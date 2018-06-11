using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TaxiRetnt.lib
{
    public class ServiceXml
    {
        public string path { get; set; }
        public ServiceXml()
        {

        }
        public ServiceXml(string path)
        {
            this.path = path;
        }


        public void XmlDocument(string path)
        {

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {

            }
        }

        public XmlDocument GetDocument()
        {
            // проверитьест ли документ
            // если есть то загрузить и вернуть, если нет создать , создать корневой элемент и вернуть

            XmlDocument xdoc = new XmlDocument();
            FileInfo fi = new FileInfo(path);

            if (fi.Exists)
                xdoc.Load(path);
            else
            {
                XmlElement root = xdoc.CreateElement("Users");
                xdoc.AppendChild(root);
                xdoc.Save(path);
            }
            return xdoc;
        }
        public XmlElement GetUser(string login, string password)
        {
            return null;
        }
    }
}
