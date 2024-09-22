using System;

namespace sorting {
    class BubbleSort{
        static void Main (string[] args){

            Console.Write("enter the length of the array : ");
            int array_length = int.Parse(Console.ReadLine());
            Console.WriteLine("the length : " + array_length);
            
            Console.Write("enter the min range : ");
            int min = int.Parse(Console.ReadLine());
            
            Console.Write("enter the max range : ");
            int max = int.Parse(Console.ReadLine());

            int[] numbers = new int[array_length];

            Random random = new Random();
            for (int i=0; i<array_length; i++) {
                numbers[i] = random.Next(min, max);
            }
            
            Console.Write("[");
            for(int i=0; i<array_length; i++){
                Console.Write(numbers[i]);

                if(i<array_length-1){
                    Console.Write(", ");
                }
            }
            Console.Write("]");

            bool swapped = true;

            while(swapped){
                swapped = false;
                for (int i=0; i<numbers.Length-1; i++){
                    if(numbers[i]>numbers[i+1]){
                        int temp = numbers[i];
                        numbers[i] = numbers[i+1];
                        numbers[i+1] = temp;
                        swapped=true;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("=======================================================================================");
            Console.Write("[");
            for(int i=0; i<array_length; i++){
                Console.Write(numbers[i]);

                if(i<array_length-1){
                    Console.Write(", ");
                }
            }
            Console.Write("]");
        }
    }
}