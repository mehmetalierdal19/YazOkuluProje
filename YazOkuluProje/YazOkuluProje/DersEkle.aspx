<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DersEkle.aspx.cs" Inherits="YazOkuluProje.DersEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="w-50 mx-auto mt-4">
        <div class="form-group">
            <strong>
                <asp:Label for="txtAd" runat="server" Text="Ders Ad:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtAd" runat="server" class="form-control mt-1"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
                <asp:Label for="txtMin" runat="server" Text="Ders Minimum Kontenjan:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtMin" runat="server" CssClass="form-control mt-1"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
                <asp:Label for="txtMax" runat="server" Text="Ders Maksimum Kontenjan:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtMax" runat="server" class="form-control mt-1"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
                <asp:Label for="txtBakiye" runat="server" Text="Ders Bakiye(TL):"></asp:Label>
            </strong>
            <asp:TextBox ID="txtBakiye" runat="server" class="form-control mt-1"></asp:TextBox>
        </div>
        <br />
        <strong>
            <asp:Button ID="update" runat="server" Text="Kaydet" class="btn btn-success" Style="font-weight: bold" OnClick="update_Click" />
        </strong>
        <br />
        <br />
        <asp:Label CssClass="text-danger" ID="Label1" runat="server" Visible="False"></asp:Label>
    </div>
</asp:Content>
