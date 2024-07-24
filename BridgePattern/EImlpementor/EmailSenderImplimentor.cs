using BridgePattern.MailService.MailServiceAbstraction;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.EImlpementor
{
    public static class EmailSenderImplimentor
    {
        public static IMailServiceImplementor compail()
        {
            var config = ConfigurationManager.AppSettings;
            if (config["SenderConfig"] == "gmail")
            {
                return new GmailSender();

            }else if( config["SenderConfig"] == "yahoo")
            {
                return new YahooSender();
            }
            else
            {
                return new CostomSender();
            }
        }
    }
}
