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
    public class DashboardPage : ContentPage
    {
        private Button createCourseButton;
        private Button newRoundButton;
        private List<Course> courses;
        private string address = "https://golfserversws6042.herokuapp.com/course/";

        public DashboardPage()
        {
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
                await Navigation.PushAsync(new CreateCoursePage());
                var pages = Navigation.NavigationStack.ToList();
                foreach (var page in pages)
                {
                    if (page.GetType() != typeof(CreateCoursePage))
                    {
                        Navigation.RemovePage(page);
                    }
                }
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

                Course curCourse = parseCourse(msg);

                courses.Add(curCourse);

                if (msg.Contains("message") && msg.Contains("Could Not Find That Course"))
                {
                    finishedChecking = true;
                }
                else
                {
                    id++;
                }
            }
        }

        private Course parseCourse(string msg)
        {
            Course ansCourse = new Course();
            int nameInd = msg.IndexOf("\"name: \"");
            int parInd = msg.IndexOf("\"par: \"");
            int h1Ind = msg.IndexOf("\"h1: \"");
            int h2Ind = msg.IndexOf("\"h2: \"");
            int h3Ind = msg.IndexOf("\"h3: \"");
            int h4Ind = msg.IndexOf("\"h4: \"");
            int h5Ind = msg.IndexOf("\"h5: \"");
            int h6Ind = msg.IndexOf("\"h6: \"");
            int h7Ind = msg.IndexOf("\"h7: \"");
            int h8Ind = msg.IndexOf("\"h8: \"");
            int h9Ind = msg.IndexOf("\"h9: \"");
            int h10Ind = msg.IndexOf("\"h10: \"");
            int h11Ind = msg.IndexOf("\"h11: \"");
            int h12Ind = msg.IndexOf("\"h12: \"");
            int h13Ind = msg.IndexOf("\"h13: \"");
            int h14Ind = msg.IndexOf("\"h14: \"");
            int h15Ind = msg.IndexOf("\"h15: \"");
            int h16Ind = msg.IndexOf("\"h16: \"");
            int h17Ind = msg.IndexOf("\"h17: \"");
            int h18Ind = msg.IndexOf("\"h18: \"");

            ansCourse.name = msg.Substring(nameInd, parInd);
            ansCourse.par = Int32.Parse(msg.Substring(parInd, h1Ind));
            ansCourse.h1 = Int32.Parse(msg.Substring(h1Ind, h2Ind));
            ansCourse.h2 = Int32.Parse(msg.Substring(h2Ind, h3Ind));
            ansCourse.h3 = Int32.Parse(msg.Substring(h3Ind, h4Ind));
            ansCourse.h4 = Int32.Parse(msg.Substring(h4Ind, h5Ind));
            ansCourse.h5 = Int32.Parse(msg.Substring(h5Ind, h6Ind));
            ansCourse.h6 = Int32.Parse(msg.Substring(h6Ind, h7Ind));
            ansCourse.h7 = Int32.Parse(msg.Substring(h7Ind, h8Ind));
            ansCourse.h8 = Int32.Parse(msg.Substring(h8Ind, h9Ind));
            ansCourse.h9 = Int32.Parse(msg.Substring(h9Ind, h10Ind));
            ansCourse.h10 = Int32.Parse(msg.Substring(h10Ind, h11Ind));
            ansCourse.h11 = Int32.Parse(msg.Substring(h11Ind, h12Ind));
            ansCourse.h12 = Int32.Parse(msg.Substring(h12Ind, h13Ind));
            ansCourse.h13 = Int32.Parse(msg.Substring(h13Ind, h14Ind));
            ansCourse.h14 = Int32.Parse(msg.Substring(h14Ind, h15Ind));
            ansCourse.h15 = Int32.Parse(msg.Substring(h15Ind, h16Ind));
            ansCourse.h16 = Int32.Parse(msg.Substring(h16Ind, h17Ind));
            ansCourse.h17 = Int32.Parse(msg.Substring(h17Ind, h18Ind));
            ansCourse.h18 = Int32.Parse(msg.Substring(h18Ind, msg.Length));

            return ansCourse;
        }

        private async void CreateCourseButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateCoursePage());
            var pages = Navigation.NavigationStack.ToList();
            foreach (var page in pages)
            {
                if (page.GetType() != typeof(CreateCoursePage))
                {
                    Navigation.RemovePage(page);
                }
            }

        }
    }
}