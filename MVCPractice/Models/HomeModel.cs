using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MVCPractice.Models
{
    public class HomeModel
    {
 
        
        public class DocumentF101
        {
            [DisplayName("DocumentID")]
            [MaxLength(11)]
            [MinLength(11)]
            public string DocumentID { get; set; }

            [DisplayName("Nombre")]
            [MaxLength(30)]
            public string Name { get; set; }
            
        }
    }
}