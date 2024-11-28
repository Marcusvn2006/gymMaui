using DevQuiz.Pages;

namespace DevQuiz
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            SecureStorage.Default.RemoveAll();
        }

       
    
    }

}
