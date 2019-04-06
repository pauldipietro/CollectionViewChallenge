using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using CollectionViewChallenge.Models;
using CollectionViewChallenge.Services;
using CollectionViewChallenge.ViewModels.Base;
using Xamarin.Forms;

namespace CollectionViewChallenge.ViewModels
{
    public class PlayersViewModel : BaseViewModel
    {
        private readonly IPlayersService _playersService;

        public PlayersViewModel()
        {
            _playersService = new PlayersService();
            var teamsService = new TeamsService();

            Task.Run(async () =>
            {
                Teams = await teamsService.GetTeams();
                Players = new ObservableCollection<Player>(await _playersService.GetPlayers());
            });

            LoadPlayersCommand = new Command(async () =>
            {
                await LoadPlayers(SelectedTeam.Acronym);
            });
        }

        private ObservableCollection<Player> _players;

        public ObservableCollection<Player> Players
        {
            get
            {
                return _players;
            }
            set
            {
                if (_players != value)
                {
                    _players = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private Team _selectedTeam;

        public Team SelectedTeam
        {
            get
            {
                return _selectedTeam;
            }
            set
            {
                if (_selectedTeam != value)
                {
                    _selectedTeam = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public IEnumerable<Team> Teams { get; set; }

        public ICommand LoadPlayersCommand { get; private set; }

        private async Task LoadPlayers(string team)
        {
            var players = await _playersService.GetPlayers(team);
            Players = new ObservableCollection<Player>(players);
        }
    }
}
