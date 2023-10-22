using messageProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shell
{
    public class MainWindowViewModel
    {
        MessagingService messagingService;
        public MainWindowViewModel()
        {
            messagingService = new MessagingService(); 
        }

        public string GetGreeting()
        {
            return messagingService.GetMessage().ToString();
        }
    }


}
