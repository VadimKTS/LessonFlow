using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    internal class TestClass : IReadAndWrite, ISave
    {
        public void Read() { }
        public void Write() { }

        public void Save() { }
    }
}
