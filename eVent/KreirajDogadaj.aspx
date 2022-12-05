<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KreirajDogadaj.aspx.cs" Inherits="eVent.KreirajDogadaj" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Kreiraj dogadaj</title>
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
    <form runat="server">
        <nav class="navbar navbar-expand-sm navbar-light bg-light">
            <div class="container-fluid ">
                <a class="navbar-brand" id="navNaslov" href="#">eVent</a>
                <asp:Label CssClass="ulogiran" ID="lblUser" runat="server" meta:resourcekey="lblUserResource1" />
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse justify-content-end" id="navbarSupportedContent">
                    <ul class="navbar-nav ">
                        <li class="nav-item">
                            <asp:LinkButton runat="server" class="nav-link active" aria-current="page" ID="navNaslovna" href="PocetnaStrana.aspx" Text="Pocetna strana" meta:resourcekey="navNaslovnaResource1" />
                        </li>
                        <li class="nav-item">
                            <asp:LinkButton runat="server" class="nav-link active" aria-current="page" ID="navKontakt" href="Kontakt.aspx" Text="Kontakt" meta:resourcekey="navKontaktResource1" />
                        </li>
                        <li class="nav-item">
                            <asp:LinkButton runat="server" class="nav-link active" aria-current="page" ID="navONama" href="ONama.aspx" Text="O nama" meta:resourcekey="navONamaResource1" />
                        </li>
                        <li class="nav-item">
                            <asp:LinkButton runat="server" class="nav-link active" aria-current="page" ID="navKorPos" href="KorisnickePostavke.aspx" Text="Korisničke postavke" meta:resourcekey="navKorPosResource1" />
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        <div class="h1Naslov">
            <asp:Label runat="server" ID="h1Naslov" Text="Kreiranje novog događaja" meta:resourcekey="h1NaslovResource1" />
        </div>
        <div class="card" style="box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2); transition: 0.3s; border-radius: 5px; margin-right: 600px; margin-left: 580px">
            <div class="card-body">
                <div class="container" style="padding: 40px 50px;">
                    <table>
                        <tr>
                            <td>
                                <div class="form-group">
                                    <div class="urediNazivId">
                                        <asp:Label Text="Naziv" runat="server" ID="lblNaziv" Font-Size="Medium" meta:resourcekey="lblNazivResource1"/>
                                    </div>
                                    <div class="urediNazivId">
                                        <asp:TextBox ID="txtNaziv" runat="server" Width="250px" CssClass="form-control" meta:resourcekey="txtNazivResource1" />
                                    </div>
                                    <div class="urediNazivId">
                                        <asp:Label Text="Opis" runat="server" ID="lblOpis" Font-Size="Medium" meta:resourcekey="lblOpisResource1"/>
                                    </div>
                                    <div class="urediNazivId">
                                        <asp:TextBox runat="server" ID="txtOpis" TextMode="MultiLine" Rows="10" CssClass="form-control" meta:resourcekey="txtOpisResource1" />
                                    </div>
                                    <div class="urediNazivId">
                                        <asp:Label Text="Tip Događaja" runat="server" ID="lblTip" Font-Size="Medium" meta:resourcekey="lblTipResource1"/>
                                    </div>
                                    <div class="urediNazivId">
                                        <asp:TextBox ID="txtTip" runat="server" placeholder=" " CssClass="form-control" meta:resourcekey="txtTipResource1" />
                                    </div>
                                    <div class="urediNazivId">
                                        <asp:Label Text="Cijena" runat="server" ID="lblCijena" Font-Size="Medium" meta:resourcekey="lblCijenaResource1"/>
                                    </div>
                                    <div class="urediNazivId">
                                        <asp:TextBox ID="txtCijena" runat="server" placeholder=" " TextMode="Number" CssClass="form-control" meta:resourcekey="txtCijenaResource1" />
                                    </div>
                                </div>
                            </td>
                            <td>
                                <div class="form-group">
                                    <div class="urediNazivId">
                                        <asp:Label runat="server" Text="Lokacija" ID="lblLokacija" Font-Size="Medium" meta:resourcekey="lblLokacijaResource1"/>
                                    </div>
                                    <div class="urediNazivId">
                                        <asp:TextBox ID="txtLokacija" runat="server" placeholder=" " CssClass="form-control" meta:resourcekey="txtLokacijaResource1" />
                                    </div>
                                    <div class="urediNazivId">
                                        <asp:Label runat="server" Text="Datum početka" ID="lblDatumPocetak" Font-Size="Medium" meta:resourcekey="lblDatumPocetakResource1"/>
                                    </div>
                                    <div class="urediNazivId">
                                        <asp:TextBox ID="txtDatumPocetak" runat="server" Width="250px" placeholder="dd-mm-yyyy" TextMode="Date" CssClass="form-control" meta:resourcekey="txtDatumPocetakResource1" />
                                    </div>
                                    <div class="urediNazivId">
                                        <asp:Label runat="server" Text="Datum završetka" ID="lblDatumZavrsetak" Font-Size="Medium" meta:resourcekey="lblDatumZavrsetakResource1"/>
                                    </div>
                                    <div class="urediNazivId">
                                        <asp:TextBox ID="txtDatumZavrsetak" runat="server" placeholder="dd-mm-yyyy" TextMode="Date" CssClass="form-control" meta:resourcekey="txtDatumZavrsetakResource1" />
                                    </div>
                                    <div class="urediNazivId">
                                        <asp:Label runat="server" Text="Vrijeme početka" ID="lblVrijemePocetak" Font-Size="Medium" meta:resourcekey="lblVrijemePocetakResource1"/>
                                    </div>
                                    <div class="urediNazivId">
                                        <asp:TextBox ID="txtVrijemePocetak" runat="server" placeholder="00:00" TextMode="DateTime" CssClass="form-control" meta:resourcekey="txtVrijemePocetakResource1" />
                                    </div>
                                    <div class="urediNazivId">
                                        <asp:Label runat="server" Text="Vrijeme završetka" ID="lblVrijemeZavrsetak" Font-Size="Medium" meta:resourcekey="lblVrijemeZavrsetakResource1"/>
                                    </div>
                                    <div class="urediNazivId">
                                        <asp:TextBox ID="txtVrijemeZavrsetak" runat="server" placeholder="00:00" TextMode="DateTime" CssClass="form-control" meta:resourcekey="txtVrijemeZavrsetakResource1" />
                                    </div>
                                </div>
                            </td>
                            <td>
                                <div>
                                    <div class="urediNazivId">
                                        <asp:Label runat="server" Text="Slike" ID="lblSlike" Font-Size="Medium" meta:resourcekey="lblSlikeResource1"/>
                                    </div>
                                    <asp:FileUpload runat="server" type='file' ID="inputFile" name="slika" meta:resourcekey="inputFileResource1"/>
                                </div>
                            </td>
                        </tr>
                    </table>
                    <div class="btnKreiraj" style="text-align: center; font-size: 20px;">
                        <asp:Button runat="server" Text="Odustani" OnClick="Odustani_click" CssClass="btn btn-secondary" meta:resourcekey="ButtonResource1" />
                        <asp:Button runat="server" Text="Kreiraj" OnClick="Kreiraj_click" CssClass="btn btn-primary" meta:resourcekey="ButtonResource2" />
                    </div>
                </div>
            </div>
        </div>
    </form>
    <style>
    </style>

</body>
</html>
