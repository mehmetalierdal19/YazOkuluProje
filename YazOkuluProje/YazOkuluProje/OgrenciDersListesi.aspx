<%@ Page Title="" Language="C#" MasterPageFile="~/OgrenciMaster.Master" AutoEventWireup="true" CodeBehind="OgrenciDersListesi.aspx.cs" Inherits="YazOkuluProje.OgrenciDersListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-striped">
        <thead>
            <tr>
                <th scope="col">Ders ID</th>
                <th scope="col">Ders Ad</th>
                <th scope="col">Ders Minimum Kontenjan</th>
                <th scope="col">Ders Maksimum Kontenjan</th>
                <th scope="col">Ders Kontenjan Durumu</th>
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
                        <td><%#Eval("DersBakiye") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "~/OgrenciDersBasvuru.aspx?DersId=" + Eval("DersId") %>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Başvur</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
