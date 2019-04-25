namespace CollectionViewChallenge.Models
{
    public class Categoria
    {
        public string Nome { get; private set; }
        public string Foto { get; private set; }

        public Categoria(string nome, string foto)
        {
            Nome = nome;
            Foto = foto;
        }
    }
}