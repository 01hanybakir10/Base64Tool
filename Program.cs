// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("***** Base64 Tool *****");
Console.WriteLine("Base64 Tool");
Console.WriteLine("Github: https://github.com/01hanybakir10/Base64Tool");
Console.WriteLine("Copyright (c) 2007-2023 - CodeZEN");
Console.WriteLine();

base64 base64 = new base64();

while (true)
{
    Console.WriteLine("1. Convert Any File To Base64");
    Console.WriteLine("2. Convert Base64 To Any File ");
    Console.WriteLine("0. Exit");
    Console.WriteLine();
    Console.Write("Enter your choice : ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            base64.ToBase64();
            break;
        case "2":
            base64.FromBase64();
            break;
        case "0":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
}

public class base64
{
    public void ToBase64()
    {
        Console.Write("Enter ZIP file path : ");
        string zippath = Console.ReadLine();

        Console.Write("Enter BASE64 file path : ");
        string b64path = Console.ReadLine();

        Console.WriteLine("Reading ZIP file ...");

        byte[] AsBytes = File.ReadAllBytes(zippath);
        String AsBase64String = Convert.ToBase64String(AsBytes);

        Console.WriteLine("Writing Base64 file ...");

        byte[] tempBytes = Encoding.ASCII.GetBytes(AsBase64String);
        File.WriteAllBytes(b64path, tempBytes);

        Console.WriteLine("Done.");

        Console.WriteLine();
        Console.WriteLine();
    }

    public void FromBase64()
    {
        Console.Write("Enter BASE64 file path : ");
        string b64path = Console.ReadLine();

        Console.Write("Enter ZIP file path : ");
        string zippath = Console.ReadLine();

        Console.WriteLine("Reading Base64 file ...");

        byte[] AsBytes = File.ReadAllBytes(b64path);
        String AsBase64String = Encoding.ASCII.GetString(AsBytes);

        Console.WriteLine("Writing ZIP file ...");

        byte[] tempBytes = Convert.FromBase64String(AsBase64String);
        File.WriteAllBytes(zippath, tempBytes);

        Console.WriteLine("Done.");

        Console.WriteLine();
        Console.WriteLine();
    }
}
