﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Libary.BLL;

namespace Libary.UI
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BooksService bookBll = new BooksService();
            this.Repeater1.DataSource = bookBll.GetModelList("");
            this.Repeater1.DataBind();
        }
    }
}