<%@ Page Title="" Language="C#" MasterPageFile="~/OgrenciMaster.Master" AutoEventWireup="true" CodeBehind="OgrenciDersBasvuru.aspx.cs" Inherits="YazOkuluProje.OgrenciDersBasvuru" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="ml-5 mr-5">
        <div class="form-group mt-3">
            <strong>
                <asp:Label for="txtId" runat="server" Text="Ders ID:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtId" runat="server" class="form-control"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
                <asp:Label for="txtAd" runat="server" Text="Ders Adı:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtAd" runat="server" class="form-control"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
                <asp:Label for="txtUcret" runat="server" Text="Ders Ücreti:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtUcret" runat="server" class="form-control"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
                <asp:Label for="txtUcret" runat="server" Text="Ders Durumu:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtDurum" runat="server" class="form-control"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">
            <strong>
                <asp:Label for="txtNumara" runat="server" Text="Öğrenci Numarası:"></asp:Label>
            </strong>
            <asp:TextBox ID="txtNumara" runat="server" class="form-control" placeholder="Öğrenci Numarası Giriniz"></asp:TextBox>
        </div>
        <br />
        <strong>
            <asp:Button ID="update" runat="server" Text="Başvur" class="btn btn-success" Style="font-weight: bold" OnClick="update_Click" />
        </strong>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Visible="False" CssClass="text-danger"></asp:Label>
        <asp:Label ID="Label2" runat="server" Visible="False" CssClass="text-success"></asp:Label>
    </div>
</asp:Content>
