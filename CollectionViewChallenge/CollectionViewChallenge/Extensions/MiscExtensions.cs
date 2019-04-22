using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CollectionViewChallenge.Extensions
{
    public static class MiscExtensions
    {
        private static readonly string[] IllegalAssetCharacters = { " ", "-", "&" };
    
        public static string ToSafeAssetName(this string s)
        {
            foreach (var c in IllegalAssetCharacters)
                s = s.Replace(c, "");

            return s;
        }

        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> items)
            => new ObservableCollection<T>(items);
            
        public static HashSet<T> ToSet<T>(this IEnumerable<T> items)
            => new HashSet<T>(items);
    }
}
