using Dados;
using Modelo;

namespace Repositorio
{
    public static class PacienteConversao
    {
        internal static PacienteModelo ToPacienteModelo(this Paciente entity)
        {
            PacienteModelo to = new PacienteModelo();

            if (entity == null)
                return null;

            to.Id = entity.Id;
            to.Nascimento = entity.Nascimento;
            to.Nome = entity.Nome;
            to.NomeMae = entity.NomeMae;
            to.Sexo = (SexoEnum)entity.Sexo;

            return to;
        }

        internal static void Apply(this Paciente entity, PacienteModelo to)
        {
            entity.Nome = to.Nome;
            entity.NomeMae = to.NomeMae;
            entity.Nascimento = to.Nascimento;
            entity.Sexo = (int)to.Sexo;
        }
    }
}
