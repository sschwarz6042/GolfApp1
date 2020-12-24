using GolfApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

using Xamarin.Forms;

namespace GolfApp1.Views
{
    public class ViewLeaderBoardPage : ContentPage
    {
        private SessionData sd;
        private string userAddress = "https://golfserversws6042.herokuapp.com/user/";
        private string scoreCardAddress = "https://golfserversws6042.herokuapp.com/scorecard/";

        private User currentUser = new User();
        private ScoreCard currentScoreCard = new ScoreCard();

        private ScrollView scrollView = new ScrollView();
        private Grid grid = new Grid();

        private Button backButton;

        private List<User> users = new List<User>();
        private List<ScoreCard> cards = new List<ScoreCard>();

        public class myLabel : Label{
            public myLabel() {
                this.FontAttributes = FontAttributes.Bold;
                this.FontSize = 25;
            }
        }

        public ViewLeaderBoardPage(SessionData sessionData)
        {
            users.Clear();
            cards.Clear();

            this.BackgroundImageSource = "SharecardBase.png";
            this.sd = sessionData;

            scrollView.Orientation = ScrollOrientation.Horizontal;

            for (int i = 0; i < sd.watchingScoreCards.Count; i++) {
                sd.watchingScoreCards.ElementAt(i).calcFinals();
            }

            cards = sd.watchingScoreCards;
            users = sd.watchingPlayers;
            if (!(cards.Contains(currentScoreCard))) {
                cards.Add(currentScoreCard);
            }
            if (!(users.Contains(currentUser))) {
                users.Insert(currentUser.id, currentUser);
            }
            cards = cards.OrderBy(i => i.currentTotal).ToList();

            int optionsRow = 0;
            backButton = new Button();
            backButton.Text = "Back <-";
            backButton.Clicked += BackButton_Clicked;
            grid.Children.Add(backButton, 0, optionsRow);

            int startRow = optionsRow + 1;
            for (int i = 0; i < cards.Count; i++) {
                myLabel currentName = new myLabel();
                currentName.Text = users.ElementAt(cards.ElementAt(i).uid).username;
                //currentName.Text = sd.watchingPlayers.ElementAt(cards.ElementAt(i).uid).username;

                myLabel h1s = new myLabel();
                myLabel h2s = new myLabel();
                myLabel h3s = new myLabel();
                myLabel h4s = new myLabel();
                myLabel h5s = new myLabel();
                myLabel h6s = new myLabel();
                myLabel h7s = new myLabel();
                myLabel h8s = new myLabel();
                myLabel h9s = new myLabel();
                myLabel h10s = new myLabel();
                myLabel h11s = new myLabel();
                myLabel h12s = new myLabel();
                myLabel h13s = new myLabel();
                myLabel h14s = new myLabel();
                myLabel h15s = new myLabel();
                myLabel h16s = new myLabel();
                myLabel h17s = new myLabel();
                myLabel h18s = new myLabel();

                h1s.Text = cards.ElementAt(i).finalScores[0].ToString();
                h2s.Text = cards.ElementAt(i).finalScores[1].ToString();
                h3s.Text = cards.ElementAt(i).finalScores[2].ToString();
                h4s.Text = cards.ElementAt(i).finalScores[3].ToString();
                h5s.Text = cards.ElementAt(i).finalScores[4].ToString();
                h6s.Text = cards.ElementAt(i).finalScores[5].ToString();
                h7s.Text = cards.ElementAt(i).finalScores[6].ToString();
                h8s.Text = cards.ElementAt(i).finalScores[7].ToString();
                h9s.Text = cards.ElementAt(i).finalScores[8].ToString();
                h10s.Text = cards.ElementAt(i).finalScores[9].ToString();
                h11s.Text = cards.ElementAt(i).finalScores[10].ToString();
                h12s.Text = cards.ElementAt(i).finalScores[11].ToString();
                h13s.Text = cards.ElementAt(i).finalScores[12].ToString();
                h14s.Text = cards.ElementAt(i).finalScores[13].ToString();
                h15s.Text = cards.ElementAt(i).finalScores[14].ToString();
                h16s.Text = cards.ElementAt(i).finalScores[15].ToString();
                h17s.Text = cards.ElementAt(i).finalScores[16].ToString();
                h18s.Text = cards.ElementAt(i).finalScores[17].ToString();

                grid.Children.Add(currentName, 0, startRow + i);
                grid.Children.Add(h1s, 1, startRow + i);
                grid.Children.Add(h2s, 2, startRow + i);
                grid.Children.Add(h3s, 3, startRow + i);
                grid.Children.Add(h4s, 4, startRow + i);
                grid.Children.Add(h5s, 5, startRow + i);
                grid.Children.Add(h6s, 6, startRow + i);
                grid.Children.Add(h7s, 7, startRow + i);
                grid.Children.Add(h8s, 8, startRow + i);
                grid.Children.Add(h9s, 9, startRow + i);
                grid.Children.Add(h10s, 10, startRow + i);
                grid.Children.Add(h11s, 11, startRow + i);
                grid.Children.Add(h12s, 12, startRow + i);
                grid.Children.Add(h13s, 13, startRow + i);
                grid.Children.Add(h14s, 14, startRow + i);
                grid.Children.Add(h15s, 15, startRow + i);
                grid.Children.Add(h16s, 16, startRow + i);
                grid.Children.Add(h17s, 17, startRow + i);
                grid.Children.Add(h18s, 18, startRow + i);
            }

            scrollView.Content = grid;
            Content = scrollView;
        }

        protected async override void OnAppearing() {
            base.OnAppearing();
            MessagingCenter.Send(this, "PreventPortrait");

            string email = "";
            string username = "";
            int handicap = 0;
            string password = "";

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(userAddress + sd.userID);
            string msg = await response.Content.ReadAsStringAsync();

            //await DisplayAlert("UserData", "User Data = " + msg, "Ok");

            if (msg.Contains("message") && msg.Contains("Could Not Find That User"))
            {
                //await DisplayAlert("ERROR", "User Not Found", "Ok");
            }
            else
            {
                string emailStart = "\"email\": \"";
                int startInd = msg.IndexOf(emailStart) + emailStart.Length;
                int endInd = msg.Substring(startInd).IndexOf("\", ");
                email = msg.Substring(startInd, endInd);
                //await DisplayAlert("Email", "Email = " + msg.Substring(startInd, endInd), "Ok");


                string usernameStart = "\"username\": \"";
                startInd = msg.IndexOf(usernameStart) + usernameStart.Length;
                endInd = msg.Substring(startInd).IndexOf("\", ");
                username = msg.Substring(startInd, endInd);
                await DisplayAlert("Username", "Username = " + msg.Substring(startInd, endInd), "Ok");


                string handicapStart = "\"handicap\": ";
                startInd = msg.IndexOf(handicapStart) + handicapStart.Length;
                endInd = msg.Substring(startInd).IndexOf(",");
                //await DisplayAlert("Handicap", "Handicap = " + msg.Substring(startInd, endInd), "Ok");
                handicap = Int32.Parse(msg.Substring(startInd, endInd));


                currentUser = new User(sd.userID, email, username, handicap, password);
            }

            int id = sd.userID;
            int uid = sd.userID;
            int[] rawScores = new int[18];
            int[] handicapScores = new int[18];
            int[] specialScores = new int[18];

            HttpClient client2 = new HttpClient();
            HttpResponseMessage response2 = await client2.GetAsync(scoreCardAddress + sd.userID);
            string msg2 = await response2.Content.ReadAsStringAsync();


            if (msg2.Contains("message") && msg2.Contains("Could Not Find That ScoreCard"))
            {
                await DisplayAlert("ERROR", "ScoreCard Not Found", "Ok");
            }
            else
            {
                //await DisplayAlert("ScoreCardData", "ScoreCardData = " + msg2, "Ok");

                int hNum = 0;
                for (int i = 0; i < rawScores.Length; i++)
                {
                    hNum = (i + 1);
                    string rawStart = "\"h" + hNum + "r\": ";
                    int startInd = msg2.IndexOf(rawStart) + rawStart.Length;
                    int endInd = msg2.Substring(startInd).IndexOf(",");

                    //await DisplayAlert("Raw Score " + hNum, "RScore = " + msg2.Substring(startInd, endInd), "Ok");
                    rawScores[i] = Int32.Parse(msg2.Substring(startInd, endInd));

                    string hcStart = "\"h" + hNum + "hc\": ";
                    startInd = msg2.IndexOf(hcStart) + hcStart.Length;
                    endInd = msg2.Substring(startInd).IndexOf(",");

                    //await DisplayAlert("Handicap Score " + hNum, "HScore = " + msg2.Substring(startInd, endInd), "Ok");
                    handicapScores[i] = Int32.Parse(msg2.Substring(startInd, endInd));


                    string specialStart = "\"h" + hNum + "sp\": ";
                    startInd = msg2.IndexOf(specialStart) + specialStart.Length;
                    if (hNum != 18)
                    {
                        endInd = msg2.Substring(startInd).IndexOf(",");
                    }
                    else
                    {
                        endInd = msg2.Substring(startInd).IndexOf("}");
                    }

                    //await DisplayAlert("Special Score " + hNum, "SScore = " + msg2.Substring(startInd, endInd), "Ok");
                    specialScores[i] = Int32.Parse(msg2.Substring(startInd, endInd));
                }

                currentScoreCard = new ScoreCard();
                currentScoreCard.id = id;
                currentScoreCard.uid = uid;
                currentScoreCard.rawScores = rawScores;
                currentScoreCard.handicapScores = handicapScores;
                currentScoreCard.specialScores = specialScores;
                currentScoreCard.calcFinals();
            }

        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Send(this, "PreventLandscape");
        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Sd User count", sd.watchingPlayers.Count.ToString(), "Ok");

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
    }
}