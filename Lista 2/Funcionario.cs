using System.Reflection.PortableExecutable;
using System.Globalization;

namespace Lista_2
{
    public class Funcionario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public double Salario { get; set; }

        public Funcionario(int id, string nome, int salario)
        {
            this.Id = id;
            this.Nome = nome;
            this.Salario = salario;

        }

        public void IncrementoSalario() {
            Salario += Salario * 10 / 100.0;
        }

    }
}