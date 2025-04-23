class Pessoa
{
    protected string nome;
    protected string email;
    public void exibirDados()
    {
       Console.WriteLine("{0} usa o email {1}", this.nome, this.email);
    }
    public virtual void cadastrar()
    {
        Console.WriteLine("Digite um Nome:");
        this.nome = Console.ReadLine();
        Console.WriteLine("Digite um Email:");
        this.email = Console.ReadLine();
    }
}