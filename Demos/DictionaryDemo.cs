
Dictionary<int, string> customerNames = new Dictionary<int, string>();

//Adding Value to Dictionary
//-------------------------
customerNames.Add(1, "John Smith");
customerNames.Add(2, "Jane Doe");
customerNames.Add(3, "Bob Johnson");

//Finding the Customer with key:

int customerId = 2;
        if (customerNames.TryGetValue(customerId, out string customerName))
        {
            Console.WriteLine($"Customer with ID {customerId} is {customerName}");
        }
        else
        {
            Console.WriteLine($"Customer with ID {customerId} not found");
        }
		
		
//Getting all key and values of dictionary:
//----------------------------------------

foreach(KeyValuePair<int,string> kvp in customerNames)
        {
            Console.WriteLine($"key: {kvp.Key} , value: {kvp.Value}");
        }
		
		//Use cases of dictionary:
//Lookup tables: Dictionaries are commonly used as lookup tables where you can quickly
// find the value associated with a given key. For example, you could use a dictionary
// to store the names of countries and their corresponding ISO codes.
		
		Dictionary<string,string> countryCodes = new Dictionary<string,string>();
        countryCodes.Add("Mali", "MLI");
        countryCodes.Add("Australia", " AUS");
        countryCodes.Add("Barbados", "BRB");
        countryCodes.Add("Canada", "CAN");

        // Lookup the iso code for a country
        string isoCode = countryCodes["Barbados"];
        Console.WriteLine(isoCode);// output: BRB

        // check if a country exists or not
        if(countryCodes.ContainsKey("Canada") )
        {
            Console.WriteLine("Yes it is in dictionary");
        }
//-----------------------------------------------------------------------------
//2. Counting: Dictionaries can be used to count occurrences of items in a collection.
// For example, you could use a dictionary to count the number of times each word appears
// in a text document.

 string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ipsum dolor lorem amet";
        string[] words = Regex.Matches(text, @"\w+")
                .Cast<Match>()
                .Select(m => m.Value)
                .ToArray();

        Dictionary<string, int> wordCounts = new Dictionary<string, int>();
        foreach(string word in words)
        {
            string normalizedWord = word.ToLower();
            if(wordCounts.ContainsKey(normalizedWord) )
            {
                wordCounts[normalizedWord]++;
            }
            else
            {
                wordCounts[normalizedWord] = 1;
            }

        }

        foreach(KeyValuePair<string,int> kvp in wordCounts)
        {
            Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
        }
		
//------------------------------------------------------------------
3. Caching: Dictionaries are often used for caching frequently accessed data. For example, you could use a dictionary to cache the results of a complex calculation or a database query.

 public class Product
   {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Views { get; set; }
   }

public class ProductRepository
{
    private Dictionary<int, List<Product>> _productCache;

    public ProductRepository()
    {
        _productCache = new Dictionary<int, List<Product>>();
    }


    public List<Product> GetTop10MostViewedProducts()
    {
        if (_productCache.ContainsKey(-1))
        {
            return _productCache[-1].ToList();
        }

        // perform the expensive query to get the most viewed products
        var top10Products = new List<Product>();
        for(int i = 0; i < 10; i++)
        {
            top10Products.Add(new Product { Id = i, Name = $"product-{i}",Views= new Random().Next(0,100) });
        };

        // add the results to the cache with a special key of -1
        _productCache[-1] = top10Products;

        return top10Products;
    }
}

//------------------------------------------------------
//4. Mapping : Dictionaries can be used to map one set of values to another.
// For example, you could use a dictionary to map customer IDs to customer names.

Dictionary<int, string> customerNames = new Dictionary<int, string>();

// Add some customer ID to name mappings
customerNames.Add(1, "John Smith");
customerNames.Add(2, "Jane Doe");
customerNames.Add(3, "Bob Johnson");

// Look up a customer name by their ID
int customerId = 2;
if (customerNames.TryGetValue(customerId, out string customerName))
{
    Console.WriteLine($"Customer with ID {customerId} is {customerName}");
}
else
{
    Console.WriteLine($"Customer with ID {customerId} not found");
}
//-------------------------------------------------------
//you can find items in a dictionary in a few different ways .
myDictionary.ContainsKey(1);
string value = myDictionary[1];

// This is actually coming from the IReadOnlyDictionary interface
myDictionary.GetValueOrDefault(1);

myDictionary.TryGetValue(1, out string? value);

myDictionary.Where(m => m.Key == 1).First();

//------------------------------------------------------------
ConcurrentDictionary<int, string> concurrentDictionary = new ConcurrentDictionary<int, string>();

concurrentDictionary.AddOrUpdate(1, "value", (key, currentValue) => currentValue);
concurrentDictionary.AddOrUpdate(1, "someValue", (key, currentValue) => "valueTwo");
concurrentDictionary.AddOrUpdate(2, "someValue", (key, currentValue) => "valueTwo");
concurrentDictionary.AddOrUpdate(3, "value", (key, currentValue) => "valueTwo");
concurrentDictionary.AddOrUpdate(3, "someValue", (key, currentValue) => currentValue);


//A list of tuples can also use named values which makes it easier to keep track of
// what the values mean, as compared to a dictionary which is always named key and value. For example:
List<(int number, string item)> myTupleList = new List<(int, string)>();

myTupleList.Add((10, "socks"));

int numberOfFirstItem = myTupleList[0].number;