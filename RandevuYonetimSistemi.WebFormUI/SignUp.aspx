<%@ Page Title="" Language="C#" MasterPageFile="~/Onyuz.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="RandevuYonetimSistemi.WebFormUI.SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <asp:Literal ID="ltMesaj" runat="server"></asp:Literal>
            <div class="col-md-7 col-lg-8" id="kayitFormu" runat="server">
                <h4 class="mb-3">Kayıt Ol</h4>
                <div class="needs-validation">
                    <div class="row g-3">
                        <div class="col-sm-6">
                            <label for="txtAdi" class="form-label">Adınız</label>
                            <input type="text" class="form-control" id="txtAdi" runat="server" placeholder="Adınız" value="" required="">
                            <div class="invalid-feedback">
                                Zorunlu Alan.
                            </div>
                        </div>

                        <div class="col-sm-6">
                            <label for="txtSoyadi" class="form-label">Soyadınız</label>
                            <input type="text" class="form-control" id="txtSoyadi" runat="server" placeholder="Soyadınız" value="" required="">
                            <div class="invalid-feedback">
                                Zorunlu Alan.
                            </div>
                        </div>

                        <div class="col-12">
                            <label for="txtTcNo" class="form-label">TC Numarası</label>
                            <div class="input-group has-validation">
                                <input type="text" class="form-control" id="txtTcNo" runat="server" placeholder="TC Numarası" required="">
                                <div class="invalid-feedback">
                                    Zorunlu Alan.
                                </div>
                            </div>
                        </div>

                        <div class="col-12">
                            <label for="txtEmail" class="form-label">Email <span class="text-muted">(Opsiyonel)</span></label>
                            <input type="email" class="form-control" id="txtEmail" runat="server" placeholder="email@example.com">
                        </div>

                        <div class="col-12">
                            <label for="txtTelefon" class="form-label">Telefon</label>
                            <input type="text" class="form-control" id="txtTelefon" runat="server" placeholder="Telefon" required="">
                            <div class="invalid-feedback">
                                Zorunlu Alan.
                            </div>
                        </div>

                        <div class="col-12">
                            <label for="txtAdres" class="form-label">Adres</label>
                            <input type="text" class="form-control" id="txtAdres" runat="server" placeholder="Adres Giriniz">
                        </div>

                        <div class="col-12">
                            <label for="address2" class="form-label">Hasta Yakını</label>
                            <input type="text" class="form-control" id="txtHastaYakinBilgisi" runat="server" placeholder="Hasta Yakın Bilgisi">
                        </div>

                        <div class="col-md-4">
                            <label for="txtKanGrubu" class="form-label">Kan Grubu</label>
                            <input type="text" class="form-control" id="txtKanGrubu" runat="server" placeholder="Kan Grubunuz">
                        </div>

                        <div class="col-md-4">
                            <label for="txtMeslek" class="form-label">Meslek</label>
                            <input type="text" class="form-control" id="txtMeslek" runat="server" placeholder="Mesleğiniz">
                        </div>

                        <div class="col-md-4">
                            <label for="txtYas" class="form-label">Yaşınız</label>
                            <input type="text" class="form-control" id="txtYas" runat="server" placeholder="Yaşınız" required="">
                            <div class="invalid-feedback">
                                Zorunlu Alan.
                            </div>
                        </div>

                    </div>

                    <hr class="my-4">

                    <div class="form-check">
                        <input type="checkbox" class="form-check-input" id="cbSozlesme" runat="server">
                        <label class="form-check-label" for="same-address">Üye Olarak Sözleşmeyi Kabul Ediyorum</label>
                    </div>

                    <div class="form-check">
                        <input type="checkbox" class="form-check-input" id="cbBilgiOnay" runat="server">
                        <label class="form-check-label" for="save-info">Firmanın Bilgilerimi Kullanmasını Onaylıyorum</label>
                    </div>

                    <hr class="my-4">

                    <asp:Button ID="btnKaydet" runat="server" Text="Kaydı Tamamla" CssClass="w-100 btn btn-primary btn-lg" OnClick="btnKaydet_Click" />

                </div>
            </div>
        </div>
    </div>
</asp:Content>
