using CircleInRectangleLib;
using Microsoft.AspNetCore.Mvc;
using REST.Model;
using System;
using System.Collections.Generic;

namespace REST.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class SlugsController : Controller
    {
        //https://localhost:44371/api/slugs
        // GET api/slugs
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Test : Slugs HTTP Get" };
        }

        // POST api/slugs
        [HttpPost]
        public IActionResult Post([FromForm] Slugs slugsobj)
        {
            if (slugsobj is null)
            {
                return NotFound(new ProblemDetails()
                {
                    Status = 404,
                    Title = "Ni najdeno",
                    Detail = $"Nepopolni podatki"
                });
            }
            CircleInRectangle cir = new CircleInRectangle();
            slugsobj.result=cir.numberOfSlugs(slugsobj.lenght, slugsobj.width, slugsobj.radious, slugsobj.space);
            return Ok(slugsobj);
        }

    }
}