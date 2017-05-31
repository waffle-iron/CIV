﻿using System;
namespace CIV.Hml
{
    public class HmlListener : HmlParserBaseListener
    {
        public IHmlFormula RootFormula { get; private set; }

        readonly HmlFactory factory = new HmlFactory();

        public override void EnterBaseHml(HmlParser.BaseHmlContext context)
        {
            RootFormula = factory.Create(context.hml());
        }
    }
}