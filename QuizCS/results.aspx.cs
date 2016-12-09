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

public partial class results : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ArrayList al = (ArrayList)Session["AnswerList"];

        if (al == null)
        {
            Response.Redirect("default.aspx");
        }


        try
        {
            resultGrid.DataSource = al;
            resultGrid.DataBind();

            // Save the results into the database.
            if (IsPostBack == false)
            {
                // Calculate score
                double questions = al.Count;
                double correct = 0.0;

                for (int i = 0; i < al.Count; i++)
                {
                    Answer a = (Answer)al[i];
                    if (a.Result == Answer.ResultValue.Correct)
                        correct++;
                }

                double score = (correct / questions) * 100;

                SqlDataSource userQuizDataSource = new SqlDataSource();
                userQuizDataSource.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                userQuizDataSource.InsertCommand = "INSERT INTO [UserQuiz] ([QuizID], [DateTimeComplete], [Score], [UserName]) VALUES (@QuizID, @DateTimeComplete, @Score, @UserName)";

                userQuizDataSource.InsertParameters.Add("QuizID", Session["QuizID"].ToString());
                userQuizDataSource.InsertParameters.Add("DateTimeComplete", DateTime.Now.ToString());
                userQuizDataSource.InsertParameters.Add("Score", score.ToString());
                userQuizDataSource.InsertParameters.Add("UserName", User.Identity.Name);

                int rowsAffected = userQuizDataSource.Insert();
                if (rowsAffected == 0)
                {
                    // Let's just notify that the insertion didn't
                    // work, but let' s continue on ...
                    errorLabel.Text = "There was a problem saving your quiz results into our database.  Therefore, the results from this quiz will not be displayed on the list on the main menu.";
                }
            }
        }
        catch (Exception ex)
        {
            // Typically I like to minimize the amount of
            // code I wrap in a try/catch statement.  However
            // honestly, I'm feeling that there are a couple
            // of potential problems that could arise in my
            // implementation of the code and I want there to
            // be *some* thought about what should happen here
            // if the worst-case-scenario actually happens.

            // Actually, what I'm about to say mimics many of
            // the comments I made in the questions.aspx.cs 
            // file.

            // I have two potential problems ... 1st, if the
            // web server is reset while my user is on the last
            // quiz question ready to click the "Finish" button
            // then all his answers will be lost.  2nd, if the
            // database connection is lost (or other database
            // malladies occur) then all the user's answers will
            // be lost. Yes, yes, yes ... I could construct
            // some elaborate schemes to ensure this doesn't
            // happen, but that would require I back-up several
            // steps and re-do some things about the application.
            // Since this is simply a tutorial application 
            // I'll just bring these potential issues to your
            // attention and move on.

            // This does remind me of a great programmer quote:
            // "Nine tenths of programming is handling the exception,
            // not the rule."  I fear too often in my own work
            // I spend 9/10ths on the rule and not the exception.

            // To make a long story short, I'm going to take
            // the easy way out and just redirect the user to
            // the default.aspx page if there is any trouble.
            // Yes, makes me feel a little dirty, but due to 
            // time constraints I must move on...

            Response.Redirect("default.aspx");
           
        }
    }

    protected void resultGrid_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlDataSource1.FilterExpression = "QuestionOrder=" + resultGrid.SelectedValue;
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
