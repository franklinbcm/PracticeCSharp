using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
  public  class Entity   
    {

        public class Dealers : Vehicle  
        {
            public string DealerName { get; set; }

            public virtual Planes MatchResult() {
                Planes model = new Planes();
                object[] fields = new object[2];
                fields[0] = "Pera";
                fields[1] = "Mango";
            


                model.AirPlane  = String.Format("The current price is {0} per ounce. {1}", fields[0], fields[1]);
         
                return model;
            }
 
        }


        public abstract class Vehicle  
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Version { get; set; }
            public decimal Capacity { get; set; }
          
        }

        public sealed class Planes
        {
            public string AirPlane { get; set; }

        }

  

    }


}
