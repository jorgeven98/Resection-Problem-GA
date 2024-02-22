using System.Runtime.CompilerServices;

namespace GeometricAlgebraFulcrumLib.Generations.Algebra.Ga401;

public static class Ga401RotorMap
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector0 MapUsingRotor(this Ga401KVector0 mv1, Ga401KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector0.Zero;
        
        return new Ga401KVector0
        {
            Scalar = mv2.Scalar * mv1.Scalar * mv2.Scalar
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector0 MapUsingRotor(this Ga401KVector0 mv1, Ga401KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector0.Zero;
        
        return new Ga401KVector0
        {
            Scalar = mv2.Scalar23 * mv1.Scalar * mv2.Scalar23 + mv2.Scalar24 * mv1.Scalar * mv2.Scalar24 + mv2.Scalar34 * mv1.Scalar * mv2.Scalar34 + mv2.Scalar25 * mv1.Scalar * mv2.Scalar25 + mv2.Scalar35 * mv1.Scalar * mv2.Scalar35 + mv2.Scalar45 * mv1.Scalar * mv2.Scalar45
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector0 MapUsingRotor(this Ga401KVector0 mv1, Ga401KVector4 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector0.Zero;
        
        return new Ga401KVector0
        {
            Scalar = mv2.Scalar2345 * mv1.Scalar * mv2.Scalar2345
        };
    }
    
    public static Ga401KVector0 MapUsingRotor(this Ga401KVector0 mv1, Ga401Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector0.Zero;
        
        var tempScalar = 0d;
        
        if (!mv2.KVector0.IsZero())
        {
            tempScalar += mv2.KVector0.Scalar * mv1.Scalar * mv2.KVector0.Scalar;
        }
        
        if (!mv2.KVector2.IsZero())
        {
            tempScalar += mv2.KVector2.Scalar23 * mv1.Scalar * mv2.KVector2.Scalar23 + mv2.KVector2.Scalar24 * mv1.Scalar * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.Scalar * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar25 * mv1.Scalar * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar35 * mv1.Scalar * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.Scalar * mv2.KVector2.Scalar45;
        }
        
        if (!mv2.KVector4.IsZero())
        {
            tempScalar += mv2.KVector4.Scalar2345 * mv1.Scalar * mv2.KVector4.Scalar2345;
        }
        
        return new Ga401KVector0
        {
            Scalar = tempScalar
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector1 MapUsingRotor(this Ga401KVector1 mv1, Ga401KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector1.Zero;
        
        return new Ga401KVector1
        {
            Scalar1 = mv2.Scalar * mv1.Scalar1 * mv2.Scalar,
            Scalar2 = mv2.Scalar * mv1.Scalar2 * mv2.Scalar,
            Scalar3 = mv2.Scalar * mv1.Scalar3 * mv2.Scalar,
            Scalar4 = mv2.Scalar * mv1.Scalar4 * mv2.Scalar,
            Scalar5 = mv2.Scalar * mv1.Scalar5 * mv2.Scalar
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector1 MapUsingRotor(this Ga401KVector1 mv1, Ga401KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector1.Zero;
        
        return new Ga401KVector1
        {
            Scalar1 = 2 * mv2.Scalar12 * mv1.Scalar3 * mv2.Scalar23 + 2 * mv2.Scalar12 * mv1.Scalar4 * mv2.Scalar24 + 2 * mv2.Scalar12 * mv1.Scalar5 * mv2.Scalar25 + 2 * mv2.Scalar13 * mv1.Scalar2 * mv2.Scalar23 + 2 * mv2.Scalar13 * mv1.Scalar4 * mv2.Scalar34 + 2 * mv2.Scalar13 * mv1.Scalar5 * mv2.Scalar35 + mv2.Scalar23 * mv1.Scalar1 * mv2.Scalar23 + 2 * mv2.Scalar14 * mv1.Scalar2 * mv2.Scalar24 + 2 * mv2.Scalar14 * mv1.Scalar3 * mv2.Scalar34 + 2 * mv2.Scalar14 * mv1.Scalar5 * mv2.Scalar45 + mv2.Scalar24 * mv1.Scalar1 * mv2.Scalar24 + mv2.Scalar34 * mv1.Scalar1 * mv2.Scalar34 + 2 * mv2.Scalar15 * mv1.Scalar2 * mv2.Scalar25 + 2 * mv2.Scalar15 * mv1.Scalar3 * mv2.Scalar35 + 2 * mv2.Scalar15 * mv1.Scalar4 * mv2.Scalar45 + mv2.Scalar25 * mv1.Scalar1 * mv2.Scalar25 + mv2.Scalar35 * mv1.Scalar1 * mv2.Scalar35 + mv2.Scalar45 * mv1.Scalar1 * mv2.Scalar45,
            Scalar2 = mv2.Scalar23 * mv1.Scalar2 * mv2.Scalar23 + 2 * mv2.Scalar23 * mv1.Scalar4 * mv2.Scalar34 + 2 * mv2.Scalar23 * mv1.Scalar5 * mv2.Scalar35 + mv2.Scalar24 * mv1.Scalar2 * mv2.Scalar24 + mv2.Scalar34 * mv1.Scalar2 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.Scalar3 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.Scalar5 * mv2.Scalar45 + mv2.Scalar25 * mv1.Scalar2 * mv2.Scalar25 + mv2.Scalar35 * mv1.Scalar2 * mv2.Scalar35 + mv2.Scalar45 * mv1.Scalar2 * mv2.Scalar45 + 2 * mv2.Scalar25 * mv1.Scalar3 * mv2.Scalar35 + 2 * mv2.Scalar25 * mv1.Scalar4 * mv2.Scalar45,
            Scalar3 = mv2.Scalar34 * mv1.Scalar3 * mv2.Scalar34 + mv2.Scalar35 * mv1.Scalar3 * mv2.Scalar35 - mv2.Scalar23 * mv1.Scalar3 * mv2.Scalar23 - mv2.Scalar24 * mv1.Scalar3 * mv2.Scalar24 - mv2.Scalar25 * mv1.Scalar3 * mv2.Scalar25 - 2 * mv2.Scalar23 * mv1.Scalar4 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar5 * mv2.Scalar25 + 2 * mv2.Scalar34 * mv1.Scalar5 * mv2.Scalar45 + mv2.Scalar45 * mv1.Scalar3 * mv2.Scalar45 + 2 * mv2.Scalar35 * mv1.Scalar4 * mv2.Scalar45,
            Scalar4 = mv2.Scalar23 * mv1.Scalar4 * mv2.Scalar23 - mv2.Scalar24 * mv1.Scalar4 * mv2.Scalar24 - mv2.Scalar25 * mv1.Scalar4 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.Scalar5 * mv2.Scalar25 + mv2.Scalar45 * mv1.Scalar4 * mv2.Scalar45 - mv2.Scalar34 * mv1.Scalar4 * mv2.Scalar34 - mv2.Scalar35 * mv1.Scalar4 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.Scalar5 * mv2.Scalar35,
            Scalar5 = mv2.Scalar23 * mv1.Scalar5 * mv2.Scalar23 - mv2.Scalar45 * mv1.Scalar5 * mv2.Scalar45 + mv2.Scalar24 * mv1.Scalar5 * mv2.Scalar24 + mv2.Scalar34 * mv1.Scalar5 * mv2.Scalar34 - mv2.Scalar25 * mv1.Scalar5 * mv2.Scalar25 - mv2.Scalar35 * mv1.Scalar5 * mv2.Scalar35
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector1 MapUsingRotor(this Ga401KVector1 mv1, Ga401KVector4 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector1.Zero;
        
        return new Ga401KVector1
        {
            Scalar1 = 2 * mv2.Scalar1234 * mv1.Scalar5 * mv2.Scalar2345 - 2 * mv2.Scalar1235 * mv1.Scalar4 * mv2.Scalar2345 + 2 * mv2.Scalar1245 * mv1.Scalar3 * mv2.Scalar2345 - 2 * mv2.Scalar1345 * mv1.Scalar2 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.Scalar1 * mv2.Scalar2345,
            Scalar2 = -mv2.Scalar2345 * mv1.Scalar2 * mv2.Scalar2345,
            Scalar3 = -mv2.Scalar2345 * mv1.Scalar3 * mv2.Scalar2345,
            Scalar4 = -mv2.Scalar2345 * mv1.Scalar4 * mv2.Scalar2345,
            Scalar5 = -mv2.Scalar2345 * mv1.Scalar5 * mv2.Scalar2345
        };
    }
    
    public static Ga401KVector1 MapUsingRotor(this Ga401KVector1 mv1, Ga401Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector1.Zero;
        
        var tempScalar0 = 0d;
        var tempScalar1 = 0d;
        var tempScalar2 = 0d;
        var tempScalar3 = 0d;
        var tempScalar4 = 0d;
        
        if (!mv2.KVector0.IsZero())
        {
            tempScalar0 += mv2.KVector0.Scalar * mv1.Scalar1 * mv2.KVector0.Scalar;
            tempScalar1 += mv2.KVector0.Scalar * mv1.Scalar2 * mv2.KVector0.Scalar;
            tempScalar2 += mv2.KVector0.Scalar * mv1.Scalar3 * mv2.KVector0.Scalar;
            tempScalar3 += mv2.KVector0.Scalar * mv1.Scalar4 * mv2.KVector0.Scalar;
            tempScalar4 += mv2.KVector0.Scalar * mv1.Scalar5 * mv2.KVector0.Scalar;
        }
        
        if (!mv2.KVector0.IsZero() && !mv2.KVector2.IsZero())
        {
            tempScalar0 += 2 * mv2.KVector0.Scalar * mv1.Scalar2 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.Scalar3 * mv2.KVector2.Scalar13 + 2 * mv2.KVector0.Scalar * mv1.Scalar4 * mv2.KVector2.Scalar14 + 2 * mv2.KVector0.Scalar * mv1.Scalar5 * mv2.KVector2.Scalar15;
            tempScalar1 += 2 * mv2.KVector0.Scalar * mv1.Scalar3 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.Scalar4 * mv2.KVector2.Scalar24 + 2 * mv2.KVector0.Scalar * mv1.Scalar5 * mv2.KVector2.Scalar25;
            tempScalar2 += -2 * mv2.KVector0.Scalar * mv1.Scalar2 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.Scalar4 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.Scalar5 * mv2.KVector2.Scalar35;
            tempScalar3 += -2 * mv2.KVector0.Scalar * mv1.Scalar2 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.Scalar3 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.Scalar5 * mv2.KVector2.Scalar45;
            tempScalar4 += -2 * mv2.KVector0.Scalar * mv1.Scalar2 * mv2.KVector2.Scalar25 - 2 * mv2.KVector0.Scalar * mv1.Scalar3 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.Scalar4 * mv2.KVector2.Scalar45;
        }
        
        if (!mv2.KVector2.IsZero())
        {
            tempScalar0 += 2 * mv2.KVector2.Scalar12 * mv1.Scalar3 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar12 * mv1.Scalar4 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar12 * mv1.Scalar5 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar13 * mv1.Scalar2 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar13 * mv1.Scalar4 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar13 * mv1.Scalar5 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar23 * mv1.Scalar1 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar14 * mv1.Scalar2 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar14 * mv1.Scalar3 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar14 * mv1.Scalar5 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar24 * mv1.Scalar1 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.Scalar1 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar15 * mv1.Scalar2 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar15 * mv1.Scalar3 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar15 * mv1.Scalar4 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar25 * mv1.Scalar1 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar35 * mv1.Scalar1 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.Scalar1 * mv2.KVector2.Scalar45;
            tempScalar1 += mv2.KVector2.Scalar23 * mv1.Scalar2 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar4 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar5 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar24 * mv1.Scalar2 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.Scalar2 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar24 * mv1.Scalar3 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar24 * mv1.Scalar5 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar25 * mv1.Scalar2 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar35 * mv1.Scalar2 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.Scalar2 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar25 * mv1.Scalar3 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar25 * mv1.Scalar4 * mv2.KVector2.Scalar45;
            tempScalar2 += -mv2.KVector2.Scalar23 * mv1.Scalar3 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.Scalar3 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar25 * mv1.Scalar3 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar4 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar5 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar34 * mv1.Scalar3 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar34 * mv1.Scalar5 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar35 * mv1.Scalar3 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.Scalar3 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar35 * mv1.Scalar4 * mv2.KVector2.Scalar45;
            tempScalar3 += mv2.KVector2.Scalar23 * mv1.Scalar4 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.Scalar4 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar25 * mv1.Scalar4 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar24 * mv1.Scalar5 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar34 * mv1.Scalar4 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar35 * mv1.Scalar4 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.Scalar5 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.Scalar4 * mv2.KVector2.Scalar45;
            tempScalar4 += mv2.KVector2.Scalar23 * mv1.Scalar5 * mv2.KVector2.Scalar23 + mv2.KVector2.Scalar24 * mv1.Scalar5 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.Scalar5 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar25 * mv1.Scalar5 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar35 * mv1.Scalar5 * mv2.KVector2.Scalar35 - mv2.KVector2.Scalar45 * mv1.Scalar5 * mv2.KVector2.Scalar45;
        }
        
        if (!mv2.KVector2.IsZero() && !mv2.KVector4.IsZero())
        {
            tempScalar0 += 2 * mv2.KVector2.Scalar34 * mv1.Scalar2 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector2.Scalar35 * mv1.Scalar2 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar4 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar5 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar45 * mv1.Scalar2 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar24 * mv1.Scalar5 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar45 * mv1.Scalar3 * mv2.KVector4.Scalar1345 + 2 * mv2.KVector2.Scalar34 * mv1.Scalar5 * mv2.KVector4.Scalar1345;
            tempScalar1 += 2 * mv2.KVector2.Scalar34 * mv1.Scalar5 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar45 * mv1.Scalar3 * mv2.KVector4.Scalar2345;
            tempScalar2 += -2 * mv2.KVector2.Scalar24 * mv1.Scalar5 * mv2.KVector4.Scalar2345;
            tempScalar3 += 2 * mv2.KVector2.Scalar23 * mv1.Scalar5 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar25 * mv1.Scalar3 * mv2.KVector4.Scalar2345;
            tempScalar4 += 2 * mv2.KVector2.Scalar24 * mv1.Scalar3 * mv2.KVector4.Scalar2345;
        }
        
        if (!mv2.KVector4.IsZero())
        {
            tempScalar0 += 2 * mv2.KVector4.Scalar1234 * mv1.Scalar5 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector4.Scalar1235 * mv1.Scalar4 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector4.Scalar1345 * mv1.Scalar2 * mv2.KVector4.Scalar2345 + mv2.KVector4.Scalar2345 * mv1.Scalar1 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1245 * mv1.Scalar3 * mv2.KVector4.Scalar2345;
            tempScalar1 += -mv2.KVector4.Scalar2345 * mv1.Scalar2 * mv2.KVector4.Scalar2345;
            tempScalar2 += -mv2.KVector4.Scalar2345 * mv1.Scalar3 * mv2.KVector4.Scalar2345;
            tempScalar3 += -mv2.KVector4.Scalar2345 * mv1.Scalar4 * mv2.KVector4.Scalar2345;
            tempScalar4 += -mv2.KVector4.Scalar2345 * mv1.Scalar5 * mv2.KVector4.Scalar2345;
        }
        
        return new Ga401KVector1
        {
            Scalar1 = tempScalar0,
            Scalar2 = tempScalar1,
            Scalar3 = tempScalar2,
            Scalar4 = tempScalar3,
            Scalar5 = tempScalar4
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector2 MapUsingRotor(this Ga401KVector2 mv1, Ga401KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector2.Zero;
        
        return new Ga401KVector2
        {
            Scalar12 = mv2.Scalar * mv1.Scalar12 * mv2.Scalar,
            Scalar13 = mv2.Scalar * mv1.Scalar13 * mv2.Scalar,
            Scalar23 = mv2.Scalar * mv1.Scalar23 * mv2.Scalar,
            Scalar14 = mv2.Scalar * mv1.Scalar14 * mv2.Scalar,
            Scalar24 = mv2.Scalar * mv1.Scalar24 * mv2.Scalar,
            Scalar34 = mv2.Scalar * mv1.Scalar34 * mv2.Scalar,
            Scalar15 = mv2.Scalar * mv1.Scalar15 * mv2.Scalar,
            Scalar25 = mv2.Scalar * mv1.Scalar25 * mv2.Scalar,
            Scalar35 = mv2.Scalar * mv1.Scalar35 * mv2.Scalar,
            Scalar45 = mv2.Scalar * mv1.Scalar45 * mv2.Scalar
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector2 MapUsingRotor(this Ga401KVector2 mv1, Ga401KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector2.Zero;
        
        return new Ga401KVector2
        {
            Scalar12 = 2 * mv2.Scalar25 * mv1.Scalar14 * mv2.Scalar45 + mv2.Scalar23 * mv1.Scalar12 * mv2.Scalar23 + 2 * mv2.Scalar23 * mv1.Scalar14 * mv2.Scalar34 + 2 * mv2.Scalar23 * mv1.Scalar15 * mv2.Scalar35 + mv2.Scalar24 * mv1.Scalar12 * mv2.Scalar24 + mv2.Scalar34 * mv1.Scalar12 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.Scalar13 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.Scalar15 * mv2.Scalar45 + mv2.Scalar25 * mv1.Scalar12 * mv2.Scalar25 + mv2.Scalar35 * mv1.Scalar12 * mv2.Scalar35 + mv2.Scalar45 * mv1.Scalar12 * mv2.Scalar45 + 2 * mv2.Scalar25 * mv1.Scalar13 * mv2.Scalar35,
            Scalar13 = 2 * mv2.Scalar35 * mv1.Scalar14 * mv2.Scalar45 + 2 * mv2.Scalar12 * mv1.Scalar24 * mv2.Scalar34 + 2 * mv2.Scalar12 * mv1.Scalar25 * mv2.Scalar35 - 2 * mv2.Scalar13 * mv1.Scalar23 * mv2.Scalar23 - 2 * mv2.Scalar13 * mv1.Scalar24 * mv2.Scalar24 - 2 * mv2.Scalar13 * mv1.Scalar25 * mv2.Scalar25 + mv2.Scalar34 * mv1.Scalar13 * mv2.Scalar34 + mv2.Scalar35 * mv1.Scalar13 * mv2.Scalar35 - mv2.Scalar23 * mv1.Scalar13 * mv2.Scalar23 - mv2.Scalar24 * mv1.Scalar13 * mv2.Scalar24 - mv2.Scalar25 * mv1.Scalar13 * mv2.Scalar25 - 2 * mv2.Scalar14 * mv1.Scalar23 * mv2.Scalar24 - 2 * mv2.Scalar15 * mv1.Scalar23 * mv2.Scalar25 - 2 * mv2.Scalar23 * mv1.Scalar14 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar24 * mv2.Scalar14 - 2 * mv2.Scalar23 * mv1.Scalar15 * mv2.Scalar25 - 2 * mv2.Scalar23 * mv1.Scalar25 * mv2.Scalar15 + mv2.Scalar45 * mv1.Scalar13 * mv2.Scalar45 + 2 * mv2.Scalar34 * mv1.Scalar15 * mv2.Scalar45,
            Scalar23 = -mv2.Scalar23 * mv1.Scalar23 * mv2.Scalar23 - mv2.Scalar25 * mv1.Scalar23 * mv2.Scalar25 + mv2.Scalar45 * mv1.Scalar23 * mv2.Scalar45 - mv2.Scalar24 * mv1.Scalar23 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar24 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar25 * mv2.Scalar25 + mv2.Scalar34 * mv1.Scalar23 * mv2.Scalar34 + 2 * mv2.Scalar35 * mv1.Scalar24 * mv2.Scalar45 + 2 * mv2.Scalar34 * mv1.Scalar25 * mv2.Scalar45 + mv2.Scalar35 * mv1.Scalar23 * mv2.Scalar35,
            Scalar14 = 2 * mv2.Scalar12 * mv1.Scalar34 * mv2.Scalar23 + 2 * mv2.Scalar12 * mv1.Scalar25 * mv2.Scalar45 + 2 * mv2.Scalar13 * mv1.Scalar24 * mv2.Scalar23 - 2 * mv2.Scalar15 * mv1.Scalar34 * mv2.Scalar35 + 2 * mv2.Scalar13 * mv1.Scalar35 * mv2.Scalar45 + mv2.Scalar23 * mv1.Scalar14 * mv2.Scalar23 - 2 * mv2.Scalar14 * mv1.Scalar34 * mv2.Scalar34 - 2 * mv2.Scalar14 * mv1.Scalar24 * mv2.Scalar24 - 2 * mv2.Scalar14 * mv1.Scalar25 * mv2.Scalar25 - 2 * mv2.Scalar14 * mv1.Scalar35 * mv2.Scalar35 - mv2.Scalar24 * mv1.Scalar14 * mv2.Scalar24 - mv2.Scalar25 * mv1.Scalar14 * mv2.Scalar25 - 2 * mv2.Scalar15 * mv1.Scalar24 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.Scalar15 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.Scalar25 * mv2.Scalar15 + mv2.Scalar45 * mv1.Scalar14 * mv2.Scalar45 - mv2.Scalar34 * mv1.Scalar14 * mv2.Scalar34 - mv2.Scalar35 * mv1.Scalar14 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.Scalar15 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.Scalar35 * mv2.Scalar15,
            Scalar24 = -mv2.Scalar24 * mv1.Scalar24 * mv2.Scalar24 - 2 * mv2.Scalar24 * mv1.Scalar34 * mv2.Scalar34 + mv2.Scalar23 * mv1.Scalar24 * mv2.Scalar23 + 2 * mv2.Scalar23 * mv1.Scalar35 * mv2.Scalar45 - mv2.Scalar35 * mv1.Scalar24 * mv2.Scalar35 - mv2.Scalar34 * mv1.Scalar24 * mv2.Scalar34 - mv2.Scalar25 * mv1.Scalar24 * mv2.Scalar25 - 2 * mv2.Scalar25 * mv1.Scalar34 * mv2.Scalar35 - 2 * mv2.Scalar24 * mv1.Scalar25 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.Scalar35 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.Scalar25 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.Scalar35 * mv2.Scalar25 + mv2.Scalar45 * mv1.Scalar24 * mv2.Scalar45,
            Scalar34 = mv2.Scalar25 * mv1.Scalar34 * mv2.Scalar25 + mv2.Scalar24 * mv1.Scalar34 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar23 * mv2.Scalar34 + 2 * mv2.Scalar25 * mv1.Scalar23 * mv2.Scalar45 - mv2.Scalar23 * mv1.Scalar34 * mv2.Scalar23 - mv2.Scalar34 * mv1.Scalar34 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.Scalar35 * mv2.Scalar25 - mv2.Scalar35 * mv1.Scalar34 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.Scalar35 * mv2.Scalar35 + mv2.Scalar45 * mv1.Scalar34 * mv2.Scalar45,
            Scalar15 = 2 * mv2.Scalar12 * mv1.Scalar35 * mv2.Scalar23 + 2 * mv2.Scalar12 * mv1.Scalar45 * mv2.Scalar24 + 2 * mv2.Scalar13 * mv1.Scalar25 * mv2.Scalar23 + 2 * mv2.Scalar13 * mv1.Scalar45 * mv2.Scalar34 + mv2.Scalar23 * mv1.Scalar15 * mv2.Scalar23 - 2 * mv2.Scalar15 * mv1.Scalar35 * mv2.Scalar35 + 2 * mv2.Scalar14 * mv1.Scalar25 * mv2.Scalar24 + 2 * mv2.Scalar14 * mv1.Scalar35 * mv2.Scalar34 - mv2.Scalar35 * mv1.Scalar15 * mv2.Scalar35 + mv2.Scalar24 * mv1.Scalar15 * mv2.Scalar24 + mv2.Scalar34 * mv1.Scalar15 * mv2.Scalar34 - 2 * mv2.Scalar15 * mv1.Scalar45 * mv2.Scalar45 - mv2.Scalar45 * mv1.Scalar15 * mv2.Scalar45 - 2 * mv2.Scalar15 * mv1.Scalar25 * mv2.Scalar25 - mv2.Scalar25 * mv1.Scalar15 * mv2.Scalar25,
            Scalar25 = -mv2.Scalar35 * mv1.Scalar25 * mv2.Scalar35 - 2 * mv2.Scalar25 * mv1.Scalar35 * mv2.Scalar35 + mv2.Scalar23 * mv1.Scalar25 * mv2.Scalar23 - mv2.Scalar25 * mv1.Scalar25 * mv2.Scalar25 + 2 * mv2.Scalar23 * mv1.Scalar45 * mv2.Scalar34 - 2 * mv2.Scalar25 * mv1.Scalar45 * mv2.Scalar45 + mv2.Scalar24 * mv1.Scalar25 * mv2.Scalar24 + mv2.Scalar34 * mv1.Scalar25 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.Scalar35 * mv2.Scalar34 - mv2.Scalar45 * mv1.Scalar25 * mv2.Scalar45,
            Scalar35 = 2 * mv2.Scalar34 * mv1.Scalar24 * mv2.Scalar25 + mv2.Scalar25 * mv1.Scalar35 * mv2.Scalar25 - mv2.Scalar45 * mv1.Scalar35 * mv2.Scalar45 - 2 * mv2.Scalar23 * mv1.Scalar23 * mv2.Scalar35 - 2 * mv2.Scalar23 * mv1.Scalar24 * mv2.Scalar45 - mv2.Scalar23 * mv1.Scalar35 * mv2.Scalar23 - mv2.Scalar24 * mv1.Scalar35 * mv2.Scalar24 - mv2.Scalar35 * mv1.Scalar35 * mv2.Scalar35 - 2 * mv2.Scalar23 * mv1.Scalar45 * mv2.Scalar24 - 2 * mv2.Scalar35 * mv1.Scalar45 * mv2.Scalar45 - 2 * mv2.Scalar24 * mv1.Scalar23 * mv2.Scalar45 - 2 * mv2.Scalar24 * mv1.Scalar24 * mv2.Scalar35 + mv2.Scalar34 * mv1.Scalar35 * mv2.Scalar34,
            Scalar45 = 2 * mv2.Scalar23 * mv1.Scalar24 * mv2.Scalar35 + 2 * mv2.Scalar23 * mv1.Scalar34 * mv2.Scalar25 + mv2.Scalar23 * mv1.Scalar45 * mv2.Scalar23 - 2 * mv2.Scalar24 * mv1.Scalar24 * mv2.Scalar45 - mv2.Scalar24 * mv1.Scalar45 * mv2.Scalar24 + mv2.Scalar35 * mv1.Scalar45 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.Scalar34 * mv2.Scalar45 - mv2.Scalar34 * mv1.Scalar45 * mv2.Scalar34 + mv2.Scalar25 * mv1.Scalar45 * mv2.Scalar25 - mv2.Scalar45 * mv1.Scalar45 * mv2.Scalar45
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector2 MapUsingRotor(this Ga401KVector2 mv1, Ga401KVector4 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector2.Zero;
        
        return new Ga401KVector2
        {
            Scalar12 = 2 * mv2.Scalar1234 * mv1.Scalar25 * mv2.Scalar2345 - 2 * mv2.Scalar1235 * mv1.Scalar24 * mv2.Scalar2345 + 2 * mv2.Scalar1245 * mv1.Scalar23 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.Scalar12 * mv2.Scalar2345,
            Scalar13 = 2 * mv2.Scalar1234 * mv1.Scalar35 * mv2.Scalar2345 - 2 * mv2.Scalar1235 * mv1.Scalar34 * mv2.Scalar2345 + 2 * mv2.Scalar1345 * mv1.Scalar23 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.Scalar13 * mv2.Scalar2345,
            Scalar23 = mv2.Scalar2345 * mv1.Scalar23 * mv2.Scalar2345,
            Scalar14 = 2 * mv2.Scalar1234 * mv1.Scalar45 * mv2.Scalar2345 - 2 * mv2.Scalar1245 * mv1.Scalar34 * mv2.Scalar2345 + 2 * mv2.Scalar1345 * mv1.Scalar24 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.Scalar14 * mv2.Scalar2345,
            Scalar24 = mv2.Scalar2345 * mv1.Scalar24 * mv2.Scalar2345,
            Scalar34 = mv2.Scalar2345 * mv1.Scalar34 * mv2.Scalar2345,
            Scalar15 = 2 * mv2.Scalar1235 * mv1.Scalar45 * mv2.Scalar2345 - 2 * mv2.Scalar1245 * mv1.Scalar35 * mv2.Scalar2345 + 2 * mv2.Scalar1345 * mv1.Scalar25 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.Scalar15 * mv2.Scalar2345,
            Scalar25 = mv2.Scalar2345 * mv1.Scalar25 * mv2.Scalar2345,
            Scalar35 = mv2.Scalar2345 * mv1.Scalar35 * mv2.Scalar2345,
            Scalar45 = mv2.Scalar2345 * mv1.Scalar45 * mv2.Scalar2345
        };
    }
    
    public static Ga401KVector2 MapUsingRotor(this Ga401KVector2 mv1, Ga401Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector2.Zero;
        
        var tempScalar0 = 0d;
        var tempScalar1 = 0d;
        var tempScalar2 = 0d;
        var tempScalar3 = 0d;
        var tempScalar4 = 0d;
        var tempScalar5 = 0d;
        var tempScalar6 = 0d;
        var tempScalar7 = 0d;
        var tempScalar8 = 0d;
        var tempScalar9 = 0d;
        
        if (!mv2.KVector0.IsZero())
        {
            tempScalar0 += mv2.KVector0.Scalar * mv1.Scalar12 * mv2.KVector0.Scalar;
            tempScalar1 += mv2.KVector0.Scalar * mv1.Scalar13 * mv2.KVector0.Scalar;
            tempScalar2 += mv2.KVector0.Scalar * mv1.Scalar23 * mv2.KVector0.Scalar;
            tempScalar3 += mv2.KVector0.Scalar * mv1.Scalar14 * mv2.KVector0.Scalar;
            tempScalar4 += mv2.KVector0.Scalar * mv1.Scalar24 * mv2.KVector0.Scalar;
            tempScalar5 += mv2.KVector0.Scalar * mv1.Scalar34 * mv2.KVector0.Scalar;
            tempScalar6 += mv2.KVector0.Scalar * mv1.Scalar15 * mv2.KVector0.Scalar;
            tempScalar7 += mv2.KVector0.Scalar * mv1.Scalar25 * mv2.KVector0.Scalar;
            tempScalar8 += mv2.KVector0.Scalar * mv1.Scalar35 * mv2.KVector0.Scalar;
            tempScalar9 += mv2.KVector0.Scalar * mv1.Scalar45 * mv2.KVector0.Scalar;
        }
        
        if (!mv2.KVector0.IsZero() && !mv2.KVector2.IsZero())
        {
            tempScalar0 += 2 * mv2.KVector0.Scalar * mv1.Scalar13 * mv2.KVector2.Scalar23 - 2 * mv2.KVector0.Scalar * mv1.Scalar23 * mv2.KVector2.Scalar13 + 2 * mv2.KVector0.Scalar * mv1.Scalar14 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.Scalar24 * mv2.KVector2.Scalar14 + 2 * mv2.KVector0.Scalar * mv1.Scalar15 * mv2.KVector2.Scalar25 - 2 * mv2.KVector0.Scalar * mv1.Scalar25 * mv2.KVector2.Scalar15;
            tempScalar1 += -2 * mv2.KVector0.Scalar * mv1.Scalar12 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.Scalar23 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.Scalar14 * mv2.KVector2.Scalar34 - 2 * mv2.KVector0.Scalar * mv1.Scalar34 * mv2.KVector2.Scalar14 + 2 * mv2.KVector0.Scalar * mv1.Scalar15 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.Scalar35 * mv2.KVector2.Scalar15;
            tempScalar2 += 2 * mv2.KVector0.Scalar * mv1.Scalar24 * mv2.KVector2.Scalar34 - 2 * mv2.KVector0.Scalar * mv1.Scalar34 * mv2.KVector2.Scalar24 + 2 * mv2.KVector0.Scalar * mv1.Scalar25 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.Scalar35 * mv2.KVector2.Scalar25;
            tempScalar3 += -2 * mv2.KVector0.Scalar * mv1.Scalar12 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.Scalar13 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.Scalar24 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.Scalar34 * mv2.KVector2.Scalar13 + 2 * mv2.KVector0.Scalar * mv1.Scalar15 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.Scalar45 * mv2.KVector2.Scalar15;
            tempScalar4 += -2 * mv2.KVector0.Scalar * mv1.Scalar23 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.Scalar34 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.Scalar25 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.Scalar45 * mv2.KVector2.Scalar25;
            tempScalar5 += 2 * mv2.KVector0.Scalar * mv1.Scalar23 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.Scalar24 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.Scalar35 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.Scalar45 * mv2.KVector2.Scalar35;
            tempScalar6 += -2 * mv2.KVector0.Scalar * mv1.Scalar12 * mv2.KVector2.Scalar25 - 2 * mv2.KVector0.Scalar * mv1.Scalar13 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.Scalar14 * mv2.KVector2.Scalar45 + 2 * mv2.KVector0.Scalar * mv1.Scalar25 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.Scalar35 * mv2.KVector2.Scalar13 + 2 * mv2.KVector0.Scalar * mv1.Scalar45 * mv2.KVector2.Scalar14;
            tempScalar7 += -2 * mv2.KVector0.Scalar * mv1.Scalar23 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.Scalar24 * mv2.KVector2.Scalar45 + 2 * mv2.KVector0.Scalar * mv1.Scalar35 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.Scalar45 * mv2.KVector2.Scalar24;
            tempScalar8 += 2 * mv2.KVector0.Scalar * mv1.Scalar23 * mv2.KVector2.Scalar25 - 2 * mv2.KVector0.Scalar * mv1.Scalar34 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.Scalar25 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.Scalar45 * mv2.KVector2.Scalar34;
            tempScalar9 += 2 * mv2.KVector0.Scalar * mv1.Scalar24 * mv2.KVector2.Scalar25 + 2 * mv2.KVector0.Scalar * mv1.Scalar34 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.Scalar25 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.Scalar35 * mv2.KVector2.Scalar34;
        }
        
        if (!mv2.KVector0.IsZero() && !mv2.KVector4.IsZero())
        {
            tempScalar0 += -2 * mv2.KVector0.Scalar * mv1.Scalar34 * mv2.KVector4.Scalar1234 - 2 * mv2.KVector0.Scalar * mv1.Scalar35 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector0.Scalar * mv1.Scalar45 * mv2.KVector4.Scalar1245;
            tempScalar1 += 2 * mv2.KVector0.Scalar * mv1.Scalar24 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector0.Scalar * mv1.Scalar25 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector0.Scalar * mv1.Scalar45 * mv2.KVector4.Scalar1345;
            tempScalar2 += -2 * mv2.KVector0.Scalar * mv1.Scalar45 * mv2.KVector4.Scalar2345;
            tempScalar3 += -2 * mv2.KVector0.Scalar * mv1.Scalar23 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector0.Scalar * mv1.Scalar25 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector0.Scalar * mv1.Scalar35 * mv2.KVector4.Scalar1345;
            tempScalar4 += 2 * mv2.KVector0.Scalar * mv1.Scalar35 * mv2.KVector4.Scalar2345;
            tempScalar5 += -2 * mv2.KVector0.Scalar * mv1.Scalar25 * mv2.KVector4.Scalar2345;
            tempScalar6 += -2 * mv2.KVector0.Scalar * mv1.Scalar23 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector0.Scalar * mv1.Scalar24 * mv2.KVector4.Scalar1245 - 2 * mv2.KVector0.Scalar * mv1.Scalar34 * mv2.KVector4.Scalar1345;
            tempScalar7 += -2 * mv2.KVector0.Scalar * mv1.Scalar34 * mv2.KVector4.Scalar2345;
            tempScalar8 += 2 * mv2.KVector0.Scalar * mv1.Scalar24 * mv2.KVector4.Scalar2345;
            tempScalar9 += -2 * mv2.KVector0.Scalar * mv1.Scalar23 * mv2.KVector4.Scalar2345;
        }
        
        if (!mv2.KVector2.IsZero())
        {
            tempScalar0 += mv2.KVector2.Scalar23 * mv1.Scalar12 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar14 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar15 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar24 * mv1.Scalar12 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.Scalar12 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar24 * mv1.Scalar13 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar24 * mv1.Scalar15 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar25 * mv1.Scalar12 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar35 * mv1.Scalar12 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.Scalar12 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar25 * mv1.Scalar13 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar25 * mv1.Scalar14 * mv2.KVector2.Scalar45;
            tempScalar1 += 2 * mv2.KVector2.Scalar12 * mv1.Scalar24 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar12 * mv1.Scalar25 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar13 * mv1.Scalar23 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar13 * mv1.Scalar24 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar13 * mv1.Scalar25 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar23 * mv1.Scalar13 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.Scalar13 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar25 * mv1.Scalar13 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar14 * mv1.Scalar23 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar15 * mv1.Scalar23 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar14 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar24 * mv2.KVector2.Scalar14 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar15 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar25 * mv2.KVector2.Scalar15 + mv2.KVector2.Scalar34 * mv1.Scalar13 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar34 * mv1.Scalar15 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar35 * mv1.Scalar13 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.Scalar13 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar35 * mv1.Scalar14 * mv2.KVector2.Scalar45;
            tempScalar2 += -mv2.KVector2.Scalar23 * mv1.Scalar23 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.Scalar23 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar24 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar25 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar34 * mv1.Scalar23 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar45 * mv1.Scalar23 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar25 * mv1.Scalar23 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar34 * mv1.Scalar25 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar35 * mv1.Scalar23 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar35 * mv1.Scalar24 * mv2.KVector2.Scalar45;
            tempScalar3 += 2 * mv2.KVector2.Scalar12 * mv1.Scalar34 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar12 * mv1.Scalar25 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar13 * mv1.Scalar24 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar15 * mv1.Scalar34 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar13 * mv1.Scalar35 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar23 * mv1.Scalar14 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar14 * mv1.Scalar34 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar14 * mv1.Scalar24 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar14 * mv1.Scalar25 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar14 * mv1.Scalar35 * mv2.KVector2.Scalar35 - mv2.KVector2.Scalar24 * mv1.Scalar14 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar25 * mv1.Scalar14 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar15 * mv1.Scalar24 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar24 * mv1.Scalar15 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar24 * mv1.Scalar25 * mv2.KVector2.Scalar15 + mv2.KVector2.Scalar45 * mv1.Scalar14 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar34 * mv1.Scalar14 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar35 * mv1.Scalar14 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.Scalar15 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.Scalar35 * mv2.KVector2.Scalar15;
            tempScalar4 += -mv2.KVector2.Scalar24 * mv1.Scalar24 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar24 * mv1.Scalar34 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar25 * mv1.Scalar34 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar23 * mv1.Scalar24 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar35 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar35 * mv1.Scalar24 * mv2.KVector2.Scalar35 - mv2.KVector2.Scalar34 * mv1.Scalar24 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar25 * mv1.Scalar24 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar24 * mv1.Scalar25 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar24 * mv1.Scalar35 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.Scalar24 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar34 * mv1.Scalar25 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.Scalar35 * mv2.KVector2.Scalar25;
            tempScalar5 += 2 * mv2.KVector2.Scalar25 * mv1.Scalar23 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar24 * mv1.Scalar34 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar23 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar23 * mv1.Scalar34 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar34 * mv1.Scalar34 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar25 * mv1.Scalar34 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar24 * mv1.Scalar35 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar35 * mv1.Scalar34 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.Scalar35 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.Scalar34 * mv2.KVector2.Scalar45;
            tempScalar6 += 2 * mv2.KVector2.Scalar12 * mv1.Scalar35 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar12 * mv1.Scalar45 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar45 * mv1.Scalar15 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar13 * mv1.Scalar25 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar13 * mv1.Scalar45 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar23 * mv1.Scalar15 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar15 * mv1.Scalar35 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar14 * mv1.Scalar25 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar14 * mv1.Scalar35 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar24 * mv1.Scalar15 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.Scalar15 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar15 * mv1.Scalar45 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar15 * mv1.Scalar25 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar25 * mv1.Scalar15 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar35 * mv1.Scalar15 * mv2.KVector2.Scalar35;
            tempScalar7 += -mv2.KVector2.Scalar35 * mv1.Scalar25 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar25 * mv1.Scalar35 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar23 * mv1.Scalar25 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar45 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar25 * mv1.Scalar45 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar24 * mv1.Scalar25 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.Scalar25 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar24 * mv1.Scalar35 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar25 * mv1.Scalar25 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar45 * mv1.Scalar25 * mv2.KVector2.Scalar45;
            tempScalar8 += -mv2.KVector2.Scalar45 * mv1.Scalar35 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar23 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar24 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar23 * mv1.Scalar35 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.Scalar35 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar35 * mv1.Scalar35 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar45 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar35 * mv1.Scalar45 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar24 * mv1.Scalar23 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar24 * mv1.Scalar24 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar25 * mv1.Scalar35 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar34 * mv1.Scalar24 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar34 * mv1.Scalar35 * mv2.KVector2.Scalar34;
            tempScalar9 += 2 * mv2.KVector2.Scalar23 * mv1.Scalar24 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar34 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar23 * mv1.Scalar45 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar24 * mv1.Scalar24 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar24 * mv1.Scalar45 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar35 * mv1.Scalar45 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.Scalar34 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar34 * mv1.Scalar45 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar25 * mv1.Scalar45 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar45 * mv1.Scalar45 * mv2.KVector2.Scalar45;
        }
        
        if (!mv2.KVector2.IsZero() && !mv2.KVector4.IsZero())
        {
            tempScalar0 += 2 * mv2.KVector2.Scalar23 * mv1.Scalar24 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar25 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar14 * mv1.Scalar35 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar24 * mv1.Scalar25 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar24 * mv1.Scalar35 * mv2.KVector4.Scalar1345 + 2 * mv2.KVector2.Scalar45 * mv1.Scalar13 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar34 * mv1.Scalar15 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar34 * mv1.Scalar35 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar35 * mv1.Scalar24 * mv2.KVector4.Scalar1345;
            tempScalar1 += 2 * mv2.KVector2.Scalar45 * mv1.Scalar23 * mv2.KVector4.Scalar1245 - 2 * mv2.KVector2.Scalar24 * mv1.Scalar15 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar24 * mv1.Scalar35 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar34 * mv1.Scalar25 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar34 * mv1.Scalar35 * mv2.KVector4.Scalar1345 - 2 * mv2.KVector2.Scalar15 * mv1.Scalar24 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar25 * mv1.Scalar24 * mv2.KVector4.Scalar1345;
            tempScalar2 += 2 * mv2.KVector2.Scalar34 * mv1.Scalar35 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar25 * mv1.Scalar24 * mv2.KVector4.Scalar2345;
            tempScalar3 += 2 * mv2.KVector2.Scalar12 * mv1.Scalar35 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar34 * mv1.Scalar24 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar15 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar35 * mv2.KVector4.Scalar1245 - 2 * mv2.KVector2.Scalar25 * mv1.Scalar34 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar34 * mv1.Scalar25 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar25 * mv1.Scalar13 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar35 * mv1.Scalar23 * mv2.KVector4.Scalar1245;
            tempScalar5 += 2 * mv2.KVector2.Scalar45 * mv1.Scalar24 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar35 * mv2.KVector4.Scalar2345;
            tempScalar6 += 2 * mv2.KVector2.Scalar13 * mv1.Scalar24 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar24 * mv2.KVector4.Scalar1345 + 2 * mv2.KVector2.Scalar34 * mv1.Scalar25 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar45 * mv2.KVector4.Scalar1234 - 2 * mv2.KVector2.Scalar45 * mv1.Scalar25 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar24 * mv1.Scalar13 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar24 * mv1.Scalar34 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar35 * mv1.Scalar25 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar34 * mv1.Scalar23 * mv2.KVector4.Scalar1245 - 2 * mv2.KVector2.Scalar45 * mv1.Scalar35 * mv2.KVector4.Scalar1345;
            tempScalar7 += 2 * mv2.KVector2.Scalar23 * mv1.Scalar24 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar45 * mv1.Scalar35 * mv2.KVector4.Scalar2345;
            tempScalar9 += -2 * mv2.KVector2.Scalar34 * mv1.Scalar24 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar25 * mv1.Scalar35 * mv2.KVector4.Scalar2345;
        }
        
        if (!mv2.KVector4.IsZero() && !mv2.KVector2.IsZero())
        {
            tempScalar0 += 2 * mv2.KVector4.Scalar1235 * mv1.Scalar34 * mv2.KVector2.Scalar45 + 2 * mv2.KVector4.Scalar1234 * mv1.Scalar45 * mv2.KVector2.Scalar35;
            tempScalar1 += 2 * mv2.KVector4.Scalar1234 * mv1.Scalar25 * mv2.KVector2.Scalar45 - 2 * mv2.KVector4.Scalar1234 * mv1.Scalar45 * mv2.KVector2.Scalar25;
            tempScalar3 += -2 * mv2.KVector4.Scalar1234 * mv1.Scalar25 * mv2.KVector2.Scalar35;
            tempScalar6 += -2 * mv2.KVector4.Scalar1234 * mv1.Scalar24 * mv2.KVector2.Scalar35;
        }
        
        if (!mv2.KVector4.IsZero())
        {
            tempScalar0 += -mv2.KVector4.Scalar2345 * mv1.Scalar12 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1245 * mv1.Scalar23 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector4.Scalar1235 * mv1.Scalar24 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1234 * mv1.Scalar25 * mv2.KVector4.Scalar2345;
            tempScalar1 += 2 * mv2.KVector4.Scalar1345 * mv1.Scalar23 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector4.Scalar1235 * mv1.Scalar34 * mv2.KVector4.Scalar2345 - mv2.KVector4.Scalar2345 * mv1.Scalar13 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1234 * mv1.Scalar35 * mv2.KVector4.Scalar2345;
            tempScalar2 += mv2.KVector4.Scalar2345 * mv1.Scalar23 * mv2.KVector4.Scalar2345;
            tempScalar3 += -2 * mv2.KVector4.Scalar1245 * mv1.Scalar34 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1234 * mv1.Scalar45 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1345 * mv1.Scalar24 * mv2.KVector4.Scalar2345 - mv2.KVector4.Scalar2345 * mv1.Scalar14 * mv2.KVector4.Scalar2345;
            tempScalar4 += mv2.KVector4.Scalar2345 * mv1.Scalar24 * mv2.KVector4.Scalar2345;
            tempScalar5 += mv2.KVector4.Scalar2345 * mv1.Scalar34 * mv2.KVector4.Scalar2345;
            tempScalar6 += 2 * mv2.KVector4.Scalar1345 * mv1.Scalar25 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1235 * mv1.Scalar45 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector4.Scalar1245 * mv1.Scalar35 * mv2.KVector4.Scalar2345 - mv2.KVector4.Scalar2345 * mv1.Scalar15 * mv2.KVector4.Scalar2345;
            tempScalar7 += mv2.KVector4.Scalar2345 * mv1.Scalar25 * mv2.KVector4.Scalar2345;
            tempScalar8 += mv2.KVector4.Scalar2345 * mv1.Scalar35 * mv2.KVector4.Scalar2345;
            tempScalar9 += mv2.KVector4.Scalar2345 * mv1.Scalar45 * mv2.KVector4.Scalar2345;
        }
        
        return new Ga401KVector2
        {
            Scalar12 = tempScalar0,
            Scalar13 = tempScalar1,
            Scalar23 = tempScalar2,
            Scalar14 = tempScalar3,
            Scalar24 = tempScalar4,
            Scalar34 = tempScalar5,
            Scalar15 = tempScalar6,
            Scalar25 = tempScalar7,
            Scalar35 = tempScalar8,
            Scalar45 = tempScalar9
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector3 MapUsingRotor(this Ga401KVector3 mv1, Ga401KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector3.Zero;
        
        return new Ga401KVector3
        {
            Scalar123 = mv2.Scalar * mv1.Scalar123 * mv2.Scalar,
            Scalar124 = mv2.Scalar * mv1.Scalar124 * mv2.Scalar,
            Scalar134 = mv2.Scalar * mv1.Scalar134 * mv2.Scalar,
            Scalar234 = mv2.Scalar * mv1.Scalar234 * mv2.Scalar,
            Scalar125 = mv2.Scalar * mv1.Scalar125 * mv2.Scalar,
            Scalar135 = mv2.Scalar * mv1.Scalar135 * mv2.Scalar,
            Scalar235 = mv2.Scalar * mv1.Scalar235 * mv2.Scalar,
            Scalar145 = mv2.Scalar * mv1.Scalar145 * mv2.Scalar,
            Scalar245 = mv2.Scalar * mv1.Scalar245 * mv2.Scalar,
            Scalar345 = mv2.Scalar * mv1.Scalar345 * mv2.Scalar
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector3 MapUsingRotor(this Ga401KVector3 mv1, Ga401KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector3.Zero;
        
        return new Ga401KVector3
        {
            Scalar123 = -2 * mv2.Scalar12 * mv1.Scalar234 * mv2.Scalar24 - 2 * mv2.Scalar12 * mv1.Scalar235 * mv2.Scalar25 + 2 * mv2.Scalar15 * mv1.Scalar234 * mv2.Scalar45 + 2 * mv2.Scalar13 * mv1.Scalar234 * mv2.Scalar34 + 2 * mv2.Scalar13 * mv1.Scalar235 * mv2.Scalar35 + 2 * mv2.Scalar34 * mv1.Scalar245 * mv2.Scalar15 + 2 * mv2.Scalar13 * mv1.Scalar245 * mv2.Scalar45 - mv2.Scalar23 * mv1.Scalar123 * mv2.Scalar23 - mv2.Scalar24 * mv1.Scalar123 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar124 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar125 * mv2.Scalar25 + 2 * mv2.Scalar14 * mv1.Scalar235 * mv2.Scalar45 + 2 * mv2.Scalar14 * mv1.Scalar245 * mv2.Scalar35 + mv2.Scalar35 * mv1.Scalar123 * mv2.Scalar35 + mv2.Scalar34 * mv1.Scalar123 * mv2.Scalar34 - mv2.Scalar25 * mv1.Scalar123 * mv2.Scalar25 + 2 * mv2.Scalar35 * mv1.Scalar124 * mv2.Scalar45 + 2 * mv2.Scalar34 * mv1.Scalar125 * mv2.Scalar45 + mv2.Scalar45 * mv1.Scalar123 * mv2.Scalar45,
            Scalar124 = -2 * mv2.Scalar12 * mv1.Scalar245 * mv2.Scalar25 - 2 * mv2.Scalar12 * mv1.Scalar345 * mv2.Scalar35 - 2 * mv2.Scalar13 * mv1.Scalar245 * mv2.Scalar35 - 2 * mv2.Scalar13 * mv1.Scalar345 * mv2.Scalar25 + mv2.Scalar23 * mv1.Scalar124 * mv2.Scalar23 + 2 * mv2.Scalar23 * mv1.Scalar135 * mv2.Scalar45 + 2 * mv2.Scalar23 * mv1.Scalar345 * mv2.Scalar15 + 2 * mv2.Scalar14 * mv1.Scalar245 * mv2.Scalar45 - mv2.Scalar24 * mv1.Scalar124 * mv2.Scalar24 - mv2.Scalar34 * mv1.Scalar124 * mv2.Scalar34 - mv2.Scalar25 * mv1.Scalar124 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.Scalar134 * mv2.Scalar34 - 2 * mv2.Scalar25 * mv1.Scalar134 * mv2.Scalar35 - 2 * mv2.Scalar24 * mv1.Scalar125 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.Scalar135 * mv2.Scalar35 + mv2.Scalar45 * mv1.Scalar124 * mv2.Scalar45 - 2 * mv2.Scalar34 * mv1.Scalar125 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.Scalar135 * mv2.Scalar25 - mv2.Scalar35 * mv1.Scalar124 * mv2.Scalar35,
            Scalar134 = 2 * mv2.Scalar12 * mv1.Scalar235 * mv2.Scalar45 + 2 * mv2.Scalar12 * mv1.Scalar345 * mv2.Scalar25 - 2 * mv2.Scalar13 * mv1.Scalar234 * mv2.Scalar23 + 2 * mv2.Scalar24 * mv1.Scalar235 * mv2.Scalar15 - 2 * mv2.Scalar13 * mv1.Scalar345 * mv2.Scalar35 - 2 * mv2.Scalar23 * mv1.Scalar123 * mv2.Scalar34 + 2 * mv2.Scalar25 * mv1.Scalar123 * mv2.Scalar45 - mv2.Scalar23 * mv1.Scalar134 * mv2.Scalar23 - mv2.Scalar34 * mv1.Scalar134 * mv2.Scalar34 + 2 * mv2.Scalar14 * mv1.Scalar234 * mv2.Scalar24 + 2 * mv2.Scalar14 * mv1.Scalar235 * mv2.Scalar25 + 2 * mv2.Scalar14 * mv1.Scalar345 * mv2.Scalar45 + mv2.Scalar24 * mv1.Scalar134 * mv2.Scalar24 + 2 * mv2.Scalar15 * mv1.Scalar234 * mv2.Scalar25 + 2 * mv2.Scalar24 * mv1.Scalar135 * mv2.Scalar25 + mv2.Scalar25 * mv1.Scalar134 * mv2.Scalar25 - mv2.Scalar35 * mv1.Scalar134 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.Scalar135 * mv2.Scalar35 + mv2.Scalar45 * mv1.Scalar134 * mv2.Scalar45,
            Scalar234 = -mv2.Scalar23 * mv1.Scalar234 * mv2.Scalar23 - mv2.Scalar35 * mv1.Scalar234 * mv2.Scalar35 - 2 * mv2.Scalar23 * mv1.Scalar345 * mv2.Scalar35 - mv2.Scalar34 * mv1.Scalar234 * mv2.Scalar34 + mv2.Scalar24 * mv1.Scalar234 * mv2.Scalar24 + mv2.Scalar25 * mv1.Scalar234 * mv2.Scalar25 + mv2.Scalar45 * mv1.Scalar234 * mv2.Scalar45 + 2 * mv2.Scalar24 * mv1.Scalar235 * mv2.Scalar25 + 2 * mv2.Scalar24 * mv1.Scalar345 * mv2.Scalar45 - 2 * mv2.Scalar34 * mv1.Scalar235 * mv2.Scalar35,
            Scalar125 = -2 * mv2.Scalar13 * mv1.Scalar234 * mv2.Scalar45 + mv2.Scalar23 * mv1.Scalar125 * mv2.Scalar23 - mv2.Scalar25 * mv1.Scalar125 * mv2.Scalar25 + 2 * mv2.Scalar23 * mv1.Scalar145 * mv2.Scalar34 - 2 * mv2.Scalar25 * mv1.Scalar145 * mv2.Scalar45 - mv2.Scalar35 * mv1.Scalar125 * mv2.Scalar35 - 2 * mv2.Scalar14 * mv1.Scalar234 * mv2.Scalar35 + mv2.Scalar24 * mv1.Scalar125 * mv2.Scalar24 + mv2.Scalar34 * mv1.Scalar125 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.Scalar135 * mv2.Scalar34 + 2 * mv2.Scalar34 * mv1.Scalar234 * mv2.Scalar15 - mv2.Scalar45 * mv1.Scalar125 * mv2.Scalar45 - 2 * mv2.Scalar25 * mv1.Scalar135 * mv2.Scalar35,
            Scalar135 = 2 * mv2.Scalar15 * mv1.Scalar235 * mv2.Scalar25 + 2 * mv2.Scalar12 * mv1.Scalar245 * mv2.Scalar34 - 2 * mv2.Scalar13 * mv1.Scalar235 * mv2.Scalar23 - 2 * mv2.Scalar13 * mv1.Scalar245 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar123 * mv2.Scalar35 - 2 * mv2.Scalar23 * mv1.Scalar124 * mv2.Scalar45 - mv2.Scalar23 * mv1.Scalar135 * mv2.Scalar23 - mv2.Scalar24 * mv1.Scalar135 * mv2.Scalar24 - mv2.Scalar35 * mv1.Scalar135 * mv2.Scalar35 - 2 * mv2.Scalar14 * mv1.Scalar235 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar145 * mv2.Scalar24 - 2 * mv2.Scalar35 * mv1.Scalar145 * mv2.Scalar45 - 2 * mv2.Scalar23 * mv1.Scalar245 * mv2.Scalar14 - 2 * mv2.Scalar24 * mv1.Scalar123 * mv2.Scalar45 - 2 * mv2.Scalar24 * mv1.Scalar124 * mv2.Scalar35 - mv2.Scalar45 * mv1.Scalar135 * mv2.Scalar45 + 2 * mv2.Scalar34 * mv1.Scalar124 * mv2.Scalar25 + mv2.Scalar34 * mv1.Scalar135 * mv2.Scalar34 + mv2.Scalar25 * mv1.Scalar135 * mv2.Scalar25,
            Scalar235 = -mv2.Scalar23 * mv1.Scalar235 * mv2.Scalar23 - 2 * mv2.Scalar35 * mv1.Scalar245 * mv2.Scalar45 - mv2.Scalar24 * mv1.Scalar235 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar245 * mv2.Scalar24 + mv2.Scalar34 * mv1.Scalar235 * mv2.Scalar34 - mv2.Scalar45 * mv1.Scalar235 * mv2.Scalar45 - mv2.Scalar35 * mv1.Scalar235 * mv2.Scalar35 + mv2.Scalar25 * mv1.Scalar235 * mv2.Scalar25,
            Scalar145 = 2 * mv2.Scalar12 * mv1.Scalar234 * mv2.Scalar35 + 2 * mv2.Scalar12 * mv1.Scalar345 * mv2.Scalar23 + 2 * mv2.Scalar13 * mv1.Scalar234 * mv2.Scalar25 + 2 * mv2.Scalar13 * mv1.Scalar245 * mv2.Scalar23 + 2 * mv2.Scalar23 * mv1.Scalar124 * mv2.Scalar35 + 2 * mv2.Scalar23 * mv1.Scalar134 * mv2.Scalar25 + 2 * mv2.Scalar23 * mv1.Scalar234 * mv2.Scalar15 + mv2.Scalar23 * mv1.Scalar145 * mv2.Scalar23 + 2 * mv2.Scalar15 * mv1.Scalar245 * mv2.Scalar25 - 2 * mv2.Scalar14 * mv1.Scalar345 * mv2.Scalar34 - 2 * mv2.Scalar14 * mv1.Scalar245 * mv2.Scalar24 - 2 * mv2.Scalar24 * mv1.Scalar124 * mv2.Scalar45 - mv2.Scalar24 * mv1.Scalar145 * mv2.Scalar24 + mv2.Scalar35 * mv1.Scalar145 * mv2.Scalar35 + 2 * mv2.Scalar15 * mv1.Scalar345 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.Scalar134 * mv2.Scalar45 - mv2.Scalar34 * mv1.Scalar145 * mv2.Scalar34 + mv2.Scalar25 * mv1.Scalar145 * mv2.Scalar25 - mv2.Scalar45 * mv1.Scalar145 * mv2.Scalar45,
            Scalar245 = -mv2.Scalar24 * mv1.Scalar245 * mv2.Scalar24 - 2 * mv2.Scalar24 * mv1.Scalar345 * mv2.Scalar34 + mv2.Scalar35 * mv1.Scalar245 * mv2.Scalar35 + 2 * mv2.Scalar23 * mv1.Scalar234 * mv2.Scalar25 + mv2.Scalar23 * mv1.Scalar245 * mv2.Scalar23 + mv2.Scalar25 * mv1.Scalar245 * mv2.Scalar25 - mv2.Scalar34 * mv1.Scalar245 * mv2.Scalar34 - 2 * mv2.Scalar34 * mv1.Scalar234 * mv2.Scalar45 - mv2.Scalar45 * mv1.Scalar245 * mv2.Scalar45 + 2 * mv2.Scalar25 * mv1.Scalar345 * mv2.Scalar35,
            Scalar345 = mv2.Scalar24 * mv1.Scalar345 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar235 * mv2.Scalar34 - mv2.Scalar23 * mv1.Scalar345 * mv2.Scalar23 - mv2.Scalar34 * mv1.Scalar345 * mv2.Scalar34 - mv2.Scalar25 * mv1.Scalar345 * mv2.Scalar25 + mv2.Scalar35 * mv1.Scalar345 * mv2.Scalar35 - 2 * mv2.Scalar25 * mv1.Scalar235 * mv2.Scalar45 - mv2.Scalar45 * mv1.Scalar345 * mv2.Scalar45
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector3 MapUsingRotor(this Ga401KVector3 mv1, Ga401KVector4 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector3.Zero;
        
        return new Ga401KVector3
        {
            Scalar123 = 2 * mv2.Scalar1234 * mv1.Scalar235 * mv2.Scalar2345 - 2 * mv2.Scalar1235 * mv1.Scalar234 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.Scalar123 * mv2.Scalar2345,
            Scalar124 = 2 * mv2.Scalar1234 * mv1.Scalar245 * mv2.Scalar2345 - 2 * mv2.Scalar1245 * mv1.Scalar234 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.Scalar124 * mv2.Scalar2345,
            Scalar134 = 2 * mv2.Scalar1234 * mv1.Scalar345 * mv2.Scalar2345 - 2 * mv2.Scalar1345 * mv1.Scalar234 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.Scalar134 * mv2.Scalar2345,
            Scalar234 = -mv2.Scalar2345 * mv1.Scalar234 * mv2.Scalar2345,
            Scalar125 = 2 * mv2.Scalar1235 * mv1.Scalar245 * mv2.Scalar2345 - 2 * mv2.Scalar1245 * mv1.Scalar235 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.Scalar125 * mv2.Scalar2345,
            Scalar135 = 2 * mv2.Scalar1235 * mv1.Scalar345 * mv2.Scalar2345 - 2 * mv2.Scalar1345 * mv1.Scalar235 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.Scalar135 * mv2.Scalar2345,
            Scalar235 = -mv2.Scalar2345 * mv1.Scalar235 * mv2.Scalar2345,
            Scalar145 = 2 * mv2.Scalar1245 * mv1.Scalar345 * mv2.Scalar2345 - 2 * mv2.Scalar1345 * mv1.Scalar245 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.Scalar145 * mv2.Scalar2345,
            Scalar245 = -mv2.Scalar2345 * mv1.Scalar245 * mv2.Scalar2345,
            Scalar345 = -mv2.Scalar2345 * mv1.Scalar345 * mv2.Scalar2345
        };
    }
    
    public static Ga401KVector3 MapUsingRotor(this Ga401KVector3 mv1, Ga401Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector3.Zero;
        
        var tempScalar0 = 0d;
        var tempScalar1 = 0d;
        var tempScalar2 = 0d;
        var tempScalar3 = 0d;
        var tempScalar4 = 0d;
        var tempScalar5 = 0d;
        var tempScalar6 = 0d;
        var tempScalar7 = 0d;
        var tempScalar8 = 0d;
        var tempScalar9 = 0d;
        
        if (!mv2.KVector0.IsZero())
        {
            tempScalar0 += mv2.KVector0.Scalar * mv1.Scalar123 * mv2.KVector0.Scalar;
            tempScalar1 += mv2.KVector0.Scalar * mv1.Scalar124 * mv2.KVector0.Scalar;
            tempScalar2 += mv2.KVector0.Scalar * mv1.Scalar134 * mv2.KVector0.Scalar;
            tempScalar3 += mv2.KVector0.Scalar * mv1.Scalar234 * mv2.KVector0.Scalar;
            tempScalar4 += mv2.KVector0.Scalar * mv1.Scalar125 * mv2.KVector0.Scalar;
            tempScalar5 += mv2.KVector0.Scalar * mv1.Scalar135 * mv2.KVector0.Scalar;
            tempScalar6 += mv2.KVector0.Scalar * mv1.Scalar235 * mv2.KVector0.Scalar;
            tempScalar7 += mv2.KVector0.Scalar * mv1.Scalar145 * mv2.KVector0.Scalar;
            tempScalar8 += mv2.KVector0.Scalar * mv1.Scalar245 * mv2.KVector0.Scalar;
            tempScalar9 += mv2.KVector0.Scalar * mv1.Scalar345 * mv2.KVector0.Scalar;
        }
        
        if (!mv2.KVector0.IsZero() && !mv2.KVector2.IsZero())
        {
            tempScalar0 += 2 * mv2.KVector0.Scalar * mv1.Scalar124 * mv2.KVector2.Scalar34 - 2 * mv2.KVector0.Scalar * mv1.Scalar134 * mv2.KVector2.Scalar24 + 2 * mv2.KVector0.Scalar * mv1.Scalar234 * mv2.KVector2.Scalar14 + 2 * mv2.KVector0.Scalar * mv1.Scalar125 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.Scalar135 * mv2.KVector2.Scalar25 + 2 * mv2.KVector0.Scalar * mv1.Scalar235 * mv2.KVector2.Scalar15;
            tempScalar1 += -2 * mv2.KVector0.Scalar * mv1.Scalar123 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.Scalar134 * mv2.KVector2.Scalar23 - 2 * mv2.KVector0.Scalar * mv1.Scalar234 * mv2.KVector2.Scalar13 + 2 * mv2.KVector0.Scalar * mv1.Scalar125 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.Scalar145 * mv2.KVector2.Scalar25 + 2 * mv2.KVector0.Scalar * mv1.Scalar245 * mv2.KVector2.Scalar15;
            tempScalar2 += 2 * mv2.KVector0.Scalar * mv1.Scalar123 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.Scalar124 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.Scalar234 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.Scalar135 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.Scalar145 * mv2.KVector2.Scalar35 + 2 * mv2.KVector0.Scalar * mv1.Scalar345 * mv2.KVector2.Scalar15;
            tempScalar3 += 2 * mv2.KVector0.Scalar * mv1.Scalar235 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.Scalar245 * mv2.KVector2.Scalar35 + 2 * mv2.KVector0.Scalar * mv1.Scalar345 * mv2.KVector2.Scalar25;
            tempScalar4 += -2 * mv2.KVector0.Scalar * mv1.Scalar123 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.Scalar124 * mv2.KVector2.Scalar45 + 2 * mv2.KVector0.Scalar * mv1.Scalar135 * mv2.KVector2.Scalar23 - 2 * mv2.KVector0.Scalar * mv1.Scalar235 * mv2.KVector2.Scalar13 + 2 * mv2.KVector0.Scalar * mv1.Scalar145 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.Scalar245 * mv2.KVector2.Scalar14;
            tempScalar5 += 2 * mv2.KVector0.Scalar * mv1.Scalar123 * mv2.KVector2.Scalar25 - 2 * mv2.KVector0.Scalar * mv1.Scalar134 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.Scalar125 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.Scalar235 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.Scalar145 * mv2.KVector2.Scalar34 - 2 * mv2.KVector0.Scalar * mv1.Scalar345 * mv2.KVector2.Scalar14;
            tempScalar6 += -2 * mv2.KVector0.Scalar * mv1.Scalar234 * mv2.KVector2.Scalar45 + 2 * mv2.KVector0.Scalar * mv1.Scalar245 * mv2.KVector2.Scalar34 - 2 * mv2.KVector0.Scalar * mv1.Scalar345 * mv2.KVector2.Scalar24;
            tempScalar7 += 2 * mv2.KVector0.Scalar * mv1.Scalar124 * mv2.KVector2.Scalar25 + 2 * mv2.KVector0.Scalar * mv1.Scalar134 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.Scalar125 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.Scalar135 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.Scalar245 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.Scalar345 * mv2.KVector2.Scalar13;
            tempScalar8 += 2 * mv2.KVector0.Scalar * mv1.Scalar234 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.Scalar235 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.Scalar345 * mv2.KVector2.Scalar23;
            tempScalar9 += -2 * mv2.KVector0.Scalar * mv1.Scalar234 * mv2.KVector2.Scalar25 + 2 * mv2.KVector0.Scalar * mv1.Scalar235 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.Scalar245 * mv2.KVector2.Scalar23;
        }
        
        if (!mv2.KVector0.IsZero() && !mv2.KVector4.IsZero())
        {
            tempScalar0 += -2 * mv2.KVector0.Scalar * mv1.Scalar145 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector0.Scalar * mv1.Scalar245 * mv2.KVector4.Scalar1345 - 2 * mv2.KVector0.Scalar * mv1.Scalar345 * mv2.KVector4.Scalar1245;
            tempScalar1 += 2 * mv2.KVector0.Scalar * mv1.Scalar135 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector0.Scalar * mv1.Scalar235 * mv2.KVector4.Scalar1345 + 2 * mv2.KVector0.Scalar * mv1.Scalar345 * mv2.KVector4.Scalar1235;
            tempScalar2 += -2 * mv2.KVector0.Scalar * mv1.Scalar125 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector0.Scalar * mv1.Scalar235 * mv2.KVector4.Scalar1245 - 2 * mv2.KVector0.Scalar * mv1.Scalar245 * mv2.KVector4.Scalar1235;
            tempScalar4 += -2 * mv2.KVector0.Scalar * mv1.Scalar134 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector0.Scalar * mv1.Scalar234 * mv2.KVector4.Scalar1345 - 2 * mv2.KVector0.Scalar * mv1.Scalar345 * mv2.KVector4.Scalar1234;
            tempScalar5 += 2 * mv2.KVector0.Scalar * mv1.Scalar124 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector0.Scalar * mv1.Scalar234 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector0.Scalar * mv1.Scalar245 * mv2.KVector4.Scalar1234;
            tempScalar7 += -2 * mv2.KVector0.Scalar * mv1.Scalar123 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector0.Scalar * mv1.Scalar234 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector0.Scalar * mv1.Scalar235 * mv2.KVector4.Scalar1234;
        }
        
        if (!mv2.KVector2.IsZero())
        {
            tempScalar0 += -2 * mv2.KVector2.Scalar12 * mv1.Scalar234 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar12 * mv1.Scalar235 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar13 * mv1.Scalar234 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar13 * mv1.Scalar235 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar13 * mv1.Scalar245 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar23 * mv1.Scalar123 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.Scalar123 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar124 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar125 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar14 * mv1.Scalar235 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar14 * mv1.Scalar245 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar35 * mv1.Scalar123 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar34 * mv1.Scalar123 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar25 * mv1.Scalar123 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar35 * mv1.Scalar124 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar34 * mv1.Scalar125 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar34 * mv1.Scalar245 * mv2.KVector2.Scalar15 + 2 * mv2.KVector2.Scalar15 * mv1.Scalar234 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar45 * mv1.Scalar123 * mv2.KVector2.Scalar45;
            tempScalar1 += -2 * mv2.KVector2.Scalar12 * mv1.Scalar245 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar12 * mv1.Scalar345 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar13 * mv1.Scalar245 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar13 * mv1.Scalar345 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar23 * mv1.Scalar124 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar135 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar345 * mv2.KVector2.Scalar15 + 2 * mv2.KVector2.Scalar14 * mv1.Scalar245 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar24 * mv1.Scalar124 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar34 * mv1.Scalar124 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar25 * mv1.Scalar124 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar24 * mv1.Scalar134 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar25 * mv1.Scalar134 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar24 * mv1.Scalar125 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar24 * mv1.Scalar135 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.Scalar124 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar34 * mv1.Scalar125 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.Scalar135 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar35 * mv1.Scalar124 * mv2.KVector2.Scalar35;
            tempScalar2 += 2 * mv2.KVector2.Scalar12 * mv1.Scalar235 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar12 * mv1.Scalar345 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar13 * mv1.Scalar234 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar13 * mv1.Scalar345 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar123 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar25 * mv1.Scalar123 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar23 * mv1.Scalar134 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar34 * mv1.Scalar134 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar14 * mv1.Scalar234 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar14 * mv1.Scalar235 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar14 * mv1.Scalar345 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar24 * mv1.Scalar134 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar15 * mv1.Scalar234 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar24 * mv1.Scalar135 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar24 * mv1.Scalar235 * mv2.KVector2.Scalar15 + mv2.KVector2.Scalar25 * mv1.Scalar134 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar35 * mv1.Scalar134 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.Scalar135 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.Scalar134 * mv2.KVector2.Scalar45;
            tempScalar3 += -mv2.KVector2.Scalar23 * mv1.Scalar234 * mv2.KVector2.Scalar23 + mv2.KVector2.Scalar45 * mv1.Scalar234 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar345 * mv2.KVector2.Scalar35 - mv2.KVector2.Scalar34 * mv1.Scalar234 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar24 * mv1.Scalar234 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar24 * mv1.Scalar235 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar24 * mv1.Scalar345 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar25 * mv1.Scalar234 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar34 * mv1.Scalar235 * mv2.KVector2.Scalar35 - mv2.KVector2.Scalar35 * mv1.Scalar234 * mv2.KVector2.Scalar35;
            tempScalar4 += -2 * mv2.KVector2.Scalar13 * mv1.Scalar234 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar23 * mv1.Scalar125 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar25 * mv1.Scalar125 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar145 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar25 * mv1.Scalar145 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar14 * mv1.Scalar234 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar24 * mv1.Scalar125 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.Scalar125 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar24 * mv1.Scalar135 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar34 * mv1.Scalar234 * mv2.KVector2.Scalar15 - mv2.KVector2.Scalar35 * mv1.Scalar125 * mv2.KVector2.Scalar35 - mv2.KVector2.Scalar45 * mv1.Scalar125 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar25 * mv1.Scalar135 * mv2.KVector2.Scalar35;
            tempScalar5 += 2 * mv2.KVector2.Scalar12 * mv1.Scalar245 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar13 * mv1.Scalar235 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar13 * mv1.Scalar245 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar123 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar124 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar45 * mv1.Scalar135 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar23 * mv1.Scalar135 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.Scalar135 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar35 * mv1.Scalar135 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar14 * mv1.Scalar235 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar145 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar35 * mv1.Scalar145 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar245 * mv2.KVector2.Scalar14 - 2 * mv2.KVector2.Scalar24 * mv1.Scalar123 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar24 * mv1.Scalar124 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar34 * mv1.Scalar124 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar34 * mv1.Scalar135 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar15 * mv1.Scalar235 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar25 * mv1.Scalar135 * mv2.KVector2.Scalar25;
            tempScalar6 += -mv2.KVector2.Scalar23 * mv1.Scalar235 * mv2.KVector2.Scalar23 + mv2.KVector2.Scalar25 * mv1.Scalar235 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar45 * mv1.Scalar235 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar24 * mv1.Scalar235 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar245 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.Scalar235 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar35 * mv1.Scalar235 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar35 * mv1.Scalar245 * mv2.KVector2.Scalar45;
            tempScalar7 += 2 * mv2.KVector2.Scalar12 * mv1.Scalar234 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar12 * mv1.Scalar345 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar13 * mv1.Scalar234 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar13 * mv1.Scalar245 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar124 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar134 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar234 * mv2.KVector2.Scalar15 + mv2.KVector2.Scalar23 * mv1.Scalar145 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar15 * mv1.Scalar245 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar14 * mv1.Scalar345 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar14 * mv1.Scalar245 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar24 * mv1.Scalar124 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar24 * mv1.Scalar145 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar35 * mv1.Scalar145 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar15 * mv1.Scalar345 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.Scalar134 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar34 * mv1.Scalar145 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar25 * mv1.Scalar145 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar45 * mv1.Scalar145 * mv2.KVector2.Scalar45;
            tempScalar8 += -mv2.KVector2.Scalar24 * mv1.Scalar245 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar45 * mv1.Scalar245 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar24 * mv1.Scalar345 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar35 * mv1.Scalar245 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar234 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar23 * mv1.Scalar245 * mv2.KVector2.Scalar23 + mv2.KVector2.Scalar25 * mv1.Scalar245 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar34 * mv1.Scalar245 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar34 * mv1.Scalar234 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar25 * mv1.Scalar345 * mv2.KVector2.Scalar35;
            tempScalar9 += mv2.KVector2.Scalar24 * mv1.Scalar345 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar235 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar23 * mv1.Scalar345 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar34 * mv1.Scalar345 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar25 * mv1.Scalar345 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar35 * mv1.Scalar345 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar25 * mv1.Scalar235 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar45 * mv1.Scalar345 * mv2.KVector2.Scalar45;
        }
        
        if (!mv2.KVector2.IsZero() && !mv2.KVector4.IsZero())
        {
            tempScalar0 += -2 * mv2.KVector2.Scalar12 * mv1.Scalar245 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar34 * mv1.Scalar345 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar24 * mv1.Scalar235 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar35 * mv1.Scalar234 * mv2.KVector4.Scalar1345 + 2 * mv2.KVector2.Scalar34 * mv1.Scalar135 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar25 * mv1.Scalar124 * mv2.KVector4.Scalar2345;
            tempScalar1 += 2 * mv2.KVector2.Scalar45 * mv1.Scalar234 * mv2.KVector4.Scalar1345 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar235 * mv2.KVector4.Scalar1245 - 2 * mv2.KVector2.Scalar25 * mv1.Scalar234 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar34 * mv1.Scalar245 * mv2.KVector4.Scalar1345;
            tempScalar2 += 2 * mv2.KVector2.Scalar45 * mv1.Scalar124 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar135 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar345 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar14 * mv1.Scalar245 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar35 * mv1.Scalar234 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar24 * mv1.Scalar245 * mv2.KVector4.Scalar1345;
            tempScalar3 += 2 * mv2.KVector2.Scalar24 * mv1.Scalar245 * mv2.KVector4.Scalar2345;
            tempScalar4 += -2 * mv2.KVector2.Scalar12 * mv1.Scalar234 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar124 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar23 * mv1.Scalar245 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector2.Scalar24 * mv1.Scalar234 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar45 * mv1.Scalar135 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar35 * mv1.Scalar245 * mv2.KVector4.Scalar1345;
            tempScalar5 += -2 * mv2.KVector2.Scalar13 * mv1.Scalar234 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar234 * mv2.KVector4.Scalar1345 - 2 * mv2.KVector2.Scalar45 * mv1.Scalar235 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar34 * mv1.Scalar234 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar15 * mv1.Scalar245 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar25 * mv1.Scalar245 * mv2.KVector4.Scalar1345;
            tempScalar6 += -2 * mv2.KVector2.Scalar23 * mv1.Scalar234 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar25 * mv1.Scalar245 * mv2.KVector4.Scalar2345;
            tempScalar7 += -2 * mv2.KVector2.Scalar34 * mv1.Scalar245 * mv2.KVector4.Scalar1234 - 2 * mv2.KVector2.Scalar14 * mv1.Scalar234 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar24 * mv1.Scalar234 * mv2.KVector4.Scalar1345 - 2 * mv2.KVector2.Scalar34 * mv1.Scalar124 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar25 * mv1.Scalar135 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar25 * mv1.Scalar345 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar35 * mv1.Scalar235 * mv2.KVector4.Scalar1245;
            tempScalar8 += -2 * mv2.KVector2.Scalar24 * mv1.Scalar234 * mv2.KVector4.Scalar2345;
            tempScalar9 += -2 * mv2.KVector2.Scalar34 * mv1.Scalar234 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar45 * mv1.Scalar245 * mv2.KVector4.Scalar2345;
        }
        
        if (!mv2.KVector4.IsZero() && !mv2.KVector2.IsZero())
        {
            tempScalar0 += -2 * mv2.KVector4.Scalar1234 * mv1.Scalar245 * mv2.KVector2.Scalar25;
            tempScalar2 += 2 * mv2.KVector4.Scalar1234 * mv1.Scalar245 * mv2.KVector2.Scalar45;
            tempScalar4 += -2 * mv2.KVector4.Scalar1235 * mv1.Scalar345 * mv2.KVector2.Scalar45;
        }
        
        if (!mv2.KVector4.IsZero())
        {
            tempScalar0 += 2 * mv2.KVector4.Scalar1234 * mv1.Scalar235 * mv2.KVector4.Scalar2345 + mv2.KVector4.Scalar2345 * mv1.Scalar123 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector4.Scalar1235 * mv1.Scalar234 * mv2.KVector4.Scalar2345;
            tempScalar1 += -2 * mv2.KVector4.Scalar1245 * mv1.Scalar234 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1234 * mv1.Scalar245 * mv2.KVector4.Scalar2345 + mv2.KVector4.Scalar2345 * mv1.Scalar124 * mv2.KVector4.Scalar2345;
            tempScalar2 += mv2.KVector4.Scalar2345 * mv1.Scalar134 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1234 * mv1.Scalar345 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector4.Scalar1345 * mv1.Scalar234 * mv2.KVector4.Scalar2345;
            tempScalar3 += -mv2.KVector4.Scalar2345 * mv1.Scalar234 * mv2.KVector4.Scalar2345;
            tempScalar4 += mv2.KVector4.Scalar2345 * mv1.Scalar125 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector4.Scalar1245 * mv1.Scalar235 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1235 * mv1.Scalar245 * mv2.KVector4.Scalar2345;
            tempScalar5 += -2 * mv2.KVector4.Scalar1345 * mv1.Scalar235 * mv2.KVector4.Scalar2345 + mv2.KVector4.Scalar2345 * mv1.Scalar135 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1235 * mv1.Scalar345 * mv2.KVector4.Scalar2345;
            tempScalar6 += -mv2.KVector4.Scalar2345 * mv1.Scalar235 * mv2.KVector4.Scalar2345;
            tempScalar7 += -2 * mv2.KVector4.Scalar1345 * mv1.Scalar245 * mv2.KVector4.Scalar2345 + mv2.KVector4.Scalar2345 * mv1.Scalar145 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1245 * mv1.Scalar345 * mv2.KVector4.Scalar2345;
            tempScalar8 += -mv2.KVector4.Scalar2345 * mv1.Scalar245 * mv2.KVector4.Scalar2345;
            tempScalar9 += -mv2.KVector4.Scalar2345 * mv1.Scalar345 * mv2.KVector4.Scalar2345;
        }
        
        return new Ga401KVector3
        {
            Scalar123 = tempScalar0,
            Scalar124 = tempScalar1,
            Scalar134 = tempScalar2,
            Scalar234 = tempScalar3,
            Scalar125 = tempScalar4,
            Scalar135 = tempScalar5,
            Scalar235 = tempScalar6,
            Scalar145 = tempScalar7,
            Scalar245 = tempScalar8,
            Scalar345 = tempScalar9
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector4 MapUsingRotor(this Ga401KVector4 mv1, Ga401KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector4.Zero;
        
        return new Ga401KVector4
        {
            Scalar1234 = mv2.Scalar * mv1.Scalar1234 * mv2.Scalar,
            Scalar1235 = mv2.Scalar * mv1.Scalar1235 * mv2.Scalar,
            Scalar1245 = mv2.Scalar * mv1.Scalar1245 * mv2.Scalar,
            Scalar1345 = mv2.Scalar * mv1.Scalar1345 * mv2.Scalar,
            Scalar2345 = mv2.Scalar * mv1.Scalar2345 * mv2.Scalar
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector4 MapUsingRotor(this Ga401KVector4 mv1, Ga401KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector4.Zero;
        
        return new Ga401KVector4
        {
            Scalar1234 = -mv2.Scalar23 * mv1.Scalar1234 * mv2.Scalar23 - 2 * mv2.Scalar23 * mv1.Scalar1345 * mv2.Scalar35 + mv2.Scalar24 * mv1.Scalar1234 * mv2.Scalar24 + mv2.Scalar25 * mv1.Scalar1234 * mv2.Scalar25 + mv2.Scalar45 * mv1.Scalar1234 * mv2.Scalar45 + 2 * mv2.Scalar24 * mv1.Scalar1235 * mv2.Scalar25 + 2 * mv2.Scalar24 * mv1.Scalar1345 * mv2.Scalar45 - mv2.Scalar34 * mv1.Scalar1234 * mv2.Scalar34 - mv2.Scalar35 * mv1.Scalar1234 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.Scalar1235 * mv2.Scalar35,
            Scalar1235 = -2 * mv2.Scalar12 * mv1.Scalar2345 * mv2.Scalar24 + 2 * mv2.Scalar13 * mv1.Scalar2345 * mv2.Scalar34 - mv2.Scalar35 * mv1.Scalar1235 * mv2.Scalar35 - mv2.Scalar23 * mv1.Scalar1235 * mv2.Scalar23 - mv2.Scalar24 * mv1.Scalar1235 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar1245 * mv2.Scalar24 + mv2.Scalar34 * mv1.Scalar1235 * mv2.Scalar34 - 2 * mv2.Scalar15 * mv1.Scalar2345 * mv2.Scalar45 + mv2.Scalar25 * mv1.Scalar1235 * mv2.Scalar25 - mv2.Scalar45 * mv1.Scalar1235 * mv2.Scalar45 - 2 * mv2.Scalar35 * mv1.Scalar1245 * mv2.Scalar45,
            Scalar1245 = 2 * mv2.Scalar23 * mv1.Scalar1234 * mv2.Scalar25 + mv2.Scalar23 * mv1.Scalar1245 * mv2.Scalar23 + mv2.Scalar25 * mv1.Scalar1245 * mv2.Scalar25 - mv2.Scalar24 * mv1.Scalar1245 * mv2.Scalar24 - mv2.Scalar34 * mv1.Scalar1245 * mv2.Scalar34 - 2 * mv2.Scalar24 * mv1.Scalar1345 * mv2.Scalar34 - 2 * mv2.Scalar34 * mv1.Scalar1234 * mv2.Scalar45 - mv2.Scalar45 * mv1.Scalar1245 * mv2.Scalar45 + mv2.Scalar35 * mv1.Scalar1245 * mv2.Scalar35 + 2 * mv2.Scalar25 * mv1.Scalar1345 * mv2.Scalar35,
            Scalar1345 = -2 * mv2.Scalar13 * mv1.Scalar2345 * mv2.Scalar23 - 2 * mv2.Scalar23 * mv1.Scalar1235 * mv2.Scalar34 - mv2.Scalar23 * mv1.Scalar1345 * mv2.Scalar23 - mv2.Scalar34 * mv1.Scalar1345 * mv2.Scalar34 + 2 * mv2.Scalar14 * mv1.Scalar2345 * mv2.Scalar24 + mv2.Scalar24 * mv1.Scalar1345 * mv2.Scalar24 - 2 * mv2.Scalar15 * mv1.Scalar2345 * mv2.Scalar25 - 2 * mv2.Scalar25 * mv1.Scalar1235 * mv2.Scalar45 - mv2.Scalar25 * mv1.Scalar1345 * mv2.Scalar25 - mv2.Scalar45 * mv1.Scalar1345 * mv2.Scalar45 + mv2.Scalar35 * mv1.Scalar1345 * mv2.Scalar35,
            Scalar2345 = -mv2.Scalar23 * mv1.Scalar2345 * mv2.Scalar23 - mv2.Scalar25 * mv1.Scalar2345 * mv2.Scalar25 - mv2.Scalar34 * mv1.Scalar2345 * mv2.Scalar34 - mv2.Scalar45 * mv1.Scalar2345 * mv2.Scalar45 + mv2.Scalar24 * mv1.Scalar2345 * mv2.Scalar24 + mv2.Scalar35 * mv1.Scalar2345 * mv2.Scalar35
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector4 MapUsingRotor(this Ga401KVector4 mv1, Ga401KVector4 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector4.Zero;
        
        return new Ga401KVector4
        {
            Scalar1234 = 2 * mv2.Scalar1234 * mv1.Scalar2345 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.Scalar1234 * mv2.Scalar2345,
            Scalar1235 = 2 * mv2.Scalar1235 * mv1.Scalar2345 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.Scalar1235 * mv2.Scalar2345,
            Scalar1245 = 2 * mv2.Scalar1245 * mv1.Scalar2345 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.Scalar1245 * mv2.Scalar2345,
            Scalar1345 = 2 * mv2.Scalar1345 * mv1.Scalar2345 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.Scalar1345 * mv2.Scalar2345,
            Scalar2345 = mv2.Scalar2345 * mv1.Scalar2345 * mv2.Scalar2345
        };
    }
    
    public static Ga401KVector4 MapUsingRotor(this Ga401KVector4 mv1, Ga401Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector4.Zero;
        
        var tempScalar0 = 0d;
        var tempScalar1 = 0d;
        var tempScalar2 = 0d;
        var tempScalar3 = 0d;
        var tempScalar4 = 0d;
        
        if (!mv2.KVector0.IsZero())
        {
            tempScalar0 += mv2.KVector0.Scalar * mv1.Scalar1234 * mv2.KVector0.Scalar;
            tempScalar1 += mv2.KVector0.Scalar * mv1.Scalar1235 * mv2.KVector0.Scalar;
            tempScalar2 += mv2.KVector0.Scalar * mv1.Scalar1245 * mv2.KVector0.Scalar;
            tempScalar3 += mv2.KVector0.Scalar * mv1.Scalar1345 * mv2.KVector0.Scalar;
            tempScalar4 += mv2.KVector0.Scalar * mv1.Scalar2345 * mv2.KVector0.Scalar;
        }
        
        if (!mv2.KVector0.IsZero() && !mv2.KVector2.IsZero())
        {
            tempScalar0 += 2 * mv2.KVector0.Scalar * mv1.Scalar1235 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.Scalar1245 * mv2.KVector2.Scalar35 + 2 * mv2.KVector0.Scalar * mv1.Scalar1345 * mv2.KVector2.Scalar25 - 2 * mv2.KVector0.Scalar * mv1.Scalar2345 * mv2.KVector2.Scalar15;
            tempScalar1 += -2 * mv2.KVector0.Scalar * mv1.Scalar1234 * mv2.KVector2.Scalar45 + 2 * mv2.KVector0.Scalar * mv1.Scalar1245 * mv2.KVector2.Scalar34 - 2 * mv2.KVector0.Scalar * mv1.Scalar1345 * mv2.KVector2.Scalar24 + 2 * mv2.KVector0.Scalar * mv1.Scalar2345 * mv2.KVector2.Scalar14;
            tempScalar2 += 2 * mv2.KVector0.Scalar * mv1.Scalar1234 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.Scalar1235 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.Scalar1345 * mv2.KVector2.Scalar23 - 2 * mv2.KVector0.Scalar * mv1.Scalar2345 * mv2.KVector2.Scalar13;
            tempScalar3 += -2 * mv2.KVector0.Scalar * mv1.Scalar1234 * mv2.KVector2.Scalar25 + 2 * mv2.KVector0.Scalar * mv1.Scalar1235 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.Scalar1245 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.Scalar2345 * mv2.KVector2.Scalar12;
        }
        
        if (!mv2.KVector2.IsZero())
        {
            tempScalar0 += -mv2.KVector2.Scalar23 * mv1.Scalar1234 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar1345 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar24 * mv1.Scalar1234 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar25 * mv1.Scalar1234 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar45 * mv1.Scalar1234 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar24 * mv1.Scalar1235 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar24 * mv1.Scalar1345 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar34 * mv1.Scalar1234 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar35 * mv1.Scalar1234 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.Scalar1235 * mv2.KVector2.Scalar35;
            tempScalar1 += -2 * mv2.KVector2.Scalar12 * mv1.Scalar2345 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar13 * mv1.Scalar2345 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar35 * mv1.Scalar1235 * mv2.KVector2.Scalar35 - mv2.KVector2.Scalar23 * mv1.Scalar1235 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.Scalar1235 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar1245 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.Scalar1235 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar15 * mv1.Scalar2345 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar25 * mv1.Scalar1235 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar45 * mv1.Scalar1235 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar35 * mv1.Scalar1245 * mv2.KVector2.Scalar45;
            tempScalar2 += 2 * mv2.KVector2.Scalar23 * mv1.Scalar1234 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar23 * mv1.Scalar1245 * mv2.KVector2.Scalar23 + mv2.KVector2.Scalar25 * mv1.Scalar1245 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar24 * mv1.Scalar1245 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar34 * mv1.Scalar1245 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar24 * mv1.Scalar1345 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar34 * mv1.Scalar1234 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar45 * mv1.Scalar1245 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar35 * mv1.Scalar1245 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar25 * mv1.Scalar1345 * mv2.KVector2.Scalar35;
            tempScalar3 += -2 * mv2.KVector2.Scalar13 * mv1.Scalar2345 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar23 * mv1.Scalar1235 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar23 * mv1.Scalar1345 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar34 * mv1.Scalar1345 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar14 * mv1.Scalar2345 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar24 * mv1.Scalar1345 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar15 * mv1.Scalar2345 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar25 * mv1.Scalar1235 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar25 * mv1.Scalar1345 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar45 * mv1.Scalar1345 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar35 * mv1.Scalar1345 * mv2.KVector2.Scalar35;
            tempScalar4 += -mv2.KVector2.Scalar23 * mv1.Scalar2345 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar25 * mv1.Scalar2345 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar35 * mv1.Scalar2345 * mv2.KVector2.Scalar35 - mv2.KVector2.Scalar34 * mv1.Scalar2345 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar45 * mv1.Scalar2345 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar24 * mv1.Scalar2345 * mv2.KVector2.Scalar24;
        }
        
        if (!mv2.KVector2.IsZero() && !mv2.KVector4.IsZero())
        {
            tempScalar0 += -2 * mv2.KVector2.Scalar23 * mv1.Scalar2345 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar24 * mv1.Scalar1245 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar34 * mv1.Scalar2345 * mv2.KVector4.Scalar1345;
            tempScalar1 += -2 * mv2.KVector2.Scalar23 * mv1.Scalar1234 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar25 * mv1.Scalar1245 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar35 * mv1.Scalar2345 * mv2.KVector4.Scalar1345;
            tempScalar2 += -2 * mv2.KVector2.Scalar24 * mv1.Scalar1234 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar25 * mv1.Scalar2345 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar45 * mv1.Scalar2345 * mv2.KVector4.Scalar1345;
            tempScalar3 += 2 * mv2.KVector2.Scalar35 * mv1.Scalar2345 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar34 * mv1.Scalar1234 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar45 * mv1.Scalar1245 * mv2.KVector4.Scalar2345;
        }
        
        if (!mv2.KVector4.IsZero())
        {
            tempScalar0 += -mv2.KVector4.Scalar2345 * mv1.Scalar1234 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1234 * mv1.Scalar2345 * mv2.KVector4.Scalar2345;
            tempScalar1 += -mv2.KVector4.Scalar2345 * mv1.Scalar1235 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1235 * mv1.Scalar2345 * mv2.KVector4.Scalar2345;
            tempScalar2 += -mv2.KVector4.Scalar2345 * mv1.Scalar1245 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1245 * mv1.Scalar2345 * mv2.KVector4.Scalar2345;
            tempScalar3 += 2 * mv2.KVector4.Scalar1345 * mv1.Scalar2345 * mv2.KVector4.Scalar2345 - mv2.KVector4.Scalar2345 * mv1.Scalar1345 * mv2.KVector4.Scalar2345;
            tempScalar4 += mv2.KVector4.Scalar2345 * mv1.Scalar2345 * mv2.KVector4.Scalar2345;
        }
        
        return new Ga401KVector4
        {
            Scalar1234 = tempScalar0,
            Scalar1235 = tempScalar1,
            Scalar1245 = tempScalar2,
            Scalar1345 = tempScalar3,
            Scalar2345 = tempScalar4
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector5 MapUsingRotor(this Ga401KVector5 mv1, Ga401KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector5.Zero;
        
        return new Ga401KVector5
        {
            Scalar12345 = mv2.Scalar * mv1.Scalar12345 * mv2.Scalar
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector5 MapUsingRotor(this Ga401KVector5 mv1, Ga401KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector5.Zero;
        
        return new Ga401KVector5
        {
            Scalar12345 = -mv2.Scalar23 * mv1.Scalar12345 * mv2.Scalar23 + mv2.Scalar24 * mv1.Scalar12345 * mv2.Scalar24 - mv2.Scalar34 * mv1.Scalar12345 * mv2.Scalar34 - mv2.Scalar25 * mv1.Scalar12345 * mv2.Scalar25 + mv2.Scalar35 * mv1.Scalar12345 * mv2.Scalar35 - mv2.Scalar45 * mv1.Scalar12345 * mv2.Scalar45
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector5 MapUsingRotor(this Ga401KVector5 mv1, Ga401KVector4 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector5.Zero;
        
        return new Ga401KVector5
        {
            Scalar12345 = mv2.Scalar2345 * mv1.Scalar12345 * mv2.Scalar2345
        };
    }
    
    public static Ga401KVector5 MapUsingRotor(this Ga401KVector5 mv1, Ga401Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector5.Zero;
        
        var tempScalar = 0d;
        
        if (!mv2.KVector0.IsZero())
        {
            tempScalar += mv2.KVector0.Scalar * mv1.Scalar12345 * mv2.KVector0.Scalar;
        }
        
        if (!mv2.KVector2.IsZero())
        {
            tempScalar += -mv2.KVector2.Scalar23 * mv1.Scalar12345 * mv2.KVector2.Scalar23 + mv2.KVector2.Scalar24 * mv1.Scalar12345 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar34 * mv1.Scalar12345 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar25 * mv1.Scalar12345 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar35 * mv1.Scalar12345 * mv2.KVector2.Scalar35 - mv2.KVector2.Scalar45 * mv1.Scalar12345 * mv2.KVector2.Scalar45;
        }
        
        if (!mv2.KVector4.IsZero())
        {
            tempScalar += mv2.KVector4.Scalar2345 * mv1.Scalar12345 * mv2.KVector4.Scalar2345;
        }
        
        return new Ga401KVector5
        {
            Scalar12345 = tempScalar
        };
    }
    
    public static Ga401Multivector MapUsingRotor(this Ga401Multivector mv1, Ga401KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401Multivector.Zero;
        
        var tempScalar = new double[32];
        
        if (!mv1.KVector0.IsZero())
        {
            tempScalar[0] += mv2.Scalar * mv1.KVector0.Scalar * mv2.Scalar;
        }
        
        if (!mv1.KVector1.IsZero())
        {
            tempScalar[1] += mv2.Scalar * mv1.KVector1.Scalar1 * mv2.Scalar;
            tempScalar[2] += mv2.Scalar * mv1.KVector1.Scalar2 * mv2.Scalar;
            tempScalar[4] += mv2.Scalar * mv1.KVector1.Scalar3 * mv2.Scalar;
            tempScalar[8] += mv2.Scalar * mv1.KVector1.Scalar4 * mv2.Scalar;
            tempScalar[16] += mv2.Scalar * mv1.KVector1.Scalar5 * mv2.Scalar;
        }
        
        if (!mv1.KVector2.IsZero())
        {
            tempScalar[3] += mv2.Scalar * mv1.KVector2.Scalar12 * mv2.Scalar;
            tempScalar[5] += mv2.Scalar * mv1.KVector2.Scalar13 * mv2.Scalar;
            tempScalar[6] += mv2.Scalar * mv1.KVector2.Scalar23 * mv2.Scalar;
            tempScalar[9] += mv2.Scalar * mv1.KVector2.Scalar14 * mv2.Scalar;
            tempScalar[10] += mv2.Scalar * mv1.KVector2.Scalar24 * mv2.Scalar;
            tempScalar[12] += mv2.Scalar * mv1.KVector2.Scalar34 * mv2.Scalar;
            tempScalar[17] += mv2.Scalar * mv1.KVector2.Scalar15 * mv2.Scalar;
            tempScalar[18] += mv2.Scalar * mv1.KVector2.Scalar25 * mv2.Scalar;
            tempScalar[20] += mv2.Scalar * mv1.KVector2.Scalar35 * mv2.Scalar;
            tempScalar[24] += mv2.Scalar * mv1.KVector2.Scalar45 * mv2.Scalar;
        }
        
        if (!mv1.KVector3.IsZero())
        {
            tempScalar[7] += mv2.Scalar * mv1.KVector3.Scalar123 * mv2.Scalar;
            tempScalar[11] += mv2.Scalar * mv1.KVector3.Scalar124 * mv2.Scalar;
            tempScalar[13] += mv2.Scalar * mv1.KVector3.Scalar134 * mv2.Scalar;
            tempScalar[14] += mv2.Scalar * mv1.KVector3.Scalar234 * mv2.Scalar;
            tempScalar[19] += mv2.Scalar * mv1.KVector3.Scalar125 * mv2.Scalar;
            tempScalar[21] += mv2.Scalar * mv1.KVector3.Scalar135 * mv2.Scalar;
            tempScalar[22] += mv2.Scalar * mv1.KVector3.Scalar235 * mv2.Scalar;
            tempScalar[25] += mv2.Scalar * mv1.KVector3.Scalar145 * mv2.Scalar;
            tempScalar[26] += mv2.Scalar * mv1.KVector3.Scalar245 * mv2.Scalar;
            tempScalar[28] += mv2.Scalar * mv1.KVector3.Scalar345 * mv2.Scalar;
        }
        
        if (!mv1.KVector4.IsZero())
        {
            tempScalar[15] += mv2.Scalar * mv1.KVector4.Scalar1234 * mv2.Scalar;
            tempScalar[23] += mv2.Scalar * mv1.KVector4.Scalar1235 * mv2.Scalar;
            tempScalar[27] += mv2.Scalar * mv1.KVector4.Scalar1245 * mv2.Scalar;
            tempScalar[29] += mv2.Scalar * mv1.KVector4.Scalar1345 * mv2.Scalar;
            tempScalar[30] += mv2.Scalar * mv1.KVector4.Scalar2345 * mv2.Scalar;
        }
        
        if (!mv1.KVector5.IsZero())
        {
            tempScalar[31] += mv2.Scalar * mv1.KVector5.Scalar12345 * mv2.Scalar;
        }
        
        return Ga401Multivector.Create(tempScalar);
    }
    
    public static Ga401Multivector MapUsingRotor(this Ga401Multivector mv1, Ga401KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401Multivector.Zero;
        
        var tempScalar = new double[32];
        
        if (!mv1.KVector0.IsZero())
        {
            tempScalar[0] += mv2.Scalar23 * mv1.KVector0.Scalar * mv2.Scalar23 + mv2.Scalar45 * mv1.KVector0.Scalar * mv2.Scalar45 + mv2.Scalar24 * mv1.KVector0.Scalar * mv2.Scalar24 + mv2.Scalar34 * mv1.KVector0.Scalar * mv2.Scalar34 + mv2.Scalar25 * mv1.KVector0.Scalar * mv2.Scalar25 + mv2.Scalar35 * mv1.KVector0.Scalar * mv2.Scalar35;
        }
        
        if (!mv1.KVector1.IsZero())
        {
            tempScalar[1] += 2 * mv2.Scalar12 * mv1.KVector1.Scalar3 * mv2.Scalar23 + 2 * mv2.Scalar12 * mv1.KVector1.Scalar4 * mv2.Scalar24 + 2 * mv2.Scalar12 * mv1.KVector1.Scalar5 * mv2.Scalar25 + 2 * mv2.Scalar15 * mv1.KVector1.Scalar2 * mv2.Scalar25 + 2 * mv2.Scalar13 * mv1.KVector1.Scalar2 * mv2.Scalar23 + 2 * mv2.Scalar13 * mv1.KVector1.Scalar4 * mv2.Scalar34 + 2 * mv2.Scalar13 * mv1.KVector1.Scalar5 * mv2.Scalar35 + mv2.Scalar23 * mv1.KVector1.Scalar1 * mv2.Scalar23 + 2 * mv2.Scalar14 * mv1.KVector1.Scalar2 * mv2.Scalar24 + 2 * mv2.Scalar14 * mv1.KVector1.Scalar3 * mv2.Scalar34 + 2 * mv2.Scalar14 * mv1.KVector1.Scalar5 * mv2.Scalar45 + mv2.Scalar24 * mv1.KVector1.Scalar1 * mv2.Scalar24 + mv2.Scalar45 * mv1.KVector1.Scalar1 * mv2.Scalar45 + mv2.Scalar34 * mv1.KVector1.Scalar1 * mv2.Scalar34 + 2 * mv2.Scalar15 * mv1.KVector1.Scalar3 * mv2.Scalar35 + 2 * mv2.Scalar15 * mv1.KVector1.Scalar4 * mv2.Scalar45 + mv2.Scalar25 * mv1.KVector1.Scalar1 * mv2.Scalar25 + mv2.Scalar35 * mv1.KVector1.Scalar1 * mv2.Scalar35;
            tempScalar[2] += 2 * mv2.Scalar25 * mv1.KVector1.Scalar4 * mv2.Scalar45 + mv2.Scalar23 * mv1.KVector1.Scalar2 * mv2.Scalar23 + 2 * mv2.Scalar23 * mv1.KVector1.Scalar4 * mv2.Scalar34 + 2 * mv2.Scalar23 * mv1.KVector1.Scalar5 * mv2.Scalar35 + mv2.Scalar24 * mv1.KVector1.Scalar2 * mv2.Scalar24 + mv2.Scalar34 * mv1.KVector1.Scalar2 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.KVector1.Scalar3 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.KVector1.Scalar5 * mv2.Scalar45 + mv2.Scalar25 * mv1.KVector1.Scalar2 * mv2.Scalar25 + mv2.Scalar35 * mv1.KVector1.Scalar2 * mv2.Scalar35 + mv2.Scalar45 * mv1.KVector1.Scalar2 * mv2.Scalar45 + 2 * mv2.Scalar25 * mv1.KVector1.Scalar3 * mv2.Scalar35;
            tempScalar[4] += mv2.Scalar45 * mv1.KVector1.Scalar3 * mv2.Scalar45 + mv2.Scalar34 * mv1.KVector1.Scalar3 * mv2.Scalar34 + mv2.Scalar35 * mv1.KVector1.Scalar3 * mv2.Scalar35 - mv2.Scalar23 * mv1.KVector1.Scalar3 * mv2.Scalar23 - mv2.Scalar24 * mv1.KVector1.Scalar3 * mv2.Scalar24 - mv2.Scalar25 * mv1.KVector1.Scalar3 * mv2.Scalar25 - 2 * mv2.Scalar23 * mv1.KVector1.Scalar4 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.KVector1.Scalar5 * mv2.Scalar25 + 2 * mv2.Scalar34 * mv1.KVector1.Scalar5 * mv2.Scalar45 + 2 * mv2.Scalar35 * mv1.KVector1.Scalar4 * mv2.Scalar45;
            tempScalar[8] += mv2.Scalar23 * mv1.KVector1.Scalar4 * mv2.Scalar23 - mv2.Scalar24 * mv1.KVector1.Scalar4 * mv2.Scalar24 - mv2.Scalar25 * mv1.KVector1.Scalar4 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.KVector1.Scalar5 * mv2.Scalar25 + mv2.Scalar45 * mv1.KVector1.Scalar4 * mv2.Scalar45 - mv2.Scalar34 * mv1.KVector1.Scalar4 * mv2.Scalar34 - mv2.Scalar35 * mv1.KVector1.Scalar4 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector1.Scalar5 * mv2.Scalar35;
            tempScalar[16] += -mv2.Scalar45 * mv1.KVector1.Scalar5 * mv2.Scalar45 - mv2.Scalar35 * mv1.KVector1.Scalar5 * mv2.Scalar35 + mv2.Scalar23 * mv1.KVector1.Scalar5 * mv2.Scalar23 - mv2.Scalar25 * mv1.KVector1.Scalar5 * mv2.Scalar25 + mv2.Scalar24 * mv1.KVector1.Scalar5 * mv2.Scalar24 + mv2.Scalar34 * mv1.KVector1.Scalar5 * mv2.Scalar34;
        }
        
        if (!mv1.KVector2.IsZero())
        {
            tempScalar[3] += mv2.Scalar23 * mv1.KVector2.Scalar12 * mv2.Scalar23 + 2 * mv2.Scalar23 * mv1.KVector2.Scalar14 * mv2.Scalar34 + 2 * mv2.Scalar23 * mv1.KVector2.Scalar15 * mv2.Scalar35 + mv2.Scalar24 * mv1.KVector2.Scalar12 * mv2.Scalar24 + mv2.Scalar34 * mv1.KVector2.Scalar12 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.KVector2.Scalar13 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.KVector2.Scalar15 * mv2.Scalar45 + mv2.Scalar25 * mv1.KVector2.Scalar12 * mv2.Scalar25 + mv2.Scalar35 * mv1.KVector2.Scalar12 * mv2.Scalar35 + mv2.Scalar45 * mv1.KVector2.Scalar12 * mv2.Scalar45 + 2 * mv2.Scalar25 * mv1.KVector2.Scalar13 * mv2.Scalar35 + 2 * mv2.Scalar25 * mv1.KVector2.Scalar14 * mv2.Scalar45;
            tempScalar[5] += 2 * mv2.Scalar12 * mv1.KVector2.Scalar24 * mv2.Scalar34 + 2 * mv2.Scalar12 * mv1.KVector2.Scalar25 * mv2.Scalar35 - 2 * mv2.Scalar13 * mv1.KVector2.Scalar23 * mv2.Scalar23 - 2 * mv2.Scalar13 * mv1.KVector2.Scalar24 * mv2.Scalar24 - 2 * mv2.Scalar13 * mv1.KVector2.Scalar25 * mv2.Scalar25 - mv2.Scalar23 * mv1.KVector2.Scalar13 * mv2.Scalar23 - mv2.Scalar24 * mv1.KVector2.Scalar13 * mv2.Scalar24 - mv2.Scalar25 * mv1.KVector2.Scalar13 * mv2.Scalar25 - 2 * mv2.Scalar14 * mv1.KVector2.Scalar23 * mv2.Scalar24 - 2 * mv2.Scalar15 * mv1.KVector2.Scalar23 * mv2.Scalar25 - 2 * mv2.Scalar23 * mv1.KVector2.Scalar14 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.KVector2.Scalar24 * mv2.Scalar14 - 2 * mv2.Scalar23 * mv1.KVector2.Scalar15 * mv2.Scalar25 - 2 * mv2.Scalar23 * mv1.KVector2.Scalar25 * mv2.Scalar15 + mv2.Scalar34 * mv1.KVector2.Scalar13 * mv2.Scalar34 + 2 * mv2.Scalar34 * mv1.KVector2.Scalar15 * mv2.Scalar45 + mv2.Scalar35 * mv1.KVector2.Scalar13 * mv2.Scalar35 + mv2.Scalar45 * mv1.KVector2.Scalar13 * mv2.Scalar45 + 2 * mv2.Scalar35 * mv1.KVector2.Scalar14 * mv2.Scalar45;
            tempScalar[6] += -mv2.Scalar23 * mv1.KVector2.Scalar23 * mv2.Scalar23 - mv2.Scalar25 * mv1.KVector2.Scalar23 * mv2.Scalar25 + mv2.Scalar45 * mv1.KVector2.Scalar23 * mv2.Scalar45 - mv2.Scalar24 * mv1.KVector2.Scalar23 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.KVector2.Scalar24 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.KVector2.Scalar25 * mv2.Scalar25 + mv2.Scalar34 * mv1.KVector2.Scalar23 * mv2.Scalar34 + 2 * mv2.Scalar35 * mv1.KVector2.Scalar24 * mv2.Scalar45 + 2 * mv2.Scalar34 * mv1.KVector2.Scalar25 * mv2.Scalar45 + mv2.Scalar35 * mv1.KVector2.Scalar23 * mv2.Scalar35;
            tempScalar[9] += 2 * mv2.Scalar12 * mv1.KVector2.Scalar34 * mv2.Scalar23 + 2 * mv2.Scalar12 * mv1.KVector2.Scalar25 * mv2.Scalar45 + 2 * mv2.Scalar13 * mv1.KVector2.Scalar24 * mv2.Scalar23 - 2 * mv2.Scalar15 * mv1.KVector2.Scalar34 * mv2.Scalar35 + 2 * mv2.Scalar13 * mv1.KVector2.Scalar35 * mv2.Scalar45 + mv2.Scalar45 * mv1.KVector2.Scalar14 * mv2.Scalar45 + mv2.Scalar23 * mv1.KVector2.Scalar14 * mv2.Scalar23 - 2 * mv2.Scalar14 * mv1.KVector2.Scalar34 * mv2.Scalar34 - 2 * mv2.Scalar14 * mv1.KVector2.Scalar24 * mv2.Scalar24 - 2 * mv2.Scalar14 * mv1.KVector2.Scalar25 * mv2.Scalar25 - 2 * mv2.Scalar14 * mv1.KVector2.Scalar35 * mv2.Scalar35 - mv2.Scalar24 * mv1.KVector2.Scalar14 * mv2.Scalar24 - mv2.Scalar25 * mv1.KVector2.Scalar14 * mv2.Scalar25 - 2 * mv2.Scalar15 * mv1.KVector2.Scalar24 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.KVector2.Scalar15 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.KVector2.Scalar25 * mv2.Scalar15 - mv2.Scalar34 * mv1.KVector2.Scalar14 * mv2.Scalar34 - mv2.Scalar35 * mv1.KVector2.Scalar14 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector2.Scalar15 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector2.Scalar35 * mv2.Scalar15;
            tempScalar[10] += -mv2.Scalar24 * mv1.KVector2.Scalar24 * mv2.Scalar24 - 2 * mv2.Scalar24 * mv1.KVector2.Scalar34 * mv2.Scalar34 + mv2.Scalar23 * mv1.KVector2.Scalar24 * mv2.Scalar23 + 2 * mv2.Scalar23 * mv1.KVector2.Scalar35 * mv2.Scalar45 - mv2.Scalar35 * mv1.KVector2.Scalar24 * mv2.Scalar35 - mv2.Scalar34 * mv1.KVector2.Scalar24 * mv2.Scalar34 - mv2.Scalar25 * mv1.KVector2.Scalar24 * mv2.Scalar25 - 2 * mv2.Scalar25 * mv1.KVector2.Scalar34 * mv2.Scalar35 - 2 * mv2.Scalar24 * mv1.KVector2.Scalar25 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.KVector2.Scalar35 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector2.Scalar25 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector2.Scalar35 * mv2.Scalar25 + mv2.Scalar45 * mv1.KVector2.Scalar24 * mv2.Scalar45;
            tempScalar[12] += mv2.Scalar25 * mv1.KVector2.Scalar34 * mv2.Scalar25 + mv2.Scalar24 * mv1.KVector2.Scalar34 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.KVector2.Scalar23 * mv2.Scalar34 + 2 * mv2.Scalar25 * mv1.KVector2.Scalar23 * mv2.Scalar45 - mv2.Scalar23 * mv1.KVector2.Scalar34 * mv2.Scalar23 - mv2.Scalar34 * mv1.KVector2.Scalar34 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.KVector2.Scalar35 * mv2.Scalar25 - mv2.Scalar35 * mv1.KVector2.Scalar34 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector2.Scalar35 * mv2.Scalar35 + mv2.Scalar45 * mv1.KVector2.Scalar34 * mv2.Scalar45;
            tempScalar[17] += 2 * mv2.Scalar12 * mv1.KVector2.Scalar35 * mv2.Scalar23 + 2 * mv2.Scalar12 * mv1.KVector2.Scalar45 * mv2.Scalar24 + 2 * mv2.Scalar13 * mv1.KVector2.Scalar25 * mv2.Scalar23 + 2 * mv2.Scalar13 * mv1.KVector2.Scalar45 * mv2.Scalar34 - mv2.Scalar45 * mv1.KVector2.Scalar15 * mv2.Scalar45 + mv2.Scalar23 * mv1.KVector2.Scalar15 * mv2.Scalar23 - 2 * mv2.Scalar15 * mv1.KVector2.Scalar35 * mv2.Scalar35 + 2 * mv2.Scalar14 * mv1.KVector2.Scalar25 * mv2.Scalar24 + 2 * mv2.Scalar14 * mv1.KVector2.Scalar35 * mv2.Scalar34 + mv2.Scalar24 * mv1.KVector2.Scalar15 * mv2.Scalar24 - mv2.Scalar35 * mv1.KVector2.Scalar15 * mv2.Scalar35 + mv2.Scalar34 * mv1.KVector2.Scalar15 * mv2.Scalar34 - 2 * mv2.Scalar15 * mv1.KVector2.Scalar45 * mv2.Scalar45 - 2 * mv2.Scalar15 * mv1.KVector2.Scalar25 * mv2.Scalar25 - mv2.Scalar25 * mv1.KVector2.Scalar15 * mv2.Scalar25;
            tempScalar[18] += -mv2.Scalar35 * mv1.KVector2.Scalar25 * mv2.Scalar35 - 2 * mv2.Scalar25 * mv1.KVector2.Scalar35 * mv2.Scalar35 + mv2.Scalar23 * mv1.KVector2.Scalar25 * mv2.Scalar23 - mv2.Scalar25 * mv1.KVector2.Scalar25 * mv2.Scalar25 + 2 * mv2.Scalar23 * mv1.KVector2.Scalar45 * mv2.Scalar34 - 2 * mv2.Scalar25 * mv1.KVector2.Scalar45 * mv2.Scalar45 + mv2.Scalar24 * mv1.KVector2.Scalar25 * mv2.Scalar24 + mv2.Scalar34 * mv1.KVector2.Scalar25 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.KVector2.Scalar35 * mv2.Scalar34 - mv2.Scalar45 * mv1.KVector2.Scalar25 * mv2.Scalar45;
            tempScalar[20] += 2 * mv2.Scalar34 * mv1.KVector2.Scalar24 * mv2.Scalar25 + mv2.Scalar25 * mv1.KVector2.Scalar35 * mv2.Scalar25 - mv2.Scalar45 * mv1.KVector2.Scalar35 * mv2.Scalar45 - 2 * mv2.Scalar23 * mv1.KVector2.Scalar23 * mv2.Scalar35 - 2 * mv2.Scalar23 * mv1.KVector2.Scalar24 * mv2.Scalar45 - mv2.Scalar23 * mv1.KVector2.Scalar35 * mv2.Scalar23 - mv2.Scalar24 * mv1.KVector2.Scalar35 * mv2.Scalar24 - mv2.Scalar35 * mv1.KVector2.Scalar35 * mv2.Scalar35 - 2 * mv2.Scalar23 * mv1.KVector2.Scalar45 * mv2.Scalar24 - 2 * mv2.Scalar35 * mv1.KVector2.Scalar45 * mv2.Scalar45 - 2 * mv2.Scalar24 * mv1.KVector2.Scalar23 * mv2.Scalar45 - 2 * mv2.Scalar24 * mv1.KVector2.Scalar24 * mv2.Scalar35 + mv2.Scalar34 * mv1.KVector2.Scalar35 * mv2.Scalar34;
            tempScalar[24] += 2 * mv2.Scalar23 * mv1.KVector2.Scalar24 * mv2.Scalar35 + 2 * mv2.Scalar23 * mv1.KVector2.Scalar34 * mv2.Scalar25 + mv2.Scalar23 * mv1.KVector2.Scalar45 * mv2.Scalar23 - 2 * mv2.Scalar24 * mv1.KVector2.Scalar24 * mv2.Scalar45 - mv2.Scalar24 * mv1.KVector2.Scalar45 * mv2.Scalar24 + mv2.Scalar35 * mv1.KVector2.Scalar45 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector2.Scalar34 * mv2.Scalar45 - mv2.Scalar34 * mv1.KVector2.Scalar45 * mv2.Scalar34 + mv2.Scalar25 * mv1.KVector2.Scalar45 * mv2.Scalar25 - mv2.Scalar45 * mv1.KVector2.Scalar45 * mv2.Scalar45;
        }
        
        if (!mv1.KVector3.IsZero())
        {
            tempScalar[7] += mv2.Scalar45 * mv1.KVector3.Scalar123 * mv2.Scalar45 - 2 * mv2.Scalar12 * mv1.KVector3.Scalar234 * mv2.Scalar24 - 2 * mv2.Scalar12 * mv1.KVector3.Scalar235 * mv2.Scalar25 + 2 * mv2.Scalar13 * mv1.KVector3.Scalar234 * mv2.Scalar34 + 2 * mv2.Scalar13 * mv1.KVector3.Scalar235 * mv2.Scalar35 + 2 * mv2.Scalar34 * mv1.KVector3.Scalar245 * mv2.Scalar15 + 2 * mv2.Scalar13 * mv1.KVector3.Scalar245 * mv2.Scalar45 - mv2.Scalar23 * mv1.KVector3.Scalar123 * mv2.Scalar23 - mv2.Scalar24 * mv1.KVector3.Scalar123 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.KVector3.Scalar124 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.KVector3.Scalar125 * mv2.Scalar25 + 2 * mv2.Scalar14 * mv1.KVector3.Scalar235 * mv2.Scalar45 + 2 * mv2.Scalar14 * mv1.KVector3.Scalar245 * mv2.Scalar35 + mv2.Scalar35 * mv1.KVector3.Scalar123 * mv2.Scalar35 + mv2.Scalar34 * mv1.KVector3.Scalar123 * mv2.Scalar34 - mv2.Scalar25 * mv1.KVector3.Scalar123 * mv2.Scalar25 + 2 * mv2.Scalar35 * mv1.KVector3.Scalar124 * mv2.Scalar45 + 2 * mv2.Scalar34 * mv1.KVector3.Scalar125 * mv2.Scalar45 + 2 * mv2.Scalar15 * mv1.KVector3.Scalar234 * mv2.Scalar45;
            tempScalar[11] += mv2.Scalar45 * mv1.KVector3.Scalar124 * mv2.Scalar45 - 2 * mv2.Scalar12 * mv1.KVector3.Scalar245 * mv2.Scalar25 - 2 * mv2.Scalar12 * mv1.KVector3.Scalar345 * mv2.Scalar35 - 2 * mv2.Scalar13 * mv1.KVector3.Scalar245 * mv2.Scalar35 - 2 * mv2.Scalar13 * mv1.KVector3.Scalar345 * mv2.Scalar25 + mv2.Scalar23 * mv1.KVector3.Scalar124 * mv2.Scalar23 + 2 * mv2.Scalar23 * mv1.KVector3.Scalar135 * mv2.Scalar45 + 2 * mv2.Scalar23 * mv1.KVector3.Scalar345 * mv2.Scalar15 + 2 * mv2.Scalar14 * mv1.KVector3.Scalar245 * mv2.Scalar45 - mv2.Scalar24 * mv1.KVector3.Scalar124 * mv2.Scalar24 - mv2.Scalar34 * mv1.KVector3.Scalar124 * mv2.Scalar34 - mv2.Scalar25 * mv1.KVector3.Scalar124 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.KVector3.Scalar134 * mv2.Scalar34 - 2 * mv2.Scalar25 * mv1.KVector3.Scalar134 * mv2.Scalar35 - 2 * mv2.Scalar24 * mv1.KVector3.Scalar125 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.KVector3.Scalar135 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector3.Scalar125 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector3.Scalar135 * mv2.Scalar25 - mv2.Scalar35 * mv1.KVector3.Scalar124 * mv2.Scalar35;
            tempScalar[13] += 2 * mv2.Scalar12 * mv1.KVector3.Scalar235 * mv2.Scalar45 + 2 * mv2.Scalar12 * mv1.KVector3.Scalar345 * mv2.Scalar25 - 2 * mv2.Scalar13 * mv1.KVector3.Scalar234 * mv2.Scalar23 + 2 * mv2.Scalar24 * mv1.KVector3.Scalar235 * mv2.Scalar15 - 2 * mv2.Scalar13 * mv1.KVector3.Scalar345 * mv2.Scalar35 - 2 * mv2.Scalar23 * mv1.KVector3.Scalar123 * mv2.Scalar34 + 2 * mv2.Scalar25 * mv1.KVector3.Scalar123 * mv2.Scalar45 - mv2.Scalar23 * mv1.KVector3.Scalar134 * mv2.Scalar23 - mv2.Scalar34 * mv1.KVector3.Scalar134 * mv2.Scalar34 + 2 * mv2.Scalar14 * mv1.KVector3.Scalar234 * mv2.Scalar24 + 2 * mv2.Scalar14 * mv1.KVector3.Scalar235 * mv2.Scalar25 + 2 * mv2.Scalar14 * mv1.KVector3.Scalar345 * mv2.Scalar45 + mv2.Scalar24 * mv1.KVector3.Scalar134 * mv2.Scalar24 + 2 * mv2.Scalar15 * mv1.KVector3.Scalar234 * mv2.Scalar25 + 2 * mv2.Scalar24 * mv1.KVector3.Scalar135 * mv2.Scalar25 + mv2.Scalar25 * mv1.KVector3.Scalar134 * mv2.Scalar25 - mv2.Scalar35 * mv1.KVector3.Scalar134 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector3.Scalar135 * mv2.Scalar35 + mv2.Scalar45 * mv1.KVector3.Scalar134 * mv2.Scalar45;
            tempScalar[14] += -mv2.Scalar23 * mv1.KVector3.Scalar234 * mv2.Scalar23 - 2 * mv2.Scalar23 * mv1.KVector3.Scalar345 * mv2.Scalar35 - mv2.Scalar34 * mv1.KVector3.Scalar234 * mv2.Scalar34 + mv2.Scalar24 * mv1.KVector3.Scalar234 * mv2.Scalar24 + mv2.Scalar25 * mv1.KVector3.Scalar234 * mv2.Scalar25 + mv2.Scalar45 * mv1.KVector3.Scalar234 * mv2.Scalar45 + 2 * mv2.Scalar24 * mv1.KVector3.Scalar235 * mv2.Scalar25 + 2 * mv2.Scalar24 * mv1.KVector3.Scalar345 * mv2.Scalar45 - 2 * mv2.Scalar34 * mv1.KVector3.Scalar235 * mv2.Scalar35 - mv2.Scalar35 * mv1.KVector3.Scalar234 * mv2.Scalar35;
            tempScalar[19] += -2 * mv2.Scalar13 * mv1.KVector3.Scalar234 * mv2.Scalar45 + mv2.Scalar23 * mv1.KVector3.Scalar125 * mv2.Scalar23 - mv2.Scalar25 * mv1.KVector3.Scalar125 * mv2.Scalar25 + 2 * mv2.Scalar23 * mv1.KVector3.Scalar145 * mv2.Scalar34 - 2 * mv2.Scalar25 * mv1.KVector3.Scalar145 * mv2.Scalar45 - 2 * mv2.Scalar14 * mv1.KVector3.Scalar234 * mv2.Scalar35 + mv2.Scalar24 * mv1.KVector3.Scalar125 * mv2.Scalar24 + mv2.Scalar34 * mv1.KVector3.Scalar125 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.KVector3.Scalar135 * mv2.Scalar34 + 2 * mv2.Scalar34 * mv1.KVector3.Scalar234 * mv2.Scalar15 - mv2.Scalar35 * mv1.KVector3.Scalar125 * mv2.Scalar35 - mv2.Scalar45 * mv1.KVector3.Scalar125 * mv2.Scalar45 - 2 * mv2.Scalar25 * mv1.KVector3.Scalar135 * mv2.Scalar35;
            tempScalar[21] += -mv2.Scalar45 * mv1.KVector3.Scalar135 * mv2.Scalar45 + 2 * mv2.Scalar15 * mv1.KVector3.Scalar235 * mv2.Scalar25 + 2 * mv2.Scalar12 * mv1.KVector3.Scalar245 * mv2.Scalar34 - 2 * mv2.Scalar13 * mv1.KVector3.Scalar235 * mv2.Scalar23 - 2 * mv2.Scalar13 * mv1.KVector3.Scalar245 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.KVector3.Scalar123 * mv2.Scalar35 - 2 * mv2.Scalar23 * mv1.KVector3.Scalar124 * mv2.Scalar45 - mv2.Scalar23 * mv1.KVector3.Scalar135 * mv2.Scalar23 - mv2.Scalar24 * mv1.KVector3.Scalar135 * mv2.Scalar24 - mv2.Scalar35 * mv1.KVector3.Scalar135 * mv2.Scalar35 - 2 * mv2.Scalar14 * mv1.KVector3.Scalar235 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.KVector3.Scalar145 * mv2.Scalar24 - 2 * mv2.Scalar35 * mv1.KVector3.Scalar145 * mv2.Scalar45 - 2 * mv2.Scalar23 * mv1.KVector3.Scalar245 * mv2.Scalar14 - 2 * mv2.Scalar24 * mv1.KVector3.Scalar123 * mv2.Scalar45 - 2 * mv2.Scalar24 * mv1.KVector3.Scalar124 * mv2.Scalar35 + 2 * mv2.Scalar34 * mv1.KVector3.Scalar124 * mv2.Scalar25 + mv2.Scalar34 * mv1.KVector3.Scalar135 * mv2.Scalar34 + mv2.Scalar25 * mv1.KVector3.Scalar135 * mv2.Scalar25;
            tempScalar[22] += -mv2.Scalar23 * mv1.KVector3.Scalar235 * mv2.Scalar23 - 2 * mv2.Scalar35 * mv1.KVector3.Scalar245 * mv2.Scalar45 - mv2.Scalar24 * mv1.KVector3.Scalar235 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.KVector3.Scalar245 * mv2.Scalar24 + mv2.Scalar34 * mv1.KVector3.Scalar235 * mv2.Scalar34 - mv2.Scalar45 * mv1.KVector3.Scalar235 * mv2.Scalar45 - mv2.Scalar35 * mv1.KVector3.Scalar235 * mv2.Scalar35 + mv2.Scalar25 * mv1.KVector3.Scalar235 * mv2.Scalar25;
            tempScalar[25] += 2 * mv2.Scalar12 * mv1.KVector3.Scalar234 * mv2.Scalar35 + 2 * mv2.Scalar12 * mv1.KVector3.Scalar345 * mv2.Scalar23 + 2 * mv2.Scalar13 * mv1.KVector3.Scalar234 * mv2.Scalar25 + 2 * mv2.Scalar13 * mv1.KVector3.Scalar245 * mv2.Scalar23 + 2 * mv2.Scalar23 * mv1.KVector3.Scalar124 * mv2.Scalar35 + 2 * mv2.Scalar23 * mv1.KVector3.Scalar134 * mv2.Scalar25 + 2 * mv2.Scalar23 * mv1.KVector3.Scalar234 * mv2.Scalar15 + mv2.Scalar23 * mv1.KVector3.Scalar145 * mv2.Scalar23 + 2 * mv2.Scalar15 * mv1.KVector3.Scalar245 * mv2.Scalar25 - 2 * mv2.Scalar14 * mv1.KVector3.Scalar345 * mv2.Scalar34 - 2 * mv2.Scalar14 * mv1.KVector3.Scalar245 * mv2.Scalar24 - 2 * mv2.Scalar24 * mv1.KVector3.Scalar124 * mv2.Scalar45 - mv2.Scalar24 * mv1.KVector3.Scalar145 * mv2.Scalar24 + mv2.Scalar35 * mv1.KVector3.Scalar145 * mv2.Scalar35 + 2 * mv2.Scalar15 * mv1.KVector3.Scalar345 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector3.Scalar134 * mv2.Scalar45 - mv2.Scalar34 * mv1.KVector3.Scalar145 * mv2.Scalar34 + mv2.Scalar25 * mv1.KVector3.Scalar145 * mv2.Scalar25 - mv2.Scalar45 * mv1.KVector3.Scalar145 * mv2.Scalar45;
            tempScalar[26] += 2 * mv2.Scalar25 * mv1.KVector3.Scalar345 * mv2.Scalar35 - mv2.Scalar24 * mv1.KVector3.Scalar245 * mv2.Scalar24 - 2 * mv2.Scalar24 * mv1.KVector3.Scalar345 * mv2.Scalar34 + mv2.Scalar35 * mv1.KVector3.Scalar245 * mv2.Scalar35 + 2 * mv2.Scalar23 * mv1.KVector3.Scalar234 * mv2.Scalar25 + mv2.Scalar23 * mv1.KVector3.Scalar245 * mv2.Scalar23 + mv2.Scalar25 * mv1.KVector3.Scalar245 * mv2.Scalar25 - mv2.Scalar45 * mv1.KVector3.Scalar245 * mv2.Scalar45 - mv2.Scalar34 * mv1.KVector3.Scalar245 * mv2.Scalar34 - 2 * mv2.Scalar34 * mv1.KVector3.Scalar234 * mv2.Scalar45;
            tempScalar[28] += mv2.Scalar35 * mv1.KVector3.Scalar345 * mv2.Scalar35 + mv2.Scalar24 * mv1.KVector3.Scalar345 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.KVector3.Scalar235 * mv2.Scalar34 - mv2.Scalar23 * mv1.KVector3.Scalar345 * mv2.Scalar23 - mv2.Scalar34 * mv1.KVector3.Scalar345 * mv2.Scalar34 - mv2.Scalar25 * mv1.KVector3.Scalar345 * mv2.Scalar25 - 2 * mv2.Scalar25 * mv1.KVector3.Scalar235 * mv2.Scalar45 - mv2.Scalar45 * mv1.KVector3.Scalar345 * mv2.Scalar45;
        }
        
        if (!mv1.KVector4.IsZero())
        {
            tempScalar[15] += -mv2.Scalar23 * mv1.KVector4.Scalar1234 * mv2.Scalar23 - 2 * mv2.Scalar23 * mv1.KVector4.Scalar1345 * mv2.Scalar35 + mv2.Scalar24 * mv1.KVector4.Scalar1234 * mv2.Scalar24 + mv2.Scalar25 * mv1.KVector4.Scalar1234 * mv2.Scalar25 + mv2.Scalar45 * mv1.KVector4.Scalar1234 * mv2.Scalar45 + 2 * mv2.Scalar24 * mv1.KVector4.Scalar1235 * mv2.Scalar25 + 2 * mv2.Scalar24 * mv1.KVector4.Scalar1345 * mv2.Scalar45 - mv2.Scalar34 * mv1.KVector4.Scalar1234 * mv2.Scalar34 - mv2.Scalar35 * mv1.KVector4.Scalar1234 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector4.Scalar1235 * mv2.Scalar35;
            tempScalar[23] += -2 * mv2.Scalar12 * mv1.KVector4.Scalar2345 * mv2.Scalar24 + 2 * mv2.Scalar13 * mv1.KVector4.Scalar2345 * mv2.Scalar34 - mv2.Scalar23 * mv1.KVector4.Scalar1235 * mv2.Scalar23 - mv2.Scalar24 * mv1.KVector4.Scalar1235 * mv2.Scalar24 - 2 * mv2.Scalar35 * mv1.KVector4.Scalar1245 * mv2.Scalar45 - 2 * mv2.Scalar23 * mv1.KVector4.Scalar1245 * mv2.Scalar24 - mv2.Scalar45 * mv1.KVector4.Scalar1235 * mv2.Scalar45 - mv2.Scalar35 * mv1.KVector4.Scalar1235 * mv2.Scalar35 + mv2.Scalar34 * mv1.KVector4.Scalar1235 * mv2.Scalar34 - 2 * mv2.Scalar15 * mv1.KVector4.Scalar2345 * mv2.Scalar45 + mv2.Scalar25 * mv1.KVector4.Scalar1235 * mv2.Scalar25;
            tempScalar[27] += 2 * mv2.Scalar23 * mv1.KVector4.Scalar1234 * mv2.Scalar25 + mv2.Scalar35 * mv1.KVector4.Scalar1245 * mv2.Scalar35 + mv2.Scalar23 * mv1.KVector4.Scalar1245 * mv2.Scalar23 + mv2.Scalar25 * mv1.KVector4.Scalar1245 * mv2.Scalar25 - mv2.Scalar24 * mv1.KVector4.Scalar1245 * mv2.Scalar24 - mv2.Scalar34 * mv1.KVector4.Scalar1245 * mv2.Scalar34 - 2 * mv2.Scalar24 * mv1.KVector4.Scalar1345 * mv2.Scalar34 - 2 * mv2.Scalar34 * mv1.KVector4.Scalar1234 * mv2.Scalar45 - mv2.Scalar45 * mv1.KVector4.Scalar1245 * mv2.Scalar45 + 2 * mv2.Scalar25 * mv1.KVector4.Scalar1345 * mv2.Scalar35;
            tempScalar[29] += mv2.Scalar35 * mv1.KVector4.Scalar1345 * mv2.Scalar35 - 2 * mv2.Scalar13 * mv1.KVector4.Scalar2345 * mv2.Scalar23 - 2 * mv2.Scalar23 * mv1.KVector4.Scalar1235 * mv2.Scalar34 - mv2.Scalar23 * mv1.KVector4.Scalar1345 * mv2.Scalar23 - mv2.Scalar34 * mv1.KVector4.Scalar1345 * mv2.Scalar34 + 2 * mv2.Scalar14 * mv1.KVector4.Scalar2345 * mv2.Scalar24 + mv2.Scalar24 * mv1.KVector4.Scalar1345 * mv2.Scalar24 - 2 * mv2.Scalar15 * mv1.KVector4.Scalar2345 * mv2.Scalar25 - 2 * mv2.Scalar25 * mv1.KVector4.Scalar1235 * mv2.Scalar45 - mv2.Scalar25 * mv1.KVector4.Scalar1345 * mv2.Scalar25 - mv2.Scalar45 * mv1.KVector4.Scalar1345 * mv2.Scalar45;
            tempScalar[30] += -mv2.Scalar23 * mv1.KVector4.Scalar2345 * mv2.Scalar23 - mv2.Scalar25 * mv1.KVector4.Scalar2345 * mv2.Scalar25 - mv2.Scalar34 * mv1.KVector4.Scalar2345 * mv2.Scalar34 - mv2.Scalar45 * mv1.KVector4.Scalar2345 * mv2.Scalar45 + mv2.Scalar24 * mv1.KVector4.Scalar2345 * mv2.Scalar24 + mv2.Scalar35 * mv1.KVector4.Scalar2345 * mv2.Scalar35;
        }
        
        if (!mv1.KVector5.IsZero())
        {
            tempScalar[31] += -mv2.Scalar34 * mv1.KVector5.Scalar12345 * mv2.Scalar34 + mv2.Scalar35 * mv1.KVector5.Scalar12345 * mv2.Scalar35 - mv2.Scalar23 * mv1.KVector5.Scalar12345 * mv2.Scalar23 + mv2.Scalar24 * mv1.KVector5.Scalar12345 * mv2.Scalar24 - mv2.Scalar45 * mv1.KVector5.Scalar12345 * mv2.Scalar45 - mv2.Scalar25 * mv1.KVector5.Scalar12345 * mv2.Scalar25;
        }
        
        return Ga401Multivector.Create(tempScalar);
    }
    
    public static Ga401Multivector MapUsingRotor(this Ga401Multivector mv1, Ga401KVector4 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401Multivector.Zero;
        
        var tempScalar = new double[32];
        
        if (!mv1.KVector0.IsZero())
        {
            tempScalar[0] += mv2.Scalar2345 * mv1.KVector0.Scalar * mv2.Scalar2345;
        }
        
        if (!mv1.KVector1.IsZero())
        {
            tempScalar[1] += 2 * mv2.Scalar1234 * mv1.KVector1.Scalar5 * mv2.Scalar2345 - 2 * mv2.Scalar1235 * mv1.KVector1.Scalar4 * mv2.Scalar2345 + 2 * mv2.Scalar1245 * mv1.KVector1.Scalar3 * mv2.Scalar2345 - 2 * mv2.Scalar1345 * mv1.KVector1.Scalar2 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.KVector1.Scalar1 * mv2.Scalar2345;
            tempScalar[2] += -mv2.Scalar2345 * mv1.KVector1.Scalar2 * mv2.Scalar2345;
            tempScalar[4] += -mv2.Scalar2345 * mv1.KVector1.Scalar3 * mv2.Scalar2345;
            tempScalar[8] += -mv2.Scalar2345 * mv1.KVector1.Scalar4 * mv2.Scalar2345;
            tempScalar[16] += -mv2.Scalar2345 * mv1.KVector1.Scalar5 * mv2.Scalar2345;
        }
        
        if (!mv1.KVector2.IsZero())
        {
            tempScalar[3] += 2 * mv2.Scalar1234 * mv1.KVector2.Scalar25 * mv2.Scalar2345 - 2 * mv2.Scalar1235 * mv1.KVector2.Scalar24 * mv2.Scalar2345 + 2 * mv2.Scalar1245 * mv1.KVector2.Scalar23 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.KVector2.Scalar12 * mv2.Scalar2345;
            tempScalar[5] += 2 * mv2.Scalar1234 * mv1.KVector2.Scalar35 * mv2.Scalar2345 - 2 * mv2.Scalar1235 * mv1.KVector2.Scalar34 * mv2.Scalar2345 + 2 * mv2.Scalar1345 * mv1.KVector2.Scalar23 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.KVector2.Scalar13 * mv2.Scalar2345;
            tempScalar[6] += mv2.Scalar2345 * mv1.KVector2.Scalar23 * mv2.Scalar2345;
            tempScalar[9] += 2 * mv2.Scalar1234 * mv1.KVector2.Scalar45 * mv2.Scalar2345 - 2 * mv2.Scalar1245 * mv1.KVector2.Scalar34 * mv2.Scalar2345 + 2 * mv2.Scalar1345 * mv1.KVector2.Scalar24 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.KVector2.Scalar14 * mv2.Scalar2345;
            tempScalar[10] += mv2.Scalar2345 * mv1.KVector2.Scalar24 * mv2.Scalar2345;
            tempScalar[12] += mv2.Scalar2345 * mv1.KVector2.Scalar34 * mv2.Scalar2345;
            tempScalar[17] += 2 * mv2.Scalar1235 * mv1.KVector2.Scalar45 * mv2.Scalar2345 - 2 * mv2.Scalar1245 * mv1.KVector2.Scalar35 * mv2.Scalar2345 + 2 * mv2.Scalar1345 * mv1.KVector2.Scalar25 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.KVector2.Scalar15 * mv2.Scalar2345;
            tempScalar[18] += mv2.Scalar2345 * mv1.KVector2.Scalar25 * mv2.Scalar2345;
            tempScalar[20] += mv2.Scalar2345 * mv1.KVector2.Scalar35 * mv2.Scalar2345;
            tempScalar[24] += mv2.Scalar2345 * mv1.KVector2.Scalar45 * mv2.Scalar2345;
        }
        
        if (!mv1.KVector3.IsZero())
        {
            tempScalar[7] += 2 * mv2.Scalar1234 * mv1.KVector3.Scalar235 * mv2.Scalar2345 - 2 * mv2.Scalar1235 * mv1.KVector3.Scalar234 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.KVector3.Scalar123 * mv2.Scalar2345;
            tempScalar[11] += 2 * mv2.Scalar1234 * mv1.KVector3.Scalar245 * mv2.Scalar2345 - 2 * mv2.Scalar1245 * mv1.KVector3.Scalar234 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.KVector3.Scalar124 * mv2.Scalar2345;
            tempScalar[13] += 2 * mv2.Scalar1234 * mv1.KVector3.Scalar345 * mv2.Scalar2345 - 2 * mv2.Scalar1345 * mv1.KVector3.Scalar234 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.KVector3.Scalar134 * mv2.Scalar2345;
            tempScalar[14] += -mv2.Scalar2345 * mv1.KVector3.Scalar234 * mv2.Scalar2345;
            tempScalar[19] += 2 * mv2.Scalar1235 * mv1.KVector3.Scalar245 * mv2.Scalar2345 - 2 * mv2.Scalar1245 * mv1.KVector3.Scalar235 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.KVector3.Scalar125 * mv2.Scalar2345;
            tempScalar[21] += 2 * mv2.Scalar1235 * mv1.KVector3.Scalar345 * mv2.Scalar2345 - 2 * mv2.Scalar1345 * mv1.KVector3.Scalar235 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.KVector3.Scalar135 * mv2.Scalar2345;
            tempScalar[22] += -mv2.Scalar2345 * mv1.KVector3.Scalar235 * mv2.Scalar2345;
            tempScalar[25] += 2 * mv2.Scalar1245 * mv1.KVector3.Scalar345 * mv2.Scalar2345 - 2 * mv2.Scalar1345 * mv1.KVector3.Scalar245 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.KVector3.Scalar145 * mv2.Scalar2345;
            tempScalar[26] += -mv2.Scalar2345 * mv1.KVector3.Scalar245 * mv2.Scalar2345;
            tempScalar[28] += -mv2.Scalar2345 * mv1.KVector3.Scalar345 * mv2.Scalar2345;
        }
        
        if (!mv1.KVector4.IsZero())
        {
            tempScalar[15] += 2 * mv2.Scalar1234 * mv1.KVector4.Scalar2345 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.KVector4.Scalar1234 * mv2.Scalar2345;
            tempScalar[23] += 2 * mv2.Scalar1235 * mv1.KVector4.Scalar2345 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.KVector4.Scalar1235 * mv2.Scalar2345;
            tempScalar[27] += 2 * mv2.Scalar1245 * mv1.KVector4.Scalar2345 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.KVector4.Scalar1245 * mv2.Scalar2345;
            tempScalar[29] += 2 * mv2.Scalar1345 * mv1.KVector4.Scalar2345 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.KVector4.Scalar1345 * mv2.Scalar2345;
            tempScalar[30] += mv2.Scalar2345 * mv1.KVector4.Scalar2345 * mv2.Scalar2345;
        }
        
        if (!mv1.KVector5.IsZero())
        {
            tempScalar[31] += mv2.Scalar2345 * mv1.KVector5.Scalar12345 * mv2.Scalar2345;
        }
        
        return Ga401Multivector.Create(tempScalar);
    }
    
    public static Ga401Multivector MapUsingRotor(this Ga401Multivector mv1, Ga401Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401Multivector.Zero;
        
        var tempScalar = new double[32];
        
        if (!mv1.KVector0.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar[0] += mv2.KVector0.Scalar * mv1.KVector0.Scalar * mv2.KVector0.Scalar;
            }
            
            if (!mv2.KVector2.IsZero())
            {
                tempScalar[0] += mv2.KVector2.Scalar23 * mv1.KVector0.Scalar * mv2.KVector2.Scalar23 + mv2.KVector2.Scalar24 * mv1.KVector0.Scalar * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.KVector0.Scalar * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar25 * mv1.KVector0.Scalar * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar45 * mv1.KVector0.Scalar * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar35 * mv1.KVector0.Scalar * mv2.KVector2.Scalar35;
            }
            
            if (!mv2.KVector4.IsZero())
            {
                tempScalar[0] += mv2.KVector4.Scalar2345 * mv1.KVector0.Scalar * mv2.KVector4.Scalar2345;
            }
            
        }
        
        if (!mv1.KVector1.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar[1] += mv2.KVector0.Scalar * mv1.KVector1.Scalar1 * mv2.KVector0.Scalar;
                tempScalar[2] += mv2.KVector0.Scalar * mv1.KVector1.Scalar2 * mv2.KVector0.Scalar;
                tempScalar[4] += mv2.KVector0.Scalar * mv1.KVector1.Scalar3 * mv2.KVector0.Scalar;
                tempScalar[8] += mv2.KVector0.Scalar * mv1.KVector1.Scalar4 * mv2.KVector0.Scalar;
                tempScalar[16] += mv2.KVector0.Scalar * mv1.KVector1.Scalar5 * mv2.KVector0.Scalar;
            }
            
            if (!mv2.KVector0.IsZero() && !mv2.KVector2.IsZero())
            {
                tempScalar[1] += 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar13 + 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar14 + 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar15;
                tempScalar[2] += 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar24 + 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar25;
                tempScalar[4] += -2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar35;
                tempScalar[8] += -2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar45;
                tempScalar[16] += -2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar25 - 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar45;
            }
            
            if (!mv2.KVector2.IsZero())
            {
                tempScalar[1] += 2 * mv2.KVector2.Scalar12 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar12 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar12 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar13 * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar13 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar13 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar23 * mv1.KVector1.Scalar1 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar15 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar14 * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar14 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar14 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar24 * mv1.KVector1.Scalar1 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar15 * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar34 * mv1.KVector1.Scalar1 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar45 * mv1.KVector1.Scalar1 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar15 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar25 * mv1.KVector1.Scalar1 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar35 * mv1.KVector1.Scalar1 * mv2.KVector2.Scalar35;
                tempScalar[2] += mv2.KVector2.Scalar23 * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar23 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar23 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar24 * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar24 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar24 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar25 * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar35 * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar25 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar25 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar45;
                tempScalar[4] += -mv2.KVector2.Scalar23 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar25 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar23 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar34 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar34 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar35 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar35 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar45;
                tempScalar[8] += mv2.KVector2.Scalar23 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar25 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar24 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar45 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar34 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar35 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar35;
                tempScalar[16] += -mv2.KVector2.Scalar45 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar35 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar23 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar23 + mv2.KVector2.Scalar24 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar25 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar25;
            }
            
            if (!mv2.KVector2.IsZero() && !mv2.KVector4.IsZero())
            {
                tempScalar[1] += 2 * mv2.KVector2.Scalar34 * mv1.KVector1.Scalar2 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector2.Scalar35 * mv1.KVector1.Scalar2 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar23 * mv1.KVector1.Scalar4 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector2.Scalar23 * mv1.KVector1.Scalar5 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar45 * mv1.KVector1.Scalar2 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar24 * mv1.KVector1.Scalar5 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar45 * mv1.KVector1.Scalar3 * mv2.KVector4.Scalar1345 + 2 * mv2.KVector2.Scalar34 * mv1.KVector1.Scalar5 * mv2.KVector4.Scalar1345;
                tempScalar[2] += 2 * mv2.KVector2.Scalar45 * mv1.KVector1.Scalar3 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar34 * mv1.KVector1.Scalar5 * mv2.KVector4.Scalar2345;
                tempScalar[4] += -2 * mv2.KVector2.Scalar24 * mv1.KVector1.Scalar5 * mv2.KVector4.Scalar2345;
                tempScalar[8] += 2 * mv2.KVector2.Scalar23 * mv1.KVector1.Scalar5 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar25 * mv1.KVector1.Scalar3 * mv2.KVector4.Scalar2345;
                tempScalar[16] += 2 * mv2.KVector2.Scalar24 * mv1.KVector1.Scalar3 * mv2.KVector4.Scalar2345;
            }
            
            if (!mv2.KVector4.IsZero())
            {
                tempScalar[1] += -2 * mv2.KVector4.Scalar1235 * mv1.KVector1.Scalar4 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1234 * mv1.KVector1.Scalar5 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1245 * mv1.KVector1.Scalar3 * mv2.KVector4.Scalar2345 + mv2.KVector4.Scalar2345 * mv1.KVector1.Scalar1 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector4.Scalar1345 * mv1.KVector1.Scalar2 * mv2.KVector4.Scalar2345;
                tempScalar[2] += -mv2.KVector4.Scalar2345 * mv1.KVector1.Scalar2 * mv2.KVector4.Scalar2345;
                tempScalar[4] += -mv2.KVector4.Scalar2345 * mv1.KVector1.Scalar3 * mv2.KVector4.Scalar2345;
                tempScalar[8] += -mv2.KVector4.Scalar2345 * mv1.KVector1.Scalar4 * mv2.KVector4.Scalar2345;
                tempScalar[16] += -mv2.KVector4.Scalar2345 * mv1.KVector1.Scalar5 * mv2.KVector4.Scalar2345;
            }
            
        }
        
        if (!mv1.KVector2.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar[3] += mv2.KVector0.Scalar * mv1.KVector2.Scalar12 * mv2.KVector0.Scalar;
                tempScalar[5] += mv2.KVector0.Scalar * mv1.KVector2.Scalar13 * mv2.KVector0.Scalar;
                tempScalar[6] += mv2.KVector0.Scalar * mv1.KVector2.Scalar23 * mv2.KVector0.Scalar;
                tempScalar[9] += mv2.KVector0.Scalar * mv1.KVector2.Scalar14 * mv2.KVector0.Scalar;
                tempScalar[10] += mv2.KVector0.Scalar * mv1.KVector2.Scalar24 * mv2.KVector0.Scalar;
                tempScalar[12] += mv2.KVector0.Scalar * mv1.KVector2.Scalar34 * mv2.KVector0.Scalar;
                tempScalar[17] += mv2.KVector0.Scalar * mv1.KVector2.Scalar15 * mv2.KVector0.Scalar;
                tempScalar[18] += mv2.KVector0.Scalar * mv1.KVector2.Scalar25 * mv2.KVector0.Scalar;
                tempScalar[20] += mv2.KVector0.Scalar * mv1.KVector2.Scalar35 * mv2.KVector0.Scalar;
                tempScalar[24] += mv2.KVector0.Scalar * mv1.KVector2.Scalar45 * mv2.KVector0.Scalar;
            }
            
            if (!mv2.KVector0.IsZero() && !mv2.KVector2.IsZero())
            {
                tempScalar[3] += 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar23 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar13 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar14 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar25 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar15;
                tempScalar[5] += -2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar34 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar14 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar15;
                tempScalar[6] += 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar34 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar24 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar25;
                tempScalar[9] += -2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar13 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar15;
                tempScalar[10] += -2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar25;
                tempScalar[12] += 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar35;
                tempScalar[17] += -2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar25 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar45 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar13 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar14;
                tempScalar[18] += -2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar45 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar24;
                tempScalar[20] += 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar25 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar34;
                tempScalar[24] += 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar25 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar34;
            }
            
            if (!mv2.KVector0.IsZero() && !mv2.KVector4.IsZero())
            {
                tempScalar[3] += -2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar34 * mv2.KVector4.Scalar1234 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar45 * mv2.KVector4.Scalar1245;
                tempScalar[5] += 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar45 * mv2.KVector4.Scalar1345;
                tempScalar[6] += -2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar45 * mv2.KVector4.Scalar2345;
                tempScalar[9] += -2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar23 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar1345;
                tempScalar[10] += 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar2345;
                tempScalar[12] += -2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar2345;
                tempScalar[17] += -2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar23 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar1245 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar34 * mv2.KVector4.Scalar1345;
                tempScalar[18] += -2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar34 * mv2.KVector4.Scalar2345;
                tempScalar[20] += 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar2345;
                tempScalar[24] += -2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar23 * mv2.KVector4.Scalar2345;
            }
            
            if (!mv2.KVector2.IsZero())
            {
                tempScalar[3] += mv2.KVector2.Scalar23 * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar24 * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar25 * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar35 * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar25 * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar25 * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar45;
                tempScalar[5] += 2 * mv2.KVector2.Scalar12 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar12 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar13 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar13 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar13 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar23 * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar25 * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar14 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar15 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar14 - 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar15 + mv2.KVector2.Scalar34 * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar35 * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar35 * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar45;
                tempScalar[6] += -mv2.KVector2.Scalar23 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar34 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar45 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar25 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar35 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar35 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar45;
                tempScalar[9] += 2 * mv2.KVector2.Scalar12 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar12 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar13 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar15 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar13 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar45 * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar23 * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar14 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar14 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar14 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar14 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar35 - mv2.KVector2.Scalar24 * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar25 * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar15 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar15 - mv2.KVector2.Scalar34 * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar35 * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar15;
                tempScalar[10] += -mv2.KVector2.Scalar24 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar25 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar23 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar35 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar35 - mv2.KVector2.Scalar34 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar25 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar25;
                tempScalar[12] += 2 * mv2.KVector2.Scalar25 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar24 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar23 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar34 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar25 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar35 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar45;
                tempScalar[17] += 2 * mv2.KVector2.Scalar12 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar45 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar12 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar13 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar13 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar35 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar23 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar15 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar14 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar14 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar24 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar15 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar15 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar25 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar25;
                tempScalar[18] += -mv2.KVector2.Scalar35 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar25 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar23 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar25 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar24 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar25 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar45 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar45;
                tempScalar[20] += -mv2.KVector2.Scalar45 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar23 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar35 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar35 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar25 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar34 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar34;
                tempScalar[24] += 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar23 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar24 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar35 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar34 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar25 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar45 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar45;
            }
            
            if (!mv2.KVector2.IsZero() && !mv2.KVector4.IsZero())
            {
                tempScalar[3] += 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar14 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar1345 + 2 * mv2.KVector2.Scalar45 * mv1.KVector2.Scalar13 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar15 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar35 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar1345;
                tempScalar[5] += 2 * mv2.KVector2.Scalar45 * mv1.KVector2.Scalar23 * mv2.KVector4.Scalar1245 - 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar15 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar1345 - 2 * mv2.KVector2.Scalar15 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar25 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar1345;
                tempScalar[6] += 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar25 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar2345;
                tempScalar[9] += 2 * mv2.KVector2.Scalar12 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar15 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar1245 - 2 * mv2.KVector2.Scalar25 * mv1.KVector2.Scalar34 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar25 * mv1.KVector2.Scalar13 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar35 * mv1.KVector2.Scalar23 * mv2.KVector4.Scalar1245;
                tempScalar[12] += 2 * mv2.KVector2.Scalar45 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar2345;
                tempScalar[17] += 2 * mv2.KVector2.Scalar13 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar1345 + 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar45 * mv2.KVector4.Scalar1234 - 2 * mv2.KVector2.Scalar45 * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar13 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar34 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar35 * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar23 * mv2.KVector4.Scalar1245 - 2 * mv2.KVector2.Scalar45 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar1345;
                tempScalar[18] += 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar45 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar2345;
                tempScalar[24] += -2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar25 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar2345;
            }
            
            if (!mv2.KVector4.IsZero() && !mv2.KVector2.IsZero())
            {
                tempScalar[3] += 2 * mv2.KVector4.Scalar1234 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar35 + 2 * mv2.KVector4.Scalar1235 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar45;
                tempScalar[5] += 2 * mv2.KVector4.Scalar1234 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar45 - 2 * mv2.KVector4.Scalar1234 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar25;
                tempScalar[9] += -2 * mv2.KVector4.Scalar1234 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar35;
                tempScalar[17] += -2 * mv2.KVector4.Scalar1234 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar35;
            }
            
            if (!mv2.KVector4.IsZero())
            {
                tempScalar[3] += 2 * mv2.KVector4.Scalar1245 * mv1.KVector2.Scalar23 * mv2.KVector4.Scalar2345 - mv2.KVector4.Scalar2345 * mv1.KVector2.Scalar12 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector4.Scalar1235 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1234 * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar2345;
                tempScalar[5] += 2 * mv2.KVector4.Scalar1345 * mv1.KVector2.Scalar23 * mv2.KVector4.Scalar2345 - mv2.KVector4.Scalar2345 * mv1.KVector2.Scalar13 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1234 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector4.Scalar1235 * mv1.KVector2.Scalar34 * mv2.KVector4.Scalar2345;
                tempScalar[6] += mv2.KVector4.Scalar2345 * mv1.KVector2.Scalar23 * mv2.KVector4.Scalar2345;
                tempScalar[9] += -2 * mv2.KVector4.Scalar1245 * mv1.KVector2.Scalar34 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1234 * mv1.KVector2.Scalar45 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1345 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar2345 - mv2.KVector4.Scalar2345 * mv1.KVector2.Scalar14 * mv2.KVector4.Scalar2345;
                tempScalar[10] += mv2.KVector4.Scalar2345 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar2345;
                tempScalar[12] += mv2.KVector4.Scalar2345 * mv1.KVector2.Scalar34 * mv2.KVector4.Scalar2345;
                tempScalar[17] += -2 * mv2.KVector4.Scalar1245 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1345 * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1235 * mv1.KVector2.Scalar45 * mv2.KVector4.Scalar2345 - mv2.KVector4.Scalar2345 * mv1.KVector2.Scalar15 * mv2.KVector4.Scalar2345;
                tempScalar[18] += mv2.KVector4.Scalar2345 * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar2345;
                tempScalar[20] += mv2.KVector4.Scalar2345 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar2345;
                tempScalar[24] += mv2.KVector4.Scalar2345 * mv1.KVector2.Scalar45 * mv2.KVector4.Scalar2345;
            }
            
        }
        
        if (!mv1.KVector3.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar[7] += mv2.KVector0.Scalar * mv1.KVector3.Scalar123 * mv2.KVector0.Scalar;
                tempScalar[11] += mv2.KVector0.Scalar * mv1.KVector3.Scalar124 * mv2.KVector0.Scalar;
                tempScalar[13] += mv2.KVector0.Scalar * mv1.KVector3.Scalar134 * mv2.KVector0.Scalar;
                tempScalar[14] += mv2.KVector0.Scalar * mv1.KVector3.Scalar234 * mv2.KVector0.Scalar;
                tempScalar[19] += mv2.KVector0.Scalar * mv1.KVector3.Scalar125 * mv2.KVector0.Scalar;
                tempScalar[21] += mv2.KVector0.Scalar * mv1.KVector3.Scalar135 * mv2.KVector0.Scalar;
                tempScalar[22] += mv2.KVector0.Scalar * mv1.KVector3.Scalar235 * mv2.KVector0.Scalar;
                tempScalar[25] += mv2.KVector0.Scalar * mv1.KVector3.Scalar145 * mv2.KVector0.Scalar;
                tempScalar[26] += mv2.KVector0.Scalar * mv1.KVector3.Scalar245 * mv2.KVector0.Scalar;
                tempScalar[28] += mv2.KVector0.Scalar * mv1.KVector3.Scalar345 * mv2.KVector0.Scalar;
            }
            
            if (!mv2.KVector0.IsZero() && !mv2.KVector2.IsZero())
            {
                tempScalar[7] += 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar34 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar24 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar14 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar25 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar15;
                tempScalar[11] += -2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar23 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar13 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar25 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar15;
                tempScalar[13] += 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar35 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar15;
                tempScalar[14] += 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar35 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar25;
                tempScalar[19] += -2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar45 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar23 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar13 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar14;
                tempScalar[21] += 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar25 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar34 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar14;
                tempScalar[22] += -2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar45 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar34 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar24;
                tempScalar[25] += 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar25 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar13;
                tempScalar[26] += 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar23;
                tempScalar[28] += -2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar25 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar23;
            }
            
            if (!mv2.KVector0.IsZero() && !mv2.KVector4.IsZero())
            {
                tempScalar[7] += -2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar145 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar1345 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar345 * mv2.KVector4.Scalar1245;
                tempScalar[11] += 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar135 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar235 * mv2.KVector4.Scalar1345 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar345 * mv2.KVector4.Scalar1235;
                tempScalar[13] += -2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar125 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar235 * mv2.KVector4.Scalar1245 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar1235;
                tempScalar[19] += -2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar134 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar1345 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar345 * mv2.KVector4.Scalar1234;
                tempScalar[21] += 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar124 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar1234;
                tempScalar[25] += -2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar123 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar235 * mv2.KVector4.Scalar1234;
            }
            
            if (!mv2.KVector2.IsZero())
            {
                tempScalar[7] += -2 * mv2.KVector2.Scalar12 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar12 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar23 * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar35 * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar34 * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar25 * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar35 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar15 + 2 * mv2.KVector2.Scalar15 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar45 * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar45;
                tempScalar[11] += -2 * mv2.KVector2.Scalar12 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar12 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar23 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar15 + 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar24 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar34 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar25 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar35 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar35;
                tempScalar[13] += 2 * mv2.KVector2.Scalar12 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar12 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar23 * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar34 * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar24 * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar15 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar15 + mv2.KVector2.Scalar25 * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar35 * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar45;
                tempScalar[14] += -mv2.KVector2.Scalar23 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar23 + mv2.KVector2.Scalar45 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar35 - mv2.KVector2.Scalar34 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar24 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar25 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar35 - mv2.KVector2.Scalar35 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar35;
                tempScalar[19] += -2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar23 * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar25 * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar24 * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar15 - mv2.KVector2.Scalar35 * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar35 - mv2.KVector2.Scalar45 * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar35;
                tempScalar[21] += -mv2.KVector2.Scalar45 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar12 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar23 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar35 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar35 * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar14 - 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar34 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar15 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar25 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar25;
                tempScalar[22] += -mv2.KVector2.Scalar23 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar23 + mv2.KVector2.Scalar25 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar45 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar24 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar35 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar35 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar45;
                tempScalar[25] += 2 * mv2.KVector2.Scalar12 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar12 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar15 + mv2.KVector2.Scalar23 * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar15 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar24 * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar35 * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar15 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar34 * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar25 * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar45 * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar45;
                tempScalar[26] += -mv2.KVector2.Scalar24 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar45 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar35 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar23 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar23 + mv2.KVector2.Scalar25 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar34 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar35;
                tempScalar[28] += mv2.KVector2.Scalar24 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar23 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar34 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar25 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar35 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar45 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar45;
            }
            
            if (!mv2.KVector2.IsZero() && !mv2.KVector4.IsZero())
            {
                tempScalar[7] += -2 * mv2.KVector2.Scalar12 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar345 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar235 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar35 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar1345 + 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar135 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar124 * mv2.KVector4.Scalar2345;
                tempScalar[11] += 2 * mv2.KVector2.Scalar45 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar1345 + 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar235 * mv2.KVector4.Scalar1245 - 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar1345;
                tempScalar[13] += 2 * mv2.KVector2.Scalar45 * mv1.KVector3.Scalar124 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar135 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar345 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar35 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar1345;
                tempScalar[14] += 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar2345;
                tempScalar[19] += -2 * mv2.KVector2.Scalar12 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar124 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar45 * mv1.KVector3.Scalar135 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar35 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar1345;
                tempScalar[21] += -2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar1345 - 2 * mv2.KVector2.Scalar45 * mv1.KVector3.Scalar235 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar15 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar1345;
                tempScalar[22] += -2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar2345;
                tempScalar[25] += -2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar1234 - 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar1345 - 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar124 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar135 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar345 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar35 * mv1.KVector3.Scalar235 * mv2.KVector4.Scalar1245;
                tempScalar[26] += -2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar2345;
                tempScalar[28] += -2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar45 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar2345;
            }
            
            if (!mv2.KVector4.IsZero() && !mv2.KVector2.IsZero())
            {
                tempScalar[7] += -2 * mv2.KVector4.Scalar1234 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar25;
                tempScalar[13] += 2 * mv2.KVector4.Scalar1234 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar45;
                tempScalar[19] += -2 * mv2.KVector4.Scalar1235 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar45;
            }
            
            if (!mv2.KVector4.IsZero())
            {
                tempScalar[7] += 2 * mv2.KVector4.Scalar1234 * mv1.KVector3.Scalar235 * mv2.KVector4.Scalar2345 + mv2.KVector4.Scalar2345 * mv1.KVector3.Scalar123 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector4.Scalar1235 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar2345;
                tempScalar[11] += mv2.KVector4.Scalar2345 * mv1.KVector3.Scalar124 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector4.Scalar1245 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1234 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar2345;
                tempScalar[13] += mv2.KVector4.Scalar2345 * mv1.KVector3.Scalar134 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1234 * mv1.KVector3.Scalar345 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector4.Scalar1345 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar2345;
                tempScalar[14] += -mv2.KVector4.Scalar2345 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar2345;
                tempScalar[19] += mv2.KVector4.Scalar2345 * mv1.KVector3.Scalar125 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1235 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector4.Scalar1245 * mv1.KVector3.Scalar235 * mv2.KVector4.Scalar2345;
                tempScalar[21] += -2 * mv2.KVector4.Scalar1345 * mv1.KVector3.Scalar235 * mv2.KVector4.Scalar2345 + mv2.KVector4.Scalar2345 * mv1.KVector3.Scalar135 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1235 * mv1.KVector3.Scalar345 * mv2.KVector4.Scalar2345;
                tempScalar[22] += -mv2.KVector4.Scalar2345 * mv1.KVector3.Scalar235 * mv2.KVector4.Scalar2345;
                tempScalar[25] += -2 * mv2.KVector4.Scalar1345 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar2345 + mv2.KVector4.Scalar2345 * mv1.KVector3.Scalar145 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1245 * mv1.KVector3.Scalar345 * mv2.KVector4.Scalar2345;
                tempScalar[26] += -mv2.KVector4.Scalar2345 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar2345;
                tempScalar[28] += -mv2.KVector4.Scalar2345 * mv1.KVector3.Scalar345 * mv2.KVector4.Scalar2345;
            }
            
        }
        
        if (!mv1.KVector4.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar[15] += mv2.KVector0.Scalar * mv1.KVector4.Scalar1234 * mv2.KVector0.Scalar;
                tempScalar[23] += mv2.KVector0.Scalar * mv1.KVector4.Scalar1235 * mv2.KVector0.Scalar;
                tempScalar[27] += mv2.KVector0.Scalar * mv1.KVector4.Scalar1245 * mv2.KVector0.Scalar;
                tempScalar[29] += mv2.KVector0.Scalar * mv1.KVector4.Scalar1345 * mv2.KVector0.Scalar;
                tempScalar[30] += mv2.KVector0.Scalar * mv1.KVector4.Scalar2345 * mv2.KVector0.Scalar;
            }
            
            if (!mv2.KVector0.IsZero() && !mv2.KVector2.IsZero())
            {
                tempScalar[15] += 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar35 + 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar25 - 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar15;
                tempScalar[23] += -2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar45 + 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar34 - 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar24 + 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar14;
                tempScalar[27] += 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar23 - 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar13;
                tempScalar[29] += -2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar25 + 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar12;
            }
            
            if (!mv2.KVector2.IsZero())
            {
                tempScalar[15] += -mv2.KVector2.Scalar23 * mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar23 * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar24 * mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar25 * mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar45 * mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar24 * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar24 * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar34 * mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar35 * mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar35;
                tempScalar[23] += -2 * mv2.KVector2.Scalar12 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar13 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar23 * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar15 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar25 * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar35 * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar35 - mv2.KVector2.Scalar45 * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar35 * mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar45;
                tempScalar[27] += 2 * mv2.KVector2.Scalar23 * mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar23 * mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar23 + mv2.KVector2.Scalar25 * mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar24 * mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar34 * mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar24 * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar34 * mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar45 * mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar35 * mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar25 * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar35;
                tempScalar[29] += -2 * mv2.KVector2.Scalar13 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar23 * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar23 * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar34 * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar14 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar24 * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar15 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar25 * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar25 * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar45 * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar35 * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar35;
                tempScalar[30] += -mv2.KVector2.Scalar23 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar25 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar34 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar45 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar24 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar35 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar35;
            }
            
            if (!mv2.KVector2.IsZero() && !mv2.KVector4.IsZero())
            {
                tempScalar[15] += -2 * mv2.KVector2.Scalar23 * mv1.KVector4.Scalar2345 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar24 * mv1.KVector4.Scalar1245 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar34 * mv1.KVector4.Scalar2345 * mv2.KVector4.Scalar1345;
                tempScalar[23] += -2 * mv2.KVector2.Scalar23 * mv1.KVector4.Scalar1234 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar25 * mv1.KVector4.Scalar1245 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar35 * mv1.KVector4.Scalar2345 * mv2.KVector4.Scalar1345;
                tempScalar[27] += -2 * mv2.KVector2.Scalar24 * mv1.KVector4.Scalar1234 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar45 * mv1.KVector4.Scalar2345 * mv2.KVector4.Scalar1345 + 2 * mv2.KVector2.Scalar25 * mv1.KVector4.Scalar2345 * mv2.KVector4.Scalar1235;
                tempScalar[29] += 2 * mv2.KVector2.Scalar35 * mv1.KVector4.Scalar2345 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar45 * mv1.KVector4.Scalar1245 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar34 * mv1.KVector4.Scalar1234 * mv2.KVector4.Scalar2345;
            }
            
            if (!mv2.KVector4.IsZero())
            {
                tempScalar[15] += -mv2.KVector4.Scalar2345 * mv1.KVector4.Scalar1234 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1234 * mv1.KVector4.Scalar2345 * mv2.KVector4.Scalar2345;
                tempScalar[23] += 2 * mv2.KVector4.Scalar1235 * mv1.KVector4.Scalar2345 * mv2.KVector4.Scalar2345 - mv2.KVector4.Scalar2345 * mv1.KVector4.Scalar1235 * mv2.KVector4.Scalar2345;
                tempScalar[27] += 2 * mv2.KVector4.Scalar1245 * mv1.KVector4.Scalar2345 * mv2.KVector4.Scalar2345 - mv2.KVector4.Scalar2345 * mv1.KVector4.Scalar1245 * mv2.KVector4.Scalar2345;
                tempScalar[29] += -mv2.KVector4.Scalar2345 * mv1.KVector4.Scalar1345 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1345 * mv1.KVector4.Scalar2345 * mv2.KVector4.Scalar2345;
                tempScalar[30] += mv2.KVector4.Scalar2345 * mv1.KVector4.Scalar2345 * mv2.KVector4.Scalar2345;
            }
            
        }
        
        if (!mv1.KVector5.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar[31] += mv2.KVector0.Scalar * mv1.KVector5.Scalar12345 * mv2.KVector0.Scalar;
            }
            
            if (!mv2.KVector2.IsZero())
            {
                tempScalar[31] += -mv2.KVector2.Scalar23 * mv1.KVector5.Scalar12345 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar45 * mv1.KVector5.Scalar12345 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar24 * mv1.KVector5.Scalar12345 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar34 * mv1.KVector5.Scalar12345 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar25 * mv1.KVector5.Scalar12345 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar35 * mv1.KVector5.Scalar12345 * mv2.KVector2.Scalar35;
            }
            
            if (!mv2.KVector4.IsZero())
            {
                tempScalar[31] += mv2.KVector4.Scalar2345 * mv1.KVector5.Scalar12345 * mv2.KVector4.Scalar2345;
            }
            
        }
        
        return Ga401Multivector.Create(tempScalar);
    }
    
}
