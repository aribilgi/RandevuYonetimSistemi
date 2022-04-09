<%@ Page Title="" Language="C#" MasterPageFile="~/AnaEkran.Master" AutoEventWireup="true" CodeBehind="RandevuYonetimi.aspx.cs" Inherits="RandevuYonetimSistemi.WebFormUI.RandevuYonetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Randevu Yönetimi</h1>
    <asp:GridView ID="dgvRandevular" runat="server"></asp:GridView>
    <hr />
    <div>

    </div>
</asp:Content>
