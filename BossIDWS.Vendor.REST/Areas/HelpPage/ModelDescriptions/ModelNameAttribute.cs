using System;

#pragma warning disable 1591

namespace BossIDWS.Vendor.REST.Areas.HelpPage.ModelDescriptions
{
    /// <summary>
    ///     Use this attribute to change the name of the <see cref="ModelDescription" /> generated for a type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, Inherited = false)]
    public sealed class ModelNameAttribute : Attribute
    {
        public ModelNameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}