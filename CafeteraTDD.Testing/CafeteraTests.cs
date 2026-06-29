using CafeteraTDD.Clases;

namespace CafeteraTDD.Testing
{
    public class CafeteraTests
    {
        [Fact]
        public void Constructor_WithValidAmount_ShouldCreateCafetera()
        {
            Cafetera cafetera = new Cafetera(20);

            Assert.Equal(20, cafetera.GetCantidadCafe());
        }

        [Fact]
        public void Constructor_WithZeroOrNegativeAmount_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => new Cafetera(0));
            Assert.Throws<ArgumentException>(() => new Cafetera(-1));
        }

        [Fact]
        public void HasCafe_WhenEnoughCoffee_ShouldReturnTrue()
        {
            Cafetera cafetera = new Cafetera(20);

            bool result = cafetera.HasCafe(5);

            Assert.True(result);
        }

        [Fact]
        public void HasCafe_WhenNotEnoughCoffee_ShouldReturnFalse()
        {
            Cafetera cafetera = new Cafetera(3);

            bool result = cafetera.HasCafe(5);

            Assert.False(result);
        }

        [Fact]
        public void GiveCafe_WithValidAmount_ShouldDecreaseCoffeeAmount()
        {
            Cafetera cafetera = new Cafetera(20);

            cafetera.GiveCafe(5);

            Assert.Equal(15, cafetera.GetCantidadCafe());
        }

        [Fact]
        public void GiveCafe_WithInvalidAmount_ShouldThrowException()
        {
            Cafetera cafetera = new Cafetera(20);

            Assert.Throws<ArgumentException>(() => cafetera.GiveCafe(0));
            Assert.Throws<ArgumentException>(() => cafetera.GiveCafe(-1));
        }
    }
}