using CourseManagement.Models;
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

namespace CourseManagement
{
    /// <summary>
    /// Interaction logic for EditSchedule.xaml
    /// </summary>
    public partial class EditSchedule : Window
    {
        private ApContext context = new ApContext();
        private readonly CourseSchedule oldSchedule;
        public CourseSchedule updateSchedule { get; set; }
        public EditSchedule(CourseSchedule schedule)
        {     
            InitializeComponent();
            oldSchedule = schedule;
            LoadcbEditData();
            LoadFormData();
        }
        private void LoadcbEditData()
        {
            cbCourseId.ItemsSource = context.Courses.ToList();
            RoomId.ItemsSource = context.Rooms.ToList();
        }
        private void LoadFormData()
        {
            txtTSId.Text = oldSchedule.TeachingScheduleId.ToString();
            cbCourseId.SelectedValue = oldSchedule.CourseId;
            Picker.SelectedDate = oldSchedule.TeachingDate;
            Slot.Text = oldSchedule.Slot.ToString();
            RoomId.SelectedValue = oldSchedule.RoomId;
            Description.Text = oldSchedule.Description;
        }
        private void saveEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                    updateSchedule = new CourseSchedule
                    {
                        TeachingScheduleId = oldSchedule.TeachingScheduleId,
                        CourseId = (int)cbCourseId.SelectedValue,
                        TeachingDate = Picker.SelectedDate ?? DateTime.Now,
                        Slot = int.Parse(Slot.Text),
                        RoomId = (int)RoomId.SelectedValue,
                        Description = Description.Text
                    };
                DialogResult = true;
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}