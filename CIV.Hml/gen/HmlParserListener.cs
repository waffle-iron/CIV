//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.1-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from HmlParser.g4 by ANTLR 4.6.1-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace CIV.Hml {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="HmlParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.1-SNAPSHOT")]
[System.CLSCompliant(false)]
public interface IHmlParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>WeakDiamond</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWeakDiamond([NotNull] HmlParser.WeakDiamondContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>WeakDiamond</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWeakDiamond([NotNull] HmlParser.WeakDiamondContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>BoxAll</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoxAll([NotNull] HmlParser.BoxAllContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BoxAll</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoxAll([NotNull] HmlParser.BoxAllContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Conj</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConj([NotNull] HmlParser.ConjContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Conj</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConj([NotNull] HmlParser.ConjContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>True</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrue([NotNull] HmlParser.TrueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>True</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrue([NotNull] HmlParser.TrueContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Box</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBox([NotNull] HmlParser.BoxContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Box</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBox([NotNull] HmlParser.BoxContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Diamond</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDiamond([NotNull] HmlParser.DiamondContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Diamond</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDiamond([NotNull] HmlParser.DiamondContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>False</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFalse([NotNull] HmlParser.FalseContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>False</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFalse([NotNull] HmlParser.FalseContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>WeakDiamondAll</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWeakDiamondAll([NotNull] HmlParser.WeakDiamondAllContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>WeakDiamondAll</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWeakDiamondAll([NotNull] HmlParser.WeakDiamondAllContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Parenth</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenth([NotNull] HmlParser.ParenthContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Parenth</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenth([NotNull] HmlParser.ParenthContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>WeakBox</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWeakBox([NotNull] HmlParser.WeakBoxContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>WeakBox</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWeakBox([NotNull] HmlParser.WeakBoxContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Negated</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNegated([NotNull] HmlParser.NegatedContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Negated</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNegated([NotNull] HmlParser.NegatedContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>WeakBoxAll</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWeakBoxAll([NotNull] HmlParser.WeakBoxAllContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>WeakBoxAll</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWeakBoxAll([NotNull] HmlParser.WeakBoxAllContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Disj</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDisj([NotNull] HmlParser.DisjContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Disj</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDisj([NotNull] HmlParser.DisjContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>DiamondAll</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDiamondAll([NotNull] HmlParser.DiamondAllContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DiamondAll</c>
	/// labeled alternative in <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDiamondAll([NotNull] HmlParser.DiamondAllContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="HmlParser.labelList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabelList([NotNull] HmlParser.LabelListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="HmlParser.labelList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabelList([NotNull] HmlParser.LabelListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="HmlParser.label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabel([NotNull] HmlParser.LabelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="HmlParser.label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabel([NotNull] HmlParser.LabelContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="HmlParser.baseHml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBaseHml([NotNull] HmlParser.BaseHmlContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="HmlParser.baseHml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBaseHml([NotNull] HmlParser.BaseHmlContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHml([NotNull] HmlParser.HmlContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="HmlParser.hml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHml([NotNull] HmlParser.HmlContext context);
}
} // namespace CIV.Hml
