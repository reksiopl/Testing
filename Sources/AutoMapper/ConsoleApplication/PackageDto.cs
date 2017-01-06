namespace ConsoleApplication
{
    public class PackageDto
    {
        public string Name { get; set; }
        public PackageTypeDto[] PackageTypeArray { get; set; }

    }
    public class PackageTypeDto
    {
        public string PackageTypeName { get; set; }
    }
}