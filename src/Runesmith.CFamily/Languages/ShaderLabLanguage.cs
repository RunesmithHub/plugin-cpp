using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.CFamily.Languages;

/// <summary>ShaderLab: its files, highlighting, comments and brackets.</summary>
public sealed class ShaderLabLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Shaderlab { get; } = new("shaderlab", "ShaderLab")
    {
        Extensions = [".shader"],
        ScopeName = "source.shaderlab",
        LineComment = "//",
        BlockComment = ("/*", "*/"),
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "file-code",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition ShaderlabGrammar { get; } = GrammarFiles.Find("source.shaderlab", "shaderlab/shaderlab.tmLanguage.json");
}
