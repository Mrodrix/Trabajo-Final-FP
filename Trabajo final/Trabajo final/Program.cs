namespace Trabajo_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE GESTIÓN DEL HOTEL");
                Console.WriteLine("Seleccione una opción: ");
                Console.WriteLine("1. Gestión de Habitaciones");
                Console.WriteLine("2. Gestión de Huéspedes");
                Console.WriteLine("3. Gestión de Reservas");
                Console.WriteLine("4. Salir del Programa");

                opcion= int.Parse(Console.ReadLine());  

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
                        Console.WriteLine("Ha salido del programa");
                        break;

                    default:
                        Console.WriteLine("Ingrese una opción válida.");
                        break;
                }

            } while (opcion != 4);
        }

        // Gestión de Habitaciones
        static void GestionHabitaciones()
        {
            int opcionHabitacion;
            int MaxHabitaciones = 20;
            string[,] habitaciones = new string[MaxHabitaciones, 4];
            int cantidadHabitaciones = 0;
            
            do
            {
                Console.Clear();
                Console.WriteLine("||| GESTIÓN DE HABITACIONES |||");
                Console.WriteLine("1. Registrar nueva habitación");
                Console.WriteLine("2. Ver lista de habitaciones");
                Console.WriteLine("3. Editar información de habitación");
                Console.WriteLine("4. Ver disponibilidad");
                Console.WriteLine("5. Volver al menú principal");
                Console.Write("Seleccione una opción: ");
                opcionHabitacion = int.Parse(Console.ReadLine());

                if (opcionHabitacion == 1)
                {
                    // Registrar habitaciones
                    if (cantidadHabitaciones < MaxHabitaciones)
                    {
                        Console.WriteLine("\nRegistro de Habitación");
                        Console.Write("Número de habitación: ");
                        habitaciones[cantidadHabitaciones, 0] = Console.ReadLine();

                        Console.Write("Tipo de habitación (Simple/Familiar/Suite): ");
                        habitaciones[cantidadHabitaciones, 1] = Console.ReadLine();

                        Console.Write("Precio por noche: ");
                        habitaciones[cantidadHabitaciones, 2] = Console.ReadLine();

                        habitaciones[cantidadHabitaciones, 3] = "Sí"; 
                        cantidadHabitaciones++;

                        Console.WriteLine("\nHabitación registrada");
                    }
                    else
                    {
                        Console.WriteLine("No se pueden registrar más habitaciones.");
                    }
                }
                else if (opcionHabitacion == 2)
                {
                    // Ver lista de habitaciones
                    Console.WriteLine("\nLista de Habitaciones");
                    if (cantidadHabitaciones == 0)
                    {
                        Console.WriteLine("No se ha registrado ninguna habitacion");
                    }
                    else
                    {
                        for (int i = 0; i < cantidadHabitaciones; i++)
                        {
                            Console.WriteLine($"Habitación: {habitaciones[i, 0]} - Tipo: {habitaciones[i, 1]} - Precio: {habitaciones[i, 2]} - Disponible: {habitaciones[i, 3]}");
                        }
                    }
                }
                else if (opcionHabitacion == 3)
                {
                    // Editar habitaciones
                    Console.Write("\nIngrese el número de habitación a editar: ");
                    string numeroBuscado = Console.ReadLine();
                    bool encontrada = false;

                    for (int i = 0; i < cantidadHabitaciones; i++)
                    {
                        if (habitaciones[i, 0] == numeroBuscado)
                        {
                            encontrada = true;
                            Console.WriteLine($"Habitación encontrada: {habitaciones[i, 0]} - Tipo: {habitaciones[i, 1]} - Precio: {habitaciones[i, 2]} - Disponible: {habitaciones[i, 3]}");
                            Console.Write("Nuevo tipo de habitación: ");
                            habitaciones[i, 1] = Console.ReadLine();
                            Console.Write("Nuevo precio por noche: ");
                            habitaciones[i, 2] = Console.ReadLine();
                            Console.Write("¿Disponible? (Sí/No): ");
                            habitaciones[i, 3] = Console.ReadLine();
                            Console.WriteLine("Habitación actualizada correctamente.");
                            
                        }
                    }

                    if (encontrada == false)
                    {
                        Console.WriteLine("Habitación no encontrada.");
                    }
                }
                else if (opcionHabitacion == 4)
                {
                    // Ver disponibilidad
                    Console.WriteLine("\nHabitaciones Disponibles");
                    bool alguna = false;
                    for (int i = 0; i < cantidadHabitaciones; i++)
                    {
                        if (habitaciones[i, 3].ToLower() == "si")
                        {
                            Console.WriteLine($"Hab. {habitaciones[i, 0]} - Tipo: {habitaciones[i, 1]} - Precio: {habitaciones[i, 2]}");
                            alguna = true;
                        }
                    }

                    if (alguna == false)
                    {
                        Console.WriteLine("No hay habitaciones disponibles.");
                    }
                }
                else if (opcionHabitacion == 5)
                {
                    Console.WriteLine("Volviendo al menú principal...");
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }

                if (opcionHabitacion != 5)
                {
                    Console.WriteLine("\nENTER para continuar...");
                    Console.ReadLine(); 
                }

            } while (opcionHabitacion != 5);
        }


        // Gestión de huespedes
        static void GestionHuespedes()
        {
            int MaxHuespedes = 20;
            string[,] huespedes = new string[MaxHuespedes, 3];
            int cantidadHuespedes = 0;
            int opcionHuesped;

            do
            {
                Console.Clear();
                Console.WriteLine("||| GESTIÓN DE HUÉSPEDES |||");
                Console.WriteLine("1. Registrar nuevo huésped");
                Console.WriteLine("2. Ver lista de huéspedes");
                Console.WriteLine("3. Editar información de huésped");
                Console.WriteLine("4. Volver al menú principal");
                Console.Write("Seleccione una opción: ");
                opcionHuesped = int.Parse(Console.ReadLine());

                if (opcionHuesped == 1)
                {
                    // Registrar huespedes
                    if (cantidadHuespedes < MaxHuespedes)
                    {
                        Console.WriteLine("\nRegistro de Huésped");
                        Console.Write("Nombre: ");
                        huespedes[cantidadHuespedes, 0] = Console.ReadLine();

                        Console.Write("Documento: ");
                        huespedes[cantidadHuespedes, 1] = Console.ReadLine();

                        Console.Write("Teléfono: ");
                        huespedes[cantidadHuespedes, 2] = Console.ReadLine();

                        cantidadHuespedes++;
                        Console.WriteLine("\nHuésped registrado");
                    }
                    else
                    {
                        Console.WriteLine("No se pueden registrar más huéspedes (límite alcanzado).");
                    }
                }
                else if (opcionHuesped == 2)
                {
                    // Ver lista de huéspedes
                    Console.WriteLine("\n--- Lista de Huéspedes Registrados ---");
                    if (cantidadHuespedes == 0)
                    {
                        Console.WriteLine("No hay huéspedes registrados.");
                    }
                    else
                    {
                        for (int i = 0; i < cantidadHuespedes; i++)
                        {
                            Console.WriteLine($"{i + 1}. Nombre: {huespedes[i, 0]} - Documento: {huespedes[i, 1]} - Teléfono: {huespedes[i, 2]}");
                        }
                    }
                }
                else if (opcionHuesped == 3)
                {
                    // Editar información de huésped
                    Console.Write("\nIngrese el documento del huésped a editar: ");
                    string docBuscado = Console.ReadLine();
                    bool encontrado = false;

                    for (int i = 0; i < cantidadHuespedes; i++)
                    {
                        if (huespedes[i, 1] == docBuscado)
                        {
                            encontrado = true;
                            Console.WriteLine($"Huésped encontrado: {huespedes[i, 0]} - Documento: {huespedes[i, 1]} - Teléfono: {huespedes[i, 2]}");
                            Console.Write("Nuevo nombre: ");
                            huespedes[i, 0] = Console.ReadLine();
                            Console.Write("Nuevo teléfono: ");
                            huespedes[i, 2] = Console.ReadLine();

                            Console.WriteLine("Información actualizada");
                            
                        }
                    }

                    if (encontrado==false)
                    {
                        Console.WriteLine("No se encontró ningún huésped con ese documento.");
                    }
                }
                else if (opcionHuesped == 4)
                {
                    Console.WriteLine("Volviendo al menú principal...");
                }
                else
                {
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                }

                if (opcionHuesped != 4)
                {
                    Console.WriteLine("\nENTER para continuar...");
                    Console.ReadLine();
                }

            } while (opcionHuesped != 4);
        }

        // Gestión de reservas
        static void GestionReservas()
        {
            int opcionReserva;

            do
            {
                Console.Clear();
                Console.WriteLine("=== GESTIÓN DE RESERVAS ===");
                Console.WriteLine("1. Crear nueva reserva");
                Console.WriteLine("2. Ver reservas de una habitación");
                Console.WriteLine("3. Ver historial por huésped");
                Console.WriteLine("4. Cancelar reserva");
                Console.WriteLine("5. Volver al menú principal");
                Console.Write("Seleccione una opción: ");
                opcionReserva = int.Parse(Console.ReadLine());

                switch (opcionReserva)
                {
                    case 1:
                        Console.WriteLine("Crear reserva...");
                        break;
                    case 2:
                        Console.WriteLine("Ver reservas por habitación...");
                        break;
                    case 3:
                        Console.WriteLine("Ver historial de huésped...");
                        break;
                    case 4:
                        Console.WriteLine("Cancelar reserva...");
                        break;
                    case 5:
                        Console.WriteLine("Volviendo al menú principal...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcionReserva != 5);
        }
    }
}
