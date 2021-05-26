using AppMvcEcommerce.Models;

namespace AppMvcEcommerce.Repositories
{
    public interface IItemPedidoRepository
    {
        ItemPedido GetItemPedido(int itemPedidoId);
    }
}