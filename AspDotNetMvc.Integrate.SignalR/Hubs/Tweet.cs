using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR.Hubs;

namespace AspDotNetMvc.Integrate.SignalR.Hubs
{
    public class Tweet:Hub
    {
        public void SendTweet(string tweetText)
        {
            Clients.All.addTweet(tweetText);
        }
    }
}