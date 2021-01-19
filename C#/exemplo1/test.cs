using System;

class Desafio {
    static void Main() {
        string[] input = Console.ReadLine().Split(' ');
        int a =Int32.Parse(input[0]);
        int n =Int32.Parse(input[1]);
        float val= (float)n/(float)a;
        for(int i=1;i<10;i++){
            Console.WriteLine(Math.Ceiling(val*i));
        }
    }
}