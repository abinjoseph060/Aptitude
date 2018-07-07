<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Quiz.aspx.cs" Inherits="woq.Quiz" %>

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
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Score :"></asp:Label>
                        <asp:Label ID="score" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="question" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButton ID="a" runat="server" />
                    </td>
                    <td>
                        <asp:RadioButton ID="b" runat="server" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButton ID="c" runat="server" />
                    </td>
                    <td>
                        <asp:RadioButton ID="d" runat="server" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="next" runat="server" Text="Next" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
