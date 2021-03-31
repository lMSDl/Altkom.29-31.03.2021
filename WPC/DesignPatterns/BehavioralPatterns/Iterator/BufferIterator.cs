﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.Iterator
{
    public class BufferIterator<T> : IEnumerator<Tuple<T, T>>
    {
        private IEnumerator<T> _enumerator;
        private T _buffer;

        public BufferIterator(IEnumerable<T> enumerator)
        {
            _enumerator = enumerator.GetEnumerator();
            Reset();
        }

        public Tuple<T, T> Current { get; private set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _enumerator = null;
            Current = null;
            _buffer = default;
        }

        public bool MoveNext()
        {
            if(_enumerator.MoveNext())
            {
                Current = new Tuple<T, T>(_buffer, _enumerator.Current);
                _buffer = _enumerator.Current;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _enumerator.Reset();
            if (_enumerator.MoveNext())
            {
                _buffer = _enumerator.Current;
            }
            else
                _buffer = default;
            Current = null;
        }
    }
}
