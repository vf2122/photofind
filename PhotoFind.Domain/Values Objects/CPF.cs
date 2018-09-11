namespace PhotoFind.Domain.Values_Objects
{
    public class Cpf
    {
        public string Valor { get; private set; }

        public bool CadastrarCpf(string cpf) {

            Valor = cpf;
            return true;
        }

        public override string ToString()
        {
            return Valor;
        }
    }
}
