# How to create the single group for null and empty value in Windows Forms DataGrid(SfDataGrid)?

## About the sample

This example illustrates how to create the single group for null and empty value in Windows Forms DataGrid(SfDataGrid)

By default, empty and null values are created the separate groups in SfDataGrid. You can able to create the single group for empty and null value by using KeySelector in GroupColumnDescriptions.

```C#
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

## Requirements to run the demo
Visual Studio 2015 and above versions
