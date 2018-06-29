using System.Collections.Generic;

namespace Controller.IBaseController
{
    public interface IBaseController<T> where T : class
    {
        void Cadastro(T entity);

        IList<T> ListarTodos();

        IList<T> ListarPorNome(string nome);

        T ListarPorCRM(int chave);

        IList<T> ListarPorEspecialidade(string especialidade);

        void Atualizar(T entity);

        void Excluir(int chave);
    }
}
