using System;
using System.Linq.Expressions;

namespace Rogue.HeartTracker.Infrastructure
{
    public static class Extensions
    {
        public static string PropertyName<TObj, TRet>(this Expression<Func<TObj, TRet>> func)
        {
            var expr = func.Body as MemberExpression;
            if (expr == null)
            {
                throw new ArgumentException("Expression must be property access");
            }

            return expr.Member.Name;
        }
    }
}
