using PhotoFind.Domain.Interfaces.Entities;
using System;

namespace PhotoFind.Domain.Entities
{
    public class Cadastro : ICadastro
    { 
        public int Id { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime DataExclusao { get; private set; }
        public bool Ativo { get; private set; }

        public Cadastro(string senha)
        {
            Senha = senha;
            DataCadastro = DateTime.Now;
            Ativo = true;
        }

        public void InativarCadastro()
        {
            DataExclusao = DateTime.Now;
            Ativo = false;
        }
    }
}