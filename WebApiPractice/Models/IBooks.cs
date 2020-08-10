using System;

namespace WebApiPractice.Models
{
    public interface IBooks
    {
        int BookID { get; set; }
        string Name { get; set; }
        DateTime? Published { get; set; }
        string Version { get; set; }
    }
}