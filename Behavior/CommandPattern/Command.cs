using System.Collections.Generic;
/* 
 Unify request. Some what useful 
*/
namespace DesignPattern
{
    public interface Order
    {
        void Execute();
    }

    public class Stock
    {

        private string name = "ABC";
        private int quantity = 10;

        public void Buy()
        {

        }
        public void Sell()
        {

        }
    }

    public class BuyStock : Order
    {
        private Stock abcStock;

        public BuyStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }

        public void Execute()
        {
            abcStock.Buy();
        }
    }

    public class SellStock : Order
    {
        private Stock abcStock;

        public SellStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }

        public void Execute()
        {
            abcStock.Sell();
        }
    }

    public class Broker
    {
        private List<Order> orderList = new List<Order>();

        public void TakeOrder(Order order)
        {
            orderList.Add(order);
        }

        public void PlaceOrders()
        {
            foreach(var order in orderList)
            {
                order.Execute();
            }

            orderList.Clear();
        }
    }
}