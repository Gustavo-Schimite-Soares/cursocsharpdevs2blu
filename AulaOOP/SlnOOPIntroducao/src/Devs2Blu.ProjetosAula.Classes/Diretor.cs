﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Classes
{
    public class Diretor : Pessoa
    {
        public double ProLabore { get; set; }
        public Diretor() { }
        public Diretor(string nome, string sobreNome, double proLabore)
        {
            this.Nome = nome;
            this.SobreNome = sobreNome;
            this.ProLabore = proLabore;
        }
        public string VerificaStatus()
        {
            return "Hospital OK!";
        }
    }
}
