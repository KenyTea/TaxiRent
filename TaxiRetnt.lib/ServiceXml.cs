using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using TaxiRetnt.lib.Modules;

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
        public bool GetUser(string login, string password)
        {
            return true;
        }

        public bool AddUsers(Tdl_User user, out string massage)
        {
            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Tdl_User));
                using (FileStream fs = new FileStream("users/" + user.Name + ".xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, user);
                }
                massage = "Пользователь добавлен";
                return true;
            }
            catch (Exception ex)
            {
                massage = ex.Message;
                return false;
            }    
        }


        public List<Tdl_User> getUserss()
        {
            List<Tdl_User> users = new List<Tdl_User>();
            DirectoryInfo di = new DirectoryInfo("users");
            foreach (FileInfo item in di.GetFiles())
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Tdl_User));

                using (FileStream fs = new FileStream(item.FullName, FileMode.Open))
                {
                    users.Add((Tdl_User)formatter.Deserialize(fs));
                }
            }
            return users;

        }

    }

}
