<%@ Page Title="" Language="C#" MasterPageFile="~/OgrenciMaster.Master" AutoEventWireup="true" CodeBehind="BakiyeYükleme.aspx.cs" Inherits="YazOkuluProje.BakiyeYükleme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="card w-50 mx-auto my-5">
        <div class="card-body">
            <div class="form-group row">
                <label class="col-sm-6 col-form-label">Kart Numarası:</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="txtKartNo" runat="server" CssClass="form-control" MaxLength="16"></asp:TextBox>
                </div>
            </div>
            <hr />
            <div class="form-group row">
                <label class="col-sm-6 col-form-label">CVV:</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="txtCVV" runat="server" CssClass="form-control w-50" MaxLength="3" TextMode="Password"></asp:TextBox>
                </div>
            </div>
            <hr />
            <div class="form-group row">
                <label class="col-sm-6 col-form-label">Son Kullanma Tarihi:</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtAy" runat="server" CssClass="form-control" placeholder="MM" MaxLength="2"></asp:TextBox>
                </div>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtYil" runat="server" CssClass="form-control" placeholder="YYYY" MaxLength="4"></asp:TextBox>
                </div>
            </div>
            <hr />
            <div class="form-group row">
                <label class="col-sm-6 col-form-label">Yüklemek İstediğiniz Miktar:</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="txtMiktar" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <hr />
            <asp:Button ID="Button1" runat="server" Text="Bakiye Yükle" CssClass="btn btn-success mt-1" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server" CssClass="col-sm-12 col-form-label text-danger" Visible="False"></asp:Label>
        </div>
    </div>
</asp:Content>
