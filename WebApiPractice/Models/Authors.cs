using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiPractice.Models
{
    public class Authors : IAuthors
    {

        public string Autor { get; set; }
        public string Biography { get; set; }
        public int BookID { get; set; }
        public int AutorId { get; set; }

        public Authors()
        {
            Autor = string.Empty;
            Biography = string.Empty;
            BookID = 0;
            AutorId = 0;
        }
    }
    public abstract class ValidateAuthor
    {
        public abstract bool AddOrModifyAuthor(IAuthors authors);

        public abstract IEnumerable<IAuthors> FindAuthor();

        public abstract bool SetAuthor(int id);

        public abstract bool RemoveById(int id);

    }


}