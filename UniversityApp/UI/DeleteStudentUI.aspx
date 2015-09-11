<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteStudentUI.aspx.cs" Inherits="UniversityApp.UI.DeleteStudentUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Reg. No."></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="regNoTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                
            </td>
            <td>
                <asp:Button ID="deleteButton" runat="server" Text="Delete" OnClick="deleteButton_Click" />
            </td>
        </tr>
    </table>
    </div>
        <asp:Label ID="messageLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
