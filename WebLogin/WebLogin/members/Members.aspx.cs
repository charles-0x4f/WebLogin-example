using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLogin
{
    public partial class Members : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Make sure we're authenticated
            bool authenticated = User.Identity.IsAuthenticated;

            // Redirect if we're not
            if (!authenticated)
            {
                Server.Transfer("Default.aspx");
            }
            else
            {
                // Set our label to the RSS feed
                Label1.Text = RSSScrape();
            }
        }

        // Will return a string that contains valid HTML printout of an RSS feed, particularly the Town of Cary's
        public static string RSSScrape()
        {
            string scrape = "";

            System.Xml.XmlReader reader = System.Xml.XmlReader.Create("http://www.townofcary.org/Page20162.rss");
            System.ServiceModel.Syndication.SyndicationFeed feed = System.ServiceModel.Syndication.SyndicationFeed.Load(reader);
            reader.Close();

            // Read in each item and add it to the scrape string
            foreach (System.ServiceModel.Syndication.SyndicationItem item in feed.Items)
            {
                scrape += "<a href=" + item.Links[0].Uri + ">" + item.Title.Text + "</a>";
                scrape += "<br>";
                scrape += item.Summary.Text;
                scrape += "<br><br>";
            }

            return scrape;
        }
    }
}