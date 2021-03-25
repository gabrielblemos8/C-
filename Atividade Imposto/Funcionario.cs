namespace Atividade_Imposto
{
    public class Funcionario
    {
        
        public string Nome { get; set; }

        public double Salario { get; set; }

        public double Imposto { get; set; }

        public double Porcentagem { get; set; }

        public Funcionario (string nome, double salario, double imposto, double porcentagem){
        Nome = nome;
        Salario = salario;
        Imposto = imposto;
        Porcentagem = porcentagem;
        }

        public Funcionario(){

        }


    }
}
