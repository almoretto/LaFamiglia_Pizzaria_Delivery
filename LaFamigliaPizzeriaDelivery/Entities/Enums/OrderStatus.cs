namespace Entities.Enums
{
    public enum OrderStatus:int
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
