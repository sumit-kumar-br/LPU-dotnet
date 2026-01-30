using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp10FeaturesDemo
{
   

    public record Person1
    {
        public string FirstName { get; init; }

        public string LastName { get; init; }

        public sealed override string ToString()
        {
            return $"My name is {FirstName} {LastName}";
        }
    }

    public record Student : Person1
    {
        //public override string ToString() // Error CS0239 'Student.ToString()': cannot override inherited member 'Person.ToString()' because it is sealed
        //{
        //    return $"My name is {FirstName} {LastName}";
        //}
    }
    internal class RecordTypeSealDemo
    {
    }
}
