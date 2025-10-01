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
}