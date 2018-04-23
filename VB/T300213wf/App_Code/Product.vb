Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class Product
    Public Property Id() As Integer
    Public Property Name() As String
    Public Property Stores() As List(Of Store)

    Public Sub New()
        Stores = New List(Of Store)()
    End Sub
End Class
