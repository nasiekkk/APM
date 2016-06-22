using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVMCore;

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

        #region Commands

        public ICommand AddOrderCommand { get; set; }
        public ICommand ModifyOrderCommand { get; set; }
        public ICommand CalculateOrderCommand { get; set; }

        #endregion

        #region Commands handlers

        private void CalculateExcute()
        {
            
        }

        private bool ModifyOrderCanExecute()
        {
            return SelectedOrder != null;
        }

        private void ModifyOrderExecute()
        {
            if (!ModifyOrderCanExecute())
                return;

            Orders.Remove(SelectedOrder);
            Orders.Add(new Order(4));
            
        }

        private void AddOrderExecute()
        {
            Orders.Add(new Order());
        }

        #endregion

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
            AddOrderCommand = new RelayCommand(AddOrderExecute);
            ModifyOrderCommand = new RelayCommand(ModifyOrderExecute, ModifyOrderCanExecute);
            CalculateOrderCommand = new RelayCommand(CalculateExcute);
        }
    }
}
