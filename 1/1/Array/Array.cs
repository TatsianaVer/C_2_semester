using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant11
{
    public class Array
    {
        private double[] _data;

        public Array(int size)
        {
            if (size <= 0) throw new ArgumentException("Size must be > 0", nameof(size));
            _data = new double[size];
        }

        public double[] Data
        {
            get => _data;
            set => _data = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}
