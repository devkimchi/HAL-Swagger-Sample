using System;

using WebApi.Hal;

namespace HalSwaggerSample.HalApiApp.Helpers
{
    /// <summary>
    /// This represents the helper entity for formatters.
    /// </summary>
    public static class FilterHelper
    {
        /// <summary>
        /// Checks whether the given type is either <see cref="Representation" /> or <see cref="SimpleListRepresentation{TResource}" />.
        /// </summary>
        /// <param name="type">Type to check.</param>
        /// <returns>Returns <c>True</c>, if the given type is either <see cref="Representation" /> or <see cref="SimpleListRepresentation{TResource}" />; otherwise returns <c>False</c>.</returns>
        public static bool IsSupportedType(Type type)
        {
            var isResourceType = IsResourceType(type);
            var isResourceCollectionType = IsResourceCollectionType(type);

            return isResourceType || isResourceCollectionType;
        }

        /// <summary>
        /// Checks whether the given type is <see cref="Representation" />.
        /// </summary>
        /// <param name="type">Type to check.</param>
        /// <returns>Returns <c>True</c>, if the given type is either <see cref="Representation" />; otherwise returns <c>False</c>.</returns>
        public static bool IsResourceType(Type type)
        {
            return type.IsSubclassOf(typeof(Representation));
        }

        /// <summary>
        /// Checks whether the given type is <see cref="SimpleListRepresentation{TResource}" />.
        /// </summary>
        /// <param name="type">Type to check.</param>
        /// <returns>Returns <c>True</c>, if the given type is <see cref="SimpleListRepresentation{TResource}" />; otherwise returns <c>False</c>.</returns>
        public static bool IsResourceCollectionType(Type type)
        {
            var typeToCheck = type;
            while (typeToCheck != null && typeToCheck != typeof(object))
            {
                var currentType = typeToCheck.IsGenericType ? typeToCheck.GetGenericTypeDefinition() : typeToCheck;
                if (currentType == typeof(SimpleListRepresentation<>))
                {
                    return true;
                }

                typeToCheck = typeToCheck.BaseType;
            }

            return false;
        }
    }
}