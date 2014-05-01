﻿using System;
using System.Collections.Generic;
using de4dot.blocks;
using ILAST.AST.Base;
using ILAST.Visitor;
using ILAST.Visitor.Base;

namespace ILAST.AST
{
    public class LiteralLongExpression : Expression
    {
        public LiteralLongExpression(Instr instr)
            : base(instr)
        {
        }

        public override void Populate()
        {
            throw new NotImplementedException();
        }

        public long Value { get; set; }
        public override int ElementSize { get { return 1; } }
        public override bool CanSimplify { get { return false; } }

        public override IEnumerable<Element> RemovableElements
        {
            get { throw new System.NotImplementedException(); }
        }

        public override void AcceptVisitor(ElementVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return Value.ToString("x8") + "h";
        }
    }
}