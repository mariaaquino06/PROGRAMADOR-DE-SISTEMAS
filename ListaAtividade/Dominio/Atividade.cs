using System;
using ListaAtividade.Repositorio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade.Dominio
{
    internal class Atividade
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Situacao Situacao { get; set; }

        private readonly AtividadeRepositorio repositorio  = new();

        public bool Criar()
        {
            if (!ValidarTítulo())
            {
                return false;
            }

            repositorio.Criar(Titulo);
            return true;
        }

        public bool AtualizarSituacao()
        {
            if (!ValidarId())
            {
                return false;
            }

            if (!ValidarSituacao())
            { 
                return false;
            }

            Atividade atividadeEmAndamento = BuscarAtividadeEmAndamento();
            Situacao novaSituacao = BuscarProximaSituacao();

            if (atividadeEmAndamento.Id > 0 && atividadeEmAndamento.Situacao == BuscarProximaSituacao())
            {
                return false;
            }

            return true;
        }

        public Atividade BuscarAtividadeEmAndamento()
        {
            return new Atividade();
        }

        public List<Atividade> ListarAtividadesPendentes()
        {
            return [];
        }

        private bool ValidarTítulo()
        {
            return !string.IsNullOrWhiteSpace(Titulo);
        }
        private bool ValidarId()
        {
            return Id > 0;
        }

        private bool ValidarSituacao()
        {
            return Situacao != Situacao.Concluido;
        }


        private Situacao BuscarProximaSituacao()
        {
           if (Situacao == Situacao.Pendente) 
           {
                return Situacao.Realizando;
           }
            
            return Situacao.Concluido;
        }

    }
}
