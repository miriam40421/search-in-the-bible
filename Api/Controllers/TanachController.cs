using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TanachController : ControllerBase
    {



        //[HttpGet]
        //public List<DTO_Common_enteties.location> Get()
        //{
        //    return Bll_services.Class2.loc();
        //}
        [HttpGet]
        public List<DTO_Common_enteties.Tora> Get()
        {
            return Bll_services.Class2.find("מרים");
        }

        [HttpGet("{s1},{s2}")]
        public List<DTO_Common_enteties.Tora>? Get(string s1,string s2)
        {
            return Bll_services.Class2.Chumashfind(s1,s2,"בראשית");
        }

        [HttpGet("{s}")]
        public List<string>? Get(string s)
        {
            return Bll_services.Class2.Gimatria(s);
        }
    }
}
