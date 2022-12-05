﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kontakt.aspx.cs" Inherits="eVent.Kontakt" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Kontakti </title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/eVent.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.6.0.min.js"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js" integrity="sha384-IQsoLXl5PILFhosVNubq5LC7Qb9DXgDA9i+tQ8Zj3iwWAwPtgFTxbJ8NT4GN1R8p" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.min.js" integrity="sha384-Atwg2Pkwv9vp0ygtn1JAojH0nYbwNJLPhwyoVbhoPwBhjQPR5VtM2+xf0Uwh9KtT" crossorigin="anonymous"></script>
</head>

<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-sm navbar-light bg-light">
            <div class="container-fluid ">
                <a class="navbar-brand" id="navNaslov" href="#">eVent</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse justify-content-end" id="navbarSupportedContent">
                    <ul class="navbar-nav ">
                        <li class="nav-item">
                            <asp:LinkButton runat="server" class="nav-link active" aria-current="page" ID="navNaslovna" href="PocetnaStrana.aspx" Text="Početna strana" meta:resourcekey="navNaslovnaResource1" />
                        </li>
                        <li class="nav-item">
                            <asp:LinkButton runat="server" class="nav-link active" aria-current="page" ID="navKontakt" href="Kontakt.aspx" Text="Kontakt" meta:resourcekey="navKontaktResource1" />
                        </li>
                        <li class="nav-item">
                            <asp:LinkButton runat="server" class="nav-link active" aria-current="page" ID="navONama" href="ONama.aspx" Text="O nama" meta:resourcekey="navONamaResource1" />
                        </li>
                        <li class="nav-item">
                            <asp:LinkButton runat="server" class="nav-link active" aria-current="page" ID="navKorPos" href="KorisnickePostavke.aspx" Visible="False" Text="Korisničke postavke" meta:resourcekey="navKorPosResource1" />
                        </li>
                        <li class="nav-item">
                            <asp:Button runat="server" OnClick="btnLogout_Click" CssClass="btn btn-danger" style="height: 45px; font-size: 15px;" aria-current="page" ID="btnLogout" Text="Odjavi se" meta:resourcekey="btnLogoutResource1" />
                        </li>
                    </ul>
                </div>
            </div>
        </nav>

        <div class="h1Naslov">
            <asp:Label runat="server" ID="h1Naslov" Text="Kontakti" meta:resourcekey="h1NaslovResource1" />
        </div>
        <div>
            <ul style="list-style: none; font-size: 20px; font-family:serif; padding-top: 50px; text-align:center;">
                <li style="text-align:center;">
                    <asp:Label runat="server" Text="Detalji i kontakti organizacije dostupni su u nastavku: " meta:resourcekey="LabelResource1" />
                </li>
                <li style="padding-top: 20px; padding-bottom: 20px; text-align:center;">
                    <asp:Label runat="server" Text="Puni naziv: " meta:resourcekey="LabelResource2" />
                    <asp:Label runat="server" Font-Size="Larger" Font-Bold="True" Text="eVent" meta:resourcekey="LabelResource3" />
                </li>
                <li style="text-align:center;">
                    <div>
                        <asp:Label Font-Bold="True" runat="server" Text="Adresa sjedišta: " meta:resourcekey="LabelResource4" />
                        <asp:Label runat="server" Text="Gradišćanska 24, Zagreb" meta:resourcekey="LabelResource5" />
                    </div>
                    <div>
                        <asp:Label Font-Bold="True" runat="server" Text="E-mail: " meta:resourcekey="LabelResource6" />
                        <asp:Label runat="server" Text="info_event@outlook.hr" meta:resourcekey="LabelResource7" />
                    </div>
                    <div>
                        <asp:Label Font-Bold="True" runat="server" Text="OIB: " meta:resourcekey="LabelResource8" />
                        <asp:Label runat="server" Text="12345678910" meta:resourcekey="LabelResource9" />
                    </div>
                </li>
            </ul>
        </div>
    </form>
</body>
</html>
