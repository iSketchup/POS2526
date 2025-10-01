using System.Windows;
using System.Windows.Media;

namespace Notenliste
{
    /// <summary>
    /// Interaction logic for WindowStudent.xaml
    /// </summary>
    public partial class WindowStudent : Window
    {


        public Student Student { get; private set; }
        public WindowStudent()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            TbFirstname.Background = null;
            TbLastname.Background = null;


            string firstname = TbFirstname.Text;
            string lastname = TbLastname.Text;

            if (String.IsNullOrEmpty(firstname))
            {
                TbFirstname.Background = Brushes.LightSalmon;
                return;
            }


            if (String.IsNullOrEmpty(lastname))
            {
                TbLastname.Background = Brushes.LightSalmon;
                return;
            }


            Student = new Student(firstname, lastname);

            this.DialogResult = true;

        }
    }
}
