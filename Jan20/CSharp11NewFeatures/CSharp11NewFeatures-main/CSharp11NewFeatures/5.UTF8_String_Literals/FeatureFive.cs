using System.Text;

namespace CSharp11NewFeatures._5.UTF8_String_Literals;

public class FeatureFive
{
    public static void FeatureExample()
    {
        ReadOnlySpan<byte> u16A = Encoding.Unicode.GetBytes("A");
        ReadOnlySpan<byte> u8A = "A"u8;
    }
}
