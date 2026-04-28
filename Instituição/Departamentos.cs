using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Instituição
{
    internal class Departamentos
    {
        public string Nome { get; set; }
        public IList<Curso> Cursos { get; } = new List<Curso>();
        public void RegistrarCurso(Curso c)
        {
            Cursos.Add(c);
        }
        public int ObterQuantidadeDeCursos()
        {
            return Cursos.Count;
        }
        public Curso ObterCursoPorIndice(int indice)
        {
            return Cursos[indice];
        }
        public void Fechardepartamento()
        {
            while (Cursos.Count > 0)
            {
                Cursos.RemoveAt(0);
            }
        }
        public Curso ObterCursoPorNome(string nome)
        {
            return Cursos.Where<Curso>(n => n.Nome.Equals(nome)).FirstOrDefault();
        }
    }
}
