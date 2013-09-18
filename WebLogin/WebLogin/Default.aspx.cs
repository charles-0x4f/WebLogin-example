using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLogin
{
    public partial class WebLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            // Hardcode username/password; not sure how to transfer ASP.NET administration tool users
            if (Login1.UserName == "user" && Login1.Password == "b@dpassword")
                e.Authenticated = true;
            else
                e.Authenticated = false;
        }
    }
}