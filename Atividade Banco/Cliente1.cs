namespace Atividade_Banco
{
    public class Cliente1
    {
        public string Nome { get; set; } 
        public int Numero { get; set; }
        
        public double Saldo { get; set; }

         public Cliente1(string nome, int numero, double saldo)
        {   Nome = nome;
            Numero = numero;
            Saldo = Saldo;
        }

        public Cliente1(){

        }
    }
}