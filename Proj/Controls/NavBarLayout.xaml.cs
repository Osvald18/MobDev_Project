using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Proj.Controls;

public partial class NavBarLayout : ContentView
{
    public ICommand BackCommand { get; }

    public NavBarLayout()
    {
        InitializeComponent();

        BackCommand = new Command(async () =>
        {
            if (Shell.Current.Navigation.NavigationStack.Count > 1)
                await Shell.Current.Navigation.PopAsync();
        });

        BindingContext = this;
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