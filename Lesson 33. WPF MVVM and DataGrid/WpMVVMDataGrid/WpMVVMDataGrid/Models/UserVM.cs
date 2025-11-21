using System.ComponentModel;

namespace WpMVVMDataGrid.Models;

/// <summary>
/// INotifyPropertyChanged наслідуємо для реалізації MVVM патерну
/// Має подію PropertyChanged, яка сповіщає View про зміни у ViewModel
/// </summary>
public class UserVM : INotifyPropertyChanged
{
    public int Id { get; set; }

    private string _name;

    private string _image;

    public string Name
    {
        get { return _name; }
        set 
        {
            if (_name != value) 
            {
                _name = value;
                NotifyPropertyChanged("Name");
            }
             
        }
    }

    public string Image
    {
        get { return _image; }
        set
        {
            if (_image != value)
            {
                _image = value;
                NotifyPropertyChanged("Image");
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// NotifyPropertyChanged(string propertyName) - 
    /// метод, який викликає подію PropertyChanged
    /// </summary>
    public void NotifyPropertyChanged(string propertyName)
    {
        //Привязуємо властивість до події PropertyChanged
        PropertyChanged?.Invoke(this, 
            new PropertyChangedEventArgs(propertyName));
    }
}
