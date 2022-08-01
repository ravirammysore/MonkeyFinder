using MonkeyFinder.Model;


namespace MonkeyFinder.View;

public partial class MainPage : ContentPage
{	
	public MainPage()
	{
		InitializeComponent();
		ShowMonkeys();
       
    }	

	public void ShowMonkeys()
	{       
        var m1 = new Monkey
        {
            Name = "Baboon",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/baboon.jpg",
            Location = "Africa and Asia"
        };

        var m2 = new Monkey
        {
            Name = "Capuchin Monkey",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/capuchin.jpg",
            Location = "Central and South America"
        };

        var m3 = new Monkey
        {
            Name = "Red-shanked douc",
            Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/douc.jpg",
            Location = "Vietnam"
        };

        Monkey[] monkeys = {m1, m2, m3};

        collectionView.ItemsSource = monkeys;
    }
}
