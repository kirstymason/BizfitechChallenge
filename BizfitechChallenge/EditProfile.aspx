<%@ Page Language="C#"  MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="BizfitechChallenge.EditProfile" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  <link rel="stylesheet" href="//code.jquery.com/ui/1.12.0/themes/base/jquery-ui.css">

    <div class="jumbotron"> 

    <h2>Edit Profile</h2>
    <br />
    <p>
        Enter First Name: 
        <asp:TextBox ID="tbFirstName"  runat="server"></asp:TextBox> <asp:Label ID="lblFirstName" Style="color: red;" runat="server"></asp:Label>
        <br />
    </p>  
           
    <p>
        Enter Surname: 
        <asp:TextBox ID="tbSurname" runat="server"></asp:TextBox> <asp:Label ID="lblSurname" Style="color: red;" runat="server"></asp:Label>
        <br />
    </p>  
        
    <p>                
        Enter Email:
        <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox> <asp:Label ID="lblEmail" Style="color: red;" runat="server"></asp:Label>        
        <br />
    </p>  
    <p>
        Enter Brief Bio: 
        <asp:TextBox TextMode="MultiLine" Columns="50" Rows="10" ID="tbBio" runat="server"></asp:TextBox> <asp:Label ID="lblBio" Style="color: red;" runat="server"></asp:Label>
        <br />
    </p>  
        
    <p>                
        Enter Twitter Ref:
        <asp:TextBox ID="tbTwitterRef" runat="server"></asp:TextBox> <asp:Label ID="lblTwitterRef" Style="color: red;" runat="server"></asp:Label>        
        <br />
    </p>   

        <asp:Button ID="EditAccountButton" runat="server" class="btn btn-primary btn-md" Text="Edit Profile &raquo;"  onclick="EditAccountButton_Click" />
    <p>
        <br />
         <asp:Label ID="EditAccountResults" runat="server"></asp:Label>
    </p>    
   </div>

</asp:Content>