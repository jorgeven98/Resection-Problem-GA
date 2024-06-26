using TextComposerLib.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Lite.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsIcosahedronGeometryConstructor :
    JsTypeConstructor
{
    public JsNumber Radius { get; }
        
    public JsNumber Detail { get; }
        
        


    internal JsIcosahedronGeometryConstructor(JsNumber argRadius, JsNumber argDetail)
    {
        Radius = argRadius ?? (1).AsJsNumber();
        Detail = argDetail ?? (0).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.IcosahedronGeometry({Radius.GetJsCode()}, {Detail.GetJsCode()})";
    }
}
    
public partial class JsIcosahedronGeometry :
    JsPolyhedronGeometry
{
    public static implicit operator JsIcosahedronGeometry(string jsTextCode)
    {
        return new JsIcosahedronGeometry(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsIcosahedronGeometry value)
    {
        return value.GetJsCode();
    }


    private readonly JsIcosahedronGeometry _jsVariableValue;
    public JsIcosahedronGeometry JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsString _type;
    public JsString Type
    {
        get => _type ?? throw new InvalidOperationException();
        set
        {
            if (_type is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"IcosahedronGeometry\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsType _parameters;
    public JsType Parameters
    {
        get => _parameters ?? throw new InvalidOperationException();
        set
        {
            if (_parameters is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.parameters = {valueCode};");
        }
    }

    internal JsIcosahedronGeometry(JsTypeConstructor jsCodeSource, JsIcosahedronGeometry jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _parameters = $"{variableName}.parameters".AsJsTypeVariable();
    }

    public JsIcosahedronGeometry(JsNumber argRadius = null, JsNumber argDetail = null)
        : base(new JsIcosahedronGeometryConstructor(argRadius, argDetail))
    {
    }

        
}