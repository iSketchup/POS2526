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
        public Student(int id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
