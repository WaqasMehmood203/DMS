using System.Linq.Expressions;

namespace DMS.DAL
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> Paginate<T>(this IQueryable<T> query, int pageNumber, int pageSize)
        {
            return query.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        }

        // Existing OrderByCustom method
        public static IOrderedQueryable<T> OrderByCustom<T>(this IQueryable<T> query, string memberName, bool asc = true)
        {
            ParameterExpression[] typeParams = new ParameterExpression[] { Expression.Parameter(typeof(T), "") };

            System.Reflection.PropertyInfo pi = typeof(T).GetProperty(memberName);

            return (IOrderedQueryable<T>)query.Provider.CreateQuery(
                Expression.Call(
                    typeof(Queryable),
                    asc ? "OrderBy" : "OrderByDescending",
                    new Type[] { typeof(T), pi.PropertyType },
                    query.Expression,
                    Expression.Lambda(Expression.Property(typeParams[0], pi), typeParams)
                )
            );
        }
    }
}
