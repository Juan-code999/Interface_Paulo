
using eXEMPLO3;
using Exemplo3;

IFormaPagamento formaPagamento;
Console.WriteLine("Selecione a forma de pagamento:");
Console.WriteLine("1 -Pix");
Console.WriteLine("2 -Dinheiro");
Console.WriteLine("3 -Cartao");
Console.WriteLine("4 -Cheque");
int f = int.Parse(Console.ReadLine());
if (f < 0 || f > 4)
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
        case 3:
            formaPagamento = new Cartao();
        break;
    default:
            formaPagamento = new cheque();
            break;
    }
GerenciadorPagamento ger =new GerenciadorPagamento();
ger.ProcesarPagamento(formaPagamento, 200);