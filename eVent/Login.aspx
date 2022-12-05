<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="eVent.Login" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/eVent.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.6.0.min.js"></script>
</head>
<body>
    <div class="jumbotron vertical-center">
        <div class="container">
            <div class="card">
                <div class="card-body">
                    <div class="row">
                        <div class="col-6">
                            <form id="form1" runat="server">
                                <div class="row g-3">
                                    <div style="display:flex; flex-direction: row; justify-content: center; align-items: center; text-indent: 50px;">
                                        <a class="acenter"><asp:HyperLink href="Register.aspx" ID="LogirajSe" runat="server" meta:resourcekey="LogirajSeResource1">Registriraj se</asp:HyperLink></a>
                                        <a class="acenter"><asp:Label CssClass="current" runat="server" ID="RegistrirajSe" meta:resourcekey="RegistrirajSeResource1">Prijava</asp:Label></a>
                                    </div>
                                    <div class="col-12" id="EmailCss">
                                        <asp:Label runat="server" meta:resourcekey="LabelResource2">E-mail:</asp:Label>
                                        <asp:TextBox ID="txtEmail" runat="server" placeholder="" CssClass="form-control" meta:resourcekey="txtEmailResource1"/>
                                        <asp:RequiredFieldValidator ControlToValidate="txtEmail" runat="server" Display="Dynamic" Text="E-mail je obavezan" CssClass="form-text text-danger" meta:resourcekey="RequiredFieldValidatorResource1"/>
                                        <asp:RegularExpressionValidator ControlToValidate="txtEmail" runat="server" ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$" Display="Dynamic" Text="E-mail nije ispravan" CssClass="form-text text-danger" meta:resourcekey="RegularExpressionValidatorResource1"/>
                                    </div>
                                    <div class="col-12" id="PassCss">
                                        <asp:Label runat="server" meta:resourcekey="LabelResource3">Lozinka:</asp:Label>
                                        <asp:TextBox ID="txtPassword" runat="server" placeholder="" TextMode="Password" CssClass="form-control" meta:resourcekey="txtPasswordResource1" />
                                        
                                        
                                    </div>
                                    <div class="col-12" id="LName">
                                        <div class="form-check">
                                            <input class="form-check-input" type="checkbox" value="" id="chbShowPassword" onchange="document.getElementById('txtPassword').type = this.checked ? 'text' : 'password'" />
                                            <asp:Label runat="server" class="form-check-label" ID="PrikaziLoz" for="chbShowPassword" meta:resourcekey="PrikaziLozResource1">Prikaži lozinku</asp:Label>
                                        </div>
                                    </div>
                                    <div class="col-12" id="btnCss">
                                        <asp:Button ID="btnLogin" runat="server" Text="Prijavi se" CssClass="btn btn-primary" OnClick="btnLogin_Click" meta:resourcekey="btnLoginResource1" />
                                    </div>
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
    <script>
        $("#txtEmail").click(function () {
            $('#lblError').hide();
        });
        $("#txtPassword").click(function () {
            $('#lblError').hide();
        });
    </script>
</body>
</html>
