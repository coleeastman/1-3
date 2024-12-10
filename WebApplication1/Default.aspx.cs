using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.MyServiceRef1;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtInput1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtInput1.Text);
            int y = Convert.ToInt32(txtInput2.Text);
            int z = x + y;
            addResult.Text = Convert.ToString(z);
        }

        protected void btnC2f_Click(object sender, EventArgs e)
        {
            MyServiceRef1.Service1Client prxy = new MyServiceRef1.Service1Client();
            String s = txtInput3.Text;
            Int32 x = prxy.C2f(Convert.ToInt32(s));
            c2fResult.Text = Convert.ToString(x);
        }

        protected void btnF2c_Click(object sender, EventArgs e)
        {
            MyServiceRef1.Service1Client prxy = new MyServiceRef1.Service1Client();
            String s = txtInput4.Text;
            Int32 x = prxy.F2c(Convert.ToInt32(s));
            f2cResult.Text = Convert.ToString(x);
        }

        protected void btnSort_Click(object sender, EventArgs e)
        {
            MyServiceRef1.Service1Client prxy = new MyServiceRef1.Service1Client();
            String s = txtInput5.Text;
            String x = prxy.Sort(s);
            sortResult.Text = x;
        }

    }
}