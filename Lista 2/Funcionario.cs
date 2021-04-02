using System.Reflection.PortableExecutable;
namespace Lista_2
{
    public class Funcionario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Salario { get; set; }

        public Funcionario(int id, string nome, int salario)
        {
            this.Id = id;
            this.Nome = nome;
            this.Salario = salario;

        }
    }
}