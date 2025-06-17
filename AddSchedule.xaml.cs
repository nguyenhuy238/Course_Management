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
using CourseManagement.Models;
using Microsoft.EntityFrameworkCore;
namespace CourseManagement
{
    /// <summary>
    /// Interaction logic for AddSchedule.xaml
    /// </summary>
    public partial class AddSchedule : Window
    {
        ApContext context = new ApContext();
        public CourseSchedule newSchedule { get; private set; }
        private int? _courseId;
        //public AddSchedule()
        //{
        //    InitializeComponent();
        //    LoadComboData();
        //}
        public AddSchedule(int? courseId = null)
        {
            InitializeComponent();
            _courseId = courseId;
            LoadComboData();
        }

        private void LoadComboData()
        {

            if (_courseId.HasValue)
            {
                var course = context.Courses.FirstOrDefault(c => c.CourseId == _courseId.Value);
                if (course != null)
                {
                    cbCourse.ItemsSource = new List<Course> { course };
                    cbCourse.SelectedItem = course;
                    cbCourse.IsEnabled = false; // Disable the ComboBox
                }
            }
            else
            {
                cbCourse.ItemsSource = context.Courses.ToList();
            }
            cbRoom.ItemsSource = context.Rooms.ToList();
            //cbCourse.ItemsSource = context.Courses.ToList();
            //cbRoom.ItemsSource = context.Rooms.ToList();
        }

        private void saveAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                newSchedule = new CourseSchedule
                {
                    CourseId = (int)cbCourse.SelectedValue,
                    TeachingDate = dtPicker.SelectedDate ?? DateTime.Now,
                    Slot = int.Parse(txtSlot.Text),
                    RoomId = (int)cbRoom.SelectedValue,
                    Description = txtDescription.Text
                };
                DialogResult = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving schedule: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
