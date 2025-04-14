using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant11
{
    public class CreateArrayC
    {
        public Array Create(Array a, Array b, int index)
        {
            var partB = new MinLeft().Execute(b.Data);
            var partA = new MinRightTo().Execute(a.Data, index);
            return new Array(partB.Length + partA.Length)
            {
                Data = partB.Concat(partA).ToArray()
            };
        }
    }
}
