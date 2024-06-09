using System.ComponentModel;

namespace DTO;

public class CustomerDTO : INotifyPropertyChanged
{
    private string name = string.Empty;
    private int age;

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

    public int Age
    {
        get => age;
        set
        {
            if (value == age) return;
            age = value;
            OnPropertyChanged(nameof(Age));
        }
    }

    [ReadOnly(true)]
    public int TotalSum { get; set; }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
