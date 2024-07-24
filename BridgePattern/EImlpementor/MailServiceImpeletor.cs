using BridgePattern.MailService.MailServiceAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.NewFolder
{
    public interface IMailImpeletor
    {
        IMailServiceImplementor gmailService();
        IMailServiceImplementor yahooService();
        IMailServiceImplementor costomService();
    }
    public class MailImpeletor : IMailImpeletor
    {
        public IMailServiceImplementor costomService()
        {
            return new CostomSender();
        }

        public IMailServiceImplementor gmailService()
        {
            return new GmailSender();
        }

        public IMailServiceImplementor yahooService()
        {
            return new YahooSender();
        }
    }
}
