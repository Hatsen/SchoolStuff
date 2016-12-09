<%@ Page Language="C#" AutoEventWireup="true" CodeFile="results.aspx.cs" Inherits="results" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Quiz - Results</title>
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
                    <asp:Image ID="imgResults" SkinID="results" runat="server" /></td>
            </tr>
            <tr>
                <td>&nbsp;<asp:Label ID="errorLabel" runat="server" CssClass="errormessage"></asp:Label></td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="resultGrid" runat="server" DataKeyNames="QuestionID" SelectedIndex="0" 
                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="resultGrid_SelectedIndexChanged" Width="555px">
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" CssClass="generaltext" HorizontalAlign="Center" />
                        <Columns>
                            <asp:BoundField DataField="QuestionID" HeaderText="Question" />
                            <asp:BoundField DataField="CorrectAnswer" HeaderText="Correct Answer" />
                            <asp:BoundField DataField="UserAnswer" HeaderText="Your Answer" />
                            <asp:BoundField DataField="Result" HeaderText="Result" />
                        </Columns>
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" CssClass="boldtext" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    </asp:GridView>

                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                        SelectCommand="SELECT [Title], [Answer1], [Answer2], [Answer3], [QuestionID], [QuestionOrder], [Answer4], [CorrectAnswer], [AnswerExplanation], [QuizID] FROM [Question] WHERE ([QuizID] = @QuizID) ORDER BY [QuestionOrder]">
                        <SelectParameters>
                            <asp:SessionParameter Name="QuizID" SessionField="QuizID" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>                
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DetailsView ID="answerDetails" runat="server" CellPadding="4" ForeColor="#333333"
                        GridLines="None" Height="45px" Width="552px" DataSourceID="SqlDataSource1" AutoGenerateRows="False" >
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" CssClass="generaltext" />
                        <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" CssClass="boldtext" Width="100px" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#999999" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Fields>
                            <asp:BoundField DataField="QuestionOrder" HeaderText="Question No.:" />
                            <asp:BoundField DataField="Title" HeaderText="Question:" />
                            <asp:BoundField DataField="Answer1" HeaderText="Answer 1:" />
                            <asp:BoundField DataField="Answer2" HeaderText="Answer 2:" />
                            <asp:BoundField DataField="Answer3" HeaderText="Answer 3:" />
                            <asp:BoundField DataField="Answer4" HeaderText="Answer 4:" />
                            <asp:TemplateField></asp:TemplateField>
                            <asp:BoundField DataField="CorrectAnswer" HeaderText="Correct Answer:" />
                            <asp:BoundField DataField="AnswerExplanation" HeaderText="Explanation:" />
                        </Fields>
                    </asp:DetailsView>                
                </td>
            </tr>
            <tr>
                <td><a href="default.aspx">Return to Main Menu</a></td>
            </tr>                                    
        </table>

    </form>
</body>
</html>
