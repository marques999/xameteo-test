using System;
using System.Collections.Generic;

namespace XameteoTest
{
    /// <summary>
    /// 
    /// </summary>
    internal static class LinqExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static TSource MinBy<TSource>(this IEnumerable<TSource> source, Func<TSource, IComparable> comparer)
        {
            using (var e = source.GetEnumerator())
            {
                if (e.MoveNext() == false)
                {
                    throw new InvalidOperationException();
                }

                var minimum = e.Current;
                var minimumProjection = comparer(e.Current);

                while (e.MoveNext())
                {
                    var currentProjection = comparer(e.Current);

                    if (currentProjection.CompareTo(minimumProjection) >= 0)
                    {
                        continue;
                    }

                    minimum = e.Current;
                    minimumProjection = currentProjection;
                }

                return minimum;
            }
        }
    }
}