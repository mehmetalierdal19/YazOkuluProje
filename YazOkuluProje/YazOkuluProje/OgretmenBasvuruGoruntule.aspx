<%@ Page Title="" Language="C#" MasterPageFile="~/OgretmenMaster.Master" AutoEventWireup="true" CodeBehind="OgretmenBasvuruGoruntule.aspx.cs" Inherits="YazOkuluProje.OgretmenBasvuruGoruntule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-hover">
        <thead>
            <tr>
                <th scope="col">Başvuru ID</th>
                <th scope="col">Öğrenci Ad-Soyad</th>
                <th scope="col">Öğrenci Numarası</th>
                <th scope="col">Ders ID</th>
                <th scope="col">Ders Ad</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <th scope="row"><%#Eval("BasvuruId") %></th>
                        <td><%#Eval("BasOgrAd") %></td>
                        <td><%#Eval("BasOgrNo") %></td>
                        <td scope="row"><%#Eval("BasDersId") %></td>
                        <td><%#Eval("BasDersAd") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
