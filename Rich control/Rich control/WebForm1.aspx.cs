using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rich_control
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach(ListItem li in CheckBoxList1.Items)
            {
                if(li.Selected)
                {
                    sb.Append("course" + li.Value + "<br>");

                }
            }
            Label1.Text = sb.ToString();
        }
    }
}