using System.Collections.ObjectModel;
using TodoListApplication.DataFile;

namespace TodoListApplication.TodoList;

public partial class FrontPage : ContentPage
{
    public ObservableCollection<DataFromTheUser> DataCollection { get; set; }

    public FrontPage()
    {
        InitializeComponent();
        BindingContext = this;
        DataCollection = new ObservableCollection<DataFromTheUser>();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(itemOfitem.Text))
        {
            var newItem = new DataFromTheUser { ItemValue = itemOfitem.Text };
            DataCollection.Add(newItem);
            itemOfitem.Text = string.Empty; // Clear the Entry field
        }
    }
}
