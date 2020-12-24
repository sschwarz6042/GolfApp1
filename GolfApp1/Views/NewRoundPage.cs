using GolfApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GolfApp1.Views
{
    public class NewRoundPage : ContentPage
    {
        private int courseNum = 0;
        private string address = "https://golfserversws6042.herokuapp.com/course/";
        private Course myCourse;

        private myLabel baseLabel;
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
        private SpecialStrokeLabel h1spEntry = new SpecialStrokeLabel();
        private SpecialStrokeLabel h2spEntry = new SpecialStrokeLabel();
        private SpecialStrokeLabel h3spEntry = new SpecialStrokeLabel();
        private SpecialStrokeLabel h4spEntry = new SpecialStrokeLabel();
        private SpecialStrokeLabel h5spEntry = new SpecialStrokeLabel();
        private SpecialStrokeLabel h6spEntry = new SpecialStrokeLabel();
        private SpecialStrokeLabel h7spEntry = new SpecialStrokeLabel();
        private SpecialStrokeLabel h8spEntry = new SpecialStrokeLabel();
        private SpecialStrokeLabel h9spEntry = new SpecialStrokeLabel();
        private SpecialStrokeLabel h10spEntry = new SpecialStrokeLabel();
        private SpecialStrokeLabel h11spEntry = new SpecialStrokeLabel();
        private SpecialStrokeLabel h12spEntry = new SpecialStrokeLabel();
        private SpecialStrokeLabel h13spEntry = new SpecialStrokeLabel();
        private SpecialStrokeLabel h14spEntry = new SpecialStrokeLabel();
        private SpecialStrokeLabel h15spEntry = new SpecialStrokeLabel();
        private SpecialStrokeLabel h16spEntry = new SpecialStrokeLabel();
        private SpecialStrokeLabel h17spEntry = new SpecialStrokeLabel();
        private SpecialStrokeLabel h18spEntry = new SpecialStrokeLabel();


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

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Send(this, "PreventPortrait");
            await updateCourseValues();
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Send(this, "PreventLandscape");
        }

        private async Task updateCourseValues() {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(address + courseNum);
            string msg = await response.Content.ReadAsStringAsync();

            //await DisplayAlert("MSG: ", msg, "Ok");

            //await parseCourse(msg);
            myCourse = parseCourse(msg);

            p1Label.Text = myCourse.h1p.ToString();
            p2Label.Text = myCourse.h2p.ToString();
            p3Label.Text = myCourse.h3p.ToString();
            p4Label.Text = myCourse.h4p.ToString();
            p5Label.Text = myCourse.h5p.ToString();
            p6Label.Text = myCourse.h6p.ToString();
            p7Label.Text = myCourse.h7p.ToString();
            p8Label.Text = myCourse.h8p.ToString();
            p9Label.Text = myCourse.h9p.ToString();
            p10Label.Text = myCourse.h10p.ToString();
            p11Label.Text = myCourse.h11p.ToString();
            p12Label.Text = myCourse.h12p.ToString();
            p13Label.Text = myCourse.h13p.ToString();
            p14Label.Text = myCourse.h14p.ToString();
            p15Label.Text = myCourse.h15p.ToString();
            p16Label.Text = myCourse.h16p.ToString();
            p17Label.Text = myCourse.h17p.ToString();
            p18Label.Text = myCourse.h18p.ToString();


            h1hcEntry.Text = myCourse.h1hc.ToString();
            h2hcEntry.Text = myCourse.h2hc.ToString();
            h3hcEntry.Text = myCourse.h3hc.ToString();
            h4hcEntry.Text = myCourse.h4hc.ToString();
            h5hcEntry.Text = myCourse.h5hc.ToString();
            h6hcEntry.Text = myCourse.h6hc.ToString();
            h7hcEntry.Text = myCourse.h7hc.ToString();
            h8hcEntry.Text = myCourse.h8hc.ToString();
            h9hcEntry.Text = myCourse.h9hc.ToString();
            h10hcEntry.Text = myCourse.h10hc.ToString();
            h11hcEntry.Text = myCourse.h11hc.ToString();
            h12hcEntry.Text = myCourse.h12hc.ToString();
            h13hcEntry.Text = myCourse.h13hc.ToString();
            h14hcEntry.Text = myCourse.h14hc.ToString();
            h15hcEntry.Text = myCourse.h15hc.ToString();
            h16hcEntry.Text = myCourse.h16hc.ToString();
            h17hcEntry.Text = myCourse.h17hc.ToString();
            h18hcEntry.Text = myCourse.h18hc.ToString();
        }

        //private async Task parseCourse(string msg)
        private Course parseCourse(string msg)
        {
            Course ans = new Course();

            string nameStartStr = "\"name\": ";
            string parStartStr = "\"par\": ";

            string h1pStartStr = "\"h1p\": ";
            string h2pStartStr = "\"h2p\": ";
            string h3pStartStr = "\"h3p\": ";
            string h4pStartStr = "\"h4p\": ";
            string h5pStartStr = "\"h5p\": ";
            string h6pStartStr = "\"h6p\": ";
            string h7pStartStr = "\"h7p\": ";
            string h8pStartStr = "\"h8p\": ";
            string h9pStartStr = "\"h9p\": ";
            string h10pStartStr = "\"h10p\": ";
            string h11pStartStr = "\"h11p\": ";
            string h12pStartStr = "\"h12p\": ";
            string h13pStartStr = "\"h13p\": ";
            string h14pStartStr = "\"h14p\": ";
            string h15pStartStr = "\"h15p\": ";
            string h16pStartStr = "\"h16p\": ";
            string h17pStartStr = "\"h17p\": ";
            string h18pStartStr = "\"h18p\": ";

            string h1hcStartStr = "\"h1hc\": ";
            string h2hcStartStr = "\"h2hc\": ";
            string h3hcStartStr = "\"h3hc\": ";
            string h4hcStartStr = "\"h4hc\": ";
            string h5hcStartStr = "\"h5hc\": ";
            string h6hcStartStr = "\"h6hc\": ";
            string h7hcStartStr = "\"h7hc\": ";
            string h8hcStartStr = "\"h8hc\": ";
            string h9hcStartStr = "\"h9hc\": ";
            string h10hcStartStr = "\"h10hc\": ";
            string h11hcStartStr = "\"h11hc\": ";
            string h12hcStartStr = "\"h12hc\": ";
            string h13hcStartStr = "\"h13hc\": ";
            string h14hcStartStr = "\"h14hc\": ";
            string h15hcStartStr = "\"h15hc\": ";
            string h16hcStartStr = "\"h16hc\": ";
            string h17hcStartStr = "\"h17hc\": ";
            string h18hcStartStr = "\"h18hc\": ";


            int nameStart = msg.IndexOf(nameStartStr);
            int parStart = msg.IndexOf(parStartStr);

            int h1pStart = msg.IndexOf(h1pStartStr);
            int h2pStart = msg.IndexOf(h2pStartStr);
            int h3pStart = msg.IndexOf(h3pStartStr);
            int h4pStart = msg.IndexOf(h4pStartStr);
            int h5pStart = msg.IndexOf(h5pStartStr);
            int h6pStart = msg.IndexOf(h6pStartStr);
            int h7pStart = msg.IndexOf(h7pStartStr);
            int h8pStart = msg.IndexOf(h8pStartStr);
            int h9pStart = msg.IndexOf(h9pStartStr);
            int h10pStart = msg.IndexOf(h10pStartStr);
            int h11pStart = msg.IndexOf(h11pStartStr);
            int h12pStart = msg.IndexOf(h12pStartStr);
            int h13pStart = msg.IndexOf(h13pStartStr);
            int h14pStart = msg.IndexOf(h14pStartStr);
            int h15pStart = msg.IndexOf(h15pStartStr);
            int h16pStart = msg.IndexOf(h16pStartStr);
            int h17pStart = msg.IndexOf(h17pStartStr);
            int h18pStart = msg.IndexOf(h18pStartStr);
            
            int h1hcStart = msg.IndexOf(h1hcStartStr);
            int h2hcStart = msg.IndexOf(h2hcStartStr);
            int h3hcStart = msg.IndexOf(h3hcStartStr);
            int h4hcStart = msg.IndexOf(h4hcStartStr);
            int h5hcStart = msg.IndexOf(h5hcStartStr);
            int h6hcStart = msg.IndexOf(h6hcStartStr);
            int h7hcStart = msg.IndexOf(h7hcStartStr);
            int h8hcStart = msg.IndexOf(h8hcStartStr);
            int h9hcStart = msg.IndexOf(h9hcStartStr);
            int h10hcStart = msg.IndexOf(h10hcStartStr);
            int h11hcStart = msg.IndexOf(h11hcStartStr);
            int h12hcStart = msg.IndexOf(h12hcStartStr);
            int h13hcStart = msg.IndexOf(h13hcStartStr);
            int h14hcStart = msg.IndexOf(h14hcStartStr);
            int h15hcStart = msg.IndexOf(h15hcStartStr);
            int h16hcStart = msg.IndexOf(h16hcStartStr);
            int h17hcStart = msg.IndexOf(h17hcStartStr);
            int h18hcStart = msg.IndexOf(h18hcStartStr);

            string newname = msg.Substring(nameStart + nameStartStr.Length, parStart - parStartStr.Length);
            string newpar = (string) ((msg.Substring(parStart + parStartStr.Length, parStart + parStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));

            string newh1p = (string) ((msg.Substring(h1pStart + h1pStartStr.Length, h1pStart + h1pStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H1P", newh1p, "Ok");

            string newh2p = (string) ((msg.Substring(h2pStart + h2pStartStr.Length, h2pStart + h2pStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H2P", newh2p, "Ok");

            string newh3p = (string) ((msg.Substring(h3pStart + h3pStartStr.Length, h3pStart + h3pStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H3P", newh3p, "Ok");

            string newh4p = (string) ((msg.Substring(h4pStart + h4pStartStr.Length, h4pStart + h4pStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H4P", newh4p, "Ok");

            string newh5p = (string) ((msg.Substring(h5pStart + h5pStartStr.Length, h5pStart + h5pStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H5P", newh5p, "Ok");

            string newh6p = (string) ((msg.Substring(h6pStart + h6pStartStr.Length, h6pStart + h6pStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H6P", newh6p, "Ok");

            string newh7p = (string) ((msg.Substring(h7pStart + h7pStartStr.Length, h7pStart + h7pStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H7P", newh7p, "Ok");

            string newh8p = (string) ((msg.Substring(h8pStart + h8pStartStr.Length, h8pStart + h8pStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H8P", newh8p, "Ok");

            string newh9p = (string) ((msg.Substring(h9pStart + h9pStartStr.Length, h9pStart + h9pStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H9P", newh9p, "Ok");

            string newh10p = (string) ((msg.Substring(h10pStart + h10pStartStr.Length, h10pStart + h10pStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H10P", newh10p, "Ok");

            string newh11p = (string) ((msg.Substring(h11pStart + h11pStartStr.Length, h11pStart + h11pStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H11P", newh11p, "Ok");

            string newh12p = (string) ((msg.Substring(h12pStart + h12pStartStr.Length, h12pStart + h12pStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H12P", newh12p, "Ok");

            string newh13p = (string) ((msg.Substring(h13pStart + h13pStartStr.Length, h13pStart + h13pStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H13P", newh13p, "Ok");

            string newh14p = (string) ((msg.Substring(h14pStart + h14pStartStr.Length, h14pStart + h14pStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H14P", newh14p, "Ok");

            string newh15p = (string) ((msg.Substring(h15pStart + h15pStartStr.Length, h15pStart + h15pStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H15P", newh15p, "Ok");

            string newh16p = (string) ((msg.Substring(h16pStart + h16pStartStr.Length, h16pStart + h16pStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H16P", newh16p, "Ok");

            string newh17p = (string) ((msg.Substring(h17pStart + h17pStartStr.Length, h17pStart + h17pStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H17P", newh17p, "Ok");

            //string newh18p = "0";
            //string newh1hc = "0";
            //string newh2hc = "0";
            //string newh3hc = "0";
            //string newh4hc = "0";
            //string newh5hc = "0";
            //string newh6hc = "0";
            //string newh7hc = "0";
            //string newh8hc = "0";
            //string newh9hc = "0";
            //string newh10hc = "0";
            //string newh11hc = "0";
            //string newh12hc = "0";
            //string newh13hc = "0";
            //string newh14hc = "0";
            //string newh15hc = "0";
            //string newh16hc = "0";
            //string newh17hc = "0";
            //string newh18hc = "0";

            //await DisplayAlert("h18pStart", h18pStart.ToString(), "Ok");
            //await DisplayAlert("h18pStartStr", h18pStartStr, "Ok");
            //await DisplayAlert("h18pStartStr Length", h18pStartStr.Length.ToString(), "Ok");
            //await DisplayAlert("MSG LENGTH:", msg.Length.ToString(), "Ok");

            //string newh18p = (string)((msg.Substring(h18pStart + h18pStartStr.Length, h18pStart + h18pStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            string newh18p = (string)((msg.Substring(h18pStart + h18pStartStr.Length).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H18P", newh18p, "Ok");


            //string newh1hc = (string) ((msg.Substring(h1hcStart + h1hcStartStr.Length, h1hcStart + h1hcStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            string newh1hc = (string) ((msg.Substring(h1hcStart + h1hcStartStr.Length).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H1HC", newh1hc, "Ok");

            //string newh2hc = (string) ((msg.Substring(h2hcStart + h2hcStartStr.Length, h2hcStart + h2hcStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            string newh2hc = (string) ((msg.Substring(h2hcStart + h2hcStartStr.Length).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H2HC", newh2hc, "Ok");

            //string newh3hc = (string) ((msg.Substring(h3hcStart + h3hcStartStr.Length, h3hcStart + h3hcStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            string newh3hc = (string) ((msg.Substring(h3hcStart + h3hcStartStr.Length).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H3HC", newh3hc, "Ok");

            //string newh4hc = (string) ((msg.Substring(h4hcStart + h4hcStartStr.Length, h4hcStart + h4hcStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            string newh4hc = (string) ((msg.Substring(h4hcStart + h4hcStartStr.Length).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H4HC", newh4hc, "Ok");

            //string newh5hc = (string) ((msg.Substring(h5hcStart + h5hcStartStr.Length, h5hcStart + h5hcStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            string newh5hc = (string) ((msg.Substring(h5hcStart + h5hcStartStr.Length).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H5HC", newh5hc, "Ok");

            //string newh6hc = (string) ((msg.Substring(h6hcStart + h6hcStartStr.Length, h6hcStart + h6hcStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            string newh6hc = (string) ((msg.Substring(h6hcStart + h6hcStartStr.Length).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H6HC", newh6hc, "Ok");

            //string newh7hc = (string) ((msg.Substring(h7hcStart + h7hcStartStr.Length, h7hcStart + h7hcStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            string newh7hc = (string) ((msg.Substring(h7hcStart + h7hcStartStr.Length).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H7HC", newh7hc, "Ok");

            //string newh8hc = (string) ((msg.Substring(h8hcStart + h8hcStartStr.Length, h8hcStart + h8hcStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            string newh8hc = (string) ((msg.Substring(h8hcStart + h8hcStartStr.Length).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H8HC", newh8hc, "Ok");

            //string newh9hc = (string) ((msg.Substring(h9hcStart + h9hcStartStr.Length, h9hcStart + h9hcStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            string newh9hc = (string) ((msg.Substring(h9hcStart + h9hcStartStr.Length).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H9HC", newh9hc, "Ok");

            //string newh10hc = (string) ((msg.Substring(h10hcStart + h10hcStartStr.Length, h10hcStart + h10hcStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            string newh10hc = (string) ((msg.Substring(h10hcStart + h10hcStartStr.Length).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H10HC", newh10hc, "Ok");

            //string newh11hc = (string) ((msg.Substring(h11hcStart + h11hcStartStr.Length, h11hcStart + h11hcStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            string newh11hc = (string) ((msg.Substring(h11hcStart + h11hcStartStr.Length).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H11HC", newh11hc, "Ok");

            //string newh12hc = (string) ((msg.Substring(h12hcStart + h12hcStartStr.Length, h12hcStart + h12hcStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            string newh12hc = (string) ((msg.Substring(h12hcStart + h12hcStartStr.Length).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H12HC", newh12hc, "Ok");

            //string newh13hc = (string) ((msg.Substring(h13hcStart + h13hcStartStr.Length, h13hcStart + h13hcStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            string newh13hc = (string) ((msg.Substring(h13hcStart + h13hcStartStr.Length).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H13HC", newh13hc, "Ok");

            //string newh14hc = (string) ((msg.Substring(h14hcStart + h14hcStartStr.Length, h14hcStart + h14hcStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            string newh14hc = (string) ((msg.Substring(h14hcStart + h14hcStartStr.Length).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H14HC", newh14hc, "Ok");

            //string newh15hc = (string) ((msg.Substring(h15hcStart + h15hcStartStr.Length, h15hcStart + h15hcStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            string newh15hc = (string) ((msg.Substring(h15hcStart + h15hcStartStr.Length).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H15HC", newh15hc, "Ok");

            //string newh16hc = (string) ((msg.Substring(h16hcStart + h16hcStartStr.Length, h16hcStart + h16hcStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            string newh16hc = (string) ((msg.Substring(h16hcStart + h16hcStartStr.Length).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H16HC", newh16hc, "Ok");

            //string newh17hc = (string) ((msg.Substring(h17hcStart + h17hcStartStr.Length, h17hcStart + h17hcStartStr.Length + 3).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            string newh17hc = (string) ((msg.Substring(h17hcStart + h17hcStartStr.Length).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H17HC", newh17hc, "Ok");

            //string newh18hc = (string) ((msg.Substring(h18hcStart + h18hcStartStr.Length).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            string newh18hc = (string) ((msg.Substring(h18hcStart + h18hcStartStr.Length).Replace(",", "").Replace("\"", "")).Substring(0, 2));
            //await DisplayAlert("H18HC", newh18hc, "Ok");


            ans.name = newname;
            ans.par = newpar;

            ans.h1p = newh1p;
            ans.h2p = newh2p;
            ans.h3p = newh3p;
            ans.h4p = newh4p;
            ans.h5p = newh5p;
            ans.h6p = newh6p;
            ans.h7p = newh7p;
            ans.h8p = newh8p;
            ans.h9p = newh9p;
            ans.h10p = newh10p;
            ans.h11p = newh11p;
            ans.h12p = newh12p;
            ans.h13p = newh13p;
            ans.h14p = newh14p;
            ans.h15p = newh15p;
            ans.h16p = newh16p;
            ans.h17p = newh17p;
            ans.h18p = newh18p;

            ans.h1hc = newh1hc;
            ans.h2hc = newh2hc;
            ans.h3hc = newh3hc;
            ans.h4hc = newh4hc;
            ans.h5hc = newh5hc;
            ans.h6hc = newh6hc;
            ans.h7hc = newh7hc;
            ans.h8hc = newh8hc;
            ans.h9hc = newh9hc;
            ans.h10hc = newh10hc;
            ans.h11hc = newh11hc;
            ans.h12hc = newh12hc;
            ans.h13hc = newh13hc;
            ans.h14hc = newh14hc;
            ans.h15hc = newh15hc;
            ans.h16hc = newh16hc;
            ans.h17hc = newh17hc;
            ans.h18hc = newh18hc;

            return ans;
        }
    }
}