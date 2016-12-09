using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for Answer
/// </summary>
public class Answer
{
	public Answer()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    private string _questionID;
    private string _correctAnswer;
    private string _userAnswer;
    private string _result;

    public string QuestionID
    {
        get { return _questionID; }
        set { _questionID = value; }
    }

    public string CorrectAnswer
    {
        get { return _correctAnswer; }
        set { _correctAnswer = value; }
    }

    public string UserAnswer
    {
        get { return _userAnswer; }
        set { _userAnswer = value; }
    }

    public ResultValue Result
    {
        get
        {
            if (_userAnswer == _correctAnswer)
            {
                return ResultValue.Correct; 
            }
            else
            {
                return ResultValue.Incorrect;
            }
        }
    }

    public enum ResultValue { Correct, Incorrect }


}
