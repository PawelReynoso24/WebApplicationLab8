<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationLab8._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBoxGrado" runat="server"></asp:TextBox>
        <br />
        <asp:RangeValidator ID="RangeValidatorGrado" runat="server" ControlToValidate="TextBoxGrado" ErrorMessage="RangeValidator" MaximumValue="6" MinimumValue="1" SetFocusOnError="True" Type="Integer">Sólo se permiten números del 1 al 6</asp:RangeValidator>
        <br />
        <br />
        <br />
        <asp:Button ID="ButtonGuardar" runat="server" OnClick="ButtonGuardar_Click" Text="GUARDAR" Width="88px" />
        
    </div>

</asp:Content>
