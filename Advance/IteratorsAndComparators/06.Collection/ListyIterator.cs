﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private readonly List<T> store;

        private int index;
        public ListyIterator(List<T> store)
        {
            this.store = store;
            this.index = 0;
        }

        public bool Move()
        {
            if (HasNext())
            {
                index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (index + 1 < store.Count)
            {
                return true;
            }
            return false;
        }

        public void Print()
        {
            Console.WriteLine(store[index]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in store)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        => this.GetEnumerator();
    }
}
