using Clase4.Models;


namespace Proyecto1.Services;
public static class MovieService
{
    static List<Movie> Movies { get; set; }

    static MovieService()
    {
        Movies = new List<Movie>{
            new Movie{Name = "A Space Oddysey", Code = "KubASO", Category="Sci fi", Minutes = 149},
            new Movie{Name = "Pineapple Express", Code = "DvgPE", Category="Comedy", Minutes = 111, Review="Cool af"},
            new Movie{Name = "Seven Samurai", Code = "KurSS", Category="Action", Minutes = 207},
            new Movie{Name = "The Dark Night", Code = "CnTDK", Category="Action", Minutes = 152},
            new Movie{Name = "Seven Pschopaths", Code = "MmSP", Category="Crime", Minutes = 110},
            new Movie{Name = "El Secreto De Sus Ojos", Code = "JjcESDSU", Category="Drama", Minutes = 130},
            new Movie{Name = "Fargo", Code = "JeCFAR", Category="Crime", Minutes = 98}

        };
    }

    public static List<Movie> GetAll() => Movies;

    // Add
    public static void Add(Movie newMovie)
    {
        if (newMovie == null)
        {
            return;
        }

        Movies.Add(newMovie);
    }

    //Delete
    public static void Delete(string code)
    {
        var movieToDelete = Get(code);

        if (movieToDelete != null)
        {
            Movies.Remove(movieToDelete);
        }
    }


    //Update

    //Get
    public static Movie? Get(string code) => Movies.FirstOrDefault(m => m.Code.ToLower() == code.ToLower());

}