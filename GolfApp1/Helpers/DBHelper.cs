using GolfApp1.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GolfApp1.Helpers
{
    public class DBHelper
    {
        //Uses Singleton pattern and provides basic functions to other classes
        private static DBHelper myinstance;
        private string baseAddress = "https://golfserversws6042.herokuapp.com/";

        private DBHelper()
        {

        }

        public static DBHelper getInstance()
        {
            if (myinstance == null)
            {
                myinstance = new DBHelper();
            }
            return myinstance;
        }

        public async Task<bool> createCourseAsync(string name, int par, int[] pars, int[] handicaps)
        {
            if (pars.Length < 18 || handicaps.Length < 18)
            {
                return false;
            }

            IEnumerable<KeyValuePair<string, string>> courseData = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("name", name),
                new KeyValuePair<string, string>("par", par.ToString()),
                new KeyValuePair<string, string>("h1p", pars[0].ToString()),
                new KeyValuePair<string, string>("h2p", pars[1].ToString()),
                new KeyValuePair<string, string>("h3p", pars[2].ToString()),
                new KeyValuePair<string, string>("h4p", pars[3].ToString()),
                new KeyValuePair<string, string>("h5p", pars[4].ToString()),
                new KeyValuePair<string, string>("h6p", pars[5].ToString()),
                new KeyValuePair<string, string>("h7p", pars[6].ToString()),
                new KeyValuePair<string, string>("h8p", pars[7].ToString()),
                new KeyValuePair<string, string>("h9p", pars[8].ToString()),
                new KeyValuePair<string, string>("h10p", pars[9].ToString()),
                new KeyValuePair<string, string>("h11p", pars[10].ToString()),
                new KeyValuePair<string, string>("h12p", pars[11].ToString()),
                new KeyValuePair<string, string>("h13p", pars[12].ToString()),
                new KeyValuePair<string, string>("h14p", pars[13].ToString()),
                new KeyValuePair<string, string>("h15p", pars[14].ToString()),
                new KeyValuePair<string, string>("h16p", pars[15].ToString()),
                new KeyValuePair<string, string>("h17p", pars[16].ToString()),
                new KeyValuePair<string, string>("h18p", pars[17].ToString()),
                new KeyValuePair<string, string>("h1hc", handicaps[0].ToString()),
                new KeyValuePair<string, string>("h2hc", handicaps[1].ToString()),
                new KeyValuePair<string, string>("h3hc", handicaps[2].ToString()),
                new KeyValuePair<string, string>("h4hc", handicaps[3].ToString()),
                new KeyValuePair<string, string>("h5hc", handicaps[4].ToString()),
                new KeyValuePair<string, string>("h6hc", handicaps[5].ToString()),
                new KeyValuePair<string, string>("h7hc", handicaps[6].ToString()),
                new KeyValuePair<string, string>("h8hc", handicaps[7].ToString()),
                new KeyValuePair<string, string>("h9hc", handicaps[8].ToString()),
                new KeyValuePair<string, string>("h10hc", handicaps[9].ToString()),
                new KeyValuePair<string, string>("h11hc", handicaps[10].ToString()),
                new KeyValuePair<string, string>("h12hc", handicaps[11].ToString()),
                new KeyValuePair<string, string>("h13hc", handicaps[12].ToString()),
                new KeyValuePair<string, string>("h14hc", handicaps[13].ToString()),
                new KeyValuePair<string, string>("h15hc", handicaps[14].ToString()),
                new KeyValuePair<string, string>("h16hc", handicaps[15].ToString()),
                new KeyValuePair<string, string>("h17hc", handicaps[16].ToString()),
                new KeyValuePair<string, string>("h18hc", handicaps[17].ToString())
            };

            int nextID = 0;
            nextID = await getNextCourseID();
            string address = baseAddress + "course/" + nextID.ToString();

            await putRequest(address, courseData);

            return true;
        }

        public async Task<bool> clearScoreCard(int id)
        {
            IEnumerable<KeyValuePair<string, string>> scoreCardData = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("h1r", "0"),
                new KeyValuePair<string, string>("h2r", "0"),
                new KeyValuePair<string, string>("h3r", "0"),
                new KeyValuePair<string, string>("h4r", "0"),
                new KeyValuePair<string, string>("h5r", "0"),
                new KeyValuePair<string, string>("h6r", "0"),
                new KeyValuePair<string, string>("h7r", "0"),
                new KeyValuePair<string, string>("h8r", "0"),
                new KeyValuePair<string, string>("h9r", "0"),
                new KeyValuePair<string, string>("h10r", "0"),
                new KeyValuePair<string, string>("h11r", "0"),
                new KeyValuePair<string, string>("h12r", "0"),
                new KeyValuePair<string, string>("h13r", "0"),
                new KeyValuePair<string, string>("h14r", "0"),
                new KeyValuePair<string, string>("h15r", "0"),
                new KeyValuePair<string, string>("h16r", "0"),
                new KeyValuePair<string, string>("h17r", "0"),
                new KeyValuePair<string, string>("h18r", "0"),
                new KeyValuePair<string, string>("h1hc", "0"),
                new KeyValuePair<string, string>("h2hc", "0"),
                new KeyValuePair<string, string>("h3hc", "0"),
                new KeyValuePair<string, string>("h4hc", "0"),
                new KeyValuePair<string, string>("h5hc", "0"),
                new KeyValuePair<string, string>("h6hc", "0"),
                new KeyValuePair<string, string>("h7hc", "0"),
                new KeyValuePair<string, string>("h8hc", "0"),
                new KeyValuePair<string, string>("h9hc", "0"),
                new KeyValuePair<string, string>("h10hc", "0"),
                new KeyValuePair<string, string>("h11hc", "0"),
                new KeyValuePair<string, string>("h12hc", "0"),
                new KeyValuePair<string, string>("h13hc", "0"),
                new KeyValuePair<string, string>("h14hc", "0"),
                new KeyValuePair<string, string>("h15hc", "0"),
                new KeyValuePair<string, string>("h16hc", "0"),
                new KeyValuePair<string, string>("h17hc", "0"),
                new KeyValuePair<string, string>("h18hc", "0"),
                new KeyValuePair<string, string>("h1sp", "0"),
                new KeyValuePair<string, string>("h2sp", "0"),
                new KeyValuePair<string, string>("h3sp", "0"),
                new KeyValuePair<string, string>("h4sp", "0"),
                new KeyValuePair<string, string>("h5sp", "0"),
                new KeyValuePair<string, string>("h6sp", "0"),
                new KeyValuePair<string, string>("h7sp", "0"),
                new KeyValuePair<string, string>("h8sp", "0"),
                new KeyValuePair<string, string>("h9sp", "0"),
                new KeyValuePair<string, string>("h10sp", "0"),
                new KeyValuePair<string, string>("h11sp", "0"),
                new KeyValuePair<string, string>("h12sp", "0"),
                new KeyValuePair<string, string>("h13sp", "0"),
                new KeyValuePair<string, string>("h14sp", "0"),
                new KeyValuePair<string, string>("h15sp", "0"),
                new KeyValuePair<string, string>("h16sp", "0"),
                new KeyValuePair<string, string>("h17sp", "0"),
                new KeyValuePair<string, string>("h18sp", "0")
            };

            HttpClient client = new HttpClient();
            HttpContent content = new FormUrlEncodedContent(scoreCardData);

            HttpMethod method = new HttpMethod("PATCH");
            HttpRequestMessage request = new HttpRequestMessage(method, baseAddress + "scorecard/" + id)
            {
                Content = content
            };

            HttpResponseMessage response = await client.SendAsync(request);

            return true;
        }

        public async Task<bool> updateUser(string id, string field, string text)
        {
            IEnumerable<KeyValuePair<string, string>> updateData = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>(field, text)
            };
            HttpClient client = new HttpClient();
            HttpContent content = new FormUrlEncodedContent(updateData);

            HttpMethod method = new HttpMethod("PATCH");
            HttpRequestMessage request = new HttpRequestMessage(method, baseAddress + "user/" + id)
            {
                Content = content
            };

            HttpResponseMessage response = await client.SendAsync(request);
            return true;
        }

        public async Task<ScoreCard> createScoreCardAsync(int uid, int cid)
        {
            IEnumerable<KeyValuePair<string, string>> scoreCardData = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("uid", uid.ToString()),
                new KeyValuePair<string, string>("cid", cid.ToString()),
                new KeyValuePair<string, string>("h1r", "0"),
                new KeyValuePair<string, string>("h2r", "0"),
                new KeyValuePair<string, string>("h3r", "0"),
                new KeyValuePair<string, string>("h4r", "0"),
                new KeyValuePair<string, string>("h5r", "0"),
                new KeyValuePair<string, string>("h6r", "0"),
                new KeyValuePair<string, string>("h7r", "0"),
                new KeyValuePair<string, string>("h8r", "0"),
                new KeyValuePair<string, string>("h9r", "0"),
                new KeyValuePair<string, string>("h10r", "0"),
                new KeyValuePair<string, string>("h11r", "0"),
                new KeyValuePair<string, string>("h12r", "0"),
                new KeyValuePair<string, string>("h13r", "0"),
                new KeyValuePair<string, string>("h14r", "0"),
                new KeyValuePair<string, string>("h15r", "0"),
                new KeyValuePair<string, string>("h16r", "0"),
                new KeyValuePair<string, string>("h17r", "0"),
                new KeyValuePair<string, string>("h18r", "0"),
                new KeyValuePair<string, string>("h1hc", "0"),
                new KeyValuePair<string, string>("h2hc", "0"),
                new KeyValuePair<string, string>("h3hc", "0"),
                new KeyValuePair<string, string>("h4hc", "0"),
                new KeyValuePair<string, string>("h5hc", "0"),
                new KeyValuePair<string, string>("h6hc", "0"),
                new KeyValuePair<string, string>("h7hc", "0"),
                new KeyValuePair<string, string>("h8hc", "0"),
                new KeyValuePair<string, string>("h9hc", "0"),
                new KeyValuePair<string, string>("h10hc", "0"),
                new KeyValuePair<string, string>("h11hc", "0"),
                new KeyValuePair<string, string>("h12hc", "0"),
                new KeyValuePair<string, string>("h13hc", "0"),
                new KeyValuePair<string, string>("h14hc", "0"),
                new KeyValuePair<string, string>("h15hc", "0"),
                new KeyValuePair<string, string>("h16hc", "0"),
                new KeyValuePair<string, string>("h17hc", "0"),
                new KeyValuePair<string, string>("h18hc", "0"),
                new KeyValuePair<string, string>("h1sp", "0"),
                new KeyValuePair<string, string>("h2sp", "0"),
                new KeyValuePair<string, string>("h3sp", "0"),
                new KeyValuePair<string, string>("h4sp", "0"),
                new KeyValuePair<string, string>("h5sp", "0"),
                new KeyValuePair<string, string>("h6sp", "0"),
                new KeyValuePair<string, string>("h7sp", "0"),
                new KeyValuePair<string, string>("h8sp", "0"),
                new KeyValuePair<string, string>("h9sp", "0"),
                new KeyValuePair<string, string>("h10sp", "0"),
                new KeyValuePair<string, string>("h11sp", "0"),
                new KeyValuePair<string, string>("h12sp", "0"),
                new KeyValuePair<string, string>("h13sp", "0"),
                new KeyValuePair<string, string>("h14sp", "0"),
                new KeyValuePair<string, string>("h15sp", "0"),
                new KeyValuePair<string, string>("h16sp", "0"),
                new KeyValuePair<string, string>("h17sp", "0"),
                new KeyValuePair<string, string>("h18sp", "0")
            };

            int nextID = 0;
            nextID = await getNextScoreCardID();
            string address = baseAddress + "scorecard/" + nextID.ToString();

            await putRequest(address, scoreCardData);

            int[] rs = new int[18];
            int[] hc = new int[18];
            int[] sp = new int[18];

            Array.Clear(rs, 0, rs.Length);
            Array.Clear(hc, 0, hc.Length);
            Array.Clear(sp, 0, sp.Length);


            return new ScoreCard(nextID, uid, cid, rs, hc, sp);
        }

        private async Task<int> getNextScoreCardID()
        {
            int i = 0;
            bool finished = false;
            ScoreCard currentScoreCard;

            while (!finished)
            {
                currentScoreCard = await getScoreCardAsync(i);
                if (currentScoreCard.id == -1)
                {
                    finished = true;
                }
                else
                {
                    i++;
                }
            }

            return i;
        }

        private async Task<int> getNextCourseID()
        {
            int i = 0;
            bool finished = false;
            Course currentCourse;

            while (!finished)
            {
                currentCourse = await getCourseAsync(i);
                if (currentCourse.id == -1)
                {
                    finished = true;
                }
                else
                {
                    i++;
                }
            }

            return i;
        }

        public async Task<User> createUserAsync(string email, string username, int handicap, string password)
        {
            //int ccid = -1;
            //int cscid = -1;
            int ccid = 0;
            int cscid = 0;

            string loggedIn = "yes";


            IEnumerable<KeyValuePair<string, string>> userData = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("email", email),
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("handicap", handicap.ToString()),
                new KeyValuePair<string, string>("password", password),
                new KeyValuePair<string, string>("ccid", ccid.ToString()),
                new KeyValuePair<string, string>("cscid", cscid.ToString()),
                new KeyValuePair<string, string>("loggedin", loggedIn)
            };


            int nextID = 0;
            nextID = await getNextUserID();
            string address = baseAddress + "user/" + nextID.ToString();

            await putRequest(address, userData);

            //bool li;
            //if (loggedIn.ToLower() == "no") {
            //    li = false;
            //}
            //else {
            //    li = true;
            //}

            return new User(nextID, email, username, handicap, password, ccid, cscid, loggedIn);
        }

        private async Task<int> getNextUserID()
        {
            int i = 0;
            bool finished = false;
            User currentUser;

            while (!finished)
            {
                currentUser = await getUserAsync(i);
                if (currentUser.id == -1)
                {
                    finished = true;
                }
                else
                {
                    i++;
                }
            }

            return i;
        }

        public async Task<bool> putRequest(string address, IEnumerable<KeyValuePair<string, string>> data)
        {
            HttpClient client = new HttpClient();
            HttpContent content = new FormUrlEncodedContent(data);
            await client.PutAsync(address, content);
            return true;
        }

        public async Task<User> getUserAsync(int id)
        {
            User ans = new User();
            string address = baseAddress + "user/" + id;
            Task t = getInfo(address);
            string msg = await getInfo(address);

            ans = parseUserMsg(msg);

            return ans;
        }

        public async void removeUserAsync(int id)
        {
            HttpClient client = new HttpClient();
            string address = baseAddress + "user/" + id;
            HttpResponseMessage response = await client.DeleteAsync(address);
        }

        public async Task<Course> getCourseAsync(int id)
        {
            Course ans = new Course();
            string address = baseAddress + "course/" + id;
            Task t = getInfo(address);
            string msg = await getInfo(address);

            ans = parseCourseMsg(msg);

            return ans;
        }

        public async void removeCourseAsync(int id)
        {
            HttpClient client = new HttpClient();
            string address = baseAddress + "course/" + id;
            HttpResponseMessage response = await client.DeleteAsync(address);
        }

        public async Task<ScoreCard> getScoreCardAsync(int id)
        {
            ScoreCard ans = new ScoreCard();
            string address = baseAddress + "scorecard/" + id;
            Task t = getInfo(address);
            string msg = await getInfo(address);

            ans = parseScoreCardMsg(msg);

            return ans;
        }

        public async void removeScoreCardAsync(int id)
        {
            HttpClient client = new HttpClient();
            string address = baseAddress + "scorecard/" + id;
            HttpResponseMessage response = await client.DeleteAsync(address);
        }

        private async Task<string> getInfo(string address)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(address);
            string msg = await response.Content.ReadAsStringAsync();
            return msg;
        }

        public async Task<List<User>> getAllUsersAsync()
        {
            bool finished = false;
            List<User> ans = new List<User>();
            User currentUser;
            int i = 0;

            //Keep asking for users until their id is invalid
            while (!finished)
            {
                currentUser = await getUserAsync(i);
                if (currentUser.id != -1)
                {
                    ans.Add(currentUser);
                    i++;
                }
                else
                {
                    finished = true;
                }
            }
            return ans;
        }

        //Ex. updateValueAsync(0, "user", "email", "aaa@gmail.com") updates /user/0's email field to aaa@gmail.com
        public async void updateValueAsync(int id, string type, string field, string newData)
        {
            IEnumerable<KeyValuePair<string, string>> updateData = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>(field, newData)
            };
            HttpClient client = new HttpClient();
            HttpContent content = new FormUrlEncodedContent(updateData);

            HttpMethod method = new HttpMethod("PATCH");
            HttpRequestMessage request = new HttpRequestMessage(method, baseAddress + type + "/" + id)
            {
                Content = content
            };

            HttpResponseMessage response = await client.SendAsync(request);
        }

        private User parseUserMsg(string msg)
        {
            int id = 0;
            string email = "";
            string username = "";
            int handicap = 0;
            string password = "";
            int currentCourseID = 0;
            int currentScoreCardID = 0;
            string loggedIn = "";

            string idStartStr = "\"id\": ";
            string emailStartStr = "\"email\": \"";
            string usernameStartStr = "\"username\": \"";
            string handicapStartStr = "\"handicap\": ";
            string passwordStartStr = "\"password\": \"";
            string ccidStartStr = "\"ccid\": ";
            string cscidStartStr = "\"cscid\": ";
            string loggedInStartStr = "\"loggedin\": \"";

            string intEndStr = ",";
            string strEndStr = "\",";
            string finalEndStr = "\"}";

            int startInd = 0;
            int endInd = 0;

            if (!msg.Contains(idStartStr))
            {
                return new User(-1, email, username, handicap, password, currentCourseID, currentScoreCardID, loggedIn);
            }

            startInd = msg.IndexOf(idStartStr) + idStartStr.Length;
            endInd = msg.Substring(startInd).IndexOf(intEndStr);
            id = Int32.Parse(msg.Substring(startInd, endInd));

            startInd = msg.IndexOf(emailStartStr) + emailStartStr.Length;
            endInd = msg.Substring(startInd).IndexOf(strEndStr);
            email = msg.Substring(startInd, endInd);

            startInd = msg.IndexOf(usernameStartStr) + usernameStartStr.Length;
            endInd = msg.Substring(startInd).IndexOf(strEndStr);
            username = msg.Substring(startInd, endInd);

            startInd = msg.IndexOf(handicapStartStr) + handicapStartStr.Length;
            endInd = msg.Substring(startInd).IndexOf(intEndStr);
            handicap = Int32.Parse(msg.Substring(startInd, endInd));

            startInd = msg.IndexOf(passwordStartStr) + passwordStartStr.Length;
            endInd = msg.Substring(startInd).IndexOf(strEndStr);
            password = msg.Substring(startInd, endInd);

            startInd = msg.IndexOf(ccidStartStr) + ccidStartStr.Length;
            endInd = msg.Substring(startInd).IndexOf(intEndStr);
            currentCourseID = Int32.Parse(msg.Substring(startInd, endInd));

            startInd = msg.IndexOf(cscidStartStr) + cscidStartStr.Length;
            endInd = msg.Substring(startInd).IndexOf(intEndStr);
            currentScoreCardID = Int32.Parse(msg.Substring(startInd, endInd));

            startInd = msg.IndexOf(loggedInStartStr) + loggedInStartStr.Length;
            endInd = msg.Substring(startInd).IndexOf(finalEndStr);
            loggedIn = msg.Substring(startInd);

            //if (loggedInMsg == "true" || loggedInMsg == "yes") {
            //    loggedIn = true;
            //}

            return new User(id, email, username, handicap, password, currentCourseID, currentScoreCardID, loggedIn);
        }

        private Course parseCourseMsg(string msg)
        {
            int id = 0;
            string name = "";
            int par = 0;
            int[] pars = new int[18];
            int[] handicaps = new int[18];

            string idStartStr = "\"id\": ";
            string nameStartStr = "\"name\": \"";
            string parStartStr = "\"par\": ";

            if (!msg.Contains(idStartStr))
            {
                Array.Clear(pars, 0, pars.Length);
                Array.Clear(handicaps, 0, handicaps.Length);
                return new Course(-1, "", 0, pars, handicaps);
            }

            string intEndStr = ",";
            string strEndStr = "\",";
            string finalEndStr = "}";

            int startInd = 0;
            int endInd = 0;

            startInd = msg.IndexOf(idStartStr) + idStartStr.Length;
            endInd = msg.Substring(startInd).IndexOf(intEndStr);
            id = Int32.Parse(msg.Substring(startInd, endInd));

            startInd = msg.IndexOf(nameStartStr) + nameStartStr.Length;
            endInd = msg.Substring(startInd).IndexOf(strEndStr);
            name = msg.Substring(startInd, endInd);

            startInd = msg.IndexOf(parStartStr) + parStartStr.Length;
            endInd = msg.Substring(startInd).IndexOf(intEndStr);
            par = Int32.Parse(msg.Substring(startInd, endInd));

            //Get pars and handicaps at the same time
            string startStr = "";
            for (int i = 0; i < pars.Length; i++)
            {
                //pars[i] = 0;
                //handicaps[i] = 0;

                if (i < 17)
                {
                    //Pars
                    startStr = getStartStr((i + 1), "p");
                    startInd = msg.IndexOf(startStr) + startStr.Length;
                    endInd = msg.Substring(startInd).IndexOf(intEndStr);
                    pars[i] = Int32.Parse(msg.Substring(startInd, endInd));

                    //Handicaps
                    startStr = getStartStr((i + 1), "hc");
                    startInd = msg.IndexOf(startStr) + startStr.Length;
                    endInd = msg.Substring(startInd).IndexOf(intEndStr);
                    handicaps[i] = Int32.Parse(msg.Substring(startInd, endInd));

                }
                else
                {
                    //Pars
                    startStr = getStartStr((i + 1), "p");
                    startInd = msg.IndexOf(startStr) + startStr.Length;
                    endInd = msg.Substring(startInd).IndexOf(intEndStr);
                    pars[i] = Int32.Parse(msg.Substring(startInd, endInd));

                    //Handicaps
                    startStr = getStartStr((i + 1), "hc");
                    startInd = msg.IndexOf(startStr) + startStr.Length;
                    endInd = msg.Substring(startInd).IndexOf(finalEndStr);
                    handicaps[i] = Int32.Parse(msg.Substring(startInd, endInd));
                }
            }

            return new Course(id, name, par, pars, handicaps);
        }

        //Ex. getStartStr(1, "r") returns h1r's start string
        private string getStartStr(int hNum, string type)
        {
            return "\"h" + hNum + type + "\": ";
        }

        private ScoreCard parseScoreCardMsg(string msg)
        {
            int id = 0;
            int userID = 0;
            int courseID = 0;
            int[] rawScores = new int[18];
            int[] handicapScores = new int[18];
            int[] specialScores = new int[18];

            string idStartStr = "\"id\": ";
            string uidStartStr = "\"uid\": ";
            string cidStartStr = "\"cid\": ";

            if (!(msg.Contains(idStartStr)))
            {
                return new ScoreCard();
            }

            string intEndStr = ",";
            string finalEndStr = "}";

            int startInd = 0;
            int endInd = 0;

            startInd = msg.IndexOf(idStartStr) + idStartStr.Length;
            endInd = msg.Substring(startInd).IndexOf(intEndStr);
            id = Int32.Parse(msg.Substring(startInd, endInd));

            startInd = msg.IndexOf(uidStartStr) + uidStartStr.Length;
            endInd = msg.Substring(startInd).IndexOf(intEndStr);
            userID = Int32.Parse(msg.Substring(startInd, endInd));

            startInd = msg.IndexOf(cidStartStr) + cidStartStr.Length;
            endInd = msg.Substring(startInd).IndexOf(intEndStr);
            courseID = Int32.Parse(msg.Substring(startInd, endInd));

            //Get pars and handicaps at the same time
            string startStr = "";
            for (int i = 0; i < rawScores.Length; i++)
            {
                //Raw Scores
                startStr = getStartStr((i + 1), "r");
                startInd = msg.IndexOf(startStr) + startStr.Length;
                endInd = msg.Substring(startInd).IndexOf(intEndStr);
                rawScores[i] = Int32.Parse(msg.Substring(startInd, endInd));

                //Handicaps
                startStr = getStartStr((i + 1), "hc");
                startInd = msg.IndexOf(startStr) + startStr.Length;
                endInd = msg.Substring(startInd).IndexOf(intEndStr);
                handicapScores[i] = Int32.Parse(msg.Substring(startInd, endInd));

                if (i < 17)
                {
                    //Special Scores
                    startStr = getStartStr((i + 1), "sp");
                    startInd = msg.IndexOf(startStr) + startStr.Length;
                    endInd = msg.Substring(startInd).IndexOf(intEndStr);
                    specialScores[i] = Int32.Parse(msg.Substring(startInd, endInd));
                }
                else
                {
                    //Special Scores
                    startStr = getStartStr((i + 1), "sp");
                    startInd = msg.IndexOf(startStr) + startStr.Length;
                    endInd = msg.Substring(startInd).IndexOf(finalEndStr);
                    specialScores[i] = Int32.Parse(msg.Substring(startInd, endInd));
                }
            }

            return new ScoreCard(id, userID, courseID, rawScores, handicapScores, specialScores);
        }

        public async Task<List<Course>> getAllCoursesAsync()
        {
            List<Course> ans = new List<Course>();
            int i = 0;
            Course currentCourse;
            bool finished = false;

            while (!finished)
            {
                currentCourse = await getCourseAsync(i);
                if (currentCourse.id != -1)
                {
                    ans.Add(currentCourse);
                    i++;
                }
                else
                {
                    finished = true;
                }
            }

            return ans;
        }

        public async Task<bool> updateScoreCard(int cardNum, string field, string text)
        {
            IEnumerable<KeyValuePair<string, string>> updateData = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>(field, text)
            };
            HttpClient client = new HttpClient();
            HttpContent content = new FormUrlEncodedContent(updateData);

            HttpMethod method = new HttpMethod("PATCH");
            HttpRequestMessage request = new HttpRequestMessage(method, baseAddress + "scorecard/" + cardNum)
            {
                Content = content
            };

            HttpResponseMessage response = await client.SendAsync(request);
            return true;
        }

        public async Task<bool> updateScoreCardMultiple(int id, List<KeyValuePair<string, string>> data)
        {
            IEnumerable<KeyValuePair<string, string>> updateData = data;
            HttpClient client = new HttpClient();
            HttpContent content = new FormUrlEncodedContent(updateData);

            HttpMethod method = new HttpMethod("PATCH");
            HttpRequestMessage request = new HttpRequestMessage(method, baseAddress + "scorecard/" + id)
            {
                Content = content
            };

            HttpResponseMessage response = await client.SendAsync(request);
            return true;
        }
    }
}
