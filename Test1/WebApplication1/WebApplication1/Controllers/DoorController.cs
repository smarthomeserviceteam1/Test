using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SmartHomeService.ViewModel;

namespace WebApplication1.Controllers
{
    public class DoorController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<DoorViewModel> Get()
        {
            return new List<DoorViewModel> 
                {
                    new DoorViewModel { ID = Guid.NewGuid(), Name = "Hello World", DeviceID = 1 }, 
                    new DoorViewModel { ID = Guid.NewGuid(), Name = "Hello World2", DeviceID = 2 } 
                };
        }

        // GET api/<controller>/5
        public DoorViewModel Get(int id)
        {
            return Get().FirstOrDefault(x=>x.DeviceID == id) ;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}