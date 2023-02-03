using System;

namespace Method {
    class Program {
       public static int UCLN(int A, int B) {
    if (B == 0)
        return A;
    return UCLN(B, A%B);
}
        static void Main(string[] args) {
            int A = int.Parse(Console.ReadLine());
             int B = int.Parse(Console.ReadLine());
             
             Console.WriteLine(UCLN(A,B));
          
        }
    }
}
