using CafeteraTDD.Clases;

namespace CafeteraTDD.Testing
{
    public class MaquinaCafeTests
    {
        private MaquinaCafe CrearMaquina()
        {
            Cafetera cafetera = new Cafetera(50);
            Vaso vasosPequenos = new Vaso(5, 3);
            Vaso vasosMedianos = new Vaso(5, 5);
            Vaso vasosGrandes = new Vaso(5, 7);
            Azucarero azucarero = new Azucarero(20);

            return new MaquinaCafe(
                cafetera,
                vasosPequenos,
                vasosMedianos,
                vasosGrandes,
                azucarero
            );
        }

        [Fact]
        public void GetTipoVaso_WhenTypeIsPequeno_ShouldReturnSmallCup()
        {
            MaquinaCafe maquina = CrearMaquina();

            Vaso? vaso = maquina.GetTipoVaso("pequeno");

            Assert.NotNull(vaso);
            Assert.Equal(3, vaso.ContenidoOz);
        }

        [Fact]
        public void GetTipoVaso_WhenTypeIsMediano_ShouldReturnMediumCup()
        {
            MaquinaCafe maquina = CrearMaquina();

            Vaso? vaso = maquina.GetTipoVaso("mediano");

            Assert.NotNull(vaso);
            Assert.Equal(5, vaso.ContenidoOz);
        }

        [Fact]
        public void GetTipoVaso_WhenTypeIsGrande_ShouldReturnLargeCup()
        {
            MaquinaCafe maquina = CrearMaquina();

            Vaso? vaso = maquina.GetTipoVaso("grande");

            Assert.NotNull(vaso);
            Assert.Equal(7, vaso.ContenidoOz);
        }

        [Fact]
        public void GetTipoVaso_WhenTypeIsInvalid_ShouldReturnNull()
        {
            MaquinaCafe maquina = CrearMaquina();

            Vaso? vaso = maquina.GetTipoVaso("extra grande");

            Assert.Null(vaso);
        }

        [Fact]
        public void GetVasoCafe_WithValidData_ShouldReturnFelicitaciones()
        {
            MaquinaCafe maquina = CrearMaquina();

            string result = maquina.GetVasoCafe("pequeno", 1, 2);

            Assert.Equal("Felicitaciones", result);
        }

        [Fact]
        public void GetVasoCafe_WhenNotEnoughCups_ShouldReturnNoHayVasos()
        {
            MaquinaCafe maquina = CrearMaquina();

            string result = maquina.GetVasoCafe("pequeno", 10, 2);

            Assert.Equal("No hay vasos", result);
        }

        [Fact]
        public void GetVasoCafe_WhenNotEnoughCoffee_ShouldReturnNoHayCafe()
        {
            Cafetera cafetera = new Cafetera(2);
            Vaso vasosPequenos = new Vaso(5, 3);
            Vaso vasosMedianos = new Vaso(5, 5);
            Vaso vasosGrandes = new Vaso(5, 7);
            Azucarero azucarero = new Azucarero(20);

            MaquinaCafe maquina = new MaquinaCafe(
                cafetera,
                vasosPequenos,
                vasosMedianos,
                vasosGrandes,
                azucarero
            );

            string result = maquina.GetVasoCafe("pequeno", 1, 2);

            Assert.Equal("No hay cafe", result);
        }

        [Fact]
        public void GetVasoCafe_WhenNotEnoughSugar_ShouldReturnNoHayAzucar()
        {
            Cafetera cafetera = new Cafetera(50);
            Vaso vasosPequenos = new Vaso(5, 3);
            Vaso vasosMedianos = new Vaso(5, 5);
            Vaso vasosGrandes = new Vaso(5, 7);
            Azucarero azucarero = new Azucarero(1);

            MaquinaCafe maquina = new MaquinaCafe(
                cafetera,
                vasosPequenos,
                vasosMedianos,
                vasosGrandes,
                azucarero
            );

            string result = maquina.GetVasoCafe("pequeno", 1, 2);

            Assert.Equal("No hay azucar", result);
        }

        [Fact]
        public void GetVasoCafe_WithInvalidCupAmount_ShouldThrowException()
        {
            MaquinaCafe maquina = CrearMaquina();

            Assert.Throws<ArgumentException>(() => maquina.GetVasoCafe("pequeno", 0, 2));
        }

        [Fact]
        public void GetVasoCafe_WithInvalidSugarAmount_ShouldThrowException()
        {
            MaquinaCafe maquina = CrearMaquina();

            Assert.Throws<ArgumentException>(() => maquina.GetVasoCafe("pequeno", 1, 0));
            Assert.Throws<ArgumentException>(() => maquina.GetVasoCafe("pequeno", 1, 8));
        }

        [Fact]
        public void GetVasoCafe_WithInvalidCupType_ShouldThrowException()
        {
            MaquinaCafe maquina = CrearMaquina();

            Assert.Throws<ArgumentException>(() => maquina.GetVasoCafe("extra grande", 1, 2));
        }

        [Fact]
        public void GetVasoCafe_WithValidData_ShouldDecreaseResources()
        {
            MaquinaCafe maquina = CrearMaquina();

            maquina.GetVasoCafe("pequeno", 1, 2);

            Assert.Equal(4, maquina.vasosPequenos!.GetCantidadVasos());
            Assert.Equal(47, maquina.cafe!.GetCantidadCafe());
            Assert.Equal(18, maquina.azucar!.GetCantidadAzucar());
        }
    }
}