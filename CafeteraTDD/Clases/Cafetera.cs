

namespace CafeteraTDD.Clases
{
    public class Cafetera
    {
        public int CantidadCafe { get; private set; }

        public Cafetera(int cantidadCafe)
        {
            if (cantidadCafe <= 0)
                throw new ArgumentException("La cantidad de cafe no puede ser menor a cero");

            CantidadCafe = cantidadCafe;
        }

        public bool HasCafe(int cantidad)
        {
            return CantidadCafe >= cantidad;
        }

        public void GiveCafe(int cantidad)
        {
            if (cantidad <= 0)
                throw new ArgumentException("Debe insertar una cantidad de cafe valida");
            
            CantidadCafe -= cantidad;

        }

        public int GetCantidadCafe()
        {
            return CantidadCafe;
        }
    }
}
