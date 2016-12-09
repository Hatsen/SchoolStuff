<%@ Page Language="C#" AutoEventWireup="true" CodeFile="recoverpassword.aspx.cs" Inherits="recoverpassword" Theme="Silver" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Quiz - Recover Password</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <table width="560" align="center">
            <tr>
                <td width="100%" align="right" class="boldtext"><a href="Default.aspx"><font color="red">Login</font></a>
                </td>
            </tr>

        </table>    
        <table width="560" align="center">
            <tr>
                <td>
                    <asp:Image ID="imgRecoverPassword" SkinID="recoverpassword" runat="server" /></td>
            </tr>
            <tr>
                <td>
                    <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" UserNameTitleText="">
                        <InstructionTextStyle CssClass="generaltext" />
                        <SuccessTextStyle CssClass="correct" />
                        <ValidatorTextStyle CssClass="incorrect" />
                        <LabelStyle CssClass="login" />
                        <TitleTextStyle CssClass="boldtext" />
                        <FailureTextStyle CssClass="incorrect" />
                    </asp:PasswordRecovery>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
