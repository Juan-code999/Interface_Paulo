using Exemplo3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class cheque : IFormaPagamento
{
    public void CalculaValorPagamento(double valorTotal)
    {
        Console.WriteLine($"Como pagamento será realizado no cheque, vamos oferecer 15% de desconto, Valor Final será: {valorTotal - (valorTotal * 0.15)}");
    }
}