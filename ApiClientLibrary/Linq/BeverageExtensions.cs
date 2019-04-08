using System;
using System.Linq.Expressions;

using ApiClientLibrary.DTOs;
using ApiClientLibrary.Models;

namespace ApiClientLibrary.Linq
{
    internal static class BeverageExtensions
    {
        public static T GetProperty<T>(this Beverage beverage, Expression<Func<BeverageComparisonPartialDto, T>> predicate)
            where T : IConvertible
        {
            if (!(predicate.Body is MemberExpression memberExpression))
            {
                return default(T);
            }

            var property = beverage.GetType().GetProperty(memberExpression.Member.Name);

            if (property == null)
            {
                return default(T);
            }

            return (T)Convert.ChangeType(property.GetValue(beverage), typeof(T));
        }

        public static T GetProperty<T>(this Beverage beverage, Expression<Func<BeverageComparisonProductDto, T>> predicate)
            where T : IConvertible
        {
            if (!(predicate.Body is MemberExpression memberExpression))
            {
                return default(T);
            }

            var property = beverage.GetType().GetProperty(memberExpression.Member.Name);

            if (property == null)
            {
                return default(T);
            }

            return (T)Convert.ChangeType(property.GetValue(beverage), typeof(T));
        }

        public static T GetProperty<T>(this Beverage beverage, Expression<Func<BeverageListItemDto, T>> predicate)
            where T : IConvertible
        {
            if (!(predicate.Body is MemberExpression memberExpression))
            {
                return default(T);
            }

            var property = beverage.GetType().GetProperty(memberExpression.Member.Name);

            if (property == null)
            {
                return default(T);
            }

            return (T)Convert.ChangeType(property.GetValue(beverage), typeof(T));
        }
    }
}