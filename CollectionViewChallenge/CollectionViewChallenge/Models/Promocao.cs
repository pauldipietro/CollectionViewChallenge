using System;

namespace CollectionViewChallenge.Models
{
    public class Promocao
    {
        public string Id { get; private set; }
        public string Descricao { get; private set; }
        public string Foto { get; private set; }

        public Promocao(string descricao, string foto)
        {
            Id = Guid.NewGuid().ToString();
            Descricao = descricao;
            Foto = foto;
        }
    }
}