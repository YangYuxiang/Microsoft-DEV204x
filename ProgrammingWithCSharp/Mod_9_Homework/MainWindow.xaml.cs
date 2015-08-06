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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student> studentList;
        
        internal List<Student> StudentList
        {
            get { return studentList; }
            set { studentList = value; }
        }

        private int currentStudentIndex;

        public int CurrentStudentIndex
        {
            get { return currentStudentIndex; }
            set { currentStudentIndex = value; }
        }
        public MainWindow()
        {
            InitializeComponent();
            studentList = new List<Student>();
            currentStudentIndex = 0;
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student();
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.City = txtCity.Text;
            studentList.Add(student);

            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (currentStudentIndex == 0)
                currentStudentIndex = studentList.Count-1;
            else
                currentStudentIndex--;

            txtFirstName.Text = studentList[currentStudentIndex].FirstName;
            txtLastName.Text = studentList[currentStudentIndex].LastName;
            txtCity.Text = studentList[currentStudentIndex].City;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (currentStudentIndex == studentList.Count-1)
                currentStudentIndex = 0;
            else
                currentStudentIndex++;

            txtFirstName.Text = studentList[currentStudentIndex].FirstName;
            txtLastName.Text = studentList[currentStudentIndex].LastName;
            txtCity.Text = studentList[currentStudentIndex].City;
        }
    }
}
