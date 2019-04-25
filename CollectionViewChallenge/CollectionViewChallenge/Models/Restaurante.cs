namespace CollectionViewChallenge.Models
{
    public class Restaurante
    {
        public string Nome { get; private set; }
        public string Foto { get; private set; }

        public Restaurante(string nome, string foto)
        {
            Nome = nome;
            Foto = foto;
        }
    }
}