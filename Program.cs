using System;

namespace examen
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta, camion;
            double km, acu, acu2, total, total2, suma, suma2, km2, totalganancia, acutotal, totalganancia2;
            int c, c2;
            c = 0;
            c2 = 0;
            acu = 0;
            acu2 = 0;
            total = 0;
            total2 = 0;

            Console.WriteLine("Ingresar si quiere iniciar la operación");
            respuesta = string.Format(Console.ReadLine());
            while (respuesta == "si")
            {
                Console.WriteLine("¿Qué camión eligió?(camion1 o camio2)");
                camion = string.Format(Console.ReadLine());
                if (camion == "camion1")
                {
                    Console.WriteLine("Ingresar los km recorridos");
                    km = double.Parse(Console.ReadLine());
                    acu = acu + km;
                    c = c + 1;
                    suma = km * 35;
                    total = total + suma;
                    Console.WriteLine("¿Quiere repetir la operación?");
                    respuesta = Console.ReadLine();
                }
                if (camion == "camion2")
                {
                    Console.WriteLine("Ingresar los km recorridos");
                    km2 = double.Parse(Console.ReadLine());
                    acu2 = acu2 + km2;
                    c2 = c2 + 1;
                    suma2 = km2 * 35;
                    total2 = total2 + suma2;
                    Console.WriteLine("¿Quiere repetir la operación?");
                    respuesta = Console.ReadLine();
                }
            }
            acutotal = acu + acu2;
            totalganancia = total + total2;
            if (acutotal > 500)
            {
                totalganancia2 = totalganancia + 3000;
                Console.WriteLine("El total de la ganancias es:"+ totalganancia2);
                Console.WriteLine("Las veces que anduvo el Camion 1 es:"+ c);
                Console.WriteLine("Las veces que anduvo el Camión 2 es:"+ c2);
                Console.WriteLine("El Camión 1 recorrió:"+ acu + "km");
                Console.WriteLine("El Camión 2 recorrió:"+ acu2 + "km");
                Console.WriteLine("El Camión 1 generó:"+ total + "$");
                Console.WriteLine("El Camión 2 generó:"+ total2 + "$");
            }else
            {
                Console.WriteLine("El total de la ganancias es:"+ totalganancia);
                Console.WriteLine("Las veces que anduvo el Camión 1 es:"+ c);
                Console.WriteLine("Las veces que anduvo el Camión 2 es:"+ c2);
                Console.WriteLine("El Camión 1 recorrió:"+ acu + "km");
                Console.WriteLine("El Camión 2 recorrió:"+ acu2+ "km");
                Console.WriteLine("El Camión 1 generó:"+ total + "$");
                Console.WriteLine("El Camión 2 generó:"+ total2 + "$");
            }
        }
    }
}
