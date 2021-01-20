using GolfApp1.Helpers;
using GolfApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GolfApp1.Views
{
    public class NewRoundPage : ContentPage
    {
        private SessionData sd;
        private Button addPlayersButton;
        private Button viewLeaderBoardButton;

        private myLabel baseLabel;
        private HandicapScoreLabel hScoreLabel;
        private HandicapStrokeLabel handicapLabel;
        private SpecialStrokeLabel specialLabel;

        private myLabel holeLabel = new myLabel();
        private myLabel h1Label = new myLabel();
        private myLabel h2Label = new myLabel();
        private myLabel h3Label = new myLabel();
        private myLabel h4Label = new myLabel();
        private myLabel h5Label = new myLabel();
        private myLabel h6Label = new myLabel();
        private myLabel h7Label = new myLabel();
        private myLabel h8Label = new myLabel();
        private myLabel h9Label = new myLabel();
        private myLabel h10Label = new myLabel();
        private myLabel h11Label = new myLabel();
        private myLabel h12Label = new myLabel();
        private myLabel h13Label = new myLabel();
        private myLabel h14Label = new myLabel();
        private myLabel h15Label = new myLabel();
        private myLabel h16Label = new myLabel();
        private myLabel h17Label = new myLabel();
        private myLabel h18Label = new myLabel();

        private parLabel holeParLabel = new parLabel();
        private parLabel p1Label = new parLabel();
        private parLabel p2Label = new parLabel();
        private parLabel p3Label = new parLabel();
        private parLabel p4Label = new parLabel();
        private parLabel p5Label = new parLabel();
        private parLabel p6Label = new parLabel();
        private parLabel p7Label = new parLabel();
        private parLabel p8Label = new parLabel();
        private parLabel p9Label = new parLabel();
        private parLabel p10Label = new parLabel();
        private parLabel p11Label = new parLabel();
        private parLabel p12Label = new parLabel();
        private parLabel p13Label = new parLabel();
        private parLabel p14Label = new parLabel();
        private parLabel p15Label = new parLabel();
        private parLabel p16Label = new parLabel();
        private parLabel p17Label = new parLabel();
        private parLabel p18Label = new parLabel();

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
        private HandicapStrokeLabel h1hcEntry = new HandicapStrokeLabel();
        private HandicapStrokeLabel h2hcEntry = new HandicapStrokeLabel();
        private HandicapStrokeLabel h3hcEntry = new HandicapStrokeLabel();
        private HandicapStrokeLabel h4hcEntry = new HandicapStrokeLabel();
        private HandicapStrokeLabel h5hcEntry = new HandicapStrokeLabel();
        private HandicapStrokeLabel h6hcEntry = new HandicapStrokeLabel();
        private HandicapStrokeLabel h7hcEntry = new HandicapStrokeLabel();
        private HandicapStrokeLabel h8hcEntry = new HandicapStrokeLabel();
        private HandicapStrokeLabel h9hcEntry = new HandicapStrokeLabel();
        private HandicapStrokeLabel h10hcEntry = new HandicapStrokeLabel();
        private HandicapStrokeLabel h11hcEntry = new HandicapStrokeLabel();
        private HandicapStrokeLabel h12hcEntry = new HandicapStrokeLabel();
        private HandicapStrokeLabel h13hcEntry = new HandicapStrokeLabel();
        private HandicapStrokeLabel h14hcEntry = new HandicapStrokeLabel();
        private HandicapStrokeLabel h15hcEntry = new HandicapStrokeLabel();
        private HandicapStrokeLabel h16hcEntry = new HandicapStrokeLabel();
        private HandicapStrokeLabel h17hcEntry = new HandicapStrokeLabel();
        private HandicapStrokeLabel h18hcEntry = new HandicapStrokeLabel();
        private SpecialStrokeEntry h1spEntry = new SpecialStrokeEntry(-1, "h1sp");
        private SpecialStrokeEntry h2spEntry = new SpecialStrokeEntry(-1, "h2sp");
        private SpecialStrokeEntry h3spEntry = new SpecialStrokeEntry(-1, "h3sp");
        private SpecialStrokeEntry h4spEntry = new SpecialStrokeEntry(-1, "h4sp");
        private SpecialStrokeEntry h5spEntry = new SpecialStrokeEntry(-1, "h5sp");
        private SpecialStrokeEntry h6spEntry = new SpecialStrokeEntry(-1, "h6sp");
        private SpecialStrokeEntry h7spEntry = new SpecialStrokeEntry(-1, "h7sp");
        private SpecialStrokeEntry h8spEntry = new SpecialStrokeEntry(-1, "h8sp");
        private SpecialStrokeEntry h9spEntry = new SpecialStrokeEntry(-1, "h9sp");
        private SpecialStrokeEntry h10spEntry = new SpecialStrokeEntry(-1, "h10sp");
        private SpecialStrokeEntry h11spEntry = new SpecialStrokeEntry(-1, "h11sp");
        private SpecialStrokeEntry h12spEntry = new SpecialStrokeEntry(-1, "h12sp");
        private SpecialStrokeEntry h13spEntry = new SpecialStrokeEntry(-1, "h13sp");
        private SpecialStrokeEntry h14spEntry = new SpecialStrokeEntry(-1, "h14sp");
        private SpecialStrokeEntry h15spEntry = new SpecialStrokeEntry(-1, "h15sp");
        private SpecialStrokeEntry h16spEntry = new SpecialStrokeEntry(-1, "h16sp");
        private SpecialStrokeEntry h17spEntry = new SpecialStrokeEntry(-1, "h17sp");
        private SpecialStrokeEntry h18spEntry = new SpecialStrokeEntry(-1, "h18sp");

        private HAdjustedScoreLabel h1adjEntry = new HAdjustedScoreLabel();
        private HAdjustedScoreLabel h2adjEntry = new HAdjustedScoreLabel();
        private HAdjustedScoreLabel h3adjEntry = new HAdjustedScoreLabel();
        private HAdjustedScoreLabel h4adjEntry = new HAdjustedScoreLabel();
        private HAdjustedScoreLabel h5adjEntry = new HAdjustedScoreLabel();
        private HAdjustedScoreLabel h6adjEntry = new HAdjustedScoreLabel();
        private HAdjustedScoreLabel h7adjEntry = new HAdjustedScoreLabel();
        private HAdjustedScoreLabel h8adjEntry = new HAdjustedScoreLabel();
        private HAdjustedScoreLabel h9adjEntry = new HAdjustedScoreLabel();
        private HAdjustedScoreLabel h10adjEntry = new HAdjustedScoreLabel();
        private HAdjustedScoreLabel h11adjEntry = new HAdjustedScoreLabel();
        private HAdjustedScoreLabel h12adjEntry = new HAdjustedScoreLabel();
        private HAdjustedScoreLabel h13adjEntry = new HAdjustedScoreLabel();
        private HAdjustedScoreLabel h14adjEntry = new HAdjustedScoreLabel();
        private HAdjustedScoreLabel h15adjEntry = new HAdjustedScoreLabel();
        private HAdjustedScoreLabel h16adjEntry = new HAdjustedScoreLabel();
        private HAdjustedScoreLabel h17adjEntry = new HAdjustedScoreLabel();
        private HAdjustedScoreLabel h18adjEntry = new HAdjustedScoreLabel();

        public class myLabel : Label
        {
            public myLabel()
            {
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

        public class RawEntry : Entry
        {
            public RawEntry()
            {
                this.BackgroundColor = Color.White;
                this.FontAttributes = FontAttributes.Bold;
                this.FontSize = 25;
                this.Text = "0";
                this.Keyboard = Keyboard.Numeric;
                this.MaxLength = 2;
                this.VerticalOptions = LayoutOptions.Center;
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
        public class HandicapScoreLabel : Label
        {
            public HandicapScoreLabel()
            {
                //this.BackgroundColor = Color.White;
                this.TextColor = Color.LightGoldenrodYellow;
                this.FontAttributes = FontAttributes.Bold;
                this.FontSize = 25;
                this.Text = "0";
            }
        }
        public class HAdjustedScoreLabel : Label
        {
            public HAdjustedScoreLabel()
            {
                //this.BackgroundColor = Color.White;
                this.TextColor = Color.LightGoldenrodYellow;
                this.FontAttributes = FontAttributes.Bold;
                this.FontSize = 25;
                this.Text = "0";
            }
        }
        public class SpecialStrokeEntry : Entry
        {
            private int id;
            private string name;
            public SpecialStrokeEntry(int id, string name)
            {
                this.name = name;
                this.BackgroundColor = Color.White;
                this.TextColor = Color.SaddleBrown;
                this.FontAttributes = FontAttributes.Bold;
                this.FontSize = 25;
                this.Text = "0";
                this.TextChanged += SpecialStrokeEntry_TextChanged;
            }

            private async void SpecialStrokeEntry_TextChanged(object sender, TextChangedEventArgs e)
            {
                SpecialStrokeEntry s = sender as SpecialStrokeEntry;
                await DBHelper.getInstance().updateScoreCard(s.getID(), s.getName(), s.Text);
            }

            public string getName()
            {
                return this.name;
            }
            public void setName(string n)
            {
                this.name = n;
            }
            public int getID()
            {
                return this.id;
            }
            public void setID(int i)
            {
                this.id = i;
            }
        }

        public class SpecialStrokeLabel : Label
        {
            public SpecialStrokeLabel()
            {
                this.TextColor = Color.SaddleBrown;
                this.FontAttributes = FontAttributes.Bold;
                this.FontSize = 25;
                this.Text = "0";
            }
        }

        public NewRoundPage(SessionData sessionData)
        {
            this.sd = sessionData;
            this.BackgroundImageSource = "SharecardBase.png";
            ScrollView scrollView = new ScrollView();
            //scrollView.Orientation = ScrollOrientation.Horizontal;
            scrollView.Orientation = ScrollOrientation.Both;
            Grid grid = new Grid();


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
            hScoreLabel = new HandicapScoreLabel();
            hScoreLabel.Text = "Handicap Strokes";
            handicapLabel = new HandicapStrokeLabel();
            handicapLabel.Text = "Course Handicap:";
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

            h1rEntry.TextChanged += H1rEntry_TextChanged;
            h2rEntry.TextChanged += H2rEntry_TextChanged;
            h3rEntry.TextChanged += H3rEntry_TextChanged;
            h4rEntry.TextChanged += H4rEntry_TextChanged;
            h5rEntry.TextChanged += H5rEntry_TextChanged;
            h6rEntry.TextChanged += H6rEntry_TextChanged;
            h7rEntry.TextChanged += H7rEntry_TextChanged;
            h8rEntry.TextChanged += H8rEntry_TextChanged;
            h9rEntry.TextChanged += H9rEntry_TextChanged;
            h10rEntry.TextChanged += H10rEntry_TextChanged;
            h11rEntry.TextChanged += H11rEntry_TextChanged;
            h12rEntry.TextChanged += H12rEntry_TextChanged;
            h13rEntry.TextChanged += H13rEntry_TextChanged;
            h14rEntry.TextChanged += H14rEntry_TextChanged;
            h15rEntry.TextChanged += H15rEntry_TextChanged;
            h16rEntry.TextChanged += H16rEntry_TextChanged;
            h17rEntry.TextChanged += H17rEntry_TextChangedAsync;
            h18rEntry.TextChanged += H18rEntry_TextChanged;


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

            h1spEntry = new SpecialStrokeEntry(sd.currentScoreCard.id, "h1sp");
            h2spEntry = new SpecialStrokeEntry(sd.currentScoreCard.id, "h2sp");
            h3spEntry = new SpecialStrokeEntry(sd.currentScoreCard.id, "h3sp");
            h4spEntry = new SpecialStrokeEntry(sd.currentScoreCard.id, "h4sp");
            h5spEntry = new SpecialStrokeEntry(sd.currentScoreCard.id, "h5sp");
            h6spEntry = new SpecialStrokeEntry(sd.currentScoreCard.id, "h6sp");
            h7spEntry = new SpecialStrokeEntry(sd.currentScoreCard.id, "h7sp");
            h8spEntry = new SpecialStrokeEntry(sd.currentScoreCard.id, "h8sp");
            h9spEntry = new SpecialStrokeEntry(sd.currentScoreCard.id, "h9sp");
            h10spEntry = new SpecialStrokeEntry(sd.currentScoreCard.id, "h10sp");
            h11spEntry = new SpecialStrokeEntry(sd.currentScoreCard.id, "h11sp");
            h12spEntry = new SpecialStrokeEntry(sd.currentScoreCard.id, "h12sp");
            h13spEntry = new SpecialStrokeEntry(sd.currentScoreCard.id, "h13sp");
            h14spEntry = new SpecialStrokeEntry(sd.currentScoreCard.id, "h14sp");
            h15spEntry = new SpecialStrokeEntry(sd.currentScoreCard.id, "h15sp");
            h16spEntry = new SpecialStrokeEntry(sd.currentScoreCard.id, "h16sp");
            h17spEntry = new SpecialStrokeEntry(sd.currentScoreCard.id, "h17sp");
            h18spEntry = new SpecialStrokeEntry(sd.currentScoreCard.id, "h18sp");

            h1adjEntry = new HAdjustedScoreLabel();
            h2adjEntry = new HAdjustedScoreLabel();
            h3adjEntry = new HAdjustedScoreLabel();
            h4adjEntry = new HAdjustedScoreLabel();
            h5adjEntry = new HAdjustedScoreLabel();
            h6adjEntry = new HAdjustedScoreLabel();
            h7adjEntry = new HAdjustedScoreLabel();
            h8adjEntry = new HAdjustedScoreLabel();
            h9adjEntry = new HAdjustedScoreLabel();
            h10adjEntry = new HAdjustedScoreLabel();
            h11adjEntry = new HAdjustedScoreLabel();
            h12adjEntry = new HAdjustedScoreLabel();
            h13adjEntry = new HAdjustedScoreLabel();
            h14adjEntry = new HAdjustedScoreLabel();
            h15adjEntry = new HAdjustedScoreLabel();
            h16adjEntry = new HAdjustedScoreLabel();
            h17adjEntry = new HAdjustedScoreLabel();
            h18adjEntry = new HAdjustedScoreLabel();

            int optionsRow = 0;
            int holeRow = optionsRow + 1;
            int parRow = holeRow + 1;
            int handicapRow = parRow + 1;
            int rawRow = handicapRow + 1;
            int hScoreRow = rawRow + 1;
            int specialRow = hScoreRow + 1;

            addPlayersButton = new Button();
            addPlayersButton.Text = "Add Players";
            addPlayersButton.Clicked += AddPlayersButton_Clicked;

            viewLeaderBoardButton = new Button();
            viewLeaderBoardButton.Text = "View LeaderBoard";
            viewLeaderBoardButton.Clicked += ViewLeaderBoardButton_Clicked;

            grid.Children.Add(addPlayersButton, 0, optionsRow);
            grid.Children.Add(viewLeaderBoardButton, 1, optionsRow);

            grid.Children.Add(holeLabel, 0, holeRow);
            grid.Children.Add(h1Label, 1, holeRow);
            grid.Children.Add(h2Label, 2, holeRow);
            grid.Children.Add(h3Label, 3, holeRow);
            grid.Children.Add(h4Label, 4, holeRow);
            grid.Children.Add(h5Label, 5, holeRow);
            grid.Children.Add(h6Label, 6, holeRow);
            grid.Children.Add(h7Label, 7, holeRow);
            grid.Children.Add(h8Label, 8, holeRow);
            grid.Children.Add(h9Label, 9, holeRow);
            grid.Children.Add(h10Label, 10, holeRow);
            grid.Children.Add(h11Label, 11, holeRow);
            grid.Children.Add(h12Label, 12, holeRow);
            grid.Children.Add(h13Label, 13, holeRow);
            grid.Children.Add(h14Label, 14, holeRow);
            grid.Children.Add(h15Label, 15, holeRow);
            grid.Children.Add(h16Label, 16, holeRow);
            grid.Children.Add(h17Label, 17, holeRow);
            grid.Children.Add(h18Label, 18, holeRow);


            grid.Children.Add(holeParLabel, 0, parRow);
            grid.Children.Add(p1Label, 1, parRow);
            grid.Children.Add(p2Label, 2, parRow);
            grid.Children.Add(p3Label, 3, parRow);
            grid.Children.Add(p4Label, 4, parRow);
            grid.Children.Add(p5Label, 5, parRow);
            grid.Children.Add(p6Label, 6, parRow);
            grid.Children.Add(p7Label, 7, parRow);
            grid.Children.Add(p8Label, 8, parRow);
            grid.Children.Add(p9Label, 9, parRow);
            grid.Children.Add(p10Label, 10, parRow);
            grid.Children.Add(p11Label, 11, parRow);
            grid.Children.Add(p12Label, 12, parRow);
            grid.Children.Add(p13Label, 13, parRow);
            grid.Children.Add(p14Label, 14, parRow);
            grid.Children.Add(p15Label, 15, parRow);
            grid.Children.Add(p16Label, 16, parRow);
            grid.Children.Add(p17Label, 17, parRow);
            grid.Children.Add(p18Label, 18, parRow);

            grid.Children.Add(baseLabel, 0, rawRow);
            grid.Children.Add(hScoreLabel, 0, hScoreRow);
            grid.Children.Add(handicapLabel, 0, handicapRow);
            grid.Children.Add(specialLabel, 0, specialRow);

            grid.Children.Add(h1rEntry, 1, rawRow);
            grid.Children.Add(h2rEntry, 2, rawRow);
            grid.Children.Add(h3rEntry, 3, rawRow);
            grid.Children.Add(h4rEntry, 4, rawRow);
            grid.Children.Add(h5rEntry, 5, rawRow);
            grid.Children.Add(h6rEntry, 6, rawRow);
            grid.Children.Add(h7rEntry, 7, rawRow);
            grid.Children.Add(h8rEntry, 8, rawRow);
            grid.Children.Add(h9rEntry, 9, rawRow);
            grid.Children.Add(h10rEntry, 10, rawRow);
            grid.Children.Add(h11rEntry, 11, rawRow);
            grid.Children.Add(h12rEntry, 12, rawRow);
            grid.Children.Add(h13rEntry, 13, rawRow);
            grid.Children.Add(h14rEntry, 14, rawRow);
            grid.Children.Add(h15rEntry, 15, rawRow);
            grid.Children.Add(h16rEntry, 16, rawRow);
            grid.Children.Add(h17rEntry, 17, rawRow);
            grid.Children.Add(h18rEntry, 18, rawRow);

            grid.Children.Add(h1hcEntry, 1, handicapRow);
            grid.Children.Add(h2hcEntry, 2, handicapRow);
            grid.Children.Add(h3hcEntry, 3, handicapRow);
            grid.Children.Add(h4hcEntry, 4, handicapRow);
            grid.Children.Add(h5hcEntry, 5, handicapRow);
            grid.Children.Add(h6hcEntry, 6, handicapRow);
            grid.Children.Add(h7hcEntry, 7, handicapRow);
            grid.Children.Add(h8hcEntry, 8, handicapRow);
            grid.Children.Add(h9hcEntry, 9, handicapRow);
            grid.Children.Add(h10hcEntry, 10, handicapRow);
            grid.Children.Add(h11hcEntry, 11, handicapRow);
            grid.Children.Add(h12hcEntry, 12, handicapRow);
            grid.Children.Add(h13hcEntry, 13, handicapRow);
            grid.Children.Add(h14hcEntry, 14, handicapRow);
            grid.Children.Add(h15hcEntry, 15, handicapRow);
            grid.Children.Add(h16hcEntry, 16, handicapRow);
            grid.Children.Add(h17hcEntry, 17, handicapRow);
            grid.Children.Add(h18hcEntry, 18, handicapRow);

            grid.Children.Add(h1adjEntry, 1, hScoreRow);
            grid.Children.Add(h2adjEntry, 2, hScoreRow);
            grid.Children.Add(h3adjEntry, 3, hScoreRow);
            grid.Children.Add(h4adjEntry, 4, hScoreRow);
            grid.Children.Add(h5adjEntry, 5, hScoreRow);
            grid.Children.Add(h6adjEntry, 6, hScoreRow);
            grid.Children.Add(h7adjEntry, 7, hScoreRow);
            grid.Children.Add(h8adjEntry, 8, hScoreRow);
            grid.Children.Add(h9adjEntry, 9, hScoreRow);
            grid.Children.Add(h10adjEntry, 10, hScoreRow);
            grid.Children.Add(h11adjEntry, 11, hScoreRow);
            grid.Children.Add(h12adjEntry, 12, hScoreRow);
            grid.Children.Add(h13adjEntry, 13, hScoreRow);
            grid.Children.Add(h14adjEntry, 14, hScoreRow);
            grid.Children.Add(h15adjEntry, 15, hScoreRow);
            grid.Children.Add(h16adjEntry, 16, hScoreRow);
            grid.Children.Add(h17adjEntry, 17, hScoreRow);
            grid.Children.Add(h18adjEntry, 18, hScoreRow);

            grid.Children.Add(h1spEntry, 1, specialRow);
            grid.Children.Add(h2spEntry, 2, specialRow);
            grid.Children.Add(h3spEntry, 3, specialRow);
            grid.Children.Add(h4spEntry, 4, specialRow);
            grid.Children.Add(h5spEntry, 5, specialRow);
            grid.Children.Add(h6spEntry, 6, specialRow);
            grid.Children.Add(h7spEntry, 7, specialRow);
            grid.Children.Add(h8spEntry, 8, specialRow);
            grid.Children.Add(h9spEntry, 9, specialRow);
            grid.Children.Add(h10spEntry, 10, specialRow);
            grid.Children.Add(h11spEntry, 11, specialRow);
            grid.Children.Add(h12spEntry, 12, specialRow);
            grid.Children.Add(h13spEntry, 13, specialRow);
            grid.Children.Add(h14spEntry, 14, specialRow);
            grid.Children.Add(h15spEntry, 15, specialRow);
            grid.Children.Add(h16spEntry, 16, specialRow);
            grid.Children.Add(h17spEntry, 17, specialRow);
            grid.Children.Add(h18spEntry, 18, specialRow);


            scrollView.Content = grid;
            Content = scrollView;
        }

        private async void H18rEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            await DBHelper.getInstance().updateScoreCard(sd.currentScoreCard.id, "h18r", h18rEntry.Text);
        }

        private async void H17rEntry_TextChangedAsync(object sender, TextChangedEventArgs e)
        {
            await DBHelper.getInstance().updateScoreCard(sd.currentScoreCard.id, "h17r", h17rEntry.Text);
        }

        private async void H16rEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            await DBHelper.getInstance().updateScoreCard(sd.currentScoreCard.id, "h16r", h16rEntry.Text);
        }

        private async void H15rEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            await DBHelper.getInstance().updateScoreCard(sd.currentScoreCard.id, "h15r", h15rEntry.Text);
        }

        private async void H14rEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            await DBHelper.getInstance().updateScoreCard(sd.currentScoreCard.id, "h14r", h14rEntry.Text);
        }

        private async void H13rEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            await DBHelper.getInstance().updateScoreCard(sd.currentScoreCard.id, "h13r", h13rEntry.Text);
        }

        private async void H12rEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            await DBHelper.getInstance().updateScoreCard(sd.currentScoreCard.id, "h12r", h12rEntry.Text);
        }

        private async void H11rEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            await DBHelper.getInstance().updateScoreCard(sd.currentScoreCard.id, "h11r", h11rEntry.Text);
        }

        private async void H10rEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            await DBHelper.getInstance().updateScoreCard(sd.currentScoreCard.id, "h10r", h10rEntry.Text);
        }

        private async void H9rEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            await DBHelper.getInstance().updateScoreCard(sd.currentScoreCard.id, "h9r", h9rEntry.Text);
        }

        private async void H8rEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            await DBHelper.getInstance().updateScoreCard(sd.currentScoreCard.id, "h8r", h8rEntry.Text);
        }

        private async void H7rEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            await DBHelper.getInstance().updateScoreCard(sd.currentScoreCard.id, "h7r", h7rEntry.Text);
        }

        private async void H6rEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            await DBHelper.getInstance().updateScoreCard(sd.currentScoreCard.id, "h6r", h6rEntry.Text);
        }

        private async void H5rEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            await DBHelper.getInstance().updateScoreCard(sd.currentScoreCard.id, "h5r", h5rEntry.Text);
        }

        private async void H4rEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            await DBHelper.getInstance().updateScoreCard(sd.currentScoreCard.id, "h4r", h4rEntry.Text);
        }

        private async void H3rEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            await DBHelper.getInstance().updateScoreCard(sd.currentScoreCard.id, "h3r", h3rEntry.Text);
        }

        private async void H2rEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            await DBHelper.getInstance().updateScoreCard(sd.currentScoreCard.id, "h2r", h2rEntry.Text);
        }

        private async void H1rEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            await DBHelper.getInstance().updateScoreCard(sd.currentScoreCard.id, "h1r", h1rEntry.Text);
        }

        private async void ViewLeaderBoardButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("UserCount", "This Game has " + (sd.watchingUsers.Count + 1) + " players", "Ok");
            if (sd.watchingUsers.Count == 0)
            {
                await DisplayAlert("ERROR", "Add users to see the scoreboard", "Ok");
            }
            else
            {
                await Navigation.PushAsync(new ViewLeaderBoardPage(sd));
                //var pages = Navigation.NavigationStack.ToList();
                //foreach (var page in pages)
                //{
                //    if (page.GetType() != typeof(ViewLeaderBoardPage))
                //    {
                //        Navigation.RemovePage(page);
                //    }
                //}
            }
        }

        private async void AddPlayersButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPlayersPage(sd));
            var pages = Navigation.NavigationStack.ToList();
            foreach (var page in pages)
            {
                if (page.GetType() != typeof(AddPlayersPage))
                {
                    Navigation.RemovePage(page);
                }
            }
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Send(this, "PreventPortrait");
            sd.currentCourse = await DBHelper.getInstance().getCourseAsync(sd.currentCourse.id);
            fillOutCourseData();
            sd.currentScoreCard = await DBHelper.getInstance().getScoreCardAsync(sd.currentScoreCard.id);

            h1rEntry.Text = sd.currentScoreCard.rawScores[0].ToString();
            h2rEntry.Text = sd.currentScoreCard.rawScores[1].ToString();
            h3rEntry.Text = sd.currentScoreCard.rawScores[2].ToString();
            h4rEntry.Text = sd.currentScoreCard.rawScores[3].ToString();
            h5rEntry.Text = sd.currentScoreCard.rawScores[4].ToString();
            h6rEntry.Text = sd.currentScoreCard.rawScores[5].ToString();
            h7rEntry.Text = sd.currentScoreCard.rawScores[6].ToString();
            h8rEntry.Text = sd.currentScoreCard.rawScores[7].ToString();
            h9rEntry.Text = sd.currentScoreCard.rawScores[8].ToString();
            h10rEntry.Text = sd.currentScoreCard.rawScores[9].ToString();
            h11rEntry.Text = sd.currentScoreCard.rawScores[10].ToString();
            h12rEntry.Text = sd.currentScoreCard.rawScores[11].ToString();
            h13rEntry.Text = sd.currentScoreCard.rawScores[12].ToString();
            h14rEntry.Text = sd.currentScoreCard.rawScores[13].ToString();
            h15rEntry.Text = sd.currentScoreCard.rawScores[14].ToString();
            h16rEntry.Text = sd.currentScoreCard.rawScores[15].ToString();
            h17rEntry.Text = sd.currentScoreCard.rawScores[16].ToString();
            h18rEntry.Text = sd.currentScoreCard.rawScores[17].ToString();

            h1spEntry.Text = sd.currentScoreCard.specialScores[0].ToString();
            h2spEntry.Text = sd.currentScoreCard.specialScores[1].ToString();
            h3spEntry.Text = sd.currentScoreCard.specialScores[2].ToString();
            h4spEntry.Text = sd.currentScoreCard.specialScores[3].ToString();
            h5spEntry.Text = sd.currentScoreCard.specialScores[4].ToString();
            h6spEntry.Text = sd.currentScoreCard.specialScores[5].ToString();
            h7spEntry.Text = sd.currentScoreCard.specialScores[6].ToString();
            h8spEntry.Text = sd.currentScoreCard.specialScores[7].ToString();
            h9spEntry.Text = sd.currentScoreCard.specialScores[8].ToString();
            h10spEntry.Text = sd.currentScoreCard.specialScores[9].ToString();
            h11spEntry.Text = sd.currentScoreCard.specialScores[10].ToString();
            h12spEntry.Text = sd.currentScoreCard.specialScores[11].ToString();
            h13spEntry.Text = sd.currentScoreCard.specialScores[12].ToString();
            h14spEntry.Text = sd.currentScoreCard.specialScores[13].ToString();
            h15spEntry.Text = sd.currentScoreCard.specialScores[14].ToString();
            h16spEntry.Text = sd.currentScoreCard.specialScores[15].ToString();
            h17spEntry.Text = sd.currentScoreCard.specialScores[16].ToString();
            h18spEntry.Text = sd.currentScoreCard.specialScores[17].ToString();

            //if (sd.watchingUsers.Count > 0) {
            //    calcHandicapData();
            //}
        }

        //private void calcHandicapData()
        //{
        //}

        private void fillOutCourseData()
        {
            p1Label.Text = sd.currentCourse.pars[0].ToString();
            p2Label.Text = sd.currentCourse.pars[1].ToString();
            p3Label.Text = sd.currentCourse.pars[2].ToString();
            p4Label.Text = sd.currentCourse.pars[3].ToString();
            p5Label.Text = sd.currentCourse.pars[4].ToString();
            p6Label.Text = sd.currentCourse.pars[5].ToString();
            p7Label.Text = sd.currentCourse.pars[6].ToString();
            p8Label.Text = sd.currentCourse.pars[7].ToString();
            p9Label.Text = sd.currentCourse.pars[8].ToString();
            p10Label.Text = sd.currentCourse.pars[9].ToString();
            p11Label.Text = sd.currentCourse.pars[10].ToString();
            p12Label.Text = sd.currentCourse.pars[11].ToString();
            p13Label.Text = sd.currentCourse.pars[12].ToString();
            p14Label.Text = sd.currentCourse.pars[13].ToString();
            p15Label.Text = sd.currentCourse.pars[14].ToString();
            p16Label.Text = sd.currentCourse.pars[15].ToString();
            p17Label.Text = sd.currentCourse.pars[16].ToString();
            p18Label.Text = sd.currentCourse.pars[17].ToString();

            h1hcEntry.Text = sd.currentCourse.handicaps[0].ToString();
            h2hcEntry.Text = sd.currentCourse.handicaps[1].ToString();
            h3hcEntry.Text = sd.currentCourse.handicaps[2].ToString();
            h4hcEntry.Text = sd.currentCourse.handicaps[3].ToString();
            h5hcEntry.Text = sd.currentCourse.handicaps[4].ToString();
            h6hcEntry.Text = sd.currentCourse.handicaps[5].ToString();
            h7hcEntry.Text = sd.currentCourse.handicaps[6].ToString();
            h8hcEntry.Text = sd.currentCourse.handicaps[7].ToString();
            h9hcEntry.Text = sd.currentCourse.handicaps[8].ToString();
            h10hcEntry.Text = sd.currentCourse.handicaps[9].ToString();
            h11hcEntry.Text = sd.currentCourse.handicaps[10].ToString();
            h12hcEntry.Text = sd.currentCourse.handicaps[11].ToString();
            h13hcEntry.Text = sd.currentCourse.handicaps[12].ToString();
            h14hcEntry.Text = sd.currentCourse.handicaps[13].ToString();
            h15hcEntry.Text = sd.currentCourse.handicaps[14].ToString();
            h16hcEntry.Text = sd.currentCourse.handicaps[15].ToString();
            h17hcEntry.Text = sd.currentCourse.handicaps[16].ToString();
            h18hcEntry.Text = sd.currentCourse.handicaps[17].ToString();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Send(this, "PreventLandscape");
        }
    }
}