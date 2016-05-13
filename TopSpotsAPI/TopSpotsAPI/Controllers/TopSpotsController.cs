using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TopSpotsAPI.Models;

namespace TopSpotsAPI.Controllers
{   [EnableCors(origins: "*", headers: "*", methods:"*")]
    public class TopSpotsController : ApiController
    {


        // GET: api/TopSpots
        public IEnumerable<TopSpot> Get()
        {
            string json = File.ReadAllText(@"C:\dev\spots.json");
            TopSpot[] result = Newtonsoft.Json.JsonConvert.DeserializeObject<TopSpot[]>(json);
            return result;


        }

            

        // GET: api/TopSpots/5
        public TopSpot Get(int id)
        {
            return new TopSpot
            {
    
        };
        }

        // POST: api/TopSpots
        public TopSpot Post(TopSpot topspot)
        {
            string json = File.ReadAllText(@"C:\dev\spots.json");
            TopSpot[] result = Newtonsoft.Json.JsonConvert.DeserializeObject<TopSpot[]>(json);
            List<TopSpot> NewTopSpot = new List<TopSpot>(result);
            NewTopSpot.Add(topspot);
            string a = Newtonsoft.Json.JsonConvert.SerializeObject(NewTopSpot);
            File.WriteAllText(@"C:\dev\spots.json", a);
            return topspot;

            
        }

        // PUT: api/TopSpots/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TopSpots/5
        public void Delete(int id)
        {
        }
    }
}
