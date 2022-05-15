<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RandevuYonetimSistemi.WebFormUI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Giriş</title>
    <style>
        html, body, form {
            height: 100%;
            margin: 0;
            padding: 0;
        }

        form {
            display: flex;
            justify-content: center;
            align-items: center;
        }

        #loginForm {
            width: 420px;
            background-color: darkgray;
            padding: 1rem;
        }

            #loginForm table tr:last-child td {
                text-align: center;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="loginForm">
            <fieldset>
                <legend>Admin Giriş
                </legend>
                <table>
                    <tr>
                        <td>Kullanıcı Adı
                        </td>
                        <td>
                            <asp:TextBox ID="txtKullaniciAdi" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Boş Geçilemez!" ControlToValidate="txtKullaniciAdi" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Şifre</td>
                        <td>
                            <asp:TextBox ID="txtSifre" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Boş Geçilemez!" ControlToValidate="txtSifre" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="btnGiris" runat="server" Text="Giriş" OnClick="btnGiris_Click" />
                        </td>
                    </tr>
                </table>
            </fieldset>
        </div>
    </form>
</body>
</html>
