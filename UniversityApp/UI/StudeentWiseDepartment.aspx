<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudeentWiseDepartment.aspx.cs" Inherits="UniversityApp.UI.StudeentWiseDepartment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" Text="Show" />
        <br />
        <asp:GridView ID="studentWiseDepartmentGridView" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
