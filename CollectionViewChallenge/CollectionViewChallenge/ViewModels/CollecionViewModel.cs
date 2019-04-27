using CollectionViewChallenge.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CollectionViewChallenge.ViewModels
{
    public class CollecionViewModel : BaseViewModel
    {
        private ObservableCollection<Anime> _listaAnimes;

        public ObservableCollection<Anime> ListaAnimes
        {
            get { return _listaAnimes; }
            set
            {
                SetProperty(ref _listaAnimes, value);
            }
        }

        public CollecionViewModel()
        {
            ListaAnimes = new ObservableCollection<Anime>()
            {
                new Anime{  Imagem = new Uri("https://img1.ak.crunchyroll.com/i/spire3/defc9dc5865e0be33eb3b0326abf28361547765748_full.jpg"),Nome = "Sword Art Online" , NumeroVideos = 150},
                new Anime{  Imagem = new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQFEpxqYtVt28N364gASnJD-Er9QIPAr1uPwQTo23Jgon4w_R_r"),Nome = "Naruto	" , NumeroVideos = 900},
                new Anime{  Imagem = new Uri("https://img1.ak.crunchyroll.com/i/spire1/281089c6a9e64236a10e3b4232474e411532451975_full.jpg"),Nome = "My hero academy" , NumeroVideos = 100},
                new Anime{  Imagem = new Uri("https://img1.ak.crunchyroll.com/i/spire3/cbb55a6382682bf71e91f685c6473c5a1487736090_full.jpg"),Nome = "Hunter X Hunter" , NumeroVideos = 200},
                new Anime{  Imagem = new Uri("https://img1.ak.crunchyroll.com/i/spire3/f1fe5c7a43cb2f38f4152a58f89479821554508873_full.jpg"),Nome = "Demon Slayer" , NumeroVideos = 3},
                new Anime{  Imagem = new Uri("https://cdn.animeultima.tv/cover-photo/1034/y3nb92t2npzi9trviVbOrreBfZu0Jts0EiMRW4yr.jpeg"),Nome = "The Rising of Shield" , NumeroVideos = 33},
                new Anime{  Imagem = new Uri("https://img1.ak.crunchyroll.com/i/spire1/c0d08a06dae2ed2877cd15e303df87491533959656_full.jpg"),Nome = "Black Clover" , NumeroVideos = 70},
                new Anime{  Imagem = new Uri("https://img1.ak.crunchyroll.com/i/spire2/c33592b4651e7cccf7ec66244e0f8ee81555537663_full.jpg"),Nome = "Bungo stray dogs" , NumeroVideos = 36},
                new Anime{  Imagem = new Uri("https://img1.ak.crunchyroll.com/i/spire2/9adde4f9cc8b426d323003388462d70b1551299649_full.jpg"),Nome = "Boruto" , NumeroVideos = 50}
            };
        }
    }
}
