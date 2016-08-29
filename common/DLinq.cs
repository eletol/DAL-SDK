using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Web;

namespace DAL.SDK.common
{
    public static class DLinq 
    {
        public static IQueryable Where(this IQueryable source, string predicate, params object[] values)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (predicate == null) throw new ArgumentNullException("predicate");
            System.Linq.Expressions.LambdaExpression lambda = DynamicExpression.ParseLambda(source.ElementType, typeof(bool), predicate, values);
            return source.Provider.CreateQuery(
                System.Linq.Expressions.Expression.Call(
                    typeof(Queryable), "Where",
                    new Type[] { source.ElementType },
                    source.Expression, System.Linq.Expressions.Expression.Quote(lambda)));
        }

    }
}
