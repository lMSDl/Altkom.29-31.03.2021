using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.StructuralPatterns.PrivateClassData
{
    public class SomeClass
    {
        private SomeClassData _data;
        private float _data3;

        private readonly int _data4;
        public int Data5 { get; }

        public SomeClass(int data1, string data2, float data3)
        {
            _data = new SomeClassData(data1, data2);
            _data3 = data3;

            _data4 = 5;
            Data5 = 6;
        }

        public string GetData2()
        {
            return _data.GetData2();
        }

        public int GetData1()
        {
            return _data.GetData1();
        }

        public void SomeAction()
        {
            _data3 = 3;
        }
    }
}
