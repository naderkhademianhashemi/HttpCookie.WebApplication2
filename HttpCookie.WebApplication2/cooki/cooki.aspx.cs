using System;
using System.Collections.Generic;
using System.Linq;
using Web = System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web;

namespace HttpCookie.WebApplication2.cooki
{
    public partial class cooki : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cookies["userName"].Value = "Annathurai";
            Response.Cookies["id"].Value = "1";
            var x = Request.Cookies["userName"].Value;
            var c = HttpContext.Current.Request.Cookies["userName"].Value;
            var id = int.Parse(Request.Cookies["id"].Value);
            Response.Write(id+1);
        }
    }
}