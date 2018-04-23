Imports DevExpress.Web
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Public Property Source() As List(Of Product)
        Get
            Dim list As List(Of Product) = TryCast(Session("source"), List(Of Product))
            If list Is Nothing Then
                list = New List(Of Product)()
                For i As Integer = 0 To 9
                    Dim product As New Product()
                    product.Id = i
                    product.Name = "Name" & i
                    For j As Integer = 0 To 4
                        product.Stores.Add(New Store With {.Id = j, .Name = String.Format("Store{0}-{1}", i, j)})
                    Next j
                    list.Add(product)
                Next i

                Session("source") = list
            End If

            Return list
        End Get
        Set(ByVal value As List(Of Product))
            Session("source") = value
        End Set
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
    End Sub
    Protected Sub ASPxGridView1_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim grid As ASPxGridView = DirectCast(sender, ASPxGridView)
        If Not IsPostBack Then
            grid.DataBind()
        End If

        TryCast(grid.Columns("Stores"), GridViewDataColumn).DataItemTemplate = New RepeaterTemplate()
    End Sub
    Protected Sub ASPxGridView1_DataBinding(ByVal sender As Object, ByVal e As EventArgs)
        Dim grid As ASPxGridView = DirectCast(sender, ASPxGridView)
        grid.DataSource = Source
    End Sub
End Class