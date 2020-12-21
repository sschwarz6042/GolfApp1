using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GolfApp1.Views
{
    public class NewRoundPage : ContentPage
    {
        public NewRoundPage()
        {
            this.BackgroundImageSource = "SharecardBase.png";
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }
                }
            };
        }
    }
}