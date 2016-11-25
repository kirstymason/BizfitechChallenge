<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="BizfitechChallenge.ViewProfile" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  <link rel="stylesheet" href="//code.jquery.com/ui/1.12.0/themes/base/jquery-ui.css">

    <div class="jumbotron"> 

    <h2><asp:Label ID="lblTitle" runat="server"></asp:Label></h2>
    <br />

    <p>
        <b>First Name: </b>
        <asp:Label ID="lblFirstName" runat="server"></asp:Label>
        <br />
    </p>  
           
    <p>
        <b>Surname: </b> 
        <asp:Label ID="lblSurname" runat="server"></asp:Label>
        <br />
    </p>  
        
    <p>                
        <b>Email: </b>
        <asp:Label ID="lblEmail" runat="server"></asp:Label>        
        <br />
    </p>  
    <p>
        <b>Brief Bio: </b>
        <asp:Label ID="lblBio" runat="server"></asp:Label>
        <br />
    </p>  
        
    <p>                
        <b>Twitter Ref: </b>
        <asp:Label ID="lblTwitterRef" runat="server"></asp:Label>        
        <br />
    </p>
        <asp:PlaceHolder runat="server" ID="panelForJS" >
             <div class="social-feed-container">
           <div id="placeholder">Loading tweets. Please wait... <img src="Content/ajax-loader.gif" /> </div>
        </div>
        </asp:PlaceHolder>
       

    </div>
    <asp:Literal runat="server" runat="server" id="javascriptBlock"></asp:Literal>
</asp:Content>