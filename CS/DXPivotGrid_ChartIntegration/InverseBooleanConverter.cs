using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace DXPivotGrid_ChartIntegration {
    public class InverseBooleanConverter : MarkupExtension, IValueConverter {
        #region IValueConverter Members
        public object Convert(object value, Type targetType,
                object parameter, CultureInfo culture) {
            return !(bool)value;
        }
        public object ConvertBack(object value, Type targetType,
                object parameter, CultureInfo culture) {
            return !(bool)value;
        }
        #endregion
        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
    }
}
