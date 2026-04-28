using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instituição
{
    internal class Matricula
    {
        public Aluno Aluno { get; set; }
        public Disciplina Disciplina { get; set; }
        public Turma Turma { get; set; }
        public override bool Equals(Object obj)
        {
            if (obj is Matricula)
            {
                Matricula m = obj as Matricula;
                return (this.Aluno.RegistroAcademico.Equals(m.Aluno.RegistroAcademico) &&
                this.Disciplina.Nome.Equals(m.Disciplina.Nome) &&
                this.Turma.CodigoTurma.Equals(m.Turma.CodigoTurma));
            }
            return false;
        }
    }
}
