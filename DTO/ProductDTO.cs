using System.ComponentModel;

namespace DTO;

public class ProductDTO : INotifyPropertyChanged
{
    private string name = string.Empty;
    private string description = string.Empty;
    private int price;

    [Browsable(false)]
    public int Id { get; set; }
    public string Name
    {
        get => name;
        set
        {
            if (name.Equals(value, StringComparison.InvariantCulture)) return;
            name = value;
            OnPropertyChanged(nameof(Name));
        }
    }
    public string Description
    {
        get => description;
        set
        {
            if (description.Equals(value, StringComparison.InvariantCulture)) return;
            description = value;
            OnPropertyChanged(nameof(Description));
        }
    }
    public int Price
    {
        get => price;
        set
        {
            if (price == value) return;
            price = value;
            OnPropertyChanged(nameof(Price));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
