using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class start : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // This is really the only reason I've added a 
        // start.aspx page ... so I could initialize the
        // values in the Session.  I probably could have
        // done this in the questions.aspx page, but its already
        // a complicated page, and you will probably want
        // to put some introductory comments here anyway.

        ArrayList al = new ArrayList();
        Session.Add("AnswerList", al);

        if (Request.QueryString["testid"] != null)
        {
            int testID = int.Parse(Request.QueryString["testid"]);
            Session.Add("QuizID", testID);
        }
        else
        {
            Response.Redirect("default.aspx");
        }

    }
    protected void startButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("questions.aspx");
    }

    void Page_PreInit(object sender, EventArgs e)
    {
        if (Profile.IsAnonymous == false)
        {
            if (Profile.Theme != "")
            {
                Page.Theme = Profile.Theme;
            }
        }
        else
        {
            Response.Redirect("default.aspx");
        }
    }

}
