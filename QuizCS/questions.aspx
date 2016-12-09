<%@ Page Language="C#" AutoEventWireup="true" CodeFile="questions.aspx.cs" Inherits="questions" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Quiz - Questions</title>
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
                    <asp:Image ID="imgQuiz" SkinID="quiz" runat="server" /></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="h1">Current Test:&nbsp;
                    <asp:Label ID="currentTestLabel" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Image ID="imgLine1" SkinID="line" runat="server" /></td>
            </tr>                        
            <tr>
                <td>
                    <asp:DetailsView ID="questionDetails" runat="server" Height="50px" Width="550px" AutoGenerateRows="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" CssClass="generaltext" />
                        <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" CssClass="boldtext" Width="80px" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <Fields>
                            <asp:BoundField DataField="Title" HeaderText="Question:" SortExpression="Title" />
                            <asp:BoundField DataField="Answer1" HeaderText="Answer 1:" SortExpression="Answer1" />
                            <asp:BoundField DataField="Answer2" HeaderText="Answer 2:" SortExpression="Answer2" />
                            <asp:BoundField DataField="Answer3" HeaderText="Answer 3:" SortExpression="Answer3" />
                            <asp:BoundField DataField="Answer4" HeaderText="Answer 4:" SortExpression="Answer4" />
                        </Fields>
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" CssClass="generaltext" />
                    </asp:DetailsView>
                    &nbsp;
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [QuestionID], [Title], [Answer1], [Answer2], [Answer3], [Answer4], [CorrectAnswer], [QuestionOrder] FROM [Question] WHERE ([QuizID] = @QuizID) ORDER BY [QuestionOrder]">
                        <SelectParameters>
                            <asp:SessionParameter SessionField="QuizID" Type="Int32" Name="QuizID" DefaultValue="0" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td>&nbsp;
                </td>
            </tr>
            <tr>
                <td class="boldtext">
                    Your Answer:&nbsp;
                <asp:DropDownList ID="answerDropDownList" runat="server">
                            <asp:ListItem Value="1">Answer 1</asp:ListItem>
                            <asp:ListItem Value="2">Answer 2</asp:ListItem>
                            <asp:ListItem Value="3">Answer 3</asp:ListItem>
                            <asp:ListItem Value="4">Answer 4</asp:ListItem>
                        </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Button ID="nextButton" runat="server" OnClick="nextButton_Click" Text="Next" />
                </td>
            </tr>                                    
        </table>
    </form>
</body>
</html>
