<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="YazOkuluProje.LoginPage" %>

<!doctype html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Yaz Okulu Ders Kayıt</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous">
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-sm-9 col-md-7 col-lg-5 mx-auto">
                <div class="card border-0 shadow rounded-3 my-5">
                    <div class="card-body p-4 p-sm-5">
                        <h5 class="card-title text-center mb-5 fw-bold fs-5">Giriş Yap</h5>
                        <form runat="server">
                            <div class="form-floating mb-3">
                               <%-- <input type="email" class="form-control" id="floatingInput" placeholder="name@example.com">--%>
                                <asp:TextBox ID="floatingInput" runat="server" CssClass="form-control"></asp:TextBox>
                                <label for="floatingInput">Öğrenci Veya Öğretmen Numarası</label>
                            </div>
                            <div class="form-floating mb-3">
                                <%--<input type="password" class="form-control" id="floatingPassword" placeholder="Password">--%>
                                <asp:TextBox ID="floatingPassword" runat="server" CssClass="form-control" TextMode="Password" ></asp:TextBox>
                                <label for="floatingPassword">Şifre</label>
                            </div>
                            <div class="form-floating mb-5">
                                <asp:DropDownList id="floatingDrop" runat="server"  CssClass="form-control w-100">
                                    <asp:ListItem Value="1">Öğrenci Girişi</asp:ListItem>
                                    <asp:ListItem Value="2">Öğretmen Girişi</asp:ListItem>
                                    <asp:ListItem Value="3">Admin Girişi</asp:ListItem>
                                </asp:DropDownList>
                                <label for="floatingDrop">Seçiniz</label>
                            </div>
                            <div class="d-grid">
                                <%--<button class="btn btn-primary btn-login text-uppercase fw-bold" type="submit"></button>--%>
                                <asp:Button ID="btnGiriş" runat="server" CssClass="btn btn-primary btn-login text-uppercase fw-bold" Text="Giriş Yap" OnClick="btnGiriş_Click"/>
                            </div>
                            <asp:Label ID="Label1" runat="server" CssClass="text-danger" Visible="False"></asp:Label>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2" crossorigin="anonymous"></script>
</body>
</html>
