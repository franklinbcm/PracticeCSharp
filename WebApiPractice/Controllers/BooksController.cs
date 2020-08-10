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
    public class BooksController : ApiController
    {
        [HttpGet]
        [Route("api/Books")]
        public IHttpActionResult GetBooks() {
            try
            {

                var authors = new BooksViewModel().FindBooks();
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
        [Route("api/Books/{id}")]
        public IHttpActionResult GET(int id)
        {
            try
            {

                var authors = (from c in new BooksViewModel().FindBooks().ToList()
                               where c.BookID == id
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
        [HttpPost]
        [Route("api/Books/")]
        public IHttpActionResult POST([FromBody] Models.IBooks books)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var authors = new BooksViewModel().AddOrModifyBooks(books);
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
        [HttpPut]
        [Route("api/Books/{id}")]
        public IHttpActionResult PUT([FromBody]  int autorId)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var authors = new BooksViewModel().SetBooks(autorId);
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
        [Route("api/Books/{id}")]
        public IHttpActionResult DELETE(int id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var authors = new BooksViewModel().RemoveById(id);
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
