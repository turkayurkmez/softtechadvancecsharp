namespace DeveloperLibrary
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class DeveloperInfoAttribute : Attribute
    {
        public string Name { get; set; }
        public string CreatedDate { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public DeveloperInfoAttribute(string name)
        {
            Name = name;
            Version = "1.0";
        }
    }
}