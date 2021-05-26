using AppMvcEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static AppMvcEcommerce.Repositories.CadastroRepository;

namespace AppMvcEcommerce.Repositories
{
    public partial class CadastroRepository : BaseRepository<Cadastro>, ICadastroRepository
    {

        public CadastroRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
