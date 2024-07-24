using BridgePattern.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.MailService.MailServiceAbstraction
{
    public abstract class MailServiceAbstraction
    {




        private readonly IMailServiceImplementor mailServiceImplementor;
        private readonly IMailImpeletor mailImpelementor =new MailImpeletor();

        protected MailServiceAbstraction(  )
        {
            mailServiceImplementor = mailImpelementor.costomService();
        }
        public virtual void send(emailDTO mail) {
            mailServiceImplementor.sendEmail(mail);
        }
    }
    public class RefindMailServiceAbstraction: MailServiceAbstraction
    {

    }
}
