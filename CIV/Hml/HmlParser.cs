﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from HmlParser.g4 by ANTLR 4.5.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace CIV.Hml {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public partial class HmlParser : Parser {
	public const int
		TERM=1, TRUE=2, FALSE=3, AND=4, OR=5, NOT=6, LPAREN=7, RPAREN=8, LBOX=9, 
		RBOX=10, LWBOX=11, RWBOX=12, LDIAMOND=13, RDIAMOND=14, LWDIAMOND=15, RWDIAMOND=16, 
		ALL=17, COMMA=18, TAU=19, COACTION=20, ACTION=21, WHITESPACE=22;
	public const int
		RULE_labelList = 0, RULE_label = 1, RULE_baseHml = 2, RULE_hml = 3;
	public static readonly string[] ruleNames = {
		"labelList", "label", "baseHml", "hml"
	};

	private static readonly string[] _LiteralNames = {
		null, "';'", "'tt'", "'ff'", "'and'", "'or'", "'not'", "'('", "')'", "'['", 
		"']'", "'[['", "']]'", "'<'", "'>'", "'<<'", "'>>'", "'-'", "','", "'tau'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "TERM", "TRUE", "FALSE", "AND", "OR", "NOT", "LPAREN", "RPAREN", 
		"LBOX", "RBOX", "LWBOX", "RWBOX", "LDIAMOND", "RDIAMOND", "LWDIAMOND", 
		"RWDIAMOND", "ALL", "COMMA", Const.tau, "COACTION", "ACTION", "WHITESPACE"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "HmlParser.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public HmlParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class LabelListContext : ParserRuleContext {
		public LabelContext label() {
			return GetRuleContext<LabelContext>(0);
		}
		public LabelListContext labelList() {
			return GetRuleContext<LabelListContext>(0);
		}
		public ITerminalNode COMMA() { return GetToken(HmlParser.COMMA, 0); }
		public LabelListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_labelList; } }
		public override void EnterRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.EnterLabelList(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.ExitLabelList(this);
		}
	}

	[RuleVersion(0)]
	public LabelListContext labelList() {
		return labelList(0);
	}

	private LabelListContext labelList(int _p) {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = State;
		LabelListContext _localctx = new LabelListContext(_ctx, _parentState);
		LabelListContext _prevctx = _localctx;
		int _startState = 0;
		EnterRecursionRule(_localctx, 0, RULE_labelList, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 9; label();
			}
			_ctx.stop = _input.Lt(-1);
			State = 16;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,0,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new LabelListContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_labelList);
					State = 11;
					if (!(Precpred(_ctx, 1))) throw new FailedPredicateException(this, "Precpred(_ctx, 1)");
					State = 12; Match(COMMA);
					State = 13; label();
					}
					} 
				}
				State = 18;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,0,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class LabelContext : ParserRuleContext {
		public ITerminalNode TAU() { return GetToken(HmlParser.TAU, 0); }
		public ITerminalNode ACTION() { return GetToken(HmlParser.ACTION, 0); }
		public ITerminalNode COACTION() { return GetToken(HmlParser.COACTION, 0); }
		public LabelContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_label; } }
		public override void EnterRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.EnterLabel(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.ExitLabel(this);
		}
	}

	[RuleVersion(0)]
	public LabelContext label() {
		LabelContext _localctx = new LabelContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_label);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 19;
			_la = _input.La(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << TAU) | (1L << COACTION) | (1L << ACTION))) != 0)) ) {
			_errHandler.RecoverInline(this);
			} else {
				Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BaseHmlContext : ParserRuleContext {
		public HmlContext hml() {
			return GetRuleContext<HmlContext>(0);
		}
		public BaseHmlContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_baseHml; } }
		public override void EnterRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.EnterBaseHml(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.ExitBaseHml(this);
		}
	}

	[RuleVersion(0)]
	public BaseHmlContext baseHml() {
		BaseHmlContext _localctx = new BaseHmlContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_baseHml);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 21; hml(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class HmlContext : ParserRuleContext {
		public HmlContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_hml; } }
	 
		public HmlContext() { }
		public virtual void CopyFrom(HmlContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class WeakDiamondContext : HmlContext {
		public ITerminalNode LWDIAMOND() { return GetToken(HmlParser.LWDIAMOND, 0); }
		public LabelListContext labelList() {
			return GetRuleContext<LabelListContext>(0);
		}
		public ITerminalNode RWDIAMOND() { return GetToken(HmlParser.RWDIAMOND, 0); }
		public HmlContext hml() {
			return GetRuleContext<HmlContext>(0);
		}
		public WeakDiamondContext(HmlContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.EnterWeakDiamond(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.ExitWeakDiamond(this);
		}
	}
	public partial class BoxAllContext : HmlContext {
		public ITerminalNode LBOX() { return GetToken(HmlParser.LBOX, 0); }
		public ITerminalNode ALL() { return GetToken(HmlParser.ALL, 0); }
		public ITerminalNode RBOX() { return GetToken(HmlParser.RBOX, 0); }
		public HmlContext hml() {
			return GetRuleContext<HmlContext>(0);
		}
		public BoxAllContext(HmlContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.EnterBoxAll(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.ExitBoxAll(this);
		}
	}
	public partial class ConjContext : HmlContext {
		public HmlContext[] hml() {
			return GetRuleContexts<HmlContext>();
		}
		public HmlContext hml(int i) {
			return GetRuleContext<HmlContext>(i);
		}
		public ITerminalNode AND() { return GetToken(HmlParser.AND, 0); }
		public ConjContext(HmlContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.EnterConj(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.ExitConj(this);
		}
	}
	public partial class TrueContext : HmlContext {
		public ITerminalNode TRUE() { return GetToken(HmlParser.TRUE, 0); }
		public TrueContext(HmlContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.EnterTrue(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.ExitTrue(this);
		}
	}
	public partial class BoxContext : HmlContext {
		public ITerminalNode LBOX() { return GetToken(HmlParser.LBOX, 0); }
		public LabelListContext labelList() {
			return GetRuleContext<LabelListContext>(0);
		}
		public ITerminalNode RBOX() { return GetToken(HmlParser.RBOX, 0); }
		public HmlContext hml() {
			return GetRuleContext<HmlContext>(0);
		}
		public BoxContext(HmlContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.EnterBox(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.ExitBox(this);
		}
	}
	public partial class DiamondContext : HmlContext {
		public ITerminalNode LDIAMOND() { return GetToken(HmlParser.LDIAMOND, 0); }
		public LabelListContext labelList() {
			return GetRuleContext<LabelListContext>(0);
		}
		public ITerminalNode RDIAMOND() { return GetToken(HmlParser.RDIAMOND, 0); }
		public HmlContext hml() {
			return GetRuleContext<HmlContext>(0);
		}
		public DiamondContext(HmlContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.EnterDiamond(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.ExitDiamond(this);
		}
	}
	public partial class FalseContext : HmlContext {
		public ITerminalNode FALSE() { return GetToken(HmlParser.FALSE, 0); }
		public FalseContext(HmlContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.EnterFalse(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.ExitFalse(this);
		}
	}
	public partial class WeakDiamondAllContext : HmlContext {
		public ITerminalNode LWDIAMOND() { return GetToken(HmlParser.LWDIAMOND, 0); }
		public ITerminalNode ALL() { return GetToken(HmlParser.ALL, 0); }
		public ITerminalNode RWDIAMOND() { return GetToken(HmlParser.RWDIAMOND, 0); }
		public HmlContext hml() {
			return GetRuleContext<HmlContext>(0);
		}
		public WeakDiamondAllContext(HmlContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.EnterWeakDiamondAll(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.ExitWeakDiamondAll(this);
		}
	}
	public partial class ParenthContext : HmlContext {
		public ITerminalNode LPAREN() { return GetToken(HmlParser.LPAREN, 0); }
		public HmlContext hml() {
			return GetRuleContext<HmlContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(HmlParser.RPAREN, 0); }
		public ParenthContext(HmlContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.EnterParenth(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.ExitParenth(this);
		}
	}
	public partial class WeakBoxContext : HmlContext {
		public ITerminalNode LWBOX() { return GetToken(HmlParser.LWBOX, 0); }
		public LabelListContext labelList() {
			return GetRuleContext<LabelListContext>(0);
		}
		public ITerminalNode RWBOX() { return GetToken(HmlParser.RWBOX, 0); }
		public HmlContext hml() {
			return GetRuleContext<HmlContext>(0);
		}
		public WeakBoxContext(HmlContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.EnterWeakBox(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.ExitWeakBox(this);
		}
	}
	public partial class NegatedContext : HmlContext {
		public ITerminalNode NOT() { return GetToken(HmlParser.NOT, 0); }
		public HmlContext hml() {
			return GetRuleContext<HmlContext>(0);
		}
		public NegatedContext(HmlContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.EnterNegated(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.ExitNegated(this);
		}
	}
	public partial class WeakBoxAllContext : HmlContext {
		public ITerminalNode LWBOX() { return GetToken(HmlParser.LWBOX, 0); }
		public ITerminalNode ALL() { return GetToken(HmlParser.ALL, 0); }
		public ITerminalNode RWBOX() { return GetToken(HmlParser.RWBOX, 0); }
		public HmlContext hml() {
			return GetRuleContext<HmlContext>(0);
		}
		public WeakBoxAllContext(HmlContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.EnterWeakBoxAll(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.ExitWeakBoxAll(this);
		}
	}
	public partial class DisjContext : HmlContext {
		public HmlContext[] hml() {
			return GetRuleContexts<HmlContext>();
		}
		public HmlContext hml(int i) {
			return GetRuleContext<HmlContext>(i);
		}
		public ITerminalNode OR() { return GetToken(HmlParser.OR, 0); }
		public DisjContext(HmlContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.EnterDisj(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.ExitDisj(this);
		}
	}
	public partial class DiamondAllContext : HmlContext {
		public ITerminalNode LDIAMOND() { return GetToken(HmlParser.LDIAMOND, 0); }
		public ITerminalNode ALL() { return GetToken(HmlParser.ALL, 0); }
		public ITerminalNode RDIAMOND() { return GetToken(HmlParser.RDIAMOND, 0); }
		public HmlContext hml() {
			return GetRuleContext<HmlContext>(0);
		}
		public DiamondAllContext(HmlContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.EnterDiamondAll(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IHmlParserListener typedListener = listener as IHmlParserListener;
			if (typedListener != null) typedListener.ExitDiamondAll(this);
		}
	}

	[RuleVersion(0)]
	public HmlContext hml() {
		return hml(0);
	}

	private HmlContext hml(int _p) {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = State;
		HmlContext _localctx = new HmlContext(_ctx, _parentState);
		HmlContext _prevctx = _localctx;
		int _startState = 6;
		EnterRecursionRule(_localctx, 6, RULE_hml, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 68;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,1,_ctx) ) {
			case 1:
				{
				_localctx = new ParenthContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;

				State = 24; Match(LPAREN);
				State = 25; hml(0);
				State = 26; Match(RPAREN);
				}
				break;

			case 2:
				{
				_localctx = new NegatedContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 28; Match(NOT);
				State = 29; hml(13);
				}
				break;

			case 3:
				{
				_localctx = new BoxContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 30; Match(LBOX);
				State = 31; labelList(0);
				State = 32; Match(RBOX);
				State = 33; hml(10);
				}
				break;

			case 4:
				{
				_localctx = new BoxAllContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 35; Match(LBOX);
				State = 36; Match(ALL);
				State = 37; Match(RBOX);
				State = 38; hml(9);
				}
				break;

			case 5:
				{
				_localctx = new DiamondContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 39; Match(LDIAMOND);
				State = 40; labelList(0);
				State = 41; Match(RDIAMOND);
				State = 42; hml(8);
				}
				break;

			case 6:
				{
				_localctx = new DiamondAllContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 44; Match(LDIAMOND);
				State = 45; Match(ALL);
				State = 46; Match(RDIAMOND);
				State = 47; hml(7);
				}
				break;

			case 7:
				{
				_localctx = new WeakBoxContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 48; Match(LWBOX);
				State = 49; labelList(0);
				State = 50; Match(RWBOX);
				State = 51; hml(6);
				}
				break;

			case 8:
				{
				_localctx = new WeakBoxAllContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 53; Match(LWBOX);
				State = 54; Match(ALL);
				State = 55; Match(RWBOX);
				State = 56; hml(5);
				}
				break;

			case 9:
				{
				_localctx = new WeakDiamondContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 57; Match(LWDIAMOND);
				State = 58; labelList(0);
				State = 59; Match(RWDIAMOND);
				State = 60; hml(4);
				}
				break;

			case 10:
				{
				_localctx = new WeakDiamondAllContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 62; Match(LWDIAMOND);
				State = 63; Match(ALL);
				State = 64; Match(RWDIAMOND);
				State = 65; hml(3);
				}
				break;

			case 11:
				{
				_localctx = new TrueContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 66; Match(TRUE);
				}
				break;

			case 12:
				{
				_localctx = new FalseContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 67; Match(FALSE);
				}
				break;
			}
			_ctx.stop = _input.Lt(-1);
			State = 78;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,3,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 76;
					_errHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(_input,2,_ctx) ) {
					case 1:
						{
						_localctx = new ConjContext(new HmlContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_hml);
						State = 70;
						if (!(Precpred(_ctx, 12))) throw new FailedPredicateException(this, "Precpred(_ctx, 12)");
						State = 71; Match(AND);
						State = 72; hml(13);
						}
						break;

					case 2:
						{
						_localctx = new DisjContext(new HmlContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_hml);
						State = 73;
						if (!(Precpred(_ctx, 11))) throw new FailedPredicateException(this, "Precpred(_ctx, 11)");
						State = 74; Match(OR);
						State = 75; hml(12);
						}
						break;
					}
					} 
				}
				State = 80;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,3,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 0: return labelList_sempred((LabelListContext)_localctx, predIndex);

		case 3: return hml_sempred((HmlContext)_localctx, predIndex);
		}
		return true;
	}
	private bool labelList_sempred(LabelListContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(_ctx, 1);
		}
		return true;
	}
	private bool hml_sempred(HmlContext _localctx, int predIndex) {
		switch (predIndex) {
		case 1: return Precpred(_ctx, 12);

		case 2: return Precpred(_ctx, 11);
		}
		return true;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\x18T\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2"+
		"\a\x2\x11\n\x2\f\x2\xE\x2\x14\v\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3\x5"+
		"\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3"+
		"\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5"+
		"\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3"+
		"\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x5\x5G\n\x5\x3\x5"+
		"\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\a\x5O\n\x5\f\x5\xE\x5R\v\x5\x3\x5\x2\x2"+
		"\x4\x2\b\x6\x2\x2\x4\x2\x6\x2\b\x2\x2\x3\x3\x2\x15\x17]\x2\n\x3\x2\x2"+
		"\x2\x4\x15\x3\x2\x2\x2\x6\x17\x3\x2\x2\x2\b\x46\x3\x2\x2\x2\n\v\b\x2\x1"+
		"\x2\v\f\x5\x4\x3\x2\f\x12\x3\x2\x2\x2\r\xE\f\x3\x2\x2\xE\xF\a\x14\x2\x2"+
		"\xF\x11\x5\x4\x3\x2\x10\r\x3\x2\x2\x2\x11\x14\x3\x2\x2\x2\x12\x10\x3\x2"+
		"\x2\x2\x12\x13\x3\x2\x2\x2\x13\x3\x3\x2\x2\x2\x14\x12\x3\x2\x2\x2\x15"+
		"\x16\t\x2\x2\x2\x16\x5\x3\x2\x2\x2\x17\x18\x5\b\x5\x2\x18\a\x3\x2\x2\x2"+
		"\x19\x1A\b\x5\x1\x2\x1A\x1B\a\t\x2\x2\x1B\x1C\x5\b\x5\x2\x1C\x1D\a\n\x2"+
		"\x2\x1DG\x3\x2\x2\x2\x1E\x1F\a\b\x2\x2\x1FG\x5\b\x5\xF !\a\v\x2\x2!\""+
		"\x5\x2\x2\x2\"#\a\f\x2\x2#$\x5\b\x5\f$G\x3\x2\x2\x2%&\a\v\x2\x2&\'\a\x13"+
		"\x2\x2\'(\a\f\x2\x2(G\x5\b\x5\v)*\a\xF\x2\x2*+\x5\x2\x2\x2+,\a\x10\x2"+
		"\x2,-\x5\b\x5\n-G\x3\x2\x2\x2./\a\xF\x2\x2/\x30\a\x13\x2\x2\x30\x31\a"+
		"\x10\x2\x2\x31G\x5\b\x5\t\x32\x33\a\r\x2\x2\x33\x34\x5\x2\x2\x2\x34\x35"+
		"\a\xE\x2\x2\x35\x36\x5\b\x5\b\x36G\x3\x2\x2\x2\x37\x38\a\r\x2\x2\x38\x39"+
		"\a\x13\x2\x2\x39:\a\xE\x2\x2:G\x5\b\x5\a;<\a\x11\x2\x2<=\x5\x2\x2\x2="+
		">\a\x12\x2\x2>?\x5\b\x5\x6?G\x3\x2\x2\x2@\x41\a\x11\x2\x2\x41\x42\a\x13"+
		"\x2\x2\x42\x43\a\x12\x2\x2\x43G\x5\b\x5\x5\x44G\a\x4\x2\x2\x45G\a\x5\x2"+
		"\x2\x46\x19\x3\x2\x2\x2\x46\x1E\x3\x2\x2\x2\x46 \x3\x2\x2\x2\x46%\x3\x2"+
		"\x2\x2\x46)\x3\x2\x2\x2\x46.\x3\x2\x2\x2\x46\x32\x3\x2\x2\x2\x46\x37\x3"+
		"\x2\x2\x2\x46;\x3\x2\x2\x2\x46@\x3\x2\x2\x2\x46\x44\x3\x2\x2\x2\x46\x45"+
		"\x3\x2\x2\x2GP\x3\x2\x2\x2HI\f\xE\x2\x2IJ\a\x6\x2\x2JO\x5\b\x5\xFKL\f"+
		"\r\x2\x2LM\a\a\x2\x2MO\x5\b\x5\xENH\x3\x2\x2\x2NK\x3\x2\x2\x2OR\x3\x2"+
		"\x2\x2PN\x3\x2\x2\x2PQ\x3\x2\x2\x2Q\t\x3\x2\x2\x2RP\x3\x2\x2\x2\x6\x12"+
		"\x46NP";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace CIV.Hml
