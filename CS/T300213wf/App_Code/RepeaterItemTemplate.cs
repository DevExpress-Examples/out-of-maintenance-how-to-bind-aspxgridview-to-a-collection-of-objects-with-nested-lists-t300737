using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

class RepeaterItemTemplate : ITemplate
{
	public void InstantiateIn(Control container) {
		HtmlTableRow row = new HtmlTableRow();
		container.Controls.Add(row);
		row.DataBinding += row_DataBinding;
	}

	void row_DataBinding(object sender, EventArgs e) {
		HtmlTableRow row = (HtmlTableRow)sender;
		RepeaterItem item = (RepeaterItem)row.NamingContainer;
		string name = DataBinder.Eval(item.DataItem, "Name") as string;
		HtmlTableCell cell = new HtmlTableCell { InnerText = name };
		string classes = "dxgv";
		List<Store> list = (List<Store>)((Repeater)item.NamingContainer).DataSource;
		if (list.Count == item.ItemIndex + 1)
			classes += " lastCell";
		cell.Attributes.Add("class", classes);
		row.Cells.Add(cell);
	}
}
