using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Notifications
{
    public class Notification
    {
        private readonly IEmailService _emailService;

        public Notification(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void Notify(string userEmail)
        {
            if (!string.IsNullOrEmpty(userEmail))
            {
                _emailService.SendEmail(userEmail, "Welcome!");
            }
        }
    }
}
