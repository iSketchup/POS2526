using System.Windows;
using System.Windows.Media;

namespace Notenliste
{
    /// <summary>
    /// Interaction logic for WindowStudent.xaml
    /// </summary>
    public partial class WindowStudent : Window
    {


        public Student Student { get; private set; } = null;
        public WindowStudent()
        {
            InitializeComponent();
        }
        public WindowStudent(string firstname, string lastname)
        {
            InitializeComponent();
            TbFirstname.Text = firstname;
            TbLastname.Text = lastname;
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            TbFirstname.Background = null;
            TbLastname.Background = null;


            string firstname = TbFirstname.Text.Trim();
            string lastname = TbLastname.Text.Trim();

            if (String.IsNullOrEmpty(firstname))
            {
                TbFirstname.Background = Brushes.LightSalmon;
                TbFirstname.ToolTip = "Darf nicht Leer sein";
                return;
            }


            if (String.IsNullOrEmpty(lastname))
            {
                TbLastname.Background = Brushes.LightSalmon;
                TbLastname.ToolTip = "Darf nicht Leer sein";
                return;
            }


            Student = new Student(firstname, lastname);

            this.DialogResult = true;

        }
    }
}
