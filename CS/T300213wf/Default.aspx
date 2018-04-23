<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
	<style type="text/css">
		.innerTable {
			width:100%;
			border-collapse: collapse;
		}

		.innerTable tr td.dxgv {
			border-right: none;
		}

		.innerTable tr td.lastCell.dxgv{
			border-bottom: none;
		}
		table tr td.storesCell.dxgv{
			padding:0px;
		}
	</style>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<dx:ASPxGridView ID="ASPxGridView1" runat="server" KeyFieldName="Id" OnLoad="ASPxGridView1_Load" OnDataBinding="ASPxGridView1_DataBinding">
				<Columns>
					<dx:GridViewDataColumn FieldName="Id"></dx:GridViewDataColumn>
					<dx:GridViewDataColumn FieldName="Name"></dx:GridViewDataColumn>
					<dx:GridViewDataColumn FieldName="Stores" UnboundType="Object">
						<CellStyle CssClass="storesCell"></CellStyle>
					</dx:GridViewDataColumn>
				</Columns>
			</dx:ASPxGridView>
		</div>
	</form>
</body>
</html>
