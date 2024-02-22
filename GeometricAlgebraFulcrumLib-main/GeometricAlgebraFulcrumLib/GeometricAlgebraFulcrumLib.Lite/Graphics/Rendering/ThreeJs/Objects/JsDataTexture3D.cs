using TextComposerLib.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Lite.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsDataTexture3DConstructor :
    JsTypeConstructor
{
    public JsObject Data { get; }
        
    public JsNumber Width { get; }
        
    public JsNumber Height { get; }
        
    public JsNumber Depth { get; }
        
        


    internal JsDataTexture3DConstructor(JsObject argData, JsNumber argWidth, JsNumber argHeight, JsNumber argDepth)
    {
        Data = argData ?? new JsObject();
        Width = argWidth ?? (1).AsJsNumber();
        Height = argHeight ?? (1).AsJsNumber();
        Depth = argDepth ?? (1).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.DataTexture3D({Data.GetJsCode()}, {Width.GetJsCode()}, {Height.GetJsCode()}, {Depth.GetJsCode()})";
    }
}
    
public partial class JsDataTexture3D :
    JsTexture
{
    public static implicit operator JsDataTexture3D(string jsTextCode)
    {
        return new JsDataTexture3D(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsDataTexture3D value)
    {
        return value.GetJsCode();
    }


    private readonly JsDataTexture3D _jsVariableValue;
    public JsDataTexture3D JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsType _image;
    public JsType Image
    {
        get => _image ?? throw new InvalidOperationException();
        set
        {
            if (_image is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "{}";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.image = {valueCode};");
        }
    }
        
    private readonly JsNumber _magFilter;
    public JsNumber MagFilter
    {
        get => _magFilter ?? throw new InvalidOperationException();
        set
        {
            if (_magFilter is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1003";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.magFilter = {valueCode};");
        }
    }
        
    private readonly JsNumber _minFilter;
    public JsNumber MinFilter
    {
        get => _minFilter ?? throw new InvalidOperationException();
        set
        {
            if (_minFilter is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1003";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.minFilter = {valueCode};");
        }
    }
        
    private readonly JsNumber _wrapR;
    public JsNumber WrapR
    {
        get => _wrapR ?? throw new InvalidOperationException();
        set
        {
            if (_wrapR is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1001";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.wrapR = {valueCode};");
        }
    }
        
    private readonly JsBoolean _generateMipmaps;
    public JsBoolean GenerateMipmaps
    {
        get => _generateMipmaps ?? throw new InvalidOperationException();
        set
        {
            if (_generateMipmaps is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.generateMipmaps = {valueCode};");
        }
    }
        
    private readonly JsBoolean _flipY;
    public JsBoolean FlipY
    {
        get => _flipY ?? throw new InvalidOperationException();
        set
        {
            if (_flipY is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "false";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.flipY = {valueCode};");
        }
    }
        
    private readonly JsNumber _unpackAlignment;
    public JsNumber UnpackAlignment
    {
        get => _unpackAlignment ?? throw new InvalidOperationException();
        set
        {
            if (_unpackAlignment is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.unpackAlignment = {valueCode};");
        }
    }
        
    private readonly JsBoolean _needsUpdate;
    public JsBoolean NeedsUpdate
    {
        get => _needsUpdate ?? throw new InvalidOperationException();
        set
        {
            if (_needsUpdate is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "true";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.needsUpdate = {valueCode};");
        }
    }

    internal JsDataTexture3D(JsTypeConstructor jsCodeSource, JsDataTexture3D jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _image = $"{variableName}.image".AsJsTypeVariable();
        _magFilter = $"{variableName}.magFilter".AsJsNumberVariable();
        _minFilter = $"{variableName}.minFilter".AsJsNumberVariable();
        _wrapR = $"{variableName}.wrapR".AsJsNumberVariable();
        _generateMipmaps = $"{variableName}.generateMipmaps".AsJsBooleanVariable();
        _flipY = $"{variableName}.flipY".AsJsBooleanVariable();
        _unpackAlignment = $"{variableName}.unpackAlignment".AsJsNumberVariable();
        _needsUpdate = $"{variableName}.needsUpdate".AsJsBooleanVariable();
    }

    public JsDataTexture3D(JsObject argData = null, JsNumber argWidth = null, JsNumber argHeight = null, JsNumber argDepth = null)
        : base(new JsDataTexture3DConstructor(argData, argWidth, argHeight, argDepth))
    {
    }

        
}