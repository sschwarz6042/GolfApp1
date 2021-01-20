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
    public class ViewLeaderBoardPage : ContentPage
    {

        private List<ScoreCard> cards = new List<ScoreCard>();
        private List<(string name, int overall, int[] totals)> gridData = new List<(string name, int overall, int[] totals)>();
        private Grid grid = new Grid();
        private SessionData sd;
        private myLabel nameLabel = new myLabel();
        private myLabel totalScoreLabel = new myLabel();

        public class myLabel : Label
        {
            public myLabel()
            {
                this.FontSize = 25;
                this.FontAttributes = FontAttributes.Bold;
            }
        }

        public ViewLeaderBoardPage(SessionData sessionData)
        {
            ScrollView scrollView = new ScrollView();
            scrollView.Orientation = ScrollOrientation.Both;

            this.BackgroundImageSource = "SharecardBase.png";
            this.sd = sessionData;

            nameLabel = new myLabel();
            nameLabel.Text = "Names:";
            grid.Children.Add(nameLabel, 0, 0);

            totalScoreLabel = new myLabel();
            totalScoreLabel.Text = "Total Score:";
            grid.Children.Add(totalScoreLabel, 1, 0);

            for (int i = 0; i < 18; i++)
            {
                myLabel holeLabel = new myLabel();
                holeLabel.Text = "#" + (i + 1);
                grid.Children.Add(holeLabel, i + 2, 0);
            }

            grid.RowSpacing = 1;

            scrollView.Content = grid;
            Content = scrollView;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Send(this, "PreventLandscape");
            await UpdateLeaderBoard();

            for (int i = 0; i < gridData.Count; i++)
            {
                myLabel nameLabel = new myLabel();
                nameLabel.Text = gridData.ElementAt(i).name;

                myLabel totalLabel = new myLabel();
                myLabel h1t = new myLabel();
                myLabel h2t = new myLabel();
                myLabel h3t = new myLabel();
                myLabel h4t = new myLabel();
                myLabel h5t = new myLabel();
                myLabel h6t = new myLabel();
                myLabel h7t = new myLabel();
                myLabel h8t = new myLabel();
                myLabel h9t = new myLabel();
                myLabel h10t = new myLabel();
                myLabel h11t = new myLabel();
                myLabel h12t = new myLabel();
                myLabel h13t = new myLabel();
                myLabel h14t = new myLabel();
                myLabel h15t = new myLabel();
                myLabel h16t = new myLabel();
                myLabel h17t = new myLabel();
                myLabel h18t = new myLabel();

                totalLabel.Text = gridData.ElementAt(i).overall.ToString();
                h1t.Text = gridData.ElementAt(i).totals[0].ToString();
                h2t.Text = gridData.ElementAt(i).totals[1].ToString();
                h3t.Text = gridData.ElementAt(i).totals[2].ToString();
                h4t.Text = gridData.ElementAt(i).totals[3].ToString();
                h5t.Text = gridData.ElementAt(i).totals[4].ToString();
                h6t.Text = gridData.ElementAt(i).totals[5].ToString();
                h7t.Text = gridData.ElementAt(i).totals[6].ToString();
                h8t.Text = gridData.ElementAt(i).totals[7].ToString();
                h9t.Text = gridData.ElementAt(i).totals[8].ToString();
                h10t.Text = gridData.ElementAt(i).totals[9].ToString();
                h11t.Text = gridData.ElementAt(i).totals[10].ToString();
                h12t.Text = gridData.ElementAt(i).totals[11].ToString();
                h13t.Text = gridData.ElementAt(i).totals[12].ToString();
                h14t.Text = gridData.ElementAt(i).totals[13].ToString();
                h15t.Text = gridData.ElementAt(i).totals[14].ToString();
                h16t.Text = gridData.ElementAt(i).totals[15].ToString();
                h17t.Text = gridData.ElementAt(i).totals[16].ToString();
                h18t.Text = gridData.ElementAt(i).totals[17].ToString();


                grid.Children.Add(nameLabel, 0, i + 1);
                grid.Children.Add(totalLabel, 1, i + 1);
                grid.Children.Add(h1t, 2, i + 1);
                grid.Children.Add(h2t, 3, i + 1);
                grid.Children.Add(h3t, 4, i + 1);
                grid.Children.Add(h4t, 5, i + 1);
                grid.Children.Add(h5t, 6, i + 1);
                grid.Children.Add(h6t, 7, i + 1);
                grid.Children.Add(h7t, 8, i + 1);
                grid.Children.Add(h8t, 9, i + 1);
                grid.Children.Add(h9t, 10, i + 1);
                grid.Children.Add(h10t, 11, i + 1);
                grid.Children.Add(h11t, 12, i + 1);
                grid.Children.Add(h12t, 13, i + 1);
                grid.Children.Add(h13t, 14, i + 1);
                grid.Children.Add(h14t, 15, i + 1);
                grid.Children.Add(h15t, 16, i + 1);
                grid.Children.Add(h16t, 17, i + 1);
                grid.Children.Add(h17t, 18, i + 1);
                grid.Children.Add(h18t, 19, i + 1);
            }
        }

        private async Task<bool> UpdateLeaderBoard()
        {
            gridData.Clear();

            List<User> users = new List<User>();
            users.Add(sd.currentUser);
            for (int i = 0; i < sd.watchingUsers.Count; i++)
            {
                users.Add(sd.watchingUsers.ElementAt(i));
            }

            for (int i = 0; i < users.Count; i++)
            {
                ScoreCard currentCard = await DBHelper.getInstance().getScoreCardAsync(users.ElementAt(i).currentScoreCardID);
                cards.Add(currentCard);
                gridData.Add((users.ElementAt(i).username, currentCard.calcTotal(), currentCard.getTotals()));
            }

            gridData.Sort(gridCompare);

            return true;
        }

        private int gridCompare((string name, int overall, int[] totals) x, (string name, int overall, int[] totals) y)
        {
            return x.overall - y.overall;
        }
    }
}