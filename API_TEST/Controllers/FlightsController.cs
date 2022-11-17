using API_TEST.Flight;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_TEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        // GET: api/<FlightsController>
        [HttpGet]
        public dynamic Get()
        {
            string DB1 = System.IO.File.ReadAllText(@"C:\Users\Aviv\Desktop\newSchool\school\dotNET\API_TEST\API_TEST\DB\Raw_data OW.json");
            string DB2 = System.IO.File.ReadAllText(@"C:\Users\Aviv\Desktop\newSchool\school\dotNET\API_TEST\API_TEST\DB\Raw_data OW - 2pax .json");
            string DB3 = System.IO.File.ReadAllText(@"C:\Users\Aviv\Desktop\newSchool\school\dotNET\API_TEST\API_TEST\DB\Raw_data RT - 2pax .json");

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            var dataArr = JsonConvert.DeserializeObject<dynamic[]>(DB1, settings);

            IFlight[] formattedArr = new IFlight[dataArr.Length];



            for (int i = 0; i < dataArr.Length; i++)
            {
                formattedArr[i] = new IFlight(dataArr[i]);
            }



            return formattedArr;
        }


        //// GET api/<FlightsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<FlightsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<FlightsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<FlightsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }

}


