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
                          Description="This manicure features a square-shaped French tip design on natural pink nude base nails. The look combines bold red French tips with accent nails showcasing a leopard print tip and a fine red smile line, creating a stylish mix of classic elegance and playful animal print art. The nails are finished with a high-gloss top coat, enhancing the sharpness of the red and the detail of the leopard design.This manicure features a square-shaped French tip design on natural pink nude base nails. The look combines bold red French tips with accent nails showcasing a leopard print tip and a fine red smile line, creating a stylish mix of classic elegance and playful animal print art. The nails are finished with a high-gloss top coat, enhancing the sharpness of the red and the detail of the leopard design."},
            new PinItem { ImageUrl="pin2.png", 
                          Title="Beauty of Nature", 
                          Description="This collage beautifully captures warm golden sunsets, peaceful beachscapes, and dreamy silhouettes of nature. It features glowing horizons over calm oceans, silhouetted birds perched on branches, delicate flowers against sunset skies, and serene moments of butterflies resting on blooms. Each image radiates tranquility, natural beauty, and the soothing essence of dusk, creating an overall aesthetic of calm, romance, and reflection." },
            new PinItem { ImageUrl="pin3.png", 
                          Title="Content Ideas", 
                          Description="This image provides a list of YouTube content ideas on a light purple background with black and pink text. It includes suggestions such as Day In My Life, Mukbang, Night Out With Friends, Skin Care Routine, Clothing Try On Haul, Hair/Nail Appointment, Recent Purchases, Vacation Mini Vlog, Content Creator Essentials, Sunday Reset, Unboxing Video, Cooking/Meal Prep, Sunday Funday, Workout Routine, and Room Makeover. Each idea is accompanied by a heart icon, offering inspiration for lifestyle, beauty, vlog, and daily content creators."},
            new PinItem { ImageUrl="pin4.png", 
                          Title="Bible Verse", 
                          Description="A faith-based motivational image designed as a wallpaper or graphic, featuring the empowering phrase \"Girl, Get Up!\" prominently displayed over a blurred pink heart, along with the corresponding Bible verse Luke 8:54-55, both referenced and quoted in full."},
            new PinItem { ImageUrl="pin5.png", 
                          Title="Sunset with Daisies", 
                          Description="The image captures a breathtaking sunset over a vast field filled with white daisies. The sky is painted in brilliant hues of orange, gold, and deep blue, with scattered, textured clouds catching the golden light. The sun is a bright disc just above the distant treeline, casting long rays over the blooming flowers in the foreground, which appear radiant in the warm light."},
            new PinItem { ImageUrl="pin6.png", 
                          Title="Sunflower field", 
                          Description="A close-up shot of a butterfly with intricate wing patterns, bathed in the warm light of a setting sun. It is positioned among a field of orange and yellow wildflowers, with the glowing sun just above the distant treeline, creating a magical and serene atmosphere."},
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