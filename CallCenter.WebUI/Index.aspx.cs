using CallCenter.BLL.Controller;
using CallCenter.Entity;
using CallCenter.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CallCenter.WebUI
{
    public partial class Index : System.Web.UI.Page
    {
        MusteriController _mustController;
        public Index()
        {
            _mustController = new MusteriController();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Helper.FillRepeater<Musteri>(_mustController.GetAllEntities(), rptMusteriler);
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            
            musteri.MusteriAdi = txtAd.Text;
            musteri.MusteriSoyadi = txtSoyad.Text;
            musteri.MusteriTC = txtTc.Text;
            musteri.DogumTarihi = Convert.ToDateTime(txtDogumTarihi.Text);
            _mustController.AddEntity(musteri);
            Response.Redirect("~/Index.aspx");
        }

        protected void rptMusteriler_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Detay":
                    Response.Redirect("~/MusteriDetay.aspx?MusteriID=" + e.CommandArgument);
                    Response.Redirect("~/Index.aspx");
                    break;

                case "Sil":
                    _mustController.DeleteEntity(new Musteri { MusteriID = Convert.ToInt32(e.CommandArgument) });
                    Response.Redirect("~/Index.aspx");
                    break;
            }
        }
    }
}