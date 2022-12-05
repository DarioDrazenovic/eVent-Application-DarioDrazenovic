using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;

namespace eVent.Models
{
    public class Localization : System.Web.UI.Page
    {
        public int DDLIndexJezik
        {
            get
            {
                if (Request.Cookies["jezik"] != null)
                {
                    if (Request.Cookies["jezik"]["index"] != null)
                    {
                        return int.Parse(Request.Cookies["jezik"]["index"]);
                    }
                }
                return 0;
            }
            set
            {
                Request.Cookies["jezik"]["index"] = value.ToString();
            }
        }


        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);
        }

        protected override void InitializeCulture()
        {
            if (Request.Cookies["jezik"] != null)
            {
                if (Request.Cookies["jezik"]["name"] != null)
                {
                    string culture = Request.Cookies["jezik"]["name"];
                    Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
                }
            }
            base.InitializeCulture();
        }
    }
}