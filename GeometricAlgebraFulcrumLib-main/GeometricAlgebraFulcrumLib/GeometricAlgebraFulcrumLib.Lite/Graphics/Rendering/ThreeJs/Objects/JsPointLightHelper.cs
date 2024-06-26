using TextComposerLib.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Lite.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsPointLightHelperConstructor :
    JsTypeConstructor
{
    public JsType Light { get; }
        
    public JsType SphereSize { get; }
        
    public JsType Color { get; }
        
        


    internal JsPointLightHelperConstructor(JsType argLight, JsType argSphereSize, JsType argColor)
    {
        Light = argLight ?? new JsObject();
        SphereSize = argSphereSize ?? new JsObject();
        Color = argColor ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.PointLightHelper({Light.GetJsCode()}, {SphereSize.GetJsCode()}, {Color.GetJsCode()})";
    }
}
    
public partial class JsPointLightHelper :
    JsMesh
{
    public static implicit operator JsPointLightHelper(string jsTextCode)
    {
        return new JsPointLightHelper(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsPointLightHelper value)
    {
        return value.GetJsCode();
    }


    private readonly JsPointLightHelper _jsVariableValue;
    public JsPointLightHelper JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _light;
    public JsType Light
    {
        get => _light ?? throw new InvalidOperationException();
        set
        {
            if (_light is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.light = {valueCode};");
        }
    }
        
    private readonly JsType _color;
    public JsType Color
    {
        get => _color ?? throw new InvalidOperationException();
        set
        {
            if (_color is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.color = {valueCode};");
        }
    }
        
    private readonly JsString _type;
    public JsString Type
    {
        get => _type ?? throw new InvalidOperationException();
        set
        {
            if (_type is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "\"PointLightHelper\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsType _matrix;
    public JsType Matrix
    {
        get => _matrix ?? throw new InvalidOperationException();
        set
        {
            if (_matrix is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.matrix = {valueCode};");
        }
    }
        
    private readonly JsBoolean _matrixAutoUpdate;
    public JsBoolean MatrixAutoUpdate
    {
        get => _matrixAutoUpdate ?? throw new InvalidOperationException();
        set
        {
            if (_matrixAutoUpdate is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.matrixAutoUpdate = {valueCode};");
        }
    }

    internal JsPointLightHelper(JsTypeConstructor jsCodeSource, JsPointLightHelper jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _light = $"{variableName}.light".AsJsTypeVariable();
        _color = $"{variableName}.color".AsJsTypeVariable();
        _type = $"{variableName}.type".AsJsStringVariable();
        _matrix = $"{variableName}.matrix".AsJsTypeVariable();
        _matrixAutoUpdate = $"{variableName}.matrixAutoUpdate".AsJsBooleanVariable();
    }

    public JsPointLightHelper(JsType argLight = null, JsType argSphereSize = null, JsType argColor = null)
        : base(new JsPointLightHelperConstructor(argLight, argSphereSize, argColor))
    {
    }

    public JsType Dispose()
    {
        return CallMethod("dispose");
    }
        
    public JsType Update()
    {
        return CallMethod("update");
    }
        
        
}