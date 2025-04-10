using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSplashApp.Pages;

public partial class SplashPage : ContentPage
{
    private static readonly TimeSpan Delay = TimeSpan.FromSeconds(2);
    
    public SplashPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        await Task.Delay(Delay);

        if (Window is not null)
        {
            Window.Page = new MainPage();
        }
        else
        {
            Trace.WriteLine("Window is null, unable to navigate to MainPage.");
        }
    }
}