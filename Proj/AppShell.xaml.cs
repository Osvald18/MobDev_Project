namespace Proj;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute("itemdetails", typeof(ItemDetails));
        Routing.RegisterRoute("HomePage", typeof(HomePage));
    }
    
    
}