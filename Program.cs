using System;

namespace ConsoleApp1
{
    class Program
    {
        static float resultados;

        static void Main(String[] args)
        {
            int numeroAlumnos, calificacion, contador = 1;
            float promedio;
            string mostrarPromedio;
            

            Console.Write("Digite los alumnos que se van a registrar: ");
            numeroAlumnos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEmpezando... \n");

            while (contador <= numeroAlumnos)
            {
                Console.Write("Digite la calificacion de su semestre: ");
                calificacion = Convert.ToInt32(Console.ReadLine());
                resultados += calificacion;

                if (calificacion >= 80 && calificacion <= 100)
                {
                    Console.WriteLine("Obtuviste una calificacion alta!\n");
                } 
                else if (calificacion <= 79 && calificacion >= 70)
                {
                    Console.WriteLine("Obtuviste una calificion baja\n");
                }
                else if (calificacion <= 69 && calificacion >= 0)
                {
                    Console.WriteLine("Esta reprobado compadre\n");
                } 
                else
                {
                    Console.WriteLine("¡Valor incorrecto! \nVuelve a intentarlo\n");
                    numeroAlumnos += 1;
                }
                
                if (contador == numeroAlumnos)
                {
                    Console.WriteLine("\nAh terminado el proceso con exito! \n");
                    Console.Write("¿Quiere ver el promedio del grupo? (Y/n) \n=> ");
                    mostrarPromedio = Console.ReadLine();

                    if (mostrarPromedio == "Y" || mostrarPromedio == "y")
                    {
                        promedio = resultados / numeroAlumnos;
                        Console.WriteLine($"\nPromedio de grupo \n-> {promedio}");
                    } 
                    else
                    {
                        Console.WriteLine("Saliendo...");
                    }
                }
                contador++;
            }
        }
    }
}