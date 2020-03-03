namespace Cinema.DataProcessor
{
    using System;
    using System.Linq;
    using Cinema.DataProcessor.ExportDto;
    using Data;
    using Newtonsoft.Json;

    public class Serializer
    {
        public static string ExportTopMovies(CinemaContext context, int rating)
        {
            var movies = context.Movies
                .Where(m => m.Rating >= rating && m.Projections.Any(p => p.Tickets.Count > 0))
                .OrderByDescending(m => m.Rating)
                .ThenByDescending(m => m.Projections.Sum(p => p.Tickets.Sum(t => t.Price)))
                .Select(m => new MovieExportDto
                {
                    MovieName = m.Title,
                    Rating = m.Rating.ToString("F2"),
                    TotalIncomes = m.Projections.Sum(p => p.Tickets.Sum(t => t.Price)).ToString("F2"),
                    Customers = m.Projections
                        .SelectMany(p => p.Tickets)
                                .Select(c => new CustomerMovieExportDto
                                {
                                    FirstName = c.Customer.FirstName,
                                    LastName = c.Customer.LastName,
                                    Balance = c.Customer.Balance.ToString("F2")
                                })
                                //TODO Balance
                                .OrderByDescending(c => c.Balance)
                                .ThenBy(c => c.FirstName)
                                .ThenBy(c => c.LastName)
                                .ToList()
                })
                .Take(10)
                .ToList();

            var res = JsonConvert.SerializeObject(movies, Formatting.Indented);
            return res;
        }

        public static string ExportTopCustomers(CinemaContext context, int age)
        {
            context.Customers.Select(e => new
            {
                SpendTime = new DateTime(e.Tickets.Sum(t => t.Projection.Movie.Duration.Ticks)).ToString(@"hh\:mm\:ss")
            });

            return null;
        }
    }
}