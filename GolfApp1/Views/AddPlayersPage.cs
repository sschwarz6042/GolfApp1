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
    public class AddPlayersPage : ContentPage
    {
        private SessionData sd;
        private User currentUser = new User();
        private ScoreCard currentCard = new ScoreCard();

        private int selected;

        private string userAddress = "https://golfserversws6042.herokuapp.com/user/";
        private string scoreCardAddress = "https://golfserversws6042.herokuapp.com/scorecard/";
        private Picker userPicker;
        private Button addUserButton;
        private Button backButton;

        private Grid grid = new Grid();

        public AddPlayersPage(SessionData sessionData)
        {
            sd = sessionData;
            this.BackgroundImageSource = "SharecardBase.png";

            StackLayout stackLayout = new StackLayout();


            userPicker = new Picker();
            userPicker.SelectedIndexChanged += UserPicker_SelectedIndexChanged;

            addUserButton = new Button();
            addUserButton.Text = "Add User";
            addUserButton.Clicked += AddUserButton_Clicked;

            backButton = new Button();
            backButton.Text = "Back <-";
            backButton.Clicked += BackButton_Clicked;

            grid.Children.Add(userPicker, 0, 0);
            grid.Children.Add(addUserButton, 1, 0);
            grid.Children.Add(backButton, 1, 2);

            stackLayout.Children.Add(grid);
            Content = stackLayout;
        }

        private async void UserPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userPicker.Items.Count > 0)
            {
                string email = "";
                string username = "";
                int handicap = 0;
                string password = "";

                HttpClient client = new HttpClient();
                selected = userPicker.SelectedIndex + 1;
                HttpResponseMessage response = await client.GetAsync(userAddress + selected);
                string msg = await response.Content.ReadAsStringAsync();

                //await DisplayAlert("UserData", "User Data = " + msg, "Ok");

                if (msg.Contains("message") && msg.Contains("Could Not Find That User"))
                {
                    await DisplayAlert("ERROR", "User Not Found", "Ok");
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
                    //await DisplayAlert("Username", "Username = " + msg.Substring(startInd, endInd), "Ok");


                    string handicapStart = "\"handicap\": ";
                    startInd = msg.IndexOf(handicapStart) + handicapStart.Length;
                    endInd = msg.Substring(startInd).IndexOf(",");
                    //await DisplayAlert("Handicap", "Handicap = " + msg.Substring(startInd, endInd), "Ok");
                    handicap = Int32.Parse(msg.Substring(startInd, endInd));


                    currentUser = new User(userPicker.SelectedIndex + 1, email, username, handicap, password);
                }

                int id = userPicker.SelectedIndex + 1;
                int uid = userPicker.SelectedIndex + 1;
                int[] rawScores = new int[18];
                int[] handicapScores = new int[18];
                int[] specialScores = new int[18];

                HttpClient client2 = new HttpClient();
                selected = userPicker.SelectedIndex + 1;
                HttpResponseMessage response2 = await client2.GetAsync(scoreCardAddress + selected);
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

                    currentCard = new ScoreCard();
                    currentCard.id = id;
                    currentCard.uid = uid;
                    currentCard.rawScores = rawScores;
                    currentCard.handicapScores = handicapScores;
                    currentCard.specialScores = specialScores;
                    currentCard.calcFinals();
                }
            }

        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
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

        private async void AddUserButton_Clicked(object sender, EventArgs e)
        {
            sd.watchingPlayers.Add(currentUser);
            sd.watchingScoreCards.Add(currentCard);

            await DisplayAlert("Success", "User: " + sd.watchingPlayers.ElementAt(sd.watchingPlayers.Count-1).username + " Added", "Ok");

            //Update picker without the selected ID
            userPicker.Items.Remove(userPicker.Items.ElementAt(userPicker.SelectedIndex));
            //grid.Children.Remove(userPicker);
            //await updateUserList();
            //grid.Children.Add(userPicker, 0, 0);
        }

        protected async override void OnAppearing()
        {
            grid.Children.Remove(userPicker);
            await updateUserList();
            grid.Children.Add(userPicker, 0, 0);
        }

        private async Task updateUserList()
        {
            int id = 0;
            bool finishedChecking = false;
            string msg;

            userPicker.Items.Clear();

            while (!finishedChecking)
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(userAddress + id);
                msg = await response.Content.ReadAsStringAsync();
                //await DisplayAlert("Checking ID", "Checking " + id + "\n" + msg, "Ok");

                if (msg.Contains("message") && msg.Contains("Could Not Find That User"))
                {
                    finishedChecking = true;
                }
                else
                {
                    string nameStart = "\"username\": \"";
                    int startInd = msg.IndexOf(nameStart) + nameStart.Length;
                    int endInd = msg.Substring(startInd).IndexOf("\", ");
                    if (startInd > 0 && endInd > 0)
                    {
                        if (!(userPicker.Items.Contains(msg.Substring(startInd, endInd))))
                        {
                            if (id != sd.userID)
                            {
                                bool alreadyWatched = false;
                                for (int i = 0; i < sd.watchingPlayers.Count; i++) { 
                                    if(sd.watchingPlayers.ElementAt(i).id == id)
                                    {
                                        alreadyWatched = true;
                                    }
                                }
                                if (!alreadyWatched) {
                                    userPicker.Items.Add(msg.Substring(startInd, endInd));
                                }
                            }
                        }
                    }
                    else
                    {
                        //await DisplayAlert("ERROR", "Indexes not correct", "Ok");
                    }
                    id++;
                }

            }
            userPicker.SelectedIndex = 0;
        }
    }
}