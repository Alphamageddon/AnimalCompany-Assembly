// Decompiled with Xera AI Decompiler
using UnityEngine;

namespace AnimalCompany
{
    public class ColorManager
    {
        public static Color viewRangeColor;
        public static Color viewPointColor;
        public static Color hearingRangeColor;
        public static Color aiNodeColor;
        public static Color aiNodeColorExplored;
        public static Color searchingLineColor;
        public static Color serachingLineNextColor;
        public static Color searchPrecisionColor;
        public static Color searchWidthColor;
        public static Color navMeshDestinationColor;
        public static Color bodyRangeColor;
        public static Color attackRangeColor;
        public static Color targetPositionColor;

        static ColorManager()
        {
            viewRangeColor = new Color(1f, 0f, 0f, 0.3f);
            viewPointColor = new Color(0f, 1f, 0f, 0.8f);
            hearingRangeColor = new Color(0f, 0f, 1f, 0.2f);
            aiNodeColor = new Color(1f, 1f, 0f, 0.5f);
            aiNodeColorExplored = new Color(0.5f, 0.5f, 0.5f, 0.5f);
            searchingLineColor = new Color(1f, 0.5f, 0f, 0.7f);
            serachingLineNextColor = new Color(0.5f, 1f, 0f, 0.7f);
            searchPrecisionColor = new Color(0f, 1f, 1f, 0.4f);
            searchWidthColor = new Color(1f, 0f, 1f, 0.4f);
            navMeshDestinationColor = new Color(0.8f, 0.2f, 0.8f, 0.6f);
            bodyRangeColor = new Color(0.2f, 0.8f, 0.2f, 0.3f);
            attackRangeColor = new Color(1f, 0.2f, 0.2f, 0.5f);
            targetPositionColor = new Color(0.9f, 0.9f, 0.1f, 0.8f);
        }

        public ColorManager()
        {
        }
    }
}