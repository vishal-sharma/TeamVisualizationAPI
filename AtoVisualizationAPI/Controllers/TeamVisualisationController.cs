using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtoVisualizationAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AtoVisualizationAPI.Controllers
{
    [Route("api/[controller]")]
    public class TeamVisualisationController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<TeamData> Get()
        {
            return new TeamData[]
            {
                new TeamData { TeamName = "Knights", Mood = "Happy",  },
                new TeamData { TeamName = "Hornets", Mood = "Neutral", }
            };
        }

        // GET api/<controller>/Knights
        [HttpGet("{teamName}")]
        public TeamData Get(string teamName)
        {
            switch (teamName)
            {
                case "Knights":
                    return new TeamData { TeamName = "Knights", Mood = "Happy", };
                    break;
                case "Hornets":
                    return new TeamData { TeamName = "Hornets", Mood = "Neutral", };
                    break;
            }

            return new TeamData { TeamName = "Unknown" };
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
