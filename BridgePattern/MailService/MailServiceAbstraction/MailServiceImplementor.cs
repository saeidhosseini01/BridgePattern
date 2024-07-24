using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace BridgePattern.MailService.MailServiceAbstraction
{
    public interface IMailServiceImplementor
    {
        void sendEmail(emailDTO email);

    }

    public class GmailSender : IMailServiceImplementor
    {
        public void sendEmail(  emailDTO email)
        {
            Console.WriteLine($"send emmail to **{email.Reciver} ** title {email.Tilte}** {typeof(GmailSender)}");
        }
    }


    public class YahooSender : IMailServiceImplementor
    {
        public void sendEmail(emailDTO email)
        {
            Console.WriteLine($"send emmail to **{email.Reciver} ** title {email.Tilte}** {typeof(YahooSender)}");
        }
    }
    public class CostomSender : IMailServiceImplementor
    {
        public void sendEmail(emailDTO email)
        {
            Console.WriteLine($"send emmail to **{email.Reciver} ** title {email.Tilte}** {typeof(CostomSender)}");
        }
    }






    public class emailDTO
    {
        public string Reciver { get; set; }
        public string Tilte { get; set; }
        public string teax { get; set; }
    }
}
