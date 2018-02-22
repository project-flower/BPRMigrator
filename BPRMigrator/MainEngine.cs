using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace BPRMigrator
{
    public static class MainEngine
    {
        public static IEnumerable<string> GetProjectFiles(string fileName, string elementName, string attributeName)
        {
            var fileInfo = new FileInfo(fileName);
            string directoryName = fileInfo.DirectoryName;
            var document = new XmlDocument();
            document.Load(fileName);
            XmlElement element = document.DocumentElement[elementName];

            if (element == null)
            {
                throw new Exception(elementName + " 要素が見つかりません。");
            }

            string currentDirectory = Directory.GetCurrentDirectory();

            try
            {
                Directory.SetCurrentDirectory(fileInfo.DirectoryName);

                foreach (XmlNode node in element.ChildNodes)
                {
                    XmlAttribute attribute = node.Attributes[attributeName];

                    if (attribute == null)
                    {
                        throw new Exception(node.OuterXml + "\r\n" + attributeName + " 属性が見つかりません。");
                    }

                    var info = new FileInfo(attribute.Value);

                    if (!(info.Exists))
                    {
                        throw new FileNotFoundException(info.FullName + " が見つかりません。");
                    }

                    yield return info.FullName;
                }
            }
            finally
            {
                Directory.SetCurrentDirectory(currentDirectory);
            }
        }

        public static string GetFormattedPaths(string fileName, string element1Name, string element2Name)
        {
            string[] paths = getPaths(fileName, element1Name, element2Name);
            var builder = new StringBuilder();

            foreach (string column in paths)
            {
                if (builder.Length > 0)
                {
                    builder.Append(";");
                }

                string value = column;

                //if (value.EndsWith("\""))
                //{
                //    if (!(value.EndsWith("\\\"")))
                //    {
                //        if (value.Length > 2)
                //        {
                //            value = value.Substring(0, (value.Length - 1));
                //        }
                //
                //        value += "\\\"";
                //    }
                //}
                //else if (!(value.EndsWith("\\")))
                if (!(value.EndsWith("\\")))
                {
                    value += "\\";
                }

                builder.Append(value);

            }

            return builder.ToString();
        }

        private static string[] getPaths(string fileName, string element1Name, string element2Name)
        {
            var document = new XmlDocument();
            document.Load(fileName);
            XmlElement element = document.DocumentElement[element1Name];

            if (element == null)
            {
                throw new Exception(element1Name + " 要素が見つかりません。");
            }

            XmlNodeList nodes = element.GetElementsByTagName(element2Name);

            if ((nodes == null) || (nodes.Count < 1))
            {
                throw new Exception(element2Name + " 要素が見つかりません。");
            }

            XmlAttribute attributes = nodes[0].Attributes["value"];

            if (attributes == null)
            {
                throw new Exception(nodes[0].OuterXml + "\r\n" + " VALUE 属性が見つかりません。");
            }

            string values = attributes.Value.Replace("\"", string.Empty).Replace("$(BCB)", "$(BDS)");
            string[] columns = values.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            return columns;
        }
    }
}
