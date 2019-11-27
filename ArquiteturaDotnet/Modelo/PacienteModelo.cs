using System;

namespace Modelo
{
    public class PacienteModelo
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string NomeMae { get; set; }

        public DateTime? Nascimento { get; set; }

        public SexoEnum Sexo { get; set; }
    }

    public enum SexoEnum
    {
        Masculino = 1,
        Feminino = 2,
        NaoInformado = 0
    };
}
