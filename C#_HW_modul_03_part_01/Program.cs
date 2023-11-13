
using System.Net;
using static System.Console;
internal class Program
{

    static bool IsPalindrom(int arg1)
    {
        string str = "";
        int arg = arg1;
        while (arg != 0)
        {
            int temp = 0;
            temp = arg % 10;
            arg /= 10;
            str += temp;
        }
        return arg1 == int.Parse(str);
    }
    static void DrowSquer(int side, char symbol)
    {
        char[,] squer = new char[side, side];

        for (int i = 0; i < side; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < side; j++)
            {
                squer[i, j] = symbol;

                Console.Write(squer[i, j] + " ");
            }
        }
    }
    static string[] Filtr(string[]origin,string[]without)
    {
        List<string> temp = new();
        temp.AddRange(origin);
        for (int i = 0; i < origin.Length; i++)
        {
            for (int j = 0; j < without.Length; j++)
            {
                if (origin[i] == without[j])
                    temp.Remove(origin[i]);
            }
        }
        return temp.ToArray();
    }
    class Website
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Specification { get; set; }
        public string IpAdress { get; set; }

        public override string ToString()
        {
            return $"\tName website: {Name}\n" +
                $"\tURL: {Path}\n \tSpecification: {Specification}\n" +
                $"\tIP Adress: {IpAdress}";
        }
        public void InputData()
        {
            WriteLine("Fill in the website details: ");
            Write("Name: ");
            Name = ReadLine();
            Write("Path: ");
            Path = ReadLine();
            Write("Specification: ");
            Specification = ReadLine();
            Write("IP Adress: ");
            IpAdress = ReadLine();
        }
    }
    class Magazin
    {
        public string Name { get; set; }
        public DateTime DateOfFoundation { get; set; }
        public string Specification { get; set; }
        public long ContactPhone { get; set; }
        public string ContactEmail { get; set; }

        public override string ToString()
        {
            return $"\tName magazin: {Name}\n" +
                $"\tFoundation: {DateOfFoundation.ToLongDateString}\n \tSpecification: {Specification}\n" +
                $"\tContact Phone number: {ContactPhone}\n\tContact E-mail: {ContactEmail} ";
        }
        public void InputData()
        {
            WriteLine("Fill in the magazin details: ");
            Write("Name: ");
            Name = ReadLine();
            Write("Foundation: ");
            DateOfFoundation = DateTime.Parse(ReadLine());
            Write("Specification: ");
            Specification = ReadLine();
            Write("Contact Phone number: ");
            ContactPhone = long.Parse(ReadLine());
            Write("Contact E-mail: ");
            ContactEmail = ReadLine();


        }

    }
    class Shop
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Specification { get; set; }
        public long ContactPhone { get; set; }
        public string ContactEmail { get; set; }

        public override string ToString()
        {
            return $"\tName shop: {Name}\n" +
                $"\tAdress: {Adress}\n \tSpecification: {Specification}\n" +
                $"\tContact Phone number: {ContactPhone}\n\tContact E-mail: {ContactEmail} ";
        }

        public void InputData()
        {
            WriteLine("Fill in the shop details: ");
            Write("Name: ");
            Name = ReadLine();
            Write("Adress: ");
            Adress = ReadLine();
            Write("Specification: ");
            Specification = ReadLine();
            Write("Contact Phone number: ");
            ContactPhone = long.Parse(ReadLine());
            Write("Contact E-mail: ");
            ContactEmail = ReadLine();
        }

    }


    private static void Main(string[] args)
    {
        string[] origin = { "1", "3", "4", "3", "-", "2" };
        string[] without = { "1", "3", "-" };
        foreach (var item in Filtr(origin,without))
        {
            Console.Write(item + " ");
        }
        WriteLine();
        Console.WriteLine(IsPalindrom(123321));
        DrowSquer(5, '+');
        WriteLine();

        Website site = new();
        site.InputData();
        WriteLine("\n"+site);
    }
}