using System.Text;

namespace Program
{
    public class FileWriter
    {
        public void AddNewColl()
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
}