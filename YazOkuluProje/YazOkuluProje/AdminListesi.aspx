<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdminListesi.aspx.cs" Inherits="YazOkuluProje.AdminListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="mt-2 mb-3">
        <a href="AdminEkle.aspx" class="btn btn-success ml-2">Admin Ekle</a>
    </div>
    <table class="table table-hover">
        <thead>
            <tr>
                <th scope="col">Admin ID</th>
                <th scope="col">Kullanıcı Adı</th>
                <th scope="col">Şifre</th>
                <th scope="col">İşlemler</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <th scope="row"><%#Eval("AdminId") %></th>
                        <td><%#Eval("KullaniciAdi") %></td>
                        <td><%#Eval("Sifre") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "~/AdminSil.aspx?AdminId=" + Eval("AdminId") %>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "~/AdminGuncelle.aspx?AdminId=" + Eval("AdminId") + "&KullaniciAdi=" + Eval("KullaniciAdi") %>' ID="HyperLink2" CssClass="btn btn-primary" runat="server">Güncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
