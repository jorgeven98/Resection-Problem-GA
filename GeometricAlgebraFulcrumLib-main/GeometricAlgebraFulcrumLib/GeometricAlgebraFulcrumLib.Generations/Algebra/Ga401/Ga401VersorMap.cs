using System.Runtime.CompilerServices;

namespace GeometricAlgebraFulcrumLib.Generations.Algebra.Ga401;

public static class Ga401VersorMap
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector0 MapUsingVersor(this Ga401KVector0 mv1, Ga401KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector0.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector0
        {
            Scalar = (mv2.Scalar * mv1.Scalar * mv2.Scalar) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector0 MapUsingVersor(this Ga401KVector0 mv1, Ga401KVector1 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector0.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector0
        {
            Scalar = (mv2.Scalar2 * mv1.Scalar * mv2.Scalar2 + mv2.Scalar3 * mv1.Scalar * mv2.Scalar3 + mv2.Scalar4 * mv1.Scalar * mv2.Scalar4 + mv2.Scalar5 * mv1.Scalar * mv2.Scalar5) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector0 MapUsingVersor(this Ga401KVector0 mv1, Ga401KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector0.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector0
        {
            Scalar = (mv2.Scalar23 * mv1.Scalar * mv2.Scalar23 + mv2.Scalar24 * mv1.Scalar * mv2.Scalar24 + mv2.Scalar34 * mv1.Scalar * mv2.Scalar34 + mv2.Scalar25 * mv1.Scalar * mv2.Scalar25 + mv2.Scalar35 * mv1.Scalar * mv2.Scalar35 + mv2.Scalar45 * mv1.Scalar * mv2.Scalar45) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector0 MapUsingVersor(this Ga401KVector0 mv1, Ga401KVector3 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector0.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector0
        {
            Scalar = (mv2.Scalar234 * mv1.Scalar * mv2.Scalar234 + mv2.Scalar235 * mv1.Scalar * mv2.Scalar235 + mv2.Scalar245 * mv1.Scalar * mv2.Scalar245 + mv2.Scalar345 * mv1.Scalar * mv2.Scalar345) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector0 MapUsingVersor(this Ga401KVector0 mv1, Ga401KVector4 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector0.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector0
        {
            Scalar = (mv2.Scalar2345 * mv1.Scalar * mv2.Scalar2345) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector0 MapUsingVersor(this Ga401KVector0 mv1, Ga401KVector5 mv2)
    {
        return Ga401KVector0.Zero;
    }
    
    public static Ga401KVector0 MapUsingEvenVersor(this Ga401KVector0 mv1, Ga401Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector0.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
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
            Scalar = (tempScalar) * mv2NormSquaredInv
        };
    }
    
    public static Ga401KVector0 MapUsingOddVersor(this Ga401KVector0 mv1, Ga401Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector0.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        var tempScalar = 0d;
        
        if (!mv2.KVector1.IsZero())
        {
            tempScalar += mv2.KVector1.Scalar2 * mv1.Scalar * mv2.KVector1.Scalar2 + mv2.KVector1.Scalar3 * mv1.Scalar * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar4 * mv1.Scalar * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar5 * mv1.Scalar * mv2.KVector1.Scalar5;
        }
        
        if (!mv2.KVector3.IsZero())
        {
            tempScalar += mv2.KVector3.Scalar234 * mv1.Scalar * mv2.KVector3.Scalar234 + mv2.KVector3.Scalar235 * mv1.Scalar * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar245 * mv1.Scalar * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar345 * mv1.Scalar * mv2.KVector3.Scalar345;
        }
        
        return new Ga401KVector0
        {
            Scalar = (tempScalar) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector1 MapUsingVersor(this Ga401KVector1 mv1, Ga401KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector1.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector1
        {
            Scalar1 = (mv2.Scalar * mv1.Scalar1 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar2 = (mv2.Scalar * mv1.Scalar2 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar3 = (mv2.Scalar * mv1.Scalar3 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar4 = (mv2.Scalar * mv1.Scalar4 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar5 = (mv2.Scalar * mv1.Scalar5 * mv2.Scalar) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector1 MapUsingVersor(this Ga401KVector1 mv1, Ga401KVector1 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector1.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector1
        {
            Scalar1 = (-2 * mv2.Scalar1 * mv1.Scalar2 * mv2.Scalar2 - 2 * mv2.Scalar1 * mv1.Scalar3 * mv2.Scalar3 - 2 * mv2.Scalar1 * mv1.Scalar4 * mv2.Scalar4 - 2 * mv2.Scalar1 * mv1.Scalar5 * mv2.Scalar5 + mv2.Scalar2 * mv1.Scalar1 * mv2.Scalar2 + mv2.Scalar3 * mv1.Scalar1 * mv2.Scalar3 + mv2.Scalar4 * mv1.Scalar1 * mv2.Scalar4 + mv2.Scalar5 * mv1.Scalar1 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar2 = (-mv2.Scalar2 * mv1.Scalar2 * mv2.Scalar2 - 2 * mv2.Scalar2 * mv1.Scalar3 * mv2.Scalar3 - 2 * mv2.Scalar2 * mv1.Scalar4 * mv2.Scalar4 - 2 * mv2.Scalar2 * mv1.Scalar5 * mv2.Scalar5 + mv2.Scalar3 * mv1.Scalar2 * mv2.Scalar3 + mv2.Scalar4 * mv1.Scalar2 * mv2.Scalar4 + mv2.Scalar5 * mv1.Scalar2 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar3 = (-2 * mv2.Scalar2 * mv1.Scalar2 * mv2.Scalar3 + mv2.Scalar2 * mv1.Scalar3 * mv2.Scalar2 - mv2.Scalar3 * mv1.Scalar3 * mv2.Scalar3 - 2 * mv2.Scalar3 * mv1.Scalar4 * mv2.Scalar4 - 2 * mv2.Scalar3 * mv1.Scalar5 * mv2.Scalar5 + mv2.Scalar4 * mv1.Scalar3 * mv2.Scalar4 + mv2.Scalar5 * mv1.Scalar3 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar4 = (-2 * mv2.Scalar2 * mv1.Scalar2 * mv2.Scalar4 + mv2.Scalar2 * mv1.Scalar4 * mv2.Scalar2 - 2 * mv2.Scalar3 * mv1.Scalar3 * mv2.Scalar4 + mv2.Scalar3 * mv1.Scalar4 * mv2.Scalar3 - mv2.Scalar4 * mv1.Scalar4 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.Scalar5 * mv2.Scalar5 + mv2.Scalar5 * mv1.Scalar4 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar5 = (-2 * mv2.Scalar2 * mv1.Scalar2 * mv2.Scalar5 + mv2.Scalar2 * mv1.Scalar5 * mv2.Scalar2 - 2 * mv2.Scalar3 * mv1.Scalar3 * mv2.Scalar5 + mv2.Scalar3 * mv1.Scalar5 * mv2.Scalar3 - 2 * mv2.Scalar4 * mv1.Scalar4 * mv2.Scalar5 + mv2.Scalar4 * mv1.Scalar5 * mv2.Scalar4 - mv2.Scalar5 * mv1.Scalar5 * mv2.Scalar5) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector1 MapUsingVersor(this Ga401KVector1 mv1, Ga401KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector1.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector1
        {
            Scalar1 = (2 * mv2.Scalar12 * mv1.Scalar3 * mv2.Scalar23 + 2 * mv2.Scalar12 * mv1.Scalar4 * mv2.Scalar24 + 2 * mv2.Scalar12 * mv1.Scalar5 * mv2.Scalar25 + 2 * mv2.Scalar13 * mv1.Scalar2 * mv2.Scalar23 + 2 * mv2.Scalar13 * mv1.Scalar4 * mv2.Scalar34 + 2 * mv2.Scalar13 * mv1.Scalar5 * mv2.Scalar35 + mv2.Scalar23 * mv1.Scalar1 * mv2.Scalar23 + 2 * mv2.Scalar14 * mv1.Scalar2 * mv2.Scalar24 + 2 * mv2.Scalar14 * mv1.Scalar3 * mv2.Scalar34 + 2 * mv2.Scalar14 * mv1.Scalar5 * mv2.Scalar45 + mv2.Scalar24 * mv1.Scalar1 * mv2.Scalar24 + mv2.Scalar34 * mv1.Scalar1 * mv2.Scalar34 + 2 * mv2.Scalar15 * mv1.Scalar2 * mv2.Scalar25 + 2 * mv2.Scalar15 * mv1.Scalar3 * mv2.Scalar35 + 2 * mv2.Scalar15 * mv1.Scalar4 * mv2.Scalar45 + mv2.Scalar25 * mv1.Scalar1 * mv2.Scalar25 + mv2.Scalar35 * mv1.Scalar1 * mv2.Scalar35 + mv2.Scalar45 * mv1.Scalar1 * mv2.Scalar45) * mv2NormSquaredInv,
            Scalar2 = (mv2.Scalar23 * mv1.Scalar2 * mv2.Scalar23 + 2 * mv2.Scalar23 * mv1.Scalar4 * mv2.Scalar34 + 2 * mv2.Scalar23 * mv1.Scalar5 * mv2.Scalar35 + mv2.Scalar24 * mv1.Scalar2 * mv2.Scalar24 + mv2.Scalar34 * mv1.Scalar2 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.Scalar3 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.Scalar5 * mv2.Scalar45 + mv2.Scalar25 * mv1.Scalar2 * mv2.Scalar25 + mv2.Scalar35 * mv1.Scalar2 * mv2.Scalar35 + mv2.Scalar45 * mv1.Scalar2 * mv2.Scalar45 + 2 * mv2.Scalar25 * mv1.Scalar3 * mv2.Scalar35 + 2 * mv2.Scalar25 * mv1.Scalar4 * mv2.Scalar45) * mv2NormSquaredInv,
            Scalar3 = (mv2.Scalar34 * mv1.Scalar3 * mv2.Scalar34 + mv2.Scalar35 * mv1.Scalar3 * mv2.Scalar35 - mv2.Scalar23 * mv1.Scalar3 * mv2.Scalar23 - mv2.Scalar24 * mv1.Scalar3 * mv2.Scalar24 - mv2.Scalar25 * mv1.Scalar3 * mv2.Scalar25 - 2 * mv2.Scalar23 * mv1.Scalar4 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar5 * mv2.Scalar25 + 2 * mv2.Scalar34 * mv1.Scalar5 * mv2.Scalar45 + mv2.Scalar45 * mv1.Scalar3 * mv2.Scalar45 + 2 * mv2.Scalar35 * mv1.Scalar4 * mv2.Scalar45) * mv2NormSquaredInv,
            Scalar4 = (mv2.Scalar23 * mv1.Scalar4 * mv2.Scalar23 - mv2.Scalar24 * mv1.Scalar4 * mv2.Scalar24 - mv2.Scalar25 * mv1.Scalar4 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.Scalar5 * mv2.Scalar25 + mv2.Scalar45 * mv1.Scalar4 * mv2.Scalar45 - mv2.Scalar34 * mv1.Scalar4 * mv2.Scalar34 - mv2.Scalar35 * mv1.Scalar4 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.Scalar5 * mv2.Scalar35) * mv2NormSquaredInv,
            Scalar5 = (mv2.Scalar23 * mv1.Scalar5 * mv2.Scalar23 - mv2.Scalar45 * mv1.Scalar5 * mv2.Scalar45 + mv2.Scalar24 * mv1.Scalar5 * mv2.Scalar24 + mv2.Scalar34 * mv1.Scalar5 * mv2.Scalar34 - mv2.Scalar25 * mv1.Scalar5 * mv2.Scalar25 - mv2.Scalar35 * mv1.Scalar5 * mv2.Scalar35) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector1 MapUsingVersor(this Ga401KVector1 mv1, Ga401KVector3 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector1.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector1
        {
            Scalar1 = (2 * mv2.Scalar123 * mv1.Scalar4 * mv2.Scalar234 + 2 * mv2.Scalar123 * mv1.Scalar5 * mv2.Scalar235 + 2 * mv2.Scalar124 * mv1.Scalar3 * mv2.Scalar234 + 2 * mv2.Scalar124 * mv1.Scalar5 * mv2.Scalar245 + 2 * mv2.Scalar134 * mv1.Scalar2 * mv2.Scalar234 + 2 * mv2.Scalar134 * mv1.Scalar5 * mv2.Scalar345 + mv2.Scalar234 * mv1.Scalar1 * mv2.Scalar234 + 2 * mv2.Scalar125 * mv1.Scalar3 * mv2.Scalar235 + 2 * mv2.Scalar125 * mv1.Scalar4 * mv2.Scalar245 + 2 * mv2.Scalar135 * mv1.Scalar2 * mv2.Scalar235 + 2 * mv2.Scalar135 * mv1.Scalar4 * mv2.Scalar345 + mv2.Scalar235 * mv1.Scalar1 * mv2.Scalar235 + 2 * mv2.Scalar145 * mv1.Scalar2 * mv2.Scalar245 + 2 * mv2.Scalar145 * mv1.Scalar3 * mv2.Scalar345 + mv2.Scalar245 * mv1.Scalar1 * mv2.Scalar245 + mv2.Scalar345 * mv1.Scalar1 * mv2.Scalar345) * mv2NormSquaredInv,
            Scalar2 = (mv2.Scalar234 * mv1.Scalar2 * mv2.Scalar234 + 2 * mv2.Scalar245 * mv1.Scalar3 * mv2.Scalar345 + 2 * mv2.Scalar234 * mv1.Scalar5 * mv2.Scalar345 + mv2.Scalar235 * mv1.Scalar2 * mv2.Scalar235 + 2 * mv2.Scalar235 * mv1.Scalar4 * mv2.Scalar345 + mv2.Scalar245 * mv1.Scalar2 * mv2.Scalar245 + mv2.Scalar345 * mv1.Scalar2 * mv2.Scalar345) * mv2NormSquaredInv,
            Scalar3 = (-mv2.Scalar234 * mv1.Scalar3 * mv2.Scalar234 - 2 * mv2.Scalar234 * mv1.Scalar5 * mv2.Scalar245 + mv2.Scalar345 * mv1.Scalar3 * mv2.Scalar345 - mv2.Scalar235 * mv1.Scalar3 * mv2.Scalar235 - mv2.Scalar245 * mv1.Scalar3 * mv2.Scalar245 - 2 * mv2.Scalar235 * mv1.Scalar4 * mv2.Scalar245) * mv2NormSquaredInv,
            Scalar4 = (-mv2.Scalar345 * mv1.Scalar4 * mv2.Scalar345 + mv2.Scalar234 * mv1.Scalar4 * mv2.Scalar234 + mv2.Scalar235 * mv1.Scalar4 * mv2.Scalar235 + 2 * mv2.Scalar234 * mv1.Scalar5 * mv2.Scalar235 - mv2.Scalar245 * mv1.Scalar4 * mv2.Scalar245) * mv2NormSquaredInv,
            Scalar5 = (-mv2.Scalar234 * mv1.Scalar5 * mv2.Scalar234 + mv2.Scalar235 * mv1.Scalar5 * mv2.Scalar235 + mv2.Scalar245 * mv1.Scalar5 * mv2.Scalar245 + mv2.Scalar345 * mv1.Scalar5 * mv2.Scalar345) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector1 MapUsingVersor(this Ga401KVector1 mv1, Ga401KVector4 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector1.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector1
        {
            Scalar1 = (2 * mv2.Scalar1234 * mv1.Scalar5 * mv2.Scalar2345 - 2 * mv2.Scalar1235 * mv1.Scalar4 * mv2.Scalar2345 + 2 * mv2.Scalar1245 * mv1.Scalar3 * mv2.Scalar2345 - 2 * mv2.Scalar1345 * mv1.Scalar2 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.Scalar1 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar2 = (-mv2.Scalar2345 * mv1.Scalar2 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar3 = (-mv2.Scalar2345 * mv1.Scalar3 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar4 = (-mv2.Scalar2345 * mv1.Scalar4 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar5 = (-mv2.Scalar2345 * mv1.Scalar5 * mv2.Scalar2345) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector1 MapUsingVersor(this Ga401KVector1 mv1, Ga401KVector5 mv2)
    {
        return Ga401KVector1.Zero;
    }
    
    public static Ga401KVector1 MapUsingEvenVersor(this Ga401KVector1 mv1, Ga401Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector1.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
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
            Scalar1 = (tempScalar0) * mv2NormSquaredInv,
            Scalar2 = (tempScalar1) * mv2NormSquaredInv,
            Scalar3 = (tempScalar2) * mv2NormSquaredInv,
            Scalar4 = (tempScalar3) * mv2NormSquaredInv,
            Scalar5 = (tempScalar4) * mv2NormSquaredInv
        };
    }
    
    public static Ga401KVector1 MapUsingOddVersor(this Ga401KVector1 mv1, Ga401Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector1.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        var tempScalar0 = 0d;
        var tempScalar1 = 0d;
        var tempScalar2 = 0d;
        var tempScalar3 = 0d;
        var tempScalar4 = 0d;
        
        if (!mv2.KVector1.IsZero())
        {
            tempScalar0 += -2 * mv2.KVector1.Scalar1 * mv1.Scalar2 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar1 * mv1.Scalar3 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar1 * mv1.Scalar4 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar1 * mv1.Scalar5 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar2 * mv1.Scalar1 * mv2.KVector1.Scalar2 + mv2.KVector1.Scalar3 * mv1.Scalar1 * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar4 * mv1.Scalar1 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar5 * mv1.Scalar1 * mv2.KVector1.Scalar5;
            tempScalar1 += -mv2.KVector1.Scalar2 * mv1.Scalar2 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar3 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar4 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar5 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar3 * mv1.Scalar2 * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar4 * mv1.Scalar2 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar5 * mv1.Scalar2 * mv2.KVector1.Scalar5;
            tempScalar2 += -2 * mv2.KVector1.Scalar2 * mv1.Scalar2 * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar2 * mv1.Scalar3 * mv2.KVector1.Scalar2 - mv2.KVector1.Scalar3 * mv1.Scalar3 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar4 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar5 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar4 * mv1.Scalar3 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar5 * mv1.Scalar3 * mv2.KVector1.Scalar5;
            tempScalar3 += -2 * mv2.KVector1.Scalar2 * mv1.Scalar2 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar2 * mv1.Scalar4 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar3 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar3 * mv1.Scalar4 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.Scalar4 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar5 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar5 * mv1.Scalar4 * mv2.KVector1.Scalar5;
            tempScalar4 += -2 * mv2.KVector1.Scalar2 * mv1.Scalar2 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar2 * mv1.Scalar5 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar3 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar3 * mv1.Scalar5 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar4 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar4 * mv1.Scalar5 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.Scalar5 * mv2.KVector1.Scalar5;
        }
        
        if (!mv2.KVector1.IsZero() && !mv2.KVector3.IsZero())
        {
            tempScalar0 += 2 * mv2.KVector1.Scalar3 * mv1.Scalar2 * mv2.KVector3.Scalar123 + 2 * mv2.KVector1.Scalar4 * mv1.Scalar2 * mv2.KVector3.Scalar124 + 2 * mv2.KVector1.Scalar4 * mv1.Scalar3 * mv2.KVector3.Scalar134 + 2 * mv2.KVector1.Scalar5 * mv1.Scalar2 * mv2.KVector3.Scalar125 + 2 * mv2.KVector1.Scalar5 * mv1.Scalar3 * mv2.KVector3.Scalar135 + 2 * mv2.KVector1.Scalar5 * mv1.Scalar4 * mv2.KVector3.Scalar145;
            tempScalar1 += 2 * mv2.KVector1.Scalar4 * mv1.Scalar3 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar5 * mv1.Scalar3 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar5 * mv1.Scalar4 * mv2.KVector3.Scalar245;
            tempScalar2 += -2 * mv2.KVector1.Scalar4 * mv1.Scalar2 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar5 * mv1.Scalar2 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar5 * mv1.Scalar4 * mv2.KVector3.Scalar345;
            tempScalar3 += 2 * mv2.KVector1.Scalar3 * mv1.Scalar2 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar5 * mv1.Scalar2 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar5 * mv1.Scalar3 * mv2.KVector3.Scalar345;
            tempScalar4 += 2 * mv2.KVector1.Scalar3 * mv1.Scalar2 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar4 * mv1.Scalar2 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar4 * mv1.Scalar3 * mv2.KVector3.Scalar345;
        }
        
        if (!mv2.KVector3.IsZero())
        {
            tempScalar0 += 2 * mv2.KVector3.Scalar123 * mv1.Scalar4 * mv2.KVector3.Scalar234 + 2 * mv2.KVector3.Scalar124 * mv1.Scalar5 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar135 * mv1.Scalar2 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar145 * mv1.Scalar2 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar345 * mv1.Scalar1 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar134 * mv1.Scalar5 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar235 * mv1.Scalar1 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar123 * mv1.Scalar5 * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar245 * mv1.Scalar1 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar124 * mv1.Scalar3 * mv2.KVector3.Scalar234 + 2 * mv2.KVector3.Scalar134 * mv1.Scalar2 * mv2.KVector3.Scalar234 + mv2.KVector3.Scalar234 * mv1.Scalar1 * mv2.KVector3.Scalar234 + 2 * mv2.KVector3.Scalar125 * mv1.Scalar3 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar125 * mv1.Scalar4 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar135 * mv1.Scalar4 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar145 * mv1.Scalar3 * mv2.KVector3.Scalar345;
            tempScalar1 += mv2.KVector3.Scalar234 * mv1.Scalar2 * mv2.KVector3.Scalar234 + 2 * mv2.KVector3.Scalar245 * mv1.Scalar3 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar234 * mv1.Scalar5 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar235 * mv1.Scalar2 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar235 * mv1.Scalar4 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar245 * mv1.Scalar2 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar345 * mv1.Scalar2 * mv2.KVector3.Scalar345;
            tempScalar2 += -mv2.KVector3.Scalar234 * mv1.Scalar3 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar235 * mv1.Scalar3 * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar345 * mv1.Scalar3 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar234 * mv1.Scalar5 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar245 * mv1.Scalar3 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar235 * mv1.Scalar4 * mv2.KVector3.Scalar245;
            tempScalar3 += mv2.KVector3.Scalar235 * mv1.Scalar4 * mv2.KVector3.Scalar235 - mv2.KVector3.Scalar245 * mv1.Scalar4 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar234 * mv1.Scalar4 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar345 * mv1.Scalar4 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar234 * mv1.Scalar5 * mv2.KVector3.Scalar235;
            tempScalar4 += mv2.KVector3.Scalar235 * mv1.Scalar5 * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar245 * mv1.Scalar5 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar345 * mv1.Scalar5 * mv2.KVector3.Scalar345 - mv2.KVector3.Scalar234 * mv1.Scalar5 * mv2.KVector3.Scalar234;
        }
        
        if (!mv2.KVector3.IsZero() && !mv2.KVector5.IsZero())
        {
            tempScalar0 += 2 * mv2.KVector3.Scalar345 * mv1.Scalar2 * mv2.KVector5.Scalar12345 + 2 * mv2.KVector3.Scalar235 * mv1.Scalar4 * mv2.KVector5.Scalar12345;
        }
        
        return new Ga401KVector1
        {
            Scalar1 = (tempScalar0) * mv2NormSquaredInv,
            Scalar2 = (tempScalar1) * mv2NormSquaredInv,
            Scalar3 = (tempScalar2) * mv2NormSquaredInv,
            Scalar4 = (tempScalar3) * mv2NormSquaredInv,
            Scalar5 = (tempScalar4) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector2 MapUsingVersor(this Ga401KVector2 mv1, Ga401KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector2.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector2
        {
            Scalar12 = (mv2.Scalar * mv1.Scalar12 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar13 = (mv2.Scalar * mv1.Scalar13 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar23 = (mv2.Scalar * mv1.Scalar23 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar14 = (mv2.Scalar * mv1.Scalar14 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar24 = (mv2.Scalar * mv1.Scalar24 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar34 = (mv2.Scalar * mv1.Scalar34 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar15 = (mv2.Scalar * mv1.Scalar15 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar25 = (mv2.Scalar * mv1.Scalar25 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar35 = (mv2.Scalar * mv1.Scalar35 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar45 = (mv2.Scalar * mv1.Scalar45 * mv2.Scalar) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector2 MapUsingVersor(this Ga401KVector2 mv1, Ga401KVector1 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector2.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector2
        {
            Scalar12 = (2 * mv2.Scalar1 * mv1.Scalar23 * mv2.Scalar3 + 2 * mv2.Scalar1 * mv1.Scalar24 * mv2.Scalar4 + 2 * mv2.Scalar1 * mv1.Scalar25 * mv2.Scalar5 - mv2.Scalar2 * mv1.Scalar12 * mv2.Scalar2 - 2 * mv2.Scalar2 * mv1.Scalar13 * mv2.Scalar3 - 2 * mv2.Scalar2 * mv1.Scalar14 * mv2.Scalar4 - 2 * mv2.Scalar2 * mv1.Scalar15 * mv2.Scalar5 + mv2.Scalar3 * mv1.Scalar12 * mv2.Scalar3 + mv2.Scalar4 * mv1.Scalar12 * mv2.Scalar4 + mv2.Scalar5 * mv1.Scalar12 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar13 = (-2 * mv2.Scalar1 * mv1.Scalar23 * mv2.Scalar2 + 2 * mv2.Scalar1 * mv1.Scalar34 * mv2.Scalar4 + 2 * mv2.Scalar1 * mv1.Scalar35 * mv2.Scalar5 - 2 * mv2.Scalar2 * mv1.Scalar12 * mv2.Scalar3 + mv2.Scalar2 * mv1.Scalar13 * mv2.Scalar2 - mv2.Scalar3 * mv1.Scalar13 * mv2.Scalar3 - 2 * mv2.Scalar3 * mv1.Scalar14 * mv2.Scalar4 - 2 * mv2.Scalar3 * mv1.Scalar15 * mv2.Scalar5 + mv2.Scalar4 * mv1.Scalar13 * mv2.Scalar4 + mv2.Scalar5 * mv1.Scalar13 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar23 = (-mv2.Scalar2 * mv1.Scalar23 * mv2.Scalar2 + 2 * mv2.Scalar2 * mv1.Scalar34 * mv2.Scalar4 + 2 * mv2.Scalar2 * mv1.Scalar35 * mv2.Scalar5 - mv2.Scalar3 * mv1.Scalar23 * mv2.Scalar3 - 2 * mv2.Scalar3 * mv1.Scalar24 * mv2.Scalar4 - 2 * mv2.Scalar3 * mv1.Scalar25 * mv2.Scalar5 + mv2.Scalar4 * mv1.Scalar23 * mv2.Scalar4 + mv2.Scalar5 * mv1.Scalar23 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar14 = (-2 * mv2.Scalar1 * mv1.Scalar24 * mv2.Scalar2 - 2 * mv2.Scalar1 * mv1.Scalar34 * mv2.Scalar3 + 2 * mv2.Scalar1 * mv1.Scalar45 * mv2.Scalar5 - 2 * mv2.Scalar2 * mv1.Scalar12 * mv2.Scalar4 + mv2.Scalar2 * mv1.Scalar14 * mv2.Scalar2 - 2 * mv2.Scalar3 * mv1.Scalar13 * mv2.Scalar4 + mv2.Scalar3 * mv1.Scalar14 * mv2.Scalar3 - mv2.Scalar4 * mv1.Scalar14 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.Scalar15 * mv2.Scalar5 + mv2.Scalar5 * mv1.Scalar14 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar24 = (-mv2.Scalar2 * mv1.Scalar24 * mv2.Scalar2 - 2 * mv2.Scalar2 * mv1.Scalar34 * mv2.Scalar3 + 2 * mv2.Scalar2 * mv1.Scalar45 * mv2.Scalar5 - 2 * mv2.Scalar3 * mv1.Scalar23 * mv2.Scalar4 + mv2.Scalar3 * mv1.Scalar24 * mv2.Scalar3 - mv2.Scalar4 * mv1.Scalar24 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.Scalar25 * mv2.Scalar5 + mv2.Scalar5 * mv1.Scalar24 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar34 = (2 * mv2.Scalar2 * mv1.Scalar23 * mv2.Scalar4 - 2 * mv2.Scalar2 * mv1.Scalar24 * mv2.Scalar3 + mv2.Scalar2 * mv1.Scalar34 * mv2.Scalar2 - mv2.Scalar3 * mv1.Scalar34 * mv2.Scalar3 + 2 * mv2.Scalar3 * mv1.Scalar45 * mv2.Scalar5 - mv2.Scalar4 * mv1.Scalar34 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.Scalar35 * mv2.Scalar5 + mv2.Scalar5 * mv1.Scalar34 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar15 = (-2 * mv2.Scalar1 * mv1.Scalar25 * mv2.Scalar2 - 2 * mv2.Scalar1 * mv1.Scalar35 * mv2.Scalar3 - 2 * mv2.Scalar1 * mv1.Scalar45 * mv2.Scalar4 - 2 * mv2.Scalar2 * mv1.Scalar12 * mv2.Scalar5 + mv2.Scalar2 * mv1.Scalar15 * mv2.Scalar2 - 2 * mv2.Scalar3 * mv1.Scalar13 * mv2.Scalar5 + mv2.Scalar3 * mv1.Scalar15 * mv2.Scalar3 - 2 * mv2.Scalar4 * mv1.Scalar14 * mv2.Scalar5 + mv2.Scalar4 * mv1.Scalar15 * mv2.Scalar4 - mv2.Scalar5 * mv1.Scalar15 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar25 = (-mv2.Scalar2 * mv1.Scalar25 * mv2.Scalar2 - 2 * mv2.Scalar2 * mv1.Scalar35 * mv2.Scalar3 - 2 * mv2.Scalar2 * mv1.Scalar45 * mv2.Scalar4 - 2 * mv2.Scalar3 * mv1.Scalar23 * mv2.Scalar5 + mv2.Scalar3 * mv1.Scalar25 * mv2.Scalar3 - 2 * mv2.Scalar4 * mv1.Scalar24 * mv2.Scalar5 + mv2.Scalar4 * mv1.Scalar25 * mv2.Scalar4 - mv2.Scalar5 * mv1.Scalar25 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar35 = (2 * mv2.Scalar2 * mv1.Scalar23 * mv2.Scalar5 - 2 * mv2.Scalar2 * mv1.Scalar25 * mv2.Scalar3 + mv2.Scalar2 * mv1.Scalar35 * mv2.Scalar2 - mv2.Scalar3 * mv1.Scalar35 * mv2.Scalar3 - 2 * mv2.Scalar3 * mv1.Scalar45 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.Scalar34 * mv2.Scalar5 + mv2.Scalar4 * mv1.Scalar35 * mv2.Scalar4 - mv2.Scalar5 * mv1.Scalar35 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar45 = (2 * mv2.Scalar2 * mv1.Scalar24 * mv2.Scalar5 - 2 * mv2.Scalar2 * mv1.Scalar25 * mv2.Scalar4 + mv2.Scalar2 * mv1.Scalar45 * mv2.Scalar2 + 2 * mv2.Scalar3 * mv1.Scalar34 * mv2.Scalar5 - 2 * mv2.Scalar3 * mv1.Scalar35 * mv2.Scalar4 + mv2.Scalar3 * mv1.Scalar45 * mv2.Scalar3 - mv2.Scalar4 * mv1.Scalar45 * mv2.Scalar4 - mv2.Scalar5 * mv1.Scalar45 * mv2.Scalar5) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector2 MapUsingVersor(this Ga401KVector2 mv1, Ga401KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector2.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector2
        {
            Scalar12 = (2 * mv2.Scalar25 * mv1.Scalar14 * mv2.Scalar45 + mv2.Scalar23 * mv1.Scalar12 * mv2.Scalar23 + 2 * mv2.Scalar23 * mv1.Scalar14 * mv2.Scalar34 + 2 * mv2.Scalar23 * mv1.Scalar15 * mv2.Scalar35 + mv2.Scalar24 * mv1.Scalar12 * mv2.Scalar24 + mv2.Scalar34 * mv1.Scalar12 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.Scalar13 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.Scalar15 * mv2.Scalar45 + mv2.Scalar25 * mv1.Scalar12 * mv2.Scalar25 + mv2.Scalar35 * mv1.Scalar12 * mv2.Scalar35 + mv2.Scalar45 * mv1.Scalar12 * mv2.Scalar45 + 2 * mv2.Scalar25 * mv1.Scalar13 * mv2.Scalar35) * mv2NormSquaredInv,
            Scalar13 = (2 * mv2.Scalar35 * mv1.Scalar14 * mv2.Scalar45 + 2 * mv2.Scalar12 * mv1.Scalar24 * mv2.Scalar34 + 2 * mv2.Scalar12 * mv1.Scalar25 * mv2.Scalar35 - 2 * mv2.Scalar13 * mv1.Scalar23 * mv2.Scalar23 - 2 * mv2.Scalar13 * mv1.Scalar24 * mv2.Scalar24 - 2 * mv2.Scalar13 * mv1.Scalar25 * mv2.Scalar25 + mv2.Scalar34 * mv1.Scalar13 * mv2.Scalar34 + mv2.Scalar35 * mv1.Scalar13 * mv2.Scalar35 - mv2.Scalar23 * mv1.Scalar13 * mv2.Scalar23 - mv2.Scalar24 * mv1.Scalar13 * mv2.Scalar24 - mv2.Scalar25 * mv1.Scalar13 * mv2.Scalar25 - 2 * mv2.Scalar14 * mv1.Scalar23 * mv2.Scalar24 - 2 * mv2.Scalar15 * mv1.Scalar23 * mv2.Scalar25 - 2 * mv2.Scalar23 * mv1.Scalar14 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar24 * mv2.Scalar14 - 2 * mv2.Scalar23 * mv1.Scalar15 * mv2.Scalar25 - 2 * mv2.Scalar23 * mv1.Scalar25 * mv2.Scalar15 + mv2.Scalar45 * mv1.Scalar13 * mv2.Scalar45 + 2 * mv2.Scalar34 * mv1.Scalar15 * mv2.Scalar45) * mv2NormSquaredInv,
            Scalar23 = (-mv2.Scalar23 * mv1.Scalar23 * mv2.Scalar23 - mv2.Scalar25 * mv1.Scalar23 * mv2.Scalar25 + mv2.Scalar45 * mv1.Scalar23 * mv2.Scalar45 - mv2.Scalar24 * mv1.Scalar23 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar24 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar25 * mv2.Scalar25 + mv2.Scalar34 * mv1.Scalar23 * mv2.Scalar34 + 2 * mv2.Scalar35 * mv1.Scalar24 * mv2.Scalar45 + 2 * mv2.Scalar34 * mv1.Scalar25 * mv2.Scalar45 + mv2.Scalar35 * mv1.Scalar23 * mv2.Scalar35) * mv2NormSquaredInv,
            Scalar14 = (2 * mv2.Scalar12 * mv1.Scalar34 * mv2.Scalar23 + 2 * mv2.Scalar12 * mv1.Scalar25 * mv2.Scalar45 + 2 * mv2.Scalar13 * mv1.Scalar24 * mv2.Scalar23 - 2 * mv2.Scalar15 * mv1.Scalar34 * mv2.Scalar35 + 2 * mv2.Scalar13 * mv1.Scalar35 * mv2.Scalar45 + mv2.Scalar23 * mv1.Scalar14 * mv2.Scalar23 - 2 * mv2.Scalar14 * mv1.Scalar34 * mv2.Scalar34 - 2 * mv2.Scalar14 * mv1.Scalar24 * mv2.Scalar24 - 2 * mv2.Scalar14 * mv1.Scalar25 * mv2.Scalar25 - 2 * mv2.Scalar14 * mv1.Scalar35 * mv2.Scalar35 - mv2.Scalar24 * mv1.Scalar14 * mv2.Scalar24 - mv2.Scalar25 * mv1.Scalar14 * mv2.Scalar25 - 2 * mv2.Scalar15 * mv1.Scalar24 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.Scalar15 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.Scalar25 * mv2.Scalar15 + mv2.Scalar45 * mv1.Scalar14 * mv2.Scalar45 - mv2.Scalar34 * mv1.Scalar14 * mv2.Scalar34 - mv2.Scalar35 * mv1.Scalar14 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.Scalar15 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.Scalar35 * mv2.Scalar15) * mv2NormSquaredInv,
            Scalar24 = (-mv2.Scalar24 * mv1.Scalar24 * mv2.Scalar24 - 2 * mv2.Scalar24 * mv1.Scalar34 * mv2.Scalar34 + mv2.Scalar23 * mv1.Scalar24 * mv2.Scalar23 + 2 * mv2.Scalar23 * mv1.Scalar35 * mv2.Scalar45 - mv2.Scalar35 * mv1.Scalar24 * mv2.Scalar35 - mv2.Scalar34 * mv1.Scalar24 * mv2.Scalar34 - mv2.Scalar25 * mv1.Scalar24 * mv2.Scalar25 - 2 * mv2.Scalar25 * mv1.Scalar34 * mv2.Scalar35 - 2 * mv2.Scalar24 * mv1.Scalar25 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.Scalar35 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.Scalar25 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.Scalar35 * mv2.Scalar25 + mv2.Scalar45 * mv1.Scalar24 * mv2.Scalar45) * mv2NormSquaredInv,
            Scalar34 = (mv2.Scalar25 * mv1.Scalar34 * mv2.Scalar25 + mv2.Scalar24 * mv1.Scalar34 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar23 * mv2.Scalar34 + 2 * mv2.Scalar25 * mv1.Scalar23 * mv2.Scalar45 - mv2.Scalar23 * mv1.Scalar34 * mv2.Scalar23 - mv2.Scalar34 * mv1.Scalar34 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.Scalar35 * mv2.Scalar25 - mv2.Scalar35 * mv1.Scalar34 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.Scalar35 * mv2.Scalar35 + mv2.Scalar45 * mv1.Scalar34 * mv2.Scalar45) * mv2NormSquaredInv,
            Scalar15 = (2 * mv2.Scalar12 * mv1.Scalar35 * mv2.Scalar23 + 2 * mv2.Scalar12 * mv1.Scalar45 * mv2.Scalar24 + 2 * mv2.Scalar13 * mv1.Scalar25 * mv2.Scalar23 + 2 * mv2.Scalar13 * mv1.Scalar45 * mv2.Scalar34 + mv2.Scalar23 * mv1.Scalar15 * mv2.Scalar23 - 2 * mv2.Scalar15 * mv1.Scalar35 * mv2.Scalar35 + 2 * mv2.Scalar14 * mv1.Scalar25 * mv2.Scalar24 + 2 * mv2.Scalar14 * mv1.Scalar35 * mv2.Scalar34 - mv2.Scalar35 * mv1.Scalar15 * mv2.Scalar35 + mv2.Scalar24 * mv1.Scalar15 * mv2.Scalar24 + mv2.Scalar34 * mv1.Scalar15 * mv2.Scalar34 - 2 * mv2.Scalar15 * mv1.Scalar45 * mv2.Scalar45 - mv2.Scalar45 * mv1.Scalar15 * mv2.Scalar45 - 2 * mv2.Scalar15 * mv1.Scalar25 * mv2.Scalar25 - mv2.Scalar25 * mv1.Scalar15 * mv2.Scalar25) * mv2NormSquaredInv,
            Scalar25 = (-mv2.Scalar35 * mv1.Scalar25 * mv2.Scalar35 - 2 * mv2.Scalar25 * mv1.Scalar35 * mv2.Scalar35 + mv2.Scalar23 * mv1.Scalar25 * mv2.Scalar23 - mv2.Scalar25 * mv1.Scalar25 * mv2.Scalar25 + 2 * mv2.Scalar23 * mv1.Scalar45 * mv2.Scalar34 - 2 * mv2.Scalar25 * mv1.Scalar45 * mv2.Scalar45 + mv2.Scalar24 * mv1.Scalar25 * mv2.Scalar24 + mv2.Scalar34 * mv1.Scalar25 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.Scalar35 * mv2.Scalar34 - mv2.Scalar45 * mv1.Scalar25 * mv2.Scalar45) * mv2NormSquaredInv,
            Scalar35 = (2 * mv2.Scalar34 * mv1.Scalar24 * mv2.Scalar25 + mv2.Scalar25 * mv1.Scalar35 * mv2.Scalar25 - mv2.Scalar45 * mv1.Scalar35 * mv2.Scalar45 - 2 * mv2.Scalar23 * mv1.Scalar23 * mv2.Scalar35 - 2 * mv2.Scalar23 * mv1.Scalar24 * mv2.Scalar45 - mv2.Scalar23 * mv1.Scalar35 * mv2.Scalar23 - mv2.Scalar24 * mv1.Scalar35 * mv2.Scalar24 - mv2.Scalar35 * mv1.Scalar35 * mv2.Scalar35 - 2 * mv2.Scalar23 * mv1.Scalar45 * mv2.Scalar24 - 2 * mv2.Scalar35 * mv1.Scalar45 * mv2.Scalar45 - 2 * mv2.Scalar24 * mv1.Scalar23 * mv2.Scalar45 - 2 * mv2.Scalar24 * mv1.Scalar24 * mv2.Scalar35 + mv2.Scalar34 * mv1.Scalar35 * mv2.Scalar34) * mv2NormSquaredInv,
            Scalar45 = (2 * mv2.Scalar23 * mv1.Scalar24 * mv2.Scalar35 + 2 * mv2.Scalar23 * mv1.Scalar34 * mv2.Scalar25 + mv2.Scalar23 * mv1.Scalar45 * mv2.Scalar23 - 2 * mv2.Scalar24 * mv1.Scalar24 * mv2.Scalar45 - mv2.Scalar24 * mv1.Scalar45 * mv2.Scalar24 + mv2.Scalar35 * mv1.Scalar45 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.Scalar34 * mv2.Scalar45 - mv2.Scalar34 * mv1.Scalar45 * mv2.Scalar34 + mv2.Scalar25 * mv1.Scalar45 * mv2.Scalar25 - mv2.Scalar45 * mv1.Scalar45 * mv2.Scalar45) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector2 MapUsingVersor(this Ga401KVector2 mv1, Ga401KVector3 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector2.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector2
        {
            Scalar12 = (mv2.Scalar234 * mv1.Scalar12 * mv2.Scalar234 + 2 * mv2.Scalar245 * mv1.Scalar13 * mv2.Scalar345 + 2 * mv2.Scalar234 * mv1.Scalar15 * mv2.Scalar345 + mv2.Scalar235 * mv1.Scalar12 * mv2.Scalar235 + 2 * mv2.Scalar235 * mv1.Scalar14 * mv2.Scalar345 + mv2.Scalar245 * mv1.Scalar12 * mv2.Scalar245 + mv2.Scalar345 * mv1.Scalar12 * mv2.Scalar345) * mv2NormSquaredInv,
            Scalar13 = (2 * mv2.Scalar124 * mv1.Scalar25 * mv2.Scalar345 - 2 * mv2.Scalar134 * mv1.Scalar23 * mv2.Scalar234 - 2 * mv2.Scalar235 * mv1.Scalar24 * mv2.Scalar145 - 2 * mv2.Scalar134 * mv1.Scalar25 * mv2.Scalar245 - mv2.Scalar234 * mv1.Scalar13 * mv2.Scalar234 - 2 * mv2.Scalar234 * mv1.Scalar15 * mv2.Scalar245 - 2 * mv2.Scalar234 * mv1.Scalar25 * mv2.Scalar145 + 2 * mv2.Scalar125 * mv1.Scalar24 * mv2.Scalar345 - 2 * mv2.Scalar135 * mv1.Scalar23 * mv2.Scalar235 - 2 * mv2.Scalar135 * mv1.Scalar24 * mv2.Scalar245 + mv2.Scalar345 * mv1.Scalar13 * mv2.Scalar345 - mv2.Scalar235 * mv1.Scalar13 * mv2.Scalar235 - mv2.Scalar245 * mv1.Scalar13 * mv2.Scalar245 - 2 * mv2.Scalar145 * mv1.Scalar23 * mv2.Scalar245 - 2 * mv2.Scalar235 * mv1.Scalar14 * mv2.Scalar245) * mv2NormSquaredInv,
            Scalar23 = (-mv2.Scalar234 * mv1.Scalar23 * mv2.Scalar234 + mv2.Scalar345 * mv1.Scalar23 * mv2.Scalar345 - 2 * mv2.Scalar234 * mv1.Scalar25 * mv2.Scalar245 - mv2.Scalar235 * mv1.Scalar23 * mv2.Scalar235 - mv2.Scalar245 * mv1.Scalar23 * mv2.Scalar245 - 2 * mv2.Scalar235 * mv1.Scalar24 * mv2.Scalar245) * mv2NormSquaredInv,
            Scalar14 = (-2 * mv2.Scalar123 * mv1.Scalar25 * mv2.Scalar345 - 2 * mv2.Scalar123 * mv1.Scalar35 * mv2.Scalar245 + 2 * mv2.Scalar124 * mv1.Scalar34 * mv2.Scalar234 - 2 * mv2.Scalar145 * mv1.Scalar34 * mv2.Scalar345 + 2 * mv2.Scalar124 * mv1.Scalar35 * mv2.Scalar235 + 2 * mv2.Scalar134 * mv1.Scalar24 * mv2.Scalar234 + 2 * mv2.Scalar134 * mv1.Scalar25 * mv2.Scalar235 + mv2.Scalar234 * mv1.Scalar14 * mv2.Scalar234 + mv2.Scalar235 * mv1.Scalar14 * mv2.Scalar235 + 2 * mv2.Scalar135 * mv1.Scalar24 * mv2.Scalar235 + 2 * mv2.Scalar125 * mv1.Scalar34 * mv2.Scalar235 + 2 * mv2.Scalar234 * mv1.Scalar15 * mv2.Scalar235 + 2 * mv2.Scalar234 * mv1.Scalar25 * mv2.Scalar135 + 2 * mv2.Scalar234 * mv1.Scalar35 * mv2.Scalar125 - mv2.Scalar345 * mv1.Scalar14 * mv2.Scalar345 - mv2.Scalar245 * mv1.Scalar14 * mv2.Scalar245 - 2 * mv2.Scalar145 * mv1.Scalar24 * mv2.Scalar245) * mv2NormSquaredInv,
            Scalar24 = (mv2.Scalar234 * mv1.Scalar24 * mv2.Scalar234 - mv2.Scalar345 * mv1.Scalar24 * mv2.Scalar345 + mv2.Scalar235 * mv1.Scalar24 * mv2.Scalar235 + 2 * mv2.Scalar234 * mv1.Scalar25 * mv2.Scalar235 - mv2.Scalar245 * mv1.Scalar24 * mv2.Scalar245 - 2 * mv2.Scalar245 * mv1.Scalar34 * mv2.Scalar345) * mv2NormSquaredInv,
            Scalar34 = (-mv2.Scalar234 * mv1.Scalar34 * mv2.Scalar234 - mv2.Scalar235 * mv1.Scalar34 * mv2.Scalar235 - 2 * mv2.Scalar234 * mv1.Scalar35 * mv2.Scalar235 + mv2.Scalar245 * mv1.Scalar34 * mv2.Scalar245 - 2 * mv2.Scalar235 * mv1.Scalar23 * mv2.Scalar345 - mv2.Scalar345 * mv1.Scalar34 * mv2.Scalar345) * mv2NormSquaredInv,
            Scalar15 = (mv2.Scalar245 * mv1.Scalar15 * mv2.Scalar245 - 2 * mv2.Scalar123 * mv1.Scalar45 * mv2.Scalar234 - 2 * mv2.Scalar124 * mv1.Scalar35 * mv2.Scalar234 - 2 * mv2.Scalar134 * mv1.Scalar25 * mv2.Scalar234 - mv2.Scalar234 * mv1.Scalar15 * mv2.Scalar234 + 2 * mv2.Scalar145 * mv1.Scalar35 * mv2.Scalar345 + 2 * mv2.Scalar125 * mv1.Scalar45 * mv2.Scalar245 + 2 * mv2.Scalar135 * mv1.Scalar45 * mv2.Scalar345 + 2 * mv2.Scalar125 * mv1.Scalar35 * mv2.Scalar235 + mv2.Scalar345 * mv1.Scalar15 * mv2.Scalar345 + 2 * mv2.Scalar135 * mv1.Scalar25 * mv2.Scalar235 + mv2.Scalar235 * mv1.Scalar15 * mv2.Scalar235 + 2 * mv2.Scalar145 * mv1.Scalar25 * mv2.Scalar245) * mv2NormSquaredInv,
            Scalar25 = (mv2.Scalar235 * mv1.Scalar25 * mv2.Scalar235 + 2 * mv2.Scalar235 * mv1.Scalar45 * mv2.Scalar345 + mv2.Scalar245 * mv1.Scalar25 * mv2.Scalar245 + mv2.Scalar345 * mv1.Scalar25 * mv2.Scalar345 + 2 * mv2.Scalar245 * mv1.Scalar35 * mv2.Scalar345 - mv2.Scalar234 * mv1.Scalar25 * mv2.Scalar234) * mv2NormSquaredInv,
            Scalar35 = (-mv2.Scalar235 * mv1.Scalar35 * mv2.Scalar235 - 2 * mv2.Scalar235 * mv1.Scalar45 * mv2.Scalar245 + 2 * mv2.Scalar234 * mv1.Scalar23 * mv2.Scalar345 + mv2.Scalar234 * mv1.Scalar35 * mv2.Scalar234 + mv2.Scalar345 * mv1.Scalar35 * mv2.Scalar345 - mv2.Scalar245 * mv1.Scalar35 * mv2.Scalar245) * mv2NormSquaredInv,
            Scalar45 = (mv2.Scalar235 * mv1.Scalar45 * mv2.Scalar235 - 2 * mv2.Scalar234 * mv1.Scalar24 * mv2.Scalar345 - 2 * mv2.Scalar234 * mv1.Scalar34 * mv2.Scalar245 - mv2.Scalar234 * mv1.Scalar45 * mv2.Scalar234 - mv2.Scalar245 * mv1.Scalar45 * mv2.Scalar245 - mv2.Scalar345 * mv1.Scalar45 * mv2.Scalar345) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector2 MapUsingVersor(this Ga401KVector2 mv1, Ga401KVector4 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector2.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector2
        {
            Scalar12 = (2 * mv2.Scalar1234 * mv1.Scalar25 * mv2.Scalar2345 - 2 * mv2.Scalar1235 * mv1.Scalar24 * mv2.Scalar2345 + 2 * mv2.Scalar1245 * mv1.Scalar23 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.Scalar12 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar13 = (2 * mv2.Scalar1234 * mv1.Scalar35 * mv2.Scalar2345 - 2 * mv2.Scalar1235 * mv1.Scalar34 * mv2.Scalar2345 + 2 * mv2.Scalar1345 * mv1.Scalar23 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.Scalar13 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar23 = (mv2.Scalar2345 * mv1.Scalar23 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar14 = (2 * mv2.Scalar1234 * mv1.Scalar45 * mv2.Scalar2345 - 2 * mv2.Scalar1245 * mv1.Scalar34 * mv2.Scalar2345 + 2 * mv2.Scalar1345 * mv1.Scalar24 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.Scalar14 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar24 = (mv2.Scalar2345 * mv1.Scalar24 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar34 = (mv2.Scalar2345 * mv1.Scalar34 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar15 = (2 * mv2.Scalar1235 * mv1.Scalar45 * mv2.Scalar2345 - 2 * mv2.Scalar1245 * mv1.Scalar35 * mv2.Scalar2345 + 2 * mv2.Scalar1345 * mv1.Scalar25 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.Scalar15 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar25 = (mv2.Scalar2345 * mv1.Scalar25 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar35 = (mv2.Scalar2345 * mv1.Scalar35 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar45 = (mv2.Scalar2345 * mv1.Scalar45 * mv2.Scalar2345) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector2 MapUsingVersor(this Ga401KVector2 mv1, Ga401KVector5 mv2)
    {
        return Ga401KVector2.Zero;
    }
    
    public static Ga401KVector2 MapUsingEvenVersor(this Ga401KVector2 mv1, Ga401Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector2.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
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
            Scalar12 = (tempScalar0) * mv2NormSquaredInv,
            Scalar13 = (tempScalar1) * mv2NormSquaredInv,
            Scalar23 = (tempScalar2) * mv2NormSquaredInv,
            Scalar14 = (tempScalar3) * mv2NormSquaredInv,
            Scalar24 = (tempScalar4) * mv2NormSquaredInv,
            Scalar34 = (tempScalar5) * mv2NormSquaredInv,
            Scalar15 = (tempScalar6) * mv2NormSquaredInv,
            Scalar25 = (tempScalar7) * mv2NormSquaredInv,
            Scalar35 = (tempScalar8) * mv2NormSquaredInv,
            Scalar45 = (tempScalar9) * mv2NormSquaredInv
        };
    }
    
    public static Ga401KVector2 MapUsingOddVersor(this Ga401KVector2 mv1, Ga401Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector2.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
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
        
        if (!mv2.KVector1.IsZero())
        {
            tempScalar0 += 2 * mv2.KVector1.Scalar1 * mv1.Scalar23 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar1 * mv1.Scalar24 * mv2.KVector1.Scalar4 + 2 * mv2.KVector1.Scalar1 * mv1.Scalar25 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar2 * mv1.Scalar12 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar13 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar14 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar15 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar3 * mv1.Scalar12 * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar4 * mv1.Scalar12 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar5 * mv1.Scalar12 * mv2.KVector1.Scalar5;
            tempScalar1 += -2 * mv2.KVector1.Scalar1 * mv1.Scalar23 * mv2.KVector1.Scalar2 + 2 * mv2.KVector1.Scalar1 * mv1.Scalar34 * mv2.KVector1.Scalar4 + 2 * mv2.KVector1.Scalar1 * mv1.Scalar35 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar12 * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar2 * mv1.Scalar13 * mv2.KVector1.Scalar2 - mv2.KVector1.Scalar3 * mv1.Scalar13 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar14 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar15 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar4 * mv1.Scalar13 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar5 * mv1.Scalar13 * mv2.KVector1.Scalar5;
            tempScalar2 += -mv2.KVector1.Scalar2 * mv1.Scalar23 * mv2.KVector1.Scalar2 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar34 * mv2.KVector1.Scalar4 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar35 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar3 * mv1.Scalar23 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar24 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar25 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar4 * mv1.Scalar23 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar5 * mv1.Scalar23 * mv2.KVector1.Scalar5;
            tempScalar3 += -2 * mv2.KVector1.Scalar1 * mv1.Scalar24 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar1 * mv1.Scalar34 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar1 * mv1.Scalar45 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar12 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar2 * mv1.Scalar14 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar13 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar3 * mv1.Scalar14 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.Scalar14 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar15 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar5 * mv1.Scalar14 * mv2.KVector1.Scalar5;
            tempScalar4 += -mv2.KVector1.Scalar2 * mv1.Scalar24 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar34 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar45 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar23 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar3 * mv1.Scalar24 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.Scalar24 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar25 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar5 * mv1.Scalar24 * mv2.KVector1.Scalar5;
            tempScalar5 += 2 * mv2.KVector1.Scalar2 * mv1.Scalar23 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar24 * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar2 * mv1.Scalar34 * mv2.KVector1.Scalar2 - mv2.KVector1.Scalar3 * mv1.Scalar34 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar45 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar4 * mv1.Scalar34 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar35 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar5 * mv1.Scalar34 * mv2.KVector1.Scalar5;
            tempScalar6 += -2 * mv2.KVector1.Scalar1 * mv1.Scalar25 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar1 * mv1.Scalar35 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar1 * mv1.Scalar45 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar12 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar2 * mv1.Scalar15 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar13 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar3 * mv1.Scalar15 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar14 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar4 * mv1.Scalar15 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.Scalar15 * mv2.KVector1.Scalar5;
            tempScalar7 += -mv2.KVector1.Scalar2 * mv1.Scalar25 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar35 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar45 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar23 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar3 * mv1.Scalar25 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar5 * mv1.Scalar25 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar24 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar4 * mv1.Scalar25 * mv2.KVector1.Scalar4;
            tempScalar8 += 2 * mv2.KVector1.Scalar2 * mv1.Scalar23 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar25 * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar2 * mv1.Scalar35 * mv2.KVector1.Scalar2 - mv2.KVector1.Scalar3 * mv1.Scalar35 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar45 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar34 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar4 * mv1.Scalar35 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.Scalar35 * mv2.KVector1.Scalar5;
            tempScalar9 += 2 * mv2.KVector1.Scalar2 * mv1.Scalar24 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar25 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar2 * mv1.Scalar45 * mv2.KVector1.Scalar2 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar34 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar35 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar3 * mv1.Scalar45 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.Scalar45 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.Scalar45 * mv2.KVector1.Scalar5;
        }
        
        if (!mv2.KVector1.IsZero() && !mv2.KVector3.IsZero())
        {
            tempScalar0 += 2 * mv2.KVector1.Scalar1 * mv1.Scalar34 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar1 * mv1.Scalar35 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar1 * mv1.Scalar45 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar23 * mv2.KVector3.Scalar123 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar24 * mv2.KVector3.Scalar124 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar34 * mv2.KVector3.Scalar134 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar25 * mv2.KVector3.Scalar125 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar35 * mv2.KVector3.Scalar135 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar45 * mv2.KVector3.Scalar145 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar34 * mv2.KVector3.Scalar124 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar35 * mv2.KVector3.Scalar125 + 2 * mv2.KVector1.Scalar4 * mv1.Scalar13 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar23 * mv2.KVector3.Scalar134 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar45 * mv2.KVector3.Scalar125 + 2 * mv2.KVector1.Scalar5 * mv1.Scalar13 * mv2.KVector3.Scalar235 - 2 * mv2.KVector1.Scalar5 * mv1.Scalar23 * mv2.KVector3.Scalar135 + 2 * mv2.KVector1.Scalar5 * mv1.Scalar14 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar5 * mv1.Scalar24 * mv2.KVector3.Scalar145;
            tempScalar1 += -2 * mv2.KVector1.Scalar1 * mv1.Scalar24 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar1 * mv1.Scalar25 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar1 * mv1.Scalar45 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar24 * mv2.KVector3.Scalar134 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar34 * mv2.KVector3.Scalar124 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar25 * mv2.KVector3.Scalar135 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar35 * mv2.KVector3.Scalar125 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar34 * mv2.KVector3.Scalar134 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar35 * mv2.KVector3.Scalar135 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar45 * mv2.KVector3.Scalar145 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar12 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar4 * mv1.Scalar23 * mv2.KVector3.Scalar124 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar45 * mv2.KVector3.Scalar135 - 2 * mv2.KVector1.Scalar5 * mv1.Scalar12 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar5 * mv1.Scalar23 * mv2.KVector3.Scalar125 + 2 * mv2.KVector1.Scalar5 * mv1.Scalar14 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar5 * mv1.Scalar34 * mv2.KVector3.Scalar145;
            tempScalar2 += -2 * mv2.KVector1.Scalar2 * mv1.Scalar24 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar25 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar45 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar34 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar35 * mv2.KVector3.Scalar235 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar45 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar45 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar5 * mv1.Scalar24 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar5 * mv1.Scalar34 * mv2.KVector3.Scalar245;
            tempScalar3 += 2 * mv2.KVector1.Scalar1 * mv1.Scalar23 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar1 * mv1.Scalar25 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar1 * mv1.Scalar35 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar23 * mv2.KVector3.Scalar134 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar34 * mv2.KVector3.Scalar123 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar25 * mv2.KVector3.Scalar145 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar45 * mv2.KVector3.Scalar125 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar12 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar35 * mv2.KVector3.Scalar145 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar45 * mv2.KVector3.Scalar135 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar45 * mv2.KVector3.Scalar145 - 2 * mv2.KVector1.Scalar5 * mv1.Scalar12 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar5 * mv1.Scalar13 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar5 * mv1.Scalar24 * mv2.KVector3.Scalar125 + 2 * mv2.KVector1.Scalar5 * mv1.Scalar34 * mv2.KVector3.Scalar135;
            tempScalar4 += 2 * mv2.KVector1.Scalar2 * mv1.Scalar23 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar25 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar35 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar35 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar45 * mv2.KVector3.Scalar235 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar45 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar5 * mv1.Scalar23 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar5 * mv1.Scalar34 * mv2.KVector3.Scalar235;
            tempScalar5 += -2 * mv2.KVector1.Scalar2 * mv1.Scalar25 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar35 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar45 * mv2.KVector3.Scalar235 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar35 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar45 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar5 * mv1.Scalar23 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar5 * mv1.Scalar24 * mv2.KVector3.Scalar235;
            tempScalar6 += 2 * mv2.KVector1.Scalar1 * mv1.Scalar23 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar1 * mv1.Scalar24 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar1 * mv1.Scalar34 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar23 * mv2.KVector3.Scalar135 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar24 * mv2.KVector3.Scalar145 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar35 * mv2.KVector3.Scalar123 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar45 * mv2.KVector3.Scalar124 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar12 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar34 * mv2.KVector3.Scalar145 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar45 * mv2.KVector3.Scalar134 + 2 * mv2.KVector1.Scalar4 * mv1.Scalar12 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar4 * mv1.Scalar13 * mv2.KVector3.Scalar345;
            tempScalar7 += 2 * mv2.KVector1.Scalar2 * mv1.Scalar23 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar24 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar34 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar34 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar45 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar4 * mv1.Scalar23 * mv2.KVector3.Scalar345;
            tempScalar8 += 2 * mv2.KVector1.Scalar2 * mv1.Scalar24 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar34 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar45 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar34 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar23 * mv2.KVector3.Scalar245;
            tempScalar9 += -2 * mv2.KVector1.Scalar2 * mv1.Scalar23 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar34 * mv2.KVector3.Scalar235 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar35 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar4 * mv1.Scalar23 * mv2.KVector3.Scalar235;
        }
        
        if (!mv2.KVector1.IsZero() && !mv2.KVector5.IsZero())
        {
            tempScalar0 += -2 * mv2.KVector1.Scalar3 * mv1.Scalar45 * mv2.KVector5.Scalar12345 + 2 * mv2.KVector1.Scalar4 * mv1.Scalar35 * mv2.KVector5.Scalar12345 - 2 * mv2.KVector1.Scalar5 * mv1.Scalar34 * mv2.KVector5.Scalar12345;
            tempScalar1 += 2 * mv2.KVector1.Scalar2 * mv1.Scalar45 * mv2.KVector5.Scalar12345 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar25 * mv2.KVector5.Scalar12345 + 2 * mv2.KVector1.Scalar5 * mv1.Scalar24 * mv2.KVector5.Scalar12345;
            tempScalar3 += -2 * mv2.KVector1.Scalar2 * mv1.Scalar35 * mv2.KVector5.Scalar12345 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar25 * mv2.KVector5.Scalar12345 - 2 * mv2.KVector1.Scalar5 * mv1.Scalar23 * mv2.KVector5.Scalar12345;
            tempScalar6 += 2 * mv2.KVector1.Scalar2 * mv1.Scalar34 * mv2.KVector5.Scalar12345 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar24 * mv2.KVector5.Scalar12345 + 2 * mv2.KVector1.Scalar4 * mv1.Scalar23 * mv2.KVector5.Scalar12345;
        }
        
        if (!mv2.KVector3.IsZero() && !mv2.KVector1.IsZero())
        {
            tempScalar3 += -2 * mv2.KVector3.Scalar123 * mv1.Scalar23 * mv2.KVector1.Scalar4;
            tempScalar6 += -2 * mv2.KVector3.Scalar123 * mv1.Scalar23 * mv2.KVector1.Scalar5 - 2 * mv2.KVector3.Scalar124 * mv1.Scalar24 * mv2.KVector1.Scalar5 - 2 * mv2.KVector3.Scalar134 * mv1.Scalar34 * mv2.KVector1.Scalar5;
            tempScalar7 += -2 * mv2.KVector3.Scalar234 * mv1.Scalar34 * mv2.KVector1.Scalar5;
            tempScalar8 += 2 * mv2.KVector3.Scalar234 * mv1.Scalar24 * mv2.KVector1.Scalar5;
            tempScalar9 += -2 * mv2.KVector3.Scalar234 * mv1.Scalar23 * mv2.KVector1.Scalar5;
        }
        
        if (!mv2.KVector3.IsZero())
        {
            tempScalar0 += mv2.KVector3.Scalar235 * mv1.Scalar12 * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar345 * mv1.Scalar12 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar245 * mv1.Scalar12 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar234 * mv1.Scalar12 * mv2.KVector3.Scalar234 + 2 * mv2.KVector3.Scalar245 * mv1.Scalar13 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar234 * mv1.Scalar15 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar235 * mv1.Scalar14 * mv2.KVector3.Scalar345;
            tempScalar1 += -mv2.KVector3.Scalar234 * mv1.Scalar13 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar235 * mv1.Scalar13 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar145 * mv1.Scalar23 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar135 * mv1.Scalar23 * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar345 * mv1.Scalar13 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar124 * mv1.Scalar25 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar134 * mv1.Scalar23 * mv2.KVector3.Scalar234 - 2 * mv2.KVector3.Scalar235 * mv1.Scalar24 * mv2.KVector3.Scalar145 - 2 * mv2.KVector3.Scalar134 * mv1.Scalar25 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar234 * mv1.Scalar15 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar234 * mv1.Scalar25 * mv2.KVector3.Scalar145 + 2 * mv2.KVector3.Scalar125 * mv1.Scalar24 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar135 * mv1.Scalar24 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar245 * mv1.Scalar13 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar235 * mv1.Scalar14 * mv2.KVector3.Scalar245;
            tempScalar2 += -mv2.KVector3.Scalar234 * mv1.Scalar23 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar235 * mv1.Scalar23 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar235 * mv1.Scalar24 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar345 * mv1.Scalar23 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar234 * mv1.Scalar25 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar245 * mv1.Scalar23 * mv2.KVector3.Scalar245;
            tempScalar3 += mv2.KVector3.Scalar235 * mv1.Scalar14 * mv2.KVector3.Scalar235 - mv2.KVector3.Scalar245 * mv1.Scalar14 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar234 * mv1.Scalar14 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar345 * mv1.Scalar14 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar124 * mv1.Scalar34 * mv2.KVector3.Scalar234 + 2 * mv2.KVector3.Scalar134 * mv1.Scalar24 * mv2.KVector3.Scalar234 - 2 * mv2.KVector3.Scalar145 * mv1.Scalar24 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar123 * mv1.Scalar25 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar123 * mv1.Scalar35 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar145 * mv1.Scalar34 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar124 * mv1.Scalar35 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar134 * mv1.Scalar25 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar135 * mv1.Scalar24 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar125 * mv1.Scalar34 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar234 * mv1.Scalar15 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar234 * mv1.Scalar25 * mv2.KVector3.Scalar135 + 2 * mv2.KVector3.Scalar234 * mv1.Scalar35 * mv2.KVector3.Scalar125;
            tempScalar4 += mv2.KVector3.Scalar234 * mv1.Scalar24 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar245 * mv1.Scalar24 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar345 * mv1.Scalar24 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar235 * mv1.Scalar24 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar234 * mv1.Scalar25 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar245 * mv1.Scalar34 * mv2.KVector3.Scalar345;
            tempScalar5 += -mv2.KVector3.Scalar234 * mv1.Scalar34 * mv2.KVector3.Scalar234 + mv2.KVector3.Scalar245 * mv1.Scalar34 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar345 * mv1.Scalar34 * mv2.KVector3.Scalar345 - mv2.KVector3.Scalar235 * mv1.Scalar34 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar234 * mv1.Scalar35 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar235 * mv1.Scalar23 * mv2.KVector3.Scalar345;
            tempScalar6 += mv2.KVector3.Scalar235 * mv1.Scalar15 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar135 * mv1.Scalar25 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar123 * mv1.Scalar45 * mv2.KVector3.Scalar234 + mv2.KVector3.Scalar245 * mv1.Scalar15 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar345 * mv1.Scalar15 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar125 * mv1.Scalar35 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar145 * mv1.Scalar25 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar124 * mv1.Scalar35 * mv2.KVector3.Scalar234 - 2 * mv2.KVector3.Scalar134 * mv1.Scalar25 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar234 * mv1.Scalar15 * mv2.KVector3.Scalar234 + 2 * mv2.KVector3.Scalar145 * mv1.Scalar35 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar125 * mv1.Scalar45 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar135 * mv1.Scalar45 * mv2.KVector3.Scalar345;
            tempScalar7 += mv2.KVector3.Scalar235 * mv1.Scalar25 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar235 * mv1.Scalar45 * mv2.KVector3.Scalar345 - mv2.KVector3.Scalar234 * mv1.Scalar25 * mv2.KVector3.Scalar234 + mv2.KVector3.Scalar345 * mv1.Scalar25 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar245 * mv1.Scalar35 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar245 * mv1.Scalar25 * mv2.KVector3.Scalar245;
            tempScalar8 += -mv2.KVector3.Scalar235 * mv1.Scalar35 * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar234 * mv1.Scalar35 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar245 * mv1.Scalar35 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar235 * mv1.Scalar45 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar234 * mv1.Scalar23 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar345 * mv1.Scalar35 * mv2.KVector3.Scalar345;
            tempScalar9 += -mv2.KVector3.Scalar245 * mv1.Scalar45 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar235 * mv1.Scalar45 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar234 * mv1.Scalar24 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar234 * mv1.Scalar34 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar234 * mv1.Scalar45 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar345 * mv1.Scalar45 * mv2.KVector3.Scalar345;
        }
        
        if (!mv2.KVector3.IsZero() && !mv2.KVector5.IsZero())
        {
            tempScalar0 += 2 * mv2.KVector3.Scalar235 * mv1.Scalar24 * mv2.KVector5.Scalar12345;
            tempScalar1 += -2 * mv2.KVector3.Scalar234 * mv1.Scalar35 * mv2.KVector5.Scalar12345;
            tempScalar3 += -2 * mv2.KVector3.Scalar345 * mv1.Scalar24 * mv2.KVector5.Scalar12345;
            tempScalar6 += 2 * mv2.KVector3.Scalar245 * mv1.Scalar35 * mv2.KVector5.Scalar12345;
        }
        
        return new Ga401KVector2
        {
            Scalar12 = (tempScalar0) * mv2NormSquaredInv,
            Scalar13 = (tempScalar1) * mv2NormSquaredInv,
            Scalar23 = (tempScalar2) * mv2NormSquaredInv,
            Scalar14 = (tempScalar3) * mv2NormSquaredInv,
            Scalar24 = (tempScalar4) * mv2NormSquaredInv,
            Scalar34 = (tempScalar5) * mv2NormSquaredInv,
            Scalar15 = (tempScalar6) * mv2NormSquaredInv,
            Scalar25 = (tempScalar7) * mv2NormSquaredInv,
            Scalar35 = (tempScalar8) * mv2NormSquaredInv,
            Scalar45 = (tempScalar9) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector3 MapUsingVersor(this Ga401KVector3 mv1, Ga401KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector3.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector3
        {
            Scalar123 = (mv2.Scalar * mv1.Scalar123 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar124 = (mv2.Scalar * mv1.Scalar124 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar134 = (mv2.Scalar * mv1.Scalar134 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar234 = (mv2.Scalar * mv1.Scalar234 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar125 = (mv2.Scalar * mv1.Scalar125 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar135 = (mv2.Scalar * mv1.Scalar135 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar235 = (mv2.Scalar * mv1.Scalar235 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar145 = (mv2.Scalar * mv1.Scalar145 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar245 = (mv2.Scalar * mv1.Scalar245 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar345 = (mv2.Scalar * mv1.Scalar345 * mv2.Scalar) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector3 MapUsingVersor(this Ga401KVector3 mv1, Ga401KVector1 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector3.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector3
        {
            Scalar123 = (-2 * mv2.Scalar1 * mv1.Scalar234 * mv2.Scalar4 - 2 * mv2.Scalar1 * mv1.Scalar235 * mv2.Scalar5 - mv2.Scalar2 * mv1.Scalar123 * mv2.Scalar2 + 2 * mv2.Scalar2 * mv1.Scalar134 * mv2.Scalar4 + 2 * mv2.Scalar2 * mv1.Scalar135 * mv2.Scalar5 - mv2.Scalar3 * mv1.Scalar123 * mv2.Scalar3 - 2 * mv2.Scalar3 * mv1.Scalar124 * mv2.Scalar4 - 2 * mv2.Scalar3 * mv1.Scalar125 * mv2.Scalar5 + mv2.Scalar4 * mv1.Scalar123 * mv2.Scalar4 + mv2.Scalar5 * mv1.Scalar123 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar124 = (2 * mv2.Scalar1 * mv1.Scalar234 * mv2.Scalar3 - 2 * mv2.Scalar1 * mv1.Scalar245 * mv2.Scalar5 - mv2.Scalar2 * mv1.Scalar124 * mv2.Scalar2 - 2 * mv2.Scalar2 * mv1.Scalar134 * mv2.Scalar3 + 2 * mv2.Scalar2 * mv1.Scalar145 * mv2.Scalar5 - 2 * mv2.Scalar3 * mv1.Scalar123 * mv2.Scalar4 + mv2.Scalar3 * mv1.Scalar124 * mv2.Scalar3 - mv2.Scalar4 * mv1.Scalar124 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.Scalar125 * mv2.Scalar5 + mv2.Scalar5 * mv1.Scalar124 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar134 = (-2 * mv2.Scalar1 * mv1.Scalar234 * mv2.Scalar2 - 2 * mv2.Scalar1 * mv1.Scalar345 * mv2.Scalar5 + 2 * mv2.Scalar2 * mv1.Scalar123 * mv2.Scalar4 - 2 * mv2.Scalar2 * mv1.Scalar124 * mv2.Scalar3 + mv2.Scalar2 * mv1.Scalar134 * mv2.Scalar2 - mv2.Scalar3 * mv1.Scalar134 * mv2.Scalar3 + 2 * mv2.Scalar3 * mv1.Scalar145 * mv2.Scalar5 - mv2.Scalar4 * mv1.Scalar134 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.Scalar135 * mv2.Scalar5 + mv2.Scalar5 * mv1.Scalar134 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar234 = (-mv2.Scalar2 * mv1.Scalar234 * mv2.Scalar2 - 2 * mv2.Scalar2 * mv1.Scalar345 * mv2.Scalar5 - mv2.Scalar3 * mv1.Scalar234 * mv2.Scalar3 + 2 * mv2.Scalar3 * mv1.Scalar245 * mv2.Scalar5 - mv2.Scalar4 * mv1.Scalar234 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.Scalar235 * mv2.Scalar5 + mv2.Scalar5 * mv1.Scalar234 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar125 = (2 * mv2.Scalar1 * mv1.Scalar235 * mv2.Scalar3 + 2 * mv2.Scalar1 * mv1.Scalar245 * mv2.Scalar4 - mv2.Scalar2 * mv1.Scalar125 * mv2.Scalar2 - 2 * mv2.Scalar2 * mv1.Scalar135 * mv2.Scalar3 - 2 * mv2.Scalar2 * mv1.Scalar145 * mv2.Scalar4 - 2 * mv2.Scalar3 * mv1.Scalar123 * mv2.Scalar5 + mv2.Scalar3 * mv1.Scalar125 * mv2.Scalar3 - 2 * mv2.Scalar4 * mv1.Scalar124 * mv2.Scalar5 + mv2.Scalar4 * mv1.Scalar125 * mv2.Scalar4 - mv2.Scalar5 * mv1.Scalar125 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar135 = (-2 * mv2.Scalar1 * mv1.Scalar235 * mv2.Scalar2 + 2 * mv2.Scalar1 * mv1.Scalar345 * mv2.Scalar4 + 2 * mv2.Scalar2 * mv1.Scalar123 * mv2.Scalar5 - 2 * mv2.Scalar2 * mv1.Scalar125 * mv2.Scalar3 + mv2.Scalar2 * mv1.Scalar135 * mv2.Scalar2 - mv2.Scalar3 * mv1.Scalar135 * mv2.Scalar3 - 2 * mv2.Scalar3 * mv1.Scalar145 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.Scalar134 * mv2.Scalar5 + mv2.Scalar4 * mv1.Scalar135 * mv2.Scalar4 - mv2.Scalar5 * mv1.Scalar135 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar235 = (-mv2.Scalar2 * mv1.Scalar235 * mv2.Scalar2 + 2 * mv2.Scalar2 * mv1.Scalar345 * mv2.Scalar4 - mv2.Scalar3 * mv1.Scalar235 * mv2.Scalar3 - 2 * mv2.Scalar3 * mv1.Scalar245 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.Scalar234 * mv2.Scalar5 + mv2.Scalar4 * mv1.Scalar235 * mv2.Scalar4 - mv2.Scalar5 * mv1.Scalar235 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar145 = (-2 * mv2.Scalar1 * mv1.Scalar245 * mv2.Scalar2 - 2 * mv2.Scalar1 * mv1.Scalar345 * mv2.Scalar3 + 2 * mv2.Scalar2 * mv1.Scalar124 * mv2.Scalar5 - 2 * mv2.Scalar2 * mv1.Scalar125 * mv2.Scalar4 + mv2.Scalar2 * mv1.Scalar145 * mv2.Scalar2 + 2 * mv2.Scalar3 * mv1.Scalar134 * mv2.Scalar5 - 2 * mv2.Scalar3 * mv1.Scalar135 * mv2.Scalar4 + mv2.Scalar3 * mv1.Scalar145 * mv2.Scalar3 - mv2.Scalar4 * mv1.Scalar145 * mv2.Scalar4 - mv2.Scalar5 * mv1.Scalar145 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar245 = (-mv2.Scalar2 * mv1.Scalar245 * mv2.Scalar2 - 2 * mv2.Scalar2 * mv1.Scalar345 * mv2.Scalar3 + 2 * mv2.Scalar3 * mv1.Scalar234 * mv2.Scalar5 - 2 * mv2.Scalar3 * mv1.Scalar235 * mv2.Scalar4 + mv2.Scalar3 * mv1.Scalar245 * mv2.Scalar3 - mv2.Scalar4 * mv1.Scalar245 * mv2.Scalar4 - mv2.Scalar5 * mv1.Scalar245 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar345 = (-2 * mv2.Scalar2 * mv1.Scalar234 * mv2.Scalar5 + 2 * mv2.Scalar2 * mv1.Scalar235 * mv2.Scalar4 - 2 * mv2.Scalar2 * mv1.Scalar245 * mv2.Scalar3 + mv2.Scalar2 * mv1.Scalar345 * mv2.Scalar2 - mv2.Scalar3 * mv1.Scalar345 * mv2.Scalar3 - mv2.Scalar4 * mv1.Scalar345 * mv2.Scalar4 - mv2.Scalar5 * mv1.Scalar345 * mv2.Scalar5) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector3 MapUsingVersor(this Ga401KVector3 mv1, Ga401KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector3.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector3
        {
            Scalar123 = (-2 * mv2.Scalar12 * mv1.Scalar234 * mv2.Scalar24 - 2 * mv2.Scalar12 * mv1.Scalar235 * mv2.Scalar25 + 2 * mv2.Scalar15 * mv1.Scalar234 * mv2.Scalar45 + 2 * mv2.Scalar13 * mv1.Scalar234 * mv2.Scalar34 + 2 * mv2.Scalar13 * mv1.Scalar235 * mv2.Scalar35 + 2 * mv2.Scalar34 * mv1.Scalar245 * mv2.Scalar15 + 2 * mv2.Scalar13 * mv1.Scalar245 * mv2.Scalar45 - mv2.Scalar23 * mv1.Scalar123 * mv2.Scalar23 - mv2.Scalar24 * mv1.Scalar123 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar124 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar125 * mv2.Scalar25 + 2 * mv2.Scalar14 * mv1.Scalar235 * mv2.Scalar45 + 2 * mv2.Scalar14 * mv1.Scalar245 * mv2.Scalar35 + mv2.Scalar35 * mv1.Scalar123 * mv2.Scalar35 + mv2.Scalar34 * mv1.Scalar123 * mv2.Scalar34 - mv2.Scalar25 * mv1.Scalar123 * mv2.Scalar25 + 2 * mv2.Scalar35 * mv1.Scalar124 * mv2.Scalar45 + 2 * mv2.Scalar34 * mv1.Scalar125 * mv2.Scalar45 + mv2.Scalar45 * mv1.Scalar123 * mv2.Scalar45) * mv2NormSquaredInv,
            Scalar124 = (-2 * mv2.Scalar12 * mv1.Scalar245 * mv2.Scalar25 - 2 * mv2.Scalar12 * mv1.Scalar345 * mv2.Scalar35 - 2 * mv2.Scalar13 * mv1.Scalar245 * mv2.Scalar35 - 2 * mv2.Scalar13 * mv1.Scalar345 * mv2.Scalar25 + mv2.Scalar23 * mv1.Scalar124 * mv2.Scalar23 + 2 * mv2.Scalar23 * mv1.Scalar135 * mv2.Scalar45 + 2 * mv2.Scalar23 * mv1.Scalar345 * mv2.Scalar15 + 2 * mv2.Scalar14 * mv1.Scalar245 * mv2.Scalar45 - mv2.Scalar24 * mv1.Scalar124 * mv2.Scalar24 - mv2.Scalar34 * mv1.Scalar124 * mv2.Scalar34 - mv2.Scalar25 * mv1.Scalar124 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.Scalar134 * mv2.Scalar34 - 2 * mv2.Scalar25 * mv1.Scalar134 * mv2.Scalar35 - 2 * mv2.Scalar24 * mv1.Scalar125 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.Scalar135 * mv2.Scalar35 + mv2.Scalar45 * mv1.Scalar124 * mv2.Scalar45 - 2 * mv2.Scalar34 * mv1.Scalar125 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.Scalar135 * mv2.Scalar25 - mv2.Scalar35 * mv1.Scalar124 * mv2.Scalar35) * mv2NormSquaredInv,
            Scalar134 = (2 * mv2.Scalar12 * mv1.Scalar235 * mv2.Scalar45 + 2 * mv2.Scalar12 * mv1.Scalar345 * mv2.Scalar25 - 2 * mv2.Scalar13 * mv1.Scalar234 * mv2.Scalar23 + 2 * mv2.Scalar24 * mv1.Scalar235 * mv2.Scalar15 - 2 * mv2.Scalar13 * mv1.Scalar345 * mv2.Scalar35 - 2 * mv2.Scalar23 * mv1.Scalar123 * mv2.Scalar34 + 2 * mv2.Scalar25 * mv1.Scalar123 * mv2.Scalar45 - mv2.Scalar23 * mv1.Scalar134 * mv2.Scalar23 - mv2.Scalar34 * mv1.Scalar134 * mv2.Scalar34 + 2 * mv2.Scalar14 * mv1.Scalar234 * mv2.Scalar24 + 2 * mv2.Scalar14 * mv1.Scalar235 * mv2.Scalar25 + 2 * mv2.Scalar14 * mv1.Scalar345 * mv2.Scalar45 + mv2.Scalar24 * mv1.Scalar134 * mv2.Scalar24 + 2 * mv2.Scalar15 * mv1.Scalar234 * mv2.Scalar25 + 2 * mv2.Scalar24 * mv1.Scalar135 * mv2.Scalar25 + mv2.Scalar25 * mv1.Scalar134 * mv2.Scalar25 - mv2.Scalar35 * mv1.Scalar134 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.Scalar135 * mv2.Scalar35 + mv2.Scalar45 * mv1.Scalar134 * mv2.Scalar45) * mv2NormSquaredInv,
            Scalar234 = (-mv2.Scalar23 * mv1.Scalar234 * mv2.Scalar23 - mv2.Scalar35 * mv1.Scalar234 * mv2.Scalar35 - 2 * mv2.Scalar23 * mv1.Scalar345 * mv2.Scalar35 - mv2.Scalar34 * mv1.Scalar234 * mv2.Scalar34 + mv2.Scalar24 * mv1.Scalar234 * mv2.Scalar24 + mv2.Scalar25 * mv1.Scalar234 * mv2.Scalar25 + mv2.Scalar45 * mv1.Scalar234 * mv2.Scalar45 + 2 * mv2.Scalar24 * mv1.Scalar235 * mv2.Scalar25 + 2 * mv2.Scalar24 * mv1.Scalar345 * mv2.Scalar45 - 2 * mv2.Scalar34 * mv1.Scalar235 * mv2.Scalar35) * mv2NormSquaredInv,
            Scalar125 = (-2 * mv2.Scalar13 * mv1.Scalar234 * mv2.Scalar45 + mv2.Scalar23 * mv1.Scalar125 * mv2.Scalar23 - mv2.Scalar25 * mv1.Scalar125 * mv2.Scalar25 + 2 * mv2.Scalar23 * mv1.Scalar145 * mv2.Scalar34 - 2 * mv2.Scalar25 * mv1.Scalar145 * mv2.Scalar45 - mv2.Scalar35 * mv1.Scalar125 * mv2.Scalar35 - 2 * mv2.Scalar14 * mv1.Scalar234 * mv2.Scalar35 + mv2.Scalar24 * mv1.Scalar125 * mv2.Scalar24 + mv2.Scalar34 * mv1.Scalar125 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.Scalar135 * mv2.Scalar34 + 2 * mv2.Scalar34 * mv1.Scalar234 * mv2.Scalar15 - mv2.Scalar45 * mv1.Scalar125 * mv2.Scalar45 - 2 * mv2.Scalar25 * mv1.Scalar135 * mv2.Scalar35) * mv2NormSquaredInv,
            Scalar135 = (2 * mv2.Scalar15 * mv1.Scalar235 * mv2.Scalar25 + 2 * mv2.Scalar12 * mv1.Scalar245 * mv2.Scalar34 - 2 * mv2.Scalar13 * mv1.Scalar235 * mv2.Scalar23 - 2 * mv2.Scalar13 * mv1.Scalar245 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar123 * mv2.Scalar35 - 2 * mv2.Scalar23 * mv1.Scalar124 * mv2.Scalar45 - mv2.Scalar23 * mv1.Scalar135 * mv2.Scalar23 - mv2.Scalar24 * mv1.Scalar135 * mv2.Scalar24 - mv2.Scalar35 * mv1.Scalar135 * mv2.Scalar35 - 2 * mv2.Scalar14 * mv1.Scalar235 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar145 * mv2.Scalar24 - 2 * mv2.Scalar35 * mv1.Scalar145 * mv2.Scalar45 - 2 * mv2.Scalar23 * mv1.Scalar245 * mv2.Scalar14 - 2 * mv2.Scalar24 * mv1.Scalar123 * mv2.Scalar45 - 2 * mv2.Scalar24 * mv1.Scalar124 * mv2.Scalar35 - mv2.Scalar45 * mv1.Scalar135 * mv2.Scalar45 + 2 * mv2.Scalar34 * mv1.Scalar124 * mv2.Scalar25 + mv2.Scalar34 * mv1.Scalar135 * mv2.Scalar34 + mv2.Scalar25 * mv1.Scalar135 * mv2.Scalar25) * mv2NormSquaredInv,
            Scalar235 = (-mv2.Scalar23 * mv1.Scalar235 * mv2.Scalar23 - 2 * mv2.Scalar35 * mv1.Scalar245 * mv2.Scalar45 - mv2.Scalar24 * mv1.Scalar235 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar245 * mv2.Scalar24 + mv2.Scalar34 * mv1.Scalar235 * mv2.Scalar34 - mv2.Scalar45 * mv1.Scalar235 * mv2.Scalar45 - mv2.Scalar35 * mv1.Scalar235 * mv2.Scalar35 + mv2.Scalar25 * mv1.Scalar235 * mv2.Scalar25) * mv2NormSquaredInv,
            Scalar145 = (2 * mv2.Scalar12 * mv1.Scalar234 * mv2.Scalar35 + 2 * mv2.Scalar12 * mv1.Scalar345 * mv2.Scalar23 + 2 * mv2.Scalar13 * mv1.Scalar234 * mv2.Scalar25 + 2 * mv2.Scalar13 * mv1.Scalar245 * mv2.Scalar23 + 2 * mv2.Scalar23 * mv1.Scalar124 * mv2.Scalar35 + 2 * mv2.Scalar23 * mv1.Scalar134 * mv2.Scalar25 + 2 * mv2.Scalar23 * mv1.Scalar234 * mv2.Scalar15 + mv2.Scalar23 * mv1.Scalar145 * mv2.Scalar23 + 2 * mv2.Scalar15 * mv1.Scalar245 * mv2.Scalar25 - 2 * mv2.Scalar14 * mv1.Scalar345 * mv2.Scalar34 - 2 * mv2.Scalar14 * mv1.Scalar245 * mv2.Scalar24 - 2 * mv2.Scalar24 * mv1.Scalar124 * mv2.Scalar45 - mv2.Scalar24 * mv1.Scalar145 * mv2.Scalar24 + mv2.Scalar35 * mv1.Scalar145 * mv2.Scalar35 + 2 * mv2.Scalar15 * mv1.Scalar345 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.Scalar134 * mv2.Scalar45 - mv2.Scalar34 * mv1.Scalar145 * mv2.Scalar34 + mv2.Scalar25 * mv1.Scalar145 * mv2.Scalar25 - mv2.Scalar45 * mv1.Scalar145 * mv2.Scalar45) * mv2NormSquaredInv,
            Scalar245 = (-mv2.Scalar24 * mv1.Scalar245 * mv2.Scalar24 - 2 * mv2.Scalar24 * mv1.Scalar345 * mv2.Scalar34 + mv2.Scalar35 * mv1.Scalar245 * mv2.Scalar35 + 2 * mv2.Scalar23 * mv1.Scalar234 * mv2.Scalar25 + mv2.Scalar23 * mv1.Scalar245 * mv2.Scalar23 + mv2.Scalar25 * mv1.Scalar245 * mv2.Scalar25 - mv2.Scalar34 * mv1.Scalar245 * mv2.Scalar34 - 2 * mv2.Scalar34 * mv1.Scalar234 * mv2.Scalar45 - mv2.Scalar45 * mv1.Scalar245 * mv2.Scalar45 + 2 * mv2.Scalar25 * mv1.Scalar345 * mv2.Scalar35) * mv2NormSquaredInv,
            Scalar345 = (mv2.Scalar24 * mv1.Scalar345 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar235 * mv2.Scalar34 - mv2.Scalar23 * mv1.Scalar345 * mv2.Scalar23 - mv2.Scalar34 * mv1.Scalar345 * mv2.Scalar34 - mv2.Scalar25 * mv1.Scalar345 * mv2.Scalar25 + mv2.Scalar35 * mv1.Scalar345 * mv2.Scalar35 - 2 * mv2.Scalar25 * mv1.Scalar235 * mv2.Scalar45 - mv2.Scalar45 * mv1.Scalar345 * mv2.Scalar45) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector3 MapUsingVersor(this Ga401KVector3 mv1, Ga401KVector3 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector3.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector3
        {
            Scalar123 = (-2 * mv2.Scalar123 * mv1.Scalar234 * mv2.Scalar234 - 2 * mv2.Scalar123 * mv1.Scalar235 * mv2.Scalar235 - 2 * mv2.Scalar123 * mv1.Scalar245 * mv2.Scalar245 - 2 * mv2.Scalar124 * mv1.Scalar235 * mv2.Scalar245 - 2 * mv2.Scalar124 * mv1.Scalar245 * mv2.Scalar235 + 2 * mv2.Scalar134 * mv1.Scalar235 * mv2.Scalar345 + mv2.Scalar345 * mv1.Scalar123 * mv2.Scalar345 - mv2.Scalar234 * mv1.Scalar123 * mv2.Scalar234 - 2 * mv2.Scalar234 * mv1.Scalar125 * mv2.Scalar245 - 2 * mv2.Scalar234 * mv1.Scalar245 * mv2.Scalar125 - 2 * mv2.Scalar125 * mv1.Scalar234 * mv2.Scalar245 + 2 * mv2.Scalar135 * mv1.Scalar234 * mv2.Scalar345 - mv2.Scalar235 * mv1.Scalar123 * mv2.Scalar235 - mv2.Scalar245 * mv1.Scalar123 * mv2.Scalar245 - 2 * mv2.Scalar235 * mv1.Scalar124 * mv2.Scalar245) * mv2NormSquaredInv,
            Scalar124 = (2 * mv2.Scalar123 * mv1.Scalar245 * mv2.Scalar235 - 2 * mv2.Scalar124 * mv1.Scalar245 * mv2.Scalar245 - 2 * mv2.Scalar124 * mv1.Scalar345 * mv2.Scalar345 - 2 * mv2.Scalar134 * mv1.Scalar245 * mv2.Scalar345 - 2 * mv2.Scalar134 * mv1.Scalar345 * mv2.Scalar245 - mv2.Scalar245 * mv1.Scalar124 * mv2.Scalar245 + mv2.Scalar234 * mv1.Scalar124 * mv2.Scalar234 + mv2.Scalar235 * mv1.Scalar124 * mv2.Scalar235 + 2 * mv2.Scalar234 * mv1.Scalar125 * mv2.Scalar235 + 2 * mv2.Scalar234 * mv1.Scalar345 * mv2.Scalar145 - mv2.Scalar345 * mv1.Scalar124 * mv2.Scalar345 - 2 * mv2.Scalar245 * mv1.Scalar134 * mv2.Scalar345) * mv2NormSquaredInv,
            Scalar134 = (-2 * mv2.Scalar123 * mv1.Scalar235 * mv2.Scalar345 - 2 * mv2.Scalar123 * mv1.Scalar345 * mv2.Scalar235 + 2 * mv2.Scalar124 * mv1.Scalar345 * mv2.Scalar245 - 2 * mv2.Scalar134 * mv1.Scalar234 * mv2.Scalar234 - 2 * mv2.Scalar134 * mv1.Scalar235 * mv2.Scalar235 - 2 * mv2.Scalar134 * mv1.Scalar345 * mv2.Scalar345 - mv2.Scalar234 * mv1.Scalar134 * mv2.Scalar234 - mv2.Scalar235 * mv1.Scalar134 * mv2.Scalar235 - 2 * mv2.Scalar135 * mv1.Scalar234 * mv2.Scalar235 - 2 * mv2.Scalar234 * mv1.Scalar135 * mv2.Scalar235 - 2 * mv2.Scalar234 * mv1.Scalar235 * mv2.Scalar135 - 2 * mv2.Scalar235 * mv1.Scalar123 * mv2.Scalar345 - mv2.Scalar345 * mv1.Scalar134 * mv2.Scalar345 + 2 * mv2.Scalar145 * mv1.Scalar234 * mv2.Scalar245 + mv2.Scalar245 * mv1.Scalar134 * mv2.Scalar245) * mv2NormSquaredInv,
            Scalar234 = (-mv2.Scalar234 * mv1.Scalar234 * mv2.Scalar234 - 2 * mv2.Scalar234 * mv1.Scalar235 * mv2.Scalar235 - 2 * mv2.Scalar234 * mv1.Scalar345 * mv2.Scalar345 - mv2.Scalar235 * mv1.Scalar234 * mv2.Scalar235 - mv2.Scalar345 * mv1.Scalar234 * mv2.Scalar345 + mv2.Scalar245 * mv1.Scalar234 * mv2.Scalar245) * mv2NormSquaredInv,
            Scalar125 = (2 * mv2.Scalar123 * mv1.Scalar234 * mv2.Scalar245 + 2 * mv2.Scalar124 * mv1.Scalar234 * mv2.Scalar235 - 2 * mv2.Scalar234 * mv1.Scalar234 * mv2.Scalar125 + mv2.Scalar235 * mv1.Scalar125 * mv2.Scalar235 - mv2.Scalar234 * mv1.Scalar125 * mv2.Scalar234 + 2 * mv2.Scalar235 * mv1.Scalar145 * mv2.Scalar345 + mv2.Scalar245 * mv1.Scalar125 * mv2.Scalar245 + mv2.Scalar345 * mv1.Scalar125 * mv2.Scalar345 + 2 * mv2.Scalar245 * mv1.Scalar135 * mv2.Scalar345) * mv2NormSquaredInv,
            Scalar135 = (-2 * mv2.Scalar145 * mv1.Scalar235 * mv2.Scalar245 + 2 * mv2.Scalar134 * mv1.Scalar235 * mv2.Scalar234 + 2 * mv2.Scalar234 * mv1.Scalar123 * mv2.Scalar345 + mv2.Scalar234 * mv1.Scalar135 * mv2.Scalar234 + mv2.Scalar345 * mv1.Scalar135 * mv2.Scalar345 + 2 * mv2.Scalar125 * mv1.Scalar245 * mv2.Scalar345 - 2 * mv2.Scalar135 * mv1.Scalar235 * mv2.Scalar235 - 2 * mv2.Scalar135 * mv1.Scalar245 * mv2.Scalar245 - mv2.Scalar235 * mv1.Scalar135 * mv2.Scalar235 - mv2.Scalar245 * mv1.Scalar135 * mv2.Scalar245 - 2 * mv2.Scalar235 * mv1.Scalar145 * mv2.Scalar245 - 2 * mv2.Scalar235 * mv1.Scalar245 * mv2.Scalar145) * mv2NormSquaredInv,
            Scalar235 = (mv2.Scalar234 * mv1.Scalar235 * mv2.Scalar234 - mv2.Scalar235 * mv1.Scalar235 * mv2.Scalar235 - mv2.Scalar245 * mv1.Scalar235 * mv2.Scalar245 - 2 * mv2.Scalar235 * mv1.Scalar245 * mv2.Scalar245 + mv2.Scalar345 * mv1.Scalar235 * mv2.Scalar345) * mv2NormSquaredInv,
            Scalar145 = (-2 * mv2.Scalar124 * mv1.Scalar234 * mv2.Scalar345 - 2 * mv2.Scalar124 * mv1.Scalar345 * mv2.Scalar234 - 2 * mv2.Scalar134 * mv1.Scalar234 * mv2.Scalar245 - 2 * mv2.Scalar134 * mv1.Scalar245 * mv2.Scalar234 - 2 * mv2.Scalar234 * mv1.Scalar124 * mv2.Scalar345 - 2 * mv2.Scalar234 * mv1.Scalar134 * mv2.Scalar245 - 2 * mv2.Scalar234 * mv1.Scalar234 * mv2.Scalar145 - mv2.Scalar234 * mv1.Scalar145 * mv2.Scalar234 - mv2.Scalar245 * mv1.Scalar145 * mv2.Scalar245 - mv2.Scalar345 * mv1.Scalar145 * mv2.Scalar345 - 2 * mv2.Scalar145 * mv1.Scalar245 * mv2.Scalar245 + 2 * mv2.Scalar125 * mv1.Scalar345 * mv2.Scalar235 + 2 * mv2.Scalar135 * mv1.Scalar245 * mv2.Scalar235 + mv2.Scalar235 * mv1.Scalar145 * mv2.Scalar235 - 2 * mv2.Scalar145 * mv1.Scalar345 * mv2.Scalar345) * mv2NormSquaredInv,
            Scalar245 = (-mv2.Scalar234 * mv1.Scalar245 * mv2.Scalar234 - 2 * mv2.Scalar234 * mv1.Scalar234 * mv2.Scalar245 - mv2.Scalar345 * mv1.Scalar245 * mv2.Scalar345 - mv2.Scalar245 * mv1.Scalar245 * mv2.Scalar245 - 2 * mv2.Scalar245 * mv1.Scalar345 * mv2.Scalar345 + mv2.Scalar235 * mv1.Scalar245 * mv2.Scalar235) * mv2NormSquaredInv,
            Scalar345 = (mv2.Scalar234 * mv1.Scalar345 * mv2.Scalar234 - mv2.Scalar235 * mv1.Scalar345 * mv2.Scalar235 + mv2.Scalar245 * mv1.Scalar345 * mv2.Scalar245 - 2 * mv2.Scalar235 * mv1.Scalar235 * mv2.Scalar345 - mv2.Scalar345 * mv1.Scalar345 * mv2.Scalar345) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector3 MapUsingVersor(this Ga401KVector3 mv1, Ga401KVector4 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector3.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector3
        {
            Scalar123 = (2 * mv2.Scalar1234 * mv1.Scalar235 * mv2.Scalar2345 - 2 * mv2.Scalar1235 * mv1.Scalar234 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.Scalar123 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar124 = (2 * mv2.Scalar1234 * mv1.Scalar245 * mv2.Scalar2345 - 2 * mv2.Scalar1245 * mv1.Scalar234 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.Scalar124 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar134 = (2 * mv2.Scalar1234 * mv1.Scalar345 * mv2.Scalar2345 - 2 * mv2.Scalar1345 * mv1.Scalar234 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.Scalar134 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar234 = (-mv2.Scalar2345 * mv1.Scalar234 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar125 = (2 * mv2.Scalar1235 * mv1.Scalar245 * mv2.Scalar2345 - 2 * mv2.Scalar1245 * mv1.Scalar235 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.Scalar125 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar135 = (2 * mv2.Scalar1235 * mv1.Scalar345 * mv2.Scalar2345 - 2 * mv2.Scalar1345 * mv1.Scalar235 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.Scalar135 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar235 = (-mv2.Scalar2345 * mv1.Scalar235 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar145 = (2 * mv2.Scalar1245 * mv1.Scalar345 * mv2.Scalar2345 - 2 * mv2.Scalar1345 * mv1.Scalar245 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.Scalar145 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar245 = (-mv2.Scalar2345 * mv1.Scalar245 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar345 = (-mv2.Scalar2345 * mv1.Scalar345 * mv2.Scalar2345) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector3 MapUsingVersor(this Ga401KVector3 mv1, Ga401KVector5 mv2)
    {
        return Ga401KVector3.Zero;
    }
    
    public static Ga401KVector3 MapUsingEvenVersor(this Ga401KVector3 mv1, Ga401Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector3.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
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
            Scalar123 = (tempScalar0) * mv2NormSquaredInv,
            Scalar124 = (tempScalar1) * mv2NormSquaredInv,
            Scalar134 = (tempScalar2) * mv2NormSquaredInv,
            Scalar234 = (tempScalar3) * mv2NormSquaredInv,
            Scalar125 = (tempScalar4) * mv2NormSquaredInv,
            Scalar135 = (tempScalar5) * mv2NormSquaredInv,
            Scalar235 = (tempScalar6) * mv2NormSquaredInv,
            Scalar145 = (tempScalar7) * mv2NormSquaredInv,
            Scalar245 = (tempScalar8) * mv2NormSquaredInv,
            Scalar345 = (tempScalar9) * mv2NormSquaredInv
        };
    }
    
    public static Ga401KVector3 MapUsingOddVersor(this Ga401KVector3 mv1, Ga401Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector3.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
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
        
        if (!mv2.KVector1.IsZero())
        {
            tempScalar0 += -2 * mv2.KVector1.Scalar1 * mv1.Scalar234 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar1 * mv1.Scalar235 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar2 * mv1.Scalar123 * mv2.KVector1.Scalar2 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar134 * mv2.KVector1.Scalar4 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar135 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar3 * mv1.Scalar123 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar124 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar125 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar4 * mv1.Scalar123 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar5 * mv1.Scalar123 * mv2.KVector1.Scalar5;
            tempScalar1 += 2 * mv2.KVector1.Scalar1 * mv1.Scalar234 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar1 * mv1.Scalar245 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar2 * mv1.Scalar124 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar134 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar145 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar123 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar3 * mv1.Scalar124 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.Scalar124 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar125 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar5 * mv1.Scalar124 * mv2.KVector1.Scalar5;
            tempScalar2 += -2 * mv2.KVector1.Scalar1 * mv1.Scalar234 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar1 * mv1.Scalar345 * mv2.KVector1.Scalar5 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar123 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar124 * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar2 * mv1.Scalar134 * mv2.KVector1.Scalar2 - mv2.KVector1.Scalar3 * mv1.Scalar134 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar145 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar4 * mv1.Scalar134 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar135 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar5 * mv1.Scalar134 * mv2.KVector1.Scalar5;
            tempScalar3 += -mv2.KVector1.Scalar2 * mv1.Scalar234 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar345 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar3 * mv1.Scalar234 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar245 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar4 * mv1.Scalar234 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar235 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar5 * mv1.Scalar234 * mv2.KVector1.Scalar5;
            tempScalar4 += 2 * mv2.KVector1.Scalar1 * mv1.Scalar235 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar1 * mv1.Scalar245 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar2 * mv1.Scalar125 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar135 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar145 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar123 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar3 * mv1.Scalar125 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar5 * mv1.Scalar125 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar124 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar4 * mv1.Scalar125 * mv2.KVector1.Scalar4;
            tempScalar5 += -2 * mv2.KVector1.Scalar1 * mv1.Scalar235 * mv2.KVector1.Scalar2 + 2 * mv2.KVector1.Scalar1 * mv1.Scalar345 * mv2.KVector1.Scalar4 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar123 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar125 * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar2 * mv1.Scalar135 * mv2.KVector1.Scalar2 - mv2.KVector1.Scalar3 * mv1.Scalar135 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar145 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar134 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar4 * mv1.Scalar135 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.Scalar135 * mv2.KVector1.Scalar5;
            tempScalar6 += -mv2.KVector1.Scalar2 * mv1.Scalar235 * mv2.KVector1.Scalar2 + mv2.KVector1.Scalar4 * mv1.Scalar235 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.Scalar235 * mv2.KVector1.Scalar5 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar345 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar3 * mv1.Scalar235 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar245 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar234 * mv2.KVector1.Scalar5;
            tempScalar7 += -2 * mv2.KVector1.Scalar1 * mv1.Scalar245 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar1 * mv1.Scalar345 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar124 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar125 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar2 * mv1.Scalar145 * mv2.KVector1.Scalar2 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar134 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar135 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar3 * mv1.Scalar145 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.Scalar145 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.Scalar145 * mv2.KVector1.Scalar5;
            tempScalar8 += -mv2.KVector1.Scalar2 * mv1.Scalar245 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar345 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar234 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar235 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar3 * mv1.Scalar245 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.Scalar245 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.Scalar245 * mv2.KVector1.Scalar5;
            tempScalar9 += -2 * mv2.KVector1.Scalar2 * mv1.Scalar234 * mv2.KVector1.Scalar5 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar235 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar245 * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar2 * mv1.Scalar345 * mv2.KVector1.Scalar2 - mv2.KVector1.Scalar5 * mv1.Scalar345 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar3 * mv1.Scalar345 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.Scalar345 * mv2.KVector1.Scalar4;
        }
        
        if (!mv2.KVector1.IsZero() && !mv2.KVector3.IsZero())
        {
            tempScalar0 += -2 * mv2.KVector1.Scalar2 * mv1.Scalar124 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar125 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar145 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar134 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar234 * mv2.KVector3.Scalar134 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar135 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar235 * mv2.KVector3.Scalar135 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar145 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar245 * mv2.KVector3.Scalar145 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar145 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar4 * mv1.Scalar245 * mv2.KVector3.Scalar135 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar345 * mv2.KVector3.Scalar125 + 2 * mv2.KVector1.Scalar5 * mv1.Scalar124 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar5 * mv1.Scalar134 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar5 * mv1.Scalar234 * mv2.KVector3.Scalar145;
            tempScalar1 += 2 * mv2.KVector1.Scalar2 * mv1.Scalar123 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar125 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar135 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar135 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar235 * mv2.KVector3.Scalar145 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar145 * mv2.KVector3.Scalar235 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar245 * mv2.KVector3.Scalar135 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar145 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar4 * mv1.Scalar245 * mv2.KVector3.Scalar145 - 2 * mv2.KVector1.Scalar5 * mv1.Scalar123 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar5 * mv1.Scalar134 * mv2.KVector3.Scalar235 - 2 * mv2.KVector1.Scalar5 * mv1.Scalar234 * mv2.KVector3.Scalar135;
            tempScalar2 += -2 * mv2.KVector1.Scalar2 * mv1.Scalar125 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar135 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar145 * mv2.KVector3.Scalar235 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar234 * mv2.KVector3.Scalar123 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar135 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar245 * mv2.KVector3.Scalar125 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar145 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar4 * mv1.Scalar345 * mv2.KVector3.Scalar145 + 2 * mv2.KVector1.Scalar5 * mv1.Scalar123 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar5 * mv1.Scalar124 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar5 * mv1.Scalar234 * mv2.KVector3.Scalar125;
            tempScalar3 += -2 * mv2.KVector1.Scalar3 * mv1.Scalar235 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar245 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar4 * mv1.Scalar345 * mv2.KVector3.Scalar245;
            tempScalar4 += 2 * mv2.KVector1.Scalar2 * mv1.Scalar123 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar124 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar134 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar134 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar234 * mv2.KVector3.Scalar145 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar145 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar245 * mv2.KVector3.Scalar134 + 2 * mv2.KVector1.Scalar4 * mv1.Scalar123 * mv2.KVector3.Scalar345;
            tempScalar5 += 2 * mv2.KVector1.Scalar2 * mv1.Scalar124 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar134 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar145 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar134 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar235 * mv2.KVector3.Scalar123 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar245 * mv2.KVector3.Scalar124 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar123 * mv2.KVector3.Scalar245;
            tempScalar6 += 2 * mv2.KVector1.Scalar3 * mv1.Scalar234 * mv2.KVector3.Scalar345;
            tempScalar7 += -2 * mv2.KVector1.Scalar2 * mv1.Scalar123 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar134 * mv2.KVector3.Scalar235 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar135 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar234 * mv2.KVector3.Scalar125 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar235 * mv2.KVector3.Scalar124 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar245 * mv2.KVector3.Scalar123 + 2 * mv2.KVector1.Scalar4 * mv1.Scalar123 * mv2.KVector3.Scalar235 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar245 * mv2.KVector3.Scalar124 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar345 * mv2.KVector3.Scalar134;
            tempScalar8 += -2 * mv2.KVector1.Scalar4 * mv1.Scalar345 * mv2.KVector3.Scalar234;
            tempScalar9 += -2 * mv2.KVector1.Scalar3 * mv1.Scalar234 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar235 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar4 * mv1.Scalar245 * mv2.KVector3.Scalar234;
        }
        
        if (!mv2.KVector1.IsZero() && !mv2.KVector5.IsZero())
        {
            tempScalar0 += 2 * mv2.KVector1.Scalar2 * mv1.Scalar245 * mv2.KVector5.Scalar12345 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar345 * mv2.KVector5.Scalar12345;
            tempScalar1 += -2 * mv2.KVector1.Scalar2 * mv1.Scalar235 * mv2.KVector5.Scalar12345 + 2 * mv2.KVector1.Scalar4 * mv1.Scalar345 * mv2.KVector5.Scalar12345;
            tempScalar2 += -2 * mv2.KVector1.Scalar3 * mv1.Scalar235 * mv2.KVector5.Scalar12345 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar245 * mv2.KVector5.Scalar12345;
            tempScalar4 += 2 * mv2.KVector1.Scalar2 * mv1.Scalar234 * mv2.KVector5.Scalar12345 + 2 * mv2.KVector1.Scalar5 * mv1.Scalar345 * mv2.KVector5.Scalar12345;
            tempScalar5 += 2 * mv2.KVector1.Scalar3 * mv1.Scalar234 * mv2.KVector5.Scalar12345 - 2 * mv2.KVector1.Scalar5 * mv1.Scalar245 * mv2.KVector5.Scalar12345;
            tempScalar7 += 2 * mv2.KVector1.Scalar4 * mv1.Scalar234 * mv2.KVector5.Scalar12345 + 2 * mv2.KVector1.Scalar5 * mv1.Scalar235 * mv2.KVector5.Scalar12345;
        }
        
        if (!mv2.KVector3.IsZero() && !mv2.KVector1.IsZero())
        {
            tempScalar4 += 2 * mv2.KVector3.Scalar123 * mv1.Scalar345 * mv2.KVector1.Scalar4 + 2 * mv2.KVector3.Scalar134 * mv1.Scalar234 * mv2.KVector1.Scalar5 - 2 * mv2.KVector3.Scalar234 * mv1.Scalar134 * mv2.KVector1.Scalar5;
            tempScalar5 += -2 * mv2.KVector3.Scalar124 * mv1.Scalar234 * mv2.KVector1.Scalar5 - 2 * mv2.KVector3.Scalar123 * mv1.Scalar245 * mv2.KVector1.Scalar4 + 2 * mv2.KVector3.Scalar234 * mv1.Scalar124 * mv2.KVector1.Scalar5;
            tempScalar7 += 2 * mv2.KVector3.Scalar123 * mv1.Scalar234 * mv2.KVector1.Scalar5 - 2 * mv2.KVector3.Scalar234 * mv1.Scalar123 * mv2.KVector1.Scalar5;
        }
        
        if (!mv2.KVector3.IsZero())
        {
            tempScalar0 += mv2.KVector3.Scalar345 * mv1.Scalar123 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar123 * mv1.Scalar234 * mv2.KVector3.Scalar234 - 2 * mv2.KVector3.Scalar124 * mv1.Scalar245 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar234 * mv1.Scalar245 * mv2.KVector3.Scalar125 - mv2.KVector3.Scalar234 * mv1.Scalar123 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar235 * mv1.Scalar123 * mv2.KVector3.Scalar235 - mv2.KVector3.Scalar245 * mv1.Scalar123 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar123 * mv1.Scalar235 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar123 * mv1.Scalar245 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar235 * mv1.Scalar124 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar135 * mv1.Scalar234 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar124 * mv1.Scalar235 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar134 * mv1.Scalar235 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar234 * mv1.Scalar125 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar125 * mv1.Scalar234 * mv2.KVector3.Scalar245;
            tempScalar1 += 2 * mv2.KVector3.Scalar234 * mv1.Scalar345 * mv2.KVector3.Scalar145 - 2 * mv2.KVector3.Scalar134 * mv1.Scalar345 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar245 * mv1.Scalar134 * mv2.KVector3.Scalar345 - mv2.KVector3.Scalar345 * mv1.Scalar124 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar123 * mv1.Scalar245 * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar234 * mv1.Scalar124 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar245 * mv1.Scalar124 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar124 * mv1.Scalar245 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar124 * mv1.Scalar345 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar134 * mv1.Scalar245 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar235 * mv1.Scalar124 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar234 * mv1.Scalar125 * mv2.KVector3.Scalar235;
            tempScalar2 += -2 * mv2.KVector3.Scalar234 * mv1.Scalar235 * mv2.KVector3.Scalar135 + 2 * mv2.KVector3.Scalar145 * mv1.Scalar234 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar235 * mv1.Scalar123 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar123 * mv1.Scalar235 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar123 * mv1.Scalar345 * mv2.KVector3.Scalar235 - mv2.KVector3.Scalar234 * mv1.Scalar134 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar345 * mv1.Scalar134 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar134 * mv1.Scalar234 * mv2.KVector3.Scalar234 + 2 * mv2.KVector3.Scalar124 * mv1.Scalar345 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar134 * mv1.Scalar235 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar134 * mv1.Scalar345 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar245 * mv1.Scalar134 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar235 * mv1.Scalar134 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar135 * mv1.Scalar234 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar234 * mv1.Scalar135 * mv2.KVector3.Scalar235;
            tempScalar3 += -mv2.KVector3.Scalar234 * mv1.Scalar234 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar235 * mv1.Scalar234 * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar245 * mv1.Scalar234 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar234 * mv1.Scalar235 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar234 * mv1.Scalar345 * mv2.KVector3.Scalar345 - mv2.KVector3.Scalar345 * mv1.Scalar234 * mv2.KVector3.Scalar345;
            tempScalar4 += mv2.KVector3.Scalar345 * mv1.Scalar125 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar123 * mv1.Scalar234 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar234 * mv1.Scalar125 * mv2.KVector3.Scalar234 + 2 * mv2.KVector3.Scalar245 * mv1.Scalar135 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar124 * mv1.Scalar234 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar234 * mv1.Scalar234 * mv2.KVector3.Scalar125 + mv2.KVector3.Scalar235 * mv1.Scalar125 * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar245 * mv1.Scalar125 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar235 * mv1.Scalar145 * mv2.KVector3.Scalar345;
            tempScalar5 += -2 * mv2.KVector3.Scalar135 * mv1.Scalar245 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar125 * mv1.Scalar245 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar235 * mv1.Scalar245 * mv2.KVector3.Scalar145 - 2 * mv2.KVector3.Scalar235 * mv1.Scalar145 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar234 * mv1.Scalar135 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar245 * mv1.Scalar135 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar134 * mv1.Scalar235 * mv2.KVector3.Scalar234 - 2 * mv2.KVector3.Scalar145 * mv1.Scalar235 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar234 * mv1.Scalar123 * mv2.KVector3.Scalar345 - mv2.KVector3.Scalar235 * mv1.Scalar135 * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar345 * mv1.Scalar135 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar135 * mv1.Scalar235 * mv2.KVector3.Scalar235;
            tempScalar6 += -2 * mv2.KVector3.Scalar235 * mv1.Scalar245 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar234 * mv1.Scalar235 * mv2.KVector3.Scalar234 + mv2.KVector3.Scalar345 * mv1.Scalar235 * mv2.KVector3.Scalar345 - mv2.KVector3.Scalar235 * mv1.Scalar235 * mv2.KVector3.Scalar235 - mv2.KVector3.Scalar245 * mv1.Scalar235 * mv2.KVector3.Scalar245;
            tempScalar7 += mv2.KVector3.Scalar235 * mv1.Scalar145 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar134 * mv1.Scalar245 * mv2.KVector3.Scalar234 + 2 * mv2.KVector3.Scalar135 * mv1.Scalar245 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar124 * mv1.Scalar345 * mv2.KVector3.Scalar234 - 2 * mv2.KVector3.Scalar145 * mv1.Scalar345 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar125 * mv1.Scalar345 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar124 * mv1.Scalar234 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar134 * mv1.Scalar234 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar234 * mv1.Scalar124 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar234 * mv1.Scalar134 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar234 * mv1.Scalar234 * mv2.KVector3.Scalar145 - mv2.KVector3.Scalar234 * mv1.Scalar145 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar245 * mv1.Scalar145 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar345 * mv1.Scalar145 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar145 * mv1.Scalar245 * mv2.KVector3.Scalar245;
            tempScalar8 += -2 * mv2.KVector3.Scalar245 * mv1.Scalar345 * mv2.KVector3.Scalar345 - mv2.KVector3.Scalar234 * mv1.Scalar245 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar245 * mv1.Scalar245 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar234 * mv1.Scalar234 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar345 * mv1.Scalar245 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar235 * mv1.Scalar245 * mv2.KVector3.Scalar235;
            tempScalar9 += -2 * mv2.KVector3.Scalar235 * mv1.Scalar235 * mv2.KVector3.Scalar345 - mv2.KVector3.Scalar345 * mv1.Scalar345 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar234 * mv1.Scalar345 * mv2.KVector3.Scalar234 + mv2.KVector3.Scalar245 * mv1.Scalar345 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar235 * mv1.Scalar345 * mv2.KVector3.Scalar235;
        }
        
        if (!mv2.KVector3.IsZero() && !mv2.KVector5.IsZero())
        {
            tempScalar0 += -2 * mv2.KVector3.Scalar234 * mv1.Scalar235 * mv2.KVector5.Scalar12345;
            tempScalar2 += -2 * mv2.KVector3.Scalar234 * mv1.Scalar345 * mv2.KVector5.Scalar12345;
            tempScalar4 += 2 * mv2.KVector3.Scalar245 * mv1.Scalar235 * mv2.KVector5.Scalar12345;
            tempScalar5 += -2 * mv2.KVector3.Scalar235 * mv1.Scalar345 * mv2.KVector5.Scalar12345 + 2 * mv2.KVector3.Scalar345 * mv1.Scalar235 * mv2.KVector5.Scalar12345;
            tempScalar7 += -2 * mv2.KVector3.Scalar245 * mv1.Scalar345 * mv2.KVector5.Scalar12345;
        }
        
        return new Ga401KVector3
        {
            Scalar123 = (tempScalar0) * mv2NormSquaredInv,
            Scalar124 = (tempScalar1) * mv2NormSquaredInv,
            Scalar134 = (tempScalar2) * mv2NormSquaredInv,
            Scalar234 = (tempScalar3) * mv2NormSquaredInv,
            Scalar125 = (tempScalar4) * mv2NormSquaredInv,
            Scalar135 = (tempScalar5) * mv2NormSquaredInv,
            Scalar235 = (tempScalar6) * mv2NormSquaredInv,
            Scalar145 = (tempScalar7) * mv2NormSquaredInv,
            Scalar245 = (tempScalar8) * mv2NormSquaredInv,
            Scalar345 = (tempScalar9) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector4 MapUsingVersor(this Ga401KVector4 mv1, Ga401KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector4.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector4
        {
            Scalar1234 = (mv2.Scalar * mv1.Scalar1234 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar1235 = (mv2.Scalar * mv1.Scalar1235 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar1245 = (mv2.Scalar * mv1.Scalar1245 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar1345 = (mv2.Scalar * mv1.Scalar1345 * mv2.Scalar) * mv2NormSquaredInv,
            Scalar2345 = (mv2.Scalar * mv1.Scalar2345 * mv2.Scalar) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector4 MapUsingVersor(this Ga401KVector4 mv1, Ga401KVector1 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector4.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector4
        {
            Scalar1234 = (2 * mv2.Scalar1 * mv1.Scalar2345 * mv2.Scalar5 - mv2.Scalar2 * mv1.Scalar1234 * mv2.Scalar2 - 2 * mv2.Scalar2 * mv1.Scalar1345 * mv2.Scalar5 - mv2.Scalar3 * mv1.Scalar1234 * mv2.Scalar3 + 2 * mv2.Scalar3 * mv1.Scalar1245 * mv2.Scalar5 - mv2.Scalar4 * mv1.Scalar1234 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.Scalar1235 * mv2.Scalar5 + mv2.Scalar5 * mv1.Scalar1234 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar1235 = (-2 * mv2.Scalar1 * mv1.Scalar2345 * mv2.Scalar4 - mv2.Scalar2 * mv1.Scalar1235 * mv2.Scalar2 + 2 * mv2.Scalar2 * mv1.Scalar1345 * mv2.Scalar4 - mv2.Scalar3 * mv1.Scalar1235 * mv2.Scalar3 - 2 * mv2.Scalar3 * mv1.Scalar1245 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.Scalar1234 * mv2.Scalar5 + mv2.Scalar4 * mv1.Scalar1235 * mv2.Scalar4 - mv2.Scalar5 * mv1.Scalar1235 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar1245 = (2 * mv2.Scalar1 * mv1.Scalar2345 * mv2.Scalar3 - mv2.Scalar2 * mv1.Scalar1245 * mv2.Scalar2 - 2 * mv2.Scalar2 * mv1.Scalar1345 * mv2.Scalar3 + 2 * mv2.Scalar3 * mv1.Scalar1234 * mv2.Scalar5 - 2 * mv2.Scalar3 * mv1.Scalar1235 * mv2.Scalar4 + mv2.Scalar3 * mv1.Scalar1245 * mv2.Scalar3 - mv2.Scalar4 * mv1.Scalar1245 * mv2.Scalar4 - mv2.Scalar5 * mv1.Scalar1245 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar1345 = (-2 * mv2.Scalar1 * mv1.Scalar2345 * mv2.Scalar2 - 2 * mv2.Scalar2 * mv1.Scalar1234 * mv2.Scalar5 + 2 * mv2.Scalar2 * mv1.Scalar1235 * mv2.Scalar4 - 2 * mv2.Scalar2 * mv1.Scalar1245 * mv2.Scalar3 + mv2.Scalar2 * mv1.Scalar1345 * mv2.Scalar2 - mv2.Scalar3 * mv1.Scalar1345 * mv2.Scalar3 - mv2.Scalar4 * mv1.Scalar1345 * mv2.Scalar4 - mv2.Scalar5 * mv1.Scalar1345 * mv2.Scalar5) * mv2NormSquaredInv,
            Scalar2345 = (-mv2.Scalar2 * mv1.Scalar2345 * mv2.Scalar2 - mv2.Scalar3 * mv1.Scalar2345 * mv2.Scalar3 - mv2.Scalar4 * mv1.Scalar2345 * mv2.Scalar4 - mv2.Scalar5 * mv1.Scalar2345 * mv2.Scalar5) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector4 MapUsingVersor(this Ga401KVector4 mv1, Ga401KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector4.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector4
        {
            Scalar1234 = (-mv2.Scalar23 * mv1.Scalar1234 * mv2.Scalar23 - 2 * mv2.Scalar23 * mv1.Scalar1345 * mv2.Scalar35 + mv2.Scalar24 * mv1.Scalar1234 * mv2.Scalar24 + mv2.Scalar25 * mv1.Scalar1234 * mv2.Scalar25 + mv2.Scalar45 * mv1.Scalar1234 * mv2.Scalar45 + 2 * mv2.Scalar24 * mv1.Scalar1235 * mv2.Scalar25 + 2 * mv2.Scalar24 * mv1.Scalar1345 * mv2.Scalar45 - mv2.Scalar34 * mv1.Scalar1234 * mv2.Scalar34 - mv2.Scalar35 * mv1.Scalar1234 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.Scalar1235 * mv2.Scalar35) * mv2NormSquaredInv,
            Scalar1235 = (-2 * mv2.Scalar12 * mv1.Scalar2345 * mv2.Scalar24 + 2 * mv2.Scalar13 * mv1.Scalar2345 * mv2.Scalar34 - mv2.Scalar35 * mv1.Scalar1235 * mv2.Scalar35 - mv2.Scalar23 * mv1.Scalar1235 * mv2.Scalar23 - mv2.Scalar24 * mv1.Scalar1235 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.Scalar1245 * mv2.Scalar24 + mv2.Scalar34 * mv1.Scalar1235 * mv2.Scalar34 - 2 * mv2.Scalar15 * mv1.Scalar2345 * mv2.Scalar45 + mv2.Scalar25 * mv1.Scalar1235 * mv2.Scalar25 - mv2.Scalar45 * mv1.Scalar1235 * mv2.Scalar45 - 2 * mv2.Scalar35 * mv1.Scalar1245 * mv2.Scalar45) * mv2NormSquaredInv,
            Scalar1245 = (2 * mv2.Scalar23 * mv1.Scalar1234 * mv2.Scalar25 + mv2.Scalar23 * mv1.Scalar1245 * mv2.Scalar23 + mv2.Scalar25 * mv1.Scalar1245 * mv2.Scalar25 - mv2.Scalar24 * mv1.Scalar1245 * mv2.Scalar24 - mv2.Scalar34 * mv1.Scalar1245 * mv2.Scalar34 - 2 * mv2.Scalar24 * mv1.Scalar1345 * mv2.Scalar34 - 2 * mv2.Scalar34 * mv1.Scalar1234 * mv2.Scalar45 - mv2.Scalar45 * mv1.Scalar1245 * mv2.Scalar45 + mv2.Scalar35 * mv1.Scalar1245 * mv2.Scalar35 + 2 * mv2.Scalar25 * mv1.Scalar1345 * mv2.Scalar35) * mv2NormSquaredInv,
            Scalar1345 = (-2 * mv2.Scalar13 * mv1.Scalar2345 * mv2.Scalar23 - 2 * mv2.Scalar23 * mv1.Scalar1235 * mv2.Scalar34 - mv2.Scalar23 * mv1.Scalar1345 * mv2.Scalar23 - mv2.Scalar34 * mv1.Scalar1345 * mv2.Scalar34 + 2 * mv2.Scalar14 * mv1.Scalar2345 * mv2.Scalar24 + mv2.Scalar24 * mv1.Scalar1345 * mv2.Scalar24 - 2 * mv2.Scalar15 * mv1.Scalar2345 * mv2.Scalar25 - 2 * mv2.Scalar25 * mv1.Scalar1235 * mv2.Scalar45 - mv2.Scalar25 * mv1.Scalar1345 * mv2.Scalar25 - mv2.Scalar45 * mv1.Scalar1345 * mv2.Scalar45 + mv2.Scalar35 * mv1.Scalar1345 * mv2.Scalar35) * mv2NormSquaredInv,
            Scalar2345 = (-mv2.Scalar23 * mv1.Scalar2345 * mv2.Scalar23 - mv2.Scalar25 * mv1.Scalar2345 * mv2.Scalar25 - mv2.Scalar34 * mv1.Scalar2345 * mv2.Scalar34 - mv2.Scalar45 * mv1.Scalar2345 * mv2.Scalar45 + mv2.Scalar24 * mv1.Scalar2345 * mv2.Scalar24 + mv2.Scalar35 * mv1.Scalar2345 * mv2.Scalar35) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector4 MapUsingVersor(this Ga401KVector4 mv1, Ga401KVector3 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector4.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector4
        {
            Scalar1234 = (-mv2.Scalar234 * mv1.Scalar1234 * mv2.Scalar234 - mv2.Scalar235 * mv1.Scalar1234 * mv2.Scalar235 - mv2.Scalar345 * mv1.Scalar1234 * mv2.Scalar345 - 2 * mv2.Scalar234 * mv1.Scalar1235 * mv2.Scalar235 - 2 * mv2.Scalar234 * mv1.Scalar1345 * mv2.Scalar345 + mv2.Scalar245 * mv1.Scalar1234 * mv2.Scalar245) * mv2NormSquaredInv,
            Scalar1235 = (2 * mv2.Scalar123 * mv1.Scalar2345 * mv2.Scalar234 + mv2.Scalar234 * mv1.Scalar1235 * mv2.Scalar234 - 2 * mv2.Scalar125 * mv1.Scalar2345 * mv2.Scalar245 + 2 * mv2.Scalar135 * mv1.Scalar2345 * mv2.Scalar345 - mv2.Scalar235 * mv1.Scalar1235 * mv2.Scalar235 - mv2.Scalar245 * mv1.Scalar1235 * mv2.Scalar245 - 2 * mv2.Scalar235 * mv1.Scalar1245 * mv2.Scalar245 + mv2.Scalar345 * mv1.Scalar1235 * mv2.Scalar345) * mv2NormSquaredInv,
            Scalar1245 = (-2 * mv2.Scalar234 * mv1.Scalar1234 * mv2.Scalar245 - mv2.Scalar234 * mv1.Scalar1245 * mv2.Scalar234 - mv2.Scalar245 * mv1.Scalar1245 * mv2.Scalar245 + mv2.Scalar235 * mv1.Scalar1245 * mv2.Scalar235 - mv2.Scalar345 * mv1.Scalar1245 * mv2.Scalar345 - 2 * mv2.Scalar245 * mv1.Scalar1345 * mv2.Scalar345) * mv2NormSquaredInv,
            Scalar1345 = (2 * mv2.Scalar145 * mv1.Scalar2345 * mv2.Scalar245 + 2 * mv2.Scalar134 * mv1.Scalar2345 * mv2.Scalar234 + mv2.Scalar234 * mv1.Scalar1345 * mv2.Scalar234 - 2 * mv2.Scalar135 * mv1.Scalar2345 * mv2.Scalar235 - 2 * mv2.Scalar235 * mv1.Scalar1235 * mv2.Scalar345 - mv2.Scalar235 * mv1.Scalar1345 * mv2.Scalar235 - mv2.Scalar345 * mv1.Scalar1345 * mv2.Scalar345 + mv2.Scalar245 * mv1.Scalar1345 * mv2.Scalar245) * mv2NormSquaredInv,
            Scalar2345 = (mv2.Scalar234 * mv1.Scalar2345 * mv2.Scalar234 + mv2.Scalar245 * mv1.Scalar2345 * mv2.Scalar245 - mv2.Scalar235 * mv1.Scalar2345 * mv2.Scalar235 - mv2.Scalar345 * mv1.Scalar2345 * mv2.Scalar345) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector4 MapUsingVersor(this Ga401KVector4 mv1, Ga401KVector4 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector4.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector4
        {
            Scalar1234 = (2 * mv2.Scalar1234 * mv1.Scalar2345 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.Scalar1234 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar1235 = (2 * mv2.Scalar1235 * mv1.Scalar2345 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.Scalar1235 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar1245 = (2 * mv2.Scalar1245 * mv1.Scalar2345 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.Scalar1245 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar1345 = (2 * mv2.Scalar1345 * mv1.Scalar2345 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.Scalar1345 * mv2.Scalar2345) * mv2NormSquaredInv,
            Scalar2345 = (mv2.Scalar2345 * mv1.Scalar2345 * mv2.Scalar2345) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector4 MapUsingVersor(this Ga401KVector4 mv1, Ga401KVector5 mv2)
    {
        return Ga401KVector4.Zero;
    }
    
    public static Ga401KVector4 MapUsingEvenVersor(this Ga401KVector4 mv1, Ga401Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector4.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
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
            Scalar1234 = (tempScalar0) * mv2NormSquaredInv,
            Scalar1235 = (tempScalar1) * mv2NormSquaredInv,
            Scalar1245 = (tempScalar2) * mv2NormSquaredInv,
            Scalar1345 = (tempScalar3) * mv2NormSquaredInv,
            Scalar2345 = (tempScalar4) * mv2NormSquaredInv
        };
    }
    
    public static Ga401KVector4 MapUsingOddVersor(this Ga401KVector4 mv1, Ga401Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector4.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        var tempScalar0 = 0d;
        var tempScalar1 = 0d;
        var tempScalar2 = 0d;
        var tempScalar3 = 0d;
        var tempScalar4 = 0d;
        
        if (!mv2.KVector1.IsZero())
        {
            tempScalar0 += 2 * mv2.KVector1.Scalar1 * mv1.Scalar2345 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar2 * mv1.Scalar1234 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar1345 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar3 * mv1.Scalar1234 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar1245 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar4 * mv1.Scalar1234 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar1235 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar5 * mv1.Scalar1234 * mv2.KVector1.Scalar5;
            tempScalar1 += -2 * mv2.KVector1.Scalar1 * mv1.Scalar2345 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar2 * mv1.Scalar1235 * mv2.KVector1.Scalar2 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar1345 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar3 * mv1.Scalar1235 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar1245 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar1234 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar4 * mv1.Scalar1235 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.Scalar1235 * mv2.KVector1.Scalar5;
            tempScalar2 += 2 * mv2.KVector1.Scalar1 * mv1.Scalar2345 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar2 * mv1.Scalar1245 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar1345 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar1234 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar1235 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar3 * mv1.Scalar1245 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.Scalar1245 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.Scalar1245 * mv2.KVector1.Scalar5;
            tempScalar3 += -2 * mv2.KVector1.Scalar1 * mv1.Scalar2345 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar1234 * mv2.KVector1.Scalar5 + 2 * mv2.KVector1.Scalar2 * mv1.Scalar1235 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar2 * mv1.Scalar1245 * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar2 * mv1.Scalar1345 * mv2.KVector1.Scalar2 - mv2.KVector1.Scalar3 * mv1.Scalar1345 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.Scalar1345 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.Scalar1345 * mv2.KVector1.Scalar5;
            tempScalar4 += -mv2.KVector1.Scalar2 * mv1.Scalar2345 * mv2.KVector1.Scalar2 - mv2.KVector1.Scalar3 * mv1.Scalar2345 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.Scalar2345 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.Scalar2345 * mv2.KVector1.Scalar5;
        }
        
        if (!mv2.KVector1.IsZero() && !mv2.KVector3.IsZero())
        {
            tempScalar0 += -2 * mv2.KVector1.Scalar2 * mv1.Scalar2345 * mv2.KVector3.Scalar125 - 2 * mv2.KVector1.Scalar3 * mv1.Scalar1235 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar1245 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar4 * mv1.Scalar1345 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar2345 * mv2.KVector3.Scalar145;
            tempScalar1 += 2 * mv2.KVector1.Scalar2 * mv1.Scalar2345 * mv2.KVector3.Scalar124 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar1234 * mv2.KVector3.Scalar345;
            tempScalar2 += -2 * mv2.KVector1.Scalar2 * mv1.Scalar2345 * mv2.KVector3.Scalar123 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar1345 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar4 * mv1.Scalar2345 * mv2.KVector3.Scalar134;
            tempScalar3 += -2 * mv2.KVector1.Scalar3 * mv1.Scalar1234 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar3 * mv1.Scalar1235 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar4 * mv1.Scalar1245 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar4 * mv1.Scalar2345 * mv2.KVector3.Scalar124;
        }
        
        if (!mv2.KVector3.IsZero())
        {
            tempScalar0 += mv2.KVector3.Scalar245 * mv1.Scalar1234 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar234 * mv1.Scalar1234 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar235 * mv1.Scalar1234 * mv2.KVector3.Scalar235 - mv2.KVector3.Scalar345 * mv1.Scalar1234 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar234 * mv1.Scalar1235 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar234 * mv1.Scalar1345 * mv2.KVector3.Scalar345;
            tempScalar1 += -mv2.KVector3.Scalar235 * mv1.Scalar1235 * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar234 * mv1.Scalar1235 * mv2.KVector3.Scalar234 - 2 * mv2.KVector3.Scalar235 * mv1.Scalar1245 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar123 * mv1.Scalar2345 * mv2.KVector3.Scalar234 + 2 * mv2.KVector3.Scalar135 * mv1.Scalar2345 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar345 * mv1.Scalar1235 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar125 * mv1.Scalar2345 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar245 * mv1.Scalar1235 * mv2.KVector3.Scalar245;
            tempScalar2 += -2 * mv2.KVector3.Scalar245 * mv1.Scalar1345 * mv2.KVector3.Scalar345 - mv2.KVector3.Scalar234 * mv1.Scalar1245 * mv2.KVector3.Scalar234 - 2 * mv2.KVector3.Scalar234 * mv1.Scalar1234 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar245 * mv1.Scalar1245 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar345 * mv1.Scalar1245 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar235 * mv1.Scalar1245 * mv2.KVector3.Scalar235;
            tempScalar3 += mv2.KVector3.Scalar234 * mv1.Scalar1345 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar345 * mv1.Scalar1345 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar134 * mv1.Scalar2345 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar235 * mv1.Scalar1345 * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar245 * mv1.Scalar1345 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar135 * mv1.Scalar2345 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar145 * mv1.Scalar2345 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar235 * mv1.Scalar1235 * mv2.KVector3.Scalar345;
            tempScalar4 += mv2.KVector3.Scalar234 * mv1.Scalar2345 * mv2.KVector3.Scalar234 + mv2.KVector3.Scalar245 * mv1.Scalar2345 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar235 * mv1.Scalar2345 * mv2.KVector3.Scalar235 - mv2.KVector3.Scalar345 * mv1.Scalar2345 * mv2.KVector3.Scalar345;
        }
        
        if (!mv2.KVector3.IsZero() && !mv2.KVector5.IsZero())
        {
            tempScalar0 += -2 * mv2.KVector3.Scalar234 * mv1.Scalar2345 * mv2.KVector5.Scalar12345;
            tempScalar1 += -2 * mv2.KVector3.Scalar235 * mv1.Scalar2345 * mv2.KVector5.Scalar12345;
            tempScalar2 += -2 * mv2.KVector3.Scalar245 * mv1.Scalar2345 * mv2.KVector5.Scalar12345;
            tempScalar3 += -2 * mv2.KVector3.Scalar345 * mv1.Scalar2345 * mv2.KVector5.Scalar12345;
        }
        
        return new Ga401KVector4
        {
            Scalar1234 = (tempScalar0) * mv2NormSquaredInv,
            Scalar1235 = (tempScalar1) * mv2NormSquaredInv,
            Scalar1245 = (tempScalar2) * mv2NormSquaredInv,
            Scalar1345 = (tempScalar3) * mv2NormSquaredInv,
            Scalar2345 = (tempScalar4) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector5 MapUsingVersor(this Ga401KVector5 mv1, Ga401KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector5.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector5
        {
            Scalar12345 = (mv2.Scalar * mv1.Scalar12345 * mv2.Scalar) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector5 MapUsingVersor(this Ga401KVector5 mv1, Ga401KVector1 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector5.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector5
        {
            Scalar12345 = (-mv2.Scalar2 * mv1.Scalar12345 * mv2.Scalar2 - mv2.Scalar3 * mv1.Scalar12345 * mv2.Scalar3 - mv2.Scalar4 * mv1.Scalar12345 * mv2.Scalar4 - mv2.Scalar5 * mv1.Scalar12345 * mv2.Scalar5) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector5 MapUsingVersor(this Ga401KVector5 mv1, Ga401KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector5.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector5
        {
            Scalar12345 = (-mv2.Scalar23 * mv1.Scalar12345 * mv2.Scalar23 + mv2.Scalar24 * mv1.Scalar12345 * mv2.Scalar24 - mv2.Scalar34 * mv1.Scalar12345 * mv2.Scalar34 - mv2.Scalar25 * mv1.Scalar12345 * mv2.Scalar25 + mv2.Scalar35 * mv1.Scalar12345 * mv2.Scalar35 - mv2.Scalar45 * mv1.Scalar12345 * mv2.Scalar45) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector5 MapUsingVersor(this Ga401KVector5 mv1, Ga401KVector3 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector5.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector5
        {
            Scalar12345 = (mv2.Scalar234 * mv1.Scalar12345 * mv2.Scalar234 - mv2.Scalar235 * mv1.Scalar12345 * mv2.Scalar235 + mv2.Scalar245 * mv1.Scalar12345 * mv2.Scalar245 - mv2.Scalar345 * mv1.Scalar12345 * mv2.Scalar345) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector5 MapUsingVersor(this Ga401KVector5 mv1, Ga401KVector4 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector5.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        return new Ga401KVector5
        {
            Scalar12345 = (mv2.Scalar2345 * mv1.Scalar12345 * mv2.Scalar2345) * mv2NormSquaredInv
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401KVector5 MapUsingVersor(this Ga401KVector5 mv1, Ga401KVector5 mv2)
    {
        return Ga401KVector5.Zero;
    }
    
    public static Ga401KVector5 MapUsingEvenVersor(this Ga401KVector5 mv1, Ga401Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector5.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
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
            Scalar12345 = (tempScalar) * mv2NormSquaredInv
        };
    }
    
    public static Ga401KVector5 MapUsingOddVersor(this Ga401KVector5 mv1, Ga401Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401KVector5.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        var tempScalar = 0d;
        
        if (!mv2.KVector1.IsZero())
        {
            tempScalar += -mv2.KVector1.Scalar2 * mv1.Scalar12345 * mv2.KVector1.Scalar2 - mv2.KVector1.Scalar3 * mv1.Scalar12345 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.Scalar12345 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.Scalar12345 * mv2.KVector1.Scalar5;
        }
        
        if (!mv2.KVector3.IsZero())
        {
            tempScalar += mv2.KVector3.Scalar234 * mv1.Scalar12345 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar235 * mv1.Scalar12345 * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar245 * mv1.Scalar12345 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar345 * mv1.Scalar12345 * mv2.KVector3.Scalar345;
        }
        
        return new Ga401KVector5
        {
            Scalar12345 = (tempScalar) * mv2NormSquaredInv
        };
    }
    
    public static Ga401Multivector MapUsingVersor(this Ga401Multivector mv1, Ga401KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401Multivector.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        var tempScalar = new double[32];
        
        if (!mv1.KVector0.IsZero())
        {
            tempScalar[0] += (mv2.Scalar * mv1.KVector0.Scalar * mv2.Scalar) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector1.IsZero())
        {
            tempScalar[1] += (mv2.Scalar * mv1.KVector1.Scalar1 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[2] += (mv2.Scalar * mv1.KVector1.Scalar2 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[4] += (mv2.Scalar * mv1.KVector1.Scalar3 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[8] += (mv2.Scalar * mv1.KVector1.Scalar4 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[16] += (mv2.Scalar * mv1.KVector1.Scalar5 * mv2.Scalar) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector2.IsZero())
        {
            tempScalar[3] += (mv2.Scalar * mv1.KVector2.Scalar12 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[5] += (mv2.Scalar * mv1.KVector2.Scalar13 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[6] += (mv2.Scalar * mv1.KVector2.Scalar23 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[9] += (mv2.Scalar * mv1.KVector2.Scalar14 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[10] += (mv2.Scalar * mv1.KVector2.Scalar24 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[12] += (mv2.Scalar * mv1.KVector2.Scalar34 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[17] += (mv2.Scalar * mv1.KVector2.Scalar15 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[18] += (mv2.Scalar * mv1.KVector2.Scalar25 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[20] += (mv2.Scalar * mv1.KVector2.Scalar35 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[24] += (mv2.Scalar * mv1.KVector2.Scalar45 * mv2.Scalar) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector3.IsZero())
        {
            tempScalar[7] += (mv2.Scalar * mv1.KVector3.Scalar123 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[11] += (mv2.Scalar * mv1.KVector3.Scalar124 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[13] += (mv2.Scalar * mv1.KVector3.Scalar134 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[14] += (mv2.Scalar * mv1.KVector3.Scalar234 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[19] += (mv2.Scalar * mv1.KVector3.Scalar125 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[21] += (mv2.Scalar * mv1.KVector3.Scalar135 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[22] += (mv2.Scalar * mv1.KVector3.Scalar235 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[25] += (mv2.Scalar * mv1.KVector3.Scalar145 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[26] += (mv2.Scalar * mv1.KVector3.Scalar245 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[28] += (mv2.Scalar * mv1.KVector3.Scalar345 * mv2.Scalar) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector4.IsZero())
        {
            tempScalar[15] += (mv2.Scalar * mv1.KVector4.Scalar1234 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[23] += (mv2.Scalar * mv1.KVector4.Scalar1235 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[27] += (mv2.Scalar * mv1.KVector4.Scalar1245 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[29] += (mv2.Scalar * mv1.KVector4.Scalar1345 * mv2.Scalar) * mv2NormSquaredInv;
            tempScalar[30] += (mv2.Scalar * mv1.KVector4.Scalar2345 * mv2.Scalar) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector5.IsZero())
        {
            tempScalar[31] += (mv2.Scalar * mv1.KVector5.Scalar12345 * mv2.Scalar) * mv2NormSquaredInv;
        }
        
        return Ga401Multivector.Create(tempScalar);
    }
    
    public static Ga401Multivector MapUsingVersor(this Ga401Multivector mv1, Ga401KVector1 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401Multivector.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        var tempScalar = new double[32];
        
        if (!mv1.KVector0.IsZero())
        {
            tempScalar[0] += (mv2.Scalar2 * mv1.KVector0.Scalar * mv2.Scalar2 + mv2.Scalar3 * mv1.KVector0.Scalar * mv2.Scalar3 + mv2.Scalar4 * mv1.KVector0.Scalar * mv2.Scalar4 + mv2.Scalar5 * mv1.KVector0.Scalar * mv2.Scalar5) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector1.IsZero())
        {
            tempScalar[1] += (-2 * mv2.Scalar1 * mv1.KVector1.Scalar2 * mv2.Scalar2 - 2 * mv2.Scalar1 * mv1.KVector1.Scalar3 * mv2.Scalar3 - 2 * mv2.Scalar1 * mv1.KVector1.Scalar4 * mv2.Scalar4 - 2 * mv2.Scalar1 * mv1.KVector1.Scalar5 * mv2.Scalar5 + mv2.Scalar2 * mv1.KVector1.Scalar1 * mv2.Scalar2 + mv2.Scalar3 * mv1.KVector1.Scalar1 * mv2.Scalar3 + mv2.Scalar4 * mv1.KVector1.Scalar1 * mv2.Scalar4 + mv2.Scalar5 * mv1.KVector1.Scalar1 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[2] += (-mv2.Scalar2 * mv1.KVector1.Scalar2 * mv2.Scalar2 - 2 * mv2.Scalar2 * mv1.KVector1.Scalar3 * mv2.Scalar3 - 2 * mv2.Scalar2 * mv1.KVector1.Scalar4 * mv2.Scalar4 - 2 * mv2.Scalar2 * mv1.KVector1.Scalar5 * mv2.Scalar5 + mv2.Scalar3 * mv1.KVector1.Scalar2 * mv2.Scalar3 + mv2.Scalar4 * mv1.KVector1.Scalar2 * mv2.Scalar4 + mv2.Scalar5 * mv1.KVector1.Scalar2 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[4] += (-2 * mv2.Scalar2 * mv1.KVector1.Scalar2 * mv2.Scalar3 + mv2.Scalar2 * mv1.KVector1.Scalar3 * mv2.Scalar2 - mv2.Scalar3 * mv1.KVector1.Scalar3 * mv2.Scalar3 - 2 * mv2.Scalar3 * mv1.KVector1.Scalar4 * mv2.Scalar4 - 2 * mv2.Scalar3 * mv1.KVector1.Scalar5 * mv2.Scalar5 + mv2.Scalar4 * mv1.KVector1.Scalar3 * mv2.Scalar4 + mv2.Scalar5 * mv1.KVector1.Scalar3 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[8] += (-2 * mv2.Scalar2 * mv1.KVector1.Scalar2 * mv2.Scalar4 + mv2.Scalar2 * mv1.KVector1.Scalar4 * mv2.Scalar2 - 2 * mv2.Scalar3 * mv1.KVector1.Scalar3 * mv2.Scalar4 + mv2.Scalar3 * mv1.KVector1.Scalar4 * mv2.Scalar3 - mv2.Scalar4 * mv1.KVector1.Scalar4 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.KVector1.Scalar5 * mv2.Scalar5 + mv2.Scalar5 * mv1.KVector1.Scalar4 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[16] += (-2 * mv2.Scalar2 * mv1.KVector1.Scalar2 * mv2.Scalar5 + mv2.Scalar2 * mv1.KVector1.Scalar5 * mv2.Scalar2 - 2 * mv2.Scalar3 * mv1.KVector1.Scalar3 * mv2.Scalar5 + mv2.Scalar3 * mv1.KVector1.Scalar5 * mv2.Scalar3 - 2 * mv2.Scalar4 * mv1.KVector1.Scalar4 * mv2.Scalar5 + mv2.Scalar4 * mv1.KVector1.Scalar5 * mv2.Scalar4 - mv2.Scalar5 * mv1.KVector1.Scalar5 * mv2.Scalar5) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector2.IsZero())
        {
            tempScalar[3] += (2 * mv2.Scalar1 * mv1.KVector2.Scalar23 * mv2.Scalar3 + 2 * mv2.Scalar1 * mv1.KVector2.Scalar24 * mv2.Scalar4 + 2 * mv2.Scalar1 * mv1.KVector2.Scalar25 * mv2.Scalar5 - mv2.Scalar2 * mv1.KVector2.Scalar12 * mv2.Scalar2 - 2 * mv2.Scalar2 * mv1.KVector2.Scalar13 * mv2.Scalar3 - 2 * mv2.Scalar2 * mv1.KVector2.Scalar14 * mv2.Scalar4 - 2 * mv2.Scalar2 * mv1.KVector2.Scalar15 * mv2.Scalar5 + mv2.Scalar3 * mv1.KVector2.Scalar12 * mv2.Scalar3 + mv2.Scalar4 * mv1.KVector2.Scalar12 * mv2.Scalar4 + mv2.Scalar5 * mv1.KVector2.Scalar12 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[5] += (-2 * mv2.Scalar1 * mv1.KVector2.Scalar23 * mv2.Scalar2 + 2 * mv2.Scalar1 * mv1.KVector2.Scalar34 * mv2.Scalar4 + 2 * mv2.Scalar1 * mv1.KVector2.Scalar35 * mv2.Scalar5 - 2 * mv2.Scalar2 * mv1.KVector2.Scalar12 * mv2.Scalar3 + mv2.Scalar2 * mv1.KVector2.Scalar13 * mv2.Scalar2 - mv2.Scalar3 * mv1.KVector2.Scalar13 * mv2.Scalar3 - 2 * mv2.Scalar3 * mv1.KVector2.Scalar14 * mv2.Scalar4 - 2 * mv2.Scalar3 * mv1.KVector2.Scalar15 * mv2.Scalar5 + mv2.Scalar4 * mv1.KVector2.Scalar13 * mv2.Scalar4 + mv2.Scalar5 * mv1.KVector2.Scalar13 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[6] += (-mv2.Scalar2 * mv1.KVector2.Scalar23 * mv2.Scalar2 + 2 * mv2.Scalar2 * mv1.KVector2.Scalar34 * mv2.Scalar4 + 2 * mv2.Scalar2 * mv1.KVector2.Scalar35 * mv2.Scalar5 - mv2.Scalar3 * mv1.KVector2.Scalar23 * mv2.Scalar3 - 2 * mv2.Scalar3 * mv1.KVector2.Scalar24 * mv2.Scalar4 - 2 * mv2.Scalar3 * mv1.KVector2.Scalar25 * mv2.Scalar5 + mv2.Scalar4 * mv1.KVector2.Scalar23 * mv2.Scalar4 + mv2.Scalar5 * mv1.KVector2.Scalar23 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[9] += (-2 * mv2.Scalar1 * mv1.KVector2.Scalar24 * mv2.Scalar2 - 2 * mv2.Scalar1 * mv1.KVector2.Scalar34 * mv2.Scalar3 + 2 * mv2.Scalar1 * mv1.KVector2.Scalar45 * mv2.Scalar5 - 2 * mv2.Scalar2 * mv1.KVector2.Scalar12 * mv2.Scalar4 + mv2.Scalar2 * mv1.KVector2.Scalar14 * mv2.Scalar2 - 2 * mv2.Scalar3 * mv1.KVector2.Scalar13 * mv2.Scalar4 + mv2.Scalar3 * mv1.KVector2.Scalar14 * mv2.Scalar3 - mv2.Scalar4 * mv1.KVector2.Scalar14 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.KVector2.Scalar15 * mv2.Scalar5 + mv2.Scalar5 * mv1.KVector2.Scalar14 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[10] += (-mv2.Scalar2 * mv1.KVector2.Scalar24 * mv2.Scalar2 - 2 * mv2.Scalar2 * mv1.KVector2.Scalar34 * mv2.Scalar3 + 2 * mv2.Scalar2 * mv1.KVector2.Scalar45 * mv2.Scalar5 - 2 * mv2.Scalar3 * mv1.KVector2.Scalar23 * mv2.Scalar4 + mv2.Scalar3 * mv1.KVector2.Scalar24 * mv2.Scalar3 - mv2.Scalar4 * mv1.KVector2.Scalar24 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.KVector2.Scalar25 * mv2.Scalar5 + mv2.Scalar5 * mv1.KVector2.Scalar24 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[12] += (2 * mv2.Scalar2 * mv1.KVector2.Scalar23 * mv2.Scalar4 - 2 * mv2.Scalar2 * mv1.KVector2.Scalar24 * mv2.Scalar3 + mv2.Scalar2 * mv1.KVector2.Scalar34 * mv2.Scalar2 - mv2.Scalar3 * mv1.KVector2.Scalar34 * mv2.Scalar3 + 2 * mv2.Scalar3 * mv1.KVector2.Scalar45 * mv2.Scalar5 - mv2.Scalar4 * mv1.KVector2.Scalar34 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.KVector2.Scalar35 * mv2.Scalar5 + mv2.Scalar5 * mv1.KVector2.Scalar34 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[17] += (-2 * mv2.Scalar1 * mv1.KVector2.Scalar25 * mv2.Scalar2 - 2 * mv2.Scalar1 * mv1.KVector2.Scalar35 * mv2.Scalar3 - 2 * mv2.Scalar1 * mv1.KVector2.Scalar45 * mv2.Scalar4 - 2 * mv2.Scalar2 * mv1.KVector2.Scalar12 * mv2.Scalar5 + mv2.Scalar2 * mv1.KVector2.Scalar15 * mv2.Scalar2 - 2 * mv2.Scalar3 * mv1.KVector2.Scalar13 * mv2.Scalar5 + mv2.Scalar3 * mv1.KVector2.Scalar15 * mv2.Scalar3 - 2 * mv2.Scalar4 * mv1.KVector2.Scalar14 * mv2.Scalar5 + mv2.Scalar4 * mv1.KVector2.Scalar15 * mv2.Scalar4 - mv2.Scalar5 * mv1.KVector2.Scalar15 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[18] += (-mv2.Scalar2 * mv1.KVector2.Scalar25 * mv2.Scalar2 - 2 * mv2.Scalar2 * mv1.KVector2.Scalar35 * mv2.Scalar3 - 2 * mv2.Scalar2 * mv1.KVector2.Scalar45 * mv2.Scalar4 - 2 * mv2.Scalar3 * mv1.KVector2.Scalar23 * mv2.Scalar5 + mv2.Scalar3 * mv1.KVector2.Scalar25 * mv2.Scalar3 - 2 * mv2.Scalar4 * mv1.KVector2.Scalar24 * mv2.Scalar5 + mv2.Scalar4 * mv1.KVector2.Scalar25 * mv2.Scalar4 - mv2.Scalar5 * mv1.KVector2.Scalar25 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[20] += (2 * mv2.Scalar2 * mv1.KVector2.Scalar23 * mv2.Scalar5 - 2 * mv2.Scalar2 * mv1.KVector2.Scalar25 * mv2.Scalar3 + mv2.Scalar2 * mv1.KVector2.Scalar35 * mv2.Scalar2 - mv2.Scalar3 * mv1.KVector2.Scalar35 * mv2.Scalar3 - 2 * mv2.Scalar3 * mv1.KVector2.Scalar45 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.KVector2.Scalar34 * mv2.Scalar5 + mv2.Scalar4 * mv1.KVector2.Scalar35 * mv2.Scalar4 - mv2.Scalar5 * mv1.KVector2.Scalar35 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[24] += (2 * mv2.Scalar2 * mv1.KVector2.Scalar24 * mv2.Scalar5 - 2 * mv2.Scalar2 * mv1.KVector2.Scalar25 * mv2.Scalar4 + mv2.Scalar2 * mv1.KVector2.Scalar45 * mv2.Scalar2 + 2 * mv2.Scalar3 * mv1.KVector2.Scalar34 * mv2.Scalar5 - 2 * mv2.Scalar3 * mv1.KVector2.Scalar35 * mv2.Scalar4 + mv2.Scalar3 * mv1.KVector2.Scalar45 * mv2.Scalar3 - mv2.Scalar4 * mv1.KVector2.Scalar45 * mv2.Scalar4 - mv2.Scalar5 * mv1.KVector2.Scalar45 * mv2.Scalar5) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector3.IsZero())
        {
            tempScalar[7] += (-2 * mv2.Scalar1 * mv1.KVector3.Scalar234 * mv2.Scalar4 - 2 * mv2.Scalar1 * mv1.KVector3.Scalar235 * mv2.Scalar5 - mv2.Scalar2 * mv1.KVector3.Scalar123 * mv2.Scalar2 + 2 * mv2.Scalar2 * mv1.KVector3.Scalar134 * mv2.Scalar4 + 2 * mv2.Scalar2 * mv1.KVector3.Scalar135 * mv2.Scalar5 - mv2.Scalar3 * mv1.KVector3.Scalar123 * mv2.Scalar3 - 2 * mv2.Scalar3 * mv1.KVector3.Scalar124 * mv2.Scalar4 - 2 * mv2.Scalar3 * mv1.KVector3.Scalar125 * mv2.Scalar5 + mv2.Scalar4 * mv1.KVector3.Scalar123 * mv2.Scalar4 + mv2.Scalar5 * mv1.KVector3.Scalar123 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[11] += (2 * mv2.Scalar1 * mv1.KVector3.Scalar234 * mv2.Scalar3 - 2 * mv2.Scalar1 * mv1.KVector3.Scalar245 * mv2.Scalar5 - mv2.Scalar2 * mv1.KVector3.Scalar124 * mv2.Scalar2 - 2 * mv2.Scalar2 * mv1.KVector3.Scalar134 * mv2.Scalar3 + 2 * mv2.Scalar2 * mv1.KVector3.Scalar145 * mv2.Scalar5 - 2 * mv2.Scalar3 * mv1.KVector3.Scalar123 * mv2.Scalar4 + mv2.Scalar3 * mv1.KVector3.Scalar124 * mv2.Scalar3 - mv2.Scalar4 * mv1.KVector3.Scalar124 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.KVector3.Scalar125 * mv2.Scalar5 + mv2.Scalar5 * mv1.KVector3.Scalar124 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[13] += (-2 * mv2.Scalar1 * mv1.KVector3.Scalar234 * mv2.Scalar2 - 2 * mv2.Scalar1 * mv1.KVector3.Scalar345 * mv2.Scalar5 + 2 * mv2.Scalar2 * mv1.KVector3.Scalar123 * mv2.Scalar4 - 2 * mv2.Scalar2 * mv1.KVector3.Scalar124 * mv2.Scalar3 + mv2.Scalar2 * mv1.KVector3.Scalar134 * mv2.Scalar2 - mv2.Scalar3 * mv1.KVector3.Scalar134 * mv2.Scalar3 + 2 * mv2.Scalar3 * mv1.KVector3.Scalar145 * mv2.Scalar5 - mv2.Scalar4 * mv1.KVector3.Scalar134 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.KVector3.Scalar135 * mv2.Scalar5 + mv2.Scalar5 * mv1.KVector3.Scalar134 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[14] += (-mv2.Scalar2 * mv1.KVector3.Scalar234 * mv2.Scalar2 - 2 * mv2.Scalar2 * mv1.KVector3.Scalar345 * mv2.Scalar5 - mv2.Scalar3 * mv1.KVector3.Scalar234 * mv2.Scalar3 + 2 * mv2.Scalar3 * mv1.KVector3.Scalar245 * mv2.Scalar5 - mv2.Scalar4 * mv1.KVector3.Scalar234 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.KVector3.Scalar235 * mv2.Scalar5 + mv2.Scalar5 * mv1.KVector3.Scalar234 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[19] += (2 * mv2.Scalar1 * mv1.KVector3.Scalar235 * mv2.Scalar3 + 2 * mv2.Scalar1 * mv1.KVector3.Scalar245 * mv2.Scalar4 - mv2.Scalar2 * mv1.KVector3.Scalar125 * mv2.Scalar2 - 2 * mv2.Scalar2 * mv1.KVector3.Scalar135 * mv2.Scalar3 - 2 * mv2.Scalar2 * mv1.KVector3.Scalar145 * mv2.Scalar4 - 2 * mv2.Scalar3 * mv1.KVector3.Scalar123 * mv2.Scalar5 + mv2.Scalar3 * mv1.KVector3.Scalar125 * mv2.Scalar3 - 2 * mv2.Scalar4 * mv1.KVector3.Scalar124 * mv2.Scalar5 + mv2.Scalar4 * mv1.KVector3.Scalar125 * mv2.Scalar4 - mv2.Scalar5 * mv1.KVector3.Scalar125 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[21] += (-2 * mv2.Scalar1 * mv1.KVector3.Scalar235 * mv2.Scalar2 + 2 * mv2.Scalar1 * mv1.KVector3.Scalar345 * mv2.Scalar4 + 2 * mv2.Scalar2 * mv1.KVector3.Scalar123 * mv2.Scalar5 - 2 * mv2.Scalar2 * mv1.KVector3.Scalar125 * mv2.Scalar3 + mv2.Scalar2 * mv1.KVector3.Scalar135 * mv2.Scalar2 - mv2.Scalar3 * mv1.KVector3.Scalar135 * mv2.Scalar3 - 2 * mv2.Scalar3 * mv1.KVector3.Scalar145 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.KVector3.Scalar134 * mv2.Scalar5 + mv2.Scalar4 * mv1.KVector3.Scalar135 * mv2.Scalar4 - mv2.Scalar5 * mv1.KVector3.Scalar135 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[22] += (-mv2.Scalar2 * mv1.KVector3.Scalar235 * mv2.Scalar2 + 2 * mv2.Scalar2 * mv1.KVector3.Scalar345 * mv2.Scalar4 - mv2.Scalar3 * mv1.KVector3.Scalar235 * mv2.Scalar3 - 2 * mv2.Scalar3 * mv1.KVector3.Scalar245 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.KVector3.Scalar234 * mv2.Scalar5 + mv2.Scalar4 * mv1.KVector3.Scalar235 * mv2.Scalar4 - mv2.Scalar5 * mv1.KVector3.Scalar235 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[25] += (-2 * mv2.Scalar1 * mv1.KVector3.Scalar245 * mv2.Scalar2 - 2 * mv2.Scalar1 * mv1.KVector3.Scalar345 * mv2.Scalar3 + 2 * mv2.Scalar2 * mv1.KVector3.Scalar124 * mv2.Scalar5 - 2 * mv2.Scalar2 * mv1.KVector3.Scalar125 * mv2.Scalar4 + mv2.Scalar2 * mv1.KVector3.Scalar145 * mv2.Scalar2 + 2 * mv2.Scalar3 * mv1.KVector3.Scalar134 * mv2.Scalar5 - 2 * mv2.Scalar3 * mv1.KVector3.Scalar135 * mv2.Scalar4 + mv2.Scalar3 * mv1.KVector3.Scalar145 * mv2.Scalar3 - mv2.Scalar4 * mv1.KVector3.Scalar145 * mv2.Scalar4 - mv2.Scalar5 * mv1.KVector3.Scalar145 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[26] += (-mv2.Scalar2 * mv1.KVector3.Scalar245 * mv2.Scalar2 - 2 * mv2.Scalar2 * mv1.KVector3.Scalar345 * mv2.Scalar3 + 2 * mv2.Scalar3 * mv1.KVector3.Scalar234 * mv2.Scalar5 - 2 * mv2.Scalar3 * mv1.KVector3.Scalar235 * mv2.Scalar4 + mv2.Scalar3 * mv1.KVector3.Scalar245 * mv2.Scalar3 - mv2.Scalar4 * mv1.KVector3.Scalar245 * mv2.Scalar4 - mv2.Scalar5 * mv1.KVector3.Scalar245 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[28] += (-2 * mv2.Scalar2 * mv1.KVector3.Scalar234 * mv2.Scalar5 + 2 * mv2.Scalar2 * mv1.KVector3.Scalar235 * mv2.Scalar4 - 2 * mv2.Scalar2 * mv1.KVector3.Scalar245 * mv2.Scalar3 + mv2.Scalar2 * mv1.KVector3.Scalar345 * mv2.Scalar2 - mv2.Scalar3 * mv1.KVector3.Scalar345 * mv2.Scalar3 - mv2.Scalar4 * mv1.KVector3.Scalar345 * mv2.Scalar4 - mv2.Scalar5 * mv1.KVector3.Scalar345 * mv2.Scalar5) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector4.IsZero())
        {
            tempScalar[15] += (2 * mv2.Scalar1 * mv1.KVector4.Scalar2345 * mv2.Scalar5 - mv2.Scalar2 * mv1.KVector4.Scalar1234 * mv2.Scalar2 - 2 * mv2.Scalar2 * mv1.KVector4.Scalar1345 * mv2.Scalar5 - mv2.Scalar3 * mv1.KVector4.Scalar1234 * mv2.Scalar3 + 2 * mv2.Scalar3 * mv1.KVector4.Scalar1245 * mv2.Scalar5 - mv2.Scalar4 * mv1.KVector4.Scalar1234 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.KVector4.Scalar1235 * mv2.Scalar5 + mv2.Scalar5 * mv1.KVector4.Scalar1234 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[23] += (-2 * mv2.Scalar1 * mv1.KVector4.Scalar2345 * mv2.Scalar4 - mv2.Scalar2 * mv1.KVector4.Scalar1235 * mv2.Scalar2 + 2 * mv2.Scalar2 * mv1.KVector4.Scalar1345 * mv2.Scalar4 - mv2.Scalar3 * mv1.KVector4.Scalar1235 * mv2.Scalar3 - 2 * mv2.Scalar3 * mv1.KVector4.Scalar1245 * mv2.Scalar4 - 2 * mv2.Scalar4 * mv1.KVector4.Scalar1234 * mv2.Scalar5 + mv2.Scalar4 * mv1.KVector4.Scalar1235 * mv2.Scalar4 - mv2.Scalar5 * mv1.KVector4.Scalar1235 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[27] += (2 * mv2.Scalar1 * mv1.KVector4.Scalar2345 * mv2.Scalar3 - mv2.Scalar2 * mv1.KVector4.Scalar1245 * mv2.Scalar2 - 2 * mv2.Scalar2 * mv1.KVector4.Scalar1345 * mv2.Scalar3 + 2 * mv2.Scalar3 * mv1.KVector4.Scalar1234 * mv2.Scalar5 - 2 * mv2.Scalar3 * mv1.KVector4.Scalar1235 * mv2.Scalar4 + mv2.Scalar3 * mv1.KVector4.Scalar1245 * mv2.Scalar3 - mv2.Scalar4 * mv1.KVector4.Scalar1245 * mv2.Scalar4 - mv2.Scalar5 * mv1.KVector4.Scalar1245 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[29] += (-2 * mv2.Scalar1 * mv1.KVector4.Scalar2345 * mv2.Scalar2 - 2 * mv2.Scalar2 * mv1.KVector4.Scalar1234 * mv2.Scalar5 + 2 * mv2.Scalar2 * mv1.KVector4.Scalar1235 * mv2.Scalar4 - 2 * mv2.Scalar2 * mv1.KVector4.Scalar1245 * mv2.Scalar3 + mv2.Scalar2 * mv1.KVector4.Scalar1345 * mv2.Scalar2 - mv2.Scalar3 * mv1.KVector4.Scalar1345 * mv2.Scalar3 - mv2.Scalar4 * mv1.KVector4.Scalar1345 * mv2.Scalar4 - mv2.Scalar5 * mv1.KVector4.Scalar1345 * mv2.Scalar5) * mv2NormSquaredInv;
            tempScalar[30] += (-mv2.Scalar2 * mv1.KVector4.Scalar2345 * mv2.Scalar2 - mv2.Scalar3 * mv1.KVector4.Scalar2345 * mv2.Scalar3 - mv2.Scalar4 * mv1.KVector4.Scalar2345 * mv2.Scalar4 - mv2.Scalar5 * mv1.KVector4.Scalar2345 * mv2.Scalar5) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector5.IsZero())
        {
            tempScalar[31] += (-mv2.Scalar2 * mv1.KVector5.Scalar12345 * mv2.Scalar2 - mv2.Scalar3 * mv1.KVector5.Scalar12345 * mv2.Scalar3 - mv2.Scalar4 * mv1.KVector5.Scalar12345 * mv2.Scalar4 - mv2.Scalar5 * mv1.KVector5.Scalar12345 * mv2.Scalar5) * mv2NormSquaredInv;
        }
        
        return Ga401Multivector.Create(tempScalar);
    }
    
    public static Ga401Multivector MapUsingVersor(this Ga401Multivector mv1, Ga401KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401Multivector.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        var tempScalar = new double[32];
        
        if (!mv1.KVector0.IsZero())
        {
            tempScalar[0] += (mv2.Scalar23 * mv1.KVector0.Scalar * mv2.Scalar23 + mv2.Scalar45 * mv1.KVector0.Scalar * mv2.Scalar45 + mv2.Scalar24 * mv1.KVector0.Scalar * mv2.Scalar24 + mv2.Scalar34 * mv1.KVector0.Scalar * mv2.Scalar34 + mv2.Scalar25 * mv1.KVector0.Scalar * mv2.Scalar25 + mv2.Scalar35 * mv1.KVector0.Scalar * mv2.Scalar35) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector1.IsZero())
        {
            tempScalar[1] += (2 * mv2.Scalar12 * mv1.KVector1.Scalar3 * mv2.Scalar23 + 2 * mv2.Scalar12 * mv1.KVector1.Scalar4 * mv2.Scalar24 + 2 * mv2.Scalar12 * mv1.KVector1.Scalar5 * mv2.Scalar25 + 2 * mv2.Scalar15 * mv1.KVector1.Scalar2 * mv2.Scalar25 + 2 * mv2.Scalar13 * mv1.KVector1.Scalar2 * mv2.Scalar23 + 2 * mv2.Scalar13 * mv1.KVector1.Scalar4 * mv2.Scalar34 + 2 * mv2.Scalar13 * mv1.KVector1.Scalar5 * mv2.Scalar35 + mv2.Scalar23 * mv1.KVector1.Scalar1 * mv2.Scalar23 + 2 * mv2.Scalar14 * mv1.KVector1.Scalar2 * mv2.Scalar24 + 2 * mv2.Scalar14 * mv1.KVector1.Scalar3 * mv2.Scalar34 + 2 * mv2.Scalar14 * mv1.KVector1.Scalar5 * mv2.Scalar45 + mv2.Scalar24 * mv1.KVector1.Scalar1 * mv2.Scalar24 + mv2.Scalar45 * mv1.KVector1.Scalar1 * mv2.Scalar45 + mv2.Scalar34 * mv1.KVector1.Scalar1 * mv2.Scalar34 + 2 * mv2.Scalar15 * mv1.KVector1.Scalar3 * mv2.Scalar35 + 2 * mv2.Scalar15 * mv1.KVector1.Scalar4 * mv2.Scalar45 + mv2.Scalar25 * mv1.KVector1.Scalar1 * mv2.Scalar25 + mv2.Scalar35 * mv1.KVector1.Scalar1 * mv2.Scalar35) * mv2NormSquaredInv;
            tempScalar[2] += (2 * mv2.Scalar25 * mv1.KVector1.Scalar4 * mv2.Scalar45 + mv2.Scalar23 * mv1.KVector1.Scalar2 * mv2.Scalar23 + 2 * mv2.Scalar23 * mv1.KVector1.Scalar4 * mv2.Scalar34 + 2 * mv2.Scalar23 * mv1.KVector1.Scalar5 * mv2.Scalar35 + mv2.Scalar24 * mv1.KVector1.Scalar2 * mv2.Scalar24 + mv2.Scalar34 * mv1.KVector1.Scalar2 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.KVector1.Scalar3 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.KVector1.Scalar5 * mv2.Scalar45 + mv2.Scalar25 * mv1.KVector1.Scalar2 * mv2.Scalar25 + mv2.Scalar35 * mv1.KVector1.Scalar2 * mv2.Scalar35 + mv2.Scalar45 * mv1.KVector1.Scalar2 * mv2.Scalar45 + 2 * mv2.Scalar25 * mv1.KVector1.Scalar3 * mv2.Scalar35) * mv2NormSquaredInv;
            tempScalar[4] += (mv2.Scalar45 * mv1.KVector1.Scalar3 * mv2.Scalar45 + mv2.Scalar34 * mv1.KVector1.Scalar3 * mv2.Scalar34 + mv2.Scalar35 * mv1.KVector1.Scalar3 * mv2.Scalar35 - mv2.Scalar23 * mv1.KVector1.Scalar3 * mv2.Scalar23 - mv2.Scalar24 * mv1.KVector1.Scalar3 * mv2.Scalar24 - mv2.Scalar25 * mv1.KVector1.Scalar3 * mv2.Scalar25 - 2 * mv2.Scalar23 * mv1.KVector1.Scalar4 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.KVector1.Scalar5 * mv2.Scalar25 + 2 * mv2.Scalar34 * mv1.KVector1.Scalar5 * mv2.Scalar45 + 2 * mv2.Scalar35 * mv1.KVector1.Scalar4 * mv2.Scalar45) * mv2NormSquaredInv;
            tempScalar[8] += (mv2.Scalar23 * mv1.KVector1.Scalar4 * mv2.Scalar23 - mv2.Scalar24 * mv1.KVector1.Scalar4 * mv2.Scalar24 - mv2.Scalar25 * mv1.KVector1.Scalar4 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.KVector1.Scalar5 * mv2.Scalar25 + mv2.Scalar45 * mv1.KVector1.Scalar4 * mv2.Scalar45 - mv2.Scalar34 * mv1.KVector1.Scalar4 * mv2.Scalar34 - mv2.Scalar35 * mv1.KVector1.Scalar4 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector1.Scalar5 * mv2.Scalar35) * mv2NormSquaredInv;
            tempScalar[16] += (-mv2.Scalar45 * mv1.KVector1.Scalar5 * mv2.Scalar45 - mv2.Scalar35 * mv1.KVector1.Scalar5 * mv2.Scalar35 + mv2.Scalar23 * mv1.KVector1.Scalar5 * mv2.Scalar23 - mv2.Scalar25 * mv1.KVector1.Scalar5 * mv2.Scalar25 + mv2.Scalar24 * mv1.KVector1.Scalar5 * mv2.Scalar24 + mv2.Scalar34 * mv1.KVector1.Scalar5 * mv2.Scalar34) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector2.IsZero())
        {
            tempScalar[3] += (mv2.Scalar23 * mv1.KVector2.Scalar12 * mv2.Scalar23 + 2 * mv2.Scalar23 * mv1.KVector2.Scalar14 * mv2.Scalar34 + 2 * mv2.Scalar23 * mv1.KVector2.Scalar15 * mv2.Scalar35 + mv2.Scalar24 * mv1.KVector2.Scalar12 * mv2.Scalar24 + mv2.Scalar34 * mv1.KVector2.Scalar12 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.KVector2.Scalar13 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.KVector2.Scalar15 * mv2.Scalar45 + mv2.Scalar25 * mv1.KVector2.Scalar12 * mv2.Scalar25 + mv2.Scalar35 * mv1.KVector2.Scalar12 * mv2.Scalar35 + mv2.Scalar45 * mv1.KVector2.Scalar12 * mv2.Scalar45 + 2 * mv2.Scalar25 * mv1.KVector2.Scalar13 * mv2.Scalar35 + 2 * mv2.Scalar25 * mv1.KVector2.Scalar14 * mv2.Scalar45) * mv2NormSquaredInv;
            tempScalar[5] += (2 * mv2.Scalar12 * mv1.KVector2.Scalar24 * mv2.Scalar34 + 2 * mv2.Scalar12 * mv1.KVector2.Scalar25 * mv2.Scalar35 - 2 * mv2.Scalar13 * mv1.KVector2.Scalar23 * mv2.Scalar23 - 2 * mv2.Scalar13 * mv1.KVector2.Scalar24 * mv2.Scalar24 - 2 * mv2.Scalar13 * mv1.KVector2.Scalar25 * mv2.Scalar25 - mv2.Scalar23 * mv1.KVector2.Scalar13 * mv2.Scalar23 - mv2.Scalar24 * mv1.KVector2.Scalar13 * mv2.Scalar24 - mv2.Scalar25 * mv1.KVector2.Scalar13 * mv2.Scalar25 - 2 * mv2.Scalar14 * mv1.KVector2.Scalar23 * mv2.Scalar24 - 2 * mv2.Scalar15 * mv1.KVector2.Scalar23 * mv2.Scalar25 - 2 * mv2.Scalar23 * mv1.KVector2.Scalar14 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.KVector2.Scalar24 * mv2.Scalar14 - 2 * mv2.Scalar23 * mv1.KVector2.Scalar15 * mv2.Scalar25 - 2 * mv2.Scalar23 * mv1.KVector2.Scalar25 * mv2.Scalar15 + mv2.Scalar34 * mv1.KVector2.Scalar13 * mv2.Scalar34 + 2 * mv2.Scalar34 * mv1.KVector2.Scalar15 * mv2.Scalar45 + mv2.Scalar35 * mv1.KVector2.Scalar13 * mv2.Scalar35 + mv2.Scalar45 * mv1.KVector2.Scalar13 * mv2.Scalar45 + 2 * mv2.Scalar35 * mv1.KVector2.Scalar14 * mv2.Scalar45) * mv2NormSquaredInv;
            tempScalar[6] += (-mv2.Scalar23 * mv1.KVector2.Scalar23 * mv2.Scalar23 - mv2.Scalar25 * mv1.KVector2.Scalar23 * mv2.Scalar25 + mv2.Scalar45 * mv1.KVector2.Scalar23 * mv2.Scalar45 - mv2.Scalar24 * mv1.KVector2.Scalar23 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.KVector2.Scalar24 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.KVector2.Scalar25 * mv2.Scalar25 + mv2.Scalar34 * mv1.KVector2.Scalar23 * mv2.Scalar34 + 2 * mv2.Scalar35 * mv1.KVector2.Scalar24 * mv2.Scalar45 + 2 * mv2.Scalar34 * mv1.KVector2.Scalar25 * mv2.Scalar45 + mv2.Scalar35 * mv1.KVector2.Scalar23 * mv2.Scalar35) * mv2NormSquaredInv;
            tempScalar[9] += (2 * mv2.Scalar12 * mv1.KVector2.Scalar34 * mv2.Scalar23 + 2 * mv2.Scalar12 * mv1.KVector2.Scalar25 * mv2.Scalar45 + 2 * mv2.Scalar13 * mv1.KVector2.Scalar24 * mv2.Scalar23 - 2 * mv2.Scalar15 * mv1.KVector2.Scalar34 * mv2.Scalar35 + 2 * mv2.Scalar13 * mv1.KVector2.Scalar35 * mv2.Scalar45 + mv2.Scalar45 * mv1.KVector2.Scalar14 * mv2.Scalar45 + mv2.Scalar23 * mv1.KVector2.Scalar14 * mv2.Scalar23 - 2 * mv2.Scalar14 * mv1.KVector2.Scalar34 * mv2.Scalar34 - 2 * mv2.Scalar14 * mv1.KVector2.Scalar24 * mv2.Scalar24 - 2 * mv2.Scalar14 * mv1.KVector2.Scalar25 * mv2.Scalar25 - 2 * mv2.Scalar14 * mv1.KVector2.Scalar35 * mv2.Scalar35 - mv2.Scalar24 * mv1.KVector2.Scalar14 * mv2.Scalar24 - mv2.Scalar25 * mv1.KVector2.Scalar14 * mv2.Scalar25 - 2 * mv2.Scalar15 * mv1.KVector2.Scalar24 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.KVector2.Scalar15 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.KVector2.Scalar25 * mv2.Scalar15 - mv2.Scalar34 * mv1.KVector2.Scalar14 * mv2.Scalar34 - mv2.Scalar35 * mv1.KVector2.Scalar14 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector2.Scalar15 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector2.Scalar35 * mv2.Scalar15) * mv2NormSquaredInv;
            tempScalar[10] += (-mv2.Scalar24 * mv1.KVector2.Scalar24 * mv2.Scalar24 - 2 * mv2.Scalar24 * mv1.KVector2.Scalar34 * mv2.Scalar34 + mv2.Scalar23 * mv1.KVector2.Scalar24 * mv2.Scalar23 + 2 * mv2.Scalar23 * mv1.KVector2.Scalar35 * mv2.Scalar45 - mv2.Scalar35 * mv1.KVector2.Scalar24 * mv2.Scalar35 - mv2.Scalar34 * mv1.KVector2.Scalar24 * mv2.Scalar34 - mv2.Scalar25 * mv1.KVector2.Scalar24 * mv2.Scalar25 - 2 * mv2.Scalar25 * mv1.KVector2.Scalar34 * mv2.Scalar35 - 2 * mv2.Scalar24 * mv1.KVector2.Scalar25 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.KVector2.Scalar35 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector2.Scalar25 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector2.Scalar35 * mv2.Scalar25 + mv2.Scalar45 * mv1.KVector2.Scalar24 * mv2.Scalar45) * mv2NormSquaredInv;
            tempScalar[12] += (mv2.Scalar25 * mv1.KVector2.Scalar34 * mv2.Scalar25 + mv2.Scalar24 * mv1.KVector2.Scalar34 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.KVector2.Scalar23 * mv2.Scalar34 + 2 * mv2.Scalar25 * mv1.KVector2.Scalar23 * mv2.Scalar45 - mv2.Scalar23 * mv1.KVector2.Scalar34 * mv2.Scalar23 - mv2.Scalar34 * mv1.KVector2.Scalar34 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.KVector2.Scalar35 * mv2.Scalar25 - mv2.Scalar35 * mv1.KVector2.Scalar34 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector2.Scalar35 * mv2.Scalar35 + mv2.Scalar45 * mv1.KVector2.Scalar34 * mv2.Scalar45) * mv2NormSquaredInv;
            tempScalar[17] += (2 * mv2.Scalar12 * mv1.KVector2.Scalar35 * mv2.Scalar23 + 2 * mv2.Scalar12 * mv1.KVector2.Scalar45 * mv2.Scalar24 + 2 * mv2.Scalar13 * mv1.KVector2.Scalar25 * mv2.Scalar23 + 2 * mv2.Scalar13 * mv1.KVector2.Scalar45 * mv2.Scalar34 - mv2.Scalar45 * mv1.KVector2.Scalar15 * mv2.Scalar45 + mv2.Scalar23 * mv1.KVector2.Scalar15 * mv2.Scalar23 - 2 * mv2.Scalar15 * mv1.KVector2.Scalar35 * mv2.Scalar35 + 2 * mv2.Scalar14 * mv1.KVector2.Scalar25 * mv2.Scalar24 + 2 * mv2.Scalar14 * mv1.KVector2.Scalar35 * mv2.Scalar34 + mv2.Scalar24 * mv1.KVector2.Scalar15 * mv2.Scalar24 - mv2.Scalar35 * mv1.KVector2.Scalar15 * mv2.Scalar35 + mv2.Scalar34 * mv1.KVector2.Scalar15 * mv2.Scalar34 - 2 * mv2.Scalar15 * mv1.KVector2.Scalar45 * mv2.Scalar45 - 2 * mv2.Scalar15 * mv1.KVector2.Scalar25 * mv2.Scalar25 - mv2.Scalar25 * mv1.KVector2.Scalar15 * mv2.Scalar25) * mv2NormSquaredInv;
            tempScalar[18] += (-mv2.Scalar35 * mv1.KVector2.Scalar25 * mv2.Scalar35 - 2 * mv2.Scalar25 * mv1.KVector2.Scalar35 * mv2.Scalar35 + mv2.Scalar23 * mv1.KVector2.Scalar25 * mv2.Scalar23 - mv2.Scalar25 * mv1.KVector2.Scalar25 * mv2.Scalar25 + 2 * mv2.Scalar23 * mv1.KVector2.Scalar45 * mv2.Scalar34 - 2 * mv2.Scalar25 * mv1.KVector2.Scalar45 * mv2.Scalar45 + mv2.Scalar24 * mv1.KVector2.Scalar25 * mv2.Scalar24 + mv2.Scalar34 * mv1.KVector2.Scalar25 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.KVector2.Scalar35 * mv2.Scalar34 - mv2.Scalar45 * mv1.KVector2.Scalar25 * mv2.Scalar45) * mv2NormSquaredInv;
            tempScalar[20] += (2 * mv2.Scalar34 * mv1.KVector2.Scalar24 * mv2.Scalar25 + mv2.Scalar25 * mv1.KVector2.Scalar35 * mv2.Scalar25 - mv2.Scalar45 * mv1.KVector2.Scalar35 * mv2.Scalar45 - 2 * mv2.Scalar23 * mv1.KVector2.Scalar23 * mv2.Scalar35 - 2 * mv2.Scalar23 * mv1.KVector2.Scalar24 * mv2.Scalar45 - mv2.Scalar23 * mv1.KVector2.Scalar35 * mv2.Scalar23 - mv2.Scalar24 * mv1.KVector2.Scalar35 * mv2.Scalar24 - mv2.Scalar35 * mv1.KVector2.Scalar35 * mv2.Scalar35 - 2 * mv2.Scalar23 * mv1.KVector2.Scalar45 * mv2.Scalar24 - 2 * mv2.Scalar35 * mv1.KVector2.Scalar45 * mv2.Scalar45 - 2 * mv2.Scalar24 * mv1.KVector2.Scalar23 * mv2.Scalar45 - 2 * mv2.Scalar24 * mv1.KVector2.Scalar24 * mv2.Scalar35 + mv2.Scalar34 * mv1.KVector2.Scalar35 * mv2.Scalar34) * mv2NormSquaredInv;
            tempScalar[24] += (2 * mv2.Scalar23 * mv1.KVector2.Scalar24 * mv2.Scalar35 + 2 * mv2.Scalar23 * mv1.KVector2.Scalar34 * mv2.Scalar25 + mv2.Scalar23 * mv1.KVector2.Scalar45 * mv2.Scalar23 - 2 * mv2.Scalar24 * mv1.KVector2.Scalar24 * mv2.Scalar45 - mv2.Scalar24 * mv1.KVector2.Scalar45 * mv2.Scalar24 + mv2.Scalar35 * mv1.KVector2.Scalar45 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector2.Scalar34 * mv2.Scalar45 - mv2.Scalar34 * mv1.KVector2.Scalar45 * mv2.Scalar34 + mv2.Scalar25 * mv1.KVector2.Scalar45 * mv2.Scalar25 - mv2.Scalar45 * mv1.KVector2.Scalar45 * mv2.Scalar45) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector3.IsZero())
        {
            tempScalar[7] += (mv2.Scalar45 * mv1.KVector3.Scalar123 * mv2.Scalar45 - 2 * mv2.Scalar12 * mv1.KVector3.Scalar234 * mv2.Scalar24 - 2 * mv2.Scalar12 * mv1.KVector3.Scalar235 * mv2.Scalar25 + 2 * mv2.Scalar13 * mv1.KVector3.Scalar234 * mv2.Scalar34 + 2 * mv2.Scalar13 * mv1.KVector3.Scalar235 * mv2.Scalar35 + 2 * mv2.Scalar34 * mv1.KVector3.Scalar245 * mv2.Scalar15 + 2 * mv2.Scalar13 * mv1.KVector3.Scalar245 * mv2.Scalar45 - mv2.Scalar23 * mv1.KVector3.Scalar123 * mv2.Scalar23 - mv2.Scalar24 * mv1.KVector3.Scalar123 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.KVector3.Scalar124 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.KVector3.Scalar125 * mv2.Scalar25 + 2 * mv2.Scalar14 * mv1.KVector3.Scalar235 * mv2.Scalar45 + 2 * mv2.Scalar14 * mv1.KVector3.Scalar245 * mv2.Scalar35 + mv2.Scalar35 * mv1.KVector3.Scalar123 * mv2.Scalar35 + mv2.Scalar34 * mv1.KVector3.Scalar123 * mv2.Scalar34 - mv2.Scalar25 * mv1.KVector3.Scalar123 * mv2.Scalar25 + 2 * mv2.Scalar35 * mv1.KVector3.Scalar124 * mv2.Scalar45 + 2 * mv2.Scalar34 * mv1.KVector3.Scalar125 * mv2.Scalar45 + 2 * mv2.Scalar15 * mv1.KVector3.Scalar234 * mv2.Scalar45) * mv2NormSquaredInv;
            tempScalar[11] += (mv2.Scalar45 * mv1.KVector3.Scalar124 * mv2.Scalar45 - 2 * mv2.Scalar12 * mv1.KVector3.Scalar245 * mv2.Scalar25 - 2 * mv2.Scalar12 * mv1.KVector3.Scalar345 * mv2.Scalar35 - 2 * mv2.Scalar13 * mv1.KVector3.Scalar245 * mv2.Scalar35 - 2 * mv2.Scalar13 * mv1.KVector3.Scalar345 * mv2.Scalar25 + mv2.Scalar23 * mv1.KVector3.Scalar124 * mv2.Scalar23 + 2 * mv2.Scalar23 * mv1.KVector3.Scalar135 * mv2.Scalar45 + 2 * mv2.Scalar23 * mv1.KVector3.Scalar345 * mv2.Scalar15 + 2 * mv2.Scalar14 * mv1.KVector3.Scalar245 * mv2.Scalar45 - mv2.Scalar24 * mv1.KVector3.Scalar124 * mv2.Scalar24 - mv2.Scalar34 * mv1.KVector3.Scalar124 * mv2.Scalar34 - mv2.Scalar25 * mv1.KVector3.Scalar124 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.KVector3.Scalar134 * mv2.Scalar34 - 2 * mv2.Scalar25 * mv1.KVector3.Scalar134 * mv2.Scalar35 - 2 * mv2.Scalar24 * mv1.KVector3.Scalar125 * mv2.Scalar25 - 2 * mv2.Scalar24 * mv1.KVector3.Scalar135 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector3.Scalar125 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector3.Scalar135 * mv2.Scalar25 - mv2.Scalar35 * mv1.KVector3.Scalar124 * mv2.Scalar35) * mv2NormSquaredInv;
            tempScalar[13] += (2 * mv2.Scalar12 * mv1.KVector3.Scalar235 * mv2.Scalar45 + 2 * mv2.Scalar12 * mv1.KVector3.Scalar345 * mv2.Scalar25 - 2 * mv2.Scalar13 * mv1.KVector3.Scalar234 * mv2.Scalar23 + 2 * mv2.Scalar24 * mv1.KVector3.Scalar235 * mv2.Scalar15 - 2 * mv2.Scalar13 * mv1.KVector3.Scalar345 * mv2.Scalar35 - 2 * mv2.Scalar23 * mv1.KVector3.Scalar123 * mv2.Scalar34 + 2 * mv2.Scalar25 * mv1.KVector3.Scalar123 * mv2.Scalar45 - mv2.Scalar23 * mv1.KVector3.Scalar134 * mv2.Scalar23 - mv2.Scalar34 * mv1.KVector3.Scalar134 * mv2.Scalar34 + 2 * mv2.Scalar14 * mv1.KVector3.Scalar234 * mv2.Scalar24 + 2 * mv2.Scalar14 * mv1.KVector3.Scalar235 * mv2.Scalar25 + 2 * mv2.Scalar14 * mv1.KVector3.Scalar345 * mv2.Scalar45 + mv2.Scalar24 * mv1.KVector3.Scalar134 * mv2.Scalar24 + 2 * mv2.Scalar15 * mv1.KVector3.Scalar234 * mv2.Scalar25 + 2 * mv2.Scalar24 * mv1.KVector3.Scalar135 * mv2.Scalar25 + mv2.Scalar25 * mv1.KVector3.Scalar134 * mv2.Scalar25 - mv2.Scalar35 * mv1.KVector3.Scalar134 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector3.Scalar135 * mv2.Scalar35 + mv2.Scalar45 * mv1.KVector3.Scalar134 * mv2.Scalar45) * mv2NormSquaredInv;
            tempScalar[14] += (-mv2.Scalar23 * mv1.KVector3.Scalar234 * mv2.Scalar23 - 2 * mv2.Scalar23 * mv1.KVector3.Scalar345 * mv2.Scalar35 - mv2.Scalar34 * mv1.KVector3.Scalar234 * mv2.Scalar34 + mv2.Scalar24 * mv1.KVector3.Scalar234 * mv2.Scalar24 + mv2.Scalar25 * mv1.KVector3.Scalar234 * mv2.Scalar25 + mv2.Scalar45 * mv1.KVector3.Scalar234 * mv2.Scalar45 + 2 * mv2.Scalar24 * mv1.KVector3.Scalar235 * mv2.Scalar25 + 2 * mv2.Scalar24 * mv1.KVector3.Scalar345 * mv2.Scalar45 - 2 * mv2.Scalar34 * mv1.KVector3.Scalar235 * mv2.Scalar35 - mv2.Scalar35 * mv1.KVector3.Scalar234 * mv2.Scalar35) * mv2NormSquaredInv;
            tempScalar[19] += (-2 * mv2.Scalar13 * mv1.KVector3.Scalar234 * mv2.Scalar45 + mv2.Scalar23 * mv1.KVector3.Scalar125 * mv2.Scalar23 - mv2.Scalar25 * mv1.KVector3.Scalar125 * mv2.Scalar25 + 2 * mv2.Scalar23 * mv1.KVector3.Scalar145 * mv2.Scalar34 - 2 * mv2.Scalar25 * mv1.KVector3.Scalar145 * mv2.Scalar45 - 2 * mv2.Scalar14 * mv1.KVector3.Scalar234 * mv2.Scalar35 + mv2.Scalar24 * mv1.KVector3.Scalar125 * mv2.Scalar24 + mv2.Scalar34 * mv1.KVector3.Scalar125 * mv2.Scalar34 + 2 * mv2.Scalar24 * mv1.KVector3.Scalar135 * mv2.Scalar34 + 2 * mv2.Scalar34 * mv1.KVector3.Scalar234 * mv2.Scalar15 - mv2.Scalar35 * mv1.KVector3.Scalar125 * mv2.Scalar35 - mv2.Scalar45 * mv1.KVector3.Scalar125 * mv2.Scalar45 - 2 * mv2.Scalar25 * mv1.KVector3.Scalar135 * mv2.Scalar35) * mv2NormSquaredInv;
            tempScalar[21] += (-mv2.Scalar45 * mv1.KVector3.Scalar135 * mv2.Scalar45 + 2 * mv2.Scalar15 * mv1.KVector3.Scalar235 * mv2.Scalar25 + 2 * mv2.Scalar12 * mv1.KVector3.Scalar245 * mv2.Scalar34 - 2 * mv2.Scalar13 * mv1.KVector3.Scalar235 * mv2.Scalar23 - 2 * mv2.Scalar13 * mv1.KVector3.Scalar245 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.KVector3.Scalar123 * mv2.Scalar35 - 2 * mv2.Scalar23 * mv1.KVector3.Scalar124 * mv2.Scalar45 - mv2.Scalar23 * mv1.KVector3.Scalar135 * mv2.Scalar23 - mv2.Scalar24 * mv1.KVector3.Scalar135 * mv2.Scalar24 - mv2.Scalar35 * mv1.KVector3.Scalar135 * mv2.Scalar35 - 2 * mv2.Scalar14 * mv1.KVector3.Scalar235 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.KVector3.Scalar145 * mv2.Scalar24 - 2 * mv2.Scalar35 * mv1.KVector3.Scalar145 * mv2.Scalar45 - 2 * mv2.Scalar23 * mv1.KVector3.Scalar245 * mv2.Scalar14 - 2 * mv2.Scalar24 * mv1.KVector3.Scalar123 * mv2.Scalar45 - 2 * mv2.Scalar24 * mv1.KVector3.Scalar124 * mv2.Scalar35 + 2 * mv2.Scalar34 * mv1.KVector3.Scalar124 * mv2.Scalar25 + mv2.Scalar34 * mv1.KVector3.Scalar135 * mv2.Scalar34 + mv2.Scalar25 * mv1.KVector3.Scalar135 * mv2.Scalar25) * mv2NormSquaredInv;
            tempScalar[22] += (-mv2.Scalar23 * mv1.KVector3.Scalar235 * mv2.Scalar23 - 2 * mv2.Scalar35 * mv1.KVector3.Scalar245 * mv2.Scalar45 - mv2.Scalar24 * mv1.KVector3.Scalar235 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.KVector3.Scalar245 * mv2.Scalar24 + mv2.Scalar34 * mv1.KVector3.Scalar235 * mv2.Scalar34 - mv2.Scalar45 * mv1.KVector3.Scalar235 * mv2.Scalar45 - mv2.Scalar35 * mv1.KVector3.Scalar235 * mv2.Scalar35 + mv2.Scalar25 * mv1.KVector3.Scalar235 * mv2.Scalar25) * mv2NormSquaredInv;
            tempScalar[25] += (2 * mv2.Scalar12 * mv1.KVector3.Scalar234 * mv2.Scalar35 + 2 * mv2.Scalar12 * mv1.KVector3.Scalar345 * mv2.Scalar23 + 2 * mv2.Scalar13 * mv1.KVector3.Scalar234 * mv2.Scalar25 + 2 * mv2.Scalar13 * mv1.KVector3.Scalar245 * mv2.Scalar23 + 2 * mv2.Scalar23 * mv1.KVector3.Scalar124 * mv2.Scalar35 + 2 * mv2.Scalar23 * mv1.KVector3.Scalar134 * mv2.Scalar25 + 2 * mv2.Scalar23 * mv1.KVector3.Scalar234 * mv2.Scalar15 + mv2.Scalar23 * mv1.KVector3.Scalar145 * mv2.Scalar23 + 2 * mv2.Scalar15 * mv1.KVector3.Scalar245 * mv2.Scalar25 - 2 * mv2.Scalar14 * mv1.KVector3.Scalar345 * mv2.Scalar34 - 2 * mv2.Scalar14 * mv1.KVector3.Scalar245 * mv2.Scalar24 - 2 * mv2.Scalar24 * mv1.KVector3.Scalar124 * mv2.Scalar45 - mv2.Scalar24 * mv1.KVector3.Scalar145 * mv2.Scalar24 + mv2.Scalar35 * mv1.KVector3.Scalar145 * mv2.Scalar35 + 2 * mv2.Scalar15 * mv1.KVector3.Scalar345 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector3.Scalar134 * mv2.Scalar45 - mv2.Scalar34 * mv1.KVector3.Scalar145 * mv2.Scalar34 + mv2.Scalar25 * mv1.KVector3.Scalar145 * mv2.Scalar25 - mv2.Scalar45 * mv1.KVector3.Scalar145 * mv2.Scalar45) * mv2NormSquaredInv;
            tempScalar[26] += (2 * mv2.Scalar25 * mv1.KVector3.Scalar345 * mv2.Scalar35 - mv2.Scalar24 * mv1.KVector3.Scalar245 * mv2.Scalar24 - 2 * mv2.Scalar24 * mv1.KVector3.Scalar345 * mv2.Scalar34 + mv2.Scalar35 * mv1.KVector3.Scalar245 * mv2.Scalar35 + 2 * mv2.Scalar23 * mv1.KVector3.Scalar234 * mv2.Scalar25 + mv2.Scalar23 * mv1.KVector3.Scalar245 * mv2.Scalar23 + mv2.Scalar25 * mv1.KVector3.Scalar245 * mv2.Scalar25 - mv2.Scalar45 * mv1.KVector3.Scalar245 * mv2.Scalar45 - mv2.Scalar34 * mv1.KVector3.Scalar245 * mv2.Scalar34 - 2 * mv2.Scalar34 * mv1.KVector3.Scalar234 * mv2.Scalar45) * mv2NormSquaredInv;
            tempScalar[28] += (mv2.Scalar35 * mv1.KVector3.Scalar345 * mv2.Scalar35 + mv2.Scalar24 * mv1.KVector3.Scalar345 * mv2.Scalar24 - 2 * mv2.Scalar23 * mv1.KVector3.Scalar235 * mv2.Scalar34 - mv2.Scalar23 * mv1.KVector3.Scalar345 * mv2.Scalar23 - mv2.Scalar34 * mv1.KVector3.Scalar345 * mv2.Scalar34 - mv2.Scalar25 * mv1.KVector3.Scalar345 * mv2.Scalar25 - 2 * mv2.Scalar25 * mv1.KVector3.Scalar235 * mv2.Scalar45 - mv2.Scalar45 * mv1.KVector3.Scalar345 * mv2.Scalar45) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector4.IsZero())
        {
            tempScalar[15] += (-mv2.Scalar23 * mv1.KVector4.Scalar1234 * mv2.Scalar23 - 2 * mv2.Scalar23 * mv1.KVector4.Scalar1345 * mv2.Scalar35 + mv2.Scalar24 * mv1.KVector4.Scalar1234 * mv2.Scalar24 + mv2.Scalar25 * mv1.KVector4.Scalar1234 * mv2.Scalar25 + mv2.Scalar45 * mv1.KVector4.Scalar1234 * mv2.Scalar45 + 2 * mv2.Scalar24 * mv1.KVector4.Scalar1235 * mv2.Scalar25 + 2 * mv2.Scalar24 * mv1.KVector4.Scalar1345 * mv2.Scalar45 - mv2.Scalar34 * mv1.KVector4.Scalar1234 * mv2.Scalar34 - mv2.Scalar35 * mv1.KVector4.Scalar1234 * mv2.Scalar35 - 2 * mv2.Scalar34 * mv1.KVector4.Scalar1235 * mv2.Scalar35) * mv2NormSquaredInv;
            tempScalar[23] += (-2 * mv2.Scalar12 * mv1.KVector4.Scalar2345 * mv2.Scalar24 + 2 * mv2.Scalar13 * mv1.KVector4.Scalar2345 * mv2.Scalar34 - mv2.Scalar23 * mv1.KVector4.Scalar1235 * mv2.Scalar23 - mv2.Scalar24 * mv1.KVector4.Scalar1235 * mv2.Scalar24 - 2 * mv2.Scalar35 * mv1.KVector4.Scalar1245 * mv2.Scalar45 - 2 * mv2.Scalar23 * mv1.KVector4.Scalar1245 * mv2.Scalar24 - mv2.Scalar45 * mv1.KVector4.Scalar1235 * mv2.Scalar45 - mv2.Scalar35 * mv1.KVector4.Scalar1235 * mv2.Scalar35 + mv2.Scalar34 * mv1.KVector4.Scalar1235 * mv2.Scalar34 - 2 * mv2.Scalar15 * mv1.KVector4.Scalar2345 * mv2.Scalar45 + mv2.Scalar25 * mv1.KVector4.Scalar1235 * mv2.Scalar25) * mv2NormSquaredInv;
            tempScalar[27] += (2 * mv2.Scalar23 * mv1.KVector4.Scalar1234 * mv2.Scalar25 + mv2.Scalar35 * mv1.KVector4.Scalar1245 * mv2.Scalar35 + mv2.Scalar23 * mv1.KVector4.Scalar1245 * mv2.Scalar23 + mv2.Scalar25 * mv1.KVector4.Scalar1245 * mv2.Scalar25 - mv2.Scalar24 * mv1.KVector4.Scalar1245 * mv2.Scalar24 - mv2.Scalar34 * mv1.KVector4.Scalar1245 * mv2.Scalar34 - 2 * mv2.Scalar24 * mv1.KVector4.Scalar1345 * mv2.Scalar34 - 2 * mv2.Scalar34 * mv1.KVector4.Scalar1234 * mv2.Scalar45 - mv2.Scalar45 * mv1.KVector4.Scalar1245 * mv2.Scalar45 + 2 * mv2.Scalar25 * mv1.KVector4.Scalar1345 * mv2.Scalar35) * mv2NormSquaredInv;
            tempScalar[29] += (mv2.Scalar35 * mv1.KVector4.Scalar1345 * mv2.Scalar35 - 2 * mv2.Scalar13 * mv1.KVector4.Scalar2345 * mv2.Scalar23 - 2 * mv2.Scalar23 * mv1.KVector4.Scalar1235 * mv2.Scalar34 - mv2.Scalar23 * mv1.KVector4.Scalar1345 * mv2.Scalar23 - mv2.Scalar34 * mv1.KVector4.Scalar1345 * mv2.Scalar34 + 2 * mv2.Scalar14 * mv1.KVector4.Scalar2345 * mv2.Scalar24 + mv2.Scalar24 * mv1.KVector4.Scalar1345 * mv2.Scalar24 - 2 * mv2.Scalar15 * mv1.KVector4.Scalar2345 * mv2.Scalar25 - 2 * mv2.Scalar25 * mv1.KVector4.Scalar1235 * mv2.Scalar45 - mv2.Scalar25 * mv1.KVector4.Scalar1345 * mv2.Scalar25 - mv2.Scalar45 * mv1.KVector4.Scalar1345 * mv2.Scalar45) * mv2NormSquaredInv;
            tempScalar[30] += (-mv2.Scalar23 * mv1.KVector4.Scalar2345 * mv2.Scalar23 - mv2.Scalar25 * mv1.KVector4.Scalar2345 * mv2.Scalar25 - mv2.Scalar34 * mv1.KVector4.Scalar2345 * mv2.Scalar34 - mv2.Scalar45 * mv1.KVector4.Scalar2345 * mv2.Scalar45 + mv2.Scalar24 * mv1.KVector4.Scalar2345 * mv2.Scalar24 + mv2.Scalar35 * mv1.KVector4.Scalar2345 * mv2.Scalar35) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector5.IsZero())
        {
            tempScalar[31] += (-mv2.Scalar34 * mv1.KVector5.Scalar12345 * mv2.Scalar34 + mv2.Scalar35 * mv1.KVector5.Scalar12345 * mv2.Scalar35 - mv2.Scalar23 * mv1.KVector5.Scalar12345 * mv2.Scalar23 + mv2.Scalar24 * mv1.KVector5.Scalar12345 * mv2.Scalar24 - mv2.Scalar45 * mv1.KVector5.Scalar12345 * mv2.Scalar45 - mv2.Scalar25 * mv1.KVector5.Scalar12345 * mv2.Scalar25) * mv2NormSquaredInv;
        }
        
        return Ga401Multivector.Create(tempScalar);
    }
    
    public static Ga401Multivector MapUsingVersor(this Ga401Multivector mv1, Ga401KVector3 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401Multivector.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        var tempScalar = new double[32];
        
        if (!mv1.KVector0.IsZero())
        {
            tempScalar[0] += (mv2.Scalar345 * mv1.KVector0.Scalar * mv2.Scalar345 + mv2.Scalar234 * mv1.KVector0.Scalar * mv2.Scalar234 + mv2.Scalar235 * mv1.KVector0.Scalar * mv2.Scalar235 + mv2.Scalar245 * mv1.KVector0.Scalar * mv2.Scalar245) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector1.IsZero())
        {
            tempScalar[1] += (2 * mv2.Scalar123 * mv1.KVector1.Scalar4 * mv2.Scalar234 + 2 * mv2.Scalar123 * mv1.KVector1.Scalar5 * mv2.Scalar235 + 2 * mv2.Scalar124 * mv1.KVector1.Scalar3 * mv2.Scalar234 + 2 * mv2.Scalar124 * mv1.KVector1.Scalar5 * mv2.Scalar245 + 2 * mv2.Scalar134 * mv1.KVector1.Scalar2 * mv2.Scalar234 + 2 * mv2.Scalar134 * mv1.KVector1.Scalar5 * mv2.Scalar345 + mv2.Scalar234 * mv1.KVector1.Scalar1 * mv2.Scalar234 + 2 * mv2.Scalar125 * mv1.KVector1.Scalar3 * mv2.Scalar235 + 2 * mv2.Scalar125 * mv1.KVector1.Scalar4 * mv2.Scalar245 + 2 * mv2.Scalar135 * mv1.KVector1.Scalar2 * mv2.Scalar235 + 2 * mv2.Scalar135 * mv1.KVector1.Scalar4 * mv2.Scalar345 + mv2.Scalar235 * mv1.KVector1.Scalar1 * mv2.Scalar235 + 2 * mv2.Scalar145 * mv1.KVector1.Scalar2 * mv2.Scalar245 + 2 * mv2.Scalar145 * mv1.KVector1.Scalar3 * mv2.Scalar345 + mv2.Scalar245 * mv1.KVector1.Scalar1 * mv2.Scalar245 + mv2.Scalar345 * mv1.KVector1.Scalar1 * mv2.Scalar345) * mv2NormSquaredInv;
            tempScalar[2] += (mv2.Scalar234 * mv1.KVector1.Scalar2 * mv2.Scalar234 + 2 * mv2.Scalar245 * mv1.KVector1.Scalar3 * mv2.Scalar345 + 2 * mv2.Scalar234 * mv1.KVector1.Scalar5 * mv2.Scalar345 + mv2.Scalar235 * mv1.KVector1.Scalar2 * mv2.Scalar235 + 2 * mv2.Scalar235 * mv1.KVector1.Scalar4 * mv2.Scalar345 + mv2.Scalar245 * mv1.KVector1.Scalar2 * mv2.Scalar245 + mv2.Scalar345 * mv1.KVector1.Scalar2 * mv2.Scalar345) * mv2NormSquaredInv;
            tempScalar[4] += (-mv2.Scalar234 * mv1.KVector1.Scalar3 * mv2.Scalar234 - 2 * mv2.Scalar234 * mv1.KVector1.Scalar5 * mv2.Scalar245 + mv2.Scalar345 * mv1.KVector1.Scalar3 * mv2.Scalar345 - mv2.Scalar235 * mv1.KVector1.Scalar3 * mv2.Scalar235 - mv2.Scalar245 * mv1.KVector1.Scalar3 * mv2.Scalar245 - 2 * mv2.Scalar235 * mv1.KVector1.Scalar4 * mv2.Scalar245) * mv2NormSquaredInv;
            tempScalar[8] += (-mv2.Scalar345 * mv1.KVector1.Scalar4 * mv2.Scalar345 - mv2.Scalar245 * mv1.KVector1.Scalar4 * mv2.Scalar245 + mv2.Scalar234 * mv1.KVector1.Scalar4 * mv2.Scalar234 + mv2.Scalar235 * mv1.KVector1.Scalar4 * mv2.Scalar235 + 2 * mv2.Scalar234 * mv1.KVector1.Scalar5 * mv2.Scalar235) * mv2NormSquaredInv;
            tempScalar[16] += (mv2.Scalar235 * mv1.KVector1.Scalar5 * mv2.Scalar235 + mv2.Scalar345 * mv1.KVector1.Scalar5 * mv2.Scalar345 - mv2.Scalar234 * mv1.KVector1.Scalar5 * mv2.Scalar234 + mv2.Scalar245 * mv1.KVector1.Scalar5 * mv2.Scalar245) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector2.IsZero())
        {
            tempScalar[3] += (mv2.Scalar234 * mv1.KVector2.Scalar12 * mv2.Scalar234 + 2 * mv2.Scalar245 * mv1.KVector2.Scalar13 * mv2.Scalar345 + 2 * mv2.Scalar234 * mv1.KVector2.Scalar15 * mv2.Scalar345 + mv2.Scalar235 * mv1.KVector2.Scalar12 * mv2.Scalar235 + 2 * mv2.Scalar235 * mv1.KVector2.Scalar14 * mv2.Scalar345 + mv2.Scalar245 * mv1.KVector2.Scalar12 * mv2.Scalar245 + mv2.Scalar345 * mv1.KVector2.Scalar12 * mv2.Scalar345) * mv2NormSquaredInv;
            tempScalar[5] += (2 * mv2.Scalar124 * mv1.KVector2.Scalar25 * mv2.Scalar345 - 2 * mv2.Scalar134 * mv1.KVector2.Scalar23 * mv2.Scalar234 - 2 * mv2.Scalar235 * mv1.KVector2.Scalar24 * mv2.Scalar145 - 2 * mv2.Scalar134 * mv1.KVector2.Scalar25 * mv2.Scalar245 + mv2.Scalar345 * mv1.KVector2.Scalar13 * mv2.Scalar345 - mv2.Scalar234 * mv1.KVector2.Scalar13 * mv2.Scalar234 - 2 * mv2.Scalar234 * mv1.KVector2.Scalar15 * mv2.Scalar245 - 2 * mv2.Scalar234 * mv1.KVector2.Scalar25 * mv2.Scalar145 + 2 * mv2.Scalar125 * mv1.KVector2.Scalar24 * mv2.Scalar345 - 2 * mv2.Scalar135 * mv1.KVector2.Scalar23 * mv2.Scalar235 - 2 * mv2.Scalar135 * mv1.KVector2.Scalar24 * mv2.Scalar245 - mv2.Scalar235 * mv1.KVector2.Scalar13 * mv2.Scalar235 - mv2.Scalar245 * mv1.KVector2.Scalar13 * mv2.Scalar245 - 2 * mv2.Scalar145 * mv1.KVector2.Scalar23 * mv2.Scalar245 - 2 * mv2.Scalar235 * mv1.KVector2.Scalar14 * mv2.Scalar245) * mv2NormSquaredInv;
            tempScalar[6] += (-mv2.Scalar234 * mv1.KVector2.Scalar23 * mv2.Scalar234 + mv2.Scalar345 * mv1.KVector2.Scalar23 * mv2.Scalar345 - 2 * mv2.Scalar234 * mv1.KVector2.Scalar25 * mv2.Scalar245 - mv2.Scalar235 * mv1.KVector2.Scalar23 * mv2.Scalar235 - mv2.Scalar245 * mv1.KVector2.Scalar23 * mv2.Scalar245 - 2 * mv2.Scalar235 * mv1.KVector2.Scalar24 * mv2.Scalar245) * mv2NormSquaredInv;
            tempScalar[9] += (-2 * mv2.Scalar123 * mv1.KVector2.Scalar25 * mv2.Scalar345 - 2 * mv2.Scalar123 * mv1.KVector2.Scalar35 * mv2.Scalar245 + 2 * mv2.Scalar124 * mv1.KVector2.Scalar34 * mv2.Scalar234 - 2 * mv2.Scalar145 * mv1.KVector2.Scalar34 * mv2.Scalar345 + 2 * mv2.Scalar124 * mv1.KVector2.Scalar35 * mv2.Scalar235 + 2 * mv2.Scalar134 * mv1.KVector2.Scalar24 * mv2.Scalar234 + 2 * mv2.Scalar134 * mv1.KVector2.Scalar25 * mv2.Scalar235 + mv2.Scalar234 * mv1.KVector2.Scalar14 * mv2.Scalar234 + mv2.Scalar235 * mv1.KVector2.Scalar14 * mv2.Scalar235 + 2 * mv2.Scalar135 * mv1.KVector2.Scalar24 * mv2.Scalar235 + 2 * mv2.Scalar125 * mv1.KVector2.Scalar34 * mv2.Scalar235 + 2 * mv2.Scalar234 * mv1.KVector2.Scalar15 * mv2.Scalar235 + 2 * mv2.Scalar234 * mv1.KVector2.Scalar25 * mv2.Scalar135 + 2 * mv2.Scalar234 * mv1.KVector2.Scalar35 * mv2.Scalar125 - mv2.Scalar245 * mv1.KVector2.Scalar14 * mv2.Scalar245 - mv2.Scalar345 * mv1.KVector2.Scalar14 * mv2.Scalar345 - 2 * mv2.Scalar145 * mv1.KVector2.Scalar24 * mv2.Scalar245) * mv2NormSquaredInv;
            tempScalar[10] += (mv2.Scalar234 * mv1.KVector2.Scalar24 * mv2.Scalar234 - mv2.Scalar345 * mv1.KVector2.Scalar24 * mv2.Scalar345 + mv2.Scalar235 * mv1.KVector2.Scalar24 * mv2.Scalar235 + 2 * mv2.Scalar234 * mv1.KVector2.Scalar25 * mv2.Scalar235 - mv2.Scalar245 * mv1.KVector2.Scalar24 * mv2.Scalar245 - 2 * mv2.Scalar245 * mv1.KVector2.Scalar34 * mv2.Scalar345) * mv2NormSquaredInv;
            tempScalar[12] += (-mv2.Scalar234 * mv1.KVector2.Scalar34 * mv2.Scalar234 - mv2.Scalar235 * mv1.KVector2.Scalar34 * mv2.Scalar235 - 2 * mv2.Scalar234 * mv1.KVector2.Scalar35 * mv2.Scalar235 + mv2.Scalar245 * mv1.KVector2.Scalar34 * mv2.Scalar245 - 2 * mv2.Scalar235 * mv1.KVector2.Scalar23 * mv2.Scalar345 - mv2.Scalar345 * mv1.KVector2.Scalar34 * mv2.Scalar345) * mv2NormSquaredInv;
            tempScalar[17] += (mv2.Scalar345 * mv1.KVector2.Scalar15 * mv2.Scalar345 - 2 * mv2.Scalar123 * mv1.KVector2.Scalar45 * mv2.Scalar234 - 2 * mv2.Scalar124 * mv1.KVector2.Scalar35 * mv2.Scalar234 + mv2.Scalar235 * mv1.KVector2.Scalar15 * mv2.Scalar235 - 2 * mv2.Scalar134 * mv1.KVector2.Scalar25 * mv2.Scalar234 - mv2.Scalar234 * mv1.KVector2.Scalar15 * mv2.Scalar234 + 2 * mv2.Scalar145 * mv1.KVector2.Scalar35 * mv2.Scalar345 + 2 * mv2.Scalar125 * mv1.KVector2.Scalar45 * mv2.Scalar245 + 2 * mv2.Scalar135 * mv1.KVector2.Scalar45 * mv2.Scalar345 + 2 * mv2.Scalar125 * mv1.KVector2.Scalar35 * mv2.Scalar235 + 2 * mv2.Scalar135 * mv1.KVector2.Scalar25 * mv2.Scalar235 + 2 * mv2.Scalar145 * mv1.KVector2.Scalar25 * mv2.Scalar245 + mv2.Scalar245 * mv1.KVector2.Scalar15 * mv2.Scalar245) * mv2NormSquaredInv;
            tempScalar[18] += (mv2.Scalar235 * mv1.KVector2.Scalar25 * mv2.Scalar235 + 2 * mv2.Scalar235 * mv1.KVector2.Scalar45 * mv2.Scalar345 + mv2.Scalar245 * mv1.KVector2.Scalar25 * mv2.Scalar245 + 2 * mv2.Scalar245 * mv1.KVector2.Scalar35 * mv2.Scalar345 - mv2.Scalar234 * mv1.KVector2.Scalar25 * mv2.Scalar234 + mv2.Scalar345 * mv1.KVector2.Scalar25 * mv2.Scalar345) * mv2NormSquaredInv;
            tempScalar[20] += (-mv2.Scalar235 * mv1.KVector2.Scalar35 * mv2.Scalar235 - 2 * mv2.Scalar235 * mv1.KVector2.Scalar45 * mv2.Scalar245 + 2 * mv2.Scalar234 * mv1.KVector2.Scalar23 * mv2.Scalar345 + mv2.Scalar234 * mv1.KVector2.Scalar35 * mv2.Scalar234 + mv2.Scalar345 * mv1.KVector2.Scalar35 * mv2.Scalar345 - mv2.Scalar245 * mv1.KVector2.Scalar35 * mv2.Scalar245) * mv2NormSquaredInv;
            tempScalar[24] += (mv2.Scalar235 * mv1.KVector2.Scalar45 * mv2.Scalar235 - 2 * mv2.Scalar234 * mv1.KVector2.Scalar24 * mv2.Scalar345 - 2 * mv2.Scalar234 * mv1.KVector2.Scalar34 * mv2.Scalar245 - mv2.Scalar234 * mv1.KVector2.Scalar45 * mv2.Scalar234 - mv2.Scalar245 * mv1.KVector2.Scalar45 * mv2.Scalar245 - mv2.Scalar345 * mv1.KVector2.Scalar45 * mv2.Scalar345) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector3.IsZero())
        {
            tempScalar[7] += (-2 * mv2.Scalar123 * mv1.KVector3.Scalar234 * mv2.Scalar234 - 2 * mv2.Scalar123 * mv1.KVector3.Scalar235 * mv2.Scalar235 - 2 * mv2.Scalar123 * mv1.KVector3.Scalar245 * mv2.Scalar245 - 2 * mv2.Scalar124 * mv1.KVector3.Scalar235 * mv2.Scalar245 - 2 * mv2.Scalar124 * mv1.KVector3.Scalar245 * mv2.Scalar235 + 2 * mv2.Scalar134 * mv1.KVector3.Scalar235 * mv2.Scalar345 - mv2.Scalar234 * mv1.KVector3.Scalar123 * mv2.Scalar234 - 2 * mv2.Scalar234 * mv1.KVector3.Scalar125 * mv2.Scalar245 - 2 * mv2.Scalar234 * mv1.KVector3.Scalar245 * mv2.Scalar125 + mv2.Scalar345 * mv1.KVector3.Scalar123 * mv2.Scalar345 - 2 * mv2.Scalar125 * mv1.KVector3.Scalar234 * mv2.Scalar245 + 2 * mv2.Scalar135 * mv1.KVector3.Scalar234 * mv2.Scalar345 - mv2.Scalar235 * mv1.KVector3.Scalar123 * mv2.Scalar235 - mv2.Scalar245 * mv1.KVector3.Scalar123 * mv2.Scalar245 - 2 * mv2.Scalar235 * mv1.KVector3.Scalar124 * mv2.Scalar245) * mv2NormSquaredInv;
            tempScalar[11] += (2 * mv2.Scalar123 * mv1.KVector3.Scalar245 * mv2.Scalar235 - 2 * mv2.Scalar124 * mv1.KVector3.Scalar245 * mv2.Scalar245 - 2 * mv2.Scalar124 * mv1.KVector3.Scalar345 * mv2.Scalar345 - mv2.Scalar245 * mv1.KVector3.Scalar124 * mv2.Scalar245 - 2 * mv2.Scalar134 * mv1.KVector3.Scalar245 * mv2.Scalar345 - 2 * mv2.Scalar134 * mv1.KVector3.Scalar345 * mv2.Scalar245 + mv2.Scalar234 * mv1.KVector3.Scalar124 * mv2.Scalar234 + mv2.Scalar235 * mv1.KVector3.Scalar124 * mv2.Scalar235 + 2 * mv2.Scalar234 * mv1.KVector3.Scalar125 * mv2.Scalar235 + 2 * mv2.Scalar234 * mv1.KVector3.Scalar345 * mv2.Scalar145 - mv2.Scalar345 * mv1.KVector3.Scalar124 * mv2.Scalar345 - 2 * mv2.Scalar245 * mv1.KVector3.Scalar134 * mv2.Scalar345) * mv2NormSquaredInv;
            tempScalar[13] += (mv2.Scalar245 * mv1.KVector3.Scalar134 * mv2.Scalar245 - 2 * mv2.Scalar123 * mv1.KVector3.Scalar235 * mv2.Scalar345 - 2 * mv2.Scalar123 * mv1.KVector3.Scalar345 * mv2.Scalar235 + 2 * mv2.Scalar124 * mv1.KVector3.Scalar345 * mv2.Scalar245 - 2 * mv2.Scalar134 * mv1.KVector3.Scalar234 * mv2.Scalar234 - 2 * mv2.Scalar134 * mv1.KVector3.Scalar235 * mv2.Scalar235 - 2 * mv2.Scalar134 * mv1.KVector3.Scalar345 * mv2.Scalar345 - mv2.Scalar234 * mv1.KVector3.Scalar134 * mv2.Scalar234 - mv2.Scalar235 * mv1.KVector3.Scalar134 * mv2.Scalar235 - 2 * mv2.Scalar135 * mv1.KVector3.Scalar234 * mv2.Scalar235 - 2 * mv2.Scalar234 * mv1.KVector3.Scalar135 * mv2.Scalar235 - 2 * mv2.Scalar234 * mv1.KVector3.Scalar235 * mv2.Scalar135 - 2 * mv2.Scalar235 * mv1.KVector3.Scalar123 * mv2.Scalar345 - mv2.Scalar345 * mv1.KVector3.Scalar134 * mv2.Scalar345 + 2 * mv2.Scalar145 * mv1.KVector3.Scalar234 * mv2.Scalar245) * mv2NormSquaredInv;
            tempScalar[14] += (-mv2.Scalar234 * mv1.KVector3.Scalar234 * mv2.Scalar234 - 2 * mv2.Scalar234 * mv1.KVector3.Scalar235 * mv2.Scalar235 - 2 * mv2.Scalar234 * mv1.KVector3.Scalar345 * mv2.Scalar345 - mv2.Scalar235 * mv1.KVector3.Scalar234 * mv2.Scalar235 - mv2.Scalar345 * mv1.KVector3.Scalar234 * mv2.Scalar345 + mv2.Scalar245 * mv1.KVector3.Scalar234 * mv2.Scalar245) * mv2NormSquaredInv;
            tempScalar[19] += (2 * mv2.Scalar123 * mv1.KVector3.Scalar234 * mv2.Scalar245 + 2 * mv2.Scalar124 * mv1.KVector3.Scalar234 * mv2.Scalar235 + 2 * mv2.Scalar245 * mv1.KVector3.Scalar135 * mv2.Scalar345 - 2 * mv2.Scalar234 * mv1.KVector3.Scalar234 * mv2.Scalar125 - mv2.Scalar234 * mv1.KVector3.Scalar125 * mv2.Scalar234 + mv2.Scalar235 * mv1.KVector3.Scalar125 * mv2.Scalar235 + 2 * mv2.Scalar235 * mv1.KVector3.Scalar145 * mv2.Scalar345 + mv2.Scalar245 * mv1.KVector3.Scalar125 * mv2.Scalar245 + mv2.Scalar345 * mv1.KVector3.Scalar125 * mv2.Scalar345) * mv2NormSquaredInv;
            tempScalar[21] += (-2 * mv2.Scalar145 * mv1.KVector3.Scalar235 * mv2.Scalar245 + 2 * mv2.Scalar134 * mv1.KVector3.Scalar235 * mv2.Scalar234 + 2 * mv2.Scalar234 * mv1.KVector3.Scalar123 * mv2.Scalar345 + mv2.Scalar234 * mv1.KVector3.Scalar135 * mv2.Scalar234 + mv2.Scalar345 * mv1.KVector3.Scalar135 * mv2.Scalar345 + 2 * mv2.Scalar125 * mv1.KVector3.Scalar245 * mv2.Scalar345 - 2 * mv2.Scalar135 * mv1.KVector3.Scalar235 * mv2.Scalar235 - 2 * mv2.Scalar135 * mv1.KVector3.Scalar245 * mv2.Scalar245 - mv2.Scalar235 * mv1.KVector3.Scalar135 * mv2.Scalar235 - mv2.Scalar245 * mv1.KVector3.Scalar135 * mv2.Scalar245 - 2 * mv2.Scalar235 * mv1.KVector3.Scalar145 * mv2.Scalar245 - 2 * mv2.Scalar235 * mv1.KVector3.Scalar245 * mv2.Scalar145) * mv2NormSquaredInv;
            tempScalar[22] += (mv2.Scalar234 * mv1.KVector3.Scalar235 * mv2.Scalar234 - mv2.Scalar235 * mv1.KVector3.Scalar235 * mv2.Scalar235 - mv2.Scalar245 * mv1.KVector3.Scalar235 * mv2.Scalar245 - 2 * mv2.Scalar235 * mv1.KVector3.Scalar245 * mv2.Scalar245 + mv2.Scalar345 * mv1.KVector3.Scalar235 * mv2.Scalar345) * mv2NormSquaredInv;
            tempScalar[25] += (-2 * mv2.Scalar124 * mv1.KVector3.Scalar234 * mv2.Scalar345 - 2 * mv2.Scalar124 * mv1.KVector3.Scalar345 * mv2.Scalar234 - 2 * mv2.Scalar134 * mv1.KVector3.Scalar234 * mv2.Scalar245 - 2 * mv2.Scalar134 * mv1.KVector3.Scalar245 * mv2.Scalar234 - 2 * mv2.Scalar234 * mv1.KVector3.Scalar124 * mv2.Scalar345 - 2 * mv2.Scalar234 * mv1.KVector3.Scalar134 * mv2.Scalar245 - 2 * mv2.Scalar234 * mv1.KVector3.Scalar234 * mv2.Scalar145 - mv2.Scalar234 * mv1.KVector3.Scalar145 * mv2.Scalar234 - mv2.Scalar245 * mv1.KVector3.Scalar145 * mv2.Scalar245 - mv2.Scalar345 * mv1.KVector3.Scalar145 * mv2.Scalar345 - 2 * mv2.Scalar145 * mv1.KVector3.Scalar245 * mv2.Scalar245 + 2 * mv2.Scalar125 * mv1.KVector3.Scalar345 * mv2.Scalar235 + 2 * mv2.Scalar135 * mv1.KVector3.Scalar245 * mv2.Scalar235 + mv2.Scalar235 * mv1.KVector3.Scalar145 * mv2.Scalar235 - 2 * mv2.Scalar145 * mv1.KVector3.Scalar345 * mv2.Scalar345) * mv2NormSquaredInv;
            tempScalar[26] += (-mv2.Scalar234 * mv1.KVector3.Scalar245 * mv2.Scalar234 - 2 * mv2.Scalar234 * mv1.KVector3.Scalar234 * mv2.Scalar245 - mv2.Scalar345 * mv1.KVector3.Scalar245 * mv2.Scalar345 - mv2.Scalar245 * mv1.KVector3.Scalar245 * mv2.Scalar245 - 2 * mv2.Scalar245 * mv1.KVector3.Scalar345 * mv2.Scalar345 + mv2.Scalar235 * mv1.KVector3.Scalar245 * mv2.Scalar235) * mv2NormSquaredInv;
            tempScalar[28] += (mv2.Scalar234 * mv1.KVector3.Scalar345 * mv2.Scalar234 - mv2.Scalar235 * mv1.KVector3.Scalar345 * mv2.Scalar235 + mv2.Scalar245 * mv1.KVector3.Scalar345 * mv2.Scalar245 - 2 * mv2.Scalar235 * mv1.KVector3.Scalar235 * mv2.Scalar345 - mv2.Scalar345 * mv1.KVector3.Scalar345 * mv2.Scalar345) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector4.IsZero())
        {
            tempScalar[15] += (-mv2.Scalar234 * mv1.KVector4.Scalar1234 * mv2.Scalar234 - mv2.Scalar235 * mv1.KVector4.Scalar1234 * mv2.Scalar235 - mv2.Scalar345 * mv1.KVector4.Scalar1234 * mv2.Scalar345 - 2 * mv2.Scalar234 * mv1.KVector4.Scalar1235 * mv2.Scalar235 - 2 * mv2.Scalar234 * mv1.KVector4.Scalar1345 * mv2.Scalar345 + mv2.Scalar245 * mv1.KVector4.Scalar1234 * mv2.Scalar245) * mv2NormSquaredInv;
            tempScalar[23] += (2 * mv2.Scalar123 * mv1.KVector4.Scalar2345 * mv2.Scalar234 + mv2.Scalar234 * mv1.KVector4.Scalar1235 * mv2.Scalar234 + mv2.Scalar345 * mv1.KVector4.Scalar1235 * mv2.Scalar345 - 2 * mv2.Scalar125 * mv1.KVector4.Scalar2345 * mv2.Scalar245 + 2 * mv2.Scalar135 * mv1.KVector4.Scalar2345 * mv2.Scalar345 - mv2.Scalar235 * mv1.KVector4.Scalar1235 * mv2.Scalar235 - mv2.Scalar245 * mv1.KVector4.Scalar1235 * mv2.Scalar245 - 2 * mv2.Scalar235 * mv1.KVector4.Scalar1245 * mv2.Scalar245) * mv2NormSquaredInv;
            tempScalar[27] += (-2 * mv2.Scalar245 * mv1.KVector4.Scalar1345 * mv2.Scalar345 - mv2.Scalar345 * mv1.KVector4.Scalar1245 * mv2.Scalar345 - 2 * mv2.Scalar234 * mv1.KVector4.Scalar1234 * mv2.Scalar245 - mv2.Scalar234 * mv1.KVector4.Scalar1245 * mv2.Scalar234 - mv2.Scalar245 * mv1.KVector4.Scalar1245 * mv2.Scalar245 + mv2.Scalar235 * mv1.KVector4.Scalar1245 * mv2.Scalar235) * mv2NormSquaredInv;
            tempScalar[29] += (mv2.Scalar245 * mv1.KVector4.Scalar1345 * mv2.Scalar245 + 2 * mv2.Scalar134 * mv1.KVector4.Scalar2345 * mv2.Scalar234 + mv2.Scalar234 * mv1.KVector4.Scalar1345 * mv2.Scalar234 - 2 * mv2.Scalar135 * mv1.KVector4.Scalar2345 * mv2.Scalar235 - 2 * mv2.Scalar235 * mv1.KVector4.Scalar1235 * mv2.Scalar345 - mv2.Scalar235 * mv1.KVector4.Scalar1345 * mv2.Scalar235 - mv2.Scalar345 * mv1.KVector4.Scalar1345 * mv2.Scalar345 + 2 * mv2.Scalar145 * mv1.KVector4.Scalar2345 * mv2.Scalar245) * mv2NormSquaredInv;
            tempScalar[30] += (mv2.Scalar234 * mv1.KVector4.Scalar2345 * mv2.Scalar234 + mv2.Scalar245 * mv1.KVector4.Scalar2345 * mv2.Scalar245 - mv2.Scalar235 * mv1.KVector4.Scalar2345 * mv2.Scalar235 - mv2.Scalar345 * mv1.KVector4.Scalar2345 * mv2.Scalar345) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector5.IsZero())
        {
            tempScalar[31] += (-mv2.Scalar235 * mv1.KVector5.Scalar12345 * mv2.Scalar235 - mv2.Scalar345 * mv1.KVector5.Scalar12345 * mv2.Scalar345 + mv2.Scalar234 * mv1.KVector5.Scalar12345 * mv2.Scalar234 + mv2.Scalar245 * mv1.KVector5.Scalar12345 * mv2.Scalar245) * mv2NormSquaredInv;
        }
        
        return Ga401Multivector.Create(tempScalar);
    }
    
    public static Ga401Multivector MapUsingVersor(this Ga401Multivector mv1, Ga401KVector4 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401Multivector.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        var tempScalar = new double[32];
        
        if (!mv1.KVector0.IsZero())
        {
            tempScalar[0] += (mv2.Scalar2345 * mv1.KVector0.Scalar * mv2.Scalar2345) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector1.IsZero())
        {
            tempScalar[1] += (2 * mv2.Scalar1234 * mv1.KVector1.Scalar5 * mv2.Scalar2345 - 2 * mv2.Scalar1235 * mv1.KVector1.Scalar4 * mv2.Scalar2345 + 2 * mv2.Scalar1245 * mv1.KVector1.Scalar3 * mv2.Scalar2345 - 2 * mv2.Scalar1345 * mv1.KVector1.Scalar2 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.KVector1.Scalar1 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[2] += (-mv2.Scalar2345 * mv1.KVector1.Scalar2 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[4] += (-mv2.Scalar2345 * mv1.KVector1.Scalar3 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[8] += (-mv2.Scalar2345 * mv1.KVector1.Scalar4 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[16] += (-mv2.Scalar2345 * mv1.KVector1.Scalar5 * mv2.Scalar2345) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector2.IsZero())
        {
            tempScalar[3] += (2 * mv2.Scalar1234 * mv1.KVector2.Scalar25 * mv2.Scalar2345 - 2 * mv2.Scalar1235 * mv1.KVector2.Scalar24 * mv2.Scalar2345 + 2 * mv2.Scalar1245 * mv1.KVector2.Scalar23 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.KVector2.Scalar12 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[5] += (2 * mv2.Scalar1234 * mv1.KVector2.Scalar35 * mv2.Scalar2345 - 2 * mv2.Scalar1235 * mv1.KVector2.Scalar34 * mv2.Scalar2345 + 2 * mv2.Scalar1345 * mv1.KVector2.Scalar23 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.KVector2.Scalar13 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[6] += (mv2.Scalar2345 * mv1.KVector2.Scalar23 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[9] += (2 * mv2.Scalar1234 * mv1.KVector2.Scalar45 * mv2.Scalar2345 - 2 * mv2.Scalar1245 * mv1.KVector2.Scalar34 * mv2.Scalar2345 + 2 * mv2.Scalar1345 * mv1.KVector2.Scalar24 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.KVector2.Scalar14 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[10] += (mv2.Scalar2345 * mv1.KVector2.Scalar24 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[12] += (mv2.Scalar2345 * mv1.KVector2.Scalar34 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[17] += (2 * mv2.Scalar1235 * mv1.KVector2.Scalar45 * mv2.Scalar2345 - 2 * mv2.Scalar1245 * mv1.KVector2.Scalar35 * mv2.Scalar2345 + 2 * mv2.Scalar1345 * mv1.KVector2.Scalar25 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.KVector2.Scalar15 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[18] += (mv2.Scalar2345 * mv1.KVector2.Scalar25 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[20] += (mv2.Scalar2345 * mv1.KVector2.Scalar35 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[24] += (mv2.Scalar2345 * mv1.KVector2.Scalar45 * mv2.Scalar2345) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector3.IsZero())
        {
            tempScalar[7] += (2 * mv2.Scalar1234 * mv1.KVector3.Scalar235 * mv2.Scalar2345 - 2 * mv2.Scalar1235 * mv1.KVector3.Scalar234 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.KVector3.Scalar123 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[11] += (2 * mv2.Scalar1234 * mv1.KVector3.Scalar245 * mv2.Scalar2345 - 2 * mv2.Scalar1245 * mv1.KVector3.Scalar234 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.KVector3.Scalar124 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[13] += (2 * mv2.Scalar1234 * mv1.KVector3.Scalar345 * mv2.Scalar2345 - 2 * mv2.Scalar1345 * mv1.KVector3.Scalar234 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.KVector3.Scalar134 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[14] += (-mv2.Scalar2345 * mv1.KVector3.Scalar234 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[19] += (2 * mv2.Scalar1235 * mv1.KVector3.Scalar245 * mv2.Scalar2345 - 2 * mv2.Scalar1245 * mv1.KVector3.Scalar235 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.KVector3.Scalar125 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[21] += (2 * mv2.Scalar1235 * mv1.KVector3.Scalar345 * mv2.Scalar2345 - 2 * mv2.Scalar1345 * mv1.KVector3.Scalar235 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.KVector3.Scalar135 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[22] += (-mv2.Scalar2345 * mv1.KVector3.Scalar235 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[25] += (2 * mv2.Scalar1245 * mv1.KVector3.Scalar345 * mv2.Scalar2345 - 2 * mv2.Scalar1345 * mv1.KVector3.Scalar245 * mv2.Scalar2345 + mv2.Scalar2345 * mv1.KVector3.Scalar145 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[26] += (-mv2.Scalar2345 * mv1.KVector3.Scalar245 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[28] += (-mv2.Scalar2345 * mv1.KVector3.Scalar345 * mv2.Scalar2345) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector4.IsZero())
        {
            tempScalar[15] += (2 * mv2.Scalar1234 * mv1.KVector4.Scalar2345 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.KVector4.Scalar1234 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[23] += (2 * mv2.Scalar1235 * mv1.KVector4.Scalar2345 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.KVector4.Scalar1235 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[27] += (2 * mv2.Scalar1245 * mv1.KVector4.Scalar2345 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.KVector4.Scalar1245 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[29] += (2 * mv2.Scalar1345 * mv1.KVector4.Scalar2345 * mv2.Scalar2345 - mv2.Scalar2345 * mv1.KVector4.Scalar1345 * mv2.Scalar2345) * mv2NormSquaredInv;
            tempScalar[30] += (mv2.Scalar2345 * mv1.KVector4.Scalar2345 * mv2.Scalar2345) * mv2NormSquaredInv;
        }
        
        if (!mv1.KVector5.IsZero())
        {
            tempScalar[31] += (mv2.Scalar2345 * mv1.KVector5.Scalar12345 * mv2.Scalar2345) * mv2NormSquaredInv;
        }
        
        return Ga401Multivector.Create(tempScalar);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga401Multivector MapUsingVersor(this Ga401Multivector mv1, Ga401KVector5 mv2)
    {
        return Ga401Multivector.Zero;
    }
    
    public static Ga401Multivector MapUsingEvenVersor(this Ga401Multivector mv1, Ga401Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401Multivector.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        var tempScalar = new double[32];
        
        if (!mv1.KVector0.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar[0] += (mv2.KVector0.Scalar * mv1.KVector0.Scalar * mv2.KVector0.Scalar) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector2.IsZero())
            {
                tempScalar[0] += (mv2.KVector2.Scalar23 * mv1.KVector0.Scalar * mv2.KVector2.Scalar23 + mv2.KVector2.Scalar24 * mv1.KVector0.Scalar * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.KVector0.Scalar * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar25 * mv1.KVector0.Scalar * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar45 * mv1.KVector0.Scalar * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar35 * mv1.KVector0.Scalar * mv2.KVector2.Scalar35) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector4.IsZero())
            {
                tempScalar[0] += (mv2.KVector4.Scalar2345 * mv1.KVector0.Scalar * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
            }
            
        }
        
        if (!mv1.KVector1.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar[1] += (mv2.KVector0.Scalar * mv1.KVector1.Scalar1 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[2] += (mv2.KVector0.Scalar * mv1.KVector1.Scalar2 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[4] += (mv2.KVector0.Scalar * mv1.KVector1.Scalar3 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[8] += (mv2.KVector0.Scalar * mv1.KVector1.Scalar4 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[16] += (mv2.KVector0.Scalar * mv1.KVector1.Scalar5 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector0.IsZero() && !mv2.KVector2.IsZero())
            {
                tempScalar[1] += (2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar13 + 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar14 + 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar15) * mv2NormSquaredInv;
                tempScalar[2] += (2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar24 + 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar25) * mv2NormSquaredInv;
                tempScalar[4] += (-2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar35) * mv2NormSquaredInv;
                tempScalar[8] += (-2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar45) * mv2NormSquaredInv;
                tempScalar[16] += (-2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar25 - 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar45) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector2.IsZero())
            {
                tempScalar[1] += (2 * mv2.KVector2.Scalar12 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar12 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar12 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar13 * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar13 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar13 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar23 * mv1.KVector1.Scalar1 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar15 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar14 * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar14 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar14 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar24 * mv1.KVector1.Scalar1 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar15 * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar34 * mv1.KVector1.Scalar1 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar45 * mv1.KVector1.Scalar1 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar15 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar25 * mv1.KVector1.Scalar1 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar35 * mv1.KVector1.Scalar1 * mv2.KVector2.Scalar35) * mv2NormSquaredInv;
                tempScalar[2] += (mv2.KVector2.Scalar23 * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar23 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar23 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar24 * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar24 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar24 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar25 * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar35 * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar25 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar25 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar45) * mv2NormSquaredInv;
                tempScalar[4] += (-mv2.KVector2.Scalar23 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar25 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar23 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar34 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar34 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar35 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar35 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar45) * mv2NormSquaredInv;
                tempScalar[8] += (mv2.KVector2.Scalar23 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar25 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar24 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar45 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar34 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar35 * mv1.KVector1.Scalar4 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar35) * mv2NormSquaredInv;
                tempScalar[16] += (-mv2.KVector2.Scalar45 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar35 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar23 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar23 + mv2.KVector2.Scalar24 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar25 * mv1.KVector1.Scalar5 * mv2.KVector2.Scalar25) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector2.IsZero() && !mv2.KVector4.IsZero())
            {
                tempScalar[1] += (2 * mv2.KVector2.Scalar34 * mv1.KVector1.Scalar2 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector2.Scalar35 * mv1.KVector1.Scalar2 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar23 * mv1.KVector1.Scalar4 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector2.Scalar23 * mv1.KVector1.Scalar5 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar45 * mv1.KVector1.Scalar2 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar24 * mv1.KVector1.Scalar5 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar45 * mv1.KVector1.Scalar3 * mv2.KVector4.Scalar1345 + 2 * mv2.KVector2.Scalar34 * mv1.KVector1.Scalar5 * mv2.KVector4.Scalar1345) * mv2NormSquaredInv;
                tempScalar[2] += (2 * mv2.KVector2.Scalar45 * mv1.KVector1.Scalar3 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar34 * mv1.KVector1.Scalar5 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[4] += (-2 * mv2.KVector2.Scalar24 * mv1.KVector1.Scalar5 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[8] += (2 * mv2.KVector2.Scalar23 * mv1.KVector1.Scalar5 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar25 * mv1.KVector1.Scalar3 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[16] += (2 * mv2.KVector2.Scalar24 * mv1.KVector1.Scalar3 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector4.IsZero())
            {
                tempScalar[1] += (-2 * mv2.KVector4.Scalar1235 * mv1.KVector1.Scalar4 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1234 * mv1.KVector1.Scalar5 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1245 * mv1.KVector1.Scalar3 * mv2.KVector4.Scalar2345 + mv2.KVector4.Scalar2345 * mv1.KVector1.Scalar1 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector4.Scalar1345 * mv1.KVector1.Scalar2 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[2] += (-mv2.KVector4.Scalar2345 * mv1.KVector1.Scalar2 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[4] += (-mv2.KVector4.Scalar2345 * mv1.KVector1.Scalar3 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[8] += (-mv2.KVector4.Scalar2345 * mv1.KVector1.Scalar4 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[16] += (-mv2.KVector4.Scalar2345 * mv1.KVector1.Scalar5 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
            }
            
        }
        
        if (!mv1.KVector2.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar[3] += (mv2.KVector0.Scalar * mv1.KVector2.Scalar12 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[5] += (mv2.KVector0.Scalar * mv1.KVector2.Scalar13 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[6] += (mv2.KVector0.Scalar * mv1.KVector2.Scalar23 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[9] += (mv2.KVector0.Scalar * mv1.KVector2.Scalar14 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[10] += (mv2.KVector0.Scalar * mv1.KVector2.Scalar24 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[12] += (mv2.KVector0.Scalar * mv1.KVector2.Scalar34 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[17] += (mv2.KVector0.Scalar * mv1.KVector2.Scalar15 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[18] += (mv2.KVector0.Scalar * mv1.KVector2.Scalar25 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[20] += (mv2.KVector0.Scalar * mv1.KVector2.Scalar35 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[24] += (mv2.KVector0.Scalar * mv1.KVector2.Scalar45 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector0.IsZero() && !mv2.KVector2.IsZero())
            {
                tempScalar[3] += (2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar23 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar13 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar14 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar25 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar15) * mv2NormSquaredInv;
                tempScalar[5] += (-2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar34 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar14 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar15) * mv2NormSquaredInv;
                tempScalar[6] += (2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar34 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar24 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar25) * mv2NormSquaredInv;
                tempScalar[9] += (-2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar13 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar15) * mv2NormSquaredInv;
                tempScalar[10] += (-2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar25) * mv2NormSquaredInv;
                tempScalar[12] += (2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar35) * mv2NormSquaredInv;
                tempScalar[17] += (-2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar25 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar45 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar13 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar14) * mv2NormSquaredInv;
                tempScalar[18] += (-2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar45 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar24) * mv2NormSquaredInv;
                tempScalar[20] += (2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar25 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar34) * mv2NormSquaredInv;
                tempScalar[24] += (2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar25 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar34) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector0.IsZero() && !mv2.KVector4.IsZero())
            {
                tempScalar[3] += (-2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar34 * mv2.KVector4.Scalar1234 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar45 * mv2.KVector4.Scalar1245) * mv2NormSquaredInv;
                tempScalar[5] += (2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar45 * mv2.KVector4.Scalar1345) * mv2NormSquaredInv;
                tempScalar[6] += (-2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar45 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[9] += (-2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar23 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar1345) * mv2NormSquaredInv;
                tempScalar[10] += (2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[12] += (-2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[17] += (-2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar23 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar1245 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar34 * mv2.KVector4.Scalar1345) * mv2NormSquaredInv;
                tempScalar[18] += (-2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar34 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[20] += (2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[24] += (-2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar23 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector2.IsZero())
            {
                tempScalar[3] += (mv2.KVector2.Scalar23 * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar24 * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar25 * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar35 * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar25 * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar25 * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar45) * mv2NormSquaredInv;
                tempScalar[5] += (2 * mv2.KVector2.Scalar12 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar12 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar13 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar13 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar13 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar23 * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar25 * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar14 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar15 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar14 - 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar15 + mv2.KVector2.Scalar34 * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar35 * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar35 * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar45) * mv2NormSquaredInv;
                tempScalar[6] += (-mv2.KVector2.Scalar23 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar34 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar45 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar25 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar35 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar35 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar45) * mv2NormSquaredInv;
                tempScalar[9] += (2 * mv2.KVector2.Scalar12 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar12 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar13 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar15 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar13 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar45 * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar23 * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar14 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar14 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar14 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar14 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar35 - mv2.KVector2.Scalar24 * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar25 * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar15 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar15 - mv2.KVector2.Scalar34 * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar35 * mv1.KVector2.Scalar14 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar15) * mv2NormSquaredInv;
                tempScalar[10] += (-mv2.KVector2.Scalar24 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar25 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar23 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar35 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar35 - mv2.KVector2.Scalar34 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar25 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar25) * mv2NormSquaredInv;
                tempScalar[12] += (2 * mv2.KVector2.Scalar25 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar24 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar23 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar34 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar25 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar35 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar45) * mv2NormSquaredInv;
                tempScalar[17] += (2 * mv2.KVector2.Scalar12 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar45 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar12 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar13 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar13 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar35 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar23 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar15 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar14 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar14 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar24 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar15 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar15 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar25 * mv1.KVector2.Scalar15 * mv2.KVector2.Scalar25) * mv2NormSquaredInv;
                tempScalar[18] += (-mv2.KVector2.Scalar35 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar25 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar23 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar25 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar24 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar25 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar45 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar45) * mv2NormSquaredInv;
                tempScalar[20] += (-mv2.KVector2.Scalar45 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar23 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar35 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar35 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar25 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar34 * mv1.KVector2.Scalar35 * mv2.KVector2.Scalar34) * mv2NormSquaredInv;
                tempScalar[24] += (2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar23 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar24 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar35 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar34 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar25 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar45 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar45) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector2.IsZero() && !mv2.KVector4.IsZero())
            {
                tempScalar[3] += (2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar14 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar1345 + 2 * mv2.KVector2.Scalar45 * mv1.KVector2.Scalar13 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar15 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar35 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar1345) * mv2NormSquaredInv;
                tempScalar[5] += (2 * mv2.KVector2.Scalar45 * mv1.KVector2.Scalar23 * mv2.KVector4.Scalar1245 - 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar15 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar1345 - 2 * mv2.KVector2.Scalar15 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar25 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar1345) * mv2NormSquaredInv;
                tempScalar[6] += (2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar25 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[9] += (2 * mv2.KVector2.Scalar12 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar15 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar1245 - 2 * mv2.KVector2.Scalar25 * mv1.KVector2.Scalar34 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar25 * mv1.KVector2.Scalar13 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar35 * mv1.KVector2.Scalar23 * mv2.KVector4.Scalar1245) * mv2NormSquaredInv;
                tempScalar[12] += (2 * mv2.KVector2.Scalar45 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[17] += (2 * mv2.KVector2.Scalar13 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar1345 + 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar45 * mv2.KVector4.Scalar1234 - 2 * mv2.KVector2.Scalar45 * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar13 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar24 * mv1.KVector2.Scalar34 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar35 * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar23 * mv2.KVector4.Scalar1245 - 2 * mv2.KVector2.Scalar45 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar1345) * mv2NormSquaredInv;
                tempScalar[18] += (2 * mv2.KVector2.Scalar23 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar45 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[24] += (-2 * mv2.KVector2.Scalar34 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar25 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector4.IsZero() && !mv2.KVector2.IsZero())
            {
                tempScalar[3] += (2 * mv2.KVector4.Scalar1234 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar35 + 2 * mv2.KVector4.Scalar1235 * mv1.KVector2.Scalar34 * mv2.KVector2.Scalar45) * mv2NormSquaredInv;
                tempScalar[5] += (2 * mv2.KVector4.Scalar1234 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar45 - 2 * mv2.KVector4.Scalar1234 * mv1.KVector2.Scalar45 * mv2.KVector2.Scalar25) * mv2NormSquaredInv;
                tempScalar[9] += (-2 * mv2.KVector4.Scalar1234 * mv1.KVector2.Scalar25 * mv2.KVector2.Scalar35) * mv2NormSquaredInv;
                tempScalar[17] += (-2 * mv2.KVector4.Scalar1234 * mv1.KVector2.Scalar24 * mv2.KVector2.Scalar35) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector4.IsZero())
            {
                tempScalar[3] += (2 * mv2.KVector4.Scalar1245 * mv1.KVector2.Scalar23 * mv2.KVector4.Scalar2345 - mv2.KVector4.Scalar2345 * mv1.KVector2.Scalar12 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector4.Scalar1235 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1234 * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[5] += (2 * mv2.KVector4.Scalar1345 * mv1.KVector2.Scalar23 * mv2.KVector4.Scalar2345 - mv2.KVector4.Scalar2345 * mv1.KVector2.Scalar13 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1234 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector4.Scalar1235 * mv1.KVector2.Scalar34 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[6] += (mv2.KVector4.Scalar2345 * mv1.KVector2.Scalar23 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[9] += (-2 * mv2.KVector4.Scalar1245 * mv1.KVector2.Scalar34 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1234 * mv1.KVector2.Scalar45 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1345 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar2345 - mv2.KVector4.Scalar2345 * mv1.KVector2.Scalar14 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[10] += (mv2.KVector4.Scalar2345 * mv1.KVector2.Scalar24 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[12] += (mv2.KVector4.Scalar2345 * mv1.KVector2.Scalar34 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[17] += (-2 * mv2.KVector4.Scalar1245 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1345 * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1235 * mv1.KVector2.Scalar45 * mv2.KVector4.Scalar2345 - mv2.KVector4.Scalar2345 * mv1.KVector2.Scalar15 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[18] += (mv2.KVector4.Scalar2345 * mv1.KVector2.Scalar25 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[20] += (mv2.KVector4.Scalar2345 * mv1.KVector2.Scalar35 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[24] += (mv2.KVector4.Scalar2345 * mv1.KVector2.Scalar45 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
            }
            
        }
        
        if (!mv1.KVector3.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar[7] += (mv2.KVector0.Scalar * mv1.KVector3.Scalar123 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[11] += (mv2.KVector0.Scalar * mv1.KVector3.Scalar124 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[13] += (mv2.KVector0.Scalar * mv1.KVector3.Scalar134 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[14] += (mv2.KVector0.Scalar * mv1.KVector3.Scalar234 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[19] += (mv2.KVector0.Scalar * mv1.KVector3.Scalar125 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[21] += (mv2.KVector0.Scalar * mv1.KVector3.Scalar135 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[22] += (mv2.KVector0.Scalar * mv1.KVector3.Scalar235 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[25] += (mv2.KVector0.Scalar * mv1.KVector3.Scalar145 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[26] += (mv2.KVector0.Scalar * mv1.KVector3.Scalar245 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[28] += (mv2.KVector0.Scalar * mv1.KVector3.Scalar345 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector0.IsZero() && !mv2.KVector2.IsZero())
            {
                tempScalar[7] += (2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar34 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar24 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar14 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar25 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar15) * mv2NormSquaredInv;
                tempScalar[11] += (-2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar23 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar13 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar25 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar15) * mv2NormSquaredInv;
                tempScalar[13] += (2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar35 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar15) * mv2NormSquaredInv;
                tempScalar[14] += (2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar35 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar25) * mv2NormSquaredInv;
                tempScalar[19] += (-2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar45 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar23 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar13 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar14) * mv2NormSquaredInv;
                tempScalar[21] += (2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar25 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar34 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar14) * mv2NormSquaredInv;
                tempScalar[22] += (-2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar45 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar34 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar24) * mv2NormSquaredInv;
                tempScalar[25] += (2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar25 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar13) * mv2NormSquaredInv;
                tempScalar[26] += (2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar23) * mv2NormSquaredInv;
                tempScalar[28] += (-2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar25 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar23) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector0.IsZero() && !mv2.KVector4.IsZero())
            {
                tempScalar[7] += (-2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar145 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar1345 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar345 * mv2.KVector4.Scalar1245) * mv2NormSquaredInv;
                tempScalar[11] += (2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar135 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar235 * mv2.KVector4.Scalar1345 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar345 * mv2.KVector4.Scalar1235) * mv2NormSquaredInv;
                tempScalar[13] += (-2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar125 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar235 * mv2.KVector4.Scalar1245 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar1235) * mv2NormSquaredInv;
                tempScalar[19] += (-2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar134 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar1345 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar345 * mv2.KVector4.Scalar1234) * mv2NormSquaredInv;
                tempScalar[21] += (2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar124 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar1234) * mv2NormSquaredInv;
                tempScalar[25] += (-2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar123 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector0.Scalar * mv1.KVector3.Scalar235 * mv2.KVector4.Scalar1234) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector2.IsZero())
            {
                tempScalar[7] += (-2 * mv2.KVector2.Scalar12 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar12 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar23 * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar35 * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar34 * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar25 * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar35 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar15 + 2 * mv2.KVector2.Scalar15 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar45 * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar45) * mv2NormSquaredInv;
                tempScalar[11] += (-2 * mv2.KVector2.Scalar12 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar12 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar23 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar15 + 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar24 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar34 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar25 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar35 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar35) * mv2NormSquaredInv;
                tempScalar[13] += (2 * mv2.KVector2.Scalar12 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar12 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar23 * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar34 * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar24 * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar15 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar15 + mv2.KVector2.Scalar25 * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar35 * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar45 * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar45) * mv2NormSquaredInv;
                tempScalar[14] += (-mv2.KVector2.Scalar23 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar23 + mv2.KVector2.Scalar45 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar35 - mv2.KVector2.Scalar34 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar24 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar25 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar35 - mv2.KVector2.Scalar35 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar35) * mv2NormSquaredInv;
                tempScalar[19] += (-2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar23 * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar25 * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar24 * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar15 - mv2.KVector2.Scalar35 * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar35 - mv2.KVector2.Scalar45 * mv1.KVector3.Scalar125 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar35) * mv2NormSquaredInv;
                tempScalar[21] += (-mv2.KVector2.Scalar45 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar12 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar23 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar35 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar35 * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar14 - 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar34 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar15 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar25 * mv1.KVector3.Scalar135 * mv2.KVector2.Scalar25) * mv2NormSquaredInv;
                tempScalar[22] += (-mv2.KVector2.Scalar23 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar23 + mv2.KVector2.Scalar25 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar45 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar24 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar35 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar35 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar45) * mv2NormSquaredInv;
                tempScalar[25] += (2 * mv2.KVector2.Scalar12 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar12 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar15 + mv2.KVector2.Scalar23 * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar15 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar124 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar24 * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar35 * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar15 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar134 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar34 * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar25 * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar45 * mv1.KVector3.Scalar145 * mv2.KVector2.Scalar45) * mv2NormSquaredInv;
                tempScalar[26] += (-mv2.KVector2.Scalar24 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar45 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar34 + mv2.KVector2.Scalar35 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar23 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar23 + mv2.KVector2.Scalar25 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar34 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar234 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar35) * mv2NormSquaredInv;
                tempScalar[28] += (mv2.KVector2.Scalar24 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar23 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar34 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar25 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar35 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar235 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar45 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar45) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector2.IsZero() && !mv2.KVector4.IsZero())
            {
                tempScalar[7] += (-2 * mv2.KVector2.Scalar12 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar345 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar235 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar35 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar1345 + 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar135 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar124 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[11] += (2 * mv2.KVector2.Scalar45 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar1345 + 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar235 * mv2.KVector4.Scalar1245 - 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar1345) * mv2NormSquaredInv;
                tempScalar[13] += (2 * mv2.KVector2.Scalar45 * mv1.KVector3.Scalar124 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar135 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar345 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar35 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar1345) * mv2NormSquaredInv;
                tempScalar[14] += (2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[19] += (-2 * mv2.KVector2.Scalar12 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar124 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar1234 + 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar45 * mv1.KVector3.Scalar135 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar35 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar1345) * mv2NormSquaredInv;
                tempScalar[21] += (-2 * mv2.KVector2.Scalar13 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar1345 - 2 * mv2.KVector2.Scalar45 * mv1.KVector3.Scalar235 * mv2.KVector4.Scalar1245 + 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar15 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar1345) * mv2NormSquaredInv;
                tempScalar[22] += (-2 * mv2.KVector2.Scalar23 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[25] += (-2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar1234 - 2 * mv2.KVector2.Scalar14 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar1345 - 2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar124 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar135 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar25 * mv1.KVector3.Scalar345 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar35 * mv1.KVector3.Scalar235 * mv2.KVector4.Scalar1245) * mv2NormSquaredInv;
                tempScalar[26] += (-2 * mv2.KVector2.Scalar24 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[28] += (-2 * mv2.KVector2.Scalar34 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar45 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector4.IsZero() && !mv2.KVector2.IsZero())
            {
                tempScalar[7] += (-2 * mv2.KVector4.Scalar1234 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar25) * mv2NormSquaredInv;
                tempScalar[13] += (2 * mv2.KVector4.Scalar1234 * mv1.KVector3.Scalar245 * mv2.KVector2.Scalar45) * mv2NormSquaredInv;
                tempScalar[19] += (-2 * mv2.KVector4.Scalar1235 * mv1.KVector3.Scalar345 * mv2.KVector2.Scalar45) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector4.IsZero())
            {
                tempScalar[7] += (2 * mv2.KVector4.Scalar1234 * mv1.KVector3.Scalar235 * mv2.KVector4.Scalar2345 + mv2.KVector4.Scalar2345 * mv1.KVector3.Scalar123 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector4.Scalar1235 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[11] += (mv2.KVector4.Scalar2345 * mv1.KVector3.Scalar124 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector4.Scalar1245 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1234 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[13] += (mv2.KVector4.Scalar2345 * mv1.KVector3.Scalar134 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1234 * mv1.KVector3.Scalar345 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector4.Scalar1345 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[14] += (-mv2.KVector4.Scalar2345 * mv1.KVector3.Scalar234 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[19] += (mv2.KVector4.Scalar2345 * mv1.KVector3.Scalar125 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1235 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector4.Scalar1245 * mv1.KVector3.Scalar235 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[21] += (-2 * mv2.KVector4.Scalar1345 * mv1.KVector3.Scalar235 * mv2.KVector4.Scalar2345 + mv2.KVector4.Scalar2345 * mv1.KVector3.Scalar135 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1235 * mv1.KVector3.Scalar345 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[22] += (-mv2.KVector4.Scalar2345 * mv1.KVector3.Scalar235 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[25] += (-2 * mv2.KVector4.Scalar1345 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar2345 + mv2.KVector4.Scalar2345 * mv1.KVector3.Scalar145 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1245 * mv1.KVector3.Scalar345 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[26] += (-mv2.KVector4.Scalar2345 * mv1.KVector3.Scalar245 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[28] += (-mv2.KVector4.Scalar2345 * mv1.KVector3.Scalar345 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
            }
            
        }
        
        if (!mv1.KVector4.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar[15] += (mv2.KVector0.Scalar * mv1.KVector4.Scalar1234 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[23] += (mv2.KVector0.Scalar * mv1.KVector4.Scalar1235 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[27] += (mv2.KVector0.Scalar * mv1.KVector4.Scalar1245 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[29] += (mv2.KVector0.Scalar * mv1.KVector4.Scalar1345 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
                tempScalar[30] += (mv2.KVector0.Scalar * mv1.KVector4.Scalar2345 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector0.IsZero() && !mv2.KVector2.IsZero())
            {
                tempScalar[15] += (2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar45 - 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar35 + 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar25 - 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar15) * mv2NormSquaredInv;
                tempScalar[23] += (-2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar45 + 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar34 - 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar24 + 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar14) * mv2NormSquaredInv;
                tempScalar[27] += (2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar35 - 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar34 + 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar23 - 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar13) * mv2NormSquaredInv;
                tempScalar[29] += (-2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar25 + 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar24 - 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar12) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector2.IsZero())
            {
                tempScalar[15] += (-mv2.KVector2.Scalar23 * mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar23 * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar35 + mv2.KVector2.Scalar24 * mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar25 * mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar45 * mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar45 + 2 * mv2.KVector2.Scalar24 * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar25 + 2 * mv2.KVector2.Scalar24 * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar34 * mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar35 * mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar35 - 2 * mv2.KVector2.Scalar34 * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar35) * mv2NormSquaredInv;
                tempScalar[23] += (-2 * mv2.KVector2.Scalar12 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar24 + 2 * mv2.KVector2.Scalar13 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar23 * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar24 * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar23 * mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar34 * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar15 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar25 * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar35 * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar35 - mv2.KVector2.Scalar45 * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar45 - 2 * mv2.KVector2.Scalar35 * mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar45) * mv2NormSquaredInv;
                tempScalar[27] += (2 * mv2.KVector2.Scalar23 * mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar23 * mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar23 + mv2.KVector2.Scalar25 * mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar24 * mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar34 * mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar24 * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar34 - 2 * mv2.KVector2.Scalar34 * mv1.KVector4.Scalar1234 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar45 * mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar35 * mv1.KVector4.Scalar1245 * mv2.KVector2.Scalar35 + 2 * mv2.KVector2.Scalar25 * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar35) * mv2NormSquaredInv;
                tempScalar[29] += (-2 * mv2.KVector2.Scalar13 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar23 * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar23 * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar34 * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar34 + 2 * mv2.KVector2.Scalar14 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar24 * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar24 - 2 * mv2.KVector2.Scalar15 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar25 - 2 * mv2.KVector2.Scalar25 * mv1.KVector4.Scalar1235 * mv2.KVector2.Scalar45 - mv2.KVector2.Scalar25 * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar45 * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar35 * mv1.KVector4.Scalar1345 * mv2.KVector2.Scalar35) * mv2NormSquaredInv;
                tempScalar[30] += (-mv2.KVector2.Scalar23 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar25 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar25 - mv2.KVector2.Scalar34 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar45 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar24 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar24 + mv2.KVector2.Scalar35 * mv1.KVector4.Scalar2345 * mv2.KVector2.Scalar35) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector2.IsZero() && !mv2.KVector4.IsZero())
            {
                tempScalar[15] += (-2 * mv2.KVector2.Scalar23 * mv1.KVector4.Scalar2345 * mv2.KVector4.Scalar1235 + 2 * mv2.KVector2.Scalar24 * mv1.KVector4.Scalar1245 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar34 * mv1.KVector4.Scalar2345 * mv2.KVector4.Scalar1345) * mv2NormSquaredInv;
                tempScalar[23] += (-2 * mv2.KVector2.Scalar23 * mv1.KVector4.Scalar1234 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector2.Scalar25 * mv1.KVector4.Scalar1245 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar35 * mv1.KVector4.Scalar2345 * mv2.KVector4.Scalar1345) * mv2NormSquaredInv;
                tempScalar[27] += (-2 * mv2.KVector2.Scalar24 * mv1.KVector4.Scalar1234 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar45 * mv1.KVector4.Scalar2345 * mv2.KVector4.Scalar1345 + 2 * mv2.KVector2.Scalar25 * mv1.KVector4.Scalar2345 * mv2.KVector4.Scalar1235) * mv2NormSquaredInv;
                tempScalar[29] += (2 * mv2.KVector2.Scalar35 * mv1.KVector4.Scalar2345 * mv2.KVector4.Scalar1235 - 2 * mv2.KVector2.Scalar45 * mv1.KVector4.Scalar1245 * mv2.KVector4.Scalar2345 - 2 * mv2.KVector2.Scalar34 * mv1.KVector4.Scalar1234 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector4.IsZero())
            {
                tempScalar[15] += (-mv2.KVector4.Scalar2345 * mv1.KVector4.Scalar1234 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1234 * mv1.KVector4.Scalar2345 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[23] += (2 * mv2.KVector4.Scalar1235 * mv1.KVector4.Scalar2345 * mv2.KVector4.Scalar2345 - mv2.KVector4.Scalar2345 * mv1.KVector4.Scalar1235 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[27] += (2 * mv2.KVector4.Scalar1245 * mv1.KVector4.Scalar2345 * mv2.KVector4.Scalar2345 - mv2.KVector4.Scalar2345 * mv1.KVector4.Scalar1245 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[29] += (-mv2.KVector4.Scalar2345 * mv1.KVector4.Scalar1345 * mv2.KVector4.Scalar2345 + 2 * mv2.KVector4.Scalar1345 * mv1.KVector4.Scalar2345 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
                tempScalar[30] += (mv2.KVector4.Scalar2345 * mv1.KVector4.Scalar2345 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
            }
            
        }
        
        if (!mv1.KVector5.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar[31] += (mv2.KVector0.Scalar * mv1.KVector5.Scalar12345 * mv2.KVector0.Scalar) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector2.IsZero())
            {
                tempScalar[31] += (-mv2.KVector2.Scalar23 * mv1.KVector5.Scalar12345 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar45 * mv1.KVector5.Scalar12345 * mv2.KVector2.Scalar45 + mv2.KVector2.Scalar24 * mv1.KVector5.Scalar12345 * mv2.KVector2.Scalar24 - mv2.KVector2.Scalar34 * mv1.KVector5.Scalar12345 * mv2.KVector2.Scalar34 - mv2.KVector2.Scalar25 * mv1.KVector5.Scalar12345 * mv2.KVector2.Scalar25 + mv2.KVector2.Scalar35 * mv1.KVector5.Scalar12345 * mv2.KVector2.Scalar35) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector4.IsZero())
            {
                tempScalar[31] += (mv2.KVector4.Scalar2345 * mv1.KVector5.Scalar12345 * mv2.KVector4.Scalar2345) * mv2NormSquaredInv;
            }
            
        }
        
        return Ga401Multivector.Create(tempScalar);
    }
    
    public static Ga401Multivector MapUsingOddVersor(this Ga401Multivector mv1, Ga401Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga401Multivector.Zero;
        
        var mv2NormSquaredInv = 1d / mv2.NormSquared();
        
        var tempScalar = new double[32];
        
        if (!mv1.KVector0.IsZero())
        {
            if (!mv2.KVector1.IsZero())
            {
                tempScalar[0] += (mv2.KVector1.Scalar2 * mv1.KVector0.Scalar * mv2.KVector1.Scalar2 + mv2.KVector1.Scalar3 * mv1.KVector0.Scalar * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar4 * mv1.KVector0.Scalar * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar5 * mv1.KVector0.Scalar * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector3.IsZero())
            {
                tempScalar[0] += (mv2.KVector3.Scalar245 * mv1.KVector0.Scalar * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar235 * mv1.KVector0.Scalar * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar345 * mv1.KVector0.Scalar * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar234 * mv1.KVector0.Scalar * mv2.KVector3.Scalar234) * mv2NormSquaredInv;
            }
            
        }
        
        if (!mv1.KVector1.IsZero())
        {
            if (!mv2.KVector1.IsZero())
            {
                tempScalar[1] += (-2 * mv2.KVector1.Scalar1 * mv1.KVector1.Scalar2 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar1 * mv1.KVector1.Scalar3 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar1 * mv1.KVector1.Scalar4 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar1 * mv1.KVector1.Scalar5 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar2 * mv1.KVector1.Scalar1 * mv2.KVector1.Scalar2 + mv2.KVector1.Scalar3 * mv1.KVector1.Scalar1 * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar4 * mv1.KVector1.Scalar1 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar5 * mv1.KVector1.Scalar1 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[2] += (-mv2.KVector1.Scalar2 * mv1.KVector1.Scalar2 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar2 * mv1.KVector1.Scalar3 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar2 * mv1.KVector1.Scalar4 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar2 * mv1.KVector1.Scalar5 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar3 * mv1.KVector1.Scalar2 * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar4 * mv1.KVector1.Scalar2 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar5 * mv1.KVector1.Scalar2 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[4] += (-2 * mv2.KVector1.Scalar2 * mv1.KVector1.Scalar2 * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar2 * mv1.KVector1.Scalar3 * mv2.KVector1.Scalar2 - mv2.KVector1.Scalar3 * mv1.KVector1.Scalar3 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar3 * mv1.KVector1.Scalar4 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar3 * mv1.KVector1.Scalar5 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar4 * mv1.KVector1.Scalar3 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar5 * mv1.KVector1.Scalar3 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[8] += (-2 * mv2.KVector1.Scalar2 * mv1.KVector1.Scalar2 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar2 * mv1.KVector1.Scalar4 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar3 * mv1.KVector1.Scalar3 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar3 * mv1.KVector1.Scalar4 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.KVector1.Scalar4 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.KVector1.Scalar5 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar5 * mv1.KVector1.Scalar4 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[16] += (-2 * mv2.KVector1.Scalar2 * mv1.KVector1.Scalar2 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar2 * mv1.KVector1.Scalar5 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar3 * mv1.KVector1.Scalar3 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar3 * mv1.KVector1.Scalar5 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar4 * mv1.KVector1.Scalar4 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar4 * mv1.KVector1.Scalar5 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.KVector1.Scalar5 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector1.IsZero() && !mv2.KVector3.IsZero())
            {
                tempScalar[1] += (2 * mv2.KVector1.Scalar3 * mv1.KVector1.Scalar2 * mv2.KVector3.Scalar123 + 2 * mv2.KVector1.Scalar4 * mv1.KVector1.Scalar2 * mv2.KVector3.Scalar124 + 2 * mv2.KVector1.Scalar4 * mv1.KVector1.Scalar3 * mv2.KVector3.Scalar134 + 2 * mv2.KVector1.Scalar5 * mv1.KVector1.Scalar2 * mv2.KVector3.Scalar125 + 2 * mv2.KVector1.Scalar5 * mv1.KVector1.Scalar3 * mv2.KVector3.Scalar135 + 2 * mv2.KVector1.Scalar5 * mv1.KVector1.Scalar4 * mv2.KVector3.Scalar145) * mv2NormSquaredInv;
                tempScalar[2] += (2 * mv2.KVector1.Scalar4 * mv1.KVector1.Scalar3 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar5 * mv1.KVector1.Scalar3 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar5 * mv1.KVector1.Scalar4 * mv2.KVector3.Scalar245) * mv2NormSquaredInv;
                tempScalar[4] += (-2 * mv2.KVector1.Scalar4 * mv1.KVector1.Scalar2 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar5 * mv1.KVector1.Scalar2 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar5 * mv1.KVector1.Scalar4 * mv2.KVector3.Scalar345) * mv2NormSquaredInv;
                tempScalar[8] += (2 * mv2.KVector1.Scalar3 * mv1.KVector1.Scalar2 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar5 * mv1.KVector1.Scalar2 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar5 * mv1.KVector1.Scalar3 * mv2.KVector3.Scalar345) * mv2NormSquaredInv;
                tempScalar[16] += (2 * mv2.KVector1.Scalar3 * mv1.KVector1.Scalar2 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar4 * mv1.KVector1.Scalar2 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar4 * mv1.KVector1.Scalar3 * mv2.KVector3.Scalar345) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector3.IsZero())
            {
                tempScalar[1] += (mv2.KVector3.Scalar245 * mv1.KVector1.Scalar1 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar235 * mv1.KVector1.Scalar1 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar123 * mv1.KVector1.Scalar4 * mv2.KVector3.Scalar234 + 2 * mv2.KVector3.Scalar123 * mv1.KVector1.Scalar5 * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar345 * mv1.KVector1.Scalar1 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar135 * mv1.KVector1.Scalar2 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar124 * mv1.KVector1.Scalar3 * mv2.KVector3.Scalar234 + 2 * mv2.KVector3.Scalar124 * mv1.KVector1.Scalar5 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar134 * mv1.KVector1.Scalar2 * mv2.KVector3.Scalar234 + 2 * mv2.KVector3.Scalar134 * mv1.KVector1.Scalar5 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar234 * mv1.KVector1.Scalar1 * mv2.KVector3.Scalar234 + 2 * mv2.KVector3.Scalar125 * mv1.KVector1.Scalar3 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar125 * mv1.KVector1.Scalar4 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar135 * mv1.KVector1.Scalar4 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar145 * mv1.KVector1.Scalar2 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar145 * mv1.KVector1.Scalar3 * mv2.KVector3.Scalar345) * mv2NormSquaredInv;
                tempScalar[2] += (mv2.KVector3.Scalar345 * mv1.KVector1.Scalar2 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar235 * mv1.KVector1.Scalar2 * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar245 * mv1.KVector1.Scalar2 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar234 * mv1.KVector1.Scalar2 * mv2.KVector3.Scalar234 + 2 * mv2.KVector3.Scalar245 * mv1.KVector1.Scalar3 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar234 * mv1.KVector1.Scalar5 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar235 * mv1.KVector1.Scalar4 * mv2.KVector3.Scalar345) * mv2NormSquaredInv;
                tempScalar[4] += (-mv2.KVector3.Scalar234 * mv1.KVector1.Scalar3 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar235 * mv1.KVector1.Scalar3 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar234 * mv1.KVector1.Scalar5 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar345 * mv1.KVector1.Scalar3 * mv2.KVector3.Scalar345 - mv2.KVector3.Scalar245 * mv1.KVector1.Scalar3 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar235 * mv1.KVector1.Scalar4 * mv2.KVector3.Scalar245) * mv2NormSquaredInv;
                tempScalar[8] += (mv2.KVector3.Scalar235 * mv1.KVector1.Scalar4 * mv2.KVector3.Scalar235 - mv2.KVector3.Scalar245 * mv1.KVector1.Scalar4 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar234 * mv1.KVector1.Scalar4 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar345 * mv1.KVector1.Scalar4 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar234 * mv1.KVector1.Scalar5 * mv2.KVector3.Scalar235) * mv2NormSquaredInv;
                tempScalar[16] += (mv2.KVector3.Scalar235 * mv1.KVector1.Scalar5 * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar245 * mv1.KVector1.Scalar5 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar345 * mv1.KVector1.Scalar5 * mv2.KVector3.Scalar345 - mv2.KVector3.Scalar234 * mv1.KVector1.Scalar5 * mv2.KVector3.Scalar234) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector3.IsZero() && !mv2.KVector5.IsZero())
            {
                tempScalar[1] += (2 * mv2.KVector3.Scalar345 * mv1.KVector1.Scalar2 * mv2.KVector5.Scalar12345 + 2 * mv2.KVector3.Scalar235 * mv1.KVector1.Scalar4 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
            }
            
        }
        
        if (!mv1.KVector2.IsZero())
        {
            if (!mv2.KVector1.IsZero())
            {
                tempScalar[3] += (2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar23 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar24 * mv2.KVector1.Scalar4 + 2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar25 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar2 * mv1.KVector2.Scalar12 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar13 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar14 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar15 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar3 * mv1.KVector2.Scalar12 * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar4 * mv1.KVector2.Scalar12 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar5 * mv1.KVector2.Scalar12 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[5] += (-2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar23 * mv2.KVector1.Scalar2 + 2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar34 * mv2.KVector1.Scalar4 + 2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar35 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar12 * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar2 * mv1.KVector2.Scalar13 * mv2.KVector1.Scalar2 - mv2.KVector1.Scalar3 * mv1.KVector2.Scalar13 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar14 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar15 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar4 * mv1.KVector2.Scalar13 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar5 * mv1.KVector2.Scalar13 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[6] += (-mv2.KVector1.Scalar2 * mv1.KVector2.Scalar23 * mv2.KVector1.Scalar2 + 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar34 * mv2.KVector1.Scalar4 + 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar35 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar3 * mv1.KVector2.Scalar23 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar24 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar25 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar4 * mv1.KVector2.Scalar23 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar5 * mv1.KVector2.Scalar23 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[9] += (-2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar24 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar34 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar45 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar12 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar2 * mv1.KVector2.Scalar14 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar13 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar3 * mv1.KVector2.Scalar14 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.KVector2.Scalar14 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar15 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar5 * mv1.KVector2.Scalar14 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[10] += (-mv2.KVector1.Scalar2 * mv1.KVector2.Scalar24 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar34 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar45 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar23 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar3 * mv1.KVector2.Scalar24 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.KVector2.Scalar24 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar25 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar5 * mv1.KVector2.Scalar24 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[12] += (2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar23 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar24 * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar2 * mv1.KVector2.Scalar34 * mv2.KVector1.Scalar2 - mv2.KVector1.Scalar3 * mv1.KVector2.Scalar34 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar45 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar4 * mv1.KVector2.Scalar34 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar35 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar5 * mv1.KVector2.Scalar34 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[17] += (-2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar25 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar35 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar45 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar12 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar2 * mv1.KVector2.Scalar15 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar13 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar3 * mv1.KVector2.Scalar15 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar14 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar4 * mv1.KVector2.Scalar15 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.KVector2.Scalar15 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[18] += (-mv2.KVector1.Scalar2 * mv1.KVector2.Scalar25 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar35 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar45 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar23 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar3 * mv1.KVector2.Scalar25 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar5 * mv1.KVector2.Scalar25 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar24 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar4 * mv1.KVector2.Scalar25 * mv2.KVector1.Scalar4) * mv2NormSquaredInv;
                tempScalar[20] += (2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar23 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar25 * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar2 * mv1.KVector2.Scalar35 * mv2.KVector1.Scalar2 - mv2.KVector1.Scalar3 * mv1.KVector2.Scalar35 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar45 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar34 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar4 * mv1.KVector2.Scalar35 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.KVector2.Scalar35 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[24] += (2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar24 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar25 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar2 * mv1.KVector2.Scalar45 * mv2.KVector1.Scalar2 + 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar34 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar35 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar3 * mv1.KVector2.Scalar45 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.KVector2.Scalar45 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.KVector2.Scalar45 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector1.IsZero() && !mv2.KVector3.IsZero())
            {
                tempScalar[3] += (2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar123 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar124 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar134 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar25 * mv2.KVector3.Scalar125 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar135 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar145 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar124 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar125 + 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar13 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar134 - 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar125 + 2 * mv2.KVector1.Scalar5 * mv1.KVector2.Scalar13 * mv2.KVector3.Scalar235 - 2 * mv2.KVector1.Scalar5 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar135 + 2 * mv2.KVector1.Scalar5 * mv1.KVector2.Scalar14 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar5 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar145) * mv2NormSquaredInv;
                tempScalar[5] += (-2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar25 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar134 + 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar124 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar25 * mv2.KVector3.Scalar135 + 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar125 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar134 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar135 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar145 - 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar12 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar124 - 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar135 - 2 * mv2.KVector1.Scalar5 * mv1.KVector2.Scalar12 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar5 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar125 + 2 * mv2.KVector1.Scalar5 * mv1.KVector2.Scalar14 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar5 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar145) * mv2NormSquaredInv;
                tempScalar[6] += (-2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar25 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar235 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar5 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar5 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar245) * mv2NormSquaredInv;
                tempScalar[9] += (2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar25 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar134 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar123 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar25 * mv2.KVector3.Scalar145 + 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar125 + 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar12 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar145 + 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar135 - 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar145 - 2 * mv2.KVector1.Scalar5 * mv1.KVector2.Scalar12 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar5 * mv1.KVector2.Scalar13 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar5 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar125 + 2 * mv2.KVector1.Scalar5 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar135) * mv2NormSquaredInv;
                tempScalar[10] += (2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar25 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar235 - 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar5 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar5 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar235) * mv2NormSquaredInv;
                tempScalar[12] += (-2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar25 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar235 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar5 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar5 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar235) * mv2NormSquaredInv;
                tempScalar[17] += (2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar1 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar135 + 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar145 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar123 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar124 + 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar12 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar145 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar134 + 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar12 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar13 * mv2.KVector3.Scalar345) * mv2NormSquaredInv;
                tempScalar[18] += (2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar345) * mv2NormSquaredInv;
                tempScalar[20] += (2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar245) * mv2NormSquaredInv;
                tempScalar[24] += (-2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar235 - 2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar235) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector1.IsZero() && !mv2.KVector5.IsZero())
            {
                tempScalar[3] += (-2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar45 * mv2.KVector5.Scalar12345 + 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar35 * mv2.KVector5.Scalar12345 - 2 * mv2.KVector1.Scalar5 * mv1.KVector2.Scalar34 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
                tempScalar[5] += (2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar45 * mv2.KVector5.Scalar12345 - 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar25 * mv2.KVector5.Scalar12345 + 2 * mv2.KVector1.Scalar5 * mv1.KVector2.Scalar24 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
                tempScalar[9] += (-2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar35 * mv2.KVector5.Scalar12345 + 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar25 * mv2.KVector5.Scalar12345 - 2 * mv2.KVector1.Scalar5 * mv1.KVector2.Scalar23 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
                tempScalar[17] += (2 * mv2.KVector1.Scalar2 * mv1.KVector2.Scalar34 * mv2.KVector5.Scalar12345 - 2 * mv2.KVector1.Scalar3 * mv1.KVector2.Scalar24 * mv2.KVector5.Scalar12345 + 2 * mv2.KVector1.Scalar4 * mv1.KVector2.Scalar23 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector3.IsZero() && !mv2.KVector1.IsZero())
            {
                tempScalar[9] += (-2 * mv2.KVector3.Scalar123 * mv1.KVector2.Scalar23 * mv2.KVector1.Scalar4) * mv2NormSquaredInv;
                tempScalar[17] += (-2 * mv2.KVector3.Scalar123 * mv1.KVector2.Scalar23 * mv2.KVector1.Scalar5 - 2 * mv2.KVector3.Scalar124 * mv1.KVector2.Scalar24 * mv2.KVector1.Scalar5 - 2 * mv2.KVector3.Scalar134 * mv1.KVector2.Scalar34 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[18] += (-2 * mv2.KVector3.Scalar234 * mv1.KVector2.Scalar34 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[20] += (2 * mv2.KVector3.Scalar234 * mv1.KVector2.Scalar24 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[24] += (-2 * mv2.KVector3.Scalar234 * mv1.KVector2.Scalar23 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector3.IsZero())
            {
                tempScalar[3] += (mv2.KVector3.Scalar345 * mv1.KVector2.Scalar12 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar245 * mv1.KVector2.Scalar12 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar234 * mv1.KVector2.Scalar12 * mv2.KVector3.Scalar234 + 2 * mv2.KVector3.Scalar245 * mv1.KVector2.Scalar13 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar234 * mv1.KVector2.Scalar15 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar235 * mv1.KVector2.Scalar12 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar235 * mv1.KVector2.Scalar14 * mv2.KVector3.Scalar345) * mv2NormSquaredInv;
                tempScalar[5] += (-mv2.KVector3.Scalar234 * mv1.KVector2.Scalar13 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar235 * mv1.KVector2.Scalar13 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar145 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar235 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar145 - 2 * mv2.KVector3.Scalar135 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar124 * mv1.KVector2.Scalar25 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar134 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar234 - 2 * mv2.KVector3.Scalar134 * mv1.KVector2.Scalar25 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar345 * mv1.KVector2.Scalar13 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar234 * mv1.KVector2.Scalar15 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar234 * mv1.KVector2.Scalar25 * mv2.KVector3.Scalar145 + 2 * mv2.KVector3.Scalar125 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar135 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar245 * mv1.KVector2.Scalar13 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar235 * mv1.KVector2.Scalar14 * mv2.KVector3.Scalar245) * mv2NormSquaredInv;
                tempScalar[6] += (-mv2.KVector3.Scalar234 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar235 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar235 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar345 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar234 * mv1.KVector2.Scalar25 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar245 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar245) * mv2NormSquaredInv;
                tempScalar[9] += (-2 * mv2.KVector3.Scalar145 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar235 * mv1.KVector2.Scalar14 * mv2.KVector3.Scalar235 - mv2.KVector3.Scalar245 * mv1.KVector2.Scalar14 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar234 * mv1.KVector2.Scalar14 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar345 * mv1.KVector2.Scalar14 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar124 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar234 + 2 * mv2.KVector3.Scalar134 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar234 - 2 * mv2.KVector3.Scalar123 * mv1.KVector2.Scalar25 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar123 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar124 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar134 * mv1.KVector2.Scalar25 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar135 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar125 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar234 * mv1.KVector2.Scalar15 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar234 * mv1.KVector2.Scalar25 * mv2.KVector3.Scalar135 + 2 * mv2.KVector3.Scalar234 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar125 - 2 * mv2.KVector3.Scalar145 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar245) * mv2NormSquaredInv;
                tempScalar[10] += (mv2.KVector3.Scalar234 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar245 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar345 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar235 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar234 * mv1.KVector2.Scalar25 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar245 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar345) * mv2NormSquaredInv;
                tempScalar[12] += (-mv2.KVector3.Scalar234 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar234 + mv2.KVector3.Scalar245 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar345 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar345 - mv2.KVector3.Scalar235 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar234 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar235 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar345) * mv2NormSquaredInv;
                tempScalar[17] += (mv2.KVector3.Scalar235 * mv1.KVector2.Scalar15 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar135 * mv1.KVector2.Scalar25 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar123 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar234 + mv2.KVector3.Scalar245 * mv1.KVector2.Scalar15 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar345 * mv1.KVector2.Scalar15 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar125 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar145 * mv1.KVector2.Scalar25 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar124 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar234 - 2 * mv2.KVector3.Scalar134 * mv1.KVector2.Scalar25 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar234 * mv1.KVector2.Scalar15 * mv2.KVector3.Scalar234 + 2 * mv2.KVector3.Scalar145 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar125 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar135 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar345) * mv2NormSquaredInv;
                tempScalar[18] += (mv2.KVector3.Scalar235 * mv1.KVector2.Scalar25 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar235 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar345 - mv2.KVector3.Scalar234 * mv1.KVector2.Scalar25 * mv2.KVector3.Scalar234 + mv2.KVector3.Scalar345 * mv1.KVector2.Scalar25 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar245 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar245 * mv1.KVector2.Scalar25 * mv2.KVector3.Scalar245) * mv2NormSquaredInv;
                tempScalar[20] += (-mv2.KVector3.Scalar235 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar234 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar245 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar235 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar234 * mv1.KVector2.Scalar23 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar345 * mv1.KVector2.Scalar35 * mv2.KVector3.Scalar345) * mv2NormSquaredInv;
                tempScalar[24] += (-mv2.KVector3.Scalar245 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar235 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar234 * mv1.KVector2.Scalar24 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar234 * mv1.KVector2.Scalar34 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar234 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar345 * mv1.KVector2.Scalar45 * mv2.KVector3.Scalar345) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector3.IsZero() && !mv2.KVector5.IsZero())
            {
                tempScalar[3] += (2 * mv2.KVector3.Scalar235 * mv1.KVector2.Scalar24 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
                tempScalar[5] += (-2 * mv2.KVector3.Scalar234 * mv1.KVector2.Scalar35 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
                tempScalar[9] += (-2 * mv2.KVector3.Scalar345 * mv1.KVector2.Scalar24 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
                tempScalar[17] += (2 * mv2.KVector3.Scalar245 * mv1.KVector2.Scalar35 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
            }
            
        }
        
        if (!mv1.KVector3.IsZero())
        {
            if (!mv2.KVector1.IsZero())
            {
                tempScalar[7] += (-2 * mv2.KVector1.Scalar1 * mv1.KVector3.Scalar234 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar1 * mv1.KVector3.Scalar235 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar2 * mv1.KVector3.Scalar123 * mv2.KVector1.Scalar2 + 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar134 * mv2.KVector1.Scalar4 + 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar135 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar3 * mv1.KVector3.Scalar123 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar124 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar125 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar4 * mv1.KVector3.Scalar123 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar5 * mv1.KVector3.Scalar123 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[11] += (2 * mv2.KVector1.Scalar1 * mv1.KVector3.Scalar234 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar1 * mv1.KVector3.Scalar245 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar2 * mv1.KVector3.Scalar124 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar134 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar145 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar123 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar3 * mv1.KVector3.Scalar124 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.KVector3.Scalar124 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar125 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar5 * mv1.KVector3.Scalar124 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[13] += (-2 * mv2.KVector1.Scalar1 * mv1.KVector3.Scalar234 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar1 * mv1.KVector3.Scalar345 * mv2.KVector1.Scalar5 + 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar123 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar124 * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar2 * mv1.KVector3.Scalar134 * mv2.KVector1.Scalar2 - mv2.KVector1.Scalar3 * mv1.KVector3.Scalar134 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar145 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar4 * mv1.KVector3.Scalar134 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar135 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar5 * mv1.KVector3.Scalar134 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[14] += (-mv2.KVector1.Scalar2 * mv1.KVector3.Scalar234 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar345 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar3 * mv1.KVector3.Scalar234 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar245 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar4 * mv1.KVector3.Scalar234 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar235 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar5 * mv1.KVector3.Scalar234 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[19] += (2 * mv2.KVector1.Scalar1 * mv1.KVector3.Scalar235 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar1 * mv1.KVector3.Scalar245 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar2 * mv1.KVector3.Scalar125 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar135 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar145 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar123 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar3 * mv1.KVector3.Scalar125 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar5 * mv1.KVector3.Scalar125 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar124 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar4 * mv1.KVector3.Scalar125 * mv2.KVector1.Scalar4) * mv2NormSquaredInv;
                tempScalar[21] += (-2 * mv2.KVector1.Scalar1 * mv1.KVector3.Scalar235 * mv2.KVector1.Scalar2 + 2 * mv2.KVector1.Scalar1 * mv1.KVector3.Scalar345 * mv2.KVector1.Scalar4 + 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar123 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar125 * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar2 * mv1.KVector3.Scalar135 * mv2.KVector1.Scalar2 - mv2.KVector1.Scalar3 * mv1.KVector3.Scalar135 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar145 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar134 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar4 * mv1.KVector3.Scalar135 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.KVector3.Scalar135 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[22] += (-mv2.KVector1.Scalar2 * mv1.KVector3.Scalar235 * mv2.KVector1.Scalar2 + mv2.KVector1.Scalar4 * mv1.KVector3.Scalar235 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.KVector3.Scalar235 * mv2.KVector1.Scalar5 + 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar345 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar3 * mv1.KVector3.Scalar235 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar245 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar234 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[25] += (-2 * mv2.KVector1.Scalar1 * mv1.KVector3.Scalar245 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar1 * mv1.KVector3.Scalar345 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar124 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar125 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar2 * mv1.KVector3.Scalar145 * mv2.KVector1.Scalar2 + 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar134 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar135 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar3 * mv1.KVector3.Scalar145 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.KVector3.Scalar145 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.KVector3.Scalar145 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[26] += (-mv2.KVector1.Scalar2 * mv1.KVector3.Scalar245 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar345 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar234 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar235 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar3 * mv1.KVector3.Scalar245 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.KVector3.Scalar245 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.KVector3.Scalar245 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[28] += (-2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar234 * mv2.KVector1.Scalar5 + 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar235 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar245 * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar2 * mv1.KVector3.Scalar345 * mv2.KVector1.Scalar2 - mv2.KVector1.Scalar5 * mv1.KVector3.Scalar345 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar3 * mv1.KVector3.Scalar345 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.KVector3.Scalar345 * mv2.KVector1.Scalar4) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector1.IsZero() && !mv2.KVector3.IsZero())
            {
                tempScalar[7] += (-2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar124 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar125 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar145 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar134 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar134 - 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar135 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar235 * mv2.KVector3.Scalar135 - 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar145 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar145 - 2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar145 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar135 - 2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar345 * mv2.KVector3.Scalar125 + 2 * mv2.KVector1.Scalar5 * mv1.KVector3.Scalar124 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar5 * mv1.KVector3.Scalar134 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar5 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar145) * mv2NormSquaredInv;
                tempScalar[11] += (2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar123 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar125 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar135 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar135 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar235 * mv2.KVector3.Scalar145 + 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar145 * mv2.KVector3.Scalar235 - 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar135 - 2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar145 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar145 - 2 * mv2.KVector1.Scalar5 * mv1.KVector3.Scalar123 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar5 * mv1.KVector3.Scalar134 * mv2.KVector3.Scalar235 - 2 * mv2.KVector1.Scalar5 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar135) * mv2NormSquaredInv;
                tempScalar[13] += (-2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar125 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar135 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar145 * mv2.KVector3.Scalar235 - 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar123 - 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar135 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar125 - 2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar145 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar345 * mv2.KVector3.Scalar145 + 2 * mv2.KVector1.Scalar5 * mv1.KVector3.Scalar123 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar5 * mv1.KVector3.Scalar124 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar5 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar125) * mv2NormSquaredInv;
                tempScalar[14] += (-2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar235 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar345 * mv2.KVector3.Scalar245) * mv2NormSquaredInv;
                tempScalar[19] += (2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar123 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar124 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar134 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar134 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar145 - 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar145 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar134 + 2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar123 * mv2.KVector3.Scalar345) * mv2NormSquaredInv;
                tempScalar[21] += (2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar124 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar134 * mv2.KVector3.Scalar245 + 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar145 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar134 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar235 * mv2.KVector3.Scalar123 - 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar124 - 2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar123 * mv2.KVector3.Scalar245) * mv2NormSquaredInv;
                tempScalar[22] += (2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar345) * mv2NormSquaredInv;
                tempScalar[25] += (-2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar123 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar134 * mv2.KVector3.Scalar235 - 2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar135 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar125 - 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar235 * mv2.KVector3.Scalar124 + 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar123 + 2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar123 * mv2.KVector3.Scalar235 - 2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar124 - 2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar345 * mv2.KVector3.Scalar134) * mv2NormSquaredInv;
                tempScalar[26] += (-2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar345 * mv2.KVector3.Scalar234) * mv2NormSquaredInv;
                tempScalar[28] += (-2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar235 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar234) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector1.IsZero() && !mv2.KVector5.IsZero())
            {
                tempScalar[7] += (2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar245 * mv2.KVector5.Scalar12345 + 2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar345 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
                tempScalar[11] += (-2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar235 * mv2.KVector5.Scalar12345 + 2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar345 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
                tempScalar[13] += (-2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar235 * mv2.KVector5.Scalar12345 - 2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar245 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
                tempScalar[19] += (2 * mv2.KVector1.Scalar2 * mv1.KVector3.Scalar234 * mv2.KVector5.Scalar12345 + 2 * mv2.KVector1.Scalar5 * mv1.KVector3.Scalar345 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
                tempScalar[21] += (2 * mv2.KVector1.Scalar3 * mv1.KVector3.Scalar234 * mv2.KVector5.Scalar12345 - 2 * mv2.KVector1.Scalar5 * mv1.KVector3.Scalar245 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
                tempScalar[25] += (2 * mv2.KVector1.Scalar4 * mv1.KVector3.Scalar234 * mv2.KVector5.Scalar12345 + 2 * mv2.KVector1.Scalar5 * mv1.KVector3.Scalar235 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector3.IsZero() && !mv2.KVector1.IsZero())
            {
                tempScalar[19] += (2 * mv2.KVector3.Scalar123 * mv1.KVector3.Scalar345 * mv2.KVector1.Scalar4 + 2 * mv2.KVector3.Scalar134 * mv1.KVector3.Scalar234 * mv2.KVector1.Scalar5 - 2 * mv2.KVector3.Scalar234 * mv1.KVector3.Scalar134 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[21] += (-2 * mv2.KVector3.Scalar124 * mv1.KVector3.Scalar234 * mv2.KVector1.Scalar5 - 2 * mv2.KVector3.Scalar123 * mv1.KVector3.Scalar245 * mv2.KVector1.Scalar4 + 2 * mv2.KVector3.Scalar234 * mv1.KVector3.Scalar124 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[25] += (2 * mv2.KVector3.Scalar123 * mv1.KVector3.Scalar234 * mv2.KVector1.Scalar5 - 2 * mv2.KVector3.Scalar234 * mv1.KVector3.Scalar123 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector3.IsZero())
            {
                tempScalar[7] += (-2 * mv2.KVector3.Scalar123 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar234 - 2 * mv2.KVector3.Scalar124 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar234 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar125 - mv2.KVector3.Scalar234 * mv1.KVector3.Scalar123 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar235 * mv1.KVector3.Scalar123 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar123 * mv1.KVector3.Scalar235 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar123 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar235 * mv1.KVector3.Scalar124 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar135 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar345 * mv1.KVector3.Scalar123 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar124 * mv1.KVector3.Scalar235 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar134 * mv1.KVector3.Scalar235 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar234 * mv1.KVector3.Scalar125 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar125 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar245 * mv1.KVector3.Scalar123 * mv2.KVector3.Scalar245) * mv2NormSquaredInv;
                tempScalar[11] += (2 * mv2.KVector3.Scalar234 * mv1.KVector3.Scalar345 * mv2.KVector3.Scalar145 - 2 * mv2.KVector3.Scalar134 * mv1.KVector3.Scalar345 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar345 * mv1.KVector3.Scalar124 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar123 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar234 * mv1.KVector3.Scalar124 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar245 * mv1.KVector3.Scalar124 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar124 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar124 * mv1.KVector3.Scalar345 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar134 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar245 * mv1.KVector3.Scalar134 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar235 * mv1.KVector3.Scalar124 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar234 * mv1.KVector3.Scalar125 * mv2.KVector3.Scalar235) * mv2NormSquaredInv;
                tempScalar[13] += (-2 * mv2.KVector3.Scalar234 * mv1.KVector3.Scalar235 * mv2.KVector3.Scalar135 + 2 * mv2.KVector3.Scalar145 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar245 * mv1.KVector3.Scalar134 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar123 * mv1.KVector3.Scalar235 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar123 * mv1.KVector3.Scalar345 * mv2.KVector3.Scalar235 - mv2.KVector3.Scalar234 * mv1.KVector3.Scalar134 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar345 * mv1.KVector3.Scalar134 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar134 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar234 + 2 * mv2.KVector3.Scalar124 * mv1.KVector3.Scalar345 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar134 * mv1.KVector3.Scalar235 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar134 * mv1.KVector3.Scalar345 * mv2.KVector3.Scalar345 - mv2.KVector3.Scalar235 * mv1.KVector3.Scalar134 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar135 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar234 * mv1.KVector3.Scalar135 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar235 * mv1.KVector3.Scalar123 * mv2.KVector3.Scalar345) * mv2NormSquaredInv;
                tempScalar[14] += (-mv2.KVector3.Scalar234 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar235 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar245 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar234 * mv1.KVector3.Scalar235 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar234 * mv1.KVector3.Scalar345 * mv2.KVector3.Scalar345 - mv2.KVector3.Scalar345 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar345) * mv2NormSquaredInv;
                tempScalar[19] += (mv2.KVector3.Scalar345 * mv1.KVector3.Scalar125 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar123 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar234 * mv1.KVector3.Scalar125 * mv2.KVector3.Scalar234 + 2 * mv2.KVector3.Scalar245 * mv1.KVector3.Scalar135 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar124 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar234 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar125 + mv2.KVector3.Scalar235 * mv1.KVector3.Scalar125 * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar245 * mv1.KVector3.Scalar125 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar235 * mv1.KVector3.Scalar145 * mv2.KVector3.Scalar345) * mv2NormSquaredInv;
                tempScalar[21] += (-2 * mv2.KVector3.Scalar235 * mv1.KVector3.Scalar145 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar125 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar235 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar145 - 2 * mv2.KVector3.Scalar135 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar234 * mv1.KVector3.Scalar135 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar245 * mv1.KVector3.Scalar135 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar134 * mv1.KVector3.Scalar235 * mv2.KVector3.Scalar234 - 2 * mv2.KVector3.Scalar145 * mv1.KVector3.Scalar235 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar234 * mv1.KVector3.Scalar123 * mv2.KVector3.Scalar345 - mv2.KVector3.Scalar235 * mv1.KVector3.Scalar135 * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar345 * mv1.KVector3.Scalar135 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar135 * mv1.KVector3.Scalar235 * mv2.KVector3.Scalar235) * mv2NormSquaredInv;
                tempScalar[22] += (-2 * mv2.KVector3.Scalar235 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar245 * mv1.KVector3.Scalar235 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar234 * mv1.KVector3.Scalar235 * mv2.KVector3.Scalar234 + mv2.KVector3.Scalar345 * mv1.KVector3.Scalar235 * mv2.KVector3.Scalar345 - mv2.KVector3.Scalar235 * mv1.KVector3.Scalar235 * mv2.KVector3.Scalar235) * mv2NormSquaredInv;
                tempScalar[25] += (mv2.KVector3.Scalar235 * mv1.KVector3.Scalar145 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar134 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar234 + 2 * mv2.KVector3.Scalar135 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar124 * mv1.KVector3.Scalar345 * mv2.KVector3.Scalar234 - 2 * mv2.KVector3.Scalar145 * mv1.KVector3.Scalar345 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar125 * mv1.KVector3.Scalar345 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar124 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar134 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar234 * mv1.KVector3.Scalar124 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar234 * mv1.KVector3.Scalar134 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar234 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar145 - mv2.KVector3.Scalar234 * mv1.KVector3.Scalar145 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar245 * mv1.KVector3.Scalar145 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar345 * mv1.KVector3.Scalar145 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar145 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar245) * mv2NormSquaredInv;
                tempScalar[26] += (-2 * mv2.KVector3.Scalar245 * mv1.KVector3.Scalar345 * mv2.KVector3.Scalar345 - mv2.KVector3.Scalar234 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar245 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar234 * mv1.KVector3.Scalar234 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar345 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar235 * mv1.KVector3.Scalar245 * mv2.KVector3.Scalar235) * mv2NormSquaredInv;
                tempScalar[28] += (-mv2.KVector3.Scalar345 * mv1.KVector3.Scalar345 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar235 * mv1.KVector3.Scalar235 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar234 * mv1.KVector3.Scalar345 * mv2.KVector3.Scalar234 + mv2.KVector3.Scalar245 * mv1.KVector3.Scalar345 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar235 * mv1.KVector3.Scalar345 * mv2.KVector3.Scalar235) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector3.IsZero() && !mv2.KVector5.IsZero())
            {
                tempScalar[7] += (-2 * mv2.KVector3.Scalar234 * mv1.KVector3.Scalar235 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
                tempScalar[13] += (-2 * mv2.KVector3.Scalar234 * mv1.KVector3.Scalar345 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
                tempScalar[19] += (2 * mv2.KVector3.Scalar245 * mv1.KVector3.Scalar235 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
                tempScalar[21] += (-2 * mv2.KVector3.Scalar235 * mv1.KVector3.Scalar345 * mv2.KVector5.Scalar12345 + 2 * mv2.KVector3.Scalar345 * mv1.KVector3.Scalar235 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
                tempScalar[25] += (-2 * mv2.KVector3.Scalar245 * mv1.KVector3.Scalar345 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
            }
            
        }
        
        if (!mv1.KVector4.IsZero())
        {
            if (!mv2.KVector1.IsZero())
            {
                tempScalar[15] += (2 * mv2.KVector1.Scalar1 * mv1.KVector4.Scalar2345 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar2 * mv1.KVector4.Scalar1234 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar2 * mv1.KVector4.Scalar1345 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar3 * mv1.KVector4.Scalar1234 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar3 * mv1.KVector4.Scalar1245 * mv2.KVector1.Scalar5 - mv2.KVector1.Scalar4 * mv1.KVector4.Scalar1234 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.KVector4.Scalar1235 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar5 * mv1.KVector4.Scalar1234 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[23] += (-2 * mv2.KVector1.Scalar1 * mv1.KVector4.Scalar2345 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar2 * mv1.KVector4.Scalar1235 * mv2.KVector1.Scalar2 + 2 * mv2.KVector1.Scalar2 * mv1.KVector4.Scalar1345 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar3 * mv1.KVector4.Scalar1235 * mv2.KVector1.Scalar3 - 2 * mv2.KVector1.Scalar3 * mv1.KVector4.Scalar1245 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar4 * mv1.KVector4.Scalar1234 * mv2.KVector1.Scalar5 + mv2.KVector1.Scalar4 * mv1.KVector4.Scalar1235 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.KVector4.Scalar1235 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[27] += (2 * mv2.KVector1.Scalar1 * mv1.KVector4.Scalar2345 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar2 * mv1.KVector4.Scalar1245 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar2 * mv1.KVector4.Scalar1345 * mv2.KVector1.Scalar3 + 2 * mv2.KVector1.Scalar3 * mv1.KVector4.Scalar1234 * mv2.KVector1.Scalar5 - 2 * mv2.KVector1.Scalar3 * mv1.KVector4.Scalar1235 * mv2.KVector1.Scalar4 + mv2.KVector1.Scalar3 * mv1.KVector4.Scalar1245 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.KVector4.Scalar1245 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.KVector4.Scalar1245 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[29] += (-2 * mv2.KVector1.Scalar1 * mv1.KVector4.Scalar2345 * mv2.KVector1.Scalar2 - 2 * mv2.KVector1.Scalar2 * mv1.KVector4.Scalar1234 * mv2.KVector1.Scalar5 + 2 * mv2.KVector1.Scalar2 * mv1.KVector4.Scalar1235 * mv2.KVector1.Scalar4 - 2 * mv2.KVector1.Scalar2 * mv1.KVector4.Scalar1245 * mv2.KVector1.Scalar3 + mv2.KVector1.Scalar2 * mv1.KVector4.Scalar1345 * mv2.KVector1.Scalar2 - mv2.KVector1.Scalar3 * mv1.KVector4.Scalar1345 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.KVector4.Scalar1345 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.KVector4.Scalar1345 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
                tempScalar[30] += (-mv2.KVector1.Scalar2 * mv1.KVector4.Scalar2345 * mv2.KVector1.Scalar2 - mv2.KVector1.Scalar3 * mv1.KVector4.Scalar2345 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.KVector4.Scalar2345 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.KVector4.Scalar2345 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector1.IsZero() && !mv2.KVector3.IsZero())
            {
                tempScalar[15] += (-2 * mv2.KVector1.Scalar2 * mv1.KVector4.Scalar2345 * mv2.KVector3.Scalar125 - 2 * mv2.KVector1.Scalar3 * mv1.KVector4.Scalar1235 * mv2.KVector3.Scalar345 - 2 * mv2.KVector1.Scalar4 * mv1.KVector4.Scalar1245 * mv2.KVector3.Scalar345 + 2 * mv2.KVector1.Scalar4 * mv1.KVector4.Scalar1345 * mv2.KVector3.Scalar245 - 2 * mv2.KVector1.Scalar4 * mv1.KVector4.Scalar2345 * mv2.KVector3.Scalar145) * mv2NormSquaredInv;
                tempScalar[23] += (2 * mv2.KVector1.Scalar2 * mv1.KVector4.Scalar2345 * mv2.KVector3.Scalar124 + 2 * mv2.KVector1.Scalar3 * mv1.KVector4.Scalar1234 * mv2.KVector3.Scalar345) * mv2NormSquaredInv;
                tempScalar[27] += (-2 * mv2.KVector1.Scalar2 * mv1.KVector4.Scalar2345 * mv2.KVector3.Scalar123 - 2 * mv2.KVector1.Scalar4 * mv1.KVector4.Scalar1345 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar4 * mv1.KVector4.Scalar2345 * mv2.KVector3.Scalar134) * mv2NormSquaredInv;
                tempScalar[29] += (-2 * mv2.KVector1.Scalar3 * mv1.KVector4.Scalar1234 * mv2.KVector3.Scalar235 + 2 * mv2.KVector1.Scalar3 * mv1.KVector4.Scalar1235 * mv2.KVector3.Scalar234 + 2 * mv2.KVector1.Scalar4 * mv1.KVector4.Scalar1245 * mv2.KVector3.Scalar234 - 2 * mv2.KVector1.Scalar4 * mv1.KVector4.Scalar2345 * mv2.KVector3.Scalar124) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector3.IsZero())
            {
                tempScalar[15] += (mv2.KVector3.Scalar245 * mv1.KVector4.Scalar1234 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar234 * mv1.KVector4.Scalar1234 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar235 * mv1.KVector4.Scalar1234 * mv2.KVector3.Scalar235 - mv2.KVector3.Scalar345 * mv1.KVector4.Scalar1234 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar234 * mv1.KVector4.Scalar1235 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar234 * mv1.KVector4.Scalar1345 * mv2.KVector3.Scalar345) * mv2NormSquaredInv;
                tempScalar[23] += (-mv2.KVector3.Scalar245 * mv1.KVector4.Scalar1235 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar235 * mv1.KVector4.Scalar1235 * mv2.KVector3.Scalar235 - 2 * mv2.KVector3.Scalar125 * mv1.KVector4.Scalar2345 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar234 * mv1.KVector4.Scalar1235 * mv2.KVector3.Scalar234 - 2 * mv2.KVector3.Scalar235 * mv1.KVector4.Scalar1245 * mv2.KVector3.Scalar245 + 2 * mv2.KVector3.Scalar123 * mv1.KVector4.Scalar2345 * mv2.KVector3.Scalar234 + 2 * mv2.KVector3.Scalar135 * mv1.KVector4.Scalar2345 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar345 * mv1.KVector4.Scalar1235 * mv2.KVector3.Scalar345) * mv2NormSquaredInv;
                tempScalar[27] += (-2 * mv2.KVector3.Scalar245 * mv1.KVector4.Scalar1345 * mv2.KVector3.Scalar345 - mv2.KVector3.Scalar234 * mv1.KVector4.Scalar1245 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar345 * mv1.KVector4.Scalar1245 * mv2.KVector3.Scalar345 - 2 * mv2.KVector3.Scalar234 * mv1.KVector4.Scalar1234 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar245 * mv1.KVector4.Scalar1245 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar235 * mv1.KVector4.Scalar1245 * mv2.KVector3.Scalar235) * mv2NormSquaredInv;
                tempScalar[29] += (-2 * mv2.KVector3.Scalar235 * mv1.KVector4.Scalar1235 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar234 * mv1.KVector4.Scalar1345 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar345 * mv1.KVector4.Scalar1345 * mv2.KVector3.Scalar345 + 2 * mv2.KVector3.Scalar134 * mv1.KVector4.Scalar2345 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar235 * mv1.KVector4.Scalar1345 * mv2.KVector3.Scalar235 + mv2.KVector3.Scalar245 * mv1.KVector4.Scalar1345 * mv2.KVector3.Scalar245 - 2 * mv2.KVector3.Scalar135 * mv1.KVector4.Scalar2345 * mv2.KVector3.Scalar235 + 2 * mv2.KVector3.Scalar145 * mv1.KVector4.Scalar2345 * mv2.KVector3.Scalar245) * mv2NormSquaredInv;
                tempScalar[30] += (mv2.KVector3.Scalar234 * mv1.KVector4.Scalar2345 * mv2.KVector3.Scalar234 + mv2.KVector3.Scalar245 * mv1.KVector4.Scalar2345 * mv2.KVector3.Scalar245 - mv2.KVector3.Scalar345 * mv1.KVector4.Scalar2345 * mv2.KVector3.Scalar345 - mv2.KVector3.Scalar235 * mv1.KVector4.Scalar2345 * mv2.KVector3.Scalar235) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector3.IsZero() && !mv2.KVector5.IsZero())
            {
                tempScalar[15] += (-2 * mv2.KVector3.Scalar234 * mv1.KVector4.Scalar2345 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
                tempScalar[23] += (-2 * mv2.KVector3.Scalar235 * mv1.KVector4.Scalar2345 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
                tempScalar[27] += (-2 * mv2.KVector3.Scalar245 * mv1.KVector4.Scalar2345 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
                tempScalar[29] += (-2 * mv2.KVector3.Scalar345 * mv1.KVector4.Scalar2345 * mv2.KVector5.Scalar12345) * mv2NormSquaredInv;
            }
            
        }
        
        if (!mv1.KVector5.IsZero())
        {
            if (!mv2.KVector1.IsZero())
            {
                tempScalar[31] += (-mv2.KVector1.Scalar2 * mv1.KVector5.Scalar12345 * mv2.KVector1.Scalar2 - mv2.KVector1.Scalar3 * mv1.KVector5.Scalar12345 * mv2.KVector1.Scalar3 - mv2.KVector1.Scalar4 * mv1.KVector5.Scalar12345 * mv2.KVector1.Scalar4 - mv2.KVector1.Scalar5 * mv1.KVector5.Scalar12345 * mv2.KVector1.Scalar5) * mv2NormSquaredInv;
            }
            
            if (!mv2.KVector3.IsZero())
            {
                tempScalar[31] += (-mv2.KVector3.Scalar345 * mv1.KVector5.Scalar12345 * mv2.KVector3.Scalar345 + mv2.KVector3.Scalar245 * mv1.KVector5.Scalar12345 * mv2.KVector3.Scalar245 + mv2.KVector3.Scalar234 * mv1.KVector5.Scalar12345 * mv2.KVector3.Scalar234 - mv2.KVector3.Scalar235 * mv1.KVector5.Scalar12345 * mv2.KVector3.Scalar235) * mv2NormSquaredInv;
            }
            
        }
        
        return Ga401Multivector.Create(tempScalar);
    }
    
}
