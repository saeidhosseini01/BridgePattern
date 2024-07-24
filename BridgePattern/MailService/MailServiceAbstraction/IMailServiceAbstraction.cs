using BridgePattern.EImlpementor;
using BridgePattern.NewFolder;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.MailService.MailServiceAbstraction
{
    public abstract class MailServiceAbstraction
    {




        private readonly IMailServiceImplementor mailServiceImplementor;
        // private readonly IMailImpeletor mailImpelementor =new MailImpeletor();
        private readonly IMailServiceImplementor compail;
        protected MailServiceAbstraction( )
        {
            mailServiceImplementor = EmailSenderImplimentor.compail();
        }
        public virtual void send(emailDTO mail) {
            mailServiceImplementor.sendEmail(mail);
        }
    }
    public class RefindMailServiceAbstraction: MailServiceAbstraction
    {

    }
}
