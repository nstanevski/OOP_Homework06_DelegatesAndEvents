using System;
using System.Collections.Generic;

namespace _01_CustomLINQExtensionMethods
{
    public static class Extensions
    {

        public static IEnumerable<T> WhereNot<T>
            (this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var matches = new List<T>();
            foreach (var element in collection)
            {
                if (predicate(element))
                {
                    matches.Add(element);
                }
            }
            return matches;
        }

        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection,
            Func<TSource, TSelector> function) where TSelector : IComparable<TSelector>
        {
            if(collection == null)
            {
                throw new ArgumentNullException("collection");
            }

            TSelector maxSelector = default(TSelector);
        
            bool first = true;
            foreach (var item in collection)
            {
                if (first)
                {
                    first = false;
                    maxSelector = function(item);
                }
                else
                {
                    TSelector currentSelector = function(item); 
                    if (currentSelector.CompareTo(maxSelector) == 1)
                    {
                        maxSelector = currentSelector;
                    }
                }
            }
            return maxSelector;
        }
    }
}

