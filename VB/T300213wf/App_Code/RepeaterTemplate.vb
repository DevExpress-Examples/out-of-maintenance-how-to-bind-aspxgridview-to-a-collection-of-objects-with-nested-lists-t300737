Imports DevExpress.Web
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls

Public Class RepeaterTemplate
    Implements ITemplate

    Public Sub InstantiateIn(ByVal c As Control) Implements ITemplate.InstantiateIn
        Dim container As GridViewDataItemTemplateContainer = CType(c, GridViewDataItemTemplateContainer)
        Dim repeater As Repeater = New Repeater With {.ID = "repeater"}
        container.Controls.Add(New Literal With {.Text="<table class='innerTable'>"})
        container.Controls.Add(repeater)
        container.Controls.Add(New Literal With {.Text = "</table>"})

        repeater.DataSource = CType(container.Grid.GetRow(container.VisibleIndex), Product).Stores
        repeater.ItemTemplate = New RepeaterItemTemplate()
    End Sub
End Class
