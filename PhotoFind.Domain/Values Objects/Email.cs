namespace PhotoFind.Domain.Values_Objects
{
    public class Email
    {
        public string Valor { get; private set; }

        public bool NovoEmail(string email)
        {
            Valor = email;
            return true;
        }

        public override string ToString()
        {
            return Valor;
        }
    }
}
