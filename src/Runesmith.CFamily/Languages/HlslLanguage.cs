using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.CFamily.Languages;

/// <summary>HLSL: its files, highlighting, comments and brackets.</summary>
public sealed class HlslLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Hlsl { get; } = new("hlsl", "HLSL")
    {
        Extensions = [".hlsl", ".hlsli", ".fx", ".fxh", ".vsh", ".psh", ".cginc", ".compute"],
        ScopeName = "source.hlsl",
        LineComment = "//",
        BlockComment = ("/*", "*/"),
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "file-code",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition HlslGrammar { get; } = GrammarFiles.Find("source.hlsl", "hlsl/hlsl.tmLanguage.json");
}
