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
using examination.Models;

namespace examination
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            array.Items.Clear();
            sortedArray.Items.Clear();
            surnameBox.Clear();
            nameBox.Clear();
            numberBox.Clear();
        }

        DeansOffice dnof = new DeansOffice();

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            string surnameFromBox = surnameBox.Text;
            string nameFromBox = nameBox.Text;
            int numberFromBox = Convert.ToInt32(numberBox.Text);

            Student newStudent = new Student()
            {
                surname = surnameFromBox,
                name = nameFromBox,
                number = numberFromBox
            };

            string newStudentString = $"{newStudent.surname}, {newStudent.name}, {newStudent.number}";

            dnof.Students.Add(newStudent);
            array.Items.Add(newStudentString);
           
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}