class Gerente : Funcionario
{
    protected string setor;
    public void definirSetor()
    {
       Console.WriteLine("Digite o Setor:");
       this.setor = Console.ReadLine();
    }
    public void exibirSetor()
    {
       Console.WriteLine("{0} supervisiona o setor {1}", this.nome, this.setor);
    }
}