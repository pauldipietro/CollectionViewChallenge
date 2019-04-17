using CollectionViewChallenge.Models;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CollectionViewChallenge.ViewModels
{
    public class FortifyViewModel : BasePrioritiesViewModel
    {
        #region Properties

        public ObservableCollection<FortItem> Targets { get; }

        public string _ccBalance;
        public string CCBalance
        {
            get { return _ccBalance; }
            private set
            {
                if (_ccBalance != value)
                {
                    _ccBalance = value;
                    OnPropertyChanged(nameof(CCBalance));
                }
            }
        }

        #endregion

        public FortifyViewModel()
        {
            RetryDownloadCommand = new Command(() => GetFortTargets());
            Targets = new ObservableCollection<FortItem>();
        }

        private void GetFortTargets()
        {
            ShowMessage = false;
            Targets.Clear();
            try
            {
                // fake data
                Cycle = "Cycle 150";
                LastUpdated = DateTime.UtcNow;
                CCBalance = "853 CC";

                if (DateTime.Now.Minute % 2 == 0)
                {
                    throw new Exception("Test Error! This error fires on even minutes, wait for an odd minute and press Retry.");
                }

                Targets.Add(new FortItem("Xinca", "101 ly", "station", "343 ls", "independent"));
                Targets.Add(new FortItem("Ngarawe", "86 ly", "station", "35 ls", "empire"));
                Targets.Add(new FortItem("Yanerones", "115 ly", "planetary", "42 ls", "empire"));
                Targets.Add(new FortItem("Damoorai", "86 ly", "station", "1,324 ls", "empire"));
                Targets.Add(new FortItem("Ostyat", "117 ly", "station", "41 ls", "independent"));
                Targets.Add(new FortItem("Lopocares", "125 ly", "outpost", "329 ls", "federation"));
                Targets.Add(new FortItem("HIP 20524", "53 ly", "planetary", "2,192 ls", "empire"));
                Targets.Add(new FortItem("Amenta", "47 ly", "station", "236 ls", "empire"));
                Targets.Add(new FortItem("27 G. Caeli", "54 ly", "outpost", "3,145 ls", "independent"));
                Targets.Add(new FortItem("Kappa Reticuli", "81 ly", "planetary", "350 ls", "federation"));
            }
            catch (Exception ex)
            {
                Message = String.Format("Error downloading Fortification targets: {0}", ex.Message);
                ShowMessage = true;
                IsErrorMessage = true;
            }
        }

        protected override void RefreshView()
        {
            GetFortTargets();
        }
    }
}
