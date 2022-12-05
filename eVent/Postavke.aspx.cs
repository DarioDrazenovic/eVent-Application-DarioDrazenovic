using DevExpress.Utils.CommonDialogs.Internal;
using eVent.Dal;
using eVent.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Xceed.Wpf.Toolkit;

namespace eVent
{
    public partial class Postavke : Localization
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection("server=tcp:oicarserver.database.windows.net;database=eVent;Uid=oicartim15@oicarserver;Pwd=eVent123");


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loggedIn"] == null || (bool)Session["loggedIn"] != true)
            {
                Response.Redirect("Login.aspx");
            }

            if (!IsPostBack)
            {
                ddlJezik.SelectedIndex = DDLIndexJezik;
            }
        }

        protected void ddlJezik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlJezik.SelectedValue != "0")
            {
                string jezik = ddlJezik.SelectedValue;

                HttpCookie cookie = new HttpCookie(name: "jezik");
                cookie.Expires.AddDays(10);
                cookie["name"] = jezik;
                cookie["index"] = ((DropDownList)sender).SelectedIndex.ToString();
                Response.Cookies.Add(cookie);
                Response.Redirect(Request.Url.LocalPath);
            }
        }

        protected void btnDelUsr_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Are you sure?", "Delete message", MessageBoxButtons.YesNo);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                RepositoryFactory.GetRepository().DeleteKorisnik(int.Parse(Session["loggedInUserID"].ToString())); 
                Session["loggedIn"] = null;
                Response.Redirect("PocetnaStrana.aspx");
            }
            else if (dialogResult == System.Windows.Forms.DialogResult.No)
            {
                Response.Redirect("Postavke.aspx");
            }
            
        }
    }
}