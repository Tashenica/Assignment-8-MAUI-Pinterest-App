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
            new PinItem { ImageUrl="pin1.png", 
                          Title="Nail Designs", 
                          Description="A set of nude french nails with leopard designs with a tough of red."},
            new PinItem { ImageUrl="pin2.png", 
                          Title="Beauty of Nature", 
                          Description="A beautiful collage of sunsets." },
            new PinItem { ImageUrl="pin3.png", 
                          Title="Content Ideas", 
                          Description="Some Content Ideas"},
            new PinItem { ImageUrl="pin4.png", 
                          Title="Bible Verse", 
                          Description="/Girl, Get Up/ Motivation bible verse"},
            new PinItem { ImageUrl="pin5.png", 
                          Title="Sunset with Daisies", 
                          Description="A field full of daisies with a amazing sunset."},
            new PinItem { ImageUrl="pin6.png", 
                          Title="Sunflower field", 
                          Description="A field full of sunflowers with a beautiful sunrise."},
        };

        BindingContext = this;
    }

    private async void PinsCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        
 
        var selectedPin = e.CurrentSelection.FirstOrDefault() as PinItem;
        if (selectedPin != null)
        {
            await Navigation.PushAsync(new PinDetailsPage(selectedPin));

            //Deselect the item after navigating
            ((CollectionView)sender).SelectedItem = null;   
        }
    }

}