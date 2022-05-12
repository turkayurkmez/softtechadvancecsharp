using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Display.SDK
{
    public class Helper
    {
        public static List<Plug> GetPlugins(string selectedPath)
        {
            if (string.IsNullOrEmpty(selectedPath))
            {
                throw new ArgumentException(nameof(selectedPath));
            }

            if (!Directory.Exists(selectedPath))
            {
                throw new FileNotFoundException($"{selectedPath} klasörü bulunamadı");
            }

            var plugs = GetPluginsInPath(selectedPath);
            return plugs;
        }

        private static List<Plug> GetPluginsInPath(string selectedPath)
        {
            var dllFiles = Directory.GetFiles(selectedPath, "*.dll");
            var plugs = new List<Plug>();
            dllFiles?.ToList().ForEach(file => AddReference(file, plugs));
            return plugs;

        }

        private static void AddReference(string file, List<Plug> plugs)
        {
            var assembly = Assembly.LoadFile(file);
            var types = assembly.GetTypes();
            types?.ToList().ForEach(type =>
            {
                Plug plug = handShakeForApp(type, file);
                if (plug != null)
                {
                    plugs.Add(plug);
                }

            });

        }

        public static object CreateInstance(Plug plug)
        {
            Assembly assembly = Assembly.LoadFile(plug.Path);
            var instance = assembly.CreateInstance(plug.FullName);
            return instance;
        }

        private static Plug handShakeForApp(Type type, string file)
        {
            Plug plug = null;
            if (type.GetInterface("IPlug") != null)
            {
                plug = new Plug();
                plug.Path = file;
                plug.FullName = type.FullName;

                //var instance = Activator.CreateInstance(type);
                //plug.Name = instance.GetType().GetProperty("Name").GetValue(instance).ToString();

                dynamic instance2 = Activator.CreateInstance(type);
                plug.Name = instance2.Name;
                

                // TODO 1: Name özelliği burada get edilecek.
                //#error "Unutma"

            }
            return plug;
        }
    }
}
