namespace Trabajo_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Console.WriteLine("Bienvenido al menú principal. Ingrese a la sección a la que desea ir: \n" +
                "1. Gestión de Habitaciones \n" + "2. Gestión de Huéspedes \n" + "3. Gestión de Reservas \n" + "4. Salir del Programa \n");
            opcion = Int32.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    GestionHabitaciones();
                    break;


                case 2:
                    GestionHuespedes();
                    break;


                case 3:
                    GestionReservas();
                    break;


                case 4:

                    break;


                default:
                    Console.WriteLine("Carácter NO válido, ingrese de nuevo");
                    break;

            }


            static void GestionHabitaciones()
            {
                Console.WriteLine("");
            }

            static void GestionHuespedes()
            {

            }

            static void GestionReservas()
            {

            }
        }


    }

}

