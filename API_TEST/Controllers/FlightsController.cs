using API_TEST.Flight;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;

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
            dynamic text = System.IO.File.ReadAllText(@"C:\Users\Aviv\Desktop\newSchool\school\dotNET\API_TEST\API_TEST\DB\Raw_data OW.json");

            List<IFlight> dataArr = JsonConvert.DeserializeObject <List<IFlight>>(text);

            //Flight1 formattedData = new List<Flight1>();

            //foreach (var item in dataArr)
            //{
            //    formattedData.Add(item);
            //}

            return dataArr;
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
