using eVent.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eVent
{
    public partial class BrisanjeDogadaja : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = int.Parse(Request.QueryString["id"]);
            RepositoryFactory.GetRepository().DeleteDogadaj(i);
            Response.Redirect("MojiDogadaji.aspx");
        }
    }
}