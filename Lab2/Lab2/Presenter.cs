using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Presenter
    {
        public List<string> EmailNotifications;
        public List<string> TextNotifications;
        public delegate void NotificationAction(string information);
        public NotificationAction notificationHandler;

        public Presenter()
        {
            EmailNotifications= new List<string>();
            TextNotifications= new List<string>();
            notificationHandler = null;
        }

        public bool getPublishSatus()
        {
            bool status = EmailNotifications!=null && EmailNotifications.Count > 0;
            status = status || (TextNotifications!=null && TextNotifications.Count > 0);
            return status;
        }
    }
}
