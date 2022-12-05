<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Postavke.aspx.cs" Inherits="eVent.Postavke" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Postavke</title>
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
            <div class="card" >
                <div class="card-body">
                    <div class="row">
                        <div class="col-6">
                            <form id="form1" runat="server">

                                <h2 title="postavke" id="korPostNaslovi">
                                    <asp:HyperLink ID="OsobniPodaci" href="KorisnickePostavke.aspx" runat="server" meta:resourcekey="OsobniPodaciResource1">Osobni podaci</asp:HyperLink>
                                    <asp:HyperLink id="MojiDogadaji" href="MojiDogadaji.aspx" runat="server" meta:resourcekey="MojiDogadajiResource1">Moji događaji</asp:HyperLink>
                                    <asp:Label ID="lblPostavke" href="Postavke.aspx" runat="server" meta:resourcekey="lblPostavkeResource1">Postavke</asp:Label></h2>

                                <div class="container2">
                                    <div class="jezik">
                                    <table cellpadding="5" cellspacing="0" class="auto-style1">
                                        <tr >
                                            <td class="auto-style2" style="text-align: right;">
                                                <asp:Label ID="lblJezik" runat="server" Font-Bold="True" Text="Jezik" meta:resourcekey="lblJezikResource1"/>
                                            </td>
                                            <td>
                                                <asp:DropDownList runat="server" ID="ddlJezik" AutoPostBack="True" CssClass="jezik"
                                                    OnSelectedIndexChanged="ddlJezik_SelectedIndexChanged" meta:resourcekey="ddlJezikResource1">
                                                    <asp:ListItem Value="0" meta:resourcekey="ListItemResource1" >---odaberi---</asp:ListItem>
                                                    <asp:ListItem Value="hr" meta:resourcekey="ListItemResource2">Hrvatski</asp:ListItem>
                                                    <asp:ListItem Value="en" meta:resourcekey="ListItemResource3">Engleski</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                                    <table class="center">
                                        <tr>
                                        <td id="EmailKorPosCss">
                                            <asp:Label Text="Email:" runat="server" ID="lblEmail" meta:resourcekey="lblEmailResource1" />
                                            <asp:TextBox ID="txtEmail" runat="server" placeholder="" CssClass="form-control" meta:resourcekey="txtEmailResource1"/>
                                        <div id="btnDeleteUsr">
                                            <asp:Button ID="btnDelUsr" Text="Izbriši račun" runat="server" CssClass="btn btn-primary" OnClick="btnDelUsr_Click" meta:resourcekey="btnDelUsrResource1"></asp:Button>
                                        </div>
                                        </td>
                                    </tr>
                                </table>
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