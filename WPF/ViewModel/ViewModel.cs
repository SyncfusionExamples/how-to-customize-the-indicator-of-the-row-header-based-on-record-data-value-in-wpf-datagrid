using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class ViewModel: NotificationObject
    {
        ObservableCollection<Model> orderCollection;
        public ObservableCollection<Model> OrderInfoCollection
        {
            get { return orderCollection; }
            set { orderCollection = value; }
        }      

        public ViewModel()
        {
            orderCollection = new ObservableCollection<Model>();            
            OrderInfoCollection = GenerateOrders();                        
        }

        public ObservableCollection<Model> GenerateOrders()
        {
            ObservableCollection<Model> orders = new ObservableCollection<Model>();           
            orders.Add(new Model() { OrderID = 1001, CustomerName = "Maria Anders", Country = "Germany", CustomerID = "ALFKI", ShipCity = "Brandenburg", DataChanged = true });
            orders.Add(new Model() { OrderID = 1002, CustomerName = "Ana Trujilo", Country = "Mexico", CustomerID = "ANATR", ShipCity = "México D.F.", DataChanged = false });
            orders.Add(new Model() { OrderID = 1003, CustomerName = "Antonio Moreno", Country = "Mexico", CustomerID = "ANTON", ShipCity = "Guadalajara", DataChanged = true });
            orders.Add(new Model() { OrderID = 1004, CustomerName = "Thomas Hardy", Country = "Argentina", CustomerID = "AROUT", ShipCity = "Mendoza", DataChanged = false });
            orders.Add(new Model() { OrderID = 1005, CustomerName = "Christina Berglund", Country = "Brazil", CustomerID = "BERGS", ShipCity = "Campinas", DataChanged = true });
            orders.Add(new Model() { OrderID = 1006, CustomerName = "Hanna Moos", Country = "Germany", CustomerID = "BLAUS", ShipCity = "Aachen", DataChanged = false });
            orders.Add(new Model() { OrderID = 1007, CustomerName = "Martin Sommer", Country = "Italy", CustomerID = "BOLID", ShipCity = "Torino", DataChanged = true });
            orders.Add(new Model() { OrderID = 1008, CustomerName = "Laurence Lebihan", Country = "Belgium", CustomerID = "BONAP", ShipCity = "Charleroi", DataChanged = false });
            orders.Add(new Model() { OrderID = 1009, CustomerName = "Elizabeth Lincoln", Country = "Canada", CustomerID = "BOTTM", ShipCity = "Vancouver", DataChanged = true });
            orders.Add(new Model() { OrderID = 1010, CustomerName = "Hanna Moos", Country = "Germany", CustomerID = "BLAUS", ShipCity = "Aachen", DataChanged = false });
            orders.Add(new Model() { OrderID = 1011, CustomerName = "Maria Anders", Country = "Germany", CustomerID = "ALFKI", ShipCity = "Brandenburg", DataChanged = true });
            orders.Add(new Model() { OrderID = 1012, CustomerName = "Antonio Moreno", Country = "Mexico", CustomerID = "ANTON", ShipCity = "Guadalajara", DataChanged = false });
            orders.Add(new Model() { OrderID = 1013, CustomerName = "Martin Sommer", Country = "Italy", CustomerID = "BOLID", ShipCity = "Torino", DataChanged = true });
            orders.Add(new Model() { OrderID = 1014, CustomerName = "Maria Anders", Country = "Germany", CustomerID = "ALFKI", ShipCity = "Brandenburg", DataChanged = false });
            orders.Add(new Model() { OrderID = 1015, CustomerName = "Ana Trujilo", Country = "Mexico", CustomerID = "ANATR", ShipCity = "México D.F.", DataChanged = true });
            orders.Add(new Model() { OrderID = 1016, CustomerName = "Hanna Moos", Country = "Germany", CustomerID = "BLAUS", ShipCity = "Aachen", DataChanged = false });
            orders.Add(new Model() { OrderID = 1017, CustomerName = "Maria Anders", Country = "Germany", CustomerID = "ALFKI", ShipCity = "Brandenburg", DataChanged = true });
            orders.Add(new Model() { OrderID = 1018, CustomerName = "Martin Sommer", Country = "Italy", CustomerID = "BOLID", ShipCity = "Torino", DataChanged = false });
            orders.Add(new Model() { OrderID = 1019, CustomerName = "Christina Berglund", Country = "Brazil", CustomerID = "BERGS", ShipCity = "Campinas", DataChanged = true });
            orders.Add(new Model() { OrderID = 1020, CustomerName = "Hanna Moos", Country = "Germany", CustomerID = "BLAUS", ShipCity = "Aachen", DataChanged = false });
            orders.Add(new Model() { OrderID = 1021, CustomerName = "Martin Sommer", Country = "Italy", CustomerID = "BOLID", ShipCity = "Torino", DataChanged = true });
            orders.Add(new Model() { OrderID = 1022, CustomerName = "Laurence Lebihan", Country = "Belgium", CustomerID = "BONAP", ShipCity = "Charleroi", DataChanged = false });
            orders.Add(new Model() { OrderID = 1023, CustomerName = "Elizabeth Lincoln", Country = "Canada", CustomerID = "BOTTM", ShipCity = "Vancouver", DataChanged = true });
            orders.Add(new Model() { OrderID = 1024, CustomerName = "Hanna Moos", Country = "Germany", CustomerID = "BLAUS", ShipCity = "Aachen", DataChanged = false });
            orders.Add(new Model() { OrderID = 1025, CustomerName = "Maria Anders", Country = "Germany", CustomerID = "ALFKI", ShipCity = "Brandenburg", DataChanged = true });
            orders.Add(new Model() { OrderID = 1026, CustomerName = "Antonio Moreno", Country = "Mexico", CustomerID = "ANTON", ShipCity = "Guadalajara", DataChanged = false });
            orders.Add(new Model() { OrderID = 1027, CustomerName = "Martin Sommer", Country = "Italy", CustomerID = "BOLID", ShipCity = "Torino", DataChanged = true });
            return orders;
        }
    }
}
