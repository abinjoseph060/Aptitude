<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cat.aspx.cs" Inherits="woq.Cat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Choose Category"></asp:Label>
                    </td>
                    <td>:</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Select Category</asp:ListItem>
                            <asp:ListItem>Logical</asp:ListItem>
                            <asp:ListItem>Technical</asp:ListItem>
                            <asp:ListItem>Maths</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Next" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
