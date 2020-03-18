using DemoCommon.Grid;
using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Forms;

namespace AddNewRow
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor

        OrderInfoCollection orderInfoCollection = new OrderInfoCollection();

        public Form1()
        {
            InitializeComponent();
            sfDataGrid.DataSource = orderInfoCollection.Orders;
            sfDataGrid.ShowGroupDropArea = true;

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

                    return item; ;
                }
            });
        }
    }

    #endregion
}

    public class OrderInfo : INotifyPropertyChanged
    {
        int orderID;
        string customerId;
        string country;
        string customerName;
        string shippingCity;

        public event PropertyChangedEventHandler PropertyChanged;

        public int OrderID
        {
            get { return orderID; }
            set
            {
                orderID = value;
                RaisePropertyChanged("OrderID");
            }
        }
        public string CustomerID
        {
            get { return customerId; }
            set
            {
                customerId = value;
                RaisePropertyChanged("CustomerID");
            }
        }
        public string CustomerName
        {
            get { return customerName; }
            set
            {
                customerName = value;
                RaisePropertyChanged("CustomerName");
            }
        }
        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                RaisePropertyChanged("Country");
            }
        }
        public string ShipCity
        {
            get { return shippingCity; }
            set
            {
                shippingCity = value;
                RaisePropertyChanged("ShipCity");
            }
        }
        public OrderInfo(int orderId, string customerName, string country, string customerId, string shipCity)
        {
            this.OrderID = orderId;
            this.CustomerName = customerName;
            this.Country = country;
            this.CustomerID = customerId;
            this.ShipCity = shipCity;
        }

        /// <summary>
        /// Occurs when any property value changed.
        /// </summary>
        /// <param name="propertyName">The name of the property which was changed.</param>
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

public class OrderInfoCollection
{
    public ObservableCollection<OrderInfo> _orders;
    public ObservableCollection<OrderInfo> Orders
    {
        get { return _orders; }
        set { _orders = value; }
    }
    public OrderInfoCollection()
    {
        _orders = new ObservableCollection<OrderInfo>();
        this.GenerateOrders();
    }
    private void GenerateOrders()
    {
        _orders.Add(new OrderInfo(1001, "Maria Anders", null, "ALFKI", "Berlin"));
        _orders.Add(new OrderInfo(1002, "Ana Trujilo", null, "ANATR", "Mexico D.F."));
        _orders.Add(new OrderInfo(1003, "Antonio Moreno", null, "ANTON", "Mexico D.F."));
        _orders.Add(new OrderInfo(1004, "Thomas Hardy", "UK", "AROUT", "London"));
        _orders.Add(new OrderInfo(1005, "Christina Berglund", string.Empty, "BERGS", "Lula"));
        _orders.Add(new OrderInfo(1006, "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
        _orders.Add(new OrderInfo(1007, "Frederique Citeaux", string.Empty, "BLONP", "Strasbourg"));
        _orders.Add(new OrderInfo(1008, "Martin Sommer", "Spain", "BOLID", "Madrid"));
        _orders.Add(new OrderInfo(1009, "Laurence Lebihan", "France", "BONAP", "Marseille"));
        _orders.Add(new OrderInfo(1010, "Elizabeth Lincoln", "Canada", "BOTTM", "Tsawassen"));
        _orders.Add(new OrderInfo(1011, "Maria Anders", null, "ALFKI", "Berlin"));
        _orders.Add(new OrderInfo(1012, "Ana Trujilo", "Mexico", "ANATR", "Mexico D.F."));
        _orders.Add(new OrderInfo(1013, "Antonio Moreno", "Mexico", "ANTON", "Mexico D.F."));
        _orders.Add(new OrderInfo(1014, "Thomas Hardy", string.Empty, "AROUT", "London"));
        _orders.Add(new OrderInfo(1015, "Christina Berglund", "Sweden", "BERGS", "Lula"));
        _orders.Add(new OrderInfo(1016, "Hanna Moos", string.Empty, "BLAUS", "Mannheim"));
        _orders.Add(new OrderInfo(1017, "Frederique Citeaux", "France", "BLONP", "Strasbourg"));
        _orders.Add(new OrderInfo(1018, "Martin Sommer", string.Empty, "BOLID", "Madrid"));
        _orders.Add(new OrderInfo(1019, "Laurence Lebihan", "France", "BONAP", "Marseille"));
        _orders.Add(new OrderInfo(1020, "Elizabeth Lincoln", null, "BOTTM", "Tsawassen"));
    }
}
