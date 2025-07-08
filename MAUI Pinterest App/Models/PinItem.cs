namespace MAUI_Pinterest_App.Models;

public class PinItem : ContentPage
{
	public required string ImageUrl { get; set; }
	public required new string Title { get; set; }
	public required string Description { get; set; }
	public required string ImageHeight { get; set; }
}
