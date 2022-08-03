<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgretmenGuncelle.aspx.cs" Inherits="YazOkuluProje.OgretmenGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="w-50 mx-auto mt-4">
        <div class="form-group mt-3">
            <strong>
                <asp:Label for="txtId" runat="server" Text="Öğretmen ID:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtId" runat="server" class="form-control mt-1"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
                <asp:Label for="txtAd" runat="server" Text="Öğretmen Ad-Soyad:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtAd" runat="server" class="form-control mt-1"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
                <asp:Label for="txtDers" runat="server" Text="Öğretmen Ders"></asp:Label>
            </strong>
            <asp:DropDownList CssClass="form-control dropdown-toggle mt-1" ID="DropDownList1" runat="server"></asp:DropDownList>
        </div>
        <br />
        <div class="form-group">
            <strong>
                <asp:Label for="txtNumara" runat="server" Text="Öğretmen Numarası:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtNumara" runat="server" class="form-control mt-1"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
                <asp:Label for="txtSifre" runat="server" Text="Şifre:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtSifre" runat="server" class="form-control mt-1"></asp:TextBox>
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
