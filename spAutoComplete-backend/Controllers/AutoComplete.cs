using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
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
    
    public class AutoComplete : ControllerBase
    {
        //
        private readonly AutoCompleteList acl = AutoCompleteList.Instance;
      
        // GET: api/<AutoComplete>

        [HttpGet]
        [EnableCors("AllowOrigin")]
        [Route("get_match")]
        
        public ActionResult<List<string>> GetMatch(string filename,string query)
        {
            this.acl.SetFileName(filename+".txt");
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
