using NUnit.Framework;
using AutoMart;

namespace AutoMart.Tests
{
    [TestFixture]
    public class CarUtilityTests
    {
        private CarUtility _carUtility;

        [SetUp]
        public void Setup()
        {
            _carUtility = new CarUtility();
        }

        [Test]
        [TestCase("A3", true)]
        [TestCase("Q5", true)]
        [TestCase("R8", false)] // Invalid Model
        public void ValidateCarModel_ShouldReturnCorrectValidity(string model, bool expected)
        {
            _carUtility.Model = model;
            Assert.That(_carUtility.ValidateCarModel(), Is.EqualTo(expected));
        }

        [Test]
        [TestCase("Sedan", 1000000, 950000)] // 5% Discount
        [TestCase("SUV", 2000000, 1800000)]   // 10% Discount
        [TestCase("Hatchback", 500000, 500000)] // No Discount
        public void PriceCalculation_ShouldApplyCorrectDiscount(string bodyStyle, double inputPrice, double expectedDiscountedPrice)
        {
            _carUtility.BodyStyle = bodyStyle;
            _carUtility.Price = inputPrice;

            var result = _carUtility.PriceCalculation();

            Assert.That(result.Price, Is.EqualTo(expectedDiscountedPrice));
        }

        [Test]
        [TestCase(950000, 997500)]    // 5% Tax (< 1M)
        [TestCase(1500000, 1620000)]  // 8% Tax (1M - 2M)
        [TestCase(3000000, 3450000)]  // 15% Tax (> 2M)
        public void CalculateFinalPriceWithTax_ShouldApplyCorrectTaxSlab(double discountedPrice, double expectedFinalPrice)
        {
            double actualFinalPrice = _carUtility.CalculateFinalPriceWithTax(discountedPrice);
            Assert.That(actualFinalPrice, Is.EqualTo(expectedFinalPrice));
        }
    }
}
