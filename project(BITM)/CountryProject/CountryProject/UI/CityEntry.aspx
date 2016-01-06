<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityEntry.aspx.cs" Inherits="CountryProject.UI.City_Entry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 228px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">City Entry</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Name&nbsp;</td>
                <td>
                    &nbsp; &nbsp;<asp:TextBox ID="CityNameTextBox" runat="server"></asp:TextBox>
                &nbsp;&nbsp;
                    <asp:Label ID="cityNameLevel" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; About&nbsp;</td>
                <td>&nbsp;&nbsp;
                    <asp:TextBox ID="AboutTextBox" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:Label ID="CityAboutLabel" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; No of dewllers&nbsp;</td>
                <td>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="NoOfDrewlerTextBox" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:Label ID="NoOfDrawlerLabel" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Weather&nbsp;</td>
                <td>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="WeatherTextBox" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:Label ID="WeatherLabel" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Location&nbsp;</td>
                <td>
                    &nbsp; &nbsp;<asp:TextBox ID="LocationTextBox" runat="server"></asp:TextBox>
                &nbsp;&nbsp;
                    <asp:Label ID="LocationLabel" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Country&nbsp;</td>
                <td>
&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="CountryDropDownList" runat="server">
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="CountryDropDownLabel" runat="server" Text=""></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="SaveButton" runat="server" Text="Save" Height="26px" OnClick="SaveButton_Click" />
&nbsp;&nbsp;
                    <asp:Button ID="CancleButton" runat="server" Text="Cancle" OnClick="CancleButton_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Label ID="messageLabel" runat="server" Text="Show Here"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:GridView ID="CityGridView" runat="server" AutoGenerateColumns="False">

         <Columns>
        
            <asp:TemplateField HeaderText="SL#">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("cityId") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("CityName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="No. of Dwellers">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("NoOfDwellers") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
              <asp:TemplateField HeaderText="Country">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%#Eval("Country") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
           
           
        </Columns>


                    </asp:GridView>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
    <p>
&nbsp;&nbsp;
    </p>
</body>
</html>
