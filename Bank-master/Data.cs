using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using System.IO;
using System.Xml.Linq;


namespace Bank
{
    public class Data
    {
        private string path = @"C:\Users\PC\Documents\C#\Bank-2\Data\userData.xml";
        public Data()
        {
            Console.WriteLine("CONSTRUCT");
        }
        public XElement Auth(string login, string pass)
        {
            XDocument doc = XDocument.Load(this.path);
            foreach (XElement el in doc.Root.Elements())
            {
                //Выводим имя элемента и значение аттрибута id
                Console.WriteLine(el.Element("login").Value + " " + login);
                if(el.Element("login").Value == login)
                {
                    if(el.Element("password").Value == pass)
                    {
                        return el;
                    }
                }
            }
            return null;
        }

        private XElement Auth(XElement user)
        {
            XDocument doc = XDocument.Load(this.path);
            foreach (XElement el in doc.Root.Elements())
            {
                //Выводим имя элемента и значение аттрибута id
                if (el.Element("login") == user.Element("login"))
                {
                    if (el.Element("password") == user.Element("password"))
                    {
                        return el;
                    }
                }
            }
            return null;
        }

        public XElement AddAccountToXML(XElement user)
        {
            XDocument doc = XDocument.Load(this.path);
            foreach (XElement el in doc.Root.Elements())
            {
                if (el.Element("login").Value ==user.Element("login").Value)
                {
                    if (el.Element("password").Value == user.Element("password").Value)
                    {
                        el.Remove();
                    }
                }
            }
            doc.Root.Add(user);
            doc.Save(this.path);
            return user;            
        }
    }
}
