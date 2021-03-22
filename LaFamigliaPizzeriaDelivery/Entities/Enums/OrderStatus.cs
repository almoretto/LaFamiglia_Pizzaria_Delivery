using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Enums
{
    public enum OrderStatus
    {
        Ativo = 1,
        EmProducao = 2,
        EmExpedicao = 3,
        EmDelivery = 4,
        Entregue = 5,
        ProblemaNaEntrega = 6,
        Devolucao = 7
    }
}
