using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorVintageKit
{
    public record VintageButtonOptions(
        int Width = 120,
        int Height = 36,
        int Bevel = 3,
        int DropPx = 1,
        string Face = "#181818",
        string TopHi = "#383838",
        string LeftHi = "#2e2e2e",
        string BottomLo = "#0a0a0a",
        string RightLo = "#050505",
        string Accent = "lime",
        double GlossStrength = 0.15,
        string FontFamily = "system-ui, Segoe UI, Arial",
        int FontSize = 16,
        bool LabelGlow = false,                      // ← optional VFD glow
        double LabelGlowBlur = 2.5)                   // px
    {
        // Presets
        public static VintageButtonOptions DarkStereo() => new();
        
        public static VintageButtonOptions Metallic() => new(
            Face: "#202224", TopHi: "#5a5e62", LeftHi: "#4b4f53",
            BottomLo: "#0b0c0d", RightLo: "#0b0c0d", GlossStrength: 0.25
        );
    }

}
