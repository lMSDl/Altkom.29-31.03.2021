﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.BehavioralPatterns.Visitor.I
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
