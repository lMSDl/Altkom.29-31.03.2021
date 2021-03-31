using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.StructuralPatterns.PrivateClassData
{
    public class SomeClassData
    {
        private int _data1;
        private string _data2;

        public SomeClassData(int data1, string data2)
        {
            _data1 = data1;
            _data2 = data2;
        }

        public string GetData2()
        {
            return _data2;
        }

        public int GetData1()
        {
            return _data1;
        }
    }
}
