using ProjetoBase.Context;
using ProjetoBase.Models;

namespace ProjetoBase.Repositorio
{
    public class DespesaRepositorio : IDespesaRepositorio
    {
        //variavel para acessar o bancoContext nos métodos, reservada a essa classe.
        private readonly BancoContext _bancoContext;
        public DespesaRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public DespesaModel Adicionar(DespesaModel despesa)
        {
            _bancoContext.Despesas.Add(despesa);
            _bancoContext.SaveChanges();
            return despesa;
            //adicionar no banco, injetando o dbcontext.
        }
    }
}
