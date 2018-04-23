using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

	public List<Product> Source {
		get {
			List<Product> list = Session["source"] as List<Product>;
			if (list == null) {
				list = new List<Product>();
				for (int i = 0; i < 10; i++) {
					Product product = new Product();
					product.Id = i;
					product.Name = "Name" + i;
					for (int j = 0; j < 5; j++)
						product.Stores.Add(new Store { Id = j, Name = string.Format("Store{0}-{1}", i, j) });
					list.Add(product);
				}

				Session["source"] = list;
			}

			return list;
		}
		set { Session["source"] = value; }
	}

	protected void Page_Load(object sender, EventArgs e) {
	}
	protected void ASPxGridView1_Load(object sender, EventArgs e) {
		ASPxGridView grid = (ASPxGridView)sender;
		if (!IsPostBack)
			grid.DataBind();

		(grid.Columns["Stores"] as GridViewDataColumn).DataItemTemplate = new RepeaterTemplate();
	}
	protected void ASPxGridView1_DataBinding(object sender, EventArgs e) {
		ASPxGridView grid = (ASPxGridView)sender;
		grid.DataSource = Source;
	}
}