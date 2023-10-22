using common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timeProvider;

namespace messageProvider
{
    public class MessagingService
    {
        TimeProviderService timeProviderService;
        public static readonly string Message = "Hello World!!!";
        public MessagingService()
        {
            timeProviderService = new TimeProviderService();
        }
        public Message GetMessage()
        {
            var message = new Message();

            message.DateTime = timeProviderService.GetDateTime();

            message.Name = "Oligo";

            message.MessageText = Message;


            return message;
        }
    }
}
