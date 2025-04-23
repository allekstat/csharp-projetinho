class Cliente : Pessoa
{
    protected int id;
    public void exibir()
    {
       Console.WriteLine("{0} tem o id {1}", this.nome, this.id);
    }
    public override void cadastrar()
    {
        baae.cadastrar();
        Console.WriteLine("Digite um Id:");
        this.id = int.Parse(Console.ReadLine());
    }
}