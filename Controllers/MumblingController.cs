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
    public class MumblingController : ControllerBase
    {
        [HttpGet]
        public string Accum(string str) 
        {
            //Creates a new list that will house our string into separate letters
            var sentenceList = new List<string>();

            //Goes through each letter, and adds them to list above
            for(var letter = 0; letter < str.Count(); letter++)
            {
                sentenceList.Add(str[letter].ToString().ToUpper());
            }

            //Goes through the list one letter at a time skipping the first letter in the list
            for(var count = 1; count < sentenceList.Count(); count++)
            {
                for(var letterCount = 0; letterCount < count; letterCount++)
                {
                    string newLetters = sentenceList[count];
                    //Trying to add letters to the end of the list that is equivalent to the number but also keeping the first letter capitalized
                    if(letterCount > 0)
                    {
                        sentenceList[count] = newLetters + newLetters[newLetters.Count() - 1 ].ToString();
                    }
                    //Only adds a letter that is lowercase once to the letter to ensure 
                    else if(letterCount == 0)
                    {
                        sentenceList[count] = sentenceList[count] + sentenceList[count].ToLower();
                    }
                }
            }

            var letterString = String.Join("-", sentenceList);

            return $"Here is your new string mumbled: {letterString}";
        }
    }
}
