<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Dersler.aspx.cs" Inherits="YazOkuluProje.Dersler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="mx-5 mt-3">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ders"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control mt-1"></asp:DropDownList>
        </div>
        <div class="mt-5">
            <asp:Label ID="Label2" runat="server" Text="Öğrenci ID"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control mt-1"></asp:TextBox>
        </div>
        <br />
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" CssClass="btn btn-success" Text="Ders Talep Oluştur" OnClick="Button1_Click" />
        </div>
    </form>
</asp:Content>
