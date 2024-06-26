using TextComposerLib.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Lite.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsCylindricalConstructor :
    JsTypeConstructor
{
    public JsNumber Radius { get; }
        
    public JsNumber Theta { get; }
        
    public JsNumber Y { get; }
        
        


    internal JsCylindricalConstructor(JsNumber argRadius, JsNumber argTheta, JsNumber argY)
    {
        Radius = argRadius ?? (1).AsJsNumber();
        Theta = argTheta ?? (0).AsJsNumber();
        Y = argY ?? (0).AsJsNumber();
    }

    public override string GetJsCode()
    {
        return $"new THREE.Cylindrical({Radius.GetJsCode()}, {Theta.GetJsCode()}, {Y.GetJsCode()})";
    }
}
    
public partial class JsCylindrical :
    JsObjectType
{
    public static implicit operator JsCylindrical(string jsTextCode)
    {
        return new JsCylindrical(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsCylindrical value)
    {
        return value.GetJsCode();
    }


    private readonly JsCylindrical _jsVariableValue;
    public JsCylindrical JsValue 
        => TypeConstructor.IsVariable ? _jsVariableValue : this;

    public override bool IsVariableWithValue
        => TypeConstructor.IsVariable && _jsVariableValue is not null;

    public override bool IsVariableWithNoValue
        => TypeConstructor.IsVariable && _jsVariableValue is null;

    private readonly JsNumber _radius;
    public JsNumber Radius
    {
        get => _radius ?? throw new InvalidOperationException();
        set
        {
            if (_radius is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "1";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.radius = {valueCode};");
        }
    }
        
    private readonly JsNumber _theta;
    public JsNumber Theta
    {
        get => _theta ?? throw new InvalidOperationException();
        set
        {
            if (_theta is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.theta = {valueCode};");
        }
    }
        
    private readonly JsNumber _y;
    public JsNumber Y
    {
        get => _y ?? throw new InvalidOperationException();
        set
        {
            if (_y is null)
                throw new InvalidOperationException();
        
            var valueCode = value?.GetJsCode() ?? "0";
            JavaScriptCodeComposer.DefaultComposer.CodeLine($"{VariableName}.y = {valueCode};");
        }
    }

    internal JsCylindrical(JsTypeConstructor jsCodeSource, JsCylindrical jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _radius = $"{variableName}.radius".AsJsNumberVariable();
        _theta = $"{variableName}.theta".AsJsNumberVariable();
        _y = $"{variableName}.y".AsJsNumberVariable();
    }

    public JsCylindrical(JsNumber argRadius = null, JsNumber argTheta = null, JsNumber argY = null)
        : base(new JsCylindricalConstructor(argRadius, argTheta, argY))
    {
    }

    public JsCylindrical Set(JsType argRadius = null, JsType argTheta = null, JsType argY = null)
    {
        CallMethodVoid("set", argRadius ?? new JsObject(), argTheta ?? new JsObject(), argY ?? new JsObject());
            
        return this;
    }
        
    public JsCylindrical Copy(JsType argOther = null)
    {
        CallMethodVoid("copy", argOther ?? new JsObject());
            
        return this;
    }
        
    public JsType SetFromVector3(JsType argV = null)
    {
        return CallMethod("setFromVector3", argV ?? new JsObject());
    }
        
    public JsCylindrical SetFromCartesianCoords(JsType argX = null, JsType argY = null, JsType argZ = null)
    {
        CallMethodVoid("setFromCartesianCoords", argX ?? new JsObject(), argY ?? new JsObject(), argZ ?? new JsObject());
            
        return this;
    }
        
    public JsType Clone()
    {
        return CallMethod("clone");
    }
        
        
}