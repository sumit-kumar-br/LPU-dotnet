namespace CSharp11NewFeatures._3.Generics_on_Attributes;

[ValidatorAttributeBeforeFeature(typeof(object))]
public class UserBeforFeature
{

}

[ValidatorAttributeAfterFeature<UserValidator>]
public class UserAfterFeature
{

}