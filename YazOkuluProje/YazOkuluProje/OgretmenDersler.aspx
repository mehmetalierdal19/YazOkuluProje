<%@ Page Title="" Language="C#" MasterPageFile="~/OgretmenMaster.Master" AutoEventWireup="true" CodeBehind="OgretmenDersler.aspx.cs" Inherits="YazOkuluProje.OgretmenDersler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-hover">
        <thead>
            <tr>
                <th scope="col">Ders ID</th>
                <th scope="col">Ders Ad</th>
                <th scope="col">Minimum Kontenjan</th>
                <th scope="col">Maksimum Kontenjan</th>
                <th scope="col">Başvuru Sayısı</th>
                <th scope="col">Ders Durumu</th>
                <th scope="col">Durum Güncelle</th>
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
                        <td>
                            <%--<asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="Aktif" OnClick="Button1_Click" />
                            <asp:Button ID="Button2" CssClass="btn btn-danger" runat="server" Text="Pasif" OnClick="Button2_Click" />--%>
                            <asp:HyperLink NavigateUrl='<%# "~/DersDurumGuncelle.aspx?BasDersId=" + Eval("DersId") + "&DersDurum=Aktif"%>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Aktif</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "~/DersDurumGuncelle.aspx?BasDersId=" + Eval("DersId") + "&DersDurum=Pasif"%>' ID="HyperLink3" CssClass="btn btn-danger" runat="server">Pasif</asp:HyperLink>
                        </td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "~/OgretmenBasvuruGoruntule.aspx?DersId=" + Eval("DersId")%>' ID="HyperLink1" CssClass="btn btn-primary" runat="server">Başvuruları Görüntüle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>

</asp:Content>
