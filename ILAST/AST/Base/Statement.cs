﻿using dnlib.DotNet.Emit;

namespace ILAST.AST.Base
{
    public abstract class Statement : Element
    {
        protected Statement(Instruction instr)
            : base(instr)
        {
        }
    }
}