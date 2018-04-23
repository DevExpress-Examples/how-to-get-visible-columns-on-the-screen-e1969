' Developer Express Code Central Example:
' How to get visible columns on the screen
' 
' Handle the GridControl.ScrollChanged event. In this event handler, check whether
' the column header location is inside the visible area.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1969


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
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()

			Dim list As New List(Of TestData)()
			'for(int i = 0; i < 100; i++)
				'list.Add(new TestData() { Text = "Row" + i, Number = i, Group = i % 3 });
			gridControl1.ItemsSource = list
		End Sub

		Private Sub gridControl1_ScrollChanged(ByVal sender As Object, ByVal e As ScrollChangedEventArgs)
			Dim list As New List(Of GridColumn)()

			Dim offset As Double = 0
			For Each column As GridColumn In view.VisibleColumns
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
		Private privateColumn0 As String
		Public Property Column0() As String
			Get
				Return privateColumn0
			End Get
			Set(ByVal value As String)
				privateColumn0 = value
			End Set
		End Property
		Private privateColumn1 As String
		Public Property Column1() As String
			Get
				Return privateColumn1
			End Get
			Set(ByVal value As String)
				privateColumn1 = value
			End Set
		End Property
		Private privateColumn2 As String
		Public Property Column2() As String
			Get
				Return privateColumn2
			End Get
			Set(ByVal value As String)
				privateColumn2 = value
			End Set
		End Property
		Private privateColumn3 As String
		Public Property Column3() As String
			Get
				Return privateColumn3
			End Get
			Set(ByVal value As String)
				privateColumn3 = value
			End Set
		End Property
		Private privateColumn4 As String
		Public Property Column4() As String
			Get
				Return privateColumn4
			End Get
			Set(ByVal value As String)
				privateColumn4 = value
			End Set
		End Property
		Private privateColumn5 As String
		Public Property Column5() As String
			Get
				Return privateColumn5
			End Get
			Set(ByVal value As String)
				privateColumn5 = value
			End Set
		End Property
		Private privateColumn6 As String
		Public Property Column6() As String
			Get
				Return privateColumn6
			End Get
			Set(ByVal value As String)
				privateColumn6 = value
			End Set
		End Property
		Private privateColumn7 As String
		Public Property Column7() As String
			Get
				Return privateColumn7
			End Get
			Set(ByVal value As String)
				privateColumn7 = value
			End Set
		End Property
		Private privateColumn8 As String
		Public Property Column8() As String
			Get
				Return privateColumn8
			End Get
			Set(ByVal value As String)
				privateColumn8 = value
			End Set
		End Property
		Private privateColumn9 As String
		Public Property Column9() As String
			Get
				Return privateColumn9
			End Get
			Set(ByVal value As String)
				privateColumn9 = value
			End Set
		End Property
	End Class
End Namespace
