using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorVintageKit
{
    public class DialOptions
    {
        /// <summary>
        /// The radius of the dial relative to the SVG viewbox. Default is 45
        /// </summary>
        public int DialRadius { get; set; } = 45;

        /// <summary>
        /// The maximum value of the dial. Defauls is 10000;
        /// </summary>
        public int DialRange { get; set; } = 10000;

        /// <summary>
        /// The current value of the dial. This is the property to set to alter the pointer position.
        /// </summary>
        public int DialValue { get; set; } = 0;

        /// <summary>
        /// The arc angle that the dial face uses. Specified in degrees. Default is 270.
        /// </summary>
        public double FaceArcAngle { get; set; } = 270;

        /// <summary>
        /// The radius of the face markings relative to the SVG viewbox. Default is 45
        /// </summary>
        public int FaceRadius { get; set; } = 40;

        /// <summary>
        /// Specifies an additional rotation to apply to the entire face. Specified in degrees.
        /// </summary>
        public int AdditionalRotation { get; set; }

        /// <summary>
        /// The background colour of the dial. Specify a hexcode or colour name. Default is black.
        /// </summary>
        public string DialColour { get; set; } = "black";

        /// <summary>
        /// The colour of the dial rim. Specify a hexcode or colour name. Default is #666666.
        /// </summary>
        public string RimColour { get; set; } = "#666666";

        /// <summary>
        /// The colour of the face markings. Specify a hexcode or colour name. Default is white.
        /// </summary>
        public string FaceColour { get; set; } = "white";

        /// <summary>
        /// The colour of the risk segment. Specify a hexcode or colour name. Default is #BF1818.
        /// </summary>
        public string RiskColour { get; set; } = "#BF1818";

        /// <summary>
        /// The colour of the pointer. Specify a hexcode or colour name. Default is #FFFF00.
        /// </summary>
        public string Pointercolour { get; set; } = "#FFFF00";

        /// <summary>
        /// The colour of the reset pointer. Specify a hexcode or colour name. Default is #FF0000.
        /// </summary>
        public string ResetPointercolour { get; set; } = "#FF0000";

        /// <summary>
        /// The colour of the reset button. Specify a hexcode or colour name. Default is #2E2E2E.
        /// </summary>
        public string ResetButtonColour { get; set; } = "#2E2E2E";

        /// <summary>
        /// The colour of the outer boss. Specify a hexcode or colour name. Default is #FFFF00.
        /// </summary>
        public string BossColour { get; set; } = "#FFFF00";

        /// <summary>
        /// The colour of the boss center. Specify a hexcode or colour name. Default is black.
        /// </summary>
        public string BossCenterColour { get; set; } = "black";

        /// <summary>
        /// The width of the rim relative to the SVG viewbox. Default is 2
        /// </summary>
        public double RimWidth { get; set; } = 2;

        /// <summary>
        /// The number of indicator marks (and text labels) on the dial. Default is 11.
        /// </summary>
        public int IndicatorCount { get; set; } = 11;

        /// <summary>
        /// The number of subindicators between each indicator. Default is 4.
        /// </summary>
        public int SubIndicatorCount { get; set; } = 4;

        /// <summary>
        /// The length of each subindicator relative to the SVG viewbox. Default is 5.
        /// </summary>
        public double SubIndicatorLength { get; set; } = 5;

        /// <summary>
        /// The Y axis offset to apply to labels relative to the SVG viewbox. Default is 2.
        /// </summary>
        public double LabelYOffset { get; set; } = 2;

        /// <summary>
        /// Additonal rotation to apply to label text in degree. Default is 0.
        /// </summary>
        public double LabelTextRotation { get; set; } = 0;

        /// <summary>
        /// Font size for label text. Default is 5.
        /// </summary>
        public double LabelFontSize { get; set; } = 5;

        /// <summary>
        /// Font name string for label text. Default is "Courier, monospace"
        /// </summary>
        public string LabelFont { get; set; } = "Courier, monospace";

        /// <summary>
        /// Flag that indicates whether the risk segment should be drawn. Default is true.
        /// </summary>
        public bool RiskMode { get; set; } = true;

        /// <summary>
        /// Additional rotation to apply to the risk segment in degroes. Default is 0.
        /// </summary>
        public double RiskAdditionalRotation { get; set; }

        /// <summary>
        /// The arc of the risk segment in degrees. Default is 54.
        /// </summary>
        public int RiskAngle { get; set; } = 54;

        /// <summary>
        /// Flag that indicates whether the face inner ring should be drawn. This ring is drawn outside the face marks. Default is false.
        /// </summary>
        public bool InnerRing { get; set; }

        /// <summary>
        /// Flag that indicates whether the face smiths ring should be drawn. This is secondary inner ring that is drawn inside the face marks. Default is false.
        /// </summary>
        public bool SmithsMode { get; set; }

        /// <summary>
        /// Flag that indicates whether the reset pointer and reset button should be drawn. Default is false.
        /// </summary>
        public bool ResetPointerMode { get; set; }

        /// <summary>
        /// Flag that indicates whether the alternative floating pointer should be drawn. This disables the boss. Default is false.
        /// </summary>
        public bool AlternatePointer { get; set; }

        /// <summary>
        /// This flag indicates if the dial should operate in anti-clockwise mode. Default is false.
        /// </summary>
        public bool ReverseMode { get; set; }

        //public bool RobMode { get; set; }

        public string MakersLabel { get; set; } = "B.V.K.";
        public string MakersLabelFont { get; set; } = "Courier, monospace";
        public double MakersLabelFontSize { get; set; } = 5;
        public string KeyLabel { get; set; } = "RPM x 100";
        public string KeyLabelFont { get; set; } = "Courier, monospace";
        public double KeyLabelFontSize { get; set; } = 5;
        public double KeyLabelX { get; set; } = 0;
        public double KeyLabelY { get; set; } = 25;
        public double MakersLabelX { get; set; } = 0;
        public double MakersLabelY { get; set; } = 10;

        public double PointerLengthAdjust { get; set; } = 0;
        public double PointerTailLengthAdjust { get; set; } = 0;
    }
}
