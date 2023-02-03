using System;

namespace Method {
    class Program {
        public static int UCLN(int A, int B) {
    if (B == 0)
        return A;
    return UCLN(B, A%B);}
        public static void Show(int[] arr) {
            int uoc=arr[0];
            for(int i = 0; i < arr.Length; i++) {
               uoc=UCLN(uoc,arr[i]);
            }
            Console.WriteLine(uoc);
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
