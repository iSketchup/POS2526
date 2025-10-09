namespace Notenliste
{



    public class Grade
    {


        public int Value;
        public Subjects Subject;
        public DateTime Date;

        public Grade() { }
        public Grade(int value, Subjects sub, DateTime date) { 
        
            Value = value;
            Subject = sub;
            Date = date;
            
            
        }

        public string SerializeToCsv()
        {
            return $"|{Value};{(int)Subject};{Date}";
        }
        public static Grade DeserializeFromCSV(string input)
        {
            string[] parts = input.Split(";");

            int value = int.Parse(parts[0]);
            Subjects sub = (Subjects)int.Parse(parts[1]);
            DateTime date = DateTime.Parse(parts[2]);

            return new(value, sub, date);
        }

        public override string ToString()
        {
            return $"{Value} | {(Subject)}, {Date.Day}.{Date.Month}.{Date.Year}";
        }

    }
}
