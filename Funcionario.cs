class Funcionario : Pessoa
{
    protected double salario;
    protected int registro;
    protected Pessoa[] dependentes;
    public void definirSalario()
    {
        Console.WriteLine("Digite um novo Salário:");
        this.salario = double.Parse(Console.ReadLine());
    }
    public void exibirSalario()
    {
        Console.WriteLine("{0} recebe R$ {1} de salário", this.nome, this.salario);
    }
    public void desconto()
    {
        Console.WriteLine("Digite um valor para descontar do salário");
        this.salario -= double.Parse(Console.ReadLine());
    }
    public void bonus()
    {
        Console.WriteLine("Digite um valor para somar do salário");
        this.salario += double.Parse(Console.ReadLine());
    }
    public void cadastrarRegistro()
    {
        Console.WriteLine("Digite o Registro:");
        this.registro = int.Parse(Console.ReadLine());
    }
    public void consultarRegistro()
    {
        Console.WriteLine("{0} é registrado por {1}", this.nome, this.registro);
    }
    public void adicionarDependente()
    {
        Pessoa dependente = new Pessoa();
        dependente.cadastrar();
        this.dependentes.Append(dependente);
    }
}