using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using FastConsig.Core.Web.Helpers;

namespace FastConsig.Core.Web
{
    public partial class PaginaNaoEncontrada : Page
    {
        protected void Page_Init(object Sender, EventArgs e)
        {
            base.OnPreInit(e);

            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetNoStore();
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            string disabledScript = "<script language=\"javascript\">\r\nwindow.history.forward(1);\r\n</script>";
            ClientScript.RegisterClientScriptBlock(this.Page.GetType(), "clientScript", disabledScript);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Session.Abandon();
        }
    }
}