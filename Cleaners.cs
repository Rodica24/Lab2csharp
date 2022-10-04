using System;

namespace VScode{

    class Cleaners{
       private Client client;

       public void cleanRoom(){
            Random rnd = new Random();
            for (int j = 0; j < 1; j++)
            {
                Console.WriteLine("There are this number of dirty rooms:");
                Console.WriteLine(rnd.Next(3));//returns random integers < 10
                }

        }}}

       
    
