using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }
    private async void OnReportLostTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ReportForm_Lost_());
    }

    private async void OnReportFoundTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ReportForm_Found_());
    }

    private async void OnSearchItemTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LostItems());
    }
    
    private bool _flyoutVisible = false;

    private void ToggleFlyoutMenu(object sender, EventArgs e)
    {
        _flyoutVisible = !_flyoutVisible;
        FlyoutMenu.IsVisible = _flyoutVisible;
    }

    private void CloseFlyoutMenu(object sender, EventArgs e)
    {
        _flyoutVisible = false;
        FlyoutMenu.IsVisible = false;
    }

}