using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Notenliste;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    public StudentCol studentCol;
    public MainWindow()
    {
        InitializeComponent();

        studentCol = new StudentCol();

    }

    private void ButtonAdd_Click(object sender, RoutedEventArgs e)
    {

        WindowStudent inputwindow = new();

        if (inputwindow.ShowDialog() == true)
        {
            studentCol.Add(inputwindow.Student);

            studentCol.UpdateListView(LvStudents);
        }

    }

    private void ButtonAddGrade_Click(object sender, RoutedEventArgs e)
    {
        Gradepicker inputwindow = new();

        if (inputwindow.ShowDialog() == true)
        {
            int index = LvStudents.SelectedIndex;
            Grade grade = inputwindow.grade;

            if (index == -1)
                return;


            studentCol.Students[index].Grades.Add(grade);

            GradeviewChanged();


        }
    }

    private void GradeviewChanged()
    {
        int index = LvStudents.SelectedIndex;

        if (index == -1){
            LvGrades.ItemsSource = null;
            return;
        }

        LvGrades.ItemsSource = studentCol.Students[index].Grades.Grades; ;
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

    private void ButtonDelete_Click(object sender, RoutedEventArgs e)
    {
        int index = LvStudents.SelectedIndex;

        if (index == -1)
            return;

        studentCol.Remove(index);

        studentCol.UpdateListView(LvStudents);
        
        GradeviewChanged();
    }

    private void ButtonEdit_Click(object sender, RoutedEventArgs e)
    {
        int index = LvStudents.SelectedIndex;

        if (index == -1)
            return;

        studentCol.Edit(index);

        studentCol.UpdateListView(LvStudents);
    }

    private void LvStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        studentCol.UpdateListView(LvStudents);
        GradeviewChanged();
    }
}