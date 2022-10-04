using System;

namespace VScode{

    class Chief{
        private Orders orders;
        private string main;
        private string drink;


        public string Main{
            get { return main; }
            set { main = value; } 
        }

        public string Drink{
            get { return drink; }
            set { drink = value; } 
        }

        public void prepare(Orders orders){
            KeyValuePair<string, int> main = orders.orderMain();
            KeyValuePair<string, int> drink = orders.orderDrink();

            Console.WriteLine("");
            Console.WriteLine("Customer ordered ");
            orders.orderMain();
            Console.WriteLine(main);
            Console.WriteLine(drink);
            Console.WriteLine("The chief got the order and started preparing it ");


        }


       
    }
}