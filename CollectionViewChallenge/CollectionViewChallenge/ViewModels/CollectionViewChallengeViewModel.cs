using CollectionViewChallenge.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectionViewChallenge.ViewModels
{
    public class CollectionViewChallengeViewModel : BaseViewModel
    {
        public ObservableCollection<Character> Characters { get; set; }
        public Command LoadCharactersCommand { get; set; }

        public CollectionViewChallengeViewModel()
        {
            Title = "Marvel's Super Heroes";
            Characters = new ObservableCollection<Character>();
            LoadCharactersCommand = new Command(async () => await ExecuteLoadCharactersCommand());
        }
        async Task ExecuteLoadCharactersCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Characters.Clear();
                var items = await MarvelServices.GetCharactersAsync(true);
                foreach (var item in items)
                {
                    Characters.Add(item);
                }
            }
            catch (Exception ex)
            {
                //Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
