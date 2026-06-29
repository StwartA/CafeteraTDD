using CafeteraTDD.Clases;
using System;

Cafetera cafetera = new(50);
Vaso vasosPequenos = new(10, 3);
Vaso vasosMedianos = new(10, 5);
Vaso vasosGrandes = new(10, 7);
Azucarero azucarero = new(20);

MaquinaCafe maquinaCafe = new(cafetera, vasosPequenos, vasosMedianos, vasosGrandes, azucarero);

MainMenu(maquinaCafe);
static void MainMenu(MaquinaCafe maquinaCafe)
{
    while (true)
    {
        Console.WriteLine("\n** Bienvenido a la maquina de cafe **");
        Console.WriteLine("Escoge un tipo de vaso para continuar: ");
        Console.WriteLine("1 - Vaso pequeño");
        Console.WriteLine("2 - Vaso mediano");
        Console.WriteLine("3 - Vaso grande");
        Console.WriteLine("4 - Consultar cantidad de azucar");
        Console.WriteLine("5 - Consultar cantidad de cafe");
        Console.WriteLine("6 - Consultar cantidad de vasos pequeños");
        Console.WriteLine("7 - Consultar cantidad de vasos medianos");
        Console.WriteLine("8 - Consultar cantidad de vasos grandes");
        Console.WriteLine("9 - Cancelar");

        string option = Console.ReadLine() ?? string.Empty;

        switch (option)
        {
            case "1":
                Console.Clear();
                Console.Write("Bien, un vaso pequeño, cuantas cucharadas de azucar quiere? ");
                int cucharadas = Convert.ToInt32(Console.ReadLine());
                if (cucharadas > 5)
                {
                    Console.WriteLine("No puede excederse de 5 cucharadas por vaso.");
                    break;
                }
                Console.WriteLine(maquinaCafe.GetVasoCafe("pequeno", 1, cucharadas));
                break;

            case "2":
                Console.Clear();
                Console.Write("Bien, un vaso mediano, cuantas cucharadas de azucar quiere? ");
                cucharadas = Convert.ToInt32(Console.ReadLine());
                if (cucharadas > 5)
                {
                    Console.WriteLine("No puede excederse de 5 cucharadas por vaso.");
                    break;
                }
                Console.WriteLine(maquinaCafe.GetVasoCafe("pequeno", 1, cucharadas));
                break;

            case "3":
                Console.Clear();
                Console.Write("Bien, un vaso grande, cuantas cucharadas de azucar quiere? ");
                cucharadas = Convert.ToInt32(Console.ReadLine());
                if (cucharadas > 5)
                {
                    Console.WriteLine("No puede excederse de 5 cucharadas por vaso.");
                    break;
                }
                Console.WriteLine(maquinaCafe.GetVasoCafe("pequeno", 1, cucharadas));
                break;

            case "4":
                Console.Clear();
                Console.WriteLine($"La cantidad de azucar es: {maquinaCafe.azucar.CantidadAzucar}");
                break;

            case "5":
                Console.Clear();
                Console.WriteLine($"La cantidad de cafe es: {maquinaCafe.cafe.CantidadCafe}");
                break;

            case "6":
                Console.Clear();
                Console.WriteLine($"La cantidad de vasos pequeños es: {maquinaCafe.vasosPequenos.CantidadVasos}");
                break;

            case "7":
                Console.Clear();
                Console.WriteLine($"La cantidad de vasos medianos es: {maquinaCafe.vasosMedianos.CantidadVasos}");
                break;

            case "8":
                Console.Clear();
                Console.WriteLine($"La cantidad de vasos grandes es: {maquinaCafe.vasosGrandes.CantidadVasos}");
                break;

            case "9":
                Console.WriteLine("Saliendo...");
                return;

            default:
                Console.WriteLine("Inserte una opcion valida");
                break;
        }
    }
}