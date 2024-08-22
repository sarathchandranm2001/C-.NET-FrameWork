<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="web3aspweb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div>
            <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate"></asp:Login>
        </div>
        <div>
            <asp:LoginView ID="LoginView1" runat="server"></asp:LoginView>
        </div>
    </main>

</asp:Content>
