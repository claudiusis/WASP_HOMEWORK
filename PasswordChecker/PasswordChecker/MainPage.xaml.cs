using Android.Service.Controls;

namespace PasswordChecker;

public partial class MainPage : ContentPage
{
	int count = 0;
	const string password = "125498";

	public MainPage()
	{
		InitializeComponent();
	}

	public void NumClick(object sender, EventArgs e)
	{
		DisplayLabel.Text+=(sender as Button).Text;
	}

	public void crossClick(object sender, EventArgs e)
	{
		DisplayLabel.Text = "";
	}

	public void tickClick(object sender, EventArgs e)
	{
		if (DisplayLabel.Text == password)
		{
			DisplayLabel.Text = "CORRECT!";
			foreach(View c in ((sender as Button).Parent as Grid).Children.Cast<View>())
			{
				c.IsEnabled = false;
			}
			DisplayLabel.IsEnabled = false;
		}
		else
		{
			DisplayLabel.Text = "";
		}
	}

}

