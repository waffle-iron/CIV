﻿using System;
using System.Linq;
using System.Collections.Generic;
using CIV.Interfaces;

namespace CIV.Hml
{
    /// <summary>
    /// Common implementation of Box, Diamond, WeakBox and WeakDiamond.
    /// </summary>
    /// <remarks>
    /// Notice that WeakBox and WeakDiamond will default to their "strong"
    /// counterparts when called on a process that does not implement
    /// IHasWeakTransitions.
    /// </remarks>
    abstract class HmlLabelFormula : HmlFormula
    {
		public ISet<String> Label { get; set; }
		public HmlFormula Inner { get; set; }

		/// <summary>
		/// This will be an existential (Any) or universal (All) check, 
		/// respectively for Diamond and Box operators.
		/// </summary>
		/// <returns><c>true</c>, if all/any of the processes satisfy Inner, 
		/// <c>false</c> otherwise.</returns>
		/// <param name="processes">Processes.</param>
		protected abstract bool CheckStrategy(IEnumerable<IProcess> processes);
        protected abstract IEnumerable<Transition> TransitionStrategy(IProcess process);

        public override bool Check(IProcess process)
        {
            var processes = (from t in TransitionStrategy(process)
							 where Label.Contains(t.Label)
							 select t.Process);
			return CheckStrategy(processes);
        }
    }
}
