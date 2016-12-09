<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" Theme="Silver" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Quiz - Welcome</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <table width="560" align="center">
            <tr>
                <td width="100%" align="right">
                    <asp:LoginName ID="LoginName1" runat="server" CssClass="boldtext" FormatString="Welcome back {0}!  | " />
                    <asp:LoginStatus ID="LoginStatus1" runat="server" CssClass="boldtext" LoginText="" />
                </td>
            </tr>
        </table>    
        <asp:LoginView ID="LoginView1" runat="server">
            <AnonymousTemplate>
                <table width="560" align="center">
                    <tr>
                        <td width="100%">
                            <asp:Image ID="imgWelcome" runat="server" SkinID="welcome" />
                            </td>
                    </tr>
                    <tr>
                        <td width="100%">&nbsp;</td>
                    </tr>                      
                    <tr>
                        <td width="100%" class="h1">Login</td>
                    </tr>
                    <tr>
                        <td width="100%">
                            <asp:Image ID="imgLine1" SkinID="line" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td width="100%">
                            <asp:Login ID="Login1" runat="server" TitleText="" PasswordRecoveryText="Forgot your password?" PasswordRecoveryUrl="~/recoverpassword.aspx">
                                <FailureTextStyle CssClass="incorrect" />
                                <CheckBoxStyle CssClass="login" />
                                <ValidatorTextStyle CssClass="incorrect" />
                                <LabelStyle CssClass="login" />
                            </asp:Login>
                        </td>
                    </tr> 
                    <tr>
                        <td width="100%" class="h1">New User?  Please Register</td>
                    </tr>
                    <tr>
                        <td width="100%">
                        <asp:Image ID="imgLine2" SkinID="line" runat="server" />
                        </td>
                    </tr>                    
                    <tr>
                        <td width="100%">
                            <asp:CreateUserWizard ID="CreateUserWizard1" runat="server">
                                <WizardSteps>
                                    <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server" Title="">
                                    </asp:CreateUserWizardStep>
                                    <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
                                    </asp:CompleteWizardStep>
                                </WizardSteps>
                                <ValidatorTextStyle CssClass="incorrect" />
                                <LabelStyle CssClass="login" />
                                <ErrorMessageStyle CssClass="incorrect" />
                            </asp:CreateUserWizard>                        
                        </td>
                    </tr>                                                           
                </table>
            </AnonymousTemplate>
            <LoggedInTemplate>
                <table width="560" align="center">
                    <tr>
                        <td width="100%">
                            <asp:Image ID="imgMainMenu" SkinID="mainmenu" runat="server" />
                            </td>
                    </tr>
                    <tr>
                        <td width="100%">&nbsp;</td>
                    </tr>                    
                    <tr>
                       <td class="h1">Available Tests</td> 
                    </tr>        
                    <tr>
                        <td width="100%">
                        <asp:Image ID="imgLine3" SkinID="line" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td width="100%">
                            <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource2">
                                <ItemTemplate>
                                    <asp:HyperLink
                                            ID="HyperLink1" runat="server" NavigateUrl='<%# "start.aspx?testid=" + Eval("QuizID") %>'
                                            Text='<%# Eval("Title") %>'></asp:HyperLink><br />
                                    &nbsp;<asp:Label
                                        ID="DescriptionLabel" runat="server" CssClass="generaltext" Text='<%# Eval("Description") %>'></asp:Label>&nbsp;<br />
                                    <br />
                                </ItemTemplate>
                            </asp:DataList>
                            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                                SelectCommand="SELECT [Title], [Description], [QuizID] FROM [Quiz]"></asp:SqlDataSource>
                        </td>
                    </tr>                                         
                    <tr>
                        <td width="100%">&nbsp;</td>
                    </tr>                      
                    <tr>
                        <td width="100%" class="h1">Test Result History</td>
                    </tr>
                    <tr>
                        <td width="100%">
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Width="555px">
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" CssClass="generaltext" />
                                <Columns>
                                    <asp:BoundField DataField="Title" HeaderText="Quiz" SortExpression="Title" >
                                        <HeaderStyle HorizontalAlign="Left" />
                                        <ItemStyle HorizontalAlign="Left" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="DateTimeComplete" DataFormatString="{0:d}" HeaderText="Completed"
                                        SortExpression="DateTimeComplete" >
                                        <FooterStyle Width="150px" />
                                        <HeaderStyle Width="150px" />
                                        <ItemStyle HorizontalAlign="Center" Width="150px" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Score" HeaderText="Score" SortExpression="Score" >
                                        <FooterStyle Width="50px" />
                                        <HeaderStyle Width="50px" />
                                        <ItemStyle HorizontalAlign="Center" Width="50px" />
                                    </asp:BoundField>
                                </Columns>
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle Font-Bold="True" CssClass="complete" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                                SelectCommand="SELECT Quiz.Title, UserQuiz.DateTimeComplete, UserQuiz.Score FROM UserQuiz INNER JOIN Quiz ON UserQuiz.QuizID = Quiz.QuizID WHERE (UserQuiz.UserName = @UserName) ORDER BY UserQuiz.DateTimeComplete">
                                <SelectParameters>
                                    <asp:SessionParameter Name="UserName" SessionField="UserName" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                        </td>
                    </tr>                                         
                    <tr>
                        <td width="100%">&nbsp;</td>
                    </tr>                                       
                    <tr>
                        <td width="100%" class="h1">Change Password</td>
                    </tr>
                    <tr>
                        <td width="100%">
                        <asp:Image ID="imgLine4" SkinID="line" runat="server" />
                        </td>
                    </tr>                    
                    <tr>
                        <td width="100%">
                            <asp:ChangePassword ID="ChangePassword1" runat="server" ChangePasswordTitleText="">
                                <LabelStyle CssClass="login" />
                                <FailureTextStyle CssClass="incorrect" />
                                <SuccessTextStyle CssClass="correct" />
                                <ValidatorTextStyle CssClass="incorrect" />
                            </asp:ChangePassword>
                        </td>
                    </tr>  
                    <tr>
                        <td width="100%">&nbsp;</td>
                    </tr>                                       
                    <tr>
                        <td width="100%" class="h1">Theme Preference</td>
                    </tr>
                    <tr>
                        <td width="100%">
                        <asp:Image ID="imgLine5" SkinID="line" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td width="100%">
                            <div class="login">Select Theme:</div> <a href="default.aspx?theme=silver">Silver</a>&nbsp;|&nbsp;<a href="default.aspx?theme=red">Red</a>
                        </td>
                    </tr>                                                          
                </table>
            </LoggedInTemplate>
        </asp:LoginView>
    </form>
</body>
</html>