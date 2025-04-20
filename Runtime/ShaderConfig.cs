//-----------------------------------------------------------------------------
// Configuration
//-----------------------------------------------------------------------------
using System;

namespace UnityEngine.Rendering.Universal
{
    /// <summary>
    /// Project-wide shader configuration options.
    /// </summary>
    /// <remarks>This enum will generate the proper shader defines.</remarks>
    ///<seealso cref="ShaderConfig"/>
    [GenerateHLSL]
    public static class ShaderOptions
    {
        /// <summary>Max number of lights supported on mobile with OpenGL 3.0 and below.</summary>
        public const int k_MaxVisibleLightCountLowEndMobile = 16; // Default - 16. Wanted - 2*6 => 12 (2 point lights)

        /// <summary>Max number of lights supported on mobile, OpenGL, and WebGPU platforms.</summary>
        public const int k_MaxVisibleLightCountMobile = 32; // Default - 32. Wanted - 4*6 => 24 (4 point lights)

        /// <summary>Max number of lights supported on desktop platforms.</summary>
        public const int k_MaxVisibleLightCountDesktop = 64; // Default - 256. Wanted - 8*6 => 48 (8 point lights)
    };
}
