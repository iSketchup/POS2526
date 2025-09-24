namespace Notenliste
{
    public class Student
    {
        private uint id;

        public uint ID
        {

            get {

                return id; 
            }

            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("ID < 0");
                id = value; 
            }
        }

    }
}
