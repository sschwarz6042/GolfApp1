using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GolfApp1.Views
{
    public class NewRoundPage : ContentPage
    {
        private int courseNum = 0;
        private myLabel baseLabel;
        private HandicapStrokeLabel handicapLabel;
        private SpecialStrokeLabel specialLabel;

        private myLabel holeLabel;
        private myLabel h1Label;
        private myLabel h2Label;
        private myLabel h3Label;
        private myLabel h4Label;
        private myLabel h5Label;
        private myLabel h6Label;
        private myLabel h7Label;
        private myLabel h8Label;
        private myLabel h9Label;
        private myLabel h10Label;
        private myLabel h11Label;
        private myLabel h12Label;
        private myLabel h13Label;
        private myLabel h14Label;
        private myLabel h15Label;
        private myLabel h16Label;
        private myLabel h17Label;
        private myLabel h18Label;

        private parLabel holeParLabel;
        private parLabel p1Label;
        private parLabel p2Label;
        private parLabel p3Label;
        private parLabel p4Label;
        private parLabel p5Label;
        private parLabel p6Label;
        private parLabel p7Label;
        private parLabel p8Label;
        private parLabel p9Label;
        private parLabel p10Label;
        private parLabel p11Label;
        private parLabel p12Label;
        private parLabel p13Label;
        private parLabel p14Label;
        private parLabel p15Label;
        private parLabel p16Label;
        private parLabel p17Label;
        private parLabel p18Label;

        private RawEntry h1rEntry;
        private RawEntry h2rEntry;
        private RawEntry h3rEntry;
        private RawEntry h4rEntry;
        private RawEntry h5rEntry;
        private RawEntry h6rEntry;
        private RawEntry h7rEntry;
        private RawEntry h8rEntry;
        private RawEntry h9rEntry;
        private RawEntry h10rEntry;
        private RawEntry h11rEntry;
        private RawEntry h12rEntry;
        private RawEntry h13rEntry;
        private RawEntry h14rEntry;
        private RawEntry h15rEntry;
        private RawEntry h16rEntry;
        private RawEntry h17rEntry;
        private RawEntry h18rEntry;
        private HandicapStrokeLabel h1hcEntry;
        private HandicapStrokeLabel h2hcEntry;
        private HandicapStrokeLabel h3hcEntry;
        private HandicapStrokeLabel h4hcEntry;
        private HandicapStrokeLabel h5hcEntry;
        private HandicapStrokeLabel h6hcEntry;
        private HandicapStrokeLabel h7hcEntry;
        private HandicapStrokeLabel h8hcEntry;
        private HandicapStrokeLabel h9hcEntry;
        private HandicapStrokeLabel h10hcEntry;
        private HandicapStrokeLabel h11hcEntry;
        private HandicapStrokeLabel h12hcEntry;
        private HandicapStrokeLabel h13hcEntry;
        private HandicapStrokeLabel h14hcEntry;
        private HandicapStrokeLabel h15hcEntry;
        private HandicapStrokeLabel h16hcEntry;
        private HandicapStrokeLabel h17hcEntry;
        private HandicapStrokeLabel h18hcEntry;
        private SpecialStrokeLabel h1spEntry;
        private SpecialStrokeLabel h2spEntry;
        private SpecialStrokeLabel h3spEntry;
        private SpecialStrokeLabel h4spEntry;
        private SpecialStrokeLabel h5spEntry;
        private SpecialStrokeLabel h6spEntry;
        private SpecialStrokeLabel h7spEntry;
        private SpecialStrokeLabel h8spEntry;
        private SpecialStrokeLabel h9spEntry;
        private SpecialStrokeLabel h10spEntry;
        private SpecialStrokeLabel h11spEntry;
        private SpecialStrokeLabel h12spEntry;
        private SpecialStrokeLabel h13spEntry;
        private SpecialStrokeLabel h14spEntry;
        private SpecialStrokeLabel h15spEntry;
        private SpecialStrokeLabel h16spEntry;
        private SpecialStrokeLabel h17spEntry;
        private SpecialStrokeLabel h18spEntry;


        public class myLabel : Label {
            public myLabel() {
                this.FontAttributes = FontAttributes.Bold;
                this.FontSize = 25;
            }
        }

        public class parLabel : Label
        {
            public parLabel()
            {
                this.FontAttributes = FontAttributes.Bold;
                this.FontSize = 25;
                this.TextColor = Color.Maroon;
            }
        }

        public class RawEntry : Entry{
            public RawEntry() {
                this.BackgroundColor = Color.White;
                this.FontAttributes = FontAttributes.Bold;
                this.FontSize = 25;
                this.Text = "0";
            }
        }
        public class HandicapStrokeLabel : Label
        {
            public HandicapStrokeLabel()
            {
                //this.BackgroundColor = Color.White;
                this.TextColor = Color.DarkBlue;
                this.FontAttributes = FontAttributes.Bold;
                this.FontSize = 25;
                this.Text = "0";
            }
        }
        public class SpecialStrokeLabel : Label
        {
            public SpecialStrokeLabel()
            {
                //this.BackgroundColor = Color.White;
                this.TextColor = Color.SaddleBrown;
                this.FontAttributes = FontAttributes.Bold;
                this.FontSize = 25;
                this.Text = "0";
            }
        }

        public NewRoundPage(int cNum)
        {
            this.courseNum = cNum;
            this.BackgroundImageSource = "SharecardBase.png";
            ScrollView scrollView = new ScrollView();
            scrollView.Orientation = ScrollOrientation.Horizontal;
            Grid grid = new Grid();
            //this.RotateTo(90);

            holeLabel = new myLabel();
            h1Label = new myLabel();
            h2Label = new myLabel();
            h3Label = new myLabel();
            h4Label = new myLabel();
            h5Label = new myLabel();
            h6Label = new myLabel();
            h7Label = new myLabel();
            h8Label = new myLabel();
            h9Label = new myLabel();
            h10Label = new myLabel();
            h11Label = new myLabel();
            h12Label = new myLabel();
            h13Label = new myLabel();
            h14Label = new myLabel();
            h15Label = new myLabel();
            h16Label = new myLabel();
            h17Label = new myLabel();
            h18Label = new myLabel();

            holeLabel.Text = "Hole Number:";
            h1Label.Text = "#1";
            h2Label.Text = "#2";
            h3Label.Text = "#3";
            h4Label.Text = "#4";
            h5Label.Text = "#5";
            h6Label.Text = "#6";
            h7Label.Text = "#7";
            h8Label.Text = "#8";
            h9Label.Text = "#9";
            h10Label.Text = "#10";
            h11Label.Text = "#11";
            h12Label.Text = "#12";
            h13Label.Text = "#13";
            h14Label.Text = "#14";
            h15Label.Text = "#15";
            h16Label.Text = "#16";
            h17Label.Text = "#17";
            h18Label.Text = "#18";

            holeParLabel = new parLabel();
            p1Label = new parLabel();
            p2Label = new parLabel();
            p3Label = new parLabel();
            p4Label = new parLabel();
            p5Label = new parLabel();
            p6Label = new parLabel();
            p7Label = new parLabel();
            p8Label = new parLabel();
            p9Label = new parLabel();
            p10Label = new parLabel();
            p11Label = new parLabel();
            p12Label = new parLabel();
            p13Label = new parLabel();
            p14Label = new parLabel();
            p15Label = new parLabel();
            p16Label = new parLabel();
            p17Label = new parLabel();
            p18Label = new parLabel();

            holeParLabel.Text = "Par:";
            p1Label.Text = "0";
            p2Label.Text = "0";
            p3Label.Text = "0";
            p4Label.Text = "0";
            p5Label.Text = "0";
            p6Label.Text = "0";
            p7Label.Text = "0";
            p8Label.Text = "0";
            p9Label.Text = "0";
            p10Label.Text = "0";
            p11Label.Text = "0";
            p12Label.Text = "0";
            p13Label.Text = "0";
            p14Label.Text = "0";
            p15Label.Text = "0";
            p16Label.Text = "0";
            p17Label.Text = "0";
            p18Label.Text = "0";

            baseLabel = new myLabel();
            baseLabel.Text = "Score:";
            handicapLabel = new HandicapStrokeLabel();
            handicapLabel.Text = "Handicap Strokes:";
            specialLabel = new SpecialStrokeLabel();
            specialLabel.Text = "Beer Strokes:";

            h1rEntry = new RawEntry();
            h2rEntry = new RawEntry();
            h3rEntry = new RawEntry();
            h4rEntry = new RawEntry();
            h5rEntry = new RawEntry();
            h6rEntry = new RawEntry();
            h7rEntry = new RawEntry();
            h8rEntry = new RawEntry();
            h9rEntry = new RawEntry();
            h10rEntry = new RawEntry();
            h11rEntry = new RawEntry();
            h12rEntry = new RawEntry();
            h13rEntry = new RawEntry();
            h14rEntry = new RawEntry();
            h15rEntry = new RawEntry();
            h16rEntry = new RawEntry();
            h17rEntry = new RawEntry();
            h18rEntry = new RawEntry();
            h1hcEntry = new HandicapStrokeLabel();
            h2hcEntry = new HandicapStrokeLabel();
            h3hcEntry = new HandicapStrokeLabel();
            h4hcEntry = new HandicapStrokeLabel();
            h5hcEntry = new HandicapStrokeLabel();
            h6hcEntry = new HandicapStrokeLabel();
            h7hcEntry = new HandicapStrokeLabel();
            h8hcEntry = new HandicapStrokeLabel();
            h9hcEntry = new HandicapStrokeLabel();
            h10hcEntry = new HandicapStrokeLabel();
            h11hcEntry = new HandicapStrokeLabel();
            h12hcEntry = new HandicapStrokeLabel();
            h13hcEntry = new HandicapStrokeLabel();
            h14hcEntry = new HandicapStrokeLabel();
            h15hcEntry = new HandicapStrokeLabel();
            h16hcEntry = new HandicapStrokeLabel();
            h17hcEntry = new HandicapStrokeLabel();
            h18hcEntry = new HandicapStrokeLabel();
            h1spEntry = new SpecialStrokeLabel();
            h2spEntry = new SpecialStrokeLabel();
            h3spEntry = new SpecialStrokeLabel();
            h4spEntry = new SpecialStrokeLabel();
            h5spEntry = new SpecialStrokeLabel();
            h6spEntry = new SpecialStrokeLabel();
            h7spEntry = new SpecialStrokeLabel();
            h8spEntry = new SpecialStrokeLabel();
            h9spEntry = new SpecialStrokeLabel();
            h10spEntry = new SpecialStrokeLabel();
            h11spEntry = new SpecialStrokeLabel();
            h12spEntry = new SpecialStrokeLabel();
            h13spEntry = new SpecialStrokeLabel();
            h14spEntry = new SpecialStrokeLabel();
            h15spEntry = new SpecialStrokeLabel();
            h16spEntry = new SpecialStrokeLabel(); 
            h17spEntry = new SpecialStrokeLabel();
            h18spEntry = new SpecialStrokeLabel();

            grid.Children.Add(holeLabel, 0, 0);
            grid.Children.Add(h1Label, 1, 0);
            grid.Children.Add(h2Label, 2, 0);
            grid.Children.Add(h3Label, 3, 0);
            grid.Children.Add(h4Label, 4, 0);
            grid.Children.Add(h5Label, 5, 0);
            grid.Children.Add(h6Label, 6, 0);
            grid.Children.Add(h7Label, 7, 0);
            grid.Children.Add(h8Label, 8, 0);
            grid.Children.Add(h9Label, 9, 0);
            grid.Children.Add(h10Label, 10, 0);
            grid.Children.Add(h11Label, 11, 0);
            grid.Children.Add(h12Label, 12, 0);
            grid.Children.Add(h13Label, 13, 0);
            grid.Children.Add(h14Label, 14, 0);
            grid.Children.Add(h15Label, 15, 0);
            grid.Children.Add(h16Label, 16, 0);
            grid.Children.Add(h17Label, 17, 0);
            grid.Children.Add(h18Label, 18, 0);


            grid.Children.Add(holeParLabel, 0, 1);
            grid.Children.Add(p1Label, 1, 1);
            grid.Children.Add(p2Label, 2, 1);
            grid.Children.Add(p3Label, 3, 1);
            grid.Children.Add(p4Label, 4, 1);
            grid.Children.Add(p5Label, 5, 1);
            grid.Children.Add(p6Label, 6, 1);
            grid.Children.Add(p7Label, 7, 1);
            grid.Children.Add(p8Label, 8, 1);
            grid.Children.Add(p9Label, 9, 1);
            grid.Children.Add(p10Label, 10, 1);
            grid.Children.Add(p11Label, 11, 1);
            grid.Children.Add(p12Label, 12, 1);
            grid.Children.Add(p13Label, 13, 1);
            grid.Children.Add(p14Label, 14, 1);
            grid.Children.Add(p15Label, 15, 1);
            grid.Children.Add(p16Label, 16, 1);
            grid.Children.Add(p17Label, 17, 1);
            grid.Children.Add(p18Label, 18, 1);

            grid.Children.Add(baseLabel, 0, 2);
            grid.Children.Add(handicapLabel, 0, 3);
            grid.Children.Add(specialLabel, 0, 4);


            grid.Children.Add(h1rEntry, 1, 2);
            grid.Children.Add(h2rEntry, 2, 2);
            grid.Children.Add(h3rEntry, 3, 2);
            grid.Children.Add(h4rEntry, 4, 2);
            grid.Children.Add(h5rEntry, 5, 2);
            grid.Children.Add(h6rEntry, 6, 2);
            grid.Children.Add(h7rEntry, 7, 2);
            grid.Children.Add(h8rEntry, 8, 2);
            grid.Children.Add(h9rEntry, 9, 2);
            grid.Children.Add(h10rEntry, 10, 2);
            grid.Children.Add(h11rEntry, 11, 2);
            grid.Children.Add(h12rEntry, 12, 2);
            grid.Children.Add(h13rEntry, 13, 2);
            grid.Children.Add(h14rEntry, 14, 2);
            grid.Children.Add(h15rEntry, 15, 2);
            grid.Children.Add(h16rEntry, 16, 2);
            grid.Children.Add(h17rEntry, 17, 2);
            grid.Children.Add(h18rEntry, 18, 2);

            grid.Children.Add(h1hcEntry, 1, 3);
            grid.Children.Add(h2hcEntry, 2, 3);
            grid.Children.Add(h3hcEntry, 3, 3);
            grid.Children.Add(h4hcEntry, 4, 3);
            grid.Children.Add(h5hcEntry, 5, 3);
            grid.Children.Add(h6hcEntry, 6, 3);
            grid.Children.Add(h7hcEntry, 7, 3);
            grid.Children.Add(h8hcEntry, 8, 3);
            grid.Children.Add(h9hcEntry, 9, 3);
            grid.Children.Add(h10hcEntry, 10, 3);
            grid.Children.Add(h11hcEntry, 11, 3);
            grid.Children.Add(h12hcEntry, 12, 3);
            grid.Children.Add(h13hcEntry, 13, 3);
            grid.Children.Add(h14hcEntry, 14, 3);
            grid.Children.Add(h15hcEntry, 15, 3);
            grid.Children.Add(h16hcEntry, 16, 3);
            grid.Children.Add(h17hcEntry, 17, 3);
            grid.Children.Add(h18hcEntry, 18, 3);

            grid.Children.Add(h1spEntry, 1, 4);
            grid.Children.Add(h2spEntry, 2, 4);
            grid.Children.Add(h3spEntry, 3, 4);
            grid.Children.Add(h4spEntry, 4, 4);
            grid.Children.Add(h5spEntry, 5, 4);
            grid.Children.Add(h6spEntry, 6, 4);
            grid.Children.Add(h7spEntry, 7, 4);
            grid.Children.Add(h8spEntry, 8, 4);
            grid.Children.Add(h9spEntry, 9, 4);
            grid.Children.Add(h10spEntry, 10, 4);
            grid.Children.Add(h11spEntry, 11, 4);
            grid.Children.Add(h12spEntry, 12, 4);
            grid.Children.Add(h13spEntry, 13, 4);
            grid.Children.Add(h14spEntry, 14, 4);
            grid.Children.Add(h15spEntry, 15, 4);
            grid.Children.Add(h16spEntry, 16, 4);
            grid.Children.Add(h17spEntry, 17, 4);
            grid.Children.Add(h18spEntry, 18, 4);


            scrollView.Content = grid;
            Content = scrollView;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Send(this, "PreventPortrait");
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Send(this, "PreventLandscape");
        }
    }
}