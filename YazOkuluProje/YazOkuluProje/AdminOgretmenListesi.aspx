<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdminOgretmenListesi.aspx.cs" Inherits="YazOkuluProje.AdminOgretmenListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="mt-2 mb-3">
        <a href="OgretmenEkle.aspx" class="btn btn-success ml-2">Öğretmen Ekle</a>
    </div>
    <table class="table table-hover">
        <thead>
            <tr>
                <th scope="col">Öğretmen ID</th>
                <th scope="col">Öğretmen Ad-Soyad</th>
                <th scope="col">Öğretmen Numarası</th>
                <th scope="col">Öğretmen Sifre</th>
                <th scope="col">Öğretmen Ders ID</th>
                <th scope="col">Öğretmen Ders</th>
                <th scope="col">İşlemler</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <th scope="row"><%#Eval("OgrtId") %></th>
                        <td><%#Eval("OgrtAd") %></td>
                        <td><%#Eval("OgrtNumara") %></td>
                        <td><%#Eval("OgrtSifre") %></td>
                        <td><%#Eval("OgrtDersId") %></td>
                        <td><%#Eval("OgrtDersAd") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "~/OgretmenSil.aspx?OgrtId=" + Eval("OgrtId") %>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "~/OgretmenGuncelle.aspx?OgrtId=" + Eval("OgrtId") %>' ID="HyperLink2" CssClass="btn btn-primary" runat="server">Güncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
