using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp5
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class MyClass
    {
        public int ID { get; set; }
        public string Value { get; set; } = "";
    }

    public partial class ViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<MyClass> _list;

        [RelayCommand]
        private async Task MyCommand(MyClass val)
        {
            // never called
            await Application.Current.MainPage.DisplayAlert("Selected", val.Value, "ok");
        }

        public ViewModel()
        {
            List = [];
            for (int i = 0; i < 30; i++)
            {
                List.Add(new() { ID = i, Value = $"I_{i}" });
            }
        }
    }

}


