﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcademico
{
    public class Professor
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }

        public Professor(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }

        public Professor()
        {
            Matricula = 0;
            Nome = "";
        }

        public void lancarNotas()
        {
            Console.WriteLine("Lançando as notas dos alunos.");
        }

        public override string ToString()
        {
            return "Matrícula: " + Matricula + " Nome: " + Nome;
        }
    }
}