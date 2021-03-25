namespace Primeiro_Projeto
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Aluno(int matricula, string nome, int idade)
        {
            Matricula = matricula;
            Nome = nome;
            Idade = idade;
        }

        public Aluno()
        {

        }

        public void fazerNiver()
        {
            Idade += 1;
        }

    }
}