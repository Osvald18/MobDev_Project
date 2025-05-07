using Microsoft.Maui.Controls;

namespace Proj;

[QueryProperty(nameof(Image), "image")]
[QueryProperty(nameof(Name), "name")]
[QueryProperty(nameof(Description), "desc")]
[QueryProperty(nameof(Date), "date")]
[QueryProperty(nameof(Location), "location")]
[QueryProperty(nameof(Founded), "founded")]
public partial class ItemDetails : ContentPage
{
    public ItemDetails()
    {
        InitializeComponent();
    }

    string image;
    public string Image
    {
        get => image;
        set
        {
            image = Uri.UnescapeDataString(value);
            ItemImage.Source = image;
        }
    }

    string name;
    public string Name
    {
        get => name;
        set
        {
            name = Uri.UnescapeDataString(value);
            ItemName.Text = name;
        }
    }

    string description;
    public string Description
    {
        get => description;
        set
        {
            description = Uri.UnescapeDataString(value);
            ItemDescription.Text = description;
        }
    }
    
    string date;
    
    public string Date
    {
        get => date;
        set
        {
            date = Uri.UnescapeDataString(value);
            ItemDate.Text = date;
        }
    }
    
    string location;
    
    public string Location
    {
        get => location;
        set
        {
            location = Uri.UnescapeDataString(value);
            ItemLocation.Text = location;
        }
    }
    
    string founded;
    
    public string Founded
    {
        get => founded;
        set
        {
            founded = Uri.UnescapeDataString(value);
            ItemFounded.Text = founded;
        }
    }
    
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
    
    private async void OnNextClicked(object sender, EventArgs e)
    {
        // Navigate to profile page or show a popup
        await Shell.Current.GoToAsync("..");
    }
    
}