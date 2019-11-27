using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using SendGrid;
using SendGrid.Helpers.Mail;
using KarbonWebForms.Sql;

namespace KarbonWebForms.Email
{
    public class EmailTool
    {
        private static readonly string SendEnvVariable = "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";
        private static readonly EmailAddress Sender = new EmailAddress("admin@karbon.com", "Admin");

        public async System.Threading.Tasks.Task SendEmail(Account account, string subject = "", string content = "", string htmlContent = "")
        {
            SendGridClient client = new SendGridClient(Environment.GetEnvironmentVariable(SendEnvVariable));
            EmailAddress reciever = new EmailAddress(account.Email, $"{account.FirstName} {account.LastName}");
            SendGridMessage msg = MailHelper.CreateSingleEmail(Sender, reciever, subject, content, htmlContent);
            await client.SendEmailAsync(msg);
        }
    }
}