using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp10FeaturesDemo
{
    public static class EmailMessages
    {
        //Old Code
        //private const string Salutation = "Welcome";
        //public static class Header
        //{
        //    public const string SalutionTeamplate = Salutation + " to constant Interpolation";
        //}

        //New Code in c#10 ver
        private const string Salutation = "Welcome";
        public static class Header
        {
            public const string SalutionTeamplate = $"{Salutation} to Interpolation";
        }
    }
    internal class ConstantInterpolatedStringsDemo
    {
        public static object Base { get;  set; } = "Some Data here";
        //Prior to C# 10, if a variable of type string was declared const we cannot use string interpolation.
        //The following statement was not valid in previous versions of C#

       // public const string GetById = $"{Base}/{{id:guid}}";

        // In order to make this work in previous versions, we had to write it like this:
       // public const string GetById = Base + "/{id:guid}";

        // However, now with C# 10, const strings may be initialized using string interpolation. So the statement below is perfectly valid in C# 10.

          //public  const string GetById = $"{Base}/{{id:guid}}";


    }
}
