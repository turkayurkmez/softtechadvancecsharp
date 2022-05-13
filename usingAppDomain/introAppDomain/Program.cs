// See https://aka.ms/new-console-template for more information
Console.WriteLine("App Domain bilgileri:");
AppDomain domain = AppDomain.CurrentDomain;
Console.WriteLine("\tİsim: {0}", domain.FriendlyName);
Console.WriteLine("\tKonum: {0}", domain.BaseDirectory);
Console.WriteLine("\tUygulama: {0}", domain.SetupInformation.ApplicationBase);
Console.WriteLine("\tFramework: {0}", domain.SetupInformation.TargetFrameworkName);
Console.WriteLine("\tEkli referans sayısı: {0}", domain.GetAssemblies().Length);
Console.WriteLine($"\tEkli referanslar:{domain.GetAssemblies().Select(a => a.FullName).Aggregate((a, b) => a + "\n" + b)}");

Console.WriteLine("-----------------------------------");
Console.WriteLine("Başka bir domain:");
AppDomain.CurrentDomain.ExecuteAssembly("another.exe");




