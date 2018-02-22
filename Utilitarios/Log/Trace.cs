using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios.Log
{
    public class Trace
    {
        private static string LOGDIR = Globales.getValor("LOGDIR");
        private static string LOGDIRERROR = Globales.getValor("LOGDIRERROR");
        private static string COMPROBANTE = Globales.getValor("COMPROBANTE");
   
        public void Log(string content)
        {

            FileStream fs = new FileStream(LOGDIR+ COMPROBANTE + DateTime.Today.ToString("yyyyMMdd")+".TXT", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine(content);
            sw.Flush();
            sw.Close();
        }
        public void LogB(string content)
        {

            FileStream fs = new FileStream(LOGDIR + "\\BO_" + DateTime.Today.ToString("yyyyMMdd") + ".TXT", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine(content);
            sw.Flush();
            sw.Close();
        }
        public void LogError(string content)
        {
            FileStream fs = new FileStream(LOGDIRERROR + "\\ERROR_" +   DateTime.Today.ToString("yyyyMMdd") + ".TXT", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine(content);
            sw.Flush();
            sw.Close();
        }
        public void LogErrorPendiente(string content)
        {
            FileStream fs = new FileStream(LOGDIRERROR + "\\ERRORPENDIENTE_" + DateTime.Today.ToString("yyyyMMdd") + ".TXT", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine(content);
            sw.Flush();
            sw.Close();
        }
    }
}
