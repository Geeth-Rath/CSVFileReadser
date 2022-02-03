using System.Text;


namespace Program
{

    public interface Readable
    {
        public void CSVFilereader();

    }


    public class People
    {
        public string Name { get; set; }
        public string Company { get; set; }
    }



    public class Filereader : Readable
    {
        public void CSVFilereader()
        {
            var lines = File.ReadAllLines("people.csv");
            var List = new List<People>();
            foreach (var line in lines)
            {
                var values = line.Split(',');

                var people = new People() { Name = values[0], Company = values[1] };
                List.Add(people);
            }
            List.ForEach(x => Console.WriteLine($"{x.Name}\t{x.Company}"));
        }
    }



}


