﻿using DataStructuresLib.Basic;
using GeometricAlgebraFulcrumLib.Lite.SignalAlgebra;
using GeometricAlgebraFulcrumLib.MathBase.GeometricAlgebra.Extended.Generic.Multivectors;
using GeometricAlgebraFulcrumLib.MathBase.GeometricAlgebra.Extended.Generic.Multivectors.Composers;
using GeometricAlgebraFulcrumLib.MathBase.GeometricAlgebra.Extended.Generic.Subspaces;
using GeometricAlgebraFulcrumLib.MathBase.SignalAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace GeometricAlgebraFulcrumLib.MathBase.GeometricAlgebra.Extended.Generic.Frames;

public static class XGaFrameUtils
{
    /// <summary>
    /// Apply the Gram-Schmidt process using the outer product
    /// See here for more details:
    /// https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process
    /// "Gram-Schmidt Orthogonalization in Geometric Algebra"
    /// https://vixra.org/abs/1306.0176
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="vectorsList"></param>
    /// <param name="makeUnitVectors"></param>
    /// <returns></returns>
    public static IReadOnlyList<XGaVector<T>> ApplyGramSchmidt<T>(this IEnumerable<XGaVector<T>> vectorsList, bool makeUnitVectors)
    {
        var inputVectorsList = new List<XGaVector<T>>(
            vectorsList.Where(v => !v.IsNearZero())
        );

        var outputVectorsList = new List<XGaVector<T>>(inputVectorsList.Count);

        var v1 = inputVectorsList[0];

        outputVectorsList.Add(makeUnitVectors ? v1 / v1.Norm() : v1);

        var mv1 = v1.AsKVector();

        for (var i = 1; i < inputVectorsList.Count; i++)
        {
            var mv2 = mv1.Op(inputVectorsList[i]);

            // If the new vector is linearly dependent on the previous ones, ignore it
            if (mv2.IsNearZero()) continue;

            var v2 = mv1.Reverse().Gp(mv2).GetVectorPart();

            outputVectorsList.Add(makeUnitVectors ? v2 / v2.Norm() : v2);

            mv1 = mv2;
        }

        return outputVectorsList;
    }

    public static Pair<XGaVector<T>> ApplyGramSchmidt<T>(this XGaVector<T> v1, XGaVector<T> v2, bool makeUnitVectors)
    {
        var vectorsList = (new[] { v1, v2 }).ApplyGramSchmidt(
            makeUnitVectors
        );

        var zeroVector = v1.Processor.CreateZeroVector();

        return vectorsList.Count switch
        {
            0 => new Pair<XGaVector<T>>(zeroVector, zeroVector),
            1 => new Pair<XGaVector<T>>(vectorsList[0], zeroVector),
            _ => new Pair<XGaVector<T>>(vectorsList[0], vectorsList[1])
        };
    }

    public static Triplet<XGaVector<T>> ApplyGramSchmidt<T>(this XGaVector<T> v1, XGaVector<T> v2, XGaVector<T> v3, bool makeUnitVectors)
    {
        var vectorsList = (new[] { v1, v2, v3 }).ApplyGramSchmidt(
            makeUnitVectors
        );

        var zeroVector = v1.Processor.CreateZeroVector();

        return vectorsList.Count switch
        {
            0 => new Triplet<XGaVector<T>>(zeroVector, zeroVector, zeroVector),
            1 => new Triplet<XGaVector<T>>(vectorsList[0], zeroVector, zeroVector),
            2 => new Triplet<XGaVector<T>>(vectorsList[0], vectorsList[1], zeroVector),
            _ => new Triplet<XGaVector<T>>(vectorsList[0], vectorsList[1], vectorsList[2])
        };
    }

    public static Quad<XGaVector<T>> ApplyGramSchmidt<T>(this XGaVector<T> v1, XGaVector<T> v2, XGaVector<T> v3, XGaVector<T> v4, bool makeUnitVectors)
    {
        var vectorsList = (new[] { v1, v2, v3, v4 }).ApplyGramSchmidt(
            makeUnitVectors
        );

        var zeroVector = v1.Processor.CreateZeroVector();

        return vectorsList.Count switch
        {
            0 => new Quad<XGaVector<T>>(zeroVector, zeroVector, zeroVector, zeroVector),
            1 => new Quad<XGaVector<T>>(vectorsList[0], zeroVector, zeroVector, zeroVector),
            2 => new Quad<XGaVector<T>>(vectorsList[0], vectorsList[1], zeroVector, zeroVector),
            3 => new Quad<XGaVector<T>>(vectorsList[0], vectorsList[1], vectorsList[2], zeroVector),
            _ => new Quad<XGaVector<T>>(vectorsList[0], vectorsList[1], vectorsList[2], vectorsList[3])
        };
    }

    public static Quint<XGaVector<T>> ApplyGramSchmidt<T>(this XGaVector<T> v1, XGaVector<T> v2, XGaVector<T> v3, XGaVector<T> v4, XGaVector<T> v5, bool makeUnitVectors)
    {
        var vectorsList = (new[] { v1, v2, v3, v4, v5 }).ApplyGramSchmidt(
            makeUnitVectors
        );

        var zeroVector = v1.Processor.CreateZeroVector();

        return vectorsList.Count switch
        {
            0 => new Quint<XGaVector<T>>(zeroVector, zeroVector, zeroVector, zeroVector, zeroVector),
            1 => new Quint<XGaVector<T>>(vectorsList[0], zeroVector, zeroVector, zeroVector, zeroVector),
            2 => new Quint<XGaVector<T>>(vectorsList[0], vectorsList[1], zeroVector, zeroVector, zeroVector),
            3 => new Quint<XGaVector<T>>(vectorsList[0], vectorsList[1], vectorsList[2], zeroVector, zeroVector),
            4 => new Quint<XGaVector<T>>(vectorsList[0], vectorsList[1], vectorsList[2], vectorsList[3], zeroVector),
            _ => new Quint<XGaVector<T>>(vectorsList[0], vectorsList[1], vectorsList[2], vectorsList[3], vectorsList[4])
        };
    }

    public static Hexad<XGaVector<T>> ApplyGramSchmidt<T>(this XGaVector<T> v1, XGaVector<T> v2, XGaVector<T> v3, XGaVector<T> v4, XGaVector<T> v5, XGaVector<T> v6, bool makeUnitVectors)
    {
        var vectorsList = (new[] { v1, v2, v3, v4, v5, v6 }).ApplyGramSchmidt(
            makeUnitVectors
        );

        var zeroVector = v1.Processor.CreateZeroVector();

        return vectorsList.Count switch
        {
            0 => new Hexad<XGaVector<T>>(zeroVector, zeroVector, zeroVector, zeroVector, zeroVector, zeroVector),
            1 => new Hexad<XGaVector<T>>(vectorsList[0], zeroVector, zeroVector, zeroVector, zeroVector, zeroVector),
            2 => new Hexad<XGaVector<T>>(vectorsList[0], vectorsList[1], zeroVector, zeroVector, zeroVector, zeroVector),
            3 => new Hexad<XGaVector<T>>(vectorsList[0], vectorsList[1], vectorsList[2], zeroVector, zeroVector, zeroVector),
            4 => new Hexad<XGaVector<T>>(vectorsList[0], vectorsList[1], vectorsList[2], vectorsList[3], zeroVector, zeroVector),
            5 => new Hexad<XGaVector<T>>(vectorsList[0], vectorsList[1], vectorsList[2], vectorsList[3], vectorsList[4], zeroVector),
            _ => new Hexad<XGaVector<T>>(vectorsList[0], vectorsList[1], vectorsList[2], vectorsList[3], vectorsList[4], vectorsList[5])
        };
    }
        
    public static IReadOnlyList<XGaVector<Float64Signal>> ApplyGramSchmidtByProjections(this IReadOnlyList<XGaVector<Float64Signal>> vectorsList, bool makeUnitVectors)
    {
        var vectorMatrixList =
            vectorsList
                .Select(v => v.ToMatrix())
                .ToArray();

        var processor = vectorsList[0].Processor;
        var samplingSpecs = vectorsList[0].GetSamplingSpecs();
        var vectorCount = vectorMatrixList.Length;
        var samplingRate = samplingSpecs.SamplingRate;
        var sampleCount = samplingSpecs.SampleCount;
        var vSpaceDimensions = vectorMatrixList[0].ColumnCount;

        for (var sampleIndex = 0; sampleIndex < sampleCount; sampleIndex++)
        {
            var index = sampleIndex;

            var matrix = (Matrix)Matrix.Build.Dense(
                vSpaceDimensions,
                vectorCount,
                (i, j) => vectorMatrixList[j][index, i]
            );

            var rank = matrix.Rank();

            var c = matrix.ColumnAbsoluteSums();
            var colList = new List<int>(c.Count);
            for (var i = 0; i < c.Count; i++)
                if (c[i] != 0) colList.Add(i);

            var gramSchmidt = Matrix.Build.Dense(
                vSpaceDimensions,
                rank,
                (i, j) => j < colList.Count ? matrix[i, colList[j]] : 0d
            ).GramSchmidt();

            //if (rank >= 3)
            //{
            //    Console.WriteLine($"Q: {gramSchmidt.Q}");
            //    Console.WriteLine($"R: {gramSchmidt.R}");
            //}

            var orthogonalMatrix = gramSchmidt.Q;
            var vectorNorms = gramSchmidt.R.Diagonal();

            for (var j = 0; j < vectorCount; j++)
            {
                var vectorMatrix = vectorMatrixList[j];

                if (j < orthogonalMatrix.ColumnCount)
                {
                    var vectorNorm =
                        makeUnitVectors ? 1d : vectorNorms[j];

                    for (var i = 0; i < orthogonalMatrix.RowCount; i++)
                        vectorMatrix[index, i] = vectorNorm * orthogonalMatrix[i, j];
                }
                else
                {
                    for (var i = 0; i < orthogonalMatrix.RowCount; i++)
                        vectorMatrix[index, i] = 0d;
                }
            }
        }

        var orthogonalVectors =
            vectorMatrixList.Select(matrix =>
                processor.ToXGaVectorSignal(
                    matrix, 
                    vSpaceDimensions, 
                    samplingRate
                )
            );

        return makeUnitVectors
            ? orthogonalVectors.Select(v => v.DivideByNorm()).ToArray()
            : orthogonalVectors.ToArray();
    }

    /// <summary>
    /// Apply the Gram-Schmidt process using classical vector projection
    /// See here for more details:
    /// https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="vectorsList"></param>
    /// <param name="makeUnitVectors"></param>
    /// <returns></returns>
    public static IReadOnlyList<XGaVector<T>> ApplyGramSchmidtByProjections<T>(this IEnumerable<XGaVector<T>> vectorsList, bool makeUnitVectors)
    {
        var inputVectorsList = new List<XGaVector<T>>(
            vectorsList.Where(v => !v.IsNearZero())
        );

        var outputVectorsList = new List<XGaVector<T>>(inputVectorsList.Count)
        {
            inputVectorsList[0]
        };

        for (var i = 1; i < inputVectorsList.Count; i++)
        {
            var vector = outputVectorsList.Aggregate(
                inputVectorsList[i],
                (current, projectionVector) =>
                    current - current.ProjectOn(projectionVector.ToSubspace())
            );

            // If the new vector is linearly dependent on the previous ones, ignore it
            if (vector.IsNearZero())
                continue;

            outputVectorsList.Add(vector);
        }

        return makeUnitVectors
            ? outputVectorsList.Select(v => v.DivideByNorm()).ToArray()
            : outputVectorsList;
    }

    public static Pair<XGaVector<T>> ApplyGramSchmidtByProjections<T>(this XGaVector<T> v1, XGaVector<T> v2, bool makeUnitVectors)
    {
        var vectorsList = (new[] { v1, v2 }).ApplyGramSchmidtByProjections(
            makeUnitVectors
        );

        var zeroVector = v1.Processor.CreateZeroVector();

        return vectorsList.Count switch
        {
            0 => new Pair<XGaVector<T>>(zeroVector, zeroVector),
            1 => new Pair<XGaVector<T>>(vectorsList[0], zeroVector),
            _ => new Pair<XGaVector<T>>(vectorsList[0], vectorsList[1])
        };
    }

    public static Triplet<XGaVector<T>> ApplyGramSchmidtByProjections<T>(this XGaVector<T> v1, XGaVector<T> v2, XGaVector<T> v3, bool makeUnitVectors)
    {
        var vectorsList = (new[] { v1, v2, v3 }).ApplyGramSchmidtByProjections(
            makeUnitVectors
        );

        var zeroVector = v1.Processor.CreateZeroVector();

        return vectorsList.Count switch
        {
            0 => new Triplet<XGaVector<T>>(zeroVector, zeroVector, zeroVector),
            1 => new Triplet<XGaVector<T>>(vectorsList[0], zeroVector, zeroVector),
            2 => new Triplet<XGaVector<T>>(vectorsList[0], vectorsList[1], zeroVector),
            _ => new Triplet<XGaVector<T>>(vectorsList[0], vectorsList[1], vectorsList[2])
        };
    }

    public static Quad<XGaVector<T>> ApplyGramSchmidtByProjections<T>(this XGaVector<T> v1, XGaVector<T> v2, XGaVector<T> v3, XGaVector<T> v4, bool makeUnitVectors)
    {
        var vectorsList = (new[] { v1, v2, v3, v4 }).ApplyGramSchmidtByProjections(
            makeUnitVectors
        );

        var zeroVector = v1.Processor.CreateZeroVector();

        return vectorsList.Count switch
        {
            0 => new Quad<XGaVector<T>>(zeroVector, zeroVector, zeroVector, zeroVector),
            1 => new Quad<XGaVector<T>>(vectorsList[0], zeroVector, zeroVector, zeroVector),
            2 => new Quad<XGaVector<T>>(vectorsList[0], vectorsList[1], zeroVector, zeroVector),
            3 => new Quad<XGaVector<T>>(vectorsList[0], vectorsList[1], vectorsList[2], zeroVector),
            _ => new Quad<XGaVector<T>>(vectorsList[0], vectorsList[1], vectorsList[2], vectorsList[3])
        };
    }

    public static Quint<XGaVector<T>> ApplyGramSchmidtByProjections<T>(this XGaVector<T> v1, XGaVector<T> v2, XGaVector<T> v3, XGaVector<T> v4, XGaVector<T> v5, bool makeUnitVectors)
    {
        var vectorsList = (new[] { v1, v2, v3, v4, v5 }).ApplyGramSchmidtByProjections(
            makeUnitVectors
        );

        var zeroVector = v1.Processor.CreateZeroVector();

        return vectorsList.Count switch
        {
            0 => new Quint<XGaVector<T>>(zeroVector, zeroVector, zeroVector, zeroVector, zeroVector),
            1 => new Quint<XGaVector<T>>(vectorsList[0], zeroVector, zeroVector, zeroVector, zeroVector),
            2 => new Quint<XGaVector<T>>(vectorsList[0], vectorsList[1], zeroVector, zeroVector, zeroVector),
            3 => new Quint<XGaVector<T>>(vectorsList[0], vectorsList[1], vectorsList[2], zeroVector, zeroVector),
            4 => new Quint<XGaVector<T>>(vectorsList[0], vectorsList[1], vectorsList[2], vectorsList[3], zeroVector),
            _ => new Quint<XGaVector<T>>(vectorsList[0], vectorsList[1], vectorsList[2], vectorsList[3], vectorsList[4])
        };
    }

    public static Hexad<XGaVector<T>> ApplyGramSchmidtByProjections<T>(this XGaVector<T> v1, XGaVector<T> v2, XGaVector<T> v3, XGaVector<T> v4, XGaVector<T> v5, XGaVector<T> v6, bool makeUnitVectors)
    {
        var vectorsList = (new[] { v1, v2, v3, v4, v5, v6 }).ApplyGramSchmidtByProjections(
            makeUnitVectors
        );

        var zeroVector = v1.Processor.CreateZeroVector();

        return vectorsList.Count switch
        {
            0 => new Hexad<XGaVector<T>>(zeroVector, zeroVector, zeroVector, zeroVector, zeroVector, zeroVector),
            1 => new Hexad<XGaVector<T>>(vectorsList[0], zeroVector, zeroVector, zeroVector, zeroVector, zeroVector),
            2 => new Hexad<XGaVector<T>>(vectorsList[0], vectorsList[1], zeroVector, zeroVector, zeroVector, zeroVector),
            3 => new Hexad<XGaVector<T>>(vectorsList[0], vectorsList[1], vectorsList[2], zeroVector, zeroVector, zeroVector),
            4 => new Hexad<XGaVector<T>>(vectorsList[0], vectorsList[1], vectorsList[2], vectorsList[3], zeroVector, zeroVector),
            5 => new Hexad<XGaVector<T>>(vectorsList[0], vectorsList[1], vectorsList[2], vectorsList[3], vectorsList[4], zeroVector),
            _ => new Hexad<XGaVector<T>>(vectorsList[0], vectorsList[1], vectorsList[2], vectorsList[3], vectorsList[4], vectorsList[5])
        };
    }
}