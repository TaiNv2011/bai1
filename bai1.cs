using System;

namespace Method {
    class Program {
        public static void Show(int[] arr) {
            int min=arr[0];
            int max= arr[0];
            for(int i = 0; i < arr.Length; i++) {
                if(arr[i]>max) {
                    max= arr[i];
                }
                if(arr[i]<min)
                {
                    min=arr[i];
                }
            }
            Console.WriteLine("Max la"+max);
            Console.WriteLine("min la"+min);
        }
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++) {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Show(arr);
        }
    }
}
