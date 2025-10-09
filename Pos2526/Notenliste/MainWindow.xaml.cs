using System.Windows;
using System.Windows.Controls;

namespace Notenliste;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    private StudentCol studentCol;

    private bool EditingGrade = false;
    public MainWindow()
    {
        InitializeComponent();

        studentCol = new StudentCol();

    }

    private void ButtonSave_Click(object sender, RoutedEventArgs e)
    {
        studentCol.Save();

        studentCol.UpdateListView(LvStudents);
    }

    private void ButtonLoad_Click(object sender, RoutedEventArgs e)
    {
        studentCol.Load();

        studentCol.UpdateListView(LvStudents);
    }


    private void ButtonAdd_Click(object sender, RoutedEventArgs e)
    {
        if (!EditingGrade)
        {
            WindowStudent inputwindow = new();

            if (inputwindow.ShowDialog() == true)
            {
                studentCol.Add(inputwindow.Student);

                studentCol.UpdateListView(LvStudents);
            }
        }
        else
        {
            Gradepicker inputwindow = new();
            int index = LvStudents.SelectedIndex;

            if (index == -1)
            {
                return;
            }


            if (inputwindow.ShowDialog() == true)
            {

                Grade grade = inputwindow.grade;
                studentCol.Students[index].Grades.Add(grade);

                GradeviewChanged();
            }
        }
    }

    private void GradeviewChanged()
    {
        int index = LvStudents.SelectedIndex;

        if (index == -1)
        {
            LvGrades.ItemsSource = null;
            return;
        }

        LvGrades.ItemsSource = studentCol.Students[index].Grades.Grades; ;
    }

    private void ButtonDelete_Click(object sender, RoutedEventArgs e)
    {
        int index = LvStudents.SelectedIndex;

        if (index == -1)
            return;

        if (!EditingGrade)
        {
            studentCol.Remove(index);

            studentCol.UpdateListView(LvStudents);

            GradeviewChanged();
        }
        else
        {
            int indexG = LvGrades.SelectedIndex;

            if (indexG == -1)
                return;

            studentCol.Students[index].Grades.RemoveAt(indexG);

            GradeviewChanged();
        }
    }


    private void ButtonEdit_Click(object sender, RoutedEventArgs e)
    {
        int index = LvStudents.SelectedIndex;

        if (index == -1)
            return;
        if (!EditingGrade)
        {
            studentCol.Edit(index);

            studentCol.UpdateListView(LvStudents);
        }
        else
        {

            int indexG = LvGrades.SelectedIndex;

            if (indexG == -1)
                return;


            studentCol.Students[index].Grades.Edit(indexG);

            GradeviewChanged();



        }

    }

    private void LvStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        studentCol.UpdateListView(LvStudents);
        GradeviewChanged();

        TbEditingMode.IsChecked = false;
    }
    private void TbEditingMode_Checked(object sender, RoutedEventArgs e)
    {
        EditingGrade = true;
        TbEditingMode.Content = "Editing Mode: Grade";

    }

    private void TbEditingMode_Unchecked(object sender, RoutedEventArgs e)
    {

        EditingGrade = false;
        TbEditingMode.Content = "Editing Mode: Student";
    }

    private void LvGrades_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        TbEditingMode.IsChecked = true;
    }
}