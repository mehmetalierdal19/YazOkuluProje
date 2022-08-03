<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DersListesi.aspx.cs" Inherits="YazOkuluProje.DersListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="mt-2 mb-3">
        <a href="DersEkle.aspx" class="btn btn-success ml-2">Ders Ekle</a>
    </div>
    <table class="table table-striped">
        <thead>
            <tr>
                <th scope="col">Ders ID</th>
                <th scope="col">Ders Ad</th>
                <th scope="col">Ders Minimum Kontenjan</th>
                <th scope="col">Ders Maksimum Kontenjan</th>
                <th scope="col">Ders Kontenjan Durumu</th>
                <th scope="col">Ders Durumu</th>
                <th scope="col">Ders Ücreti</th>
                <th scope="col">İşlemler</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <th scope="row"><%#Eval("DersId") %></th>
                        <td><%#Eval("Dersad") %></td>
                        <td><%#Eval("Min") %></td>
                        <td><%#Eval("Max") %></td>
                        <td><%#Eval("KontDurum") %></td>
                        <td><%#Eval("DersDurum") %></td>
                        <td><%#Eval("DersBakiye") %> TL</td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "~/DersSil.aspx?DersId=" + Eval("DersId") %>' ID="HyperLink2" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "~/DersGuncelle.aspx?DersId=" + Eval("DersId") %>' ID="HyperLink1" CssClass="btn btn-primary" runat="server">Güncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
