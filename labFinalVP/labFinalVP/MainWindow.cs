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

namespace labFinalVP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
        }
    }

    namespace YourNamespace
    {
        public partial class MainWindow : Window
        {
            private AppDbContext dbContext;

            public MainWindow()
            {
                NewMethod();
                dbContext = new AppDbContext();

                // Load courses into the DataGrid
                dgCourses.ItemsSource = dbContext.Courses.ToList();
            }

        
            private void AddCourse_Click(object sender, RoutedEventArgs e)
            {
                // Get the course name from the TextBox
                string courseName = txtCourseName.Text;

                // Check if the course name is not empty
                if (!string.IsNullOrEmpty(courseName))
                {
                    // Create a new course
                    Course newCourse = new Course { CourseName = courseName };

                    // Add the new course to the database
                    dbContext.Courses.Add(newCourse);
                    dbContext.SaveChanges();

              

                    // Clear the TextBox
                    txtCourseName.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Please enter a course name.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }

}



namespace LabFinalVP
{
    public partial class MainWindow : Window
    {
        private AppDbContext dbContext;

    
        {
            InitializeComponent();
            dbContext = new AppDbContext();

            // Load students into the DataGrid
            dataGridStudents.ItemsSource = dbContext.Students.ToList();
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            // Get the first name and last name from the TextBoxes
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;

            // Check if both first name and last name are not empty
            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                // Create a new student
                Student newStudent = new Student { FirstName = firstName, LastName = lastName };

                // Add the new student to the database
                dbContext.Students.Add(newStudent);
                dbContext.SaveChanges();

                // Refresh the DataGrid
                dataGridStudents.ItemsSource = dbContext.Students.ToList();

            object textBoxFirstName = null;
            // Clear the TextBoxes
            textBoxFirstName.Text = string.Empty;
                textBoxLastName.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please enter both first name and last name.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
}



    public partial class MainWindow : Window
    {
        private AppDbContext dbContext;

        public MainWindow()
        {
            InitializeComponent();
            dbContext = new AppDbContext();

            // Load students and their assigned courses into the DataGrids
            LoadStudents();
            LoadCourses();
        }

        private void LoadStudents()
        {
            dataGridStudents.ItemsSource = dbContext.Students.ToList();
        }

        private void LoadCourses()
        {
            dataGridCourses.ItemsSource = dbContext.Courses.ToList();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            // Search students based on the entered text
            string studentSearchText = textBoxStudentSearch.Text;
            var students = dbContext.Students.Where(s =>
                s.FirstName.Contains(studentSearchText) || s.LastName.Contains(studentSearchText)
            ).ToList();
            dataGridStudents.ItemsSource = students;

            // Search courses based on the entered text
            string courseSearchText = textBoxCourseSearch.Text;
            var courses = dbContext.Courses.Where(c =>
                c.CourseName.Contains(courseSearchText)
            ).ToList();
            dataGridCourses.ItemsSource = courses;
        }
    }
}
