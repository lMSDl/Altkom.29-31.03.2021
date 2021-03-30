using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.StructuralPatterns.Adapter.I
{
    public class SquareToCircleAdapter : ICircle
    {
        private Square _sqare;

        public SquareToCircleAdapter(Square sqare)
        {
            _sqare = sqare;
        }

        public float Radius => _sqare.Width * (float)Math.Sqrt(2) / 2;
    }
}
