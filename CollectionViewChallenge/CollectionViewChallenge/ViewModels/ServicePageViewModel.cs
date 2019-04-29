using CollectionViewChallenge.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace CollectionViewChallenge.ViewModels
{
    class ServicePageViewModel : Xamarin.Forms.BindableObject
    {
        public ServicePageViewModel()
        {
            selectedService = ServiceList[0];
            selectedCaseStudy = CaseStudyList[0];
        }

        private ObservableCollection<ServiceModel> serviceList { get; set; }

        public ObservableCollection<ServiceModel> ServiceList
        {
            get
            {
                return serviceList ?? (serviceList = FakeServiceList());
            }
        }

        private ObservableCollection<ServiceModel> FakeServiceList()
        {
            var fakeList = new ObservableCollection<ServiceModel>();

            fakeList.Add(new ServiceModel() { Name = "Xamarin", Description="Mobile solution", Icon= "xamarin.png" });
            fakeList.Add(new ServiceModel() { Name = "Sitecore", Description = "Web solution", Icon = "sitecore.png" });
            fakeList.Add(new ServiceModel() { Name = "SharePoint", Description = "Intranet solution", Icon = "sharepoint.png" });
            fakeList.Add(new ServiceModel() { Name = "Azure", Description = "Cloud solution", Icon = "azure.png" });

            return fakeList;
        }
        private ObservableCollection<CaseStudyModel> caseStudyList { get; set; }

        public ObservableCollection<CaseStudyModel> CaseStudyList
        {
            get
            {
                return caseStudyList ?? (caseStudyList = FakeCaseStudyList(ServiceList[0].Name, ServiceList[0].Icon));
            }
            set
            {
                caseStudyList = value;
                OnPropertyChanged("CaseStudyList");
            }
        }

        private ObservableCollection<CaseStudyModel> FakeCaseStudyList(string service, string image)
        {
            var fakeList = new ObservableCollection<CaseStudyModel>();

            Random random = new Random();
            int num = random.Next(3, 10);

            for (int i = 1; i < num; i++)
            {
                fakeList.Add(new CaseStudyModel() { Project =  string.Format("{0} - Proyect {1}", service, i), Quote = "\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.\"", Icon = image, Company = string.Format("Company {0}", i) });
            }

            return fakeList;
        }

        private ServiceModel selectedService;

        public ServiceModel SelectedService
        {
            get
            {
                return selectedService;
            }
            set
            {
                if (selectedService != value)
                {
                    selectedService.Animate = false;
                    selectedService = value;
                    selectedService.Animate = true;
                    MessagingCenter.Send(this, "ScrollToSelectedService", serviceList.IndexOf(selectedService));
                    CaseStudyList = FakeCaseStudyList(selectedService.Name, SelectedService.Icon);
                }
            }
        }

        private CaseStudyModel selectedCaseStudy;

        public CaseStudyModel SelectedCaseStudy
        {
            get
            {
                return selectedCaseStudy;
            }
            set
            {
                if (selectedCaseStudy != value)
                {
                    selectedCaseStudy.ShowQuote = false;
                    selectedCaseStudy = value;
                    selectedCaseStudy.ShowQuote = true;
                }
            }
        }
    }
}
