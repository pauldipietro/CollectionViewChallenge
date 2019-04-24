using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CollectionViewChallenge.Enum;
using CollectionViewChallenge.Models;

namespace CollectionViewChallenge.ViewModels
{
    public class PodcastCollectionViewModel
    {
        public IList<GroupPodcast> PodcastList { get; private set; }

        public PodcastCollectionViewModel()
        {
            PodcastList = GetPodcasts();
        }

        private IList<GroupPodcast> GetPodcasts()
        {
            var podcasts = new List<Podcast>();

            podcasts.Add(new Podcast
            {
                Title = "The Joe Rogan Experience",
                Image = "http://static.libsyn.com/p/assets/7/1/f/3/71f3014e14ef2722/JREiTunesImage2.jpg",
                Author = "Joe Rogan",
                Category = "Top",
                CellType = Enum.PodcastCellType.Standard
            });

            podcasts.Add(new Podcast
            {
                Title = "The Daily",
                Image = "https://static01.nyt.com/images/2017/01/29/podcasts/the-daily-album-art/the-daily-album-art-square320-v4.png",
                Author = "The New York Times",
                Category = "Top",
                CellType = Enum.PodcastCellType.Standard
            });

            podcasts.Add(new Podcast
            {
                Title = "TED Radio Hour",
                Image = "https://media.npr.org/assets/img/2018/08/03/npr_ted_podcasttile_sq-f924b1a84a189479b7555a19b030778d88ee55f5.jpg?s=1400",
                Author = "NPR",
                Category = "Top",
                CellType = Enum.PodcastCellType.Standard
            });

            podcasts.Add(new Podcast
            {
                Title = "Stuff You Should Know",
                Image = "https://image-ticketfly.imgix.net/00/02/57/10/25-og.jpg?w=500&h=500",
                Author = "iHeartRadio",
                Category = "Top",
                CellType = Enum.PodcastCellType.Standard
            });

            podcasts.Add(new Podcast
            {
                Title = "This American Life",
                Image = "https://media.npr.org/images/podcasts/primary/icon_381444650-04c1bad8586e69edf04b78ea319846614c4a6a6b.png?s=1400",
                Author = "This American Life",
                Category = "Top",
                CellType = Enum.PodcastCellType.Standard
            });

            podcasts.Add(new Podcast
            {
                Title = "Planet Money",
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c7/NPR_Planet_Money_cover_art.jpg/220px-NPR_Planet_Money_cover_art.jpg",
                Author = "NPR",
                Category = "Top",
                CellType = Enum.PodcastCellType.Standard
            });

            podcasts.Add(new Podcast
            {
                Title = "The Daily Show with Trevor Noah",
                Image = "https://static.megaphone.fm/podcasts/34814bf8-e860-11e8-8bb2-6f3e1a98c859/image/uploads_2F1553887433220-tm6mswb02ve-81b991f0edef1e2d49524f20aaa20a8f_2FTDS_EARS_EDITION_COVER_ART_2019.jpg",
                Author = "Comedy Central",
                Category = "Trending",
                CellType = Enum.PodcastCellType.Standard
            });

            podcasts.Add(new Podcast
            {
                Title = "Kwik Brain with Jim Kwik",
                Image = "https://ssl-static.libsyn.com/p/assets/1/9/0/b/190b7fd25d03c103/KB_Podcast_cover_NEW.jpg",
                Author = "Jim Kwik",
                Category = "Trending",
                CellType = Enum.PodcastCellType.Standard
            });

            podcasts.Add(new Podcast
            {
                Title = "Crime Junkie",
                Image = "https://secureimg.stitcher.com/feedimageswide/480x270_160493.jpg",
                Author = "audiochuck",
                Category = "Trending",
                CellType = Enum.PodcastCellType.Standard
            });

            podcasts.Add(new Podcast
            {
                Title = "Getting Curious with Jonathan Van Ness",
                Image = "https://content.production.cdn.art19.com/images/2a/15/eb/b0/2a15ebb0-32de-4a48-8b0f-2739942cd331/23e99e4514262cbbf748fc123e0d6d9fe57af74d1e321ea4ea2e29262ed44629ad7e5f777ec365cd267b2803e83113d601f502673a83380d44289e89cee53fcf.jpeg",
                Author = "Jonathan Van Ness",
                Category = "Trending",
                CellType = Enum.PodcastCellType.Standard
            });

            podcasts.Add(new Podcast
            {
                Title = "The Watch",
                Image = "https://content.production.cdn.art19.com/images/f9/9a/35/e4/f99a35e4-7b6c-4c4b-b019-f63cf5c1ee20/43139e8bc00a28c088991ec4a05829aaed812a09c8776a9210f2b5e91009f790b913a334a3e25b202f76cd77017fe5adb9e48662646ddeef3a6dc4b44680d70c.jpeg",
                Author = "The Ringer",
                Category = "Trending",
                CellType = Enum.PodcastCellType.Standard
            });

            podcasts.Add(new Podcast
            {
                Title = "Sword and Scale",
                Image = "https://content.production.cdn.art19.com/images/68/70/e9/6f/6870e96f-3454-4091-bf0b-4baa2facdc2f/06b0d6317351688822b96ba3ed21c39845d9f68f5b5b0b41e01231c30d9c2088e382df34a0657f3e07b7a463e712d43463e754efe28fbcc1e21db738c6f9d7d7.jpeg",
                Author = "Incongruity True Crime",
                Category = "Society and Culture",
                CellType = Enum.PodcastCellType.Standard
            });

            podcasts.Add(new Podcast
            {
                Title = "Casefile True Crime",
                Image = "http://static.libsyn.com/p/assets/8/5/0/1/85019a2d38df195e/casefile_logo_final.jpg",
                Author = "Casefile True Crime",
                Category = "Society and Culture",
                CellType = Enum.PodcastCellType.Standard
            });

            podcasts.Add(new Podcast
            {
                Title = "Code Switch",
                Image = "https://media.npr.org/assets/img/2018/08/03/npr_codeswitch_podcasttile_sq-a396f0624532c150ed5b77cefd9065f863f9daf2.jpg?s=1400",
                Author = "NPR",
                Category = "Society and Culture",
                CellType = Enum.PodcastCellType.Standard
            });

            podcasts.Add(new Podcast
            {
                Title = "On the Media",
                Image = "https://thehustle.co/wp-content/uploads/2019/03/Onthemedia.jpg",
                Author = "WNYC Studios",
                Category = "Society and Culture",
                CellType = Enum.PodcastCellType.Standard
            });

            podcasts.Add(new Podcast
            {
                Title = "Radiolab",
                Image = "https://media.wnyc.org/i/raw/1/Radiolab_WNYCStudios_1400_2dq02Dh.png",
                Author = "WNYC Studios",
                Category = "Society and Culture",
                CellType = PodcastCellType.Standard
            });

            var tempList =  podcasts
                .GroupBy(podcast => podcast.Category)
                .Select(group => new GroupPodcast(group.Key, group.ToList()))
                .ToList();

            return tempList;
        }


    }
}
