using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timeProvider
{
    public class TimeProviderService
    {
        public DateTime GetDateTime()
        {
            DateTime dateTime = DateTime.Now.AddDays(1);

            return dateTime;

        }
    }
}
