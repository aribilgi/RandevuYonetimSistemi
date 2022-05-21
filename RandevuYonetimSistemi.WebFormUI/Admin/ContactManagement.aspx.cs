using System;
using BL;
using Entities;

namespace RandevuYonetimSistemi.WebFormUI.Admin
{
    public partial class ContactManagement : System.Web.UI.Page
    {
        ContactManager contactManager = new ContactManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            dgvContacts.DataSource = contactManager.GetAll();
            dgvContacts.DataBind();
        }
    }
}               