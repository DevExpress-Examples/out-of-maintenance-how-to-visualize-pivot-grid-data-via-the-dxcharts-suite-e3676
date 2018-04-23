Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Reflection
Imports System.Windows.Controls
Imports System.Xml.Serialization

Namespace DXPivotGrid_ChartIntegration
	Partial Public Class MainPage
		Inherits UserControl
		Private dataFileName As String = "DXPivotGrid_ChartIntegration.nwind.xml"
		Public Sub New()
			InitializeComponent()

			' Parses an XML file and creates a collection of data items.
			Dim [assembly] As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
			Dim stream As Stream = [assembly].GetManifestResourceStream(dataFileName)
			Dim s As New XmlSerializer(GetType(OrderData))
			Dim dataSource As Object = s.Deserialize(stream)

			' Binds a pivot grid to this collection.
			pivotGridControl1.DataSource = dataSource
		End Sub
	End Class
End Namespace