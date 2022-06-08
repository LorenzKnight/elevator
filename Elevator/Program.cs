using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Timers;

namespace Elevator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Elevate();
            Console.Read();
        }

        public static void Elevate()
        {
            
                int[] arr = { };
                do
                {
                    Console.WriteLine("enter your floor");
                    string input = Console.ReadLine();
                    int newElement = int.Parse(input);
                    List<int> list = new List<int>(arr.ToList());
                    list.Add(newElement);
                    
                    arr = list.ToArray();
                    Array.Sort(arr);
                    foreach (var e in arr)
                    {
                        Thread.Sleep(2000);
                        Console.WriteLine("floor {0}", e);
                        ElevatorIsHere(e);
                        //MoveAndCheck();
                        Console.WriteLine("open the door");
                        Thread.Sleep(2000);
                        Console.WriteLine("close the door");
                        
                        Thread.Sleep(2000);
                        Console.WriteLine(arr[0]);
                    }
                    list.Remove(arr[0]);
                } while (true);
            

            //do
            //{

            //    if(nextFloors.Length != 0)
            //    {
            //        Console.WriteLine(nextFloors);
            //    }
            //} while (true);

            //int[] floors = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //bool isIt = floors.Contains(inputValue);

            //for (int i = 0; i < floors.Length+1; i++)
            //{
            //    if (inputValue == i)
            //    {
            //        Console.WriteLine("You are on floor number {0}", i);
            //    }
            //}

        }

        public static int ElevatorIsHere(int e)
        {
            var currentStatus = e;
            return currentStatus;
        }

        public static void MoveAndCheck(int floor)
        {
            int[] currentFloor = { };
            List<int> floorList = new List<int>(currentFloor.ToList());
            floorList.Add(floor);
            foreach (var j in currentFloor)
            {
                Console.WriteLine(j);
            }
        }
    }
}
