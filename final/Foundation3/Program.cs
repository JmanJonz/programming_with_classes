using System;

class Program
{
    static void Main(string[] args)
    {
        var ad1 = new Address("Ya Ya Street, DoomsDale NY, USA");
        var ad2 = new Address("Maybe Street, DoomsDale NY, USA");
        var ad3 = new Address("No No Street, DoomsDale NY, USA");

        var lecture = new Lecture("Baking With Sugar", "Where we lecture you on all things baking with sugar", "01/02/1999", "2:17 PM", ad1, "Sally Sue", "30K People Limit");
        Console.WriteLine(lecture.ShortM("Lecture"));
        Console.WriteLine("");
        Console.WriteLine(lecture.StandardM());
        Console.WriteLine("");
        Console.WriteLine(lecture.FullM());
        Console.WriteLine("\n----------------------------------------\n");

        var reception = new Reception("Bob Smith's and Sally Sue's wedding reception", "Come celebrate their wedding with us!", "01/02/1337", "1:11 AM", ad2, "givememoney@yahoo.com");
        Console.WriteLine(reception.ShortM("Reception"));
        Console.WriteLine("");
        Console.WriteLine(reception.StandardM());
        Console.WriteLine("");
        Console.WriteLine(reception.FullM());
        Console.WriteLine("\n----------------------------------------\n");

        var gathering = new OutdoorGathering("Hand Stand Contest!", "Come join thousands in our daily hand standing contest!", "01/02/200BC", "3:33 PM & AM", ad3, "Rain, Shine, Blizzard, Hurricane, We'll be here doing hand stands so come join us!");
        Console.WriteLine(gathering.ShortM("Gathering"));
        Console.WriteLine("");
        Console.WriteLine(gathering.StandardM());
        Console.WriteLine("");
        Console.WriteLine(gathering.FullM());
        Console.WriteLine("\n----------------------------------------\n");


    }
}