using System;
using System.Linq;
using AutoMapper;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoMapperConfigure();

            Mapper.AssertConfigurationIsValid();

            // Create type Package
            var package = new Package
                {
                    Name = "Paczka1",
                    PackageTypeArray = new[] { new PackageType { PackageTypeName = "PackageTypeName1" } }
                };

            var packageDto = Mapper.Map<Package, PackageDto>(package);


            Console.WriteLine(packageDto.Name);
            Console.WriteLine(packageDto.PackageTypeArray.First().PackageTypeName);

        }

        private static void AutoMapperConfigure()
        {
            // Create configuration for automapper
            Mapper.CreateMap<Package, PackageDto>();
            Mapper.CreateMap<PackageDto, Package>();
            Mapper.CreateMap<PackageType, PackageTypeDto>();
            Mapper.CreateMap<PackageTypeDto, PackageType>();
        }
    }
}
