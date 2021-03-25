namespace Atividade_Banco
{
    public class Cliente
    {
        public string Nome { get; set; } 
        public int Numero { get; set; }
        
        public double Saldo { get; set; }

         public Cliente(string nome, int numero, double saldo)
        {   Nome = nome;
            Numero = numero;
            Saldo = Saldo;
        }

        public Cliente(){

        }
    }
}