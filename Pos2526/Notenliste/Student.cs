namespace Notenliste
{
    public class Student
    {
        private int id;

        public int ID
        {

            get
            {

                return id;
            }

            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException($"ID < 0. Value = {value}");

                id = value;
            }
        }

        private string firstName;

        public string FirstName
        {
            get => firstName;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNullOrEmpty(value);

                firstName = value;
            }
        }
        private string lastName;
        public string LastName
        {
            get => lastName;
            set
            {
                ArgumentOutOfRangeException.ThrowIfNullOrEmpty(value);

                lastName = value;
            }
        }

        // TODO: Add Grae Collection


        public Student() { }
        /// <summary>
        /// Erstellt ein neues Sudent Obj mit dem übergebenen WErten
        /// </summary>
        /// <param name="id">Id des Schülers. Darf nicht negativ sien. </param>
        /// <param name="firstName">Vorname. Darf nicht leer sein.</param>
        /// <param name="lastName">Nachname. darf nicht leer sein</param>
        /// <exception cref="ArgumentOutOfRangeException">Id darf nicht negativ sein. Vor und nachname dürfen nicht leer sein</exception>
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string SerializeToCSV()
        {
            return $"{firstName} ; {lastName}";
        }

        public static Student DeserializeFromCSV(string csv)
        {
            string[] parts = csv.Split(';');
            Student student = new(parts[0].Trim(), parts[1].Trim());
            return student;

        }
        public override string ToString()
        {
            return $"ID: {ID:D4} Name: {FirstName} {LastName.ToUpper()} ";
        }
    }
}
