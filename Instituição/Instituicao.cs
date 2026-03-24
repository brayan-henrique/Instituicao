using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instituição
{
    internal class Instituicao
    {
        public String Nome { get; set; }
        public String Endereço { get; set; }
        public Departamentos[] departamentos { get; set; } =
            new Departamentos[10];

        int posicaoDepartamento = 0;

        public void GerarDepartamentos(Departamentos d)
        {
            if (posicaoDepartamento < 10)
            {
                departamentos[posicaoDepartamento++] = d;

            }
        }
        public void ListarDepartamentos()
        {
            for (int i = 0; i < posicaoDepartamento; i++)
            {
                Console.WriteLine(departamentos[i].Nome);
            }
        }
    }
}
