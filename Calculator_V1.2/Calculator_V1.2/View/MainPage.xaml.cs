using Calculator_V1._2.ViewModel;
using Microsoft.Maui.Controls.PlatformConfiguration;

namespace Calculator_V1._2.View;


public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new CalcViewModel();
    }
}



