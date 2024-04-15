using System.Windows.Input;

namespace MauiApp5;

public partial class MyItemTemplate : ContentView
{
    public ICommand ApriCommand
    {
        get { return (ICommand)GetValue(ApriCommandProperty); }
        set { SetValue(ApriCommandProperty, value); }
    }
    public static readonly BindableProperty ApriCommandProperty = BindableProperty.Create(
        propertyName: nameof(ApriCommand),
        returnType: typeof(ICommand),
        declaringType: typeof(MyItemTemplate),
        defaultValue: null,
        defaultBindingMode: BindingMode.OneWay,
        propertyChanged: (BindableObject bindable, object oldValue, object newValue) =>
        {
            {
                // never called
            }
        }
    );
    public MyItemTemplate()
    {
        InitializeComponent();
    }
}