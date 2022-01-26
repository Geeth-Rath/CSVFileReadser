// See https://aka.ms/new-console-template for more information


namespace Program
{
    class Program{
        static void Main(string []args ){
                CSVFilereader();
                Console.ReadLine();
        }

        static void CSVFilereader(){
            
            var lines = File.ReadAllLines("people.csv");
            var List = new List<People>();
            foreach (var line in lines)
            {
                var values = line.Split(',');
                var people = new People(){ Name = values[0], Company = values[1]};
                List.Add(people);                
            }
            List.ForEach( x => Console.WriteLine($"{x.Name}\t{x.Company}")); 
           
        }
    }

    

    class People{
        public string Name {get; set;}
        public string Company {get; set;}
    }
}
