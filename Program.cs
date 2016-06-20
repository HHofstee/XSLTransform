using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;

namespace XSLTransform
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Usage: XSLTransform xslt inxml outxml");
            }

            string xslt_file = args[0];
            string inxml_file = args[1];
            string outxml_file = args[2];

            // Create the XsltSettings object with script enabled.
            XsltSettings settings = new XsltSettings(false, true);

            // Execute the transform.
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(xslt_file, settings, new XmlUrlResolver());
            xslt.Transform(inxml_file, outxml_file);
        }
    }
}
