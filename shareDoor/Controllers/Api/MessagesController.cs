using Microsoft.AspNet.Identity;
using shareDoor.Data;
using shareDoor.Dto;
using shareDoor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace shareDoor.Controllers.Api
{
    public class MessagesController : ApiController
    {
        private readonly ApplicationDbContext _ctx;
        public MessagesController()
        {
            _ctx = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult GetMessages(MessageInfo info)
        {

            var receiver = _ctx.Users.SingleOrDefault(x => x.NickName == info.ReceiverId.ToLower());

            if(receiver== null){
                return BadRequest("Δεν υπάρχει χρήστης με αυτό το ψευδώνυμο!");
            }

            _ctx.Messages.Add(new MessageInfo
            {
                Message= info.Message,
                ReceiverId = receiver.Id,
                SenderId = info.SenderId,
                Subject = info.Subject

            });
            _ctx.SaveChanges();

            return Ok();
        
        }

    }
}
