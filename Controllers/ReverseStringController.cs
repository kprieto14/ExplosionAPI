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
    public class ReverseStringController : ControllerBase
    {
        [HttpGet]
        public string Solution(string str) 
        {
            //When called, will send a string that will then be separated by character one by one and placed in an array
            char[] charArray = str.ToCharArray();
            //Reverses the array/ string
            Array.Reverse(charArray);
            //Returns now reversed string
            var newString = new string(charArray);
            return $"Here is your string reversed: {newString}";
        }
    }
}
