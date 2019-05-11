using Microsoft.AspNet.SignalR;
using shareDoor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shareDoor
{
    public class ChatHub : Hub
    {


        private readonly ApplicationDbContext _ctx;

        public ChatHub()
        {
            _ctx = new ApplicationDbContext();
        }


        public void Send(string id, string message)
        {

            var NickName = _ctx.Users.Single(x => x.Id == id).NickName;
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(NickName, message);
  
        }
    }
}