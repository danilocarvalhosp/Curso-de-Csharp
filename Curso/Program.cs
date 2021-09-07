using System;
using Curso.Devices;

public class Program
{
    public static void Main(string[] args)
    {
        Printer p = new Printer() { SerialNumber = 1080 };
        p.ProcessDoc("My letter");
        p.Print("My letter");

        Scanner s = new Scanner() { SerialNumber = 2003 };
        s.ProcessDoc("My email");
        Console.WriteLine(s.Scan());

        ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
        c.ProcessDoc("My Dissertation");
        c.Print("My Dissertation");

        Console.WriteLine(c.Scan());
    }
}
