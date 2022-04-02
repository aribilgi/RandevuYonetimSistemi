<%@ Page Title="Hasta Yönetimi" Language="C#" MasterPageFile="~/AnaEkran.Master" AutoEventWireup="true" CodeBehind="HastaYonetimi.aspx.cs" Inherits="RandevuYonetimSistemi.WebFormUI.HastaYonetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Hasta Yönetimi</h1>
    <asp:GridView ID="dgvHastalar" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="dgvHastalar_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <hr />
    <div>

        <table class="auto-style1">
            <tr>
                <td>Adı</td>
                <td>
                    <asp:TextBox ID="txtAdi" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Soyadı</td>
                <td>
                    <asp:TextBox ID="txtSoyadi" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Tc Numarası</td>
                <td>
                    <asp:TextBox ID="txtTcNo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Yaş</td>
                <td>
                    <asp:TextBox ID="txtYas" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Telefon</td>
                <td>
                    <asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Adres</td>
                <td>
                    <asp:TextBox ID="txtAdres" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Hasta Yakını</td>
                <td>
                    <asp:TextBox ID="txtHastaYakinBilgisi" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Kan Grubu</td>
                <td>
                    <asp:TextBox ID="txtKanGrubu" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Meslek</td>
                <td>
                    <asp:TextBox ID="txtMeslek" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnEkle" runat="server" OnClick="btnEkle_Click" Text="Ekle" />
                    <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" Enabled="False" />
                    <asp:Button ID="btnSil" runat="server" Text="Sil" Enabled="False" />
                </td>
            </tr>
        </table>

    </div>
</asp:Content>
