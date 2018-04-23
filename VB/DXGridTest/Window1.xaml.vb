Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Utils.Themes
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Core
Imports System.Collections
Imports System.Windows.Threading

Namespace DXGridTest
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Public Partial Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()

			Dim list As List(Of TestData) = New List(Of TestData)()
			'for(int i = 0; i < 100; i++)
				'list.Add(new TestData() { Text = "Row" + i, Number = i, Group = i % 3 });
			gridControl1.DataSource = list
		End Sub

		Private Sub gridControl1_ScrollChanged(ByVal sender As Object, ByVal e As ScrollChangedEventArgs)
			Dim list As List(Of GridColumn) = New List(Of GridColumn)()

			Dim offset As Double = 0
			For Each column As GridColumn In gridControl1.View.VisibleColumns
				offset += column.ActualHeaderWidth
				If offset < e.HorizontalOffset Then
					Continue For
				End If
				list.Add(column)
				If offset > e.HorizontalOffset + e.ViewportWidth Then
					Exit For
				End If
			Next column
			listBox.ItemsSource = list
		End Sub
	End Class

	Public Class TestData
        Private _Column0 As String
        Public Property Column0() As String
            Get
                Return _Column0
            End Get
            Set(ByVal value As String)
                _Column0 = value
            End Set
        End Property

        Private _Column1 As String
        Public Property Column1() As String
            Get
                Return _Column1
            End Get
            Set(ByVal value As String)
                _Column1 = value
            End Set
        End Property

        Private _Column2 As String
        Public Property Column2() As String
            Get
                Return _Column2
            End Get
            Set(ByVal value As String)
                _Column2 = value
            End Set
        End Property

        Private _Column3 As String
        Public Property Column3() As String
            Get
                Return _Column3
            End Get
            Set(ByVal value As String)
                _Column3 = value
            End Set
        End Property

        Private _Column4 As String
        Public Property Column4() As String
            Get
                Return _Column4
            End Get
            Set(ByVal value As String)
                _Column4 = value
            End Set
        End Property

        Private _Column5 As String
        Public Property Column5() As String
            Get
                Return _Column5
            End Get
            Set(ByVal value As String)
                _Column5 = value
            End Set
        End Property

        Private _Column6 As String
        Public Property Column6() As String
            Get
                Return _Column6
            End Get
            Set(ByVal value As String)
                _Column6 = value
            End Set
        End Property

        Private _Column7 As String
        Public Property Column7() As String
            Get
                Return _Column7
            End Get
            Set(ByVal value As String)
                _Column7 = value
            End Set
        End Property

        Private _Column8 As String
        Public Property Column8() As String
            Get
                Return _Column8
            End Get
            Set(ByVal value As String)
                _Column8 = value
            End Set
        End Property

        Private _Column9 As String 
        Public Property Column9() As String
            Get
                Return _Column9
            End Get
            Set(ByVal value As String)
                _Column9 = value
            End Set
        End Property
    End Class
End Namespace

