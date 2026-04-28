using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instituição
{
    internal class Graduacao: Curso
    {
        public int Semestres { get; set; }
    }
}
namespace Instituição
{
    internal class PosGraduacao : Curso
    {
        public int Creditos { get; set; }
    }
}
namespace Instituição
{
    internal class LatoSensu : PosGraduacao
    {
        public int Semestres { get; set; }
    }
}
namespace Instituição
{
    internal class StrictoSensu : PosGraduacao
    {
        public IList<string> LinhasDePesquisa { get; } = new List<string>();
    }
}