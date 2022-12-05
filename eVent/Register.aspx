<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="eVent.Register" culture="auto" uiculture="auto" meta:resourcekey="PageResource1"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/eVent.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-b5kHyXgcpbZJ0/tY9Ul7kGkf1S0CWuKcCD38l8YkeH8z8QjE0GmW1gYU5S9F0nJ0"
        crossorigin="anonymous"></script>
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
                                        <a class="acenter"><asp:Label CssClass="current" runat="server" ID="RegistrirajSe" meta:resourcekey="RegistrirajSeResource1">Registracija</asp:Label></a>
                                        <a class="acenter"><asp:HyperLink href="Login.aspx" ID="LogirajSe" runat="server" meta:resourcekey="LogirajSeResource1">Prijavi se</asp:HyperLink></a>
                                    </div>
                                    <div class="col-6">
                                        <div class="col-6" id="FName">
                                            <asp:Label runat="server" ID="ime" meta:resourcekey="imeResource1">Ime:</asp:Label>
                                            <asp:TextBox ID="txtFirstName" runat="server" placeholder="" CssClass="form-control" meta:resourcekey="txtFirstNameResource1" />
                                            <asp:RequiredFieldValidator ControlToValidate="txtFirstName" runat="server" Display="Dynamic" Text="Ime je obavezno" CssClass="form-text text-danger" meta:resourcekey="RequiredFieldValidatorResource1" />
                                        </div>

                                        <div class="col-6" id="LName">
                                            <asp:Label runat="server" meta:resourcekey="LabelResource1" >Prezime:</asp:Label>
                                            <asp:TextBox ID="txtLastName" runat="server" placeholder="" CssClass="form-control" meta:resourcekey="txtLastNameResource1"/>
                                            <asp:RequiredFieldValidator ControlToValidate="txtLastName" runat="server" Display="Dynamic" Text="Prezime je obavezno" CssClass="form-text text-danger" meta:resourcekey="RequiredFieldValidatorResource2"/>

                                        </div>
                                        <div class="col-12" id="EmailCss">
                                            <asp:Label runat="server" meta:resourcekey="LabelResource2">E-mail:</asp:Label>
                                            <asp:TextBox ID="txtEmail" runat="server" placeholder="" CssClass="form-control" meta:resourcekey="txtEmailResource1"/>
                                            <asp:RequiredFieldValidator ControlToValidate="txtEmail" runat="server" Display="Dynamic" Text="E-mail je obavezan" CssClass="form-text text-danger" meta:resourcekey="RequiredFieldValidatorResource3" />
                                            <asp:RegularExpressionValidator ControlToValidate="txtEmail" runat="server" ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$" Display="Dynamic" Text="E-mail nije ispravan" CssClass="form-text text-danger" meta:resourcekey="RegularExpressionValidatorResource1" />
                                            <asp:CustomValidator ID="valEmailExists" ControlToValidate="txtEmail" runat="server" Display="Dynamic" Text="E-mail adresa je zauzeta" CssClass="form-text text-danger" meta:resourcekey="valEmailExistsResource1" />

                                        </div>
                                        <div class="col-12" id="PassCss">
                                            <asp:Label runat="server" meta:resourcekey="LabelResource3">Lozinka:</asp:Label>
                                            <asp:TextBox ID="txtPassword" runat="server" placeholder="" TextMode="Password" CssClass="form-control" meta:resourcekey="txtPasswordResource1" />
                                            <asp:RequiredFieldValidator ControlToValidate="txtPassword" runat="server" Display="Dynamic" Text="Lozinka je obavezna" CssClass="form-text text-danger" meta:resourcekey="RequiredFieldValidatorResource4"/>
                                            <asp:RegularExpressionValidator ControlToValidate="txtPassword" runat="server" ValidationExpression="^[\s\S]{8,64}$" Display="Dynamic" Text="Lozinka mora imati između 8 i 64 znakova" CssClass="form-text text-danger" meta:resourcekey="RegularExpressionValidatorResource2" />
                                        </div>
                                        <div class="col-12" id="RepeatPass">
                                            <asp:Label runat="server" meta:resourcekey="LabelResource4">Potvrdi lozinku:</asp:Label>
                                            <asp:TextBox ID="txtConfirmPassword" runat="server" placeholder="" TextMode="Password" CssClass="form-control" meta:resourcekey="txtConfirmPasswordResource1"/>
                                            <asp:RequiredFieldValidator ControlToValidate="txtConfirmPassword" runat="server" Display="Dynamic" Text="Lozinka je obavezna" CssClass="form-text text-danger" meta:resourcekey="RequiredFieldValidatorResource5"/>
                                            <asp:CompareValidator runat="server" ControlToValidate="txtConfirmPassword" ControlToCompare="txtPassword" Display="Dynamic" Text="Lozinke nisu iste" CssClass="form-text text-danger" meta:resourcekey="CompareValidatorResource1"/>
                                        </div>
                                        <div class="col-12" id="btnCss">
                                            <asp:Button ID="btnRegister" runat="server" Text="Registriraj se" CssClass="btn btn-primary" OnClick="btnRegister_Click" meta:resourcekey="btnRegisterResource1" />
                                        </div>
                                    </div>
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
