using System;

namespace VScode{
    
    class Program{

        static void Main(){

            Hotel hotel = new Hotel("Grand", "Chisinau");
            hotel.printValues();

            Rooms rooms = new Rooms();
            rooms.GenerateRoom();

            Facility facility = new Facility();
            facility.displayFacility();

            Menu menu = new Menu();
            menu.displayMain();
            menu.displayDrink();

            Orders orders = new Orders();
            orders.orderMain();
            orders.orderDrink();
            

            Client client = new Client();

            Chief chief = new Chief();
            chief.prepare(orders);

            Cleaners cleaners = new Cleaners();
            cleaners.cleanRoom();

            Administrator administrator = new Administrator();

           
        }

    } 

}