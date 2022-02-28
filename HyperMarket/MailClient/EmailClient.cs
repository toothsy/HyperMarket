using System.Net;
using System.Net.Mail;

namespace HyperMarket.MailClient
{
    public class EmailClient
    {
        static string activationCode;

        /// <summary>
        /// Method to generate OTP
        /// </summary>
        /// <returns>activationCode</returns>
        public string GenerateOTP()
        {
            string numeralCode;
            activationCode = string.Empty;
            Random random = new Random();
            string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXY";

            for (int i = 0; i < 2; i++)
            {
                int a = random.Next(alphabets.Length);
                activationCode = activationCode + alphabets.ElementAt(a);
            }
            activationCode = activationCode + "-";
            numeralCode = random.Next(1001, 9999).ToString();
            activationCode += numeralCode;

            return activationCode;
        }

        /// <summary>
        /// Method to send the mail to user
        /// </summary>
        /// <param name="receiveraddress"></param>
        /// <param name="senderAddress"></param>
        /// <param name="senderPassword"></param>
        /// <param name="senderSignature"></param>
        /// <returns></returns>
        public bool SendEmail(string receiveraddress, string senderAddress, string senderPassword, string senderSignature)
        {
            string activationCode = GenerateOTP();
            MailMessage mail = new MailMessage();
            mail.To.Add(receiveraddress.Trim().Replace("'", "''"));
            mail.From = new MailAddress(senderAddress);
            mail.Subject = "User Login Mobile OTP";
            string body = "Dear User your Acitvation Code is " + EmailClient.activationCode;
            body += "<br /> Thanks And Regards:" + "<br />" + senderSignature;
            mail.Body = body;
            mail.IsBodyHtml = true;
            NetworkCredential networkcredential = new NetworkCredential(senderAddress, senderPassword);
            SmtpClient smtp = new SmtpClient();
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = networkcredential;
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.Send(mail);

            return true;
        }


        /// <summary>
        /// Method to validate the OTP
        /// </summary>
        /// <param name="check"></param>
        /// <returns>bool</returns>
        public bool ValidateOTP(string check)
        {
            if (check == activationCode)
                return true;

            else
                return false;
        }
    }
}
