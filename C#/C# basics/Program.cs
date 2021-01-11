using System;
using CS_basics.exemples;

namespace CS_basics{
    class Program{
        static void Main(string[] args){

          int[] test=new int[] {1,2,3,4,5,6,7,8,9,10};
          foreach(int i in test){
              Console.WriteLine(i*i);
          }
          Ponto p1=new Ponto(0,0);
          Ponto p2=new Ponto(10,20);
          Console.WriteLine(dist(p1,p2));
          Ponto3D p3=new Ponto3D(0,0,0);
          p1.dist3D();
          p3.dist3D();
          int x=0;
          Console.WriteLine(x);
          plus1(ref x);
          Console.WriteLine(x);
        }

        public static double dist(Ponto p1, Ponto p2){
            return Math.Sqrt(Math.Pow(p1.x - p2.x,2) + Math.Pow(p1.y - p2.y,2));
        }
        public static void plus1(ref int x){
            x+=1;
        }
    }


}
