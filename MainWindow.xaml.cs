using CourseManagement.Models;
using Microsoft.EntityFrameworkCore;
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

namespace CourseManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ApContext context = new();
        public MainWindow()
        {
            InitializeComponent();
            LoadCourse();
            LoadData();
        }

        private void LoadCourse()
        {
            var courses = context.Courses.Include(c => c.Subject).ToList();
            CourseCbBox.ItemsSource = courses;
            CourseCbBox.DisplayMemberPath = "CourseCode";
            CourseCbBox.SelectedValuePath = "CourseId";

        }

        private void LoadData(int? courseId = null)
        {
            var sql = context.CourseSchedules
                .Include(sc => sc.Course)
                .Include(sc => sc.Room).AsQueryable();
            if(courseId.HasValue && courseId.Value != 0)
            {
                sql = sql.Where(s => s.CourseId == courseId.Value);
                
            }
            ScheduleGrid.ItemsSource = sql.ToList();
        }
        private void CourseCbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CourseCbBox.SelectedValue is int courseId)
            {
                var result = context.CourseSchedules.Where(s => s.CourseId == courseId).ToList();
                ScheduleGrid.ItemsSource = result;
            }
            
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            CourseCbBox.SelectedIndex = -1;
            ScheduleGrid.ItemsSource = null;
        }
            
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {


            if (CourseCbBox.SelectedValue is int courseId)
            {
                var addWindow = new AddSchedule(courseId);
                if (addWindow.ShowDialog() == true)
                {
                    context.CourseSchedules.Add(addWindow.newSchedule);
                    context.SaveChanges();
                    LoadData(courseId);
                }
            }
            else
            {
                var addWindow = new AddSchedule();
                if (addWindow.ShowDialog() == true)
                {
                    context.CourseSchedules.Add(addWindow.newSchedule);
                    context.SaveChanges();
                    LoadData();
                }
            }

            //var addWindow = new AddSchedule();
            //if(addWindow.ShowDialog() == true)
            //{
            //    context.CourseSchedules.Add(addWindow.newSchedule);
            //    context.SaveChanges();
            //    LoadData();
            //}
        }
    }
}