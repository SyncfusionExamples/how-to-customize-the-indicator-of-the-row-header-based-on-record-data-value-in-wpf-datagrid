# How to customize the indicator of the Row header based on record data value in WPF DataGrid(SfDataGrid)?

This sample show cases how to customize the indicator of the Row header based on record data value in [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid)?

# About the sample

You can change the row indicator based on data by customizing the ControlTemplate of [Syncfusion.GridRowHeaderCell](https://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfGrid.WPF~Syncfusion.UI.Xaml.Grid.GridRowHeaderCell.html?_ga=2.200465709.241783780.1597639152-393461464.1573033696) in [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid).

```xml
<Window.Resources>
    <local:RowIndicatorConverter x:Key="converter"/>
    <Style TargetType="syncfusion:GridRowHeaderCell">
        <Setter Property="Template">
            <Setter.Value>
                <ControlTemplate TargetType="syncfusion:GridRowHeaderCell">
                    <Border x:Name="PART_RowHeaderCellBorder"
                        Background="{TemplateBinding Background}"
                        BorderBrush="{TemplateBinding BorderBrush}"
                        BorderThickness="{TemplateBinding BorderThickness}">
                        <Grid>
                            <Path 
                                Margin="2"
                                Width="10"
                                Height="10"
                                Data="{Binding DataChanged, Converter={StaticResource converter}}"
                                Fill="{TemplateBinding Foreground}"
                                Stretch="Uniform"/>
                        </Grid>
                    </Border>
                </ControlTemplate>
            </Setter.Value>
        </Setter>
    </Style>
</Window.Resources>
```

```c#
public class RowIndicatorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value != null && (bool)value)
        {
            string str = "M6.8007798,1.7332839 L8.97791,3.9143763 2.8868401,10.034073 0,10.666874 0.70837402,7.8491302 z M9.1967516,0.00016105175 C9.5903473,-0.0053596497 9.9693098,0.13107061 10.251301,0.41431141 10.856801,1.0224026 10.794301,2.067961 10.110801,2.7515601 L7.9219999,0.5588423 C8.2858057,0.19500291 8.7506762,0.0064178705 9.1967516,0.00016105175z";
            return Geometry.Parse(str);
        }
        return Geometry.Empty;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
```

KB article - [How to customize the indicator of the Row header based on record data value in WPF DataGrid(SfDataGrid)?](https://www.syncfusion.com/kb/11916/how-to-customize-the-indicator-of-the-row-header-based-on-record-data-value-in-wpf-datagrid)

## Requirements to run the demo
 Visual Studio 2015 and above versions
