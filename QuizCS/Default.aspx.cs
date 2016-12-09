using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // In order for the SqlDataSource1 to bind
        // correctly it needed an input parameter
        // and unfortunately I couldn't specify 
        // Profile.UserName since it wasn't in the
        // property bag of Profile, but was a real
        // property.  So, this is a bit of a kluge
        // and I feel bad about it, but since we're
        // using session, why not pile one more 
        // data element on top ...  :)

        if (Profile.IsAnonymous == false)
        {
            Session.Add("UserName", User.Identity.Name);
        }

    }

    void Page_PreInit(object sender, EventArgs e)
    {
        if (Request.QueryString["theme"] != null)
        {
            Profile.Theme = Request.QueryString["theme"]; 
        }

        if (Profile.IsAnonymous == false)
        {
            if (Profile.Theme != "")
            {
                Page.Theme= Profile.Theme;
            }
        }
    }
}