<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DersGuncelle.aspx.cs" Inherits="YazOkuluProje.DersGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="ml-5 mx-auto w-50">
        <div class="form-group mt-3">
            <strong>
                <asp:Label for="txtId" runat="server" Text="Ders ID:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtId" runat="server" class="form-control mt-1"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
                <asp:Label for="txtAd" runat="server" Text="Ders Adı:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtAd" runat="server" class="form-control mt-1"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
                <asp:Label for="txtMin" runat="server" Text="Ders Minimum Kontenjan:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtMin" runat="server" class="form-control mt-1"></asp:TextBox>
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
                <asp:Label for="txtUcret" runat="server" Text="Ders Ücreti:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtUcret" runat="server" class="form-control mt-1"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
                <asp:Label for="txtUcret" runat="server" Text="Ders Durumu:"></asp:Label>
            </strong>
            <asp:DropDownList CssClass="form-control dropdown-toggle mt-1" ID="DropDownList1" runat="server">
                <asp:ListItem>Aktif</asp:ListItem>
                <asp:ListItem>Pasif</asp:ListItem>
            </asp:DropDownList>
        </div>
        <br />
        <strong>
            <asp:Button ID="update" runat="server" Text="Güncelle" class="btn btn-success" Style="font-weight: bold" OnClick="update_Click" />
        </strong>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Visible="False" CssClass="text-danger"></asp:Label>
        <asp:Label ID="Label2" runat="server" Visible="False" CssClass="text-success"></asp:Label>
    </div>
</asp:Content>
