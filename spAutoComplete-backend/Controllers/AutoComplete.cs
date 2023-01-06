using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using spAutoComplete.Models.autoComplete;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace spAutoComplete.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [BindProperties]
    [NoCache]
    
    

    public class AutoComplete : ControllerBase
    {
        public class NoCache : ActionFilterAttribute
        {
            public override void OnResultExecuting(ResultExecutingContext filterContext)
            {
                filterContext.HttpContext.Response.Headers["Cache-Control"] = "no-cache, no-store, must-revalidate";
                filterContext.HttpContext.Response.Headers["Expires"] = "-1";
                filterContext.HttpContext.Response.Headers["Pragma"] = "no-cache";
                filterContext.HttpContext.Response.Headers["Access-Control-Allow-Origin"]="http://localhost:4200";
                filterContext.HttpContext.Response.Headers["Access-Control-Allow-Headers"] = "Content-Type, Accept, Pragma, Cache-Control, Authorization";


                base.OnResultExecuting(filterContext);
            }
        }
        //
        private readonly AutoCompleteList acl = AutoCompleteList.Instance;

        // GET: api/<AutoComplete>

        [HttpGet]
        //[EnableCors(origins: "https://localhost:7152", headers : "AllowOrigin,AllowCredentials", methods: "*")]
        [EnableCors("AllowAll,AllowCredentials,AllowOrigin")]

        [Route("get_match")]

        public ActionResult<List<string>> GetMatch(string filename, string query)
        {
            this.acl.SetFileName(filename + ".txt");
            List<string> matches = this.acl.Match(query);

            return StatusCode(200, matches);

        }


        //// POST api/<AutoComplete>
        //[HttpPost]
        //[Route("addLIst/{listName}")]

        //// POST api/<AutoComplete>
        //[HttpPost]
        //public void add_name(string value)
        //{
        //} 
    }


}
