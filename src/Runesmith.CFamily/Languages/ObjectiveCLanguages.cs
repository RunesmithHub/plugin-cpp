using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.CFamily.Languages;

/// <summary>Objective-C and Objective-C++: their files, highlighting, comments and brackets.</summary>
public sealed class ObjectiveCLanguages
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition ObjectiveC { get; } = new("objective-c", "Objective-C")
    {
        Extensions = [".m"],
        ScopeName = "source.objc",
        LineComment = "//",
        BlockComment = ("/*", "*/"),
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "file-code",
    };

    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition ObjectiveCpp { get; } = new("objective-cpp", "Objective-C++")
    {
        Extensions = [".mm"],
        ScopeName = "source.objcpp",
        LineComment = "//",
        BlockComment = ("/*", "*/"),
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "file-code",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition ObjectiveCGrammar { get; } = GrammarFiles.Find("source.objc", "objectivec/objective-c.tmLanguage.json");

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition ObjectiveCppGrammar { get; } = GrammarFiles.Find("source.objcpp", "objectivec/objective-c++.tmLanguage.json");
}
