using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
  public static  class AnonimousMethod
    {

        // Métodos anónimos:

        //Un método anónimo es un método, el cual carece de un nombre.
        //Lo que contiene es el cuerpo del propio método que es lo que ejecutaremos.De hecho, un método anónimo nos ofrece la 
        //posibilidad de pasar un bloque de código como un parámetro de delegado.
        //Los métodos anónimos crearán instancias de delegados, reduciendo así la sobrecarga.
        //Para lograr todo esto, declararemos el delegado y su firma, y posteriormente indicaremos el código del mismo.
        //También debemos tener en cuenta que no tenemos porqué especificar el tipo de dato que devolverá, ya que será inferido dentro del 
        //cuerpo del método que lancemos.

        private delegate double Mathematical(double value);

        public static void MathMethod(Double param)
        {
            Mathematical met = delegate (Double value) { return param * param; };
            Console.WriteLine("MathMethod=" + met(param));
        }
    }
}
