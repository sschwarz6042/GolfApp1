using GolfApp1.Models;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GolfApp1.Views
{
    public class DashboardPage : ContentPage
    {
        private Button createCourseButton;
        private Button newRoundButton;
        private List<Course> courses = new List<Course>();
        private string address = "https://golfserversws6042.herokuapp.com/course/";

        public DashboardPage()
        {
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
            await checkForCourses();

            if (courses.Count > 0)
            {
                await Navigation.PushAsync(new SelectOptionsPopup());
            }
            else {
                await DisplayAlert("ERROR", "No courses found in database\nCreate a new course", "Ok");
            }
        }

        private async Task checkForCourses()
        {
            int id = 0;
            bool finishedChecking = false;
            string msg;

            while (!finishedChecking) {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(address + id);
                msg = await response.Content.ReadAsStringAsync();


                if (msg.Contains("message") && msg.Contains("Could Not Find That Course"))
                {
                    finishedChecking = true;
                }
                else
                {
                    Course curCourse = parseCourse(msg);
                    courses.Add(curCourse);
                    id++;
                }
            }
        }

        private Course parseCourse(string msg)
        {
            Course ansCourse = new Course();
            
            //Parse Course

            return ansCourse;
        }

        private async void CreateCourseButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateCoursePage());
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