using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ejercicio_evaluado
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int eleccion = 0;
            while(eleccion != 3)
            {
                Console.WriteLine("Desea: ");
                Console.WriteLine("1.- Almacenar Persona");
                Console.WriteLine("2.- Cargar Persona");
                Console.WriteLine("3.- Salir");
                eleccion = Convert.ToInt32(Console.ReadLine());

                if (eleccion == 1 || eleccion == 2)
                {
                    IFormatter formatter = new BinaryFormatter();
                    if (eleccion == 1)
                    {
                        Console.WriteLine("Ingrese nombre: ");
                        string np = Console.ReadLine();
                        Console.WriteLine("Ingrese apellido: ");
                        string ap = Console.ReadLine();
                        Console.WriteLine("Ingrese edad: ");
                        int ep = Convert.ToInt32(Console.ReadLine());
                        Persona persona = new Persona(np, ap, ep);

                        Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter.Serialize(stream, persona);
                        stream.Close();

                    }
                    else if (eleccion == 2)
                    {
                        Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read);
                        Persona personanew = (Persona)formatter.Deserialize(stream);

                        Console.WriteLine(personanew.nombre + " " + personanew.apellido + " " + personanew.edad);


                        
                    }
                }
                else
                {
                    Console.WriteLine("Opcion invalida.");
                }
            }
           
        }
    }
}
