# How to create the single group for null and empty value in Windows Forms DataGrid(SfDataGrid)

By default, empty and null values are created the separate groups in SfDataGrid. You can able to create the single group for empty and null value by using [KeySelector](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.GroupColumnDescription.html?_ga=2.117674313.1315379768.1669285137-766490130.1650530957&_gl=1*tvmfv5*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2OTM3NjkwOS4zMTQuMS4xNjY5Mzc5ODA2LjAuMC4w#Syncfusion_WinForms_DataGrid_GroupColumnDescription_KeySelector) in [GroupColumnDescription](https://help.syncfusion.com/cr/Syncfusion.WinForms.DataGrid.GroupColumnDescription.html?_ga=2.117674313.1315379768.1669285137-766490130.1650530957&_gl=1*tvmfv5*_ga*NzY2NDkwMTMwLjE2NTA1MzA5NTc.*_ga_WC4JKKPHH0*MTY2OTM3NjkwOS4zMTQuMS4xNjY5Mzc5ODA2LjAuMC4w).

```
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
