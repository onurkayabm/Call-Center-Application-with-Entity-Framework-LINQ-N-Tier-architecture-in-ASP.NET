using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CallCenter.Extension
{
    public class Helper
    {
        public static void MesajGoster(Page targetPage, string message)
        {

            Literal ltr = new Literal();
            ltr.Text = "<script type=\"text/javascript\">alert('" + message + "')</script>";
            targetPage.Header.Controls.Add(ltr);

        }
        public static void BindDropDownList<T>(ICollection<T> _sourceList, DropDownList _dropDownList, string _dataValuesField, string _dataTextField)
        {

            _dropDownList.DataSource = _sourceList;
            _dropDownList.DataValueField = _dataValuesField;
            _dropDownList.DataTextField = _dataTextField;
            _dropDownList.DataBind();
        }

        public static void BindDataControl<T>(ICollection<T> _sourceList, BaseDataBoundControl _dataControl)
        {
            _dataControl.DataSource = _sourceList;
            _dataControl.DataBind();
        }

        public static void FillRepeater<T>(ICollection<T> _sourceList, Repeater _rpt)
        {
            _rpt.DataSource = _sourceList;
            _rpt.DataBind();
        }



        public static string GeneralMessageDynamic<T>(T item)
        {
            string message = "";
            foreach (var prop in item.GetType().GetProperties())
            {
                if (prop.Name == "MessagePath")
                {
                    message = prop.GetValue(item, null).ToString();
                }
                else if (prop.Name == "MessageText")
                {
                    message += "path'inde beklenmedik bir durum ile karşılaşıldı:" + prop.GetValue(item, null).ToString();
                }
            }
            return message;
        }

    }
}
