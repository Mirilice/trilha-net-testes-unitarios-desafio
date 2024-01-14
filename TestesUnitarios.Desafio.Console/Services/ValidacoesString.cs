namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesString
    {
        public int RetornarQuantidadeCaracteres(string texto)//quantidade de caracteres em string texto
        {
            var numeroCaracteres = texto.Length;
            return numeroCaracteres;
        }

        public bool ContemCaractere(string texto, string textoProcurado)//true ou false se o trecho procurado existe no texto
        {
            var contem = texto.Contains(textoProcurado);
            return contem;
        }

        public bool TextoTerminaCom(string texto, string textoProcurado)//true ou false se o trecho procurado existe no FINAL do texto, apenas
        {
            var termina = texto.EndsWith(textoProcurado);
            return termina;
        }
    }
}