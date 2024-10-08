
using eXEMPLO3;
using Exemplo3;

IFormaPagamento formaPagamento;
Console.WriteLine("Selecione a forma de pagamento:");
Console.WriteLine("1 -Pix");
Console.WriteLine("2 -Dinheiro");
Console.WriteLine("3 -Cartao");
int f = int.Parse(Console.ReadLine());
if (f < 0 || f > 3)
{
    throw new Exception("Opção inválida");
}
    switch (f)
    {
        case 1:
            formaPagamento = new Pix();
            break;
        case 2:
            formaPagamento = new Dinheiro();
            break;
    default:
            formaPagamento = new Cartao();
            break;
    }
formaPagamento.CalculaValorPagamento(200);