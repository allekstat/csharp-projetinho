class ClienteVip : Cliente
{
    protected double desconto;
    protected double cashback;
    public void exibirCashBack()
    {
       Console.WriteLine("{0} tem R$ {1} de cashback", this.nome, this.cashback);
    }
    public void calcularCashBack(double valorCompra)
    {
        Console.WriteLine("{0} terá R$ {1} de cashback em R$ {2} de compra", this.nome, valorCompra * this.cashback, valorCompra);
    }
    public void exibirDesconto()
    {
       Console.WriteLine("{0} tem {1} % de desconto", this.nome, this.desconto);
    }
    public void calcularDesconto(double valorCompra)
    {
        Console.WriteLine("{0} terá R$ {1} de desconto em R$ {2} de compra", this.nome, valorCompra * this.desconto, valorCompra);
    }
}