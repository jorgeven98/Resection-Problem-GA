﻿using GeometricAlgebraFulcrumLib.MetaProgramming.Context;

namespace GeometricAlgebraFulcrumLib.MetaProgramming.Composers;

/// <summary>
/// This class can be used to generate a single base macro or a set of related macros into a single code file. 
/// Several related bindings of the same macro or related macros can be generated by several calls to the 
/// GenerateComputationsCode() method with varying binding and target naming results depending on more derived 
/// class parameters. The SetBaseMetaContext() method can be called to change the base macro before calling the
/// GenerateComputationsCode() method.
/// </summary>
public abstract class GaFuLMetaContextCodeFileComposerBase : 
    GaFuLCodePartFileComposerBase
{
    protected GaFuLMetaContextCodeFileComposerBase(GaFuLCodeLibraryComposerBase codeLibraryComposer)
        : base(codeLibraryComposer)
    {
    }


    protected virtual void SetContextOptions(MetaContextOptions options)
    {
    }

    protected abstract void DefineContextParameters(MetaContext context);

    protected abstract void DefineContextComputations(MetaContext context);

    protected abstract void DefineContextExternalNames(MetaContext context);

    protected virtual void SetContextCodeComposerOptions(GaFuLMetaContextCodeComposerOptions options)
    {
    }


    protected string GenerateCode()
    {
        var context = 
            new MetaContext(
                CodeComposer.DefaultContextOptions
            );

        SetContextOptions(context.ContextOptions);

        DefineContextParameters(context);

        DefineContextComputations(context);

        context.OptimizeContext();

        DefineContextExternalNames(context);

        var metaContextCodeComposer = 
            new GaFuLMetaContextCodeComposer(
                GeoLanguage, 
                context, 
                CodeComposer.DefaultContextCodeComposerOptions
            );

        SetContextCodeComposerOptions(metaContextCodeComposer.ComposerOptions);

        return metaContextCodeComposer.Generate();
    }
}