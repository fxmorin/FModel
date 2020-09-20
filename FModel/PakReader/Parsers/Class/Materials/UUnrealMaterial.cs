﻿using System.Collections.Generic;
using PakReader.Materials;

namespace PakReader.Parsers.Class.Materials
{
    public abstract class UUnrealMaterial : UObject
    {
        internal UUnrealMaterial(PackageReader reader) : base(reader)
        {
        }

        public bool IsTextureCube { get; } = false;

        public abstract void GetParams(CMaterialParams parameters);

        public virtual void AppendReferencedTextures(List<UUnrealMaterial> outTextures, bool onlyRendered)
        {
            var parameters = new CMaterialParams();
            GetParams(parameters);
            parameters.AppendAllTextures(outTextures);
        }
    }
}