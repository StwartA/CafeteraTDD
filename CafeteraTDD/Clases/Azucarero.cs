
namespace CafeteraTDD.Clases
{
    public class Azucarero
    {
        public int CantidadAzucar { get; private set; }

        public Azucarero(int cantidad)
        {
            if (cantidad <= 0)
                throw new ArgumentException("Debe insertar una cantidad de azucar mayor a cero");

            CantidadAzucar = cantidad;
        }

        public bool HasAzucar(int cantidad)
        {
            return CantidadAzucar >= cantidad;
        }

        public void GiveAzucar(int cantidad)
        {
            CantidadAzucar -= cantidad;
        }

        public int GetCantidadAzucar()
        {
            return CantidadAzucar;
        }

        public void SetCantidadAzucar(int cantidad)
        {
            CantidadAzucar = cantidad;
        }

    }
}
