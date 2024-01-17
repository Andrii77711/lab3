using System.Collections.ObjectModel;
using System.Windows.Input;

namespace lab3_1
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Student> Students { get; } = new ObservableCollection<Student>();

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;

            LoadStudents();
        }

        private void LoadStudents()
        {

            Students.Add(new Student { Name = "И И", Age = 22, Course = "Инф." });
            Students.Add(new Student { Name = "А К", Age = 22, Course = "Мат. лог." });
        }
        public ICommand EditCommand => new Command<Student>(EditStudent);
        public ICommand DeleteCommand => new Command<Student>(DeleteStudent);

        private async void EditStudent(Student student)
        {
            await Shell.Current.GoToAsync($"{nameof(EditStudentPage)}", true, new Dictionary<string, object>
        {
            { "Student", student }
        });
        }

        private void DeleteStudent(Student student)
        {
            if (Students.Contains(student))
            {
                Students.Remove(student);
            }
        }
    }

}
