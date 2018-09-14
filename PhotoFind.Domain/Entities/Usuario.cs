using PhotoFind.Domain.Interfaces.Entities;
using PhotoFind.Domain.Values_Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PhotoFind.Domain.Entities
{
    public class Usuario : IUsuario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public Email Email { get; private set; }
        public Cpf CPF { get; private set; }
        public DateTime DataNascimento { get; private set; }
        private ICollection<Cadastro> _cadastros { get; set; }
        public ICollection<Cadastro> Cadastros { get { return _cadastros; } }

        public Usuario(string nome, string sobrenome, Email email, Cpf cpf, DateTime dataNascimento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            CPF = cpf;
            DataNascimento = dataNascimento;
        }

        public bool TemCadastroAtivo()
        {
            var retorno = Cadastros.Count(x => x.Ativo) > 0;
            return retorno;
        }

        public void CriarNovoCadastro(string senha)
        {
            if (!TemCadastroAtivo())
            {
                var cadastro = new Cadastro(senha);
                _cadastros.Add(cadastro);
            }
        }
    }
}
