using System;
using System.Xml;

namespace Shared
{
    public class CommonLogic
    {
        public String GetshortDate()
        {
            return DateTime.Now.ToShortDateString();
        }

        public String GetAppUrl()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("environments.xml");
            XmlNode node = doc.SelectSingleNode("/Environments/Environment");
            String path = node.Attributes["url"].Value;
            return path;
        }
    }
}