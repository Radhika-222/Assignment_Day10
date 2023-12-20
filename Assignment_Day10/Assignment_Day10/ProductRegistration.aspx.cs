using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_Day10
{
    public partial class ProductRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            LblMsg.Visible = false;
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            LblMsg.Visible = true;
            LblMsg.Text = "Product Name: " + TextBox1.Text;
            LblMsg.Text += "<br/> Product Category: " + DdlCategory.Text;
            LblMsg.Text += "<br/> Product Price: " + TxtPrice.Text;
            LblMsg.Text += "<br/> Product Description: " + TxtDesc.Text;
            LblMsg.Text += "<br/> Release Date: " + CalRelDate.SelectedDate.ToShortDateString();
            LblMsg.Text += "<br/> SuccessFul Registration!!!";
        }
    }
}