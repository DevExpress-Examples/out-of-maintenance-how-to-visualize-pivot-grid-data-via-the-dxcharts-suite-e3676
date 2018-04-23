Imports Microsoft.VisualBasic
Imports System
Imports System.Globalization
Imports System.Windows.Data
Imports System.Windows.Markup

Namespace DXPivotGrid_ChartIntegration
	Public Class InverseBooleanConverter
		Inherits MarkupExtension
		Implements IValueConverter
		#Region "IValueConverter Members"
		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
			Return Not CBool(value)
		End Function
		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
			Return Not CBool(value)
		End Function
		#End Region
		Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
			Return Me
		End Function
	End Class
End Namespace
