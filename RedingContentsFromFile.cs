using System;
using System.Xml;

class ReadOperations
{
    public static void Main(string[] args)
    {
        ReadXmlFileCaseStudy1();
        ReadHtmlFileCaseStudy2();
        ReadTextFileCaseStudy3();
    }
    private static void ReadXmlFileCaseStudy1()
    {
        Console.WriteLine("For reading XML File");
        XmlDocument readxmlfile = new XmlDocument();
        readxmlfile.Load(@"F:\SwabhavTraningRepositiry\Csharp\Basics\oop\ReadingContentsFrom\ReadingContentsFrom\information.xml");
        XmlNodeList nodes = readxmlfile.SelectNodes("//informations/information");

        foreach(XmlNode node in nodes)
        {
            XmlNode name=node.SelectSingleNode("name");
            XmlNode companyname = node.SelectSingleNode("companyname");
            Console.WriteLine("Name is "+name.InnerText+"\nCompany name is "+companyname.InnerText);
            Console.WriteLine();
        }
    }
   
    private static void ReadHtmlFileCaseStudy2()
    {
        Console.WriteLine("Reading HTML file");
        string html = File.ReadAllText(@"F:\SwabhavTraningRepositiry\Csharp\Basics\oop\ReadingContentsFrom\ReadingContentsFrom\information.html");
        Console.WriteLine(html);
        Console.WriteLine();
    }
    private static void ReadTextFileCaseStudy3()
    {
        Console.WriteLine("Reading Text file");
        string text = File.ReadAllText(@"F:\SwabhavTraningRepositiry\Csharp\Basics\oop\ReadingContentsFrom\ReadingContentsFrom\information.txt");
        Console.WriteLine(text);
        /*string[] lines = File.ReadAllLines(@"F:\SwabhavTraningRepositiry\Csharp\Basics\oop\ReadingContentsFrom\ReadingContentsFrom\information.txt");

        foreach (string line in lines)
            Console.WriteLine(line);*/

    }
}
