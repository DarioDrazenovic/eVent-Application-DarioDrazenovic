<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KorisnickePostavke.aspx.cs" Inherits="eVent.KorisnickePostavke" Culture="auto" meta:resourcekey="PageResource1" UICulture="auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Korisnicke postavke</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/eVent.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-b5kHyXgcpbZJ0/tY9Ul7kGkf1S0CWuKcCD38l8YkeH8z8QjE0GmW1gYU5S9F0nJ0"
        crossorigin="anonymous"></script>
</head>
<body runat="server" id="BodyTag">
    <div class="jumbotron vertical-center">
        <div class="container" style="padding: 18px 270px;">
            <div class="card">
                <div class="card-body">
                    <div class="row">
                        <div class="col-6">
                            <form id="form1" runat="server">
                                <h2 title="postavke" id="korPostNaslovi">
                                    <asp:Label Text="Osobni podaci" runat="server" ID="lblOsobniPod" meta:resourcekey="lblOsobniPodResource1" />
                                    <asp:HyperLink ID="MojiDogadaji" href="MojiDogadaji.aspx" runat="server" meta:resourcekey="MojiDogadajiResource1">Moji događaji</asp:HyperLink>
                                    <asp:HyperLink ID="Postavke" href="Postavke.aspx" runat="server" meta:resourcekey="PostavkeResource1">Postavke</asp:HyperLink></h2>
                                <div class="container2">
                                    <table class="center">

                                        <tr>
                                            <td id="EmailKorPosCss">
                                                <asp:Label Text="Email:" runat="server" ID="lblEmail" meta:resourcekey="lblEmailResource1" />
                                                <asp:TextBox ID="txtEmail" runat="server" placeholder="" CssClass="form-control" meta:resourcekey="txtEmailResource1" Enabled="false" />
                                            </td>
                                        </tr>
                                        
                                        <tr>
                                            <td id="StaraLozinkaCss">
                                                <asp:Label Text="Stara lozinka:" runat="server" ID="lblStLoz" meta:resourcekey="lblStLozResource1" />
                                                <asp:TextBox ID="txtOldPass" runat="server" placeholder=" " TextMode="Password" CssClass="form-control" meta:resourcekey="txtOldPassResource1"></asp:TextBox></td>
                                            <asp:RegularExpressionValidator ControlToValidate="txtOldPass" runat="server" ForeColor="Red"
                                                ValidationExpression="^[\s\S]{8,64}$" Display="Dynamic" Text="Min 8, max 64" CssClass="form-text" meta:resourcekey="RegularExpressionValidatorResource1" />
                                        </tr>
                                        <tr>
                                            <td id="NovaLozinkaCss">
                                                <asp:Label Text="Nova lozinka:" runat="server" ID="lblNovaLoz" meta:resourcekey="lblNovaLozResource1" />
                                                <asp:TextBox ID="txtNewPass" runat="server" placeholder="" TextMode="Password" CssClass="form-control" meta:resourcekey="txtNewPassResource1"></asp:TextBox></td>
                                            <asp:RegularExpressionValidator ControlToValidate="txtNewPass" runat="server" ForeColor="Red"
                                                ValidationExpression="^[\s\S]{8,64}$" Display="Dynamic" Text="Min 8, max 64" CssClass="form-text" meta:resourcekey="RegularExpressionValidatorResource2" />
                                        </tr>
                                        <tr>
                                            <td id="PonoviteLozinkuCss">
                                                <asp:Label Text="Ponovite lozinku:" runat="server" ID="lblPonLoz" meta:resourcekey="lblPonLozResource1" />
                                                <asp:TextBox ID="txtConPass" runat="server" placeholder="" TextMode="Password" CssClass="form-control" meta:resourcekey="txtConPassResource1"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td class="col-12" id="btnZaLozinkeCss">
                                                <asp:Label ID="Label1" runat="server" ForeColor="Red" Font-Bold="True" meta:resourcekey="Label1Resource1"></asp:Label>
                                                <asp:Button ID="btnPwd" runat="server" Text="Promjeni" CssClass="btn btn-primary" OnClick="btnPwd_Click" meta:resourcekey="btnPwdResource1" />
                                                <asp:Button ID="btnGup" Text="Odustani" runat="server" CssClass="btn btn-primary" OnClick="btnGup_Click" meta:resourcekey="btnGupResource1" /></td>
                                        </tr>

                                    </table>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row mt-3 col-4">
                <asp:Label ID="lblError" runat="server" Visible="False" CssClass="alert alert-danger" meta:resourcekey="lblErrorResource1" />
            </div>
        </div>
    </div>
</body>
</html>
