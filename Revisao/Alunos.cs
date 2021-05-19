namespace Revisao
{
    public struct Alunos //o mais apropriado, para um programa acessando um banco de dados, seria o uso de uma class
    {
        public string Nome { get; set; }
        public decimal Nota { get; set; }
    }
}