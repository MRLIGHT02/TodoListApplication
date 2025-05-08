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

    /// <summary>
    /// This is item adding button 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AddItemButtonClicked(object sender, EventArgs e)
    {

        var newItem = new DataFromTheUser { ItemData = itemofentery.Text?.Trim() };
        DataCollection.Add(newItem);





    }
    /// <summary>
    /// This is Delete Item button Which delete the item from the list
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DeleteItemButtonClicked(object sender, EventArgs e)
    {
        if (sender is Button btn && btn.BindingContext is DataFromTheUser item)
        {
            DataCollection.Remove(item);
        }
    }
}
