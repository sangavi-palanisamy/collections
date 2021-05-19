using System;
using System.Collections;

namespace collection
{
    class stacks
    {
        public void method()
        {
            Stack ss = new Stack(); // creating the stack object
            ss.Push(40);   // push the elements
            ss.Push(8.0f);
            ss.Push("sangavi");
            ss.Push(20000);
            ss.Push("bavi");
            Console.WriteLine("elements in stack");
            foreach (var sample in ss)
            {
                Console.WriteLine(sample);
            }
            ss.Pop();

            Console.WriteLine("pop delete the last element in the stack ");
            foreach (var sample in ss) // after pop the last element
            {


                Console.WriteLine(sample);


            }
            Console.WriteLine("peep element");
            Console.WriteLine(ss.Peek());
            Console.WriteLine(ss.Peek());



        }
    }
   
    class queues
    {
        public void display()
        {
            Console.WriteLine("\n");
            Console.WriteLine("QUEUE");
            Queue qu = new Queue();
            qu.Enqueue(200);
            qu.Enqueue(40.90f);
            qu.Enqueue("pass");
            qu.Enqueue("fail");
            foreach (var sample in qu)
            {
                Console.WriteLine(sample);
            }
            qu.Dequeue();
            Console.WriteLine("after dequeue");
            foreach (var sample in qu)// after dequeue
            {
                Console.WriteLine(sample);
            }
        }
       
    }
    class arraryli
    {
       public void function()
        {
            Console.WriteLine("\n");
            ArrayList arr1 = new ArrayList();
            arr1.Add(100);
            arr1.Add(50.98f);
            arr1.Add("vino");
            arr1.Add("deeps");
            Console.WriteLine("displaying elements in arr1");
            foreach (var sample in arr1)
            {
                Console.WriteLine(sample);
            }
            ArrayList arr2 = new ArrayList();
            arr2.Add(877);
            arr2.Add("sindhu");
            arr2.Add("kavya");
            arr1.AddRange(arr2);
            Console.WriteLine("displaying elements after addrange");
            foreach (var sample in arr1)
            {
                Console.WriteLine(sample);
            }
        }
        
    }

   
    class Program
    {
        static void Main(string[] args)
        {

            stacks ob = new stacks();
            ob.method(); // call the method 
            queues obj = new queues();
            obj.display();
            arraryli obj1 = new arraryli();
            obj1.function();
            Console.ReadKey();
            

            
            
           
        }
    }
}

