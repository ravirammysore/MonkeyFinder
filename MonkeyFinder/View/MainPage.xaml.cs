﻿using MonkeyFinder.Model;


namespace MonkeyFinder.View;

public partial class MainPage : ContentPage
{
	Monkey m1;
	public MainPage()
	{
		InitializeComponent();
       
    }

	private void btnShow_Clicked(object sender, EventArgs e)
	{
        m1 = new Monkey
        {
            Name = "Baboon",
            Details = "Africa and Asia"
        };

        this.BindingContext = m1;
    }
}
