using GolfApp1.Helpers;
using GolfApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GolfApp1.Views
{
    public class SelectOptionsPage : ContentPage
    {
        private myLabel courseLabel;
        private myLabel parLabel;
        private myLabel parValue;
        private Picker coursePicker = new Picker();
        private Button startButton;
        private StackLayout stackLayout = new StackLayout();
        private Grid grid = new Grid();
        private static int fSize = 25;
        private SessionData sd;
        private List<Course> courseList = new List<Course>();

        public class myLabel : Label
        {
            public myLabel()
            {
                this.FontAttributes = FontAttributes.Bold;
                this.FontSize = fSize;
            }
        }

        public SelectOptionsPage(SessionData sessionData)
        {
            this.sd = sessionData;
            this.BackgroundImageSource = "SharecardBase.png";

            courseLabel = new myLabel();
            courseLabel.Text = "Select a Course:";
            grid.Children.Add(courseLabel, 0, 0);

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
            //await Navigation.PushAsync(new NewRoundPage(0));
            sd.currentCourse = courseList[this.coursePicker.SelectedIndex];

            sd.currentScoreCard.id = sd.currentUser.id;
            sd.currentScoreCard.userID = sd.currentUser.id;
            sd.currentScoreCard.courseID = sd.currentCourse.id;
            await DBHelper.getInstance().updateScoreCard(sd.currentScoreCard.id, "uid", sd.currentUser.id.ToString());
            await DBHelper.getInstance().updateScoreCard(sd.currentScoreCard.id, "cid", sd.currentCourse.id.ToString());


            User userfromdb = await DBHelper.getInstance().getUserAsync(sd.currentUser.id);
            await DisplayAlert("Updating", "Changing User #" + sd.currentUser.id.ToString() + "'s ccid from " + userfromdb.currentCourseID + " to " + sd.currentCourse.id.ToString(), "Ok");


            sd.currentUser.currentCourseID = sd.currentCourse.id;
            await DBHelper.getInstance().updateUser(sd.currentUser.id.ToString(), "ccid", sd.currentCourse.id.ToString());

            userfromdb = await DBHelper.getInstance().getUserAsync(sd.currentUser.id);
            await DisplayAlert("Success", "Changed User #" + sd.currentUser.id.ToString() + "'s ccid from " + userfromdb.currentCourseID + " to " + sd.currentCourse.id.ToString(), "Ok");


            await DBHelper.getInstance().clearScoreCard(sd.currentScoreCard.id);

            await Navigation.PushAsync(new NewRoundPage(sd));
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
            parValue.Text = courseList[coursePicker.SelectedIndex].par.ToString();
            grid.Children.Add(parValue, 1, 1);
        }

        protected async override void OnAppearing()
        {
            grid.Children.Remove(coursePicker);
            coursePicker.Items.Clear();
            courseList = await DBHelper.getInstance().getAllCoursesAsync();
            coursePicker.ItemsSource = courseList;
            coursePicker.ItemDisplayBinding = new Binding("name");
            grid.Children.Add(coursePicker, 1, 0);
            coursePicker.SelectedIndex = 0;
        }
    }
}