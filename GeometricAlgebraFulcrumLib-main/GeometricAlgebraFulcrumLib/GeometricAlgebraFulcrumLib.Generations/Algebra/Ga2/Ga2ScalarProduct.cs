using System.Runtime.CompilerServices;

namespace GeometricAlgebraFulcrumLib.Generations.Algebra.Ga2;

public static class Ga2ScalarProduct
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga2KVector0 Sp(this Ga2KVector0 mv1, Ga2KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga2KVector0.Zero;
        
        return new Ga2KVector0
        {
            Scalar = mv1.Scalar * mv2.Scalar
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga2KVector0 Sp(this Ga2KVector0 mv1, Ga2KVector1 mv2)
    {
        return Ga2KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga2KVector0 Sp(this Ga2KVector0 mv1, Ga2KVector2 mv2)
    {
        return Ga2KVector0.Zero;
    }
    
    public static Ga2KVector0 Sp(this Ga2KVector0 mv1, Ga2Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga2KVector0.Zero;
        
        var tempScalar = 0d;
        
        if (!mv2.KVector0.IsZero())
        {
            tempScalar += mv1.Scalar * mv2.KVector0.Scalar;
        }
        
        return new Ga2KVector0
        {
            Scalar = tempScalar
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga2KVector0 Sp(this Ga2KVector1 mv1, Ga2KVector0 mv2)
    {
        return Ga2KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga2KVector0 Sp(this Ga2KVector1 mv1, Ga2KVector1 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga2KVector0.Zero;
        
        return new Ga2KVector0
        {
            Scalar = mv1.Scalar1 * mv2.Scalar1 + mv1.Scalar2 * mv2.Scalar2
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga2KVector0 Sp(this Ga2KVector1 mv1, Ga2KVector2 mv2)
    {
        return Ga2KVector0.Zero;
    }
    
    public static Ga2KVector0 Sp(this Ga2KVector1 mv1, Ga2Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga2KVector0.Zero;
        
        var tempScalar = 0d;
        
        if (!mv2.KVector1.IsZero())
        {
            tempScalar += mv1.Scalar1 * mv2.KVector1.Scalar1 + mv1.Scalar2 * mv2.KVector1.Scalar2;
        }
        
        return new Ga2KVector0
        {
            Scalar = tempScalar
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga2KVector0 Sp(this Ga2KVector2 mv1, Ga2KVector0 mv2)
    {
        return Ga2KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga2KVector0 Sp(this Ga2KVector2 mv1, Ga2KVector1 mv2)
    {
        return Ga2KVector0.Zero;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga2KVector0 Sp(this Ga2KVector2 mv1, Ga2KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga2KVector0.Zero;
        
        return new Ga2KVector0
        {
            Scalar = -mv1.Scalar12 * mv2.Scalar12
        };
    }
    
    public static Ga2KVector0 Sp(this Ga2KVector2 mv1, Ga2Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga2KVector0.Zero;
        
        var tempScalar = 0d;
        
        if (!mv2.KVector2.IsZero())
        {
            tempScalar += -mv1.Scalar12 * mv2.KVector2.Scalar12;
        }
        
        return new Ga2KVector0
        {
            Scalar = tempScalar
        };
    }
    
    public static Ga2KVector0 Sp(this Ga2Multivector mv1, Ga2KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga2KVector0.Zero;
        
        var tempScalar = 0d;
        
        if (!mv1.KVector0.IsZero())
        {
            tempScalar += mv1.KVector0.Scalar * mv2.Scalar;
        }
        
        return new Ga2KVector0
        {
            Scalar = tempScalar
        };
    }
    
    public static Ga2KVector0 Sp(this Ga2Multivector mv1, Ga2KVector1 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga2KVector0.Zero;
        
        var tempScalar = 0d;
        
        if (!mv1.KVector1.IsZero())
        {
            tempScalar += mv1.KVector1.Scalar1 * mv2.Scalar1 + mv1.KVector1.Scalar2 * mv2.Scalar2;
        }
        
        return new Ga2KVector0
        {
            Scalar = tempScalar
        };
    }
    
    public static Ga2KVector0 Sp(this Ga2Multivector mv1, Ga2KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga2KVector0.Zero;
        
        var tempScalar = 0d;
        
        if (!mv1.KVector2.IsZero())
        {
            tempScalar += -mv1.KVector2.Scalar12 * mv2.Scalar12;
        }
        
        return new Ga2KVector0
        {
            Scalar = tempScalar
        };
    }
    
    public static Ga2KVector0 Sp(this Ga2Multivector mv1, Ga2Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga2KVector0.Zero;
        
        var tempScalar = 0d;
        
        if (!mv1.KVector0.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar += mv1.KVector0.Scalar * mv2.KVector0.Scalar;
            }
            
        }
        
        if (!mv1.KVector1.IsZero())
        {
            if (!mv2.KVector1.IsZero())
            {
                tempScalar += mv1.KVector1.Scalar1 * mv2.KVector1.Scalar1 + mv1.KVector1.Scalar2 * mv2.KVector1.Scalar2;
            }
            
        }
        
        if (!mv1.KVector2.IsZero())
        {
            if (!mv2.KVector2.IsZero())
            {
                tempScalar += -mv1.KVector2.Scalar12 * mv2.KVector2.Scalar12;
            }
            
        }
        
        return new Ga2KVector0
        {
            Scalar = tempScalar
        };
    }
    
}
