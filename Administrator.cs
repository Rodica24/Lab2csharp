using System;

namespace VScode{

    class Administrator{
        private Client client;



        public void grade(Client client, Cleaners cleaners){
            Console.WriteLine("");
            if (client.Tips <= 0){

                Console.WriteLine("The waiter now has a lower salary(");
            }
            else if (client.Tips > 0){
                Console.WriteLine("The waiter gets congrats");
            }
        }

    }
}