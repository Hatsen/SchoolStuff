<%@ Page Language="C#" AutoEventWireup="true" CodeFile="start.aspx.cs" Inherits="start" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Quiz - Start</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <table width="560" align="center">
            <tr>
                <td width="100%" align="right">
                    <asp:LoginName ID="LoginName1" runat="server" CssClass="boldtext" FormatString="Currently logged in as: {0}" />
                </td>
            </tr>
        </table>     
        <table width="560" align="center">
            <tr>
                <td>
                    <asp:Image ID="imgQuizStartingNow" SkinID="quizstartingnow" runat="server" /></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="h1">Ready to Start the Test
                </td>
            </tr>
            <tr>
                <td><asp:Image ID="imgLine1" SkinID="line" runat="server" /></td>
            </tr>
            <tr>
                <td class="generaltext">
                    You are about to take the quiz.&nbsp; The quiz contains multiple choice style questions.&nbsp;
                    Complete each question from the drop down list box then select the Next button.&nbsp;
                    You will not be able to go back and change your answers once you select the Next
                    button, so choose carefully.<br />
                    <br />
                    When you are ready to begin, select the Start button below.</td>
            </tr>                                    
            <tr>
                <td align="right">
                    <asp:Button ID="startButton" runat="server" Text="Start" OnClick="startButton_Click" /></td>
            </tr>
        </table>
    </form>
</body>
</html>
