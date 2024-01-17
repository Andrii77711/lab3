using lab3_1;

namespace lab3_1
{
    public partial class EditStudentPage : ContentPage
    {
        public Student CurrentStudent { get; set; }

        public EditStudentPage(Student student)
        {
            InitializeComponent();
            CurrentStudent = student;
            this.BindingContext = CurrentStudent;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private async void SaveStudent(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }

        private async void CancelEdit(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
