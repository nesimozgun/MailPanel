<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
    <asp:ContentPlaceHolder ID="head" runat="server">
    </asp:ContentPlaceHolder>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 250px; width: 300px; margin: auto; background-color: aquamarine;">
            <asp:Panel ID="Panel1" runat="server">
                <table>
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="200px"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" Height="20px" Width="200px"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server" Height="80px" Width="200px"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Button ButtonID="Button1" runat="server" Text="Send" OnClick="Button1_Click"></asp:Button>
                        </td>
                    </tr>
                </table>
            </asp:Panel>




            <asp:ContentPlaceHolder ID="ContentPlaceHolder1" runat="server">
            </asp:ContentPlaceHolder>
        </div>
    </form>
</body>
</html>

