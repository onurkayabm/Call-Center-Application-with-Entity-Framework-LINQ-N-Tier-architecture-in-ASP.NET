using CallCenter.BLL.Controller;
using CallCenter.Entity;
using CallCenter.Entity.Model;
using CallCenter.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CallCenter.WebUI
{
    public partial class MusteriDetay : System.Web.UI.Page
    {
        private Musteri _musteri;

        MusteriController _mustController;
        AdresController _adrescontroller;
        TelefonController _telefonController;
        MailController _mailController;

        public MusteriDetay()
        {
            _mustController = new MusteriController();
            _adrescontroller = new AdresController();
            _telefonController = new TelefonController();
            _mailController = new MailController();
          
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(Request.QueryString["MusteriID"]))
            {
                Response.Redirect("~/Index.aspx");
            }
            _musteri = _mustController.GetByIDEntities(Convert.ToInt32(Request.QueryString["MusteriID"]));
            Helper.FillRepeater<Telefon>(_musteri.Telefonlar, rptTelefonlar);
            Helper.FillRepeater<Adres>(_musteri.Adresler, rptAdresler);
            Helper.FillRepeater<Mail>(_musteri.Mailler, rptMailler);

            ltMusteriAdi.Text = _musteri.MusteriAdi+ " "+ _musteri.MusteriSoyadi;

            txtAd.Text = _musteri.MusteriAdi;
            txtSoyad.Text = _musteri.MusteriSoyadi;
            txtTc.Text = _musteri.MusteriTC;
            txtDogumTarihi.Text = _musteri.DogumTarihi.Year.ToString() + "-" + _musteri.DogumTarihi.Month.ToString() + "-" + _musteri.DogumTarihi.Day.ToString();
        }

        protected void btnTelefonKaydet_Click(object sender, EventArgs e)
        {
            _telefonController.AddEntity(new Telefon { TelefonNumarasi = txtTelefon.Text,MusteriID=_musteri.MusteriID });

            Response.Redirect("~/MusteriDetay.aspx?MusteriID=" + _musteri.MusteriID);

        }

        protected void btnMailKaydet_Click(object sender, EventArgs e)
        {
            _mailController.AddEntity(new Mail { MailAdresi = txtMail.Text, MusteriID = _musteri.MusteriID });

            Response.Redirect("~/MusteriDetay.aspx?MusteriID=" + _musteri.MusteriID);
        }

        protected void btnAdresKaydet_Click(object sender, EventArgs e)
        {
            _adrescontroller.AddEntity(new Adres { Adresi = txtAdres.Text, MusteriID = _musteri.MusteriID });

            Response.Redirect("~/MusteriDetay.aspx?MusteriID=" + _musteri.MusteriID);
        }

        protected void rptTelefonlar_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Sil")
            {
                _telefonController.DeleteEntity(new Telefon { TelefonID=Convert.ToInt32(e.CommandArgument)});
            
                Response.Redirect("~/MusteriDetay.aspx?MusteriID="+_musteri.MusteriID);
            }
        }

        protected void rptMailler_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Sil")
            {
                _mailController.DeleteEntity(new Mail { MailID = Convert.ToInt32(e.CommandArgument) });

                Response.Redirect("~/MusteriDetay.aspx?MusteriID=" + _musteri.MusteriID);
            }
        }

        protected void rptAdresler_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Sil")
            {
                _adrescontroller.DeleteEntity(new Adres { AdresID = Convert.ToInt32(e.CommandArgument) });

                Response.Redirect("~/MusteriDetay.aspx?MusteriID=" + _musteri.MusteriID);
            }
        }

        protected void btnGeri_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Index.aspx");
        }
    }
}