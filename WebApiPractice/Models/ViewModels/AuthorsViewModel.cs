using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiPractice.Models.ViewModels
{
    public class AuthorsViewModel : ValidateAuthor
    {

        public override IEnumerable<IAuthors> FindAuthor()
        {
            List<IAuthors> model = new List<IAuthors>();
            model.Add(new Authors() { AutorId =100, Autor = "Servantes", BookID = 1, Biography = "Servantes, autor reconocido mundialmente...." });
            model.Add(new Authors() { AutorId =101, Autor = "Matilde", BookID = 2, Biography = "Matilde, autor con muchos premios...." });
            model.Add(new Authors() { AutorId =102, Autor = "Spencer Johnson", BookID = 3, Biography = "Spencer Johnson, autor especialista en...." });
            model.Add(new Authors() { AutorId =103, Autor = "Gabriel García Márquez", BookID = 4, Biography = "Gabriel García Márquez, autor con muchos premios...." });
            model.Add(new Authors() { AutorId =104, Autor = "Julio Verne", BookID = 5, Biography = "Julio Verne, autor con muchos galardones...." });
            model.Add(new Authors() { AutorId =105, Autor = "Victor Hugo", BookID = 6, Biography = "Victor Hugo, autor con muchos años...." });
            model.Add(new Authors() { AutorId =106, Autor = "Martin", BookID = 7, Biography = "Martin, autor con muchos aportes...." });

            return model;
        }

        public override bool AddOrModifyAuthor(IAuthors authors)
        {
            return true;
        }

        public override bool RemoveById(int id)
        {
            return true;
        }

        public override bool SetAuthor(int id)
        {
            return true;
        }
    }
}