using System;
namespace CS_basics.exemples{
    public class Ponto{
        public int x,y;
        public Ponto(int x,int y){
            this.x=x;
            this.y=y;
        }
        public virtual void dist3D(){
            Console.WriteLine("2D line in 3D");
        }
    }
    public class Ponto3D:Ponto{
        public int z;
        public Ponto3D(int x,int y,int z):base(x,y){
            this.z=z;

        }
        public override void dist3D(){
            Console.WriteLine("3D point somewhere");
        }
    }
    public struct Ponto2{
        public int x,y;
        public Ponto2(int x,int y){
            this.x=x;
            this.y=y;
        }
    }
    interface IControl{
        void Paint();
    }
    interface IListBox{
        void SetText();
    }
    public class InterfaceTest:IControl, IListBox{
        public void Paint(){
            Console.WriteLine("I'm an artist!");
        }
        public void SetText(){
            Console.WriteLine("I'm a writer");
        }
    }
    enum Cor{
        Red,
        Green,
        Blue
    }
}