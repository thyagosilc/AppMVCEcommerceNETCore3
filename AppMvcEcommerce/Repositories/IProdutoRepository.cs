using AppMvcEcommerce.Models;
using System.Collections.Generic;

namespace AppMvcEcommerce.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(IList<Livro> livros);
        IList<Produto> GetProdutos();
    }
}