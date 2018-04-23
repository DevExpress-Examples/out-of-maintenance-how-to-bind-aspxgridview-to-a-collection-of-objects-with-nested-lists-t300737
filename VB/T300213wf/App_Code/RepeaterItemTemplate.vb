Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls

Friend Class RepeaterItemTemplate
    Implements ITemplate

    Public Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
        Dim row As New HtmlTableRow()
        container.Controls.Add(row)
        AddHandler row.DataBinding, AddressOf row_DataBinding
    End Sub

    Private Sub row_DataBinding(ByVal sender As Object, ByVal e As EventArgs)
        Dim row As HtmlTableRow = DirectCast(sender, HtmlTableRow)
        Dim item As RepeaterItem = CType(row.NamingContainer, RepeaterItem)
        Dim name As String = TryCast(DataBinder.Eval(item.DataItem, "Name"), String)
        Dim cell As HtmlTableCell = New HtmlTableCell With {.InnerText = name}
        Dim classes As String = "dxgv"
        Dim list As List(Of Store) = DirectCast(CType(item.NamingContainer, Repeater).DataSource, List(Of Store))
        If list.Count = item.ItemIndex + 1 Then
            classes &= " lastCell"
        End If
        cell.Attributes.Add("class", classes)
        row.Cells.Add(cell)
    End Sub
End Class
