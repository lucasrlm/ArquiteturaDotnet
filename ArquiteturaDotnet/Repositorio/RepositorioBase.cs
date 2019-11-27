using Dados;
using System;

namespace Repositorio
{
    public class RepositorioBase
    {
        public TesteEntities Contexto
        {
            get
            {
                return _contexto;
            }
            set
            {
                _contexto = value;
            }
        }

        private TesteEntities _contexto;

        public RepositorioBase()
        {
            _contexto = new TesteEntities();
        }
    }
}
