using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(UNIVERSITY.ActiveViewIndex==0)
            {
            UNIVERSITY.ActiveViewIndex = 1;
        }
        else
        {
            UNIVERSITY.ActiveViewIndex = 0;
        }
    }

    protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
    {

    }

    protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.Append("Username" + TextBox1.Text + "<br>");
        sb.Append("Password" + TextBox2.Text + "<br>");
        sb.Append("Submit" + TextBox3.Text + "<br>");
        Label1.Text = sb.ToString();


    }
}