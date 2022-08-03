<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciGuncelle.aspx.cs" Inherits="YazOkuluProje.OgrenciGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="w-50 mx-auto mt-4">
        <div class="form-group mt-3">
            <strong>
                <asp:Label for="txtId" runat="server" Text="Öğrenci ID:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtId" runat="server" class="form-control mt-1" placeholder="Öğrenci ID Giriniz"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
                <asp:Label for="txtAd" runat="server" Text="Öğrenci Adı:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtAd" runat="server" class="form-control mt-1" placeholder="Öğrenci Adı Giriniz"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
                <asp:Label for="txtSoyad" runat="server" Text="Öğrenci Soyadı:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtSoyad" runat="server" class="form-control mt-1" placeholder="Öğrenci Soyadı Giriniz"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
                <asp:Label for="txtNumara" runat="server" Text="Öğrenci Numarası:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtNumara" runat="server" class="form-control mt-1" placeholder="Öğrenci Numarası Giriniz"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
                <asp:Label for="txtMail" runat="server" Text="Email:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtMail" runat="server" class="form-control mt-1" placeholder="Email Giriniz"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
                <asp:Label for="txtSifre" runat="server" Text="Şifre:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtSifre" runat="server" class="form-control mt-1" placeholder="Şifre Giriniz"></asp:TextBox>
        </div>
        <br />
        <strong>
            <asp:Button ID="update" runat="server" Text="Güncelle" class="btn btn-success" Style="font-weight: bold" OnClick="update_Click" />
        </strong>
        <br />
        <br />
        <asp:Label CssClass="text-danger" ID="Label1" runat="server" Visible="False"></asp:Label>
    </div>
</asp:Content>
