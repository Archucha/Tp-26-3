using System;

namespace Tp_26_3
{
    public class Carrera
    {
        public int[] NroParticipante;
        public string[] Nombre;
        public string[] Apellido;
        public double[] Tiempo;
        public int[] Altura;
        public int[] Categoria;
        public int i = 0;
        public double mejtiempo = 9999999999999999;
        public int posi;
        public void Carga()
        {
            int j = 1;
            do
            {
                Console.WriteLine("Ingrese el numero del participante");
                Console.WriteLine("0 para salir");
                NroParticipante[i] = int.Parse(Console.ReadLine());
                if (NroParticipante[i] != 0)
                {
                    Console.WriteLine("Ingrese el nombre");
                    Nombre[i] = Console.ReadLine();
                    Console.WriteLine("Ingrese el apellido");
                    Apellido[i] = Console.ReadLine();
                    Console.WriteLine("Ingrese el tiempo");
                    Tiempo[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura en centimetrosm");
                    Altura[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la categoria 2007-2006-2005");
                    Categoria[i] = int.Parse(Console.ReadLine());
                    i++;

                }
                else
                {
                    j = 0;
                }
            }
            while (j != 0);
        }
        public void MuestraMejTiemp()
        {
            for (int p = 0; p < i; p++)
            {
                if (mejtiempo < Tiempo[p])
                {
                    mejtiempo = Tiempo[p];
                    posi = p;
                }
            }
            Console.WriteLine("El mejor tiempo lo tiene");
            Console.WriteLine("Numero de participante:" + NroParticipante[posi]);
            Console.WriteLine("Nombre:" + Nombre[posi]);
            Console.WriteLine("Apellido:" + Apellido[posi]);
            Console.WriteLine("Tiempo:" + Tiempo[posi]);
            Console.WriteLine("Categoria:" + Categoria[posi]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
