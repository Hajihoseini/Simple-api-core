using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWeb_API.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb_API.Controllers
{
    [ApiController]
    [Route("api/TopMovies")]
    public class TopMoviesController : ControllerBase
    {
        private List<JamesBond> jamesBond = new()
        {
            new JamesBond(1, "GoldenEye", 1995),
            new JamesBond(2, "Skyfall", 2012),
            new JamesBond(3, "Spectre", 2015),
            new JamesBond(4, "Octopussy", 1983),
            new JamesBond(5, "Moonraker", 1979),
            new JamesBond(6, "Goldfinger", 1964),
        };

        [HttpGet]
        public List<JamesBond> GetMovieName()
        {
            return jamesBond;
        }


        [HttpGet("{id}")]
        public JamesBond GetMovieNameByID(int id)
        {
            return jamesBond.Find(i=>i.Id == id);
        }

        [HttpPost]
        public List<JamesBond> AddNewMove(JamesBond jamesBond)
        {
            this.jamesBond.Add(jamesBond);
            return this.jamesBond;
        }

    }
}
