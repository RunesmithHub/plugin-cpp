using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.CFamily.Languages;

/// <summary>C, C++ and CUDA C++: their files, highlighting, comments and brackets.</summary>
public sealed class CppLanguages
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition C { get; } = new("c", "C")
    {
        Extensions = [".c", ".i"],
        ScopeName = "source.c",
        LineComment = "//",
        BlockComment = ("/*", "*/"),
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "file-code",
    };

    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Cpp { get; } = new("cpp", "C++")
    {
        Extensions =
        [
            ".cpp", ".cc", ".cxx", ".c++", ".hpp", ".hh", ".hxx", ".h++", ".h", ".ii", ".ino", ".inl", ".ipp", ".ixx", ".tpp", ".txx",
            ".hpp.in", ".h.in",
        ],
        ScopeName = "source.cpp",
        LineComment = "//",
        BlockComment = ("/*", "*/"),
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "file-code",
    };

    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition CudaCpp { get; } = new("cuda-cpp", "CUDA C++")
    {
        Extensions = [".cu", ".cuh"],
        ScopeName = "source.cuda-cpp",
        LineComment = "//",
        BlockComment = ("/*", "*/"),
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "file-code",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition CGrammar { get; } = GrammarFiles.Find("source.c", "cpp/c.tmLanguage.json");

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition CppGrammar { get; } = GrammarFiles.Find("source.cpp", "cpp/cpp.tmLanguage.json");

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition SourceCppEmbeddedMacroGrammar { get; } = GrammarFiles.Find("source.cpp.embedded.macro", "cpp/cpp.embedded.macro.tmLanguage.json");

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition SourceCPlatformGrammar { get; } = GrammarFiles.Find("source.c.platform", "cpp/platform.tmLanguage.json");

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition CudaCppGrammar { get; } = GrammarFiles.Find("source.cuda-cpp", "cpp/cuda-cpp.tmLanguage.json");
}
