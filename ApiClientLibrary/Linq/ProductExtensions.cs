using System;
using System.Linq.Expressions;

using ApiClientLibrary.DTOs;
using ApiClientLibrary.Models;

namespace ApiClientLibrary.Linq
{
    internal static class ProductExtensions
    {
        public static T GetProperty<T>(this Product product, Expression<Func<ProductComparisonPartialDto, T>> predicate)
            where T : IConvertible
        {
            if (!(predicate.Body is MemberExpression memberExpression))
            {
                return default(T);
            }

            var property = product.GetType().GetProperty(memberExpression.Member.Name);

            if (property == null)
            {
                return default(T);
            }

            return (T)Convert.ChangeType(property.GetValue(product), typeof(T));
        }

        public static T GetProperty<T>(this Product product, Expression<Func<ProductComparisonProductDto, T>> predicate)
            where T : IConvertible
        {
            if (!(predicate.Body is MemberExpression memberExpression))
            {
                return default(T);
            }

            var property = product.GetType().GetProperty(memberExpression.Member.Name);

            if (property == null)
            {
                return default(T);
            }

            return (T)Convert.ChangeType(property.GetValue(product), typeof(T));
        }

        public static T GetProperty<T>(this Product product, Expression<Func<ProductListItemDto, T>> predicate)
            where T : IConvertible
        {
            if (!(predicate.Body is MemberExpression memberExpression))
            {
                return default(T);
            }

            var property = product.GetType().GetProperty(memberExpression.Member.Name);

            if (property == null)
            {
                return default(T);
            }

            return (T)Convert.ChangeType(property.GetValue(product), typeof(T));
        }
    }
}