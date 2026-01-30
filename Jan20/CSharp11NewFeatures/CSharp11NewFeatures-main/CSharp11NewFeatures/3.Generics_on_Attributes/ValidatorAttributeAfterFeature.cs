namespace CSharp11NewFeatures._3.Generics_on_Attributes;

#region AfterFeature

public class ValidatorAttributeAfterFeature<TVaildator> : Attribute where TVaildator : IValidator
{
    public Type ValidatorType { get; }

    public ValidatorAttributeAfterFeature()
    {
        ValidatorType = typeof(TVaildator);
    }
}
#endregion