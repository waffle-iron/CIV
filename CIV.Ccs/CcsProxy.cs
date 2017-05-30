﻿using System.Collections.Generic;
using static CIV.Ccs.CcsParser;
using CIV.Interfaces;
using System;

namespace CIV.Ccs
{
    /// <summary>
    /// Proxy class that delays the creation of a new Process instance until it
    /// is needed.
    /// </summary>
    class CcsProxy : CcsProcess
    {
        Proxy<CcsProcess, ProcessContext> proxy;

        public CcsProxy(ProcessFactory factory, ProcessContext context)
        {
            proxy = new Proxy<CcsProcess, ProcessContext>(factory, context);
        }

        public override bool Equals(CcsProcess other) => proxy.Real.Equals(other);

        public override IEnumerable<Transition> Transitions() => proxy.Real.Transitions();


    }
}
