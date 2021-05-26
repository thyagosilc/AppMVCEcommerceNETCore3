using AppMvcEcommerce.Models;
using AppMvcEcommerce.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace AppMvcEcommerce
{
    class DataService : IDataService
    {
        private readonly ApplicationContext context;
        private readonly IProdutoRepository produtoRepository;

        public DataService(ApplicationContext context, IProdutoRepository produtoRepository)
        {
            this.context = context;
            this.produtoRepository = produtoRepository;
        }

        public void InicializaDB()
        {
            context.Database.EnsureCreated();
            IList<Livro> livros = GetLivros();
            produtoRepository.SaveProdutos(livros);
        }

        private IList<Livro> GetLivros()
        {
            var json = File.ReadAllText("livros.json");
            return JsonConvert.DeserializeObject<List<Livro>>(json);
        }
    }
}
