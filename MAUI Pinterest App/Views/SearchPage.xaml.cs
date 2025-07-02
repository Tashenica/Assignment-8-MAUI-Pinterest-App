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
            new PinItem { ImageUrl="category1.png", Title="Date Ideas" },
        };
    }
}