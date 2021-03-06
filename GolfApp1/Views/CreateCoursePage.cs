﻿using GolfApp1.Helpers;
using GolfApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GolfApp1.Views
{
    public class CreateCoursePage : ContentPage
    {

        private SessionData sd;
        private myLabel BlankLabel;
        private myLabel nameLabel;
        private myEntry nameEntry;
        private myLabel parLabel;
        private myEntry parEntry;
        private myEntry h1pEntry;
        private myEntry h2pEntry;
        private myEntry h3pEntry;
        private myEntry h4pEntry;
        private myEntry h5pEntry;
        private myEntry h6pEntry;
        private myEntry h7pEntry;
        private myEntry h8pEntry;
        private myEntry h9pEntry;
        private myEntry h10pEntry;
        private myEntry h11pEntry;
        private myEntry h12pEntry;
        private myEntry h13pEntry;
        private myEntry h14pEntry;
        private myEntry h15pEntry;
        private myEntry h16pEntry;
        private myEntry h17pEntry;
        private myEntry h18pEntry;
        private myEntry h1hcEntry;
        private myEntry h2hcEntry;
        private myEntry h3hcEntry;
        private myEntry h4hcEntry;
        private myEntry h5hcEntry;
        private myEntry h6hcEntry;
        private myEntry h7hcEntry;
        private myEntry h8hcEntry;
        private myEntry h9hcEntry;
        private myEntry h10hcEntry;
        private myEntry h11hcEntry;
        private myEntry h12hcEntry;
        private myEntry h13hcEntry;
        private myEntry h14hcEntry;
        private myEntry h15hcEntry;
        private myEntry h16hcEntry;
        private myEntry h17hcEntry;
        private myEntry h18hcEntry;
        private myLabel h1pLabel;
        private myLabel h2pLabel;
        private myLabel h3pLabel;
        private myLabel h4pLabel;
        private myLabel h5pLabel;
        private myLabel h6pLabel;
        private myLabel h7pLabel;
        private myLabel h8pLabel;
        private myLabel h9pLabel;
        private myLabel h10pLabel;
        private myLabel h11pLabel;
        private myLabel h12pLabel;
        private myLabel h13pLabel;
        private myLabel h14pLabel;
        private myLabel h15pLabel;
        private myLabel h16pLabel;
        private myLabel h17pLabel;
        private myLabel h18pLabel;
        private myLabel h1hcLabel;
        private myLabel h2hcLabel;
        private myLabel h3hcLabel;
        private myLabel h4hcLabel;
        private myLabel h5hcLabel;
        private myLabel h6hcLabel;
        private myLabel h7hcLabel;
        private myLabel h8hcLabel;
        private myLabel h9hcLabel;
        private myLabel h10hcLabel;
        private myLabel h11hcLabel;
        private myLabel h12hcLabel;
        private myLabel h13hcLabel;
        private myLabel h14hcLabel;
        private myLabel h15hcLabel;
        private myLabel h16hcLabel;
        private myLabel h17hcLabel;
        private myLabel h18hcLabel;
        private Button createCourseButton;

        public class myLabel : Label
        {
            public myLabel()
            {
                this.FontAttributes = FontAttributes.Bold;
            }
        }

        public class myEntry : Entry
        {
            public myEntry()
            {
                this.BackgroundColor = Color.White;
                this.Keyboard = Keyboard.Numeric;
            }
        }

        public CreateCoursePage(SessionData sessionData)
        {
            this.sd = sessionData;
            this.BackgroundImageSource = "SharecardBase.png";
            ScrollView scrollView = new ScrollView();
            Grid grid = new Grid();

            nameLabel = new myLabel();
            nameLabel.Text = "Course Name:";
            nameEntry = new myEntry();
            nameEntry.Keyboard = Keyboard.Text;
            parLabel = new myLabel();
            parLabel.Text = "Par:";
            parEntry = new myEntry();
            grid.Children.Add(nameLabel, 0, 0);
            grid.Children.Add(nameEntry, 1, 0);
            grid.Children.Add(parLabel, 2, 0);
            grid.Children.Add(parEntry, 3, 0);

            h1pLabel = new myLabel();
            h1pLabel.Text = "Hole 1 Par:";
            h1pEntry = new myEntry();
            h1hcLabel = new myLabel();
            h1hcLabel.Text = "Hole 1 Handicap:";
            h1hcEntry = new myEntry();
            grid.Children.Add(h1pLabel, 0, 1);
            grid.Children.Add(h1pEntry, 1, 1);
            grid.Children.Add(h1hcLabel, 2, 1);
            grid.Children.Add(h1hcEntry, 3, 1);

            h2pLabel = new myLabel();
            h2pLabel.Text = "Hole 2 Par:";
            h2pEntry = new myEntry();
            h2hcLabel = new myLabel();
            h2hcLabel.Text = "Hole 2 Handicap:";
            h2hcEntry = new myEntry();
            grid.Children.Add(h2pLabel, 0, 2);
            grid.Children.Add(h2pEntry, 1, 2);
            grid.Children.Add(h2hcLabel, 2, 2);
            grid.Children.Add(h2hcEntry, 3, 2);

            h3pLabel = new myLabel();
            h3pLabel.Text = "Hole 3 Par:";
            h3pEntry = new myEntry();
            h3hcLabel = new myLabel();
            h3hcLabel.Text = "Hole 3 Handicap:";
            h3hcEntry = new myEntry();
            grid.Children.Add(h3pLabel, 0, 3);
            grid.Children.Add(h3pEntry, 1, 3);
            grid.Children.Add(h3hcLabel, 2, 3);
            grid.Children.Add(h3hcEntry, 3, 3);

            h4pLabel = new myLabel();
            h4pLabel.Text = "Hole 4 Par:";
            h4pEntry = new myEntry();
            h4hcLabel = new myLabel();
            h4hcLabel.Text = "Hole 4 Handicap:";
            h4hcEntry = new myEntry();
            grid.Children.Add(h4pLabel, 0, 4);
            grid.Children.Add(h4pEntry, 1, 4);
            grid.Children.Add(h4hcLabel, 2, 4);
            grid.Children.Add(h4hcEntry, 3, 4);

            h5pLabel = new myLabel();
            h5pLabel.Text = "Hole 5 Par:";
            h5pEntry = new myEntry();
            h5hcLabel = new myLabel();
            h5hcLabel.Text = "Hole 5 Handicap:";
            h5hcEntry = new myEntry();
            grid.Children.Add(h5pLabel, 0, 5);
            grid.Children.Add(h5pEntry, 1, 5);
            grid.Children.Add(h5hcLabel, 2, 5);
            grid.Children.Add(h5hcEntry, 3, 5);

            h6pLabel = new myLabel();
            h6pLabel.Text = "Hole 6 Par:";
            h6pEntry = new myEntry();
            h6hcLabel = new myLabel();
            h6hcLabel.Text = "Hole 6 Handicap:";
            h6hcEntry = new myEntry();
            grid.Children.Add(h6pLabel, 0, 6);
            grid.Children.Add(h6pEntry, 1, 6);
            grid.Children.Add(h6hcLabel, 2, 6);
            grid.Children.Add(h6hcEntry, 3, 6);

            h7pLabel = new myLabel();
            h7pLabel.Text = "Hole 7 Par:";
            h7pEntry = new myEntry();
            h7hcLabel = new myLabel();
            h7hcLabel.Text = "Hole 7 Handicap:";
            h7hcEntry = new myEntry();
            grid.Children.Add(h7pLabel, 0, 7);
            grid.Children.Add(h7pEntry, 1, 7);
            grid.Children.Add(h7hcLabel, 2, 7);
            grid.Children.Add(h7hcEntry, 3, 7);

            h8pLabel = new myLabel();
            h8pLabel.Text = "Hole 8 Par:";
            h8pEntry = new myEntry();
            h8hcLabel = new myLabel();
            h8hcLabel.Text = "Hole 8 Handicap:";
            h8hcEntry = new myEntry();
            grid.Children.Add(h8pLabel, 0, 8);
            grid.Children.Add(h8pEntry, 1, 8);
            grid.Children.Add(h8hcLabel, 2, 8);
            grid.Children.Add(h8hcEntry, 3, 8);

            h9pLabel = new myLabel();
            h9pLabel.Text = "Hole 9 Par:";
            h9pEntry = new myEntry();
            h9hcLabel = new myLabel();
            h9hcLabel.Text = "Hole 9 Handicap:";
            h9hcEntry = new myEntry();
            grid.Children.Add(h9pLabel, 0, 9);
            grid.Children.Add(h9pEntry, 1, 9);
            grid.Children.Add(h9hcLabel, 2, 9);
            grid.Children.Add(h9hcEntry, 3, 9);

            h10pLabel = new myLabel();
            h10pLabel.Text = "Hole 10 Par:";
            h10pEntry = new myEntry();
            h10hcLabel = new myLabel();
            h10hcLabel.Text = "Hole 10 Handicap:";
            h10hcEntry = new myEntry();
            grid.Children.Add(h10pLabel, 0, 10);
            grid.Children.Add(h10pEntry, 1, 10);
            grid.Children.Add(h10hcLabel, 2, 10);
            grid.Children.Add(h10hcEntry, 3, 10);

            h11pLabel = new myLabel();
            h11pLabel.Text = "Hole 11 Par:";
            h11pEntry = new myEntry();
            h11hcLabel = new myLabel();
            h11hcLabel.Text = "Hole 11 Handicap:";
            h11hcEntry = new myEntry();
            grid.Children.Add(h11pLabel, 0, 11);
            grid.Children.Add(h11pEntry, 1, 11);
            grid.Children.Add(h11hcLabel, 2, 11);
            grid.Children.Add(h11hcEntry, 3, 11);

            h12pLabel = new myLabel();
            h12pLabel.Text = "Hole 12 Par:";
            h12pEntry = new myEntry();
            h12hcLabel = new myLabel();
            h12hcLabel.Text = "Hole 12 Handicap:";
            h12hcEntry = new myEntry();
            grid.Children.Add(h12pLabel, 0, 12);
            grid.Children.Add(h12pEntry, 1, 12);
            grid.Children.Add(h12hcLabel, 2, 12);
            grid.Children.Add(h12hcEntry, 3, 12);

            h13pLabel = new myLabel();
            h13pLabel.Text = "Hole 13 Par:";
            h13pEntry = new myEntry();
            h13hcLabel = new myLabel();
            h13hcLabel.Text = "Hole 13 Handicap:";
            h13hcEntry = new myEntry();
            grid.Children.Add(h13pLabel, 0, 13);
            grid.Children.Add(h13pEntry, 1, 13);
            grid.Children.Add(h13hcLabel, 2, 13);
            grid.Children.Add(h13hcEntry, 3, 13);

            h14pLabel = new myLabel();
            h14pLabel.Text = "Hole 14 Par:";
            h14pEntry = new myEntry();
            h14hcLabel = new myLabel();
            h14hcLabel.Text = "Hole 14 Handicap:";
            h14hcEntry = new myEntry();
            grid.Children.Add(h14pLabel, 0, 14);
            grid.Children.Add(h14pEntry, 1, 14);
            grid.Children.Add(h14hcLabel, 2, 14);
            grid.Children.Add(h14hcEntry, 3, 14);

            h15pLabel = new myLabel();
            h15pLabel.Text = "Hole 15 Par:";
            h15pEntry = new myEntry();
            h15hcLabel = new myLabel();
            h15hcLabel.Text = "Hole 15 Handicap:";
            h15hcEntry = new myEntry();
            grid.Children.Add(h15pLabel, 0, 15);
            grid.Children.Add(h15pEntry, 1, 15);
            grid.Children.Add(h15hcLabel, 2, 15);
            grid.Children.Add(h15hcEntry, 3, 15);

            h16pLabel = new myLabel();
            h16pLabel.Text = "Hole 16 Par:";
            h16pEntry = new myEntry();
            h16hcLabel = new myLabel();
            h16hcLabel.Text = "Hole 16 Handicap:";
            h16hcEntry = new myEntry();
            grid.Children.Add(h16pLabel, 0, 16);
            grid.Children.Add(h16pEntry, 1, 16);
            grid.Children.Add(h16hcLabel, 2, 16);
            grid.Children.Add(h16hcEntry, 3, 16);

            h17pLabel = new myLabel();
            h17pLabel.Text = "Hole 17 Par:";
            h17pEntry = new myEntry();
            h17hcLabel = new myLabel();
            h17hcLabel.Text = "Hole 17 Handicap:";
            h17hcEntry = new myEntry();
            grid.Children.Add(h17pLabel, 0, 17);
            grid.Children.Add(h17pEntry, 1, 17);
            grid.Children.Add(h17hcLabel, 2, 17);
            grid.Children.Add(h17hcEntry, 3, 17);

            h18pLabel = new myLabel();
            h18pLabel.Text = "Hole 18 Par:";
            h18pLabel.FontAttributes = FontAttributes.Bold;
            h18pEntry = new myEntry();
            h18hcLabel = new myLabel();
            h18hcLabel.Text = "Hole 18 Handicap:";
            h18hcLabel.FontAttributes = FontAttributes.Bold;
            h18hcEntry = new myEntry();
            grid.Children.Add(h18pLabel, 0, 18);
            grid.Children.Add(h18pEntry, 1, 18);
            grid.Children.Add(h18hcLabel, 2, 18);
            grid.Children.Add(h18hcEntry, 3, 18);

            createCourseButton = new Button();
            createCourseButton.Text = "Create";
            createCourseButton.Clicked += CreateCourseButton_Clicked;
            grid.Children.Add(createCourseButton, 2, 19);

            BlankLabel = new myLabel();
            BlankLabel.Text = "";
            grid.Children.Add(BlankLabel, 0, 20);
            grid.Children.Add(BlankLabel, 0, 21);
            grid.Children.Add(BlankLabel, 0, 22);
            grid.Children.Add(BlankLabel, 0, 23);
            grid.Children.Add(BlankLabel, 0, 24);

            scrollView.Content = grid;
            Content = scrollView;
        }

        private async void CreateCourseButton_Clicked(object sender, EventArgs e)
        {
            int[] pars = new int[18];
            int[] handicaps = new int[18];

            try
            {
                pars[0] = Int32.Parse(h1pEntry.Text);
                pars[1] = Int32.Parse(h2pEntry.Text);
                pars[2] = Int32.Parse(h3pEntry.Text);
                pars[3] = Int32.Parse(h4pEntry.Text);
                pars[4] = Int32.Parse(h5pEntry.Text);
                pars[5] = Int32.Parse(h6pEntry.Text);
                pars[6] = Int32.Parse(h7pEntry.Text);
                pars[7] = Int32.Parse(h8pEntry.Text);
                pars[8] = Int32.Parse(h9pEntry.Text);
                pars[9] = Int32.Parse(h10pEntry.Text);
                pars[10] = Int32.Parse(h11pEntry.Text);
                pars[11] = Int32.Parse(h12pEntry.Text);
                pars[12] = Int32.Parse(h13pEntry.Text);
                pars[13] = Int32.Parse(h14pEntry.Text);
                pars[14] = Int32.Parse(h15pEntry.Text);
                pars[15] = Int32.Parse(h16pEntry.Text);
                pars[16] = Int32.Parse(h17pEntry.Text);
                pars[17] = Int32.Parse(h18pEntry.Text);

                handicaps[0] = Int32.Parse(h1hcEntry.Text);
                handicaps[1] = Int32.Parse(h2hcEntry.Text);
                handicaps[2] = Int32.Parse(h3hcEntry.Text);
                handicaps[3] = Int32.Parse(h4hcEntry.Text);
                handicaps[4] = Int32.Parse(h5hcEntry.Text);
                handicaps[5] = Int32.Parse(h6hcEntry.Text);
                handicaps[6] = Int32.Parse(h7hcEntry.Text);
                handicaps[7] = Int32.Parse(h8hcEntry.Text);
                handicaps[8] = Int32.Parse(h9hcEntry.Text);
                handicaps[9] = Int32.Parse(h10hcEntry.Text);
                handicaps[10] = Int32.Parse(h11hcEntry.Text);
                handicaps[11] = Int32.Parse(h12hcEntry.Text);
                handicaps[12] = Int32.Parse(h13hcEntry.Text);
                handicaps[13] = Int32.Parse(h14hcEntry.Text);
                handicaps[14] = Int32.Parse(h15hcEntry.Text);
                handicaps[15] = Int32.Parse(h16hcEntry.Text);
                handicaps[16] = Int32.Parse(h17hcEntry.Text);
                handicaps[17] = Int32.Parse(h18hcEntry.Text);
            }
            catch (Exception)
            {
                await DisplayAlert("ERROR", "Invalid Input", "Ok");
                return;
            }

            bool success = await DBHelper.getInstance().createCourseAsync(nameEntry.Text, Int32.Parse(parEntry.Text), pars, handicaps);

            if (success)
            {
                await DisplayAlert("Course Created", "Your Course Was Created Successfully", "Ok");
            }
            else
            {
                await DisplayAlert("ERROR", "Could not create your course", "Ok");
            }

            var pages = Navigation.NavigationStack.ToList();
            foreach (var page in pages)
            {
                if (page.GetType() != typeof(DashboardPage))
                {
                    Navigation.RemovePage(page);
                }
            }
        }
    }
}