using eVent.Dal;
using System;

namespace eVent
{
    public partial class ObrisiKorisnika : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = int.Parse(Request.QueryString["id"]);
            RepositoryFactory.GetRepository().DeleteKorisnik(i);
            Response.Redirect("PocetnaStrana.aspx");
        }
    }
}