namespace MauiApp3.Components;

public partial class RegistrationForm : ContentView
{
    public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(RegistrationForm), string.Empty);

    public string CardTitle
    {
        get => (string)GetValue(RegistrationForm.CardTitleProperty);
        set => SetValue(RegistrationForm.CardTitleProperty, value);
    }

    public RegistrationForm()
	{
		InitializeComponent();
        BindingContext = this;
	}
}