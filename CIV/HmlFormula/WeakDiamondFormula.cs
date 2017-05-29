﻿using System.Collections.Generic;
using System.Linq;
using CIV.Ccs;

namespace CIV.HmlFormula
{
    public class WeakDiamondFormula : HmlLabelFormula
    {
        protected override bool CheckStrategy(IEnumerable<IProcess> processes)
			=> processes.Any(Inner.Check);

		protected override IEnumerable<Transition> GetTransitions(IProcess process)
			=> process.WeakTransitions();
    }
}
