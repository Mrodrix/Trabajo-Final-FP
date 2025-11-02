namespace Trabajo_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Max_Habitaciones = 20;
            int Max_Huespedes = 20;
            int Max_Reservas = 100;

            string[,] habitaciones = new string[Max_Habitaciones, 4];
            int cantidadHabitaciones = 0;

            string[,] huespedes = new string[Max_Huespedes, 3];
            int cantidadHuespedes = 0;

            string[,] reservas = new string[Max_Reservas, 5];
            int cantidadReservas = 0;
            int opcion;


            do
            {
                Console.Clear();
                Console.WriteLine(" SISTEMA DE GESTIÓN DE HOTEL ");
                Console.WriteLine("1. Gestión de Habitaciones");
                Console.WriteLine("2. Gestión de Huéspedes");
                Console.WriteLine("3. Gestión de Reservas");
                Console.WriteLine("4. Salir del programa");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    cantidadHabitaciones = GestionHabitaciones(habitaciones, cantidadHabitaciones);
                }
                else if (opcion == 2)
                {
                    cantidadHuespedes = GestionHuespedes(huespedes, cantidadHuespedes);
                }
                else if (opcion == 3)
                {
                    cantidadReservas = GestionReservas(habitaciones, huespedes, reservas,
                                                       cantidadHabitaciones, cantidadHuespedes,
                                                       cantidadReservas);
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("Saliendo del programa");
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }

                if (opcion != 4)
                {
                    Console.WriteLine("\nENTER para volver al menú principal");
                    Console.ReadLine();
                }

            } while (opcion != 4);
        }


        // Gestión de Habitaciones
        static int GestionHabitaciones(string[,] habitaciones, int cantidadHab)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("|||GESTIÓN DE HABITACIONES|||");
                Console.WriteLine("1. Registrar nueva habitación");
                Console.WriteLine("2. Ver lista de habitaciones");
                Console.WriteLine("3. Editar habitación");
                Console.WriteLine("4. Ver disponibilidad");
                Console.WriteLine("5. Volver al menú principal");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    if (cantidadHab < 20)
                    {
                        Console.WriteLine("\nRegistro de Habitación");

                        Console.Write("Número de habitación: ");
                        habitaciones[cantidadHab, 0] = Console.ReadLine();

                        Console.Write("Tipo (Simple/Familiar/Suite): ");
                        habitaciones[cantidadHab, 1] = Console.ReadLine();

                        Console.Write("Precio por noche: ");
                        habitaciones[cantidadHab, 2] = Console.ReadLine();

                        habitaciones[cantidadHab, 3] = "si";

                        cantidadHab++;
                        Console.WriteLine("Habitación registrada con éxito!");
                    }
                    else
                    {
                        Console.WriteLine("No se pueden registrar más habitaciones.");
                    }
                }

                else if (opcion == 2)
                {
                    Console.WriteLine("\nLista de Habitaciones");
                    if (cantidadHab == 0)
                    {
                        Console.WriteLine("No hay habitaciones registradas.");
                    }
                    else
                    {
                        for (int i = 0; i < cantidadHab; i++)
                        {
                            Console.WriteLine($"Habitación: {habitaciones[i, 0]} - Tipo: {habitaciones[i, 1]} - Precio: {habitaciones[i, 2]} - Disponible: {habitaciones[i, 3]}");

                        }
                    }
                }

                else if (opcion == 3)
                {
                    Console.Write("\nNúmero de habitación a editar: ");
                    string num = Console.ReadLine();
                    bool encontrada = false;

                    for (int i = 0; i < cantidadHab; i++)
                    {
                        if (habitaciones[i, 0] == num)
                        {
                            encontrada = true;
                            Console.Write("Nuevo tipo: ");
                            habitaciones[i, 1] = Console.ReadLine();

                            Console.Write("Nuevo precio: ");
                            habitaciones[i, 2] = Console.ReadLine();

                            Console.Write("¿Disponible? (Sí/No): ");
                            habitaciones[i, 3] = Console.ReadLine();

                            Console.WriteLine("Habitación actualizada.");
                            
                        }
                    }

                    if (encontrada == false)
                    {
                        Console.WriteLine("No se encontró la habitación.");
                    }
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("\nHabitaciones Disponibles");
                    bool alguna = false;

                    for (int i = 0; i < cantidadHab; i++)
                    {
                        if (habitaciones[i, 3].ToLower() == "si")
                        {
                            Console.WriteLine($"Hab. {habitaciones[i, 0]} - {habitaciones[i, 1]} - Precio: {habitaciones[i, 2]}");
                            alguna = true;
                        }
                    }

                    if (alguna == false)
                    {
                        Console.WriteLine("No hay habitaciones disponibles.");
                    }
                }

                if (opcion != 5)
                {
                    Console.WriteLine("\nENTER para continuar");
                    Console.ReadLine();
                }

            } while (opcion != 5);

            return cantidadHab;
        }


        // Gestión de huespedes
        static int GestionHuespedes(string[,] huespedes, int cantidadHuesp)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("GESTIÓN DE HUÉSPEDES");
                Console.WriteLine("1. Registrar huésped");
                Console.WriteLine("2. Ver lista de huéspedes");
                Console.WriteLine("3. Editar información");
                Console.WriteLine("4. Volver al menú principal");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    if (cantidadHuesp < 20)
                    {
                        Console.WriteLine("\nRegistro de Huésped");

                        Console.Write("Nombre: ");
                        huespedes[cantidadHuesp, 0] = Console.ReadLine();

                        Console.Write("Documento: ");
                        huespedes[cantidadHuesp, 1] = Console.ReadLine();

                        Console.Write("Teléfono: ");
                        huespedes[cantidadHuesp, 2] = Console.ReadLine();

                        cantidadHuesp++;

                        Console.WriteLine("Huésped registrado");
                    }
                    else
                    {
                        Console.WriteLine("No se pueden registrar más huéspedes.");
                    }
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("\nLista de Huéspedes");

                    if (cantidadHuesp == 0)
                    {
                        Console.WriteLine("No hay huéspedes registrados.");
                    }

                    else
                    {
                        for (int i = 0; i < cantidadHuesp; i++)
                        {
                            Console.WriteLine($"{i + 1}. Nombre: {huespedes[i, 0]} - Documento: {huespedes[i, 1]} - Tel: {huespedes[i, 2]}");

                        }
                    }
                }

                else if (opcion == 3)
                {
                    Console.Write("\nDocumento del huésped a editar: ");
                    string doc = Console.ReadLine();
                    bool encontrado = false;

                    for (int i = 0; i < cantidadHuesp; i++)
                    {
                        if (huespedes[i, 1] == doc)
                        {
                            encontrado = true;
                            Console.Write("Nuevo nombre: ");
                            huespedes[i, 0] = Console.ReadLine();

                            Console.Write("Nuevo documento: ");
                            huespedes[i, 1] = Console.ReadLine();

                            Console.Write("Nuevo teléfono: ");
                            huespedes[i, 2] = Console.ReadLine();

                            Console.WriteLine("Datos actualizados.");
                            
                        }
                    }

                    if (encontrado == false)
                    {
                        Console.WriteLine("No se encontró ese huésped.");

                    }
                }

                if (opcion != 4)
                {
                    Console.WriteLine("\nENTER para continuar");
                    Console.ReadLine();
                }

            } while (opcion != 4);

            return cantidadHuesp;
        }

        // Gestión de reservas
        static int GestionReservas(string[,] habitaciones, string[,] huespedes, string[,] reservas, int cantidadHabitaciones, int cantidadHuespedes, int cantidadReservas)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("|||GESTIÓN DE RESERVAS|||");
                Console.WriteLine("1. Crear reserva");
                Console.WriteLine("2. Ver reservas de una habitación");
                Console.WriteLine("3. Ver historial de huésped");
                Console.WriteLine("4. Cancelar reserva");
                Console.WriteLine("5. Volver al menú principal");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Write("\nNúmero de habitación: ");
                    string habitacion = Console.ReadLine();

                    Console.Write("Documento del huésped: ");
                    string doc = Console.ReadLine();

                    bool habExiste = false;
                    bool huespExiste = false;
                    bool habDisponible = false;

                    for (int i = 0; i < cantidadHabitaciones; i++)
                    {
                        if (habitaciones[i, 0] == habitacion)
                        {
                            habExiste = true;
                            habDisponible = (habitaciones[i, 3].ToLower() == "si");
                           
                        }
                    }

                    for (int i = 0; i < cantidadHuespedes; i++)
                    {
                        if (huespedes[i, 1] == doc)
                        {
                            huespExiste = true;
                            
                        }
                    }

                    if (habExiste && huespExiste && habDisponible)
                    {
                        Console.Write("Fecha de entrada AA/MM/DD ");
                        string fecha = Console.ReadLine();

                        Console.Write("Número de noches: ");
                        string noches = Console.ReadLine();

                        reservas[cantidadReservas, 0] = habitacion;
                        reservas[cantidadReservas, 1] = doc;
                        reservas[cantidadReservas, 2] = fecha;
                        reservas[cantidadReservas, 3] = noches;
                        reservas[cantidadReservas, 4] = "Activa";
                        cantidadReservas++;

                        for (int i = 0; i < cantidadHabitaciones; i++)
                        {
                            if (habitaciones[i, 0] == habitacion)
                            {
                                habitaciones[i, 3] = "No";

                            }
                        }

                        Console.WriteLine("Reserva creada");
                    }
                    else
                    {
                        if (habExiste == false)  
                        {
                            Console.WriteLine("Habitación no registrada.");
                        }
                        else if (huespExiste == false) 
                        {
                            Console.WriteLine("Huésped no registrado.");
                        }
                        else if (habDisponible == false) 
                        {
                            Console.WriteLine("La habitación no está disponible.");
                        }
                    }
                }
                else if (opcion == 2)
                {
                    Console.Write("\nNúmero de habitación: ");
                    string num = Console.ReadLine();
                    bool alguna = false;

                    for (int i = 0; i < cantidadReservas; i++)
                        if (reservas[i, 0] == num)
                        {
                            Console.WriteLine($"Huésped: {reservas[i, 1]} - Fecha: {reservas[i, 2]} - Noches: {reservas[i, 3]} - Estado: {reservas[i, 4]}");
                            alguna = true;
                        }

                    if (alguna == false)
                    {
                        Console.WriteLine("No existen reservas para esa habitación.");

                    }
                }
                else if (opcion == 3)
                {
                    Console.Write("\nDocumento del huésped: ");
                    string doc = Console.ReadLine();
                    bool alguna = false;

                    for (int i = 0; i < cantidadReservas; i++)
                        if (reservas[i, 1] == doc)
                        {
                            Console.WriteLine($"Hab: {reservas[i, 0]} - Fecha: {reservas[i, 2]} - Noches: {reservas[i, 3]} - Estado: {reservas[i, 4]}");
                            alguna = true;
                        }

                    if (alguna == false)
                    {
                        Console.WriteLine("No existen reservas para ese huésped.");

                    }
                }
                else if (opcion == 4)
                {
                    Console.Write("\nNúmero de habitación: ");
                    string hab = Console.ReadLine();

                    Console.Write("Documento del huésped: ");
                    string doc = Console.ReadLine();

                    bool cancelada = false;

                    for (int i = 0; i < cantidadReservas; i++)
                    {
                        if (reservas[i, 0] == hab && reservas[i, 1] == doc && reservas[i, 4] == "Activa")
                        {
                            reservas[i, 4] = "Cancelada";
                            cancelada = true;

                            for (int h = 0; h < cantidadHabitaciones; h++)
                            {
                                if (habitaciones[h, 0] == hab)
                                {
                                    habitaciones[h, 3] = "Sí";

                                }
                            }
                                
                            Console.WriteLine("Reserva cancelada.");
                            
                        }
                    }

                    if (cancelada == false) 
                    {
                        Console.WriteLine("No se encontró ninguna reserva activa con esos datos.");

                    }
                }

                if (opcion != 5)
                {
                    Console.WriteLine("\nENTER para continuar");
                    Console.ReadLine();
                }

            } while (opcion != 5);

            return cantidadReservas;
        }
    }
}