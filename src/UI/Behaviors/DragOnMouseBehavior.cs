using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace Rogue.HeartTracker.UI.Behaviors
{
    public class DragOnMouseBehavior : Behavior<Window>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.MouseDown += AssociatedObjectOnMouseDown;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.MouseDown -= AssociatedObjectOnMouseDown;
        }

        private void AssociatedObjectOnMouseDown(object sender, MouseButtonEventArgs mouseButtonEventArgs)
        {
            AssociatedObject.DragMove();
        }
    }
}
