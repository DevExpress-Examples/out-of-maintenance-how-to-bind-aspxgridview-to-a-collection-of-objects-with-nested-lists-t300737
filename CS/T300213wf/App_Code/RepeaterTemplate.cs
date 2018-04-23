using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public class RepeaterTemplate : ITemplate
{
	public void InstantiateIn(Control c) {
		GridViewDataItemTemplateContainer container = (GridViewDataItemTemplateContainer)c;
		Repeater repeater = new Repeater { ID = "repeater" };
		container.Controls.Add(new Literal { Text="<table class='innerTable'>"});
		container.Controls.Add(repeater);
		container.Controls.Add(new Literal { Text = "</table>" });

		repeater.DataSource = ((Product)container.Grid.GetRow(container.VisibleIndex)).Stores;
		repeater.ItemTemplate = new RepeaterItemTemplate();
	}
}
