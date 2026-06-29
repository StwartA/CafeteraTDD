using CafeteraTDD.Clases;

namespace CafeteraTDD.Testing
{
    public class VasoTests
    {
        [Fact]
        public void Constructor_WithValidData_ShouldCreateVaso()
        {
            Vaso vaso = new Vaso(10, 3);

            Assert.Equal(10, vaso.GetCantidadVasos());
            Assert.Equal(3, vaso.ContenidoOz);
        }

        [Fact]
        public void Constructor_WithInvalidCupAmount_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => new Vaso(0, 3));
            Assert.Throws<ArgumentException>(() => new Vaso(-1, 3));
        }

        [Fact]
        public void Constructor_WithInvalidContent_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => new Vaso(10, 1));
            Assert.Throws<ArgumentException>(() => new Vaso(10, 4));
            Assert.Throws<ArgumentException>(() => new Vaso(10, 8));
        }

        [Fact]
        public void HasVasos_WhenEnoughCups_ShouldReturnTrue()
        {
            Vaso vaso = new Vaso(10, 3);

            bool result = vaso.HasVasos(5);

            Assert.True(result);
        }

        [Fact]
        public void HasVasos_WhenNotEnoughCups_ShouldReturnFalse()
        {
            Vaso vaso = new Vaso(2, 3);

            bool result = vaso.HasVasos(5);

            Assert.False(result);
        }

        [Fact]
        public void GiveVasos_WithValidAmount_ShouldDecreaseCupAmount()
        {
            Vaso vaso = new Vaso(10, 3);

            vaso.GiveVasos(4);

            Assert.Equal(6, vaso.GetCantidadVasos());
        }

        [Fact]
        public void GiveVasos_WithInvalidAmount_ShouldThrowException()
        {
            Vaso vaso = new Vaso(10, 3);

            Assert.Throws<ArgumentException>(() => vaso.GiveVasos(0));
            Assert.Throws<ArgumentException>(() => vaso.GiveVasos(-1));
        }
    }
}