namespace MauiApp1.Views;

public partial class Sobre : ContentPage
{
    public Sobre()
    {
        InitializeComponent();
    }
private async void IrParaReserva_Clicked(object? sender, EventArgs e)
{
    await Navigation.PopAsync();
}
}