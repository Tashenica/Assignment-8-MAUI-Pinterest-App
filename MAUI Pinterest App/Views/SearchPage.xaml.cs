using MAUI_Pinterest_App.Models;

namespace MAUI_Pinterest_App.Views;

public partial class SearchPage : ContentPage
{
    public List<PinItem> Categories { get; set; }
    public SearchPage()
    {
        InitializeComponent();

        Categories = new List<PinItem>
        {
            new PinItem { ImageUrl="category1.png", Title="Date Ideas", Description="A collection of romantic date ideas." },
            new PinItem { ImageUrl="category2.png", Title="Braiding Styles", Description="Lemonade braids with curls."},
            new PinItem { ImageUrl="category3.png", Title="Sunflowers", Description="A collage of sunflowers." },
            new PinItem { ImageUrl="category4.png", Title="Butterfly with Sunflowers", Description="A wallpaper that display a butterfly with sunflowers" },
            new PinItem { ImageUrl="category5.png", Title="Butterfly in Ocean", Description="A wallpaper with butterflies in the ocean." },
            new PinItem { ImageUrl="category6.png", Title="Photoshoot Ideas", Description="A perfect spot light photoshoot." },
        };
        BindingContext = this;
    }
}