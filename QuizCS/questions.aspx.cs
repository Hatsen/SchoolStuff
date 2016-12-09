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

public partial class questions : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        questionDetails.DataBind();
    }

    protected void nextButton_Click(object sender, EventArgs e)
    {
        try
        {
            // Save off previous answers
            System.Data.DataRowView dr = (System.Data.DataRowView)questionDetails.DataItem;

            // Create Answer object to save values
            Answer a = new Answer();
            a.QuestionID = dr["QuestionOrder"].ToString();
            a.CorrectAnswer = dr["CorrectAnswer"].ToString();
            a.UserAnswer = answerDropDownList.SelectedValue.ToString();

            ArrayList al = (ArrayList)Session["AnswerList"];

            al.Add(a);

            Session.Add("AnswerList", al);

        }
        catch (Exception ex)
        {
            // Sometimes the most difficult decisions involve 
            // trying to figure out what should you as a developer
            // should do for your user's experience as bad 
            // things happen within your application.
            // This requires a little empathy ... I recommend a
            // quick coffee break while you imagine what
            // *you* would want to happen if you were half-way
            // through the quiz and something "screwed-up" on
            // the server (server reset, etc.)

            // In my 'try' statement I have two potential problems.
            // 1st, what if the app can't pull the questions 
            // from the database for some reason?  2nd, what if
            // the web server can't retrieve the current user's
            // session data?  In both cases, I could construct 
            // some elaborate work arounds to safeguard against this
            // from ever happening, or if I really thought
            // this was going to be a huge issue, I could back
            // up and re-think how I'm persisting the user's
            // answers during the quiz.  However, since my goal
            // here is to keep this example application simple,
            // I'm merely going to return the user to the 
            // default.aspx page.  Please keep in mind that I'm
            // not satisfied with this because I think it "surprises"
            // and potentially diminishes the quality of the user's
            // experience with my application, however I have some 
            // time constraints in this tutorial.

            Response.Redirect("default.aspx");
        }


        if (questionDetails.PageIndex == questionDetails.PageCount - 1)
        {
            // Go to evaluate answers
            Response.Redirect("results.aspx");
        }
        else 
        {
            questionDetails.PageIndex++;
        }

        if (questionDetails.PageIndex == questionDetails.PageCount - 1)
        {
            nextButton.Text = "Finished";
        }

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
