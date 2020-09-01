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
        int cnt = 0;
        int cnt1 = 0;
       double ans = 0;
        if (CheckBox1.Checked)
        {
            cnt = cnt + 1;

            if (cnt < 3)
            {
                ans = ans + 0.5;

            }
            else
            {
                Label1.Text = "select any two option";
            }
        }

        if (CheckBox2.Checked)
        {
            cnt = cnt + 1;

            if (cnt < 3)
            {
                ans = ans - 0.5;

            }
            else
            {
                Label1.Text = "select any two option";
            }
        }

        if (CheckBox3.Checked)
        {
            cnt = cnt + 1;

            if (cnt < 3)
            {
                ans = ans + 0.5;

            }
            else
            {
                Label1.Text = "select any two option";
            }
        }


        //second ques
        if (CheckBox4.Checked)
        {
            cnt1 = cnt1 + 1;

            if (cnt1 < 3)
            {
                ans = ans - 0.5;

            }
            else
            {
                Label1.Text = "select any two option";
            }
        }
        if (CheckBox5.Checked)
        {
            cnt1 = cnt1 + 1;

            if (cnt1 < 3)
            {
                ans = ans + 0.5;

            }
            else
            {
                Label1.Text = "select any two option";
            }
        }
        if (CheckBox6.Checked)
        {
            cnt1 = cnt1 + 1;

            if (cnt1 < 3)
            {
                ans = ans + 0.5;

            }
            else
            {
                Label1.Text = "select any two option";
            }
        }
        if(cnt<3 &&cnt1<3)
        {
            Label1.Text = "your score:" + ans;
        }
    }
}