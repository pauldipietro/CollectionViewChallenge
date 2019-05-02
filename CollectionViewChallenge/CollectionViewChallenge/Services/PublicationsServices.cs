using System;
using System.Collections.Generic;
using CollectionViewChallenge.Models;

namespace CollectionViewChallenge.Services
{
    public class PublicationsService
    {
        public List<Publication> GetPublication()
        {
            var publication = new List<Publication>
            {
                new Publication
                {
                    Title="Xamarin.Forms 3.5: A Little Bindable Love",
                    Author="Andrei Nitescu",
                    Description="This is a guest post contributed " +
                    "by Andrei Nitescu, a mobile developer since 2013 and frequent contributor to Xamarin.Forms. " +
                    "He shares about his experiences with other developers on his blog, and delivering talks whenever " +
                    "he has the chance.",
                    ImageAuthor="https://i-h2.pinimg.com/564x/14/35/14/1435144bc9e23976e6dbcdce1232db6c.jpg",
                    ImagePost="https://i.pinimg.com/originals/00/f6/53/00f65310af25334f09398664fd50d8e4.png"
                },
                new Publication
                {
                    Title="Accessing Native Features the Cross-Platform Way with Xamarin.Essentials",
                    Author="James Montemagno",
                    Description="Every mobile application requires access to native " +
                    "functionality. When developing native mobile apps with Xamarin, developers are able to integrate " +
                    "deeply into iOS and Android since Xamarin exposes every API directly in C# to access these features. " +
                    "To help streamline and simplify development when needing to add native features to apps we are pleased to " +
                    "introduce Xamarin.Essentials, a new library that abstracts these native APIs into a set of cross-platform APIs. " +
                    "This means that you now have access to over 30 native features from single APIs that can be called directly from " +
                    "your shared business logic.",
                    ImageAuthor="https://i.pinimg.com/originals/a1/e1/ad/a1e1adb8aac40da7a3db573ed3ab00d5.jpg",
                    ImagePost="https://i.pinimg.com/originals/63/79/1b/63791b0be417193fe64faa02769bd47e.png"
                },
                new Publication
                {
                    Title="Xamarin.Forms 4.0 Feature Preview: An Entirely New Point of (Collection)View",
                    Author="Paul DiPietro",
                    Description="As part of the upcoming Xamarin.Forms 4.0 release, we are implementing the all new CollectionView " +
                    "control. The CollectionView is intended to be a successor to the ListView, improving upon its design by " +
                    "reducing technical complexity and allowing for more flexibility of layout and function. But we’re not stopping " +
                    "there! Along with this also comes the long-awaited CarouselView.",
                    ImageAuthor="https://i.pinimg.com/originals/2e/a5/3d/2ea53d53e7ffa08bcfd2590777d60060.png",
                    ImagePost="https://i.pinimg.com/originals/e5/ad/aa/e5adaadd82de9c01c4a71c126c154c55.png"
                },
                new Publication
                {
                    Title="The Future of Mobile Development: Xamarin.Forms 4.0 Preview",
                    Author="David Ortinau",
                    Description="Yesterday at Microsoft Connect(); 2018 we announced our plans for Xamarin.Forms 4.0 and shared a public preview. " +
                    "Let’s now take a deeper look at the big changes, starting with Xamarin.Forms Shell, and then touch some of the other highlights. " +
                    "Through countless interviews, conversations, and surveys, we have heard your voice loud and clear. You want Xamarin.Forms to be easier to " +
                    "use “out of the box”, navigation to be ever present and easier to control, to have a more consistent design across iOS and Android, and to " +
                    "have a faster, more flexible list control. Get ready to preview Xamarin.Forms 4.0, which delivers on all those top feedback themes and so " +
                    "much more with Shell, Visual, and CollectionView.",
                    ImageAuthor="https://i.pinimg.com/originals/66/5b/15/665b15540b99c3a3021b072160e9be57.png",
                    ImagePost="https://i.pinimg.com/originals/1c/76/e0/1c76e04db828b4d05aece458d0698418.jpg"
                },
                new Publication
                {
                    Title="Xamarin.Forms 3.5: A Little Bindable Love",
                    Author="Andrei Nitescu",
                    Description="This is a guest post contributed " +
                    "by Andrei Nitescu, a mobile developer since 2013 and frequent contributor to Xamarin.Forms. " +
                    "He shares about his experiences with other developers on his blog, and delivering talks whenever " +
                    "he has the chance.",
                    ImageAuthor="https://i-h2.pinimg.com/564x/14/35/14/1435144bc9e23976e6dbcdce1232db6c.jpg",
                    ImagePost="https://i.pinimg.com/originals/00/f6/53/00f65310af25334f09398664fd50d8e4.png"
                },
                new Publication
                {
                    Title="Accessing Native Features the Cross-Platform Way with Xamarin.Essentials",
                    Author="James Montemagno",
                    Description="Every mobile application requires access to native " +
                    "functionality. When developing native mobile apps with Xamarin, developers are able to integrate " +
                    "deeply into iOS and Android since Xamarin exposes every API directly in C# to access these features. " +
                    "To help streamline and simplify development when needing to add native features to apps we are pleased to " +
                    "introduce Xamarin.Essentials, a new library that abstracts these native APIs into a set of cross-platform APIs. " +
                    "This means that you now have access to over 30 native features from single APIs that can be called directly from " +
                    "your shared business logic.",
                    ImageAuthor="https://i.pinimg.com/originals/a1/e1/ad/a1e1adb8aac40da7a3db573ed3ab00d5.jpg",
                    ImagePost="https://i.pinimg.com/originals/63/79/1b/63791b0be417193fe64faa02769bd47e.png"
                },
                new Publication
                {
                    Title="Xamarin.Forms 4.0 Feature Preview: An Entirely New Point of (Collection)View",
                    Author="Paul DiPietro",
                    Description="As part of the upcoming Xamarin.Forms 4.0 release, we are implementing the all new CollectionView " +
                    "control. The CollectionView is intended to be a successor to the ListView, improving upon its design by " +
                    "reducing technical complexity and allowing for more flexibility of layout and function. But we’re not stopping " +
                    "there! Along with this also comes the long-awaited CarouselView.",
                    ImageAuthor="https://i.pinimg.com/originals/2e/a5/3d/2ea53d53e7ffa08bcfd2590777d60060.png",
                    ImagePost="https://i.pinimg.com/originals/e5/ad/aa/e5adaadd82de9c01c4a71c126c154c55.png"
                },
                new Publication
                {
                    Title="The Future of Mobile Development: Xamarin.Forms 4.0 Preview",
                    Author="David Ortinau",
                    Description="Yesterday at Microsoft Connect(); 2018 we announced our plans for Xamarin.Forms 4.0 and shared a public preview. " +
                    "Let’s now take a deeper look at the big changes, starting with Xamarin.Forms Shell, and then touch some of the other highlights. " +
                    "Through countless interviews, conversations, and surveys, we have heard your voice loud and clear. You want Xamarin.Forms to be easier to " +
                    "use “out of the box”, navigation to be ever present and easier to control, to have a more consistent design across iOS and Android, and to " +
                    "have a faster, more flexible list control. Get ready to preview Xamarin.Forms 4.0, which delivers on all those top feedback themes and so " +
                    "much more with Shell, Visual, and CollectionView.",
                    ImageAuthor="https://i.pinimg.com/originals/66/5b/15/665b15540b99c3a3021b072160e9be57.png",
                    ImagePost="https://i.pinimg.com/originals/1c/76/e0/1c76e04db828b4d05aece458d0698418.jpg"
                }
            };

            return publication;
        }
    }
}
