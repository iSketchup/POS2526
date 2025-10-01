namespace Notenliste
{
    public class Grade
    {
        public enum Subjects
        {
            Math,
            Pos,
            DBI
        }

        public int Value;
        public Subjects Subject;
        public DateTime Date;

        public Grade() { }
        public Grade(int value, Subjects sub, DateTime date) { 
        
            Value = value;
            Subject = sub;
            Date = date;
        
        }

    }
}
