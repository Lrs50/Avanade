using System;

namespace exemplo1{
    class Program{
        static void Main(string[] args){

            Aluno[] alunos= new Aluno[5];
            int n=0;
            string choice=GetUserChoice();

            while(choice.ToUpper() != "X"){
                switch(choice){
                    case "1":
                        var aluno = new Aluno();
                        Console.Write("Informe no nome do aluno: ");
                        aluno.nome=Console.ReadLine();

                        Console.Write("Informe a nota do aluno: ");
                        if(decimal.TryParse(Console.ReadLine(),out decimal nota)){
                            aluno.nota=nota;
                        }else{
                            throw new ArgumentException("O valor da nota deve ser decimal");
                        }

                        alunos[n]=aluno;
                        n++;

                        break;
                    case "2":
                        foreach (var a in alunos){
                            if(!string.IsNullOrEmpty(a.nome)){
                                Console.WriteLine($"ALUNO:{a.nome} NOTA:{a.nota}");
                            }
                        }
                        break;
                    case "3":
                        decimal total=0;
                        for(int i=0;i<n+1;i++){
                            total+=alunos[i].nota;
                        }
                        Console.WriteLine($"A média dos Alunos é {total/n}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                choice=GetUserChoice();
            }
        }

        private static string GetUserChoice(){

            Console.WriteLine("\nInforme a opção desejada");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");

            string choice=Console.ReadLine();
            Console.WriteLine();

            return choice;
        }
    }

}
