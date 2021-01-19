using System;
using System.Collections.Generic;
using System.Linq;

namespace resolvendo{
    class Program{
        static void Main(string[] args){

            List<string> joias=new List<String>();
            string input;
            for(int i=0;i<106;i++){
                input=Console.ReadLine();
                if(input=="p"){
                    break;
                }else{
                    if(!joias.Contains(input)){
                    joias.Add(input);
                    }
                }
            }
            
            Console.WriteLine(joias.Count);
            
        }
    }
}