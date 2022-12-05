<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PocetnaStrana.aspx.cs" Inherits="eVent.PocetnaStrana" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<form runat="server">
<!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <title>Pocetna strana</title>
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
                            <asp:Button runat="server" OnClick="btnLogout_Click" CssClass="btn btn-danger" style="height: 45px; font-size: 15px;" aria-current="page" ID="btnLogout" Visible="False" Text="Odjavi se" meta:resourcekey="btnLogoutResource1" />
                        </li>
                        <li class="nav-item">
                            <asp:LinkButton runat="server" class="nav-link active" aria-current="page" ID="navLogin" href="Login.aspx" Text="Prijava" meta:resourcekey="navLoginResource1" />
                        </li>
                        <li class="nav-item">
                            <asp:LinkButton runat="server" class="nav-link" ID="navRegister" href="Register.aspx" Text="Registracija" meta:resourcekey="navRegisterResource1" />
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        <div class="h1Naslov">
            <asp:Label runat="server" ID="h1Naslov" Text="Pretraži događaje" meta:resourcekey="h1NaslovResource1" />
        </div>
        <div id="inputDogadaj">
            <asp:TextBox runat="server" ID="tb_trazilica" type="text" size="50" name="inputDog" />
        </div>
        <div id="btnSubmit">
            <asp:Button runat="server" ID="btn_trazi" class="btn btn-primary" size="50" Text="Traži" style="height: 50px; font-size: 22px;" meta:resourcekey="ButtonResource1" OnClick="btn_trazi_Click" />
        </div>

        <asp:Panel runat="server" ID="panel_dogadaji"></asp:Panel>

        

    </body>
    </html>
</form>
