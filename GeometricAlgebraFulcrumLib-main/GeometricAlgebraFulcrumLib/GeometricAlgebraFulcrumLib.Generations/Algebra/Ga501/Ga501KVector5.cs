using System.Runtime.CompilerServices;

namespace GeometricAlgebraFulcrumLib.Generations.Algebra.Ga501;

public sealed partial class Ga501KVector5
{
    public static Ga501KVector5 Zero { get; } = new Ga501KVector5();
    
    public static Ga501KVector5 E12345 { get; } = new Ga501KVector5() { Scalar12345 = 1d };
    
    public static Ga501KVector5 E12346 { get; } = new Ga501KVector5() { Scalar12346 = 1d };
    
    public static Ga501KVector5 E12356 { get; } = new Ga501KVector5() { Scalar12356 = 1d };
    
    public static Ga501KVector5 E12456 { get; } = new Ga501KVector5() { Scalar12456 = 1d };
    
    public static Ga501KVector5 E13456 { get; } = new Ga501KVector5() { Scalar13456 = 1d };
    
    public static Ga501KVector5 E23456 { get; } = new Ga501KVector5() { Scalar23456 = 1d };
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501KVector5 Create(params double[] scalarArray)
    {
        return new Ga501KVector5
        {
            Scalar12345 = scalarArray[0],
            Scalar12346 = scalarArray[1],
            Scalar12356 = scalarArray[2],
            Scalar12456 = scalarArray[3],
            Scalar13456 = scalarArray[4],
            Scalar23456 = scalarArray[5]
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501KVector5 operator +(Ga501KVector5 mv)
    {
        return mv;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501KVector5 operator -(Ga501KVector5 mv)
    {
        return mv.Negative();
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501KVector5 operator *(Ga501KVector5 mv1, double mv2)
    {
        return mv1.Times(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501KVector5 operator *(double mv1, Ga501KVector5 mv2)
    {
        return mv2.Times(mv1);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501KVector5 operator /(Ga501KVector5 mv1, double mv2)
    {
        return mv1.Times(1d / mv2);
    }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501Multivector operator +(Ga501KVector5 mv1, Ga501KVector0 mv2)
    {
        return mv1.Add(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501Multivector operator -(Ga501KVector5 mv1, Ga501KVector0 mv2)
    {
        return mv1.Subtract(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501Multivector operator +(Ga501KVector5 mv1, Ga501KVector1 mv2)
    {
        return mv1.Add(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501Multivector operator -(Ga501KVector5 mv1, Ga501KVector1 mv2)
    {
        return mv1.Subtract(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501Multivector operator +(Ga501KVector5 mv1, Ga501KVector2 mv2)
    {
        return mv1.Add(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501Multivector operator -(Ga501KVector5 mv1, Ga501KVector2 mv2)
    {
        return mv1.Subtract(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501Multivector operator +(Ga501KVector5 mv1, Ga501KVector3 mv2)
    {
        return mv1.Add(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501Multivector operator -(Ga501KVector5 mv1, Ga501KVector3 mv2)
    {
        return mv1.Subtract(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501Multivector operator +(Ga501KVector5 mv1, Ga501KVector4 mv2)
    {
        return mv1.Add(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501Multivector operator -(Ga501KVector5 mv1, Ga501KVector4 mv2)
    {
        return mv1.Subtract(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501KVector5 operator +(Ga501KVector5 mv1, Ga501KVector5 mv2)
    {
        return mv1.Add(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501KVector5 operator -(Ga501KVector5 mv1, Ga501KVector5 mv2)
    {
        return mv1.Subtract(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501Multivector operator +(Ga501KVector5 mv1, Ga501Multivector mv2)
    {
        return mv1.Add(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501Multivector operator -(Ga501KVector5 mv1, Ga501Multivector mv2)
    {
        return mv1.Subtract(mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501Multivector operator +(Ga501KVector5 mv1, double mv2)
    {
        return Ga501Multivector.Create(mv1, mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501Multivector operator +(double mv1, Ga501KVector5 mv2)
    {
        return Ga501Multivector.Create(mv2, mv1);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501Multivector operator -(Ga501KVector5 mv1, double mv2)
    {
        return Ga501Multivector.Create(mv1, -mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga501Multivector operator -(double mv1, Ga501KVector5 mv2)
    {
        return Ga501Multivector.Create(mv2.Negative(), mv1);
    }
    
    public double Scalar12345 { get; init; }
    
    public double Scalar12346 { get; init; }
    
    public double Scalar12356 { get; init; }
    
    public double Scalar12456 { get; init; }
    
    public double Scalar13456 { get; init; }
    
    public double Scalar23456 { get; init; }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501KVector5()
    {
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsValid()
    {
        return
            !double.IsNaN(Scalar12345) &&
            !double.IsNaN(Scalar12346) &&
            !double.IsNaN(Scalar12356) &&
            !double.IsNaN(Scalar12456) &&
            !double.IsNaN(Scalar13456) &&
            !double.IsNaN(Scalar23456);
    }
    
    private bool? _isZero;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsZero()
    {
        _isZero ??= 
            Scalar12345 == 0d &&
            Scalar12346 == 0d &&
            Scalar12356 == 0d &&
            Scalar12456 == 0d &&
            Scalar13456 == 0d &&
            Scalar23456 == 0d;
    
        return _isZero.Value;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsNearZero(double epsilon = 1e-12d)
    {
        var norm = this.Norm();
    
        return norm > -epsilon && norm < epsilon;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public double[] GetMultivectorArray()
    {
        var scalarArray = new double[64];
        
        scalarArray[31] = Scalar12345;
        scalarArray[47] = Scalar12346;
        scalarArray[55] = Scalar12356;
        scalarArray[59] = Scalar12456;
        scalarArray[61] = Scalar13456;
        scalarArray[62] = Scalar23456;
        
        return scalarArray;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public double[] GetKVectorArray()
    {
        return new double[]
        {
            Scalar12345,
            Scalar12346,
            Scalar12356,
            Scalar12456,
            Scalar13456,
            Scalar23456
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501KVector5 Times(double mv2)
    {
        return new Ga501KVector5()
        {
            Scalar12345 = Scalar12345 * mv2,
            Scalar12346 = Scalar12346 * mv2,
            Scalar12356 = Scalar12356 * mv2,
            Scalar12456 = Scalar12456 * mv2,
            Scalar13456 = Scalar13456 * mv2,
            Scalar23456 = Scalar23456 * mv2
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501KVector5 Divide(double mv2)
    {
        return Times(1d / mv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501KVector5 DivideByNorm()
    {
        return Times(1d / this.Norm());
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501KVector5 DivideByNormSquared()
    {
        return Times(1d / this.NormSquared());
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501KVector5 DivideBySpSquared()
    {
        return Times(1d / this.SpSquared());
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501KVector5 Negative()
    {
        return new Ga501KVector5()
        {
            Scalar12345 = -Scalar12345,
            Scalar12346 = -Scalar12346,
            Scalar12356 = -Scalar12356,
            Scalar12456 = -Scalar12456,
            Scalar13456 = -Scalar13456,
            Scalar23456 = -Scalar23456
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501KVector5 Reverse()
    {
        return this;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501KVector5 GradeInvolution()
    {
        return Negative();
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501KVector5 CliffordConjugate()
    {
        return Negative();
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501KVector5 Inverse()
    {
        return Times(1d / this.NormSquared());
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501KVector5 InverseTimes(double mv2)
    {
        return Times(mv2 / this.NormSquared());
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501KVector5 PseudoInverse()
    {
        var conjugate = Conjugate();
    
        return conjugate.Times(
            1d / conjugate.Sp(this).Scalar
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501KVector5 PseudoInverseTimes(double mv2)
    {
        var conjugate = Conjugate();
    
        return conjugate.Times(
            mv2 / conjugate.Sp(this).Scalar
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501KVector5 Conjugate()
    {
        return new Ga501KVector5()
               {
                   Scalar23456 = Scalar23456
               };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501KVector1 UnDual()
    {
        return new Ga501KVector1()
               {
                   Scalar1 = -Scalar23456
               };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501KVector0 Dual(Ga501KVector5 kv2)
    {
        return this.Lcp(kv2.Inverse());
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501KVector0 UnDual(Ga501KVector5 kv2)
    {
        return this.Lcp(kv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501KVector1 Dual(Ga501KVector6 kv2)
    {
        return this.Lcp(kv2.Inverse());
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501KVector1 UnDual(Ga501KVector6 kv2)
    {
        return this.Lcp(kv2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501Multivector Add(Ga501KVector0 mv2)
    {
        if (mv2.IsZero()) return Ga501Multivector.Create(this);
        if (IsZero()) return Ga501Multivector.Create(mv2);
        
        return Ga501Multivector.Create(
            mv2,
            Ga501KVector1.Zero,
            Ga501KVector2.Zero,
            Ga501KVector3.Zero,
            Ga501KVector4.Zero,
            this,
            Ga501KVector6.Zero
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501Multivector Add(Ga501KVector1 mv2)
    {
        if (mv2.IsZero()) return Ga501Multivector.Create(this);
        if (IsZero()) return Ga501Multivector.Create(mv2);
        
        return Ga501Multivector.Create(
            Ga501KVector0.Zero,
            mv2,
            Ga501KVector2.Zero,
            Ga501KVector3.Zero,
            Ga501KVector4.Zero,
            this,
            Ga501KVector6.Zero
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501Multivector Add(Ga501KVector2 mv2)
    {
        if (mv2.IsZero()) return Ga501Multivector.Create(this);
        if (IsZero()) return Ga501Multivector.Create(mv2);
        
        return Ga501Multivector.Create(
            Ga501KVector0.Zero,
            Ga501KVector1.Zero,
            mv2,
            Ga501KVector3.Zero,
            Ga501KVector4.Zero,
            this,
            Ga501KVector6.Zero
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501Multivector Add(Ga501KVector3 mv2)
    {
        if (mv2.IsZero()) return Ga501Multivector.Create(this);
        if (IsZero()) return Ga501Multivector.Create(mv2);
        
        return Ga501Multivector.Create(
            Ga501KVector0.Zero,
            Ga501KVector1.Zero,
            Ga501KVector2.Zero,
            mv2,
            Ga501KVector4.Zero,
            this,
            Ga501KVector6.Zero
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501Multivector Add(Ga501KVector4 mv2)
    {
        if (mv2.IsZero()) return Ga501Multivector.Create(this);
        if (IsZero()) return Ga501Multivector.Create(mv2);
        
        return Ga501Multivector.Create(
            Ga501KVector0.Zero,
            Ga501KVector1.Zero,
            Ga501KVector2.Zero,
            Ga501KVector3.Zero,
            mv2,
            this,
            Ga501KVector6.Zero
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501KVector5 Add(Ga501KVector5 mv2)
    {
        if (mv2.IsZero()) return this;
        if (IsZero()) return mv2;
        
        return new Ga501KVector5()
        {
            Scalar12345 = Scalar12345 + mv2.Scalar12345,
            Scalar12346 = Scalar12346 + mv2.Scalar12346,
            Scalar12356 = Scalar12356 + mv2.Scalar12356,
            Scalar12456 = Scalar12456 + mv2.Scalar12456,
            Scalar13456 = Scalar13456 + mv2.Scalar13456,
            Scalar23456 = Scalar23456 + mv2.Scalar23456
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501Multivector Add(Ga501KVector6 mv2)
    {
        if (mv2.IsZero()) return Ga501Multivector.Create(this);
        if (IsZero()) return Ga501Multivector.Create(mv2);
        
        return Ga501Multivector.Create(
            Ga501KVector0.Zero,
            Ga501KVector1.Zero,
            Ga501KVector2.Zero,
            Ga501KVector3.Zero,
            Ga501KVector4.Zero,
            this,
            mv2
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501Multivector Add(Ga501Multivector mv2)
    {
        if (mv2.IsZero()) return Ga501Multivector.Create(this);
        if (IsZero()) return mv2;
        
        return Ga501Multivector.Create(
            mv2.KVector0,
            mv2.KVector1,
            mv2.KVector2,
            mv2.KVector3,
            mv2.KVector4,
            Add(mv2.KVector5),
            mv2.KVector6
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501Multivector Subtract(Ga501KVector0 mv2)
    {
        if (mv2.IsZero()) return Ga501Multivector.Create(this);
        if (IsZero()) return Ga501Multivector.Create(mv2.Negative());
        
        return Ga501Multivector.Create(
            mv2.Negative(),
            Ga501KVector1.Zero,
            Ga501KVector2.Zero,
            Ga501KVector3.Zero,
            Ga501KVector4.Zero,
            this,
            Ga501KVector6.Zero
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501Multivector Subtract(Ga501KVector1 mv2)
    {
        if (mv2.IsZero()) return Ga501Multivector.Create(this);
        if (IsZero()) return Ga501Multivector.Create(mv2.Negative());
        
        return Ga501Multivector.Create(
            Ga501KVector0.Zero,
            mv2.Negative(),
            Ga501KVector2.Zero,
            Ga501KVector3.Zero,
            Ga501KVector4.Zero,
            this,
            Ga501KVector6.Zero
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501Multivector Subtract(Ga501KVector2 mv2)
    {
        if (mv2.IsZero()) return Ga501Multivector.Create(this);
        if (IsZero()) return Ga501Multivector.Create(mv2.Negative());
        
        return Ga501Multivector.Create(
            Ga501KVector0.Zero,
            Ga501KVector1.Zero,
            mv2.Negative(),
            Ga501KVector3.Zero,
            Ga501KVector4.Zero,
            this,
            Ga501KVector6.Zero
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501Multivector Subtract(Ga501KVector3 mv2)
    {
        if (mv2.IsZero()) return Ga501Multivector.Create(this);
        if (IsZero()) return Ga501Multivector.Create(mv2.Negative());
        
        return Ga501Multivector.Create(
            Ga501KVector0.Zero,
            Ga501KVector1.Zero,
            Ga501KVector2.Zero,
            mv2.Negative(),
            Ga501KVector4.Zero,
            this,
            Ga501KVector6.Zero
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501Multivector Subtract(Ga501KVector4 mv2)
    {
        if (mv2.IsZero()) return Ga501Multivector.Create(this);
        if (IsZero()) return Ga501Multivector.Create(mv2.Negative());
        
        return Ga501Multivector.Create(
            Ga501KVector0.Zero,
            Ga501KVector1.Zero,
            Ga501KVector2.Zero,
            Ga501KVector3.Zero,
            mv2.Negative(),
            this,
            Ga501KVector6.Zero
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501KVector5 Subtract(Ga501KVector5 mv2)
    {
        if (mv2.IsZero()) return this;
        if (IsZero()) return mv2.Negative();
        
        return new Ga501KVector5()
        {
            Scalar12345 = Scalar12345 - mv2.Scalar12345,
            Scalar12346 = Scalar12346 - mv2.Scalar12346,
            Scalar12356 = Scalar12356 - mv2.Scalar12356,
            Scalar12456 = Scalar12456 - mv2.Scalar12456,
            Scalar13456 = Scalar13456 - mv2.Scalar13456,
            Scalar23456 = Scalar23456 - mv2.Scalar23456
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501Multivector Subtract(Ga501KVector6 mv2)
    {
        if (mv2.IsZero()) return Ga501Multivector.Create(this);
        if (IsZero()) return Ga501Multivector.Create(mv2.Negative());
        
        return Ga501Multivector.Create(
            Ga501KVector0.Zero,
            Ga501KVector1.Zero,
            Ga501KVector2.Zero,
            Ga501KVector3.Zero,
            Ga501KVector4.Zero,
            this,
            mv2.Negative()
        );
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Ga501Multivector Subtract(Ga501Multivector mv2)
    {
        if (mv2.IsZero()) return Ga501Multivector.Create(this);
        if (IsZero()) return mv2.Negative();
        
        return Ga501Multivector.Create(
            mv2.KVector0.Negative(),
            mv2.KVector1.Negative(),
            mv2.KVector2.Negative(),
            mv2.KVector3.Negative(),
            mv2.KVector4.Negative(),
            Subtract(mv2.KVector5),
            mv2.KVector6.Negative()
        );
    }
    
}
