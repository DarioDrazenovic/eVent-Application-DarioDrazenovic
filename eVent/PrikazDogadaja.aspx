<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrikazDogadaja.aspx.cs" Inherits="eVent.PrikazDogadaja" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
                    </ul>
                </div>
            </div>
        </nav>

        <div style="display: flex; align-items: center; justify-content: center; padding: 8px;">
            <asp:Button runat="server" ID="btn_dolazim" OnClick="btn_dolazim_Click" Text="Dolazim!" CssClass="btn btn-success" meta:resourcekey="btn_dolazimResource1" />
        </div>
        <div>
            <asp:Panel runat="server" ID="panel_dogadaji" meta:resourcekey="panel_dogadajiResource1"></asp:Panel>
        </div>
        <div style="display: flex; align-items: center; justify-content: center; font-size: medium;">
            <asp:Label runat="server" Text="Ostavi komentar" meta:resourcekey="LabelResource1"></asp:Label>
            <asp:TextBox runat="server" ID="tb_komentar" meta:resourcekey="tb_komentarResource1" />
            <asp:Button runat="server" ID="btn_komentiraj" OnClick="btn_komentiraj_Click" Text="Komentiraj" meta:resourcekey="btn_komentirajResource1" />
        </div>
    </form>
</body>
</html>