using TodoListApplication.TodoList;

namespace TodoListApplication
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new FrontPage();
        }

      
    }
}