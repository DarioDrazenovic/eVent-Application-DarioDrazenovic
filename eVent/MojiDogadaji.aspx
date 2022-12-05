<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MojiDogadaji.aspx.cs" Inherits="eVent.MojiDogadaji" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Moji dogadaji</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/eVent.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-b5kHyXgcpbZJ0/tY9Ul7kGkf1S0CWuKcCD38l8YkeH8z8QjE0GmW1gYU5S9F0nJ0"
        crossorigin="anonymous"></script>
</head>
<body runat="server" id="BodyTag">
    <div class="jumbotron vertical-center">
        <div class="container" style="padding: 18px 100px;">
            <div class="card" style="padding:50px" >
                <div class="card-body">
                    <div class="row">
                        <div class="col-6">
                            <form id="form1" runat="server">

                                <h2 title="postavke" id="korPostNaslovi">
                                    <asp:HyperLink ID="OsobniPodaci" href="KorisnickePostavke.aspx" runat="server" meta:resourcekey="OsobniPodaciResource1">Osobni podaci</asp:HyperLink>
                                    <asp:Label id="lblMojiDogadaji2" runat="server" meta:resourcekey="lblMojiDogadaji2Resource1">Moji događaji</asp:Label>
                                    <asp:HyperLink ID="Postavke2" href="Postavke.aspx" runat="server" meta:resourcekey="Postavke2Resource1">Postavke</asp:HyperLink></h2>

                                <asp:Label runat="server" id="lbl_nemaDogadaja" Visible="false">Nemate niti jedan kreirani događaj. (work in progress)</asp:Label>
                                <asp:Panel runat="server" ID="gv_dogadaji" />
                                
                                <!--hr ne radi sa card tak da je ovo najbolje kaj ima...-->
                                    ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
                                <div id="btnKreiraj" style="padding-top:30px;">
                                    <asp:Button runat="server" Text="Kreiraj" OnClick="Kreiraj_click" meta:resourcekey="ButtonResource1" />
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row mt-3 col-4">
                <asp:Label ID="lblError" runat="server" Visible="False" CssClass="alert alert-danger" meta:resourcekey="lblErrorResource1"/>
            </div>
        </div>
    </div>
</body>
</html>