﻿namespace VivAnimate.Effects.Other
{
    public class FontSizeEffect : IEffect
    {
        public EffectInteractions Interaction
        {
            get => EffectInteractions.SIZE;
        }

        public int GetCurrentValue(Control control) => (int)control.Font.SizeInPoints;

        public void SetValue(Control control, int originalValue, int valueToReach, int newValue)
        {
            control.Font = new System.Drawing.Font(control.Font.FontFamily, newValue);
        }

        public int GetMinimumValue(Control control) => 0;

        public int GetMaximumValue(Control control) => int.MaxValue;
    }
}
