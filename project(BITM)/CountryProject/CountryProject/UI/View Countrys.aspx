<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View Countrys.aspx.cs" Inherits="CountryProject.UI.View_Countrys" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 149px;
        }
        .auto-style3 {
            width: 169px;
        }
        .auto-style4 {
            width: 167px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">View Country</td>
                <td colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td colspan="3">search criteria</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Country&nbsp;name</td>
                <td class="auto-style4">
                    <asp:TextBox ID="viewCountrynameTextBox" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="viewSearchButton" runat="server" Text="Search" OnClick="viewSearchButton_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="messageViewCountry" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td colspan="3">
                    <asp:GridView ID="viewCountryGridView" runat="server" AutoGenerateColumns="False">

                         <Columns>
        
            <asp:TemplateField HeaderText="SL#">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("ViewCountryid") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("ViewCountryName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="About">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("ViewCountryAbout") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
              <asp:TemplateField HeaderText="No. OF Citys">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("viewCountryNoOfCitys") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
              <asp:TemplateField HeaderText="No. OF CityDwellers">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("viewCountryNoOfCityDrewlers") %>'></asp:Label>
                </ItemTemplate>
              </asp:TemplateField>
           
           
        </Columns>


                    </asp:GridView>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
