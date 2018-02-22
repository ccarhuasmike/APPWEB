using System;
using System.Configuration;
using System.Diagnostics;
using System.Net.Mail;
using System.Text;
using Utilitarios.Security;

namespace Utilitarios.Mail
{
    public class MailSender
    {
        public static string SendMail(string message)
        {
            string response;
            try
            {                
                const string htmlInit = "<html><head><link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css' integrity='sha384-1q8mTJOASx8j1Au+a5WDVnPi2lkFfwwEAa8hDDdjZlpLegxhjVME1fgjWPGmkzs7' crossorigin='anonymous'></head><body>";
                string htmlBody = message;
                string sHead = "ALERTA - Problemas Detectados en el Sistema " + ConfigurationManager.AppSettings.Get("NombreSistema") + "<br /><br />";
                const string htmlEnd = "</body></html>";
                string sBody = htmlInit + htmlBody + htmlEnd;

                MailMessage mailMessage = new MailMessage(Encryptor.DecryptString(ConfigurationManager.AppSettings.Get("CorreoDe")), Encryptor.DecryptString(ConfigurationManager.AppSettings.Get("CorreoDe")));
                mailMessage.To.Add(ConfigurationManager.AppSettings.Get("CorreoPara"));
                mailMessage.Subject = "ALERTA - Información de Problemas de la aplicación IGACC2016";

                AlternateView alternativeView = AlternateView.CreateAlternateViewFromString(sHead + sBody, Encoding.UTF8, "text/html");
                mailMessage.AlternateViews.Add(alternativeView);

                SmtpClient smtpClient = new SmtpClient
                {
                    Host = Encryptor.DecryptString(ConfigurationManager.AppSettings.Get("ServidorCorreo")),
                    Port = int.Parse(Encryptor.DecryptString(ConfigurationManager.AppSettings.Get("PuertoCorreo"))),
                    EnableSsl = false,
                    UseDefaultCredentials = false,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials =
                        new System.Net.NetworkCredential(
                            Encryptor.DecryptString(ConfigurationManager.AppSettings.Get("UsuarioCorreo")),
                            Encryptor.DecryptString(ConfigurationManager.AppSettings.Get("ClaveCorreo")))
                };
                smtpClient.Send(mailMessage);
                response = "OK";
            }
            catch (Exception ex)
            {
                response = ex.Message;                
            }
            return response;
        }

        public static string SendErrorMail(Exception exception)
        {
            var st = new StackTrace(exception, true);
            var frame = st.GetFrame(st.FrameCount-1);
            var frameName = frame.GetFileName();            
            if (string.IsNullOrEmpty(frameName) || frameName.Contains("MethodValidator.cs"))
                frame = st.GetFrame(st.FrameCount - 2);
            string sbody =
                    "<table class='table table-bordered' Style='border: 1px solid #ddd;font-family: sans-serif;'>" +
                    "<thead style='background-color: #2374BB;color: #ffffff;'>" +
                    "<tr>" +
                    "<th Style='border: 1px solid #ddd;padding: 8px;text-align: center;vertical-align: middle;'>TIPO</th>" +
                    "<th Style='border: 1px solid #ddd;padding: 8px;text-align: center;vertical-align: middle;'>DETALLE</th>" +
                    "</tr>"+
                    "</thead>" +
                    "<tbody>"+
                    "<tr Style='border: 1px solid #ddd;padding: 8px;'>" +
                    "<td Style='border: 1px solid #ddd;padding: 8px;vertical-align: middle;'>Mensaje Principal del Exception: </td>" +
                    "<td Style='border: 1px solid #ddd;padding: 8px;vertical-align: middle;'>" + exception.Message + "</td>" +
                    "</tr>" +
                    ((exception.InnerException != null)? ("<tr Style='border: 1px solid #ddd;padding: 8px;'><td Style='border: 1px solid #ddd;padding: 8px;vertical-align: middle;'>Mensaje Secundario del Exception: </td><td Style='border: 1px solid #ddd;padding: 8px;vertical-align: middle;'>" + exception.InnerException.Message + "</td></tr>") : "") +
                    "<tr Style='border: 1px solid #ddd;padding: 8px;'>" +
                    "<td Style='border: 1px solid #ddd;padding: 8px;vertical-align: middle;'>Archivo Generador del Exception: </td>" +
                    "<td Style='border: 1px solid #ddd;padding: 8px;vertical-align: middle;'>" + frame.GetFileName() + "</td>" +
                    "</tr>" +
                    "<tr Style='border: 1px solid #ddd;padding: 8px;'>" +
                    "<td Style='border: 1px solid #ddd;padding: 8px;vertical-align: middle;'>Método Generador del Exception: </td>" +
                    "<td Style='border: 1px solid #ddd;padding: 8px;vertical-align: middle;'>" + frame.GetMethod() + "</td>" +
                    "</tr>" +
                    "<tr Style='border: 1px solid #ddd;padding: 8px;'>" +
                    "<td Style='border: 1px solid #ddd;padding: 8px;vertical-align: middle;'>Línea del Exception: </td>" +
                    "<td Style='border: 1px solid #ddd;padding: 8px;vertical-align: middle;'>" + frame.GetFileLineNumber() + "</td>" +
                    "</tr>" +
                    "<tr Style='border: 1px solid #ddd;padding: 8px;'>" +
                    "<td Style='border: 1px solid #ddd;padding: 8px;vertical-align: middle;'>Columna del Exception: </td>" +
                    "<td Style='border: 1px solid #ddd;padding: 8px;vertical-align: middle;'>" + frame.GetFileColumnNumber() + "</td>" +
                    "</tr>" +
                    "<tr Style='border: 1px solid #ddd;padding: 8px;'>" +
                    "<td Style='border: 1px solid #ddd;padding: 8px;vertical-align: middle;'>StackTrace: </td>" +
                    "<td Style='border: 1px solid #ddd;padding: 8px;vertical-align: middle;'>" + exception.StackTrace + "</td>" +
                    "</tr>" +
                    "</tbody></table><br /><br /><br />" +
                    //"Mensaje Principal del Exception: "+exception.Message+"<br />" +
                    //((exception.InnerException != null)? ("Mensaje Secundario del Exception: " + exception.InnerException.Message + "<br />") : "") +
                    //"Archivo Generador del Exception: " + frame.GetFileName() + "<br />" +
                    //"Método Generador del Exception: " + frame.GetMethod() + "<br />" +
                    //"Línea del Exception: " + frame.GetFileLineNumber() + "<br />" +
                    //"Columna del Exception: " + frame.GetFileColumnNumber() + "<br />" +
                    //"StackTrace: " + exception.StackTrace + "<br />" +
                    "No dar respuesta a este correo electrónico.<br />" +
                    "Oficina de Tecnología de Información" + "<br />" + "Ministerio de Transportes y Comunicaciones";
            return SendMail(sbody);
        }
    }
}
