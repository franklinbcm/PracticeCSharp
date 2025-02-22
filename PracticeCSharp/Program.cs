﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace PracticeCSharp
{
   public class Program
    {
        static void Main(string[] args)
        {

            var kr = TestSingleton.LazyOb;
            var p = TestSingleton.LazyOb;

            var n = TestSingleton.MySingle;
            var q = TestSingleton.MySingle;

            //Entity.Dealers dea = new Entity.Dealers();
            //Entity.Planes pla = new Entity.Planes();

            //pla.AirPlane = "123";
            //Console.WriteLine(dea.MatchResult().AirPlane);
            //double a = 3;
            //double b = 4;
            //Console.WriteLine($"Three classical Pythagorean means of {a} and {b}:");
            //Console.WriteLine(string.Join("papa", a.ToString(),b.ToString()));
            //Console.WriteLine(string.Format("{0} {1} {2} {3} {4}", "This", "is", "a", "concatenated", "string."));
            //AnonimousMethod.MathMethod(225);
            //foreach(var item in Listas.GetListaPares())
            //Console.WriteLine(item);
            //Listas.Seriefibonacci();
            //Listas.SplitTexto();
            //Listas.GetListaPareseImpares();
            //Listas.ReverseString("HOLA MUNDO!");
            //Console.WriteLine(Singleton.MiSingle);
            //Fibonacy();

            //ConvertTexToBinary();
            // Listas.GetListaDistanciaPromedio();

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(new XmlConverter().GetXml()); //Generar XML desde una Clase
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            new XmlConverter().ConvertXmlToJson();


            Console.WriteLine(Environment.NewLine);

            Listas.InvertirVadores(3,5);
            Listas.IsCasiPalindromo();
            Listas.GetDuplicado();
            List<int> Lista = new List<int>();
            Lista.AddRange(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
           var Pares = Lista.FindAll((i) => (i % 2 == 0));
          var k =  Lista.FindAll((i) =>
            {
                if ((i % 2 == 0))
                {
                    Console.WriteLine($"Par {i}");
                    return true;
                }
                else
                {
                    Console.WriteLine($"InPar {i}");
                    return false;
                }

            });

            string Text = "Hello World";
            var ChanteText = Text.Reverse().ToArray();

            Listas.NumerosPrimos(100);

 
            Console.ReadLine();


        }
        
        public static void Fibonacy(int num = 10)
        {
  
            int ant = 0, prox = 1, aux = 0;
            
            string Result = "", rever = "Hola Don Pepito";
            for (int i = 0; i < num; i++)
            {
                aux = ant;
                ant = prox;
                prox = ant + aux;
                Result += ant.ToString() + ", ";
            }

            var final = Result;
            var re = new string (rever.Reverse().ToArray());
            
        }


        public static void ConvertTexToBinary(string Text = "A")
        {
            var dataAsciiCode = Encoding.ASCII.GetBytes(Text);//Get ASCII Code
            var binaryStr = string.Join(" ", dataAsciiCode.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0'))); //ToBinary
            Console.WriteLine(binaryStr);
            Console.ReadLine();

        }

    }
}
