namespace ConsoleAppQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //part1();     
          part2();
        }

        public static void part2(){
            Queue<Order> ordersQueue = new Queue<Order>();

            foreach(Order o in RecieveOrdersFromBranch1())
            {
               //add each order to queue
               ordersQueue.Enqueue(o);  
            }

            foreach(Order o in RecieveOrdersFromBranch2())
            {
                ordersQueue.Enqueue(o);
            }

            while(ordersQueue.Count > 0)
            {
                //remove the order at the front 
                Order currentOrder = ordersQueue.Dequeue();
                
                //process the order
                currentOrder.ProcessOrder();
            }
        }
        
        static Order[] RecieveOrdersFromBranch1(){
            //creating new orders array
            Order[] orders = new Order[]{
                new Order(1,5),
                new Order(2,4),
                new Order(6,10)
            };
 
            //return the array of orders that we created
            return orders;                
        }
        
        static Order[] RecieveOrdersFromBranch2(){
            //creating new orders array
            Order[] orders = new Order[]{
                new Order(3,5),
                new Order(4,4),
                new Order(5,10)
            };

            //return the array of orders that we created 
            return orders;                
        }

        private static void part1(){
           //defining a queue
            Queue<int> ints = new Queue<int>();
            ints.Enqueue(1);

            //printing the element at the front of the queue
            Console.WriteLine($"The value at the front of the queue is : {ints.Peek()}");

            ints.Enqueue(2);
            Console.WriteLine($"The value in the queue is : {ints.Peek()}");
           
            ints.Enqueue(3);
            Console.WriteLine($"The value in the queue is : {ints.Peek()}");

            Console.WriteLine("");

            while( ints.Count > 0 )
            {
                Console.WriteLine($"The front value {ints.Dequeue()} was removed from the queue.");
                Console.WriteLine($"Current queue count is : {ints.Count}");
            }
        }
    }

    class Order
    {
        //order ID 
        public int OrderId {get; set;}
        //quantity of the order
        public int OrderQuanttity { get; set;}
        

        //simple constructor 
        public Order(int id, int OrderQuanttity)
        {
            this.OrderId = id;
            this.OrderQuanttity = OrderQuanttity;
        }

        //print message on the screen that the order was processed
        public void ProcessOrder()
        {
            //print the message
            Console.WriteLine($"Order {OrderId} , processed!");
        }

    }
}