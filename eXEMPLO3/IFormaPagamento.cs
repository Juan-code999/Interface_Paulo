using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo3
{
    public interface IFormaPagamento
    {
        void CalculaValorPagamento(double valorTotal);
    }
}
