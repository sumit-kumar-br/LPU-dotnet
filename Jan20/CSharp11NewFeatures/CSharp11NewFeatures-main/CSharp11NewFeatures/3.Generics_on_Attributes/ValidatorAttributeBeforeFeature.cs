

namespace CSharp11NewFeatures._3.Generics_on_Attributes;
#region BeforeFeature

public class ValidatorAttributeBeforeFeature : Attribute
{
    public Type ValidatorType { get;}

	public ValidatorAttributeBeforeFeature(Type validatorType)
	{
		ValidatorType = validatorType;	
	}
}

#endregion