<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdminEkle.aspx.cs" Inherits="YazOkuluProje.AdminEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="w-50 mx-auto mt-4">
        <div class="form-group">
            <strong>
                <asp:Label for="txtAd" runat="server" Text="Kullanıcı Adı:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtAd" runat="server" class="form-control mt-1"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
                <asp:Label for="txtSifre" runat="server" Text="Şifre:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtSifre" runat="server" class="form-control mt-1"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="update" runat="server" Text="Kaydet" class="btn btn-success" Style="font-weight: bold" OnClick="update_Click" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label" CssClass="text-danger" Visible="false"></asp:Label>
    </div>
</asp:Content>
