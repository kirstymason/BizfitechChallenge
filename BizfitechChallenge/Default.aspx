<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BizfitechChallenge._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">

        <%--<p><asp:Button runat="server" ID = "btnLogout" OnClick="btnLogout_Click" style="float: right;" class="btn btn-warning btn-md" Text="Logout &crarr;" /></p>--%>

        <h2><b>User menu</b></h2>

        <br />
        <p>Don't have a profile? 
        <asp:HyperLink runat="server" ID="NewProfilelink" class="btn btn-primary btn-md" navigateUrl="~/CreateNewUser.aspx" Text="Create a New User Profile" /></p>
        <br />
        <p>Search For a Profile</p>
        <p>
        First Name: <asp:TextBox ID="tbSearchFirstName" runat="server"></asp:TextBox>
        Surname: <asp:TextBox ID="tbSearchSurname" runat="server"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" onclick="btnSearch_Click"  class="btn btn-primary btn-md" Text="Go &raquo;"  />
            <br />
        </p>
        <br/>
        <asp:Repeater runat="server" ID="ViewResults"  Visible="true">
                <HeaderTemplate>
                    <table class="table table-bordered" style="background-color: #66a3ff;">
                        <tr>
                            <th>
                                <asp:Label ID="lblFirstName" runat="server" Style="color: white;">First Name</asp:Label></</th>
                            <th>
                                <asp:Label ID="lblSurname" runat="server" Style="color: white;">Surname</asp:Label></</th>
                            <th>
                                <asp:Label ID="lblEmail" runat="server" Style="color: white;">Email</asp:Label></</th>
                            <th>
                                <asp:Label ID="lblGo" runat="server" Style="color: white;"></asp:Label></</th>
                            <th>
                                <asp:Label ID="lblEdit" runat="server" Style="color: white;"></asp:Label></</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td bgcolor="white">
                            <asp:Label runat="server" ID="lblFirstName1"
                                Text='<%# DataBinder.Eval(Container.DataItem, "FirstName") %>' />
                        </td>
                        <td bgcolor="white">
                            <asp:Label runat="server" ID="lblSurname1"
                                Text='<%# DataBinder.Eval(Container.DataItem, "Surname") %>' />
                        </td>
                        <td bgcolor="white">
                            <asp:Label runat="server" ID="lblEmail1"
                                Text='<%# DataBinder.Eval(Container.DataItem, "Email") %>' />
                        </td>
                        <td bgcolor="white">
                            <asp:HyperLink ID="hypGo" Text="View" NavigateUrl='<%# "ViewProfile.aspx?ID=" + DataBinder.Eval(Container.DataItem, "ID") %>'  runat="server"></asp:HyperLink>
                        </td>
                        <td bgcolor="white">
                            <asp:HyperLink ID="HyperLink1" Text="Edit" NavigateUrl='<%# "EditProfile.aspx?ID=" + DataBinder.Eval(Container.DataItem, "ID") %>'  runat="server"></asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
                <AlternatingItemTemplate>
                    <tr>
                        <td bgcolor="f2f2f2">
                            <asp:Label runat="server" ID="lblFirstName1"
                                Text='<%# DataBinder.Eval(Container.DataItem, "FirstName") %>' />
                        </td>
                        <td bgcolor="f2f2f2">
                            <asp:Label runat="server" ID="lblSurname1"
                                Text='<%# DataBinder.Eval(Container.DataItem, "Surname") %>' />
                        </td>
                        <td bgcolor="f2f2f2">
                            <asp:Label runat="server" ID="lblEmail1"
                                Text='<%# DataBinder.Eval(Container.DataItem, "Email") %>' />
                        </td>
                        <td bgcolor="f2f2f2">
                            <asp:HyperLink ID="hypGo" Text="View" NavigateUrl='<%# "ViewProfile.aspx?ID=" + DataBinder.Eval(Container.DataItem, "ID") %>' runat="server"></asp:HyperLink>
                        </td>
                        <td bgcolor="f2f2f2">
                            <asp:HyperLink ID="HyperLink2" Text="Edit" NavigateUrl='<%# "EditProfile.aspx?ID=" + DataBinder.Eval(Container.DataItem, "ID") %>' runat="server"></asp:HyperLink>
                        </td>
                    </tr>
                </AlternatingItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>

    </div>

</asp:Content>





