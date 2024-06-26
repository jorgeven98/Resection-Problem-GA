using TextComposerLib.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Lite.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsMeshDepthMaterialConstructor :
    JsTypeConstructor
{
    public JsType Parameters { get; }
        
        


    internal JsMeshDepthMaterialConstructor(JsType argParameters)
    {
        Parameters = argParameters ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.MeshDepthMaterial({Parameters.GetJsCode()})";
    }
}
    
public partial class JsMeshDepthMaterial :
    JsMaterial
{
    public static implicit operator JsMeshDepthMaterial(string jsTextCode)
    {
        return new JsMeshDepthMaterial(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsMeshDepthMaterial value)
    {
        return value.GetJsCode();
    }


    private readonly JsMeshDepthMaterial _jsVariableValue;
    public JsMeshDepthMaterial JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"MeshDepthMaterial\"";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.type = {valueCode};");
        }
    }
        
    private readonly JsNumber _depthPacking;
    public JsNumber DepthPacking
    {
        get => _depthPacking ?? throw new InvalidOperationException();
        set
        {
            if (_depthPacking is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "3200";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.depthPacking = {valueCode};");
        }
    }
        
    private readonly JsType _map;
    public JsType Map
    {
        get => _map ?? throw new InvalidOperationException();
        set
        {
            if (_map is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.map = {valueCode};");
        }
    }
        
    private readonly JsType _alphaMap;
    public JsType AlphaMap
    {
        get => _alphaMap ?? throw new InvalidOperationException();
        set
        {
            if (_alphaMap is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.alphaMap = {valueCode};");
        }
    }
        
    private readonly JsType _displacementMap;
    public JsType DisplacementMap
    {
        get => _displacementMap ?? throw new InvalidOperationException();
        set
        {
            if (_displacementMap is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.displacementMap = {valueCode};");
        }
    }
        
    private readonly JsNumber _displacementScale;
    public JsNumber DisplacementScale
    {
        get => _displacementScale ?? throw new InvalidOperationException();
        set
        {
            if (_displacementScale is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.displacementScale = {valueCode};");
        }
    }
        
    private readonly JsNumber _displacementBias;
    public JsNumber DisplacementBias
    {
        get => _displacementBias ?? throw new InvalidOperationException();
        set
        {
            if (_displacementBias is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.displacementBias = {valueCode};");
        }
    }
        
    private readonly JsBoolean _wireframe;
    public JsBoolean Wireframe
    {
        get => _wireframe ?? throw new InvalidOperationException();
        set
        {
            if (_wireframe is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.wireframe = {valueCode};");
        }
    }
        
    private readonly JsNumber _wireframeLinewidth;
    public JsNumber WireframeLinewidth
    {
        get => _wireframeLinewidth ?? throw new InvalidOperationException();
        set
        {
            if (_wireframeLinewidth is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.wireframeLinewidth = {valueCode};");
        }
    }
        
    private readonly JsBoolean _fog;
    public JsBoolean Fog
    {
        get => _fog ?? throw new InvalidOperationException();
        set
        {
            if (_fog is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.fog = {valueCode};");
        }
    }

    internal JsMeshDepthMaterial(JsTypeConstructor jsCodeSource, JsMeshDepthMaterial jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _depthPacking = $"{variableName}.depthPacking".AsJsNumberVariable();
        _map = $"{variableName}.map".AsJsTypeVariable();
        _alphaMap = $"{variableName}.alphaMap".AsJsTypeVariable();
        _displacementMap = $"{variableName}.displacementMap".AsJsTypeVariable();
        _displacementScale = $"{variableName}.displacementScale".AsJsNumberVariable();
        _displacementBias = $"{variableName}.displacementBias".AsJsNumberVariable();
        _wireframe = $"{variableName}.wireframe".AsJsBooleanVariable();
        _wireframeLinewidth = $"{variableName}.wireframeLinewidth".AsJsNumberVariable();
        _fog = $"{variableName}.fog".AsJsBooleanVariable();
    }

    public JsMeshDepthMaterial(JsType argParameters = null)
        : base(new JsMeshDepthMaterialConstructor(argParameters))
    {
    }

    public JsMeshDepthMaterial Copy(JsType argSource = null)
    {
        CallMethodVoid("copy", argSource ?? new JsObject());
            
        return this;
    }
        
        
}