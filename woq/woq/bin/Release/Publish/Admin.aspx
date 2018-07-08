<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="woq.Admin" %>

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
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Add Questions :"></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="add_q" runat="server" OnClick="add_q_Click" Text="Add" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Select quiz category :"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="q_cat" runat="server" OnSelectedIndexChanged="q_cat_SelectedIndexChanged">
                            <asp:ListItem Value="Select Category">Select Category</asp:ListItem>
                            <asp:ListItem>Logical</asp:ListItem>
                            <asp:ListItem>Tehnical</asp:ListItem>
                            <asp:ListItem>Maths</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Button ID="Set" runat="server" OnClick="Set_Click" Text="Set" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Select date :"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="date" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Exit" runat="server" OnClick="Exit_Click" Text="Exit" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
