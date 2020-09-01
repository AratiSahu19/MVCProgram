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

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int Actno = Convert.ToInt32(TextBox1.Text);
        int amount = Convert.ToInt32(TextBox2.Text);
        int Balance = 1000;
        if(RadioButton1.Checked)
        {
            Balance = Balance + amount;
        }
        else if(RadioButton2.Checked)
                {
            Balance = Balance - amount;
        }
        Label3.Text = "Balance of account no:" + Actno + "is" + Balance.ToString();
    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }
}