<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciListesi.aspx.cs" Inherits="YazOkuluProje.OgrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-hover">
        <thead>
            <tr>
                <th scope="col">Öğrenci ID</th>
                <th scope="col">Öğrenci Ad</th>
                <th scope="col">Öğrenci Soyad</th>
                <th scope="col">Öğrenci Numara</th>
                <th scope="col">Öğrenci Email</th>
                <th scope="col">Öğrenci Şifre</th>
                <th scope="col">Öğrenci Bakiye</th>
                <th scope="col">İşlemler</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <th scope="row"><%#Eval("OgrId") %></th>
                        <td><%#Eval("Ad") %></td>
                        <td><%#Eval("Soyad") %></td>
                        <td><%#Eval("Numara") %></td>
                        <td><%#Eval("Mail") %></td>
                        <td><%#Eval("Sifre") %></td>
                        <td><%#Eval("Bakiye") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "~/OgrenciSil.aspx?OgrId=" + Eval("OgrId") %>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "~/OgrenciGuncelle.aspx?OgrId=" + Eval("OgrId") %>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
