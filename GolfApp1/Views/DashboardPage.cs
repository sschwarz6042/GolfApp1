using GolfApp1.Helpers;
using GolfApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GolfApp1.Views
{
    public class DashboardPage : ContentPage
    {
        private Button createCourseButton;
        private Button newRoundButton;
        private SessionData sd;

        public DashboardPage(SessionData sessionData)
        {
            this.sd = sessionData;
            this.BackgroundImageSource = "SharecardBase.png";
            StackLayout stackLayout = new StackLayout();

            createCourseButton = new Button();
            createCourseButton.Text = "Create A New Course";
            createCourseButton.Margin = new Thickness(0, 30);
            createCourseButton.Clicked += CreateCourseButton_Clicked;
            stackLayout.Children.Add(createCourseButton);

            newRoundButton = new Button();
            newRoundButton.Text = "Start New Round";
            newRoundButton.Margin = new Thickness(0, 30);
            newRoundButton.Clicked += NewRoundButton_Clicked;
            stackLayout.Children.Add(newRoundButton);

            Content = stackLayout;
        }

        private async void NewRoundButton_Clicked(object sender, EventArgs e)
        {
            List<Course> courses = await DBHelper.getInstance().getAllCoursesAsync();

            if (courses.Count > 0)
            {
                await Navigation.PushAsync(new SelectOptionsPage(sd));
            }
            else
            {
                await DisplayAlert("ERROR", "No courses found in database\nCreate a new course", "Ok");
            }
        }

        private async void CreateCourseButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateCoursePage(sd));
            //var pages = Navigation.NavigationStack.ToList();
            //foreach (var page in pages)
            //{
            //    if (page.GetType() != typeof(CreateCoursePage))
            //    {
            //        Navigation.RemovePage(page);
            //    }
            //}

        }
    }
}