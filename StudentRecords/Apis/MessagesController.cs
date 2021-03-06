using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentRecords.Models;

namespace StudentRecords.Apis
{
    [Route("api/messages")]
    public class MessagesController : Controller
    {
        [HttpGet]
        [ProducesResponseType(typeof(Message), 200)]
        public async Task<ActionResult> Messages()
        {
            //Simulate async process
            return await Task.Run(() =>
            {
                var msg = new Message { Data = "Hello World" };
                return Ok(msg);
            });
        }
    }
}