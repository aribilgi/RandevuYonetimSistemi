<%@ Page Title="" Language="C#" MasterPageFile="~/AnaEkran.Master" AutoEventWireup="true" CodeBehind="RandevuYonetimi.aspx.cs" Inherits="RandevuYonetimSistemi.WebFormUI.RandevuYonetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Randevu Yönetimi</h1>
    <asp:GridView ID="dgvRandevular" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="dgvRandevular_SelectedIndexChanged">
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
                <td>Hasta Adı</td>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            <asp:DropDownList ID="cbHastalar" runat="server" DataTextField="Adi" DataValueField="Id" AutoPostBack="True" OnSelectedIndexChanged="cbHastalar_SelectedIndexChanged">
                            </asp:DropDownList>
                            <asp:Literal ID="ltHastaDetay" runat="server"></asp:Literal>
                        </ContentTemplate>
                    </asp:UpdatePanel>

                </td>
            </tr>
            <tr>
                <td>Doktor</td>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:DropDownList ID="cbDoktorlar" runat="server" AutoPostBack="True" DataTextField="Adi" DataValueField="Id" OnSelectedIndexChanged="cbDoktorlar_SelectedIndexChanged">
                            </asp:DropDownList>
                            <asp:Literal ID="ltDoktorDetay" runat="server"></asp:Literal>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td>Kronik Hastalığı var mı?</td>
                <td>
                    <asp:CheckBox ID="cbKronikHastalik" runat="server" />
                </td>
            </tr>
            <tr>
                <td>Sgk var Mı?</td>
                <td>
                    <asp:CheckBox ID="cbSgk" runat="server" />
                </td>
            </tr>
            <tr>
                <td>Randevu Tarihi</td>
                <td>
                    <asp:Calendar ID="dtpRandevuTarihi" runat="server"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td>Hastanın Şikayeti</td>
                <td>
                    <asp:TextBox ID="txtSikayet" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnEkle" runat="server" OnClick="btnEkle_Click" Text="Ekle" />
                    <asp:Button ID="btnGuncelle" runat="server" Enabled="False" OnClick="btnGuncelle_Click" Text="Güncelle" />
                    <asp:Button ID="btnSil" runat="server" Enabled="False" Text="Sil" OnClick="btnSil_Click" />
                </td>
            </tr>
        </table>

    </div>
</asp:Content>
