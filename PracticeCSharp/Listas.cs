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
