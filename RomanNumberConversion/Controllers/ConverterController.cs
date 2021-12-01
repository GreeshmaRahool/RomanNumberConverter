using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RomanNumberConversion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ConverterController : ControllerBase
    {
        [HttpGet]
        public string Get([FromQuery] string value)
        {
            int result;
            if (int.TryParse(value,
               out result))
            {
                if(result < 1 && result > 3999)
                {
                    return string.Empty;
                }

                return Converter.arabicToRoman(result);
            }
            else
            {
                var allowedCharacters = "IVXLCDM";
                if (string.IsNullOrEmpty(value))
                {
                    return string.Empty;
                }

                // Validate the text 
                for (int i = 0; i < value.Length; i++)
                {
                    if (!allowedCharacters.Contains(value[i]))
                    {
                        return string.Empty;
                    }
                }

                return Converter.romanToArabic(value).ToString(); 
            }


        }



    }
}
