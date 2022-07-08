using System;
using System.Data;
using System.IO;


class Program
{
    public static void Main(String[] args)
    {
        WriteXmlFileCaseStuidy();
        WriteTextFileCaseStudy();
        WritingHtmlFileCaseStudy();
    }

    private static void WritingHtmlFileCaseStudy()
    {
        string Fname = "gaurav";
        string Lname = "jadhav";
        //Html Code
        string html = "<html><h3>First Name: </h3> <span>" + Fname + "</span>";
        html += "<h3 >Last Name: </h3> <span>" + Lname + "</span></html>";
        File.WriteAllText(@"F:\SwabhavTraningRepositiry\Csharp\Basics\oop\WritingContentsFrom\WritingContentsFrom\information.html", html);
        Console.WriteLine("HTML File created.");
        Console.ReadLine();
    }

    private static void WriteTextFileCaseStudy()
    {
        string containt1 = "name : Gaurav Jadhav";
        string containt2 = "company name : AurionPro";
        StreamWriter sr = new StreamWriter(@"F:\SwabhavTraningRepositiry\Csharp\Basics\oop\WritingContentsFrom\WritingContentsFrom\TextFile1.txt");
        sr.WriteLine(containt1+"\n"+containt2);
        sr.Close();
        
    }

    private static void WriteXmlFileCaseStuidy()
    {
        Console.WriteLine("For Writing XML File");
        string filePath = @"F:\SwabhavTraningRepositiry\Csharp\Basics\oop\WritingContentsFrom\WritingContentsFrom\XMLFile1.xml";
        DataSet ds=new DataSet();
        ds.ReadXml(filePath);
        ds.Tables[0].Rows[0]["name"] = "Gaurav Jadhav";
        ds.Tables[0].Rows[0]["companyname"] = "AurionPro";
        ds.Tables[0].Rows[0]["addres"] = "Mumbai";
        ds.WriteXml(filePath);
        Console.WriteLine("Containt Write in XML File");
    }
}