using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using WebAPI9.Models;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace WebAPI9.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]

    public class HttpMetodeController : ControllerBase
    {
        [HttpGet]

        public string HelloWorld()
        {
            return "Hello {ime}!";
        }


        [HttpGet]
        [Route("helloworld")]
        public string HelloWorld(string ime)
        {
            return $"Hello World!";

        }

        [HttpGet]
        [RouteAttribute("json")]
        public IActionResult Json(int sifra, string ime)
        {
            return Ok(new { Sifra = sifra, Ime = ime });
        }


        [HttpPost]
        public IActionResult Post(Osoba osoba)
        {
            osoba.Ime = "Hello " + osoba.Ime;
            return StatusCode(201, osoba);
        }


        [Httpput]
        public IActionResult Put(Osoba osoba)
        {
            osoba.Ime = "Hello" + osoba.Ime;
            return StatusCode(StatusCodes.Status206PartialContent, osoba);

        }


        [HttpDelete]
        public IActionResult Delete(int sifra)
        {
            if (sifra <= 0)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { poruka = "Sifra mora biti veća od 0" });
            }
            return StatusCode(StatusCodes.Status204NoContent);
        }
    }



    
    }
