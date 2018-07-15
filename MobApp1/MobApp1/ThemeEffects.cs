using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace ThemesDemo
{
    public static class ThemeEffects
    {
        public static readonly BindableProperty CornerRadiusProperty =
          BindableProperty.CreateAttached("CornerRadius", typeof(double), typeof(ThemeEffects), 0.0, propertyChanged: OnChanged<CornerRadiusEffect, double>);
        private static void OnChanged<TEffect, TProp>(BindableObject bindable, object oldValue, object newValue)
                  where TEffect : Effect, new()
        {
            var view = bindable as View;
            if (view == null)
            {
                return;
            }

            if (EqualityComparer<TProp>.Equals(newValue, default(TProp)))
            {
                var toRemove = view.Effects.FirstOrDefault(e => e is TEffect);
                if (toRemove != null)
                {
                    view.Effects.Remove(toRemove);
                }
            }
            else
            {
                view.Effects.Add(new TEffect());
            }

        }
        public static void SetCornerRadius(BindableObject view, double radius)
        {
            view.SetValue(CornerRadiusProperty, radius);
        }

        public static double GetCornerRadius(BindableObject view)
        {
            return (double)view.GetValue(CornerRadiusProperty);
        }

        private class CornerRadiusEffect : RoutingEffect
        {
            public CornerRadiusEffect()
                : base("Xamarin.CornerRadiusEffect")
            {
            }
        }
    }
}
