using System;
using System.Linq;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el numero de autos que desea en un futuro:");
            int cantidad = int.Parse(Console.ReadLine());
            Auto[] autos = null;
            if (cantidad > 0)
            {
                autos = new Auto[cantidad];
                var ramdon = new Random();

                for (int i = 0; i < cantidad; i++){
                    Console.WriteLine($"Digite marca de auto que le gustaria tener en un futuro");
                    string marca = Console.ReadLine();
                    Console.WriteLine("El auto de marca "+ marca +" es:\nTodo terreno 1, Deportivo 2, Formal 3");
                    int valor = int.Parse(Console.ReadLine());
                    switch (valor)
                    {
                        case 1:autos[i] = new TodoTerreno(marca, false, ramdon.Next(100, 1000));
                            break;
                        case 2:autos[i] = new Deportivo(marca, "Rojo", ramdon.Next(500, 1000));
                            break;
                        case 3: autos[i] = new Formal(marca, ramdon.Next(50, 200));
                            break;
                        default:Console.WriteLine("No existe un tipo "+valor+" de auto");
                               break;
                    }
                    Console.WriteLine("\n");
                }
            }

            if(autos != null){
                //Polimorfismo, debido a que todos los autos anteriores son tratados con un mismo, objecto
                //Aquí aplica el termino:
                /*polimorfismo es la capacidad que tienen los objetos de una clase en ofrecer respuesta distinta e 
                independiente en función de los parámetros (diferentes implementaciones) utilizados durante su invocación. 
                Dicho de otro modo el objeto como entidad puede contener valores de diferentes tipos durante la ejecución 
                del programa.
                
                */
                foreach (Auto item in autos)
                {
                    Console.WriteLine();
                    item.Sonido();                    
                    Console.WriteLine("Velocalidad por segundo de "+item.Marca +": "+ item.CalculaVelocidadPorSegundo());
                    Console.WriteLine();
                    Type objecto = item.GetType();
                    Console.WriteLine("Información adicional del objecto de tipo "+objecto.Name+":");
                    string[] arr =  {
                        $"Clase base: {objecto.BaseType.Name}",
                        $"Ensanblado : {objecto.Assembly.FullName}",
                         "Guid de objecto :"+ objecto.GUID.ToString()
                    };
                    //Concatenando cadena, lo mismo que string join...
                    Console.WriteLine(arr.Aggregate("", (current, next) => current + "\n" + next));
                    Console.WriteLine("Llamada al To string de la clase:");
                    Console.WriteLine(item);
                }
            }
        }
    }
}
