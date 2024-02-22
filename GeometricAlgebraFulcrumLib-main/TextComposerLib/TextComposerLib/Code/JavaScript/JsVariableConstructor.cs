using System.Diagnostics.CodeAnalysis;

namespace TextComposerLib.Code.JavaScript;

public sealed class JsVariableConstructor :
    JsTypeConstructor
{
    public string JsVariableName { get; }


    public JsVariableConstructor([NotNull] string jsVariableName)
    {
        JsVariableName = jsVariableName;
    }


    public override string GetJsCode()
    {
        return JsVariableName;
    }
}