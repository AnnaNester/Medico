using Controller.DAL;
using Controller.IBaseController;
using Model;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Controller
{
    public class MedicoController : IBaseController<Medico>
    {
        private List<Medico> listaMedicos { get; set; }

        private Contexto contexto = new Contexto();

        public void Cadastro(Medico entity)
        {
            contexto.Medicos.Add(entity);
            contexto.SaveChanges();
        }

        public IList<Medico> ListarTodos()
        {
            return listaMedicos;
        }

        public IList<Medico> ListarPorNome(string nome)
        {
            return contexto.Medicos.Where(med => med.nome.ToLower() == nome.ToLower()).ToList();
        }

        public Medico ListarPorCRM(int chave)
        {
            return contexto.Medicos.Find(chave);
        }

        public void Atualizar(Medico entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int chave)
        {
            Medico m = ListarPorCRM(chave);

            if (m != null)
            {
                contexto.Entry(m).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }

        public IList<Medico> ListarPorEspecialidade(string especialidade)
        {
            return contexto.Medicos.Where(esp => esp.especialidade.ToLower() == especialidade.ToLower()).ToList();
        }
    }
}
