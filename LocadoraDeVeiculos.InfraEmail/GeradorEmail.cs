﻿using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;

namespace LocadoraDeVeiculos.InfraEmail
{
   
    public class GeradorEmail : IGeradorEmail
    {
        public Result EnviarEmail(Aluguel aluguel, byte[] bytesAnexo = null!)
        {
            string emailRemetente = "equip3devagar3sempr3@gmail.com";

            string tipoEmail = aluguel.EstaAberto ? "Aprovação" : "Finalização";

            var emailMessage = new MailMessage();

            emailMessage.From = new MailAddress(ValidarEmail(emailRemetente));

            emailMessage.To.Add(new MailAddress(ValidarEmail(aluguel.Cliente.Email)));

            emailMessage.Subject = $"Detalhes da {tipoEmail} do aluguel do veículo {aluguel.Automovel.Modelo}";

            emailMessage.Body = CorpoEmail();

            if (bytesAnexo != null)
            {
                var anexoStream = new MemoryStream(bytesAnexo);

                var anexo = new Attachment(anexoStream, "Aluguel.pdf", "application/pdf");

                emailMessage.Attachments.Add(anexo);
            }

            try
            {
                using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                {

                    smtp.Credentials = new NetworkCredential(emailRemetente,ObterCredenciais());

                    smtp.EnableSsl = true;

                    smtp.Send(emailMessage);
                 
                }

                return Result.Ok().WithSuccess("Email enviado com sucesso");
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message).WithError("Falha ao enviar email");
            }
        }

        private static string ValidarEmail(string email)
        {
            string padrao = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z]";

            bool valido = Regex.IsMatch(email, padrao);

            if (!valido)
                throw new Exception("O email informado está em um formato inválido");

            return email;
        }

        private static string CorpoEmail()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Prezado cliente,");
            sb.AppendLine("");
            sb.AppendLine("Agradecemos pela preferência de nossa locadora de veículos. Estamos felizes em poder atendê-lo e esperamos que você tenha uma experiência agradável.");
            sb.AppendLine("");
            sb.AppendLine("Estamos sempre trabalhando para melhorar nossos serviços e estamos abertos a sugestões. Se você tiver alguma dúvida ou comentário, por favor, não hesite em entrar em contato conosco.");
            sb.AppendLine("");
            sb.AppendLine($"Segue em anexo detalhes do aluguel");
            sb.AppendLine("");
            sb.AppendLine("Atenciosamente,");
            sb.AppendLine("Locadora de Veículos Devagar e Sempre");

            return sb.ToString();
        }

        private string ObterCredenciais()
        {          
            return "wctzzwxulytircaj";
        }
    }
}
