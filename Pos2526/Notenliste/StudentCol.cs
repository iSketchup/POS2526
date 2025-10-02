using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Controls;

namespace Notenliste
{
    public class StudentCol
    {
        private List<Student> students = [];

        public ReadOnlyCollection<Student> Students { get => students.AsReadOnly(); }


        public StudentCol() { }

        public void Add(Student student)
        {
            students.Add(student);
            CheckID();
        }

        public void Remove(int index)
        {
            students.RemoveAt(index);
            CheckID();
        }

        public void Edit(int index)
        {

            Student student = students[index];

            WindowStudent inputwindow = new(student.FirstName, student.LastName);

            if (inputwindow.ShowDialog() == true)
            {
                student.FirstName = inputwindow.Student.FirstName;
                student.LastName = inputwindow.Student.LastName;
            }
        }


        public void UpdateListView(ListView listView)
        {
            listView.ItemsSource = Students;
        }

        private void CheckID()
        {
            for (int i = 0; i < students.Count; i++)
            {
                students[i].ID = i + 1;
            }
        }

        public void Save()
        {
            using StreamWriter writer = new("StudentCol.csv");

            foreach (Student student in students)
            {
                writer.WriteLine(student.SerializeToCSV());
            }
        }

        public void Load()
        {
            this.students.Clear();

            using StreamReader reader = new("StudentCol.csv");

            while (!reader.EndOfStream)
            {
                this.Add(Student.DeserializeFromCSV(reader.ReadLine()));
            }

        }
    }
}

