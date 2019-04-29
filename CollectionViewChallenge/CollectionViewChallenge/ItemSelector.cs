using System;
using Xamarin.Forms;
using CollectionViewChallenge.Models;

namespace CollectionViewChallenge {
    public class ItemSelector : DataTemplateSelector {

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container) {
            var ticket = (FlightTicket)item;
            if (ticket.IsFooter) return BlankFooter;
            else if (ticket.IsHeader) return BlankHeader;
            else return FlightTemplate;
        }
        public DataTemplate FlightTemplate { get; set; }
        public DataTemplate BlankHeader { get; set; }
        public DataTemplate BlankFooter { get; set; }
    }
}
