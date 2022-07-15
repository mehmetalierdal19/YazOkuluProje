<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="YazOkuluProje.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server" >
        <div class="form-group">
            <strong>
            <asp:Label for="txtAd" runat="server" Text="Öğrenci Adı:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtAd" runat="server" class="form-control" placeholder="Öğrenci Adı Giriniz"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
            <asp:Label for="txtSoyad" runat="server" Text="Öğrenci Soyadı:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtSoyad" runat="server" class="form-control" placeholder="Öğrenci Soyadı Giriniz"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
            <asp:Label for="txtNumara" runat="server" Text="Öğrenci Numarası:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtNumara" runat="server" class="form-control" placeholder="Öğrenci Numarası Giriniz"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
            <asp:Label for="txtMail" runat="server" Text="Email:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtMail" runat="server" class="form-control" placeholder="Email Giriniz"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
            <asp:Label for="txtSifre" runat="server" Text="Şifre:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtSifre" runat="server" class="form-control" placeholder="Şifre Giriniz"></asp:TextBox>
        </div>
        <br />
        <strong>
        <asp:Button ID="submit" runat="server" Text="Kaydet" class="btn btn-primary" OnClick="submit_Click" style="font-weight: bold" />
        </strong>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
    </form>
</asp:Content>
