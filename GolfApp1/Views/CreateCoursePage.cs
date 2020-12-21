using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GolfApp1.Views
{
    public class CreateCoursePage : ContentPage
    {
        private Entry nameEntry;
        private Entry parEntry;
        private Entry h1Entry;
        private Entry h2Entry;
        private Entry h3Entry;
        private Entry h4Entry;
        private Entry h5Entry;
        private Entry h6Entry;
        private Entry h7Entry;
        private Entry h8Entry;
        private Entry h9Entry;
        private Entry h10Entry;
        private Entry h11Entry;
        private Entry h12Entry;
        private Entry h13Entry;
        private Entry h14Entry;
        private Entry h15Entry;
        private Entry h16Entry;
        private Entry h17Entry;
        private Entry h18Entry;
        private Button createCourseButton;

        public CreateCoursePage()
        {
            this.BackgroundImageSource = "SharecardBase.png";
            StackLayout stackLayout = new StackLayout();



            Content = stackLayout;
        }
    }
}