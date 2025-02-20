﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP2Classes
{
    public class Contato
    {
        public String Nome { get; set; }
        public String TelCel { get; set; }
        public String Email { get; set; }
        public String CEP { get; set; }
        public String Estado { get; set; }
        public String Cidade { get; set; }
        public String Bairro { get; set; }
        public String Rua { get; set; }
        public String Texto { get; set; }

        public Contato() {}
        public Contato(string nome, string telCel, string email, string cep, string estado, string cidade, string bairro, string rua, string texto)
        {
            Nome = nome;
            TelCel = telCel;
            Email = email;
            CEP = cep;
            Estado = estado;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            Texto = texto;
        }
    }
}
