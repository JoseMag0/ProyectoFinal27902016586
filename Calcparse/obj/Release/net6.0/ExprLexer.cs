//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.12.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\jocma\Source\Repos\ProyectoFinal27902016586\Calcparse\Expr.g4 by ANTLR 4.12.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Calcparse {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public partial class ExprLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		MULT=1, DIV=2, SUM=3, RES=4, PARI=5, PARD=6, NEWLINE=7, INT=8, REAL=9;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"MULT", "DIV", "SUM", "RES", "PARI", "PARD", "NEWLINE", "INT", "REAL"
	};


	public ExprLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public ExprLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'*'", "'/'", "'+'", "'-'", "'('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "MULT", "DIV", "SUM", "RES", "PARI", "PARD", "NEWLINE", "INT", "REAL"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Expr.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static ExprLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,9,51,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,
		2,7,7,7,2,8,7,8,1,0,1,0,1,1,1,1,1,2,1,2,1,3,1,3,1,4,1,4,1,5,1,5,1,6,4,
		6,33,8,6,11,6,12,6,34,1,7,3,7,38,8,7,1,7,4,7,41,8,7,11,7,12,7,42,1,8,3,
		8,46,8,8,1,8,1,8,1,8,1,8,0,0,9,1,1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,9,
		1,0,2,2,0,10,10,13,13,1,0,48,57,54,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,
		0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,
		0,0,0,1,19,1,0,0,0,3,21,1,0,0,0,5,23,1,0,0,0,7,25,1,0,0,0,9,27,1,0,0,0,
		11,29,1,0,0,0,13,32,1,0,0,0,15,37,1,0,0,0,17,45,1,0,0,0,19,20,5,42,0,0,
		20,2,1,0,0,0,21,22,5,47,0,0,22,4,1,0,0,0,23,24,5,43,0,0,24,6,1,0,0,0,25,
		26,5,45,0,0,26,8,1,0,0,0,27,28,5,40,0,0,28,10,1,0,0,0,29,30,5,41,0,0,30,
		12,1,0,0,0,31,33,7,0,0,0,32,31,1,0,0,0,33,34,1,0,0,0,34,32,1,0,0,0,34,
		35,1,0,0,0,35,14,1,0,0,0,36,38,5,45,0,0,37,36,1,0,0,0,37,38,1,0,0,0,38,
		40,1,0,0,0,39,41,7,1,0,0,40,39,1,0,0,0,41,42,1,0,0,0,42,40,1,0,0,0,42,
		43,1,0,0,0,43,16,1,0,0,0,44,46,5,45,0,0,45,44,1,0,0,0,45,46,1,0,0,0,46,
		47,1,0,0,0,47,48,3,15,7,0,48,49,5,46,0,0,49,50,3,15,7,0,50,18,1,0,0,0,
		5,0,34,37,42,45,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Calcparse
