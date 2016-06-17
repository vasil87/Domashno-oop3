

namespace domashno_po_Linq
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
  
    public static class IenumerableExtension

    {
        public static long Sum(this IEnumerable<int> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            long num = 0;
        
             foreach (int current in source)
             {
                 num += current;
             }
             return num;
         
        }

        public static long? Sum(this IEnumerable<int?> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            long num = 0;
            
                foreach (int? current in source)
                {
                    if (current.HasValue)
                    {
                        num += current.GetValueOrDefault();
                    }
                }
                return new long?(num);
            
        }

        public static long Sum(this IEnumerable<long> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");

            }

            long num = 0;

            foreach (var item in source)
            {
                num += item;
            }

            return num;
        }

        public static long? Sum(this IEnumerable<long?> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");

            }

            long num = 0;

            foreach (var item in source)
            {
               if(item.HasValue) num += item.GetValueOrDefault();
            }

            return new long?(num);
        }

        public static double Sum(this IEnumerable<double> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");

            }

            double num = 0.0;

            foreach (var item in source)
            {
                num += item;
            }

            return num;
        }

        public static double? Sum(this IEnumerable<double?> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");

            }

            double num = 0.0;

            foreach (var item in source)
            {
               if(item.HasValue)num += item.GetValueOrDefault();
            }

            return new double?(num);
        }

        public static BigInteger Product(this IEnumerable<int> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");

            }

            BigInteger num = 1;

            foreach (var item in source)
            {
                num *= item;
            }

            return num;
        }

        public static int Min(this IEnumerable<int> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");

            }

            int num = int.MaxValue;

            foreach (var item in source)
            {
                if (num > item) num = item;
            }

            return num;
        }

        public static int? Min(this IEnumerable<int?> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");

            }

            int num = int.MaxValue;

            foreach (var item in source)
            {
                if (item.HasValue)
                    if (num > item) num = item.GetValueOrDefault();

            }

            return new int?(num);
        }

        public static int Max(this IEnumerable<int> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");

            }

            int num = int.MinValue;

            foreach (var item in source)
            {
                if (num < item) num = item;
            }

            return num;
        }

        public static int? Max(this IEnumerable<int?> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");

            }

            int num = int.MinValue;

            foreach (var item in source)
            {
                if (item.HasValue)
                    if (num < item) num = item.GetValueOrDefault();

            }

            return new int?(num);
        }

        public static double Average(this IEnumerable<int> source)
        {
            int count = 0;
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            int num = 0;
            
                foreach (int current in source)
                {
                    num += current;
                count++;
                }
            
            return num/(double)count;
            
        }

    }
}
