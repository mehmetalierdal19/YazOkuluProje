<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YeniSifre.aspx.cs" Inherits="YazOkuluProje.YeniSifre" %>

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
                    <form runat="server">
                        <asp:Button ID="btnGeri" runat="server" CssClass="btn btn-danger btn-login fw-bold mt-3 ms-2" Text="Geri" OnClick="btnGeri_Click" />
                        <div class="card-body p-4 p-sm-5">
                            <h5 class="card-title text-center mb-5 fw-bold fs-5">Şifre Değiştir</h5>

                            <div class="form-floating mb-4">
                                <%-- <input type="email" class="form-control" id="floatingInput" placeholder="name@example.com">--%>
                                <asp:TextBox ID="txtEski" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                <label for="floatingInput">Eski Şifre</label>
                            </div>
                            <div class="form-floating mb-4">
                                <%--<input type="password" class="form-control" id="floatingPassword" placeholder="Password">--%>
                                <asp:TextBox ID="txtYeni" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                <label for="floatingPassword">Yeni Şifre</label>
                            </div>
                            <div class="form-floating mb-5">
                                <%--<input type="password" class="form-control" id="floatingPassword" placeholder="Password">--%>
                                <asp:TextBox ID="txtYeniTekrar" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                <label for="floatingPassword">Yeni Şifre Tekrar</label>
                            </div>
                            <div class="d-grid">
                                <%--<button class="btn btn-primary btn-login text-uppercase fw-bold" type="submit"></button>--%>
                                <asp:Button ID="btnDegistir" runat="server" CssClass="btn btn-primary btn-login fw-bold" Text="ŞİFRE DEĞİŞTİR" OnClick="btnDegistir_Click" />
                            </div>
                            <asp:Label ID="Label1" runat="server" CssClass="text-danger" Visible="False"></asp:Label>

                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2" crossorigin="anonymous"></script>
</body>
</html>
