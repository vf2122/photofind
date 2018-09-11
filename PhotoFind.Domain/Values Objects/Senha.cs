using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoFind.Domain.Values_Objects
{
    public class Senha
    {
        public string Valor { get; set; }
        public Senha(string senha)
        {
            Valor = senha;
        }

        public override string ToString()
        {
            return Valor;
        }
    }
}
