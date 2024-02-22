using System.Runtime.CompilerServices;

namespace GeometricAlgebraFulcrumLib.Generations.Algebra.Ga3;

public static class Ga3RotorMap
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga3KVector0 MapUsingRotor(this Ga3KVector0 mv1, Ga3KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga3KVector0.Zero;
        
        return new Ga3KVector0
        {
            Scalar = mv2.Scalar * mv1.Scalar * mv2.Scalar
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga3KVector0 MapUsingRotor(this Ga3KVector0 mv1, Ga3KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga3KVector0.Zero;
        
        return new Ga3KVector0
        {
            Scalar = mv2.Scalar12 * mv1.Scalar * mv2.Scalar12 + mv2.Scalar13 * mv1.Scalar * mv2.Scalar13 + mv2.Scalar23 * mv1.Scalar * mv2.Scalar23
        };
    }
    
    public static Ga3KVector0 MapUsingRotor(this Ga3KVector0 mv1, Ga3Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga3KVector0.Zero;
        
        var tempScalar = 0d;
        
        if (!mv2.KVector0.IsZero())
        {
            tempScalar += mv2.KVector0.Scalar * mv1.Scalar * mv2.KVector0.Scalar;
        }
        
        if (!mv2.KVector2.IsZero())
        {
            tempScalar += mv2.KVector2.Scalar12 * mv1.Scalar * mv2.KVector2.Scalar12 + mv2.KVector2.Scalar13 * mv1.Scalar * mv2.KVector2.Scalar13 + mv2.KVector2.Scalar23 * mv1.Scalar * mv2.KVector2.Scalar23;
        }
        
        return new Ga3KVector0
        {
            Scalar = tempScalar
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga3KVector1 MapUsingRotor(this Ga3KVector1 mv1, Ga3KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga3KVector1.Zero;
        
        return new Ga3KVector1
        {
            Scalar1 = mv2.Scalar * mv1.Scalar1 * mv2.Scalar,
            Scalar2 = mv2.Scalar * mv1.Scalar2 * mv2.Scalar,
            Scalar3 = mv2.Scalar * mv1.Scalar3 * mv2.Scalar
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga3KVector1 MapUsingRotor(this Ga3KVector1 mv1, Ga3KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga3KVector1.Zero;
        
        return new Ga3KVector1
        {
            Scalar1 = mv2.Scalar12 * mv1.Scalar1 * mv2.Scalar12 + 2 * mv2.Scalar12 * mv1.Scalar3 * mv2.Scalar23 + mv2.Scalar13 * mv1.Scalar1 * mv2.Scalar13 + mv2.Scalar23 * mv1.Scalar1 * mv2.Scalar23 + 2 * mv2.Scalar13 * mv1.Scalar2 * mv2.Scalar23,
            Scalar2 = mv2.Scalar23 * mv1.Scalar2 * mv2.Scalar23 - mv2.Scalar12 * mv1.Scalar2 * mv2.Scalar12 - mv2.Scalar13 * mv1.Scalar2 * mv2.Scalar13 - 2 * mv2.Scalar12 * mv1.Scalar3 * mv2.Scalar13,
            Scalar3 = mv2.Scalar12 * mv1.Scalar3 * mv2.Scalar12 - mv2.Scalar13 * mv1.Scalar3 * mv2.Scalar13 - mv2.Scalar23 * mv1.Scalar3 * mv2.Scalar23
        };
    }
    
    public static Ga3KVector1 MapUsingRotor(this Ga3KVector1 mv1, Ga3Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga3KVector1.Zero;
        
        var tempScalar0 = 0d;
        var tempScalar1 = 0d;
        var tempScalar2 = 0d;
        
        if (!mv2.KVector0.IsZero())
        {
            tempScalar0 += mv2.KVector0.Scalar * mv1.Scalar1 * mv2.KVector0.Scalar;
            tempScalar1 += mv2.KVector0.Scalar * mv1.Scalar2 * mv2.KVector0.Scalar;
            tempScalar2 += mv2.KVector0.Scalar * mv1.Scalar3 * mv2.KVector0.Scalar;
        }
        
        if (!mv2.KVector0.IsZero() && !mv2.KVector2.IsZero())
        {
            tempScalar0 += 2 * mv2.KVector0.Scalar * mv1.Scalar2 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.Scalar3 * mv2.KVector2.Scalar13;
            tempScalar1 += -2 * mv2.KVector0.Scalar * mv1.Scalar1 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.Scalar3 * mv2.KVector2.Scalar23;
            tempScalar2 += -2 * mv2.KVector0.Scalar * mv1.Scalar1 * mv2.KVector2.Scalar13 - 2 * mv2.KVector0.Scalar * mv1.Scalar2 * mv2.KVector2.Scalar23;
        }
        
        if (!mv2.KVector2.IsZero())
        {
            tempScalar0 += mv2.KVector2.Scalar12 * mv1.Scalar1 * mv2.KVector2.Scalar12 + 2 * mv2.KVector2.Scalar12 * mv1.Scalar3 * mv2.KVector2.Scalar23 + mv2.KVector2.Scalar13 * mv1.Scalar1 * mv2.KVector2.Scalar13 + mv2.KVector2.Scalar23 * mv1.Scalar1 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar13 * mv1.Scalar2 * mv2.KVector2.Scalar23;
            tempScalar1 += mv2.KVector2.Scalar23 * mv1.Scalar2 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar12 * mv1.Scalar2 * mv2.KVector2.Scalar12 - mv2.KVector2.Scalar13 * mv1.Scalar2 * mv2.KVector2.Scalar13 - 2 * mv2.KVector2.Scalar12 * mv1.Scalar3 * mv2.KVector2.Scalar13;
            tempScalar2 += mv2.KVector2.Scalar12 * mv1.Scalar3 * mv2.KVector2.Scalar12 - mv2.KVector2.Scalar13 * mv1.Scalar3 * mv2.KVector2.Scalar13 - mv2.KVector2.Scalar23 * mv1.Scalar3 * mv2.KVector2.Scalar23;
        }
        
        return new Ga3KVector1
        {
            Scalar1 = tempScalar0,
            Scalar2 = tempScalar1,
            Scalar3 = tempScalar2
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga3KVector2 MapUsingRotor(this Ga3KVector2 mv1, Ga3KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga3KVector2.Zero;
        
        return new Ga3KVector2
        {
            Scalar12 = mv2.Scalar * mv1.Scalar12 * mv2.Scalar,
            Scalar13 = mv2.Scalar * mv1.Scalar13 * mv2.Scalar,
            Scalar23 = mv2.Scalar * mv1.Scalar23 * mv2.Scalar
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga3KVector2 MapUsingRotor(this Ga3KVector2 mv1, Ga3KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga3KVector2.Zero;
        
        return new Ga3KVector2
        {
            Scalar12 = -mv2.Scalar12 * mv1.Scalar12 * mv2.Scalar12 - mv2.Scalar13 * mv1.Scalar12 * mv2.Scalar13 - 2 * mv2.Scalar12 * mv1.Scalar13 * mv2.Scalar13 + mv2.Scalar23 * mv1.Scalar12 * mv2.Scalar23,
            Scalar13 = mv2.Scalar12 * mv1.Scalar13 * mv2.Scalar12 - mv2.Scalar13 * mv1.Scalar13 * mv2.Scalar13 - mv2.Scalar23 * mv1.Scalar13 * mv2.Scalar23 - 2 * mv2.Scalar13 * mv1.Scalar23 * mv2.Scalar23,
            Scalar23 = -2 * mv2.Scalar12 * mv1.Scalar12 * mv2.Scalar23 - mv2.Scalar12 * mv1.Scalar23 * mv2.Scalar12 - mv2.Scalar23 * mv1.Scalar23 * mv2.Scalar23 + mv2.Scalar13 * mv1.Scalar23 * mv2.Scalar13
        };
    }
    
    public static Ga3KVector2 MapUsingRotor(this Ga3KVector2 mv1, Ga3Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga3KVector2.Zero;
        
        var tempScalar0 = 0d;
        var tempScalar1 = 0d;
        var tempScalar2 = 0d;
        
        if (!mv2.KVector0.IsZero())
        {
            tempScalar0 += mv2.KVector0.Scalar * mv1.Scalar12 * mv2.KVector0.Scalar;
            tempScalar1 += mv2.KVector0.Scalar * mv1.Scalar13 * mv2.KVector0.Scalar;
            tempScalar2 += mv2.KVector0.Scalar * mv1.Scalar23 * mv2.KVector0.Scalar;
        }
        
        if (!mv2.KVector0.IsZero() && !mv2.KVector2.IsZero())
        {
            tempScalar0 += 2 * mv2.KVector0.Scalar * mv1.Scalar13 * mv2.KVector2.Scalar23 - 2 * mv2.KVector0.Scalar * mv1.Scalar23 * mv2.KVector2.Scalar13;
            tempScalar1 += -2 * mv2.KVector0.Scalar * mv1.Scalar12 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.Scalar23 * mv2.KVector2.Scalar12;
            tempScalar2 += 2 * mv2.KVector0.Scalar * mv1.Scalar12 * mv2.KVector2.Scalar13 - 2 * mv2.KVector0.Scalar * mv1.Scalar13 * mv2.KVector2.Scalar12;
        }
        
        if (!mv2.KVector2.IsZero())
        {
            tempScalar0 += -mv2.KVector2.Scalar12 * mv1.Scalar12 * mv2.KVector2.Scalar12 - mv2.KVector2.Scalar13 * mv1.Scalar12 * mv2.KVector2.Scalar13 - 2 * mv2.KVector2.Scalar12 * mv1.Scalar13 * mv2.KVector2.Scalar13 + mv2.KVector2.Scalar23 * mv1.Scalar12 * mv2.KVector2.Scalar23;
            tempScalar1 += mv2.KVector2.Scalar12 * mv1.Scalar13 * mv2.KVector2.Scalar12 - mv2.KVector2.Scalar13 * mv1.Scalar13 * mv2.KVector2.Scalar13 - mv2.KVector2.Scalar23 * mv1.Scalar13 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar13 * mv1.Scalar23 * mv2.KVector2.Scalar23;
            tempScalar2 += -2 * mv2.KVector2.Scalar12 * mv1.Scalar12 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar12 * mv1.Scalar23 * mv2.KVector2.Scalar12 - mv2.KVector2.Scalar23 * mv1.Scalar23 * mv2.KVector2.Scalar23 + mv2.KVector2.Scalar13 * mv1.Scalar23 * mv2.KVector2.Scalar13;
        }
        
        return new Ga3KVector2
        {
            Scalar12 = tempScalar0,
            Scalar13 = tempScalar1,
            Scalar23 = tempScalar2
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga3KVector3 MapUsingRotor(this Ga3KVector3 mv1, Ga3KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga3KVector3.Zero;
        
        return new Ga3KVector3
        {
            Scalar123 = mv2.Scalar * mv1.Scalar123 * mv2.Scalar
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Ga3KVector3 MapUsingRotor(this Ga3KVector3 mv1, Ga3KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga3KVector3.Zero;
        
        return new Ga3KVector3
        {
            Scalar123 = -mv2.Scalar12 * mv1.Scalar123 * mv2.Scalar12 + mv2.Scalar13 * mv1.Scalar123 * mv2.Scalar13 - mv2.Scalar23 * mv1.Scalar123 * mv2.Scalar23
        };
    }
    
    public static Ga3KVector3 MapUsingRotor(this Ga3KVector3 mv1, Ga3Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga3KVector3.Zero;
        
        var tempScalar = 0d;
        
        if (!mv2.KVector0.IsZero())
        {
            tempScalar += mv2.KVector0.Scalar * mv1.Scalar123 * mv2.KVector0.Scalar;
        }
        
        if (!mv2.KVector2.IsZero())
        {
            tempScalar += -mv2.KVector2.Scalar12 * mv1.Scalar123 * mv2.KVector2.Scalar12 + mv2.KVector2.Scalar13 * mv1.Scalar123 * mv2.KVector2.Scalar13 - mv2.KVector2.Scalar23 * mv1.Scalar123 * mv2.KVector2.Scalar23;
        }
        
        return new Ga3KVector3
        {
            Scalar123 = tempScalar
        };
    }
    
    public static Ga3Multivector MapUsingRotor(this Ga3Multivector mv1, Ga3KVector0 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga3Multivector.Zero;
        
        var tempScalar = new double[8];
        
        if (!mv1.KVector0.IsZero())
        {
            tempScalar[0] += mv2.Scalar * mv1.KVector0.Scalar * mv2.Scalar;
        }
        
        if (!mv1.KVector1.IsZero())
        {
            tempScalar[1] += mv2.Scalar * mv1.KVector1.Scalar1 * mv2.Scalar;
            tempScalar[2] += mv2.Scalar * mv1.KVector1.Scalar2 * mv2.Scalar;
            tempScalar[4] += mv2.Scalar * mv1.KVector1.Scalar3 * mv2.Scalar;
        }
        
        if (!mv1.KVector2.IsZero())
        {
            tempScalar[3] += mv2.Scalar * mv1.KVector2.Scalar12 * mv2.Scalar;
            tempScalar[5] += mv2.Scalar * mv1.KVector2.Scalar13 * mv2.Scalar;
            tempScalar[6] += mv2.Scalar * mv1.KVector2.Scalar23 * mv2.Scalar;
        }
        
        if (!mv1.KVector3.IsZero())
        {
            tempScalar[7] += mv2.Scalar * mv1.KVector3.Scalar123 * mv2.Scalar;
        }
        
        return Ga3Multivector.Create(tempScalar);
    }
    
    public static Ga3Multivector MapUsingRotor(this Ga3Multivector mv1, Ga3KVector2 mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga3Multivector.Zero;
        
        var tempScalar = new double[8];
        
        if (!mv1.KVector0.IsZero())
        {
            tempScalar[0] += mv2.Scalar12 * mv1.KVector0.Scalar * mv2.Scalar12 + mv2.Scalar13 * mv1.KVector0.Scalar * mv2.Scalar13 + mv2.Scalar23 * mv1.KVector0.Scalar * mv2.Scalar23;
        }
        
        if (!mv1.KVector1.IsZero())
        {
            tempScalar[1] += mv2.Scalar12 * mv1.KVector1.Scalar1 * mv2.Scalar12 + 2 * mv2.Scalar12 * mv1.KVector1.Scalar3 * mv2.Scalar23 + mv2.Scalar13 * mv1.KVector1.Scalar1 * mv2.Scalar13 + mv2.Scalar23 * mv1.KVector1.Scalar1 * mv2.Scalar23 + 2 * mv2.Scalar13 * mv1.KVector1.Scalar2 * mv2.Scalar23;
            tempScalar[2] += mv2.Scalar23 * mv1.KVector1.Scalar2 * mv2.Scalar23 - mv2.Scalar12 * mv1.KVector1.Scalar2 * mv2.Scalar12 - mv2.Scalar13 * mv1.KVector1.Scalar2 * mv2.Scalar13 - 2 * mv2.Scalar12 * mv1.KVector1.Scalar3 * mv2.Scalar13;
            tempScalar[4] += mv2.Scalar12 * mv1.KVector1.Scalar3 * mv2.Scalar12 - mv2.Scalar13 * mv1.KVector1.Scalar3 * mv2.Scalar13 - mv2.Scalar23 * mv1.KVector1.Scalar3 * mv2.Scalar23;
        }
        
        if (!mv1.KVector2.IsZero())
        {
            tempScalar[3] += -mv2.Scalar12 * mv1.KVector2.Scalar12 * mv2.Scalar12 - mv2.Scalar13 * mv1.KVector2.Scalar12 * mv2.Scalar13 - 2 * mv2.Scalar12 * mv1.KVector2.Scalar13 * mv2.Scalar13 + mv2.Scalar23 * mv1.KVector2.Scalar12 * mv2.Scalar23;
            tempScalar[5] += mv2.Scalar12 * mv1.KVector2.Scalar13 * mv2.Scalar12 - mv2.Scalar13 * mv1.KVector2.Scalar13 * mv2.Scalar13 - mv2.Scalar23 * mv1.KVector2.Scalar13 * mv2.Scalar23 - 2 * mv2.Scalar13 * mv1.KVector2.Scalar23 * mv2.Scalar23;
            tempScalar[6] += -2 * mv2.Scalar12 * mv1.KVector2.Scalar12 * mv2.Scalar23 - mv2.Scalar12 * mv1.KVector2.Scalar23 * mv2.Scalar12 - mv2.Scalar23 * mv1.KVector2.Scalar23 * mv2.Scalar23 + mv2.Scalar13 * mv1.KVector2.Scalar23 * mv2.Scalar13;
        }
        
        if (!mv1.KVector3.IsZero())
        {
            tempScalar[7] += -mv2.Scalar12 * mv1.KVector3.Scalar123 * mv2.Scalar12 + mv2.Scalar13 * mv1.KVector3.Scalar123 * mv2.Scalar13 - mv2.Scalar23 * mv1.KVector3.Scalar123 * mv2.Scalar23;
        }
        
        return Ga3Multivector.Create(tempScalar);
    }
    
    public static Ga3Multivector MapUsingRotor(this Ga3Multivector mv1, Ga3Multivector mv2)
    {
        if (mv1.IsZero() || mv2.IsZero()) return Ga3Multivector.Zero;
        
        var tempScalar = new double[8];
        
        if (!mv1.KVector0.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar[0] += mv2.KVector0.Scalar * mv1.KVector0.Scalar * mv2.KVector0.Scalar;
            }
            
            if (!mv2.KVector2.IsZero())
            {
                tempScalar[0] += mv2.KVector2.Scalar12 * mv1.KVector0.Scalar * mv2.KVector2.Scalar12 + mv2.KVector2.Scalar13 * mv1.KVector0.Scalar * mv2.KVector2.Scalar13 + mv2.KVector2.Scalar23 * mv1.KVector0.Scalar * mv2.KVector2.Scalar23;
            }
            
        }
        
        if (!mv1.KVector1.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar[1] += mv2.KVector0.Scalar * mv1.KVector1.Scalar1 * mv2.KVector0.Scalar;
                tempScalar[2] += mv2.KVector0.Scalar * mv1.KVector1.Scalar2 * mv2.KVector0.Scalar;
                tempScalar[4] += mv2.KVector0.Scalar * mv1.KVector1.Scalar3 * mv2.KVector0.Scalar;
            }
            
            if (!mv2.KVector0.IsZero() && !mv2.KVector2.IsZero())
            {
                tempScalar[1] += 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar13;
                tempScalar[2] += -2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar1 * mv2.KVector2.Scalar12 + 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar23;
                tempScalar[4] += -2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar1 * mv2.KVector2.Scalar13 - 2 * mv2.KVector0.Scalar * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar23;
            }
            
            if (!mv2.KVector2.IsZero())
            {
                tempScalar[1] += mv2.KVector2.Scalar12 * mv1.KVector1.Scalar1 * mv2.KVector2.Scalar12 + 2 * mv2.KVector2.Scalar12 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar23 + mv2.KVector2.Scalar13 * mv1.KVector1.Scalar1 * mv2.KVector2.Scalar13 + mv2.KVector2.Scalar23 * mv1.KVector1.Scalar1 * mv2.KVector2.Scalar23 + 2 * mv2.KVector2.Scalar13 * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar23;
                tempScalar[2] += mv2.KVector2.Scalar23 * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar12 * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar12 - mv2.KVector2.Scalar13 * mv1.KVector1.Scalar2 * mv2.KVector2.Scalar13 - 2 * mv2.KVector2.Scalar12 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar13;
                tempScalar[4] += mv2.KVector2.Scalar12 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar12 - mv2.KVector2.Scalar13 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar13 - mv2.KVector2.Scalar23 * mv1.KVector1.Scalar3 * mv2.KVector2.Scalar23;
            }
            
        }
        
        if (!mv1.KVector2.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar[3] += mv2.KVector0.Scalar * mv1.KVector2.Scalar12 * mv2.KVector0.Scalar;
                tempScalar[5] += mv2.KVector0.Scalar * mv1.KVector2.Scalar13 * mv2.KVector0.Scalar;
                tempScalar[6] += mv2.KVector0.Scalar * mv1.KVector2.Scalar23 * mv2.KVector0.Scalar;
            }
            
            if (!mv2.KVector0.IsZero() && !mv2.KVector2.IsZero())
            {
                tempScalar[3] += 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar23 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar13;
                tempScalar[5] += -2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar23 + 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar12;
                tempScalar[6] += 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar13 - 2 * mv2.KVector0.Scalar * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar12;
            }
            
            if (!mv2.KVector2.IsZero())
            {
                tempScalar[3] += -mv2.KVector2.Scalar12 * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar12 - mv2.KVector2.Scalar13 * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar13 - 2 * mv2.KVector2.Scalar12 * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar13 + mv2.KVector2.Scalar23 * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar23;
                tempScalar[5] += mv2.KVector2.Scalar12 * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar12 - mv2.KVector2.Scalar13 * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar13 - mv2.KVector2.Scalar23 * mv1.KVector2.Scalar13 * mv2.KVector2.Scalar23 - 2 * mv2.KVector2.Scalar13 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar23;
                tempScalar[6] += -2 * mv2.KVector2.Scalar12 * mv1.KVector2.Scalar12 * mv2.KVector2.Scalar23 - mv2.KVector2.Scalar12 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar12 - mv2.KVector2.Scalar23 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar23 + mv2.KVector2.Scalar13 * mv1.KVector2.Scalar23 * mv2.KVector2.Scalar13;
            }
            
        }
        
        if (!mv1.KVector3.IsZero())
        {
            if (!mv2.KVector0.IsZero())
            {
                tempScalar[7] += mv2.KVector0.Scalar * mv1.KVector3.Scalar123 * mv2.KVector0.Scalar;
            }
            
            if (!mv2.KVector2.IsZero())
            {
                tempScalar[7] += -mv2.KVector2.Scalar12 * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar12 + mv2.KVector2.Scalar13 * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar13 - mv2.KVector2.Scalar23 * mv1.KVector3.Scalar123 * mv2.KVector2.Scalar23;
            }
            
        }
        
        return Ga3Multivector.Create(tempScalar);
    }
    
}
