<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateStudentUI.aspx.cs" Inherits="UniversityApp.UI.UpdateStudentUI" %>

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
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Phone No."></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="phoneNoTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td>
                
            </td>
            <td>
                <asp:Button ID="updateButton" runat="server" Text="Update" OnClick="updateButton_Click" />
            </td>
        </tr>
    </table>
    </div>
        <asp:Label ID="messageLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
