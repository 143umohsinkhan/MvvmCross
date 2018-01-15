﻿// IMvxViewTypeResolver.cs

// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System;

namespace MvvmCross.Binding.Droid.Binders.ViewTypeResolvers
{
    public interface IMvxViewTypeResolver
    {
        Type Resolve(string tagName);
    }
}