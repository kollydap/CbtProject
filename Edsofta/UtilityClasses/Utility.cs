using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Edsofta.UtilityClasses
{
    public static class Utility
    {
        public static T GetParentOfType<T>(this DependencyObject depObj)
            where T : DependencyObject
        {
            if (depObj == null) return null;

            T parent = null;
            var currentParent = VisualTreeHelper.GetParent(depObj);
            while (currentParent != null && parent == null)
            {
                parent = currentParent as T;
                currentParent = VisualTreeHelper.GetParent(currentParent);
            }

            return parent;
        }

    }
}
