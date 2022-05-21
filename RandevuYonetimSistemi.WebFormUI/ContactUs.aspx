<%@ Page Title="" Language="C#" MasterPageFile="~/Onyuz.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="RandevuYonetimSistemi.WebFormUI.ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <h4 class="mb-3">İletişim</h4>
            <hr />
            <div class="col">
                <h5>Bize Ulaşın</h5>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Panel ID="pnlForm" runat="server">
                            <asp:TextBox ID="txtName" runat="server" CssClass="form-control mt-3" placeholder="Adınız.. " required></asp:TextBox>
                            <asp:TextBox ID="txtSurname" runat="server" CssClass="form-control mt-3" placeholder="Soyadınız.. " required></asp:TextBox>
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control mt-3" placeholder="Email.. "></asp:TextBox>
                            <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control mt-3" placeholder="Telefon.. "></asp:TextBox>
                            <asp:TextBox ID="txtMessage" runat="server" CssClass="form-control mt-3" placeholder="Mesajınız.. " TextMode="MultiLine" required></asp:TextBox>
                            <div class="col text-center mt-3">
                                <asp:Button ID="btnGonder" runat="server" Text="Gönder" CssClass="btn btn-primary" OnClick="btnGonder_Click" />
                            </div>
                        </asp:Panel>
                        <asp:Panel ID="pnlMesaj" runat="server" CssClass="" Visible="false">
                            <div></div>
                            <asp:Literal ID="ltMesaj" runat="server"></asp:Literal>
                        </asp:Panel>
                    </ContentTemplate>
                </asp:UpdatePanel>

            </div>
            <div class="col">
                <h5>Adresimiz</h5>
                <address>
                    Doğu Mah. Gazi Paşa Cad. Ihlamur Sok. Has iş Merkezi No: 28 kat: 4
                    <br />
                    Pendik / İstanbul
                </address>
                <p>
                    Telefon : 0216-491-4274
                </p>
            </div>
            <div class="col">
                <h5>Harita</h5>
                <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3016.6647909984836!2d29.233057000000002!3d40.87923!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xa053e0b7ec57d6!2sAr%C4%B1%20Bilgi%20Bili%C5%9Fim%20Teknolojileri%20Akademisi!5e0!3m2!1str!2sus!4v1653144698005!5m2!1str!2sus" width="400" height="300" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
            </div>
        </div>
    </div>
</asp:Content>
