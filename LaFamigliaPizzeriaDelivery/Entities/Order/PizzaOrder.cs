using Entities.Enums;
using Entities.People;
using System;

namespace Entities.Order
{
    public class PizzaOrder
    {

        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public Client ClientInOrder { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Double OrderAmount { get; private set; }
        public bool CallCenter { get; set; }
        public double DeliveryAmount { get; private set; }
        public Double OrderTotalAmount { get; private set; }
        public DateTime OrderDate { get; set; }
        public User OrderUser { get; set; }
        public DateTime LastChangeDate { get; set; }
        public User LastChangeUser { get; set; }

        public PizzaOrder() { }

        public PizzaOrder(Client clientInOrder, OrderStatus status, bool callCenter,
            DateTime orderDate, User orderUser, DateTime lastChangeDate, User lastChangeUser)
        {
            OrderNumber = GenerateOrderNumber();
            ClientInOrder = clientInOrder;
            OrderStatus = status;
            OrderAmount = 0.0d;
            CallCenter = callCenter;
            DeliveryAmount = 0.0d;
            OrderTotalAmount = 0.0d;
            OrderDate = orderDate;
            OrderUser = orderUser;
            LastChangeDate = lastChangeDate;
            LastChangeUser = lastChangeUser;
        }

        public bool SetTotal()
        {
            OrderTotalAmount = OrderAmount + DeliveryAmount;
            if (OrderTotalAmount > 0.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SetOrderTotal(double amount)
        {
            OrderAmount = amount;
            if (OrderAmount > 0.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SetDelivery(double amount)
        {
            DeliveryAmount = amount;
            if (DeliveryAmount > 0.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GenerateOrderNumber()
        {
            string number;
            Random rand = new Random();
            number = ClientInOrder.Id.ToString();
            number += OrderDate.Month.ToString();
            number += OrderDate.Day.ToString();
            number += rand.Next(00001,99999).ToString();
            return number;
        }
    }
}
