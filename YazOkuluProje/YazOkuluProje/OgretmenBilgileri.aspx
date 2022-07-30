<%@ Page Title="" Language="C#" MasterPageFile="~/OgretmenMaster.Master" AutoEventWireup="true" CodeBehind="OgretmenBilgileri.aspx.cs" Inherits="YazOkuluProje.OgretmenBilgileri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="card w-50 mx-auto my-5">
        <div class="card-body">
            <div class="form-group row">
                <label class="col-sm-2 col-form-label">Ad - Soyad:</label>
                <div class="col-sm-10">
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </div>
            </div>
            <hr />
            <div class="form-group row">
                <label class="col-sm-2 col-form-label">Numara:</label>
                <div class="col-sm-10">
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                </div>
            </div>
            <hr />
            <div class="form-group row">
                <label class="col-sm-2 col-form-label">Ders:</label>
                <div class="col-sm-10">
                    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                </div>
            </div>
            <hr />
            <a href="YeniSifre.aspx" class="btn btn-primary mt-2">Yeni Şifre</a>
        </div>
</asp:Content>
