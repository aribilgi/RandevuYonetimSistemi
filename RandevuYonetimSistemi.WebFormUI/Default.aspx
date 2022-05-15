<%@ Page Title="" Language="C#" MasterPageFile="~/Onyuz.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RandevuYonetimSistemi.WebFormUI.Default1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="px-4 py-5 my-5 text-center">
        <img class="d-block mx-auto mb-4" src="Images/logo-ikon.png" alt="Arı Sağlık Grubu" width="72">
        <h1 class="display-5 fw-bold">Arı Sağlık Grubu</h1>
        <div class="col-lg-6 mx-auto">
            <p class="lead mb-4">
                Arı Sağlık grubuna hoş geldiniz.
                Doktorlarımız her türlü sağlık hizmeti ihtiyacınız için sizlerin hizmetindedir.
            </p>
            <div class="d-grid gap-2 d-sm-flex justify-content-sm-center">
                <button type="button" class="btn btn-primary btn-lg px-4 gap-3">Randevu Al</button>
                <button type="button" class="btn btn-outline-secondary btn-lg px-4">Bilgi Al</button>
            </div>
        </div>
    </div>
</asp:Content>
