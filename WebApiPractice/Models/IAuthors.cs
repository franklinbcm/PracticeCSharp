namespace WebApiPractice.Models
{
    public interface IAuthors
    {
        string Autor { get; set; }
        int BookID { get; set; }
        int AutorId { get; set; }

    }
}