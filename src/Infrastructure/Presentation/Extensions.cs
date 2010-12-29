using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Rogue.HeartTracker.Infrastructure.Presentation
{
    public static class Extensions
    {
        public static void OnPropertyChanged<TViewModel, TProp>(this TViewModel vm,
                                                                Expression<Func<TViewModel, TProp>> expression)
            where TViewModel : IRaisePropertyChanged
        {
            vm.RaisePropertyChanged(expression.PropertyName());
        }
    }
}
