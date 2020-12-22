using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GolfApp1.Views
{

    public class SelectOptionsPopup : ContentPage
    {
 
        private myLabel courseLabel;
        private myLabel parLabel;
        private myLabel parValue;
        private Picker coursePicker = new Picker();
        private Button startButton;
        private List<string> courseList = new List<string>();
        private string address = "https://golfserversws6042.herokuapp.com/course/";
        private StackLayout stackLayout = new StackLayout();
        private Grid grid = new Grid();
        private static int fSize = 25;

        public class myLabel : Label
        {
            public myLabel()
            {
                this.FontAttributes = FontAttributes.Bold;
                this.FontSize = fSize;
            }
        }

        public SelectOptionsPopup()
        {
            this.BackgroundImageSource = "SharecardBase.png";
            courseLabel = new myLabel();
            courseLabel.Text = "Select a Course:";
            grid.Children.Add(courseLabel, 0, 0);
            //coursePicker.ItemsSource = courseList;
            //coursePicker.Unfocused += CoursePicker_Unfocused;
            
            coursePicker.FontSize = fSize;
            coursePicker.SelectedIndexChanged += CoursePicker_SelectedIndexChanged;
            grid.Children.Add(coursePicker, 1, 0);
            
            parLabel = new myLabel();
            parLabel.Text = "Par:";
            grid.Children.Add(parLabel, 0, 1);
            
            parValue = new myLabel();
            parValue.Text = "";
            grid.Children.Add(parValue, 1, 1);
            
            startButton = new Button();
            startButton.Text = "Start";
            startButton.Clicked += StartButton_Clicked;
            grid.Children.Add(startButton, 1, 2);

            stackLayout.Children.Add(grid);
            Content = stackLayout;
        }

        private async void StartButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewRoundPage());
            var pages = Navigation.NavigationStack.ToList();
            foreach (var page in pages)
            {
                if (page.GetType() != typeof(NewRoundPage))
                {
                    Navigation.RemovePage(page);
                }
            }
        }

        private void CoursePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            grid.Children.Remove(parValue);
            string startText = "\"par\": ";
            int startInd = courseList.ElementAt(coursePicker.SelectedIndex).IndexOf(startText) + startText.Length;
            int endInd = courseList.ElementAt(coursePicker.SelectedIndex).Substring(startInd).IndexOf(",");
            parValue.Text = courseList.ElementAt(coursePicker.SelectedIndex).Substring(startInd, endInd);
            grid.Children.Add(parValue, 1, 1);
        }

        protected async override void OnAppearing()
        {
            grid.Children.Remove(coursePicker);
            await updateCourseList();
            //coursePicker.Items.Add("Course 0");
            grid.Children.Add(coursePicker, 1, 0);
        }

        //private async void CoursePicker_Unfocused(object sender, FocusEventArgs e)
        //{
        //    grid.Children.Remove(coursePicker);
        //    await updateCourseList();
        //    grid.Children.Add(coursePicker, 1, 0);
        //}

        private async Task updateCourseList()
        {
            int id = 0;
            bool finishedChecking = false;
            string msg;

            while (!finishedChecking)
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(address + id);
                msg = await response.Content.ReadAsStringAsync();
                //await DisplayAlert("Checking ID", "Checking " + id + "\n" + msg, "Ok");

                if (msg.Contains("message") && msg.Contains("Could Not Find That Course"))
                {
                    finishedChecking = true;
                }
                else
                {
                    //await DisplayAlert("Adding Course", "Adding Course to list", "Ok");
                    //courseList.Add("Course " + id);
                    string nameStart = "\"name\": \"";
                    int startInd = msg.IndexOf(nameStart) + nameStart.Length;
                    int endInd = msg.Substring(startInd).IndexOf("\", ");
                    if (startInd > 0 && endInd > 0)
                    {
                        if (!(coursePicker.Items.Contains(msg.Substring(startInd, endInd))))
                        {
                            coursePicker.Items.Add(msg.Substring(startInd, endInd));
                            courseList.Add(msg);
                        }
                    }
                    else {
                        await DisplayAlert("ERROR", "Indexes not correct", "Ok");
                    }
                    id++;
                }

            }
            coursePicker.SelectedIndex = 0;
            //coursePicker.ItemsSource = courseList;
        }
    }
}