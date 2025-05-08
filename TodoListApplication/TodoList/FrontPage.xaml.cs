using System.Collections.ObjectModel;

using TodoListApplication.DataFile;

namespace TodoListApplication.TodoList;

public partial class FrontPage : ContentPage
{
    public ObservableCollection<DataFromTheUser> DataCollection { get; set; }

    public FrontPage()
    {
        InitializeComponent();
        DataCollection = new ObservableCollection<DataFromTheUser>();
        BindingContext = this;
        
    }

    //private ObservableCollection<DataFromTheUser> Getdata() => new ObservableCollection<DataFromTheUser>(
    //    new List<DataFromTheUser>
    //    {
    //        new DataFromTheUser{ItemData=itemofentery.Text}
    //    });
    private void Button_Clicked(object sender, EventArgs e)
    {
        var newItem = new DataFromTheUser { ItemData = itemofentery.Text };
        DataCollection.Add(newItem);
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        if(sender is Button btn && btn.BindingContext is DataFromTheUser item)
        {
            DataCollection.Remove(item);
        }
    }
}
