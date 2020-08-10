using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using static WebApiPractice.Models.Books;

namespace WebApiPractice.Models.ViewModels
{
    public class BooksViewModel : ValidateBooks
    {

        public override bool AddOrModifyBooks(IBooks authors)
        {
            return true;
        }

        public override IEnumerable<IBooks> FindBooks()
        {
            List<IBooks> model = new List<IBooks>();
            model.Add(new Books() {Name = "Quijote de la Mancha", BookID = 1, Version = "2.0.1", Published = DateTime.Parse("1995-12-01", new CultureInfo("es-DO")) });
            model.Add(new Books() {Name = "Blanca Nieves", BookID = 2, Version = "1.0.1", Published = DateTime.Parse("1999-08-01", new CultureInfo("es-DO")) });
            model.Add(new Books() {Name = "El Condor pasa", BookID = 3, Version = "1.0.1", Published = DateTime.Parse("1995-12-01", new CultureInfo("es-DO")) });
            model.Add(new Books() {Name = "La Pereza", BookID = 4, Version = "1.1.1", Published = DateTime.Parse("1993-11-15", new CultureInfo("es-DO")) });
            model.Add(new Books() {Name = "Viaje al centro de la Tierra", BookID = 5, Version = "1.1.1", Published = DateTime.Parse("1985-09-16", new CultureInfo("es-DO")) });
            model.Add(new Books() {Name = "Los miserables", BookID = 6, Version = "1.1.1", Published = DateTime.Parse("1998-07-03", new CultureInfo("es-DO")) });
            model.Add(new Books() {Name = "Clean Code", BookID = 7, Version = "1.1.1", Published = DateTime.Parse("1994-03-09", new CultureInfo("es-DO")) });

            return model;
        }

        public override bool RemoveById(int id)
        {
            return true;
        }

        public override bool SetBooks(int id)
        {
            return true;
        }
    }
}