using System.Text;

namespace CSharp11NewFeatures._1.Raw_String_Literals;

public class FeatureOne
{
    public static void BeforeFeature()
    {
        var sb = new StringBuilder();
        var xmlText = "<?xml version=\"1.0\"  encoding=\"UTF-8\"?>";
        var jsonText = "{\n  \"name\": \"Muhammad Jamal\" \n}";
        //anthor solution : @""<?xml version=\"1.0\"  encoding=\"UTF-8\"?>""
        sb.AppendLine(xmlText);
        Console.WriteLine(sb.ToString());
        Console.WriteLine(jsonText);
    }
    public static void AfterFeature()
    {
        var sb = new StringBuilder();
        var xmlText = """<?xml version="1.0"  encoding="UTF-8"?>""";
        var jsonText = """
                        {
                            "name" : "Muhammad Jamal"
                        }
                        """;
        sb.AppendLine(xmlText);
        Console.WriteLine(sb.ToString());
        Console.WriteLine(jsonText);
    }
}
