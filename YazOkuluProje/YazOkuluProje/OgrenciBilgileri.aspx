﻿<%@ Page Title="" Language="C#" MasterPageFile="~/OgrenciMaster.Master" AutoEventWireup="true" CodeBehind="OgrenciBilgileri.aspx.cs" Inherits="YazOkuluProje.OgrenciBilgileri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="card w-50 mx-auto my-5">
        <div class="card-body">
            <form>
                <div class="form-group row">
                    <label for="staticEmail" class="col-sm-2 col-form-label">Ad:</label>
                    <div class="col-sm-10">
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="form-group row">
                    <label for="inputPassword" class="col-sm-2 col-form-label">Soyad:</label>
                    <div class="col-sm-10">
                        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="form-group row">
                    <label for="inputPassword" class="col-sm-2 col-form-label">Numara:</label>
                    <div class="col-sm-10">
                        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="form-group row">
                    <label for="inputPassword" class="col-sm-2 col-form-label">Şifre:</label>
                    <div class="col-sm-10">
                        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="form-group row">
                    <label for="inputPassword" class="col-sm-2 col-form-label">Mail:</label>
                    <div class="col-sm-10">
                        <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="form-group row">
                    <label for="inputPassword" class="col-sm-2 col-form-label">Bakiye:</label>
                    <div class="col-sm-10">
                        <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
