

namespace CafeteraTDD.Clases
{
    public class Vaso
    {
        public int CantidadVasos { get; private set; }
        public int ContenidoOz { get; private set; }

        public Vaso(int cantidadVasos, int contenido)
        {
            if (cantidadVasos <= 0)
            {
                throw new ArgumentException("La cantidad de vasos no puede ser menor a cero");
            }

            CantidadVasos = cantidadVasos;

            // Tome la iniciacitiva de usar esta validacion porque en la asignacion dice que los vasos de cafe son de 3oz, 5oz y 7oz respectivamente, pero para pasar los test dados la validacion deberia ser simplemente que sea mayor a cero.
            if (contenido is not (3 or 5 or 7)) 
            {
                throw new ArgumentException("El contenido debe ser de 3 oz, 5 oz o 7 oz");
            }
            
            ContenidoOz = contenido;
        }

        public void SetCantidadVasos(int cantidadVasos)
        {
            if (cantidadVasos <= 0)
                throw new ArgumentException("La cantidad de vasos debe ser mayor a cero");

            CantidadVasos = cantidadVasos;
        }

        public int GetCantidadVasos()
        {
            return CantidadVasos;
        }

        public void SetContenido(int contenido)
        {
            if (contenido < 3)
            {
                throw new ArgumentException("El contenido no puede ser menor a 3 oz");
            }
            ContenidoOz = contenido;
        }

        public bool HasVasos(int cantidad)
        {
            return CantidadVasos >= cantidad;
        }

        public void GiveVasos(int cantidad)
        {
            if (cantidad <= 0)
            {
                throw new ArgumentException("Debe pedir al menos 1 vaso");
            }
            CantidadVasos -= cantidad;
        }

    }
}
