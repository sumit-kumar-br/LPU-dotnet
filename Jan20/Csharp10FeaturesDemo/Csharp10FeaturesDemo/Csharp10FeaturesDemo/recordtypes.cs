using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp10FeaturesDemo
{


   //C# 9 introduces records, a new reference type that you can create instead of classes or structs.
   //C# 10 adds record structs so that you can define records as value types. 
   //Records are distinct from classes in that record types use value-based equality. 
   //Two variables of a record type are equal if the record type definitions are identical, and if for every
   //field, the values in both records are equal. Two variables of a class type are equal if the objects referred
   //to are the same class type and the variables refer to the same object
    public record Customer
    {
        //record types were immutable by default, which meant that you could not change their properties once they were created.
       // C# 10 introduces a new feature that allows you to mark properties in a record as mutable.
        public string FirstName { get; init; }//To mark a property as mutable, you can use the init keyword like this

        public string LastName { get; init; }


        public sealed override string ToString()
        {
           
            return $"FirstName: {FirstName} LastName{LastName}";
        }
    }

    public record PrimeCustomer : Customer
    {
        // Trying to overide ToString() in the derived record type.
        // Error CS0239 'PrimeCustomer.ToString()': cannot override inherited member 
        // 'Customer.ToString()' because it is sealed.

        //public override string ToString()
        //{
        //    return $"FirstName: {FirstName} LastName{LastName}";
        //}
    }

    public record Product
    {
        public string Name { get; init; }
        public int CategoryId { get; init; }

        //public Product(string name, int categoryId)
        //  => (Name, CategoryId) = (name, categoryId);

        //public void Deconstruct(out string name, out int categoryId)
        //  => (name, categoryId) = (Name, CategoryId);
    }

    // Positional Records, that allows a shorter syntax by a specific position of members:
    //public record Product(string Name, int CategoryId);

    internal class RecordTypesDemo
    {
        static void Main(string[] args)
        {
            var product = new Product
            {
                Name = "VideoGame",
                CategoryId = 1
            };

            var newProduct = product with { CategoryId = 2 };

            product.Equals(newProduct); // returns false
          // product == newProduct; // returns false
            if (product == newProduct)
            {

            }

            var newAnotherProduct = new Product
            {
                Name = "VideoGame",
                CategoryId = 1
            };

            product.Equals(newAnotherProduct); // returns true
           // product == newAnotherProduct; // returns false
        }
    }
}
