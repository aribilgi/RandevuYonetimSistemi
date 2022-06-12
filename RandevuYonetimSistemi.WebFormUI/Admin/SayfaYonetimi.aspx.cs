using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using Entities;

namespace RandevuYonetimSistemi.WebFormUI.Admin
{
    public partial class SayfaYonetimi : System.Web.UI.Page
    {
        PageManager manager = new PageManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            dgvSayfalar.DataSource = manager.GetAll();
            dgvSayfalar.DataBind();
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            var sayfa = new Entities.Page
            {
                CreateDate = DateTime.Now,
                IsActive = cbIsActive.Checked,
                IsTopMenu = cbIsTopMenu.Checked,
                Name = txtName.Text,
                PageContent = txtPageContent.Text
            };
            if (fuImage.HasFile) // eğer resim yüklenecekse
            {
                fuImage.SaveAs(Server.MapPath("/Images/" + fuImage.FileName));
                sayfa.Image = fuImage.FileName;
            }
            var sonuc = manager.Add(sayfa);
            if (sonuc > 0)
            {
                Response.Redirect("SayfaYonetimi.aspx");
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        protected void btnSil_Click(object sender, EventArgs e)
        {

        }
    }
}