using Planer.MVVM_Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Planer
{
    public class MainWindowVM : ObservableObject
    {
        private ObservableCollection<Order> _orders;
        public ObservableCollection<Order> Orders
        {
            get 
            { 
                return _orders; 
            }
            set
            {
                _orders = value;
                RaisePropertyChanged("Orders");
            }
         
        }
        
        public ICommand AddOrderCommand { get; set; }
        public ICommand ModifyOrderCommand { get; set; }
        public ICommand CalculateOrderCommand { get; set; }
        private Order _selectedOrder;
        public Order SelectedOrder
        {
            get
            {
                return _selectedOrder;
            }
            set
            {
                _selectedOrder = value;
                RaisePropertyChanged("SelectedOrder");
            }
        }

        public MainWindowVM()
        {
            Orders = new ObservableCollection<Order>
            {
                new Order
                {
                    OrderDate = DateTime.Now,
                    Items = new List<OrderItem> 
                    { 
                        new OrderItem(), 
                        new OrderItem()
                    }
                },
                new Order
                {
                    OrderDate = DateTime.Today,
                    Items = new List<OrderItem> 
                    { 
                        new OrderItem(), 
                        new OrderItem()
                    }
                }
            };
            AddOrderCommand = new RelayCommand(
                () => 
                { 
                    Orders.Add(new Order());
                }
            );

            ModifyOrderCommand = new RelayCommand(
                () => 
                {
                    Orders.Remove(SelectedOrder);
                    Orders.Add(new Order(4));
                }
            );

            CalculateOrderCommand = new RelayCommand(
                () =>
                {

                });
        }
    }
}
