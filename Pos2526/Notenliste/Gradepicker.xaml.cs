using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Notenliste
{
    /// <summary>
    /// Interaction logic for Gradepicker.xaml
    /// </summary>
    public partial class Gradepicker : Window
    {
        public Grade grade = new();
        public Gradepicker()
        {
            InitializeComponent();
            CbSubject.ItemsSource = Enum.GetValues(typeof(Subjects));
            CbGrade.ItemsSource = new[] { 1, 2, 3, 4, 5, 6 };

        }

        public Gradepicker(int value, Subjects subject, DateTime date)
        {

            InitializeComponent();
            CbSubject.ItemsSource = Enum.GetValues(typeof(Subjects));
            CbGrade.ItemsSource = new[] { 1, 2, 3, 4, 5, 6 };

            CbGrade.SelectedIndex = value -1;
            CbSubject.SelectedIndex = ((int)subject);
            DpDate.SelectedDate = date;

        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            DateTime? Date = DpDate.SelectedDate;

            if (Date == null)
                return;
            //TODO: rot machen tooltip



            grade = new Grade((int)CbGrade.SelectedValue, (Subjects)CbSubject.SelectedValue, (DateTime)Date);

            this.DialogResult = true;

        }
    }
}
