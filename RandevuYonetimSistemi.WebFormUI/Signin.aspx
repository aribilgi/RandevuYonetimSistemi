<%@ Page Title="" Language="C#" MasterPageFile="~/Onyuz.Master" AutoEventWireup="true" CodeBehind="Signin.aspx.cs" Inherits="RandevuYonetimSistemi.WebFormUI.Signin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="form-signin w-100 m-auto border border-info p-4" style="max-width: 350px">
        <div>
            <img class="mb-4" src="Images/logo-ikon.png" alt="logo" width="72" />
            <h1 class="h3 mb-3 fw-normal">Lütfen Giriş Yapınız</h1>

            <div class="form-floating">
                <input type="email" class="form-control" id="floatingInput" placeholder="name@example.com">
                <label for="floatingInput">Email</label>
            </div>
            <div class="form-floating">
                <input type="password" class="form-control" id="floatingPassword" placeholder="Password">
                <label for="floatingPassword">Parola</label>
            </div>

            <div class="checkbox mb-3">
                <label>
                    <input type="checkbox" value="remember-me">
                    Beni Hatırla
                </label>
            </div>
            <button class="w-100 btn btn-lg btn-primary" type="submit">Giriş Yap</button>
            <p class="mt-5 mb-3 text-muted">© 2022</p>
        </div>
    </main>
</asp:Content>
