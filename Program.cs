using System.Text;
// See https://aka.ms/new-console-template for more information


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNewColl();
            Console.ReadLine();
        }

        static void CSVFilereader()
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

        static void AddNewColl()
        {

            List<string> lines = File.ReadAllLines("people.csv").ToList();
            StringBuilder sb = new StringBuilder("", lines.Count + 1);
           

            foreach (var line in lines)
            {
                sb.Append(line);
                var values = line.Split(',');
                sb.Append(",");
                sb.Append(values[0] + "_" + values[1] + "\n");

            }

            string test1 = sb.ToString();
            File.WriteAllText("people.csv", test1);

        }


    }



    class People
    {
        public string Name { get; set; }
        public string Company { get; set; }

    }
}
