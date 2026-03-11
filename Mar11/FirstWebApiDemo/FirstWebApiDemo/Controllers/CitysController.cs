using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitysController : ControllerBase
    {
        public static List<string> cityList = null;
        public CitysController()
        {
            if(cityList == null)
            {
                cityList = new List<string>()
                {
                    "Delhi",
                    "Pune",
                    "Mumbai",
                    "Chennai",
                    "Hyderabad"
                };
            }
        }
        [HttpGet]
        [Route("JoiningCity")]
        public List<string> ShowAllCitys()
        {
            return cityList;
        }

        [Route("GetCityList/{stateName}")]
        [HttpGet]
        public List<string> GetCityList(string stateName)
        {
            return cityList;
        }

        [Route("FetchAllCitys/{stateId}")]
        [HttpGet]
        public List<string> FetchAllCitys(int stateId)
        {
            return cityList;
        }

        [HttpGet]
        public int AddMe(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
