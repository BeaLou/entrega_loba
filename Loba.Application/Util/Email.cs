using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Loba.Service.Util
{
    public class Email
    {
        public Email()
        {
            from = "lourenco19beatriz@gmail.com";
            fromAlias = "LOBA";
            subject = "Ata de Reunião - " + DateTime.Now.ToString();
            body = "Olá! Sua ata de reunião está pronta. Verifique o anexo.";
            port = 587;
            ssl = true;
            host = "smtp.gmail.com";
            credentialEmail = "lourenco19beatriz@gmail.com";
            credentialPassword = "xjiaieivhfsyxgmc";
            usedefaultcredentials = false;
            deliverymethod = SmtpDeliveryMethod.Network;
        }
        public string from { get; set; }
        public string fromAlias { get; set; }
        public string to { get; set; }
        public string subject { get; set; }
        public string body { get; set; }
        public int port { get; set; }
        public string host{ get; set; }
        public bool ssl{ get; set; }
        public string credentialEmail{ get; set; }
        public string credentialPassword{ get; set; }
        public bool usedefaultcredentials { get; set; }
        public SmtpDeliveryMethod deliverymethod { get; set; }
        
        public List<Attachment> attachments { get; set; }    
    }
}
