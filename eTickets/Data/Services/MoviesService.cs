using eTickets.Data.Base;
using eTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class MoviesService:EntityBaseRepository<Movie>, IMoviesService
    {
        public MoviesService(AppDbContext context):base(context)
        {
        }
    }
}
