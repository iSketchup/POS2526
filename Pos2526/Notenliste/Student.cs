namespace Notenliste
{
    public class Student
    {
        private uint id;

        public uint ID
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


    }
}
