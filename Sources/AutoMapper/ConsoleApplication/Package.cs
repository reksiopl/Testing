namespace ConsoleApplication
{
    public class Package
    {
        public string Name { get; set; }
        public PackageType[] PackageTypeArray { get; set; }
    }

    public class PackageType
    {
        public string PackageTypeName { get; set; }
    }
}