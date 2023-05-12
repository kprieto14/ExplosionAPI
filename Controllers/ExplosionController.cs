using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExplosionController : ControllerBase
    {
        [HttpGet]
        public string Explode(string str)
        {
            str = str.Replace("0","");
            str = str.Replace("2","22");
            str = str.Replace("3","333");
            str = str.Replace("4","4444");
            str = str.Replace("5","55555");
            str = str.Replace("6","666666");
            str = str.Replace("7","7777777");
            str = str.Replace("8","88888888");
            str = str.Replace("9","999999999");
            
            return $"Here is your new number: {str}";
        }
    }
}
