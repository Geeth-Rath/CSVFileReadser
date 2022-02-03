using System.IO;
// See https://aka.ms/new-console-template for more information


namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {

            Filereader r = new Filereader();
            r.CSVFilereader();

            FileWriter w = new FileWriter();
            w.AddNewColl();
            Console.ReadLine();

        }

    }

}
