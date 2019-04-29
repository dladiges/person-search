using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonData;

namespace SearchService.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly SearchContext context;
        private readonly IHostingEnvironment hostingEnvironment;

        public PersonController(SearchContext context, IHostingEnvironment hostingEnvironment)
        {
            this.context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        // POST api/person
        [HttpPost]
        public ActionResult Post(Person person)
        {
            context.People.Add(person);
            context.SaveChanges();

            // Should be a Created() result with a path to object details, but for simplicity...
            return Ok();
        }

        // POST api/person/uploadimage
        [HttpPost]
        public ActionResult UploadImage()
        {
            try
            {
                var file = Request.Form.Files[0];
                string folder = "ImageUploads";
                string webRootPath = hostingEnvironment.WebRootPath;
                string uploadPath = Path.Combine(webRootPath, folder);

                if (!Directory.Exists(uploadPath))
                    Directory.CreateDirectory(uploadPath);

                if (file.Length > 0)
                {
                    string currentFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName;
                    string extension = Path.GetExtension(currentFileName);
                    string fileName = new Guid().ToString() + extension;
                    string fullPath = Path.Combine(uploadPath, fileName);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    return Content(fileName);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}