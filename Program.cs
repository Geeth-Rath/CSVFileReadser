using System.IO;
// See https://aka.ms/new-console-template for more information


namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
           FileWriter w = new FileWriter();
           People people = new People();
         //  w.AddNewColl();
           people.CSVFilereader();
            Console.ReadLine();

        }

    }
    
}
