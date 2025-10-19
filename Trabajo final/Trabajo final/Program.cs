namespace Trabajo_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
        }



        static void BorrarPantalla()
        {
            Console.Clear();
        }
        static int MenuPrincipal()
        {
            char opcion = ' ';
            Console.WriteLine("Bienvenido al menú principal. Ingrese a la sección a la que desea ir: \n" +
                "1. Gestión de Habitaciones \n" + "2. Gestión de Huéspedes \n" + "3. Gestión de Reservas \n" + "4. Salir del Programa \n");

            return opcion;
        }


    }
}
