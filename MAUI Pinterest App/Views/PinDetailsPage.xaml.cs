using MAUI_Pinterest_App.Models;

namespace MAUI_Pinterest_App.Views;

public partial class PinDetailsPage : ContentPage
{
    public PinDetailsPage(PinItem selectedPin)
    {
        InitializeComponent();

        PinImage.Source = selectedPin.ImageUrl;
        PinTitle.Text = selectedPin.Title;
        PinDescription.Text = selectedPin.Description;
    }
}