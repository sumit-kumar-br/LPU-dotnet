using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Csharp10FeaturesDemo
{
    [AttributeUsage(AttributeTargets.Class)]
    public class VehicleValidatorAttribute<T, TEntity> : Attribute
    where T : class, IVehicleValidator<TEntity>
    where TEntity : class
    {
    }
    public interface IVehicleValidator<T>
    where T : class
    {
        bool IsValid(T entity);
    }

    public class CarValidator : IVehicleValidator<Car>
    {
        public bool IsValid(Car car) => car.IsConvertible;
    }

    public class TruckValidator : IVehicleValidator<Truck>
    {
        public bool IsValid(Truck entity)
        {
            throw new NotImplementedException();
        }
    }


    public static class ValidationHelper
    {
        public static IVehicleValidator<T>? GetValidator<T>()
            where T : class
        {
            var modelType = typeof(T);

            var validatorAttr = modelType
                .GetCustomAttribute(typeof(VehicleValidatorAttribute<,>));

            if (validatorAttr is not null)
            {
                var validatorType = validatorAttr
                    .GetType()
                    .GetGenericArguments()
                    .First();

                return Activator.CreateInstance(validatorType) as IVehicleValidator<T>;
            }

            return null;
        }
    }

    [VehicleValidator<CarValidator, Car>]
    public class Car
    {
        public bool IsConvertible { get; set; }
    }

    [VehicleValidator<TruckValidator,Truck>]
    public class Truck
    {
        public string? LoadCapacity { get; set; }
    }
    internal class AttribSupportGenericDemo
    {
        public static void Main()
        {
            var carValidator = ValidationHelper.GetValidator<Car>();
            var car = new Car()
            {
                IsConvertible = true
            };

            Console.WriteLine(carValidator?.IsValid(car));
        }
    }
}
