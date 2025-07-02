using MAUI_Pinterest_App.Models;

namespace MAUI_Pinterest_App.Views;

public partial class HomePage : ContentPage
{
    public List<PinItem> Pins { get; set; }
    public HomePage()
    {
        InitializeComponent();

        Pins = new List<PinItem>
        {
            new PinItem { ImageUrl="pin1.png", Title="Nail Designs", Description="Beautiful set Frenchies with a pink and leopard print"},
        };

        BindingContext = this;
    }

    private async void PinsCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is PinItem selectedPin)
        {
            await Navigation.PushAsync(new PinDetailsPage(selectedPin));
        }
    }

}