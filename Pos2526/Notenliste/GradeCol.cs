using System.Collections.ObjectModel;

namespace Notenliste
{

    public class GradeCol
    {
        private List<Grade> grades = [];

        public ReadOnlyCollection<Grade> Grades { get => grades.AsReadOnly(); }


        public GradeCol()
        {

        }

        public void Add(Grade grade)
        {
            grades.Add(grade);
        }

        public string SerializeToCsv()
        {
            string safestring = "";

            foreach (Grade grade in grades) { 
                safestring += grade.SerializeToCsv();
            }
            return safestring;
        }

        public static GradeCol DeserializeFromCsv(string[] input)
        {
            GradeCol grades = new GradeCol();
            // i = 2 damit first und lastname geskippt werden
            for (int i = 2; i < input.Length; i++) {
                grades.Add(Grade.DeserializeFromCSV(input[i]));
            }

            return grades;
        }
    }
}
