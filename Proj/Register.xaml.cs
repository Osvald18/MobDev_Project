using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj;

public partial class Register : ContentPage
{
    public Register()
    {
        InitializeComponent();
    }
    
    private void OnCounterClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("HomePage");
    }
    
}