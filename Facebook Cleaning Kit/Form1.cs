/*
 * This program writen by Hasala Dananjaya Github:- github.com/wisnshaftler
 * This is beta Version
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Facebook_Cleaning_Kit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnViewInactiveFriend_Click(object sender, EventArgs e)
        {
            if(lstvInactiveList.SelectedItems.Count > 0)
            {
                Process.Start(lstvInactiveList.SelectedItems[0].SubItems[1].Text);
            }
            else
            {
                lblStatus.Text = "Plese select an item ";
            }
        }

        private void btnViewActiveFriend_Click(object sender, EventArgs e)
        {
            if(lstvActiveList.SelectedItems.Count > 0)
            {
                Process.Start(lstvActiveList.SelectedItems[0].SubItems[1].Text);
            }
            else
            {
                lblStatus.Text = "Plese select an item ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item = lstvInactiveList.SelectedItems[0];
            lstvInactiveList.Items.Remove(item);
            lstvActiveList.Items.Add(item);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            linkhavetounfriend = true;
            boolPostSeeMore = true;
            boolGetActiveFriend = true;
            boolGetFriendList = true;
            boolStartUnfriend = true;

            btnInactiveUnfriend.Enabled = false;
            btnAllUnfriend.Enabled = false;
            btnDeleteAllChats.Enabled = false;
            btnRemoveUnfriendList.Enabled = false;
           // btnViewInactiveFriend.Enabled = false;
           // btnStartUnfriend.Enabled = false;
           // btnViewActiveFriend.Enabled = false;
            btnRemoveActiveFriend.Enabled = false;

            int counter = lstvInactiveList.Items.Count - 1;
            browser.Navigate(lstvInactiveList.Items[counter].SubItems[1].Text);
        }

        private void btnInactiveUnfriend_Click(object sender, EventArgs e)
        {
            browser.Hide();
            allUnfriend = false;
            boolInactiveUnfriend = true;
            maxPostsToScan = Convert.ToInt32(Math.Round(numberBox.Value, 0));
            numberBox.Enabled = false;
            //btnInactiveUnfriend.Enabled = false;
            btnAllUnfriend.Enabled = false;
            btnDeleteAllChats.Enabled = false;
            btnRemoveUnfriendList.Enabled = false;
            btnViewInactiveFriend.Enabled = false;
            btnStartUnfriend.Enabled = false;
            btnViewActiveFriend.Enabled = false;
            btnRemoveActiveFriend.Enabled = false;

            browser.Navigate("https://mbasic.facebook.com/profile.php?ref_component=mbasic_home_header");

        }
        //declare variables
        public bool boolGetActiveFriend, boolGetFriendList, boolCheckLink, boolInactiveUnfriend, boolAllUnfriend,
            boolDeleteAllChat, boolPostSeeMore, newPostLink, postLinkHaveNow = false;
        public bool redirectToHome, redirectToFriends, linkhavetounfriend, allUnfriend, boolStartUnfriend,
            clickMore, confirmunfriend, linkhavetodelete, confirmdelete = false;
        public int activeFriendCounter, inactiveFriendCounter, postCounter, chatCounter, maxPostsToScan,
            unfriendCount, unfriendRefreshCounter, msgDelteCount = 0;

        private void lstvInactiveList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnInactiveUnfriend.Enabled = false;
            btnAllUnfriend.Enabled = false;
            btnDeleteAllChats.Enabled = false;
            btnRemoveUnfriendList.Enabled = false;
            btnViewInactiveFriend.Enabled = false;
            btnStartUnfriend.Enabled = false;
            btnViewActiveFriend.Enabled = false;
            btnRemoveActiveFriend.Enabled = false;
        }

        private void btnDeleteAllChats_Click(object sender, EventArgs e)
        {
            browser.Hide();
            boolInactiveUnfriend = false;
            boolCheckLink = true;
            boolDeleteAllChat = true;

            btnInactiveUnfriend.Enabled = false;
            btnAllUnfriend.Enabled = false;
            //btnDeleteAllChats.Enabled = false;
            btnRemoveUnfriendList.Enabled = false;
            btnViewInactiveFriend.Enabled = false;
            btnStartUnfriend.Enabled = false;
            btnViewActiveFriend.Enabled = false;
            btnRemoveActiveFriend.Enabled = false;

            browser.Navigate("mbasic.facebook.com/messages/");
        }

        private void btnAllUnfriend_Click(object sender, EventArgs e)
        {
            browser.Hide();
            boolInactiveUnfriend = true;
            boolGetFriendList = false;
            boolPostSeeMore = true;
            boolGetActiveFriend = true;
            allUnfriend = true;
            btnInactiveUnfriend.Enabled = false;
            //btnAllUnfriend.Enabled = false;
            btnDeleteAllChats.Enabled = false;
            btnRemoveUnfriendList.Enabled = false;
            btnViewInactiveFriend.Enabled = false;
            btnStartUnfriend.Enabled = false;
            btnViewActiveFriend.Enabled = false;
            btnRemoveActiveFriend.Enabled = false;

            browser.Navigate("https://mbasic.facebook.com/profile.php?v=friends");
        }

        private void btnRemoveActiveFriend_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item = lstvActiveList.SelectedItems[0];
            lstvActiveList.Items.Remove(item);
            lstvInactiveList.Items.Add(item);
        }

        public List<String> postLink = new List<string>();//scaning post links

        public List<String> activeFriendList =new List<String>();
        public List<String> activeFriendListName =new List<String>();
        public List<String> friendList =new List<String>();
        public List<String> friendNames = new List<string>();
        public List<String> FriendImageList = new List<string>();

        public List<String> tempImageLink = new List<string>();

        public ImageList profilePicAndName = new ImageList();
        public ImageList activeFriendsImageList = new ImageList();

        //end of declaring variables
        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (boolCheckLink == false)//check profile redirection is done 
            {
                checkUrl(boolCheckLink);//call to checkUrl function
            }

            if (boolInactiveUnfriend == true)//if click inactive unfriend
            {
                if (boolPostSeeMore == false)
                {
                    getPostLink(boolPostSeeMore);
                }
                else if (boolGetActiveFriend == false)
                {
                    getActiveFriends(boolGetActiveFriend, postCounter);
                }
                else if (boolGetFriendList == false)
                {
                    getFriendList();
                }
                else if (boolStartUnfriend == true)
                {
                    if (unfriendRefreshCounter > 6)
                    {
                        unfriendRefreshCounter = 0;
                        browser.Navigate(browser.Url.ToString());
                    }
                    else
                    {
                        unfriendRefreshCounter++;
                        startUnfriend();
                    }
                }
            }

            if (boolDeleteAllChat == true)
            {
                deleteAllChat();
            }
        }
        public void deleteAllChat()
        {
            btnDeleteAllChats.Enabled = false;
            if (!browser.Document.Body.InnerHtml.Contains("messages/read/?"))
            {
                lblStatus.Text = "All chats deleted. Deleted chats :- " + msgDelteCount.ToString();
                boolDeleteAllChat = false;
                return;
            }
            lblStatus.Text = msgDelteCount.ToString() + " chats deleted";

            if (linkhavetodelete == false && confirmdelete == false)
            {
                foreach (HtmlElement eli in browser.Document.Links)
                {
                    String link = eli.GetAttribute("href").ToString();
                    if (link.Contains("messages/read/"))
                    {
                        linkhavetodelete = true;
                        eli.InvokeMember("click");
                    }
                }
            }
            if (linkhavetodelete == true && confirmdelete == false)
            {

                foreach (HtmlElement eli in browser.Document.GetElementsByTagName("input"))
                {
                    if (eli.GetAttribute("name").ToString() == ("delete"))
                    {

                        confirmdelete = true;
                        eli.InvokeMember("click");
                    }
                }
            }
            if (linkhavetodelete == true && confirmdelete == true)
            {
                foreach (HtmlElement eli in browser.Document.Links)
                {
                    String link = eli.GetAttribute("href").ToString();
                    if (link.Contains("/messages/action"))
                    {

                        linkhavetodelete = false;
                        confirmdelete = false;
                        msgDelteCount += 1;
                        eli.InvokeMember("click");
                    }
                }
            }
        }
        public void startUnfriend()
        {
            int counter = lstvInactiveList.Items.Count - 1;
            btnStartUnfriend.Enabled = false;
            if (clickMore == false && confirmunfriend == false && linkhavetounfriend == true)
            {
                lblStatus.Text = "Unfriending " + lstvInactiveList.Items[counter].Text +" "+
                    lstvInactiveList.Items[counter].SubItems[1].Text;
                if (!browser.Document.Body.InnerText.Contains("Edit Profile Picture") &&
                    !browser.Document.Body.InnerText.Contains("Add Friend") &&
                    !browser.Document.Body.InnerText.Contains("The page you requested cannot be displayed")&&
                    !browser.Document.Body.InnerText.Contains("It looks like you were misusing " +
                    "this feature by going too quickly"))
                {//oya dila thiyena ewa nattan pahala ewa duwanawa
                    foreach (HtmlElement eli in browser.Document.GetElementsByTagName("a"))
                    {
                        if (eli.GetAttribute("href").Contains("https://mbasic.facebook.com/removefriend.php"))
                        {
                            clickMore = false;
                            confirmunfriend = true;
                            linkhavetounfriend = true;
                            eli.InvokeMember("click");
                        }
                    }
                }
                else if(browser.Document.Body.InnerText.Contains("It looks like you were misusing " +
                    "this feature by going too quickly"))
                {
                    lblStatus.Text = "Your Account temporally block this feature :( Please and try again later";
                    
                }
                else
                {
                    lstvInactiveList.Items.Remove(lstvInactiveList.Items[counter]);
                    counter = lstvInactiveList.Items.Count - 1;
                    browser.Navigate(lstvInactiveList.Items[counter].SubItems[1].Text);
                }
            }
            else if (clickMore == false && confirmunfriend == true && linkhavetounfriend == true)
            {
                foreach (HtmlElement eli in browser.Document.GetElementsByTagName("input"))//input tags okkoma gannawa
                {
                    if (eli.GetAttribute("name").Contains("confirm"))//aragena eke nama confirm thiyena ewa aran obanawa
                    {
                        linkhavetounfriend = false;
                        eli.InvokeMember("click");
                    }
                }
            }
            else if (linkhavetounfriend == false && clickMore == false && confirmunfriend == true)
            {
                if(lstvInactiveList.Items.Count != 0)
                {
                    linkhavetounfriend = true;
                    confirmunfriend = false;
                    clickMore = false;
                    lstvInactiveList.Items.Remove(lstvInactiveList.Items[counter]);
                    counter = lstvInactiveList.Items.Count - 1;
                    browser.Navigate(lstvInactiveList.Items[counter].SubItems[1].Text);
                }
                else
                {
                    lblStatus.Text = "Job done";
                }
            }
        }
        //check user logged to account and redirect to profile page
        public void checkUrl(bool check)
        {
            maxPostsToScan = Convert.ToInt32(Math.Round(numberBox.Value, 0));//get maximum post counter for scan 
            if (browser.Document.Body.InnerText.Contains("Profile"))//check webpage have Profile word
            {
                lblStatus.Text = "redirecting";
                lblStatus.Text = "Click inactive unfriend, All unfriend or Delete all Messages";
                boolCheckLink = true;
                btnInactiveUnfriend.Enabled = true;
                btnAllUnfriend.Enabled = true;
                btnDeleteAllChats.Enabled = true;
                browser.Navigate("https://mbasic.facebook.com/profile.php?ref_component=mbasic_home_header");
            }
            if (browser.Url.ToString().Contains("https://mbasic.facebook.com/?_rdr") || browser.Url.ToString() == "https://mbasic.facebook.com")
            {

                lblStatus.Text = "redirecting";
                lblStatus.Text = "Click inactive unfriend, All unfriend or Delete all Messages";
                boolCheckLink = true;
                btnInactiveUnfriend.Enabled = true;
                btnAllUnfriend.Enabled = true;
                btnDeleteAllChats.Enabled = true;
                browser.Navigate("https://mbasic.facebook.com/profile.php?ref_component=mbasic_home_header");
            }
        }
        //end of the profile page redirection
        //get posts for scan
        public void getPostLink(bool seeMore)
        {
            btnInactiveUnfriend.Enabled = false;
            numberBox.Enabled = false;
            if (seeMore == false)
            {
                lblStatus.Text = "Getting posts " + postLink.Count.ToString() + " done";
                foreach (HtmlElement eli in browser.Document.GetElementsByTagName("a"))
                {
                    String linkItem = eli.GetAttribute("HREF").ToString();//geting page all links
                    if (linkItem.Contains("/story.php?story_fbid=") && eli.InnerText == "Full Story")//check links contain full story
                    {
                        postLink.Add(linkItem);//add to post link 
                    }
                }
                if (browser.DocumentText.ToString().Contains("/profile/timeline/stream/?cursor=") && postLink.Count < maxPostsToScan)
                {
                    //check see more and click if not call to get friend function
                    foreach (HtmlElement eli in browser.Document.Links)
                    {
                        if (eli.GetAttribute("href").Contains("/profile/timeline/stream/?cursor="))
                        {
                            //if have see more and click it
                            eli.InvokeMember("click");
                        }
                    }
                }
                else
                {
                    boolPostSeeMore = true;
                    postCounter = postLink.Count - 1;
                    getActiveFriends(boolInactiveUnfriend, postCounter);
                }
            }
        }
        //end of geting post 
        //getting like or reacted friends
        public void getActiveFriends(bool check, int counter)
        {
            lblStatus.Text = "Getting Active users. " + activeFriendList.Count.ToString() + " found. Scanned " + 
                (postLink.Count - counter).ToString() + " posts from " + postLink.Count.ToString() + " posts";
            if (counter > 0)//check post is >0
            {
                if (newPostLink == false && postLinkHaveNow == false)
                {
                    postLinkHaveNow = true;
                    browser.Navigate(postLink[counter]);
                }
                else if (newPostLink == false && postLinkHaveNow == true)// browser eke post ekak load welanam
                {
                    string oldLink = "";
                    foreach (HtmlElement eli in browser.Document.GetElementsByTagName("a"))
                    {//thiyena okkoma links gannawa
                        if (eli.GetAttribute("href").Contains("ufi/reaction/profile/browser/"))
                        {//aragena oya contains kiyana eka athule thiyena eka thiyeda balala eka uda click koranawa
                            oldLink = eli.GetAttribute("href");
                            break;
                            eli.InvokeMember("click");
                        }
                    }
                    int linkCounter = browser.Document.GetElementsByTagName("a").Count;
                    foreach (HtmlElement eli in browser.Document.GetElementsByTagName("a"))
                    {
                        if(eli.GetAttribute("href").Contains(oldLink))
                        {
                            newPostLink = true;
                            postLinkHaveNow = false;
                            eli.InvokeMember("click");
                        }
                    }
                }
                else if (newPostLink == true && postLinkHaveNow == false)
                {
                    //thiyena okkoma links gannawa
                    foreach (HtmlElement eli in browser.Document.GetElementsByTagName("a"))
                    {
                        //contain eke thiyena okkoma gannawa
                        if (eli.GetAttribute("href").Contains("ufi/reaction/profile/browser/fetch/") )
                        {
                            if (eli.InnerText == ("All 0"))//ekek wat like korala nattan passata goin
                            {
                                newPostLink = false;
                                if (postCounter != 0)
                                {
                                    postCounter -= 1;
                                    browser.Navigate(postLink[postCounter]);
                                }
                            }
                            else 
                            {//mokek hari like koralanam aye list eka load karanwa limit eka bara ganakata set korala 
                                String golink = eli.GetAttribute("href").ToString().Replace("limit=10", "limit=99999");
                                golink = golink.Replace("reaction_type", "");
                                newPostLink = true;
                                postLinkHaveNow = true;
                                browser.Navigate(golink);//ehema load kornawa
                            }
                        }

                    }
                }
                else if (newPostLink == true && postLinkHaveNow == true)
                {
                    foreach (HtmlElement eli in browser.Document.GetElementsByTagName("a"))//okkoma link gannawa
                    {
                        String links = eli.GetAttribute("href").ToString();//get all links in page
                                                                           //listBox1.Items.Add(eli.GetAttribute("href"));
                        if (!links.Contains("https://mbasic.facebook.com/ufi/reaction/") &&
                            !links.Contains("https://mbasic.facebook.com/story.php") &&
                            !links.Contains("https://mbasic.facebook.com/a/mobile/friends/add_friend.php?") &&
                            !links.Contains("https://mbasic.facebook.com/home.php") &&
                            links != ("https://mbasic.facebook.com/profile.php")
                            )
                        {
                            if (!activeFriendList.Contains(links))
                            {
                                //badu link list eke nattan add koranwa
                                if (!links.Contains("hovercard"))
                                {
                                    if (links.Contains("?"))
                                    {
                                        String[] names = links.Split('?');
                                        if (links.Contains("profile.php?id="))
                                        {
                                            links = names[0] +"?"+ names[1];
                                            if (links.Contains("&"))
                                            {
                                                String[] name2 = links.Split('&');
                                                links = name2[0];
                                            }
                                        }
                                        else
                                        {
                                            links = names[0];
                                        }
                                    }
                                   
                                    links = links.Replace("&", "");
                                    links = links.Replace("?fref=fr_tabamp;refid=17", "");
                                    links = links.Replace("refid=17", "");
                                    links = links.Replace("?fref=fr_tab", "");
                                    links = links.Replace("fref=fr_tab", "");
                                    links = links.Replace("?fref=fr_tab", "");
                                    links = links.Replace("?ref=dbl", "");
                                }
                                activeFriendListName.Add(eli.InnerText);
                                activeFriendList.Add(links);
                            }
                        }

                    }

                    newPostLink = false;
                    postLinkHaveNow = false;
                    if (postCounter != 0)//mekath thopita kiyanda onenam programming nokara palayan tahuduwenda :/
                    {
                        postCounter -= 1;
                        browser.Navigate(postLink[postCounter]);//browser eke link ekak load koranwa
                    }
                    else if (postCounter <= 0)
                    {
                        boolGetActiveFriend = true;
                        getFriendList();//onna oya function eka hari method eka hari void eka hari mona labbata hari call koranwa
                    }
                }
            }
            else
            {
               boolGetActiveFriend = true;
               getFriendList();
            }
           
        }
        //end of get active friend
        //start of get friend list
        public void getFriendList()
        {
            btnAllUnfriend.Enabled = false;
            lblStatus.Text = "Getting friend list " + friendList.Count.ToString() + " friends found";
            if (redirectToHome == false && redirectToFriends == false)
            {
                redirectToHome = true;
                browser.Navigate("https://mbasic.facebook.com/profile.php?ref_component=mbasic_home_header");//me link ekata yanawa
            }
            else if (redirectToFriends == false && redirectToHome == true)
            {
                foreach (HtmlElement eli in browser.Document.GetElementsByTagName("a"))//okkoma link gannawa
                {
                    var link = eli.GetAttribute("href").ToString();
                    if ((link.Contains("friends?lst=") || link.Contains("friends&lst")) && eli.InnerText == "Friends")//oya dila thiyena ewa thiyena link eka gannawa
                    {
                        redirectToFriends = true;
                        eli.InvokeMember("click");//aragena eke uda obanawa
                    }

                }
            }
            else if (redirectToFriends == true && redirectToHome == true)
            {
                foreach (HtmlElement eli in browser.Document.GetElementsByTagName("a"))//okkoma link gannawa
                {
                    var link = eli.GetAttribute("href").ToString();
                    if (!link.Contains("https://mbasic.facebook.com/ufi/reaction/") &&
                        !link.Contains("https://mbasic.facebook.com/story.php?") &&
                        !link.Contains("https://mbasic.facebook.com/login/") &&
                        !link.Contains("https://mbasic.facebook.com/a/mobile/friends/add_friend.php?") &&
                        !link.Contains("https://mbasic.facebook.com/messages/") &&
                        !link.Contains("https://mbasic.facebook.com/profile.php?lst=") &&
                        !link.Contains("https://mbasic.facebook.com/notifications.php?") &&
                        !link.Contains("https://mbasic.facebook.com/buddylist.php?") &&
                        !link.Contains("https://mbasic.facebook.com/friends/") &&
                        !link.Contains("https://mbasic.facebook.com/pages/") &&
                        !link.Contains("https://mbasic.facebook.com/groups/?") &&
                        !link.Contains("https://mbasic.facebook.com/events/") &&
                        !link.Contains("https://mbasic.facebook.com/notes/") &&
                        !link.Contains("https://mbasic.facebook.com/saved/") &&
                        !link.Contains("https://mbasic.facebook.com/settings/") &&
                        !link.Contains("https://mbasic.facebook.com/help/") &&
                        !link.Contains("https://mbasic.facebook.com/menu/") &&
                        !link.Contains("https://mbasic.facebook.com/photo.php?") &&
                        !link.Contains("https://mbasic.facebook.com/findfriends/") &&
                        !link.Contains("allactivity?") &&
                        !link.Contains("allactivity") &&
                        !link.Contains("https://mbasic.facebook.com/privacyx") &&
                        !link.Contains("https://mbasic.facebook.com/profile.php?v") &&
                        !link.Contains("https://mbasic.facebook.com/bugnub/") &&
                        !link.Contains("https://mbasic.facebook.com/policies/") &&
                        !link.Contains("https://mbasic.facebook.com/logout.php?") &&
                        !link.Contains("friends?unit_cursor=") &&
                        !link.Contains("v=timeline&lst=") &&
                        !link.Contains("lst=") &&
                        !link.Contains("about?") &&
                        !link.Contains("photos?") &&
                        !link.Contains("v=likes") &&
                        !link.Contains("about?") &&
                        !link.Contains("https://mbasic.facebook.com/home.php") ||
                        link.Contains("mbasic.facebook.com/friends/hovercard")) 
                    {//oya uda thiyen labbawal nattan hari yama magula thiyenawanam hari gannawa
                        Thread.Sleep(10);
                        if (!link.Contains("hovercard"))
                        {
                            if (link.Contains("?"))
                            {
                                String[] names = link.Split('?');
                                if (link.Contains("profile.php?id="))
                                {
                                    link = names[0] + "?"+ names[1];
                                    if (link.Contains("&"))
                                    {
                                        String[] name2 = link.Split('&');
                                        link = name2[0];
                                    }
                                }
                                else
                                {
                                    link = names[0];
                                }
                            }
                            link = link.Replace("&", "");
                            link = link.Replace("?fref=fr_tabamp;refid=17", "");
                            link = link.Replace("refid=17", "");
                            link = link.Replace("?fref=fr_tab", "");
                            link = link.Replace("fref=fr_tab", "");
                            link = link.Replace("?fref=fr_tab", "");
                            link = link.Replace("?ref=dbl", "");
                        }
                        //friendNames.Add(eli.InnerText);
                        friendList.Add(link);//aragena balala nattan obanwa
                        link = "";
                    }
                }
                foreach (HtmlElement eli in browser.Document.GetElementsByTagName("img"))
                {
                    String testing = "";
                    if (!eli.GetAttribute("src").Contains("74x74") &&
                       ( eli.GetAttribute("src").Contains("50x50") ||
                        eli.GetAttribute("src").Contains("s50x50") ||
                        eli.GetAttribute("src").Contains("p86x86") ||
                        eli.GetAttribute("src").Contains("cp0/e15/q65") ||
                        eli.GetAttribute("src").Contains("50.50a") )
                    )
                    {
                        testing = eli.GetAttribute("src");
                        friendNames.Add(eli.GetAttribute("alt"));
                        FriendImageList.Add(testing);
                    }
                    else if (eli.GetAttribute("src").Contains("https://scontent.fcmb1-1.fna.fbcdn.net/v/t1.0-1/fr/"))
                    {
                        testing = eli.GetAttribute("src");
                        friendNames.Add(eli.GetAttribute("alt"));
                        FriendImageList.Add(testing);
                    }
                    
                }
                profilePicAndName.ImageSize = new Size(50, 50);
  
                foreach (HtmlElement eli in browser.Document.GetElementsByTagName("a"))//okkoma link gannawa
                {
                    var links = eli.GetAttribute("href").ToString();
                    if ((links.Contains("friends?unit_cursor=") || links.Contains("friends&unit_cursor=")) && 
                        (eli.InnerText.Contains("See More Friends") || eli.InnerText.Contains("See More friends") || 
                        eli.InnerText.Contains("See more friends") || eli.InnerText.Contains("see more friends")))//oya dila thiyena ewa thiyena link eka gannawa
                    {//
                        eli.InvokeMember("click");//obanawa
                    }
                }

            }
            if (browser.Url.ToString().Contains("unit_cursor=") && !browser.Document.Body.InnerText.Contains("See more friends") && !browser.Document.Body.InnerText.Contains("See More Friends"))
            {
                lblStatus.Text = friendList.Count.ToString() + "friends found";
                boolGetFriendList = true;

                if (allUnfriend == false)
                {
                    lblStatus.Text = "panna";
                    compareFriends();//call kala
                }
                else
                {
                    browser.Hide();
                    linkhavetounfriend = true;
                    for (int i = 0; i < FriendImageList.Count; i++)
                    {
                        System.Net.WebRequest request = System.Net.WebRequest.Create(FriendImageList[i]);
                        System.Net.WebResponse response = request.GetResponse();
                        System.IO.Stream respostrime = response.GetResponseStream();
                        Bitmap bitmap = new Bitmap(respostrime);
                        respostrime.Dispose();

                        profilePicAndName.Images.Add(bitmap);
                    }

                    lstvInactiveList.View = View.Details;
                    lstvInactiveList.Columns.Add("");
                    lstvInactiveList.SmallImageList = profilePicAndName;
                    lstvInactiveList.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

                    lstvActiveList.View = View.Details;
                    lstvActiveList.Columns.Add("");
                    lstvActiveList.SmallImageList = profilePicAndName;
                    lstvActiveList.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

                    lblStatus.Text = profilePicAndName.Images.Count.ToString() + "  " + friendList.Count.ToString();
                    for (int i = 0; i < profilePicAndName.Images.Count; i++)
                    {
                        lblStatus.Text = "Getting Images " + i.ToString() + " done";
                        ListViewItem item = new ListViewItem();
                        item.Text = friendNames[i];
                        item.ImageIndex = i;
                        item.SubItems.Add(friendList[i]);

                        lstvInactiveList.Items.Add(item);
                    }
                    lblActiveStatus.Text = "Active Friends " + lstvActiveList.Items.Count.ToString();
                    lblInactiveStatus.Text = "Inactive Friends " + lstvInactiveList.Items.Count.ToString();
                    lblStatus.Text = "click inactive friend in inactive list and click remove from inactive friend button for keep friend in friend list" +
                "click active friend in active list and click remove from active list for unfriend";

                    btnRemoveUnfriendList.Enabled = true;
                    btnViewInactiveFriend.Enabled = true;
                    btnStartUnfriend.Enabled = true;
                    btnViewActiveFriend.Enabled = true;
                    btnRemoveActiveFriend.Enabled = true;
                   // lblStatus.Text = "done ";
                }
            }
        }
        //end of getFriendList
        //start CompareFriends
        public void compareFriends()
        {
           browser.Hide();
            lblStatus.Text = "Comparing friends please wait";
            
            for (int i=0; i <activeFriendList.Count; i++)
            {
                /*int counter = friendList.Count - 1;
                while (0<= counter)
                {
                    if(activeFriendList[i] == friendList[counter])
                    {
                        activeFriendList.RemoveAt(i);
                        break;
                    }
                    counter--;
                }*/
                
                if (!friendList.Contains(activeFriendList[i]))
                {
                    activeFriendListName.RemoveAt(i);
                    activeFriendList.Remove(activeFriendList[i]);
                }
            }

           for(int i=0; i<FriendImageList.Count; i++)
            {
                System.Net.WebRequest request = System.Net.WebRequest.Create(FriendImageList[i]);
                System.Net.WebResponse response = request.GetResponse();
                System.IO.Stream respostrime = response.GetResponseStream();
                Bitmap bitmap = new Bitmap(respostrime);
                respostrime.Dispose();

                profilePicAndName.Images.Add(bitmap);
            }

            lstvInactiveList.View = View.Details;
            lstvInactiveList.Columns.Add("");
            lstvInactiveList.SmallImageList = profilePicAndName;
            lstvInactiveList.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            lstvActiveList.View = View.Details;
            lstvActiveList.Columns.Add("");
            lstvActiveList.SmallImageList = profilePicAndName;
            lstvActiveList.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            lblStatus.Text = profilePicAndName.Images.Count.ToString() + "  " + friendList.Count.ToString();
           for (int i=0; i<profilePicAndName.Images.Count; i++)
            {
                lblStatus.Text = "Getting Images " + i.ToString() + " done";
                ListViewItem item = new ListViewItem();
                item.Text = friendNames[i];
                item.ImageIndex = i;
                item.SubItems.Add(friendList[i]);

                lstvInactiveList.Items.Add(item);
            }
           for (int i=0; i<lstvInactiveList.Items.Count; i++)
            {/*
                int counter = activeFriendList.Count - 1;
                while( counter >= 0)
                {
                    if(activeFriendList[counter] == lstvInactiveList.Items[i].SubItems[1].Text)
                    {
                        ListViewItem item = new ListViewItem();
                        item = lstvInactiveList.Items[i];
                        lstvInactiveList.Items.RemoveAt(i);
                        lstvActiveList.Items.Add(item);
                    }
                    else
                    {
                        counter--;
                    }
                }*/
                
                if (activeFriendList.Contains(lstvInactiveList.Items[i].SubItems[1].Text))
                {
                    ListViewItem item = new ListViewItem();
                    item = lstvInactiveList.Items[i];
                    lstvInactiveList.Items.Remove(lstvInactiveList.Items[i]);
                    lstvActiveList.Items.Add(item);             
                }
            }
            lblActiveStatus.Text = "Active Friends "+lstvActiveList.Items.Count.ToString();
            lblInactiveStatus.Text = "Inactive Friends "+ lstvInactiveList.Items.Count.ToString();
            lblStatus.Text = "click inactive friend in inactive list and click remove from inactive friend button for keep friend in friend list" +
                "click active friend in active list and click remove from active list for unfriend";
            btnRemoveUnfriendList.Enabled = true;
            btnViewInactiveFriend.Enabled = true;
            btnStartUnfriend.Enabled = true;
            btnViewActiveFriend.Enabled = true;
            btnRemoveActiveFriend.Enabled = true;
        }
        //end of compare friends
    }
}

