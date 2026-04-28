using System;
using System.Linq;
using Instituição;

namespace Instituição
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var dptoAlimentos = new Departamentos { Nome = "Alimentos" };

            dptoAlimentos.RegistrarCurso(
                new Curso { Nome = "Tecnologia em Alimentos", CargaHoraria = 2000 });
            dptoAlimentos.RegistrarCurso(
                new Curso { Nome = "Engenharia de Alimentos", CargaHoraria = 3000 });

            Console.WriteLine();
            Console.WriteLine($"Cursos no departamento de {dptoAlimentos.Nome}:");
            foreach (var curso in dptoAlimentos.Cursos)
            {
                Console.WriteLine($"=> {curso.Nome} ({curso.CargaHoraria}h)");
            }

            var ctAlimentos = new Curso
            {
                Nome = "Tecnologia em Alimentos",
                CargaHoraria = 2000
            };
            var graduacao = new Graduacao() { Nome = "Curso de Graduação" };
            var latoSensu = new LatoSensu() { Nome = "Curso de Lato Sensu" };
            var strictoSensu = new StrictoSensu() { Nome = "Curso de Stricto Sensu" };
            var repositorioCursos = new RepositorioCurso();
            repositorioCursos.Gravar(graduacao);
            repositorioCursos.Gravar(latoSensu);
            repositorioCursos.Gravar(strictoSensu);
            Console.WriteLine("Cursos gravados");
            foreach (var curso in repositorioCursos.ObterTodos())
            {
                Console.WriteLine($"==> {curso.Nome} ({curso.GetType()})");
            }
            // Verifica a existência por nome para evitar depender da implementação de Equals
            if (!dptoAlimentos.Cursos.Any(c => c.Nome == ctAlimentos.Nome))
            {
                dptoAlimentos.RegistrarCurso(ctAlimentos);
                Console.WriteLine();
                Console.WriteLine("Curso 'Tecnologia em Alimentos' registrado.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Curso 'Tecnologia em Alimentos' já existe no departamento.");
            }

            Console.WriteLine();
            Console.WriteLine($"Quantidade de cursos: {dptoAlimentos.ObterQuantidadeDeCursos()}");

            // Fecha o departamento (usa o método existente nas classes do projeto)
            dptoAlimentos.Fechardepartamento();
            Console.WriteLine("O departamento foi fechado e os cursos removidos.");
            Console.WriteLine($"Quantidade de cursos após fechamento: {dptoAlimentos.ObterQuantidadeDeCursos()}");

            Console.WriteLine();

            var cursoCC = new Curso() { Nome = "Ciência da Computação", CargaHoraria = 3000 };
            cursoCC.RegistrarDisciplina(new Disciplina() { Nome = "Algoritmos", CargaHoraria = 80 });
            cursoCC.RegistrarDisciplina(new Disciplina() { Nome = "Orientação a Objetos", CargaHoraria = 60 });
            cursoCC.RegistrarDisciplina(new Disciplina() { Nome = "Orientação a Objetos", CargaHoraria = 80 });
            cursoCC.RegistrarDisciplina(new Disciplina() { Nome = "Estrutura de Dados", CargaHoraria = 80 });
            cursoCC.RegistrarDisciplina(new Disciplina() { Nome = "Programação para web", CargaHoraria = 80 });

            Console.WriteLine($"O curso {cursoCC.Nome} possui {cursoCC.Disciplinas.Count} disciplinas:");
            foreach (var d in cursoCC.Disciplinas)
            {
                Console.WriteLine($"=> {d.Nome} ({d.CargaHoraria}h)");
            }

            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }
        var turma = new Turma()
        {
            CodigoTurma = "1",
            PeriodoCurso = PeriodoCursoEnum.Primeiro,
            TurnoTurma = TurnoTurmaEnum.Matutino
        };
        var aluno = new Aluno() { RegistroAcademico = "1", Nome = "Asdrubal" };
        var cursoCC = new Graduacao() { Nome = "Ciência da Computação", CargaHoraria = 3000 };
        cursoCC.RegistrarAluno(aluno);
cursoCC.RegistrarTurma(turma);
foreach (var d in cursoCC.Disciplinas)
{
turma.RegistrarMatricula(new Matricula()
        {
            Aluno = aluno,
Disciplina = d
});
}
}
}