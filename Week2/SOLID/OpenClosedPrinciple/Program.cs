using System;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {    //Open Closed Principle ->
            // An object should be open to development and closed to change.

            //Customer customer = new Customer { cart = CartTypes.Gold };
            Customer customer = new Customer { cart = new Premium() };
            OrderManagement orderManagement = new OrderManagement { customer = customer };
            var pay = orderManagement.Pay(1000);
            Console.WriteLine(pay);
        }

        //public enum CartTypes
        //{
        //    Silver,
        //    Standart,
        //    Gold,   
        //}

        public abstract class CartTypes
        {
            public abstract decimal discount(decimal amount);
        }

        public class Silver : CartTypes
        {
            public override decimal discount(decimal amount)
            {
                return amount * 0.9M;
            }
        }

        public class Standart : CartTypes
        {
            public override decimal discount(decimal amount)
            {
                return amount * 0.5M;
            }
        }

        public class Gold : CartTypes
        {
            public override decimal discount(decimal amount)
            {
                return amount * 0.85M;
            }
        }

        public class Premium : CartTypes
        {
            public override decimal discount(decimal amount)
            {
                return amount * 0.7M;
            }
        }
        public class Customer
        {
            public CartTypes cart { get; set; }
        }

        public class OrderManagement
        {
            public Customer customer { get; set; }
            public decimal Pay(decimal amount)
            {
                return customer.cart.discount(amount);

                //switch (customer.cart)
                //{
                //    case CartTypes.Silver:
                //        return amount * 0.9M;
                //    case CartTypes.Standart:
                //        return amount * 0.5M;
                //    case CartTypes.Gold:
                //        return amount * 0.85M;
                //    default:
                //        return amount;
                //}
            }
        }

    }
}
