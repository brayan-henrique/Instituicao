using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Instituição.Departamentos;

namespace Instituição
{
    internal class Instituicao
    {
        public String Nome { get; set; }
        public Endereco Endereco { get; set; }
        public Departamentos[] Departamentos
        { get; } = new Departamentos[10];
        public void nome(string nome)
        {
            this.Nome = nome;
        }
        private int quantidadeDepartamentos = 0;

        public void RegistrarDepartamento(Departamentos d)
        {
            if (quantidadeDepartamentos < 10)
                Departamentos[quantidadeDepartamentos++] = d;
        }

        public int ObterQuantidadeDepartamentos()
        {
            return quantidadeDepartamentos;
        }
    }
}
