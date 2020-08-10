using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
   public static class Listas
    {
        //Numeros Pares
        public static List<int> GetListaPares()
        {
            List<int> Lista = new List<int>();
            Lista.AddRange(new[] { 1, 2, 3, 4, 5, 6,7,8,9,10 });

            List<int> numpares = Lista.FindAll(i => (i % 2) == 0); // ==>     % is equal to mod

            return numpares;

        }
        public static void InvertirVadores(int A, int B) {
            
            Console.WriteLine($"Valor Inicial A={A}, B={B}");
            A = A + B;
            B = A - B;
            A = A - B;

            Console.WriteLine($"A={A}, B={B}");
            Console.ReadLine();

        }
        public static int[] NumMasPopular()
        {
           
            int Veces = 0;
            int[] arr = new[] { 34, 31, 35, 32 };

        

            return arr;

        }

        public static bool IsCasiPalindromo(string palabra = "anana")
        {
            bool IsValid = false;
            palabra = palabra.ToLower();
            if (palabra.Length > 0)
            {
                var inverse = new string(palabra.Reverse().ToArray());
                if (palabra == inverse || palabra.Substring(0, palabra.Length - 1) == inverse.Substring(0, inverse.Length - 1))
                    IsValid = true;

            };
             
            return IsValid;

        }

        public static void FnDistanciaPromedio()
        {
            List<int[]> Lista = new List<int[]>();
            double x1=1.5, x2 = 4.2, x3 = 7.3, y1 = 0, y2 = 9, y3 = 6.2;
            var distProm = Math.Sqrt(Math.Pow((x1-y1) ,2) + Math.Pow((x2 - y2), 2)  + Math.Pow((x3 - y3) ,2));

            Console.WriteLine(distProm);
            Console.ReadLine();



        }

        public static int GetDuplicado()
        {
 

            var arr = new[] { 2, 3, 4, 3, 2, 1 };
            var ent = 3;
            int counter = 0;
            foreach (var t in arr)
            {
                if (t == ent)
                {
                    counter= counter + 1;
                }
            }

            

            return counter;

        }

        public static void GetListaPareseImpares()
        {
            List<int> Lista = new List<int>();
            Lista.AddRange(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            List<int> numpares = Lista.FindAll((i) => 
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Es Par =>" + i);
                    return true;
                }
 
                else
                {
                    Console.WriteLine("Es ImPar =>" + i);
                    return false;
                }
                    

            });  
 

        }

        public static void Seriefibonacci(int limite = 10)
        {
            int anterior=0, proximo=1, auxiliar;

            Console.WriteLine("Serie fibonacci:");
            for (int i = 0; i < limite; i++)
            {
                auxiliar = anterior;
                anterior = proximo;
                proximo = auxiliar + anterior;
                Console.WriteLine(anterior);
            }
                
 
        }
        public static void SplitTexto(string texto = "there is a cat")
        {
 
            // Split string on spaces (this will separate all the words).
            string[] words = texto.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine("WORD: " + word);
            }

        }

        public static void  ReverseString(string text)
        {
            var reverse = new string(text.Reverse().ToArray());

            Console.WriteLine("WORD: " + reverse);
        }


        public static void NumerosPrimos(int numero)
        {
            int a = 0;
            List<int> Lista = new List<int>();
 
            for (int i = 1; i < (numero + 1); i++)
            {
                if (numero % i == 0)
                {
                    a++;
                }
            }
            if (a != 2)
            {
                Lista.Add(a);
            }
            else
            {
                Lista.Add(a);
            }

            Console.WriteLine("Numeros Primos: " + Lista.ToArray().ToString());
 

        }

        enum TipoDocumento
        {
            DNI, // 0
            NIE, // 1
            Pasaporte, // 2
            Otro = 99
        };

    }
}
