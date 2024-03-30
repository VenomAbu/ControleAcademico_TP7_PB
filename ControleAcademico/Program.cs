using System;
using System.Collections.Generic;

namespace ControleAcademico
{
    public class Program
    {
        static void Main(string[] args)
        {
            Disciplina disciplina = new Disciplina(1, "Java");
            Professor professor = new Professor(1, "Elberth");
            Turma turma = new Turma(1, disciplina);

            Aluno aluno1 = new Aluno(1, "Mario");
            Aluno aluno2 = new Aluno(2, "Luigi");
            Aluno aluno3 = new Aluno(3, "Wario");

            Console.WriteLine(turma.addAluno(aluno1));
            Console.WriteLine(turma.addAluno(aluno2));
            Console.WriteLine(turma.addAluno(aluno3));

            Console.WriteLine(turma.gerarPauta());

            Console.WriteLine(aluno1);
            Console.WriteLine(professor);
            Console.WriteLine(turma);
        }

    }
}