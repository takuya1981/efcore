// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microsoft.EntityFrameworkCore.Metadata
{
    /// <summary>
    ///     <para>
    ///         Represents a navigation property that is part of a relationship
    ///         that is forwarded through a third entity type.
    ///     </para>
    ///     <para>
    ///         This interface is used during model creation and allows the metadata to be modified.
    ///         Once the model is built, <see cref="ISkipNavigation" /> represents a read-only view of the same metadata.
    ///     </para>
    /// </summary>
    public interface IConventionSkipNavigation : ISkipNavigation, IConventionPropertyBase
    {
        /// <summary>
        ///     Gets the builder that can be used to configure this property.
        /// </summary>
        IConventionSkipNavigationBuilder Builder { get; }

        /// <summary>
        ///     Gets the type that this navigation property belongs to.
        /// </summary>
        new IConventionEntityType DeclaringEntityType => (IConventionEntityType)((ISkipNavigation)this).DeclaringEntityType;

        /// <summary>
        ///     Gets the entity type that this navigation property will hold an instance(s) of.
        /// </summary>
        new IConventionEntityType TargetEntityType => (IConventionEntityType)((ISkipNavigation)this).TargetEntityType;

        /// <summary>
        ///     Gets the association type used by the foreign key.
        /// </summary>
        new IConventionEntityType AssociationEntityType => (IConventionEntityType)((ISkipNavigation)this).AssociationEntityType;

        /// <summary>
        ///     Returns the configuration source for this property.
        /// </summary>
        /// <returns> The configuration source. </returns>
        ConfigurationSource GetConfigurationSource();

        /// <summary>
        ///     Gets the foreign key to the association type.
        /// </summary>
        new IConventionForeignKey ForeignKey => (IConventionForeignKey)((ISkipNavigation)this).ForeignKey;

        /// <summary>
        ///     Sets the foreign key.
        /// </summary>
        /// <param name="foreignKey">
        ///     The foreign key. Passing <c>null</c> will result in there being no foreign key associated.
        /// </param>
        /// <param name="fromDataAnnotation"> Indicates whether the configuration was specified using a data annotation. </param>
        IConventionForeignKey SetForeignKey([CanBeNull] IConventionForeignKey foreignKey, bool fromDataAnnotation = false);

        /// <summary>
        ///     Returns the configuration source for <see cref="ForeignKey" />.
        /// </summary>
        /// <returns> The configuration source for <see cref="ForeignKey" />. </returns>
        ConfigurationSource? GetForeignKeyConfigurationSource();

        /// <summary>
        ///     Gets the inverse skip navigation.
        /// </summary>
        new IConventionSkipNavigation Inverse => (IConventionSkipNavigation)((ISkipNavigation)this).Inverse;

        /// <summary>
        ///     Sets the inverse skip navigation.
        /// </summary>
        /// <param name="inverse">
        ///     The inverse skip navigation. Passing <c>null</c> will result in there being no inverse navigation property defined.
        /// </param>
        /// <param name="fromDataAnnotation"> Indicates whether the configuration was specified using a data annotation. </param>
        IConventionSkipNavigation SetInverse([CanBeNull] IConventionSkipNavigation inverse, bool fromDataAnnotation = false);

        /// <summary>
        ///     Returns the configuration source for <see cref="Inverse" />.
        /// </summary>
        /// <returns> The configuration source for <see cref="Inverse" />. </returns>
        ConfigurationSource? GetInverseConfigurationSource();
    }
}
