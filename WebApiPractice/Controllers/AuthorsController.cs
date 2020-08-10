using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using WebApiPractice.Models.ViewModels;

namespace WebApiPractice.Controllers
{
    public class AuthorsController : ApiController
    {
        [HttpGet]
        [Route("api/authors/books/{idBook}")]
        public IHttpActionResult GetAuthorBooks(int idBook)
        {
            try
            {
                var authors = (from c in new AuthorsViewModel().FindAuthor().ToList()
                               where c.BookID == idBook
                               select c);
                if (authors.Count() > 0)
                    return Ok(new { Result = "OK", Record = new JavaScriptSerializer().Serialize(authors) });
                else
                    return NotFound();

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);

            }
        }

        [HttpGet]
        [Route("api/Authors")]
        public IHttpActionResult GetAuthor()
        {
            try
            {

                var authors = new AuthorsViewModel().FindAuthor();
                if (authors.Count() > 0)
                    return Ok(new { Result = "OK", Record = new JavaScriptSerializer().Serialize(authors) });
                else
                    return NotFound();

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);

            }

        }

        [HttpGet]
        [Route("api/Authors/{id}")]
        public IHttpActionResult GetAuthorByID(int id)
        {
            try
            {
                var authors = (from c in new AuthorsViewModel().FindAuthor().ToList()
                               where c.AutorId == id select c);
                if (authors.Count() > 0)
                    return Ok(new { Result = "OK", Record = new JavaScriptSerializer().Serialize(authors) });
                else
                    return NotFound();
      
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
      
            }
            
        }



        [HttpPost]
        [Route("api/Authors/")]
        public IHttpActionResult POST([FromBody] Models.IAuthors autor)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var authors = new AuthorsViewModel().AddOrModifyAuthor(autor);
                        return Ok(authors);


                }
                catch (Exception ex)
                {
                    return InternalServerError(ex);

                }

            }
            else {

                return NotFound();
            }


        }

        [HttpPut]
        [Route("api/Authors/{id}")]
        public IHttpActionResult PUT([FromBody]  int autorId)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var authors = new AuthorsViewModel().SetAuthor(autorId);
                        return Ok(authors);

                }
                catch (Exception ex)
                {
                    return InternalServerError(ex);

                }

            }
            else
            {

                return NotFound();
            }
        }
        [HttpDelete]
        [Route("api/Authors/{id}")]
        public IHttpActionResult DELETE(int id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var authors = new AuthorsViewModel().RemoveById(id);
                    return Ok(authors);

                }
                catch (Exception ex)
                {
                    return InternalServerError(ex);

                }

            }
            else
            {

                return NotFound();
            }
        }

    }
}
