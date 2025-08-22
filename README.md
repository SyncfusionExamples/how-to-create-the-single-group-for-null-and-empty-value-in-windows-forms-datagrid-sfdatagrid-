# How to create the single group for null and empty value in WinForms DataGrid?

This example illustrates how to create the single group for null and empty value in [WinForms DataGrid](https://www.syncfusion.com/winforms-ui-controls/datagrid) (SfDataGrid)

By default, empty and null values are created the separate groups in `SfDataGrid`. You can able to create the single group for empty and null value by using [KeySelector](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.GroupColumnDescription.html#Syncfusion_WinForms_DataGrid_GroupColumnDescription_KeySelector) in [GroupColumnDescriptions](https://help.syncfusion.com/cr/Syncfusion.WinForms.DataGrid.GroupColumnDescription.html).

```csharp
this.sfDataGrid.GroupColumnDescriptions.Add(new GroupColumnDescription()
{
    ColumnName = "Country",
    KeySelector = (string ColumnName, object o) =>
    {
        var item = (o as OrderInfo).Country;
        if (item == null || item == "")
        {
            return "";
        }
        return item;
    }
});
```

![How to create the single group for null and empty value](https://www.syncfusion.com/uploads/user/kb/wf/wf-54523/wf-54523_img1.png)