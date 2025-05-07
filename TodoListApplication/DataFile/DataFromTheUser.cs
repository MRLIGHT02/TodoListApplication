using System.ComponentModel;

namespace TodoListApplication.DataFile;

public class DataFromTheUser : INotifyPropertyChanged
{
    private string itemValue;

    public string ItemValue
    {
        get => itemValue;
        set
        {
            if (itemValue != value)
            {
                itemValue = value;
                OnPropertyChanged(nameof(ItemValue));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
