using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiPractice.Models
{
    public class Books : IBooks
    {
        public Books()
        {
            Name = string.Empty;
            Published = null;
            Version = string.Empty;
            BookID = 0;
        }
        public string Name { get; set; }
        public DateTime? Published { get; set; }
        public string Version { get; set; }  
        public int BookID { get; set; }

        public abstract class ValidateBooks
        {
            public abstract bool AddOrModifyBooks(IBooks authors);

            public abstract IEnumerable<IBooks> FindBooks();

            public abstract bool SetBooks(int id);

            public abstract bool RemoveById(int id);

        }
    }
}