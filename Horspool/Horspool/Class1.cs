using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Horspool
{
    public class Class1
    {

        int karsilastirmasayaci = 0;
        public int eslesmesayaci = 0;
        public int retkarsi = 0;

        public List<int> Find(string haystack, string needle)
        {

            List<int> indexlist = new List<int>();

            // If substring is bigger than string, no match exists
            if (needle.Length > haystack.Length)
                return indexlist;

            // If the substring has characters not in the string, no match exists
            if (needle.Except(haystack).Any())
                return indexlist;

            Dictionary<char, int> BadMatchTable = new Dictionary<char, int>();

            // Initializes every letter with the default value
            foreach (char c in haystack)
            {
                if (!BadMatchTable.Keys.Contains(c))
                    BadMatchTable.Add(c, needle.Length);
            }

            // The formula for every letter in the needle (except the last) is lenght - index - 1
            for (int i = 0; i < needle.Length - 1; i++)
            {
                BadMatchTable[needle[i]] = needle.Length - i - 1;
            }

            int index = 0;
            while (index <= haystack.Length - needle.Length)
            {
                bool match = true;
                for (int i = needle.Length - 1; i >= 0; i--)
                {
                    if (needle[i] != haystack[index + i])
                    {
                        match = false;
                        index = index + BadMatchTable[haystack[index + needle.Length - 1]];
                        karsilastirmasayaci = karsilastirmasayaci + 1;
                    }
                }
                if (match)
                {
                    indexlist.Add(index);
                    index = index + 1;
                    eslesmesayaci = eslesmesayaci + 1;

                    // return indexlist;
                }

            }
            retkarsi = karsilastirmasayaci;
            return indexlist;
        }
        public int Karsi()
        {
            return karsilastirmasayaci;
        }

        public int Esle()
        {
            return eslesmesayaci;
        }
    }
}