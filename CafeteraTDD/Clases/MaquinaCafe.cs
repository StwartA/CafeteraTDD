
namespace CafeteraTDD.Clases
{
    public class MaquinaCafe
    {
        public MaquinaCafe(Cafetera? cafe, Vaso? vasosPequenos, Vaso? vasosMedianos, Vaso? vasosGrandes, Azucarero? azucar)
        {
            this.cafe = cafe;
            this.vasosPequenos = vasosPequenos;
            this.vasosMedianos = vasosMedianos;
            this.vasosGrandes = vasosGrandes;
            this.azucar = azucar;
        }

        public Cafetera? cafe { get; set; }
        public Vaso? vasosPequenos { get; set; }
        public Vaso? vasosMedianos { get; set; }
        public Vaso? vasosGrandes { get; set; }
        public Azucarero? azucar { get; set; }

        public Vaso? GetTipoVaso(string tipoVaso)
        {
            if (tipoVaso.Equals("pequeno", StringComparison.OrdinalIgnoreCase))
            {
                return vasosPequenos;
            }

            if (tipoVaso.Equals("mediano", StringComparison.OrdinalIgnoreCase))
            {
                return vasosMedianos;
            }

            if (tipoVaso.Equals("grande", StringComparison.OrdinalIgnoreCase))
            {
                return vasosGrandes;
            }

            return null;
        }

        public string GetVasoCafe(string tipoVaso, int cantidadVasos, int cantidadAzucar)
        {

            if (cantidadVasos <= 0)
                throw new ArgumentException("La cantidad de vasos debe ser mayor a cero");

            if (cantidadAzucar <= 0 || cantidadAzucar > 7)
                throw new ArgumentException("La cantidad de azucar no puede ser menor a cero ni tampoco puede ser demasiado excesiva");

            var vaso = GetTipoVaso(tipoVaso);

            if (vaso is null)
                throw new ArgumentException("Inserte un tipo de vaso valido");

            if (!vaso.HasVasos(cantidadVasos))
                return "No hay vasos";

            if (!cafe.HasCafe(vaso.ContenidoOz))
                return "No hay cafe";

            if (!azucar.HasAzucar(cantidadAzucar))
                return "No hay azucar";
            
            vaso.GiveVasos(cantidadVasos);

            cafe.GiveCafe(vaso.ContenidoOz);

            azucar.GiveAzucar(cantidadAzucar);

            return "Felicitaciones";

        }

    }
}
