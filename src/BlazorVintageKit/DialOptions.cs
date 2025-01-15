using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorVintageKit
{
    public class DialOptions
    {
        public int DialRadius { get; set; } = 45;
        public int DialRange { get; set; } = 10000;
        public int DialValue { get; set; } = 0;

        public double FaceArcAngle { get; set; } = 270;
        public int FaceRadius { get; set; } = 40;
        public int AdditionalRotation { get; set; }

        public string DialColour { get; set; } = "#000000";
        public string RimColour { get; set; } = "#666666";
        public string FaceColour { get; set; } = "#FFFFFF";
        public string RiskColour { get; set; } = "#BF1818";
        public string Pointercolour { get; set; } = "#FFFF00";
        public string ResetPointercolour { get; set; } = "#FF0000";
        public string ResetButtonColour { get; set; } = "#2E2E2E";
        public string BossColour { get; set; } = "#FFFFFF";
        public string BossCenterColour { get; set; } = "#000000";
        public double RimWidth { get; set; } = 2;

        public int IndicatorCount { get; set; } = 10;
        public int SubIndicatorCount { get; set; } = 4;
        public double SubIndicatorLength { get; set; } = 5;

        public int LabelYOffset { get; set; } = 2;
        public int LabelTextRotation { get; set; } = 0;
        public double LabelFontSize { get; set; } = 5;
        public string LabelFont { get; set; } = "Courier, monospace";

        public bool RiskMode { get; set; } = true;
        public int RiskAdditionalRotation { get; set; }
        public int RiskAngle { get; set; } = 45;

        public bool InnerRing { get; set; }
        public bool SmithsMode { get; set; }
        public bool ResetPointerMode { get; set; }
        public bool AlternatePointer { get; set; }
        public bool ReverseMode { get; set; }

        public string MakersLabel { get; set; } = "B.V.K.";
        public string MakersLabelFont { get; set; } = "Courier, monospace";
        public double MakersLabelFontSize { get; set; } = 5;
        public string KeyLabel { get; set; } = "RPM x 100";
        public string KeyLabelFont { get; set; } = "Courier, monospace";
        public double KeyLabelFontSize { get; set; } = 5;
        public int KeyLabelX { get; set; } = 0;
        public int KeyLabelY { get; set; } = 25;
        public int MakersLabelX { get; set; } = 0;
        public int MakersLabelY { get; set; } = 10;

        public double PointerLengthAdjust { get; set; } = 0;
        public double PointerTailLengthAdjust { get; set; } = 0;
    }
}
