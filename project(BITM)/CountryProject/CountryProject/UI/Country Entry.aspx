<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Country Entry.aspx.cs" Inherits="CountryProject.UI.Country_Entry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 225px;
        }
        .auto-style3 {
            width: 224px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Counrty Entry&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Name&nbsp;&nbsp; &nbsp;</td>
                <td>
                    <asp:TextBox ID="CountryTextBox" runat="server"></asp:TextBox>
                &nbsp;
                    <asp:Label ID="CountryNameLabel" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; About &nbsp;</td>
                <td>
                    <asp:TextBox ID="AboutTextBox" runat="server"></asp:TextBox>
                &nbsp;
                    <asp:Label ID="CountryAboutLabel" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                <td>&nbsp; &nbsp;<asp:Button ID="SaveButton" runat="server" Text="Save" OnClick="SaveButton_Click" />
&nbsp;&nbsp;
                    <asp:Button ID="CancleButton" runat="server" Text="Cancle" OnClick="CancleButton_Click" />
                &nbsp;&nbsp;
                    <asp:Label ID="MessageLabel" runat="server" Text="Show Message"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:GridView ID="CountryGridView" runat="server" AutoGenerateColumns="False">

                        <Columns>
        
            <asp:TemplateField HeaderText="SL#">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("CountryName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="About">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("CountryAbout") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
           
           
        </Columns>

                    </asp:GridView>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
