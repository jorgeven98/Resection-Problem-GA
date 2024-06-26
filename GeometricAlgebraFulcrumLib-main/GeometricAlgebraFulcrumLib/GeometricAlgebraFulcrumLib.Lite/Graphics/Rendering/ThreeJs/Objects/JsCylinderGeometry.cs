using TextComposerLib.Code.JavaScript;

namespace GeometricAlgebraFulcrumLib.Lite.Graphics.Rendering.ThreeJs.Objects;

internal sealed partial class JsCylinderGeometryConstructor :
    JsTypeConstructor
{
    public JsNumber RadiusTop { get; }
        
    public JsNumber RadiusBottom { get; }
        
    public JsNumber Height { get; }
        
    public JsNumber RadialSegments { get; }
        
    public JsNumber HeightSegments { get; }
        
    public JsBoolean OpenEnded { get; }
        
    public JsNumber ThetaStart { get; }
        
    public JsType ThetaLength { get; }
        
        


    internal JsCylinderGeometryConstructor(JsNumber argRadiusTop, JsNumber argRadiusBottom, JsNumber argHeight, JsNumber argRadialSegments, JsNumber argHeightSegments, JsBoolean argOpenEnded, JsNumber argThetaStart, JsType argThetaLength)
    {
        RadiusTop = argRadiusTop ?? (1).AsJsNumber();
        RadiusBottom = argRadiusBottom ?? (1).AsJsNumber();
        Height = argHeight ?? (1).AsJsNumber();
        RadialSegments = argRadialSegments ?? (8).AsJsNumber();
        HeightSegments = argHeightSegments ?? (1).AsJsNumber();
        OpenEnded = argOpenEnded ?? (false).AsJsBoolean();
        ThetaStart = argThetaStart ?? (0).AsJsNumber();
        ThetaLength = argThetaLength ?? new JsObject();
    }

    public override string GetJsCode()
    {
        return $"new THREE.CylinderGeometry({RadiusTop.GetJsCode()}, {RadiusBottom.GetJsCode()}, {Height.GetJsCode()}, {RadialSegments.GetJsCode()}, {HeightSegments.GetJsCode()}, {OpenEnded.GetJsCode()}, {ThetaStart.GetJsCode()}, {ThetaLength.GetJsCode()})";
    }
}
    
public partial class JsCylinderGeometry :
    JsBufferGeometry
{
    public static implicit operator JsCylinderGeometry(string jsTextCode)
    {
        return new JsCylinderGeometry(
            new JsTextCodeConstructor(jsTextCode)
        );
    }

    public static implicit operator string(JsCylinderGeometry value)
    {
        return value.GetJsCode();
    }


    private readonly JsCylinderGeometry _jsVariableValue;
    public JsCylinderGeometry JsValue 
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
        
            var valueCode = value?.GetJsCode() ?? "\"CylinderGeometry\"";
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

    internal JsCylinderGeometry(JsTypeConstructor jsCodeSource, JsCylinderGeometry jsVariableValue = null)
        : base(jsCodeSource)
    {
        if (!(jsCodeSource.IsVariable || jsCodeSource.IsTextCode))
            return;

        _jsVariableValue = jsVariableValue;
        var variableName = TypeConstructor.GetJsCode();

        _type = $"{variableName}.type".AsJsStringVariable();
        _parameters = $"{variableName}.parameters".AsJsTypeVariable();
    }

    public JsCylinderGeometry(JsNumber argRadiusTop = null, JsNumber argRadiusBottom = null, JsNumber argHeight = null, JsNumber argRadialSegments = null, JsNumber argHeightSegments = null, JsBoolean argOpenEnded = null, JsNumber argThetaStart = null, JsType argThetaLength = null)
        : base(new JsCylinderGeometryConstructor(argRadiusTop, argRadiusBottom, argHeight, argRadialSegments, argHeightSegments, argOpenEnded, argThetaStart, argThetaLength))
    {
    }

        
}