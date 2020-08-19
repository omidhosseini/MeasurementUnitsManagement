using System;
using System.Threading;
using System.Threading.Tasks;
using MeasurementUnitsManagement.Models.Entities;
using MeasurementUnitsManagement.Models.Entities.UnitEnums;
using MeasurementUnitsManagement.Repository.Contracts;
using MeasurementUnitsManagement.Repository.Implements;
using MeasurementUnitsManagement.Services.Contracts;
using MeasurementUnitsManagement.Services.Implements;
using MeasurementUnitsManagement.Services.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace MeasurementUnitConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IServiceCollection services = new ServiceCollection();

            services.AddScoped<IRepository<UnitFactorModel>, Repository<UnitFactorModel>>(); 
            services.AddScoped<IRepository<UnitFactorModel>, Repository<UnitFactorModel>>();
            
            services.AddScoped<IUnitFactorRepository, UnitFactorRepository>();
            services.AddScoped<IUnitFactorService, UnitFactorService>();

            services.AddScoped<IUnitConverter, UnitConverter>();

            using var sp = services.BuildServiceProvider();
            
            var unitFactorService = sp.GetService<IUnitConverter>();


            var res = await unitFactorService.ConvertLength
                (LengthEnum.km, LengthEnum.cm, 1, CancellationToken.None);

            Console.WriteLine("Converted number : ", res);

            Console.ReadLine();
        }
    }
}