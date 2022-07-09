using System;
class Program
{
    public static void Main(string[] args)
    {
        CaseStudy();
    }

    private static void CaseStudy()
    {
        string Path = (@"F:\SwabhavTraningRepositiry\Csharp\Basics\oop\NotOverriteText\NotOverriteText\Information.txt");
        StreamWriter username = File.AppendText(Path);
        Console.WriteLine("Enter the user name");
        string UserName = Console.ReadLine();
        username.WriteLine(UserName);
        username.Close();
    }
}