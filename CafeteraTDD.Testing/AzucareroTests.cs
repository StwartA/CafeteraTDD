using CafeteraTDD.Clases;

namespace CafeteraTDD.Testing
{
    public class AzucareroTests
    {
        [Fact]
        public void Constructor_WithValidAmount_ShouldCreateAzucarero()
        {
            Azucarero azucarero = new Azucarero(10);

            Assert.Equal(10, azucarero.GetCantidadAzucar());
        }

        [Fact]
        public void Constructor_WithZeroOrNegativeAmount_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => new Azucarero(0));
            Assert.Throws<ArgumentException>(() => new Azucarero(-1));
        }

        [Fact]
        public void HasAzucar_WhenEnoughSugar_ShouldReturnTrue()
        {
            Azucarero azucarero = new Azucarero(10);

            bool result = azucarero.HasAzucar(5);

            Assert.True(result);
        }

        [Fact]
        public void HasAzucar_WhenNotEnoughSugar_ShouldReturnFalse()
        {
            Azucarero azucarero = new Azucarero(3);

            bool result = azucarero.HasAzucar(5);

            Assert.False(result);
        }

        [Fact]
        public void GiveAzucar_ShouldDecreaseSugarAmount()
        {
            Azucarero azucarero = new Azucarero(10);

            azucarero.GiveAzucar(3);

            Assert.Equal(7, azucarero.GetCantidadAzucar());
        }
    }
}