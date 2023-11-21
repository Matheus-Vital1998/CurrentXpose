using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CurrentXpose.Domain.Entidades;
using CurrentXpose.Domain.Interface;

namespace CurrentXpose.Domain.Services
{
    public class EmailService: IEmailService
    {
        private readonly string smtpServer = "smtp.gmail.com";
        private readonly int smtpPort = 587; // Porta SMTP padrão para Gmail
        private readonly string smtpUsername = "Matheus.termo@gmail.com"; // Seu endereço de e-mail do Gmail
        private readonly string smtpPassword = "@Termo123456"; // Senha do seu e-mail do Gmail
        private readonly string fromAddress = "Matheus.termo@gmail.com"; // Seu endereço de e-mail do Gmail

        public async Task EnviarMensagemFaleConosco(FaleConosco model)
        {
            using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
            {
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                smtpClient.EnableSsl = false;

                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress(fromAddress),
                    Subject = "Nova mensagem do Fale Conosco",
                    Body = $@"
                    <p><strong>Nome:</strong> {model.Nome}</p>
                    <p><strong>Assunto:</strong> {model.Assunto}</p>
                    <p><strong>Email:</strong> {model.Email}</p>
                    <p><strong>Mensagem:</strong> {model.Mensagem}</p>"
                };

                // Substitua pelo seu e-mail de destino
                mailMessage.To.Add("mat.vital.santos@gmail.com");

                mailMessage.IsBodyHtml = true; // Permite o uso de HTML no corpo do e-mail

                await smtpClient.SendMailAsync(mailMessage);
            }
        }
    }
}