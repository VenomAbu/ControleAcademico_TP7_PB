﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcademico
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }

        public Aluno(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }

        public Aluno()
        {
            Matricula = 0;
            Nome = "";
        }

        public void inserirNotas()
        {
            Console.WriteLine("Notas Inseridas de: " + Nome);
        }

        public override string ToString()
        {
            return "Matrícula: " + Matricula + " Nome: " + Nome;
        }
    }
}