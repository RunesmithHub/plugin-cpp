using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.CFamily.Languages;

/// <summary>x86 Assembly: its files, highlighting, comments and brackets.</summary>
public sealed class X86AssemblyLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition X86asm { get; } = new("x86asm", "x86 Assembly")
    {
        Extensions = [".asm"],
        ScopeName = "source.x86asm",
        LineComment = ";",
        Brackets = [('[', ']')],
        Icon = "file-code",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition X86asmGrammar { get; } = GrammarFiles.Find("source.x86asm", "x86asm/x86asm.tmLanguage.json");
}
