using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo3
{
    public class GerenciadorPagamento
    {
        public void ProcesarPagamento(IFormaPagamento pagamento, double valor)
        {
            pagamento.CalculaValorPagamento(valor);
        }
    }
}
