/* *********************************************************************
 * This Original Work is copyright of 51 Degrees Mobile Experts Limited.
 * Copyright 2023 51 Degrees Mobile Experts Limited, Davidson House,
 * Forbury Square, Reading, Berkshire, United Kingdom RG1 3EU.
 *
 * This Original Work is licensed under the European Union Public Licence
 * (EUPL) v.1.2 and is subject to its terms as set out below.
 *
 * If a copy of the EUPL was not distributed with this file, You can obtain
 * one at https://opensource.org/licenses/EUPL-1.2.
 *
 * The 'Compatible Licences' set out in the Appendix to the EUPL (as may be
 * amended by the European Commission) shall be deemed incompatible for
 * the purposes of the Work and the provisions of the compatibility
 * clause in Article 5 of the EUPL shall not apply.
 *
 * If using the Work as, or as part of, a network application, by
 * including the attribution notice(s) required under Article 5 of the EUPL
 * in the end user terms of the application under an appropriate heading,
 * such notice(s) shall fulfill the requirements of that article.
 * ********************************************************************* */

using FiftyOne.Pipeline.Engines.FiftyOne.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiftyOne.DeviceDetection.Shared.Data
{
    /// <summary>
    /// Data class that contains meta-data relating to a specific 
    /// component.
    /// See the <see href="https://github.com/51Degrees/specifications/blob/main/data-model-specification/README.md#component">Specification</see>
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Design",
        "CA1036:Override methods on comparable types",
        Justification = "Mathematical operator-style methods are not " +
        "appropriate for this class.")]
    public abstract class ComponentMetaDataDefault : IComponentMetaData
    {
        private List<IFiftyOneAspectPropertyMetaData> _properties;

        /// <summary>
        /// As this is a generated component, not a 'real' one. 
        /// It will always have Id = 255.
        /// </summary>
        public byte ComponentId => 255;

        /// <summary>
        /// The name of this component.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The default profile associated with this component.
        /// As this is a generated component rather than a 'real' one, this
        /// will always return null.
        /// </summary>
        public virtual IProfileMetaData DefaultProfile => null;

        /// <summary>
        /// Get the meta-data for all properties that are associated
        /// with this component.
        /// </summary>
        [Obsolete("Use the GetProperties method instead.")]
        public IReadOnlyList<IFiftyOneAspectPropertyMetaData> Properties => GetProperties().ToList();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">
        /// The name of this component
        /// </param>
        public ComponentMetaDataDefault(string name) : 
            this(name, new List<IFiftyOneAspectPropertyMetaData>())
        {}

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">
        /// The name of this component
        /// </param>
        /// <param name="properties">
        /// The meta-data for the properties associated with this component.
        /// </param>
        public ComponentMetaDataDefault(string name, 
            List<IFiftyOneAspectPropertyMetaData> properties)
        {
            Name = name;
            _properties = properties;
        }

        /// <summary>
        /// Add the specified property meta-data to the list of properties
        /// associated with this component.
        /// </summary>
        /// <param name="property">
        /// The meta-data to add.
        /// </param>
        public void AddProperty(IFiftyOneAspectPropertyMetaData property)
        {
            if (GetProperties().Any(p => p.Name == property.Name) == false)
            {
                _properties.Add(property);
            }
        }

        /// <summary>
        /// Compare this instance to another object that implements 
        /// <see cref="IComponentMetaData"/>.
        /// </summary>
        /// <param name="other">
        /// The <see cref="IComponentMetaData"/> instance to compare to.
        /// </param>
        /// <returns>
        /// &gt;0 if this instance precedes `other` in the sort order.
        /// 0 if they are equal in the sort order.
        /// &lt;0 if `other` precedes this instance in the sort order.
        /// </returns>
        public int CompareTo(IComponentMetaData other)
        {
            if (other == null) return -1;
            return ComponentId.CompareTo(other.ComponentId);
        }
        
        /// <summary>
        /// Check if this instance is equal to another object that 
        /// implements <see cref="IComponentMetaData"/>.
        /// </summary>
        /// <param name="other">
        /// The <see cref="IComponentMetaData"/> to check for equality
        /// </param>
        /// <returns>
        /// True if the two instances are equal.
        /// False otherwise
        /// </returns>
        public bool Equals(IComponentMetaData other)
        {
            if (other == null) return false;
            return ComponentId.Equals(other.ComponentId);
        }

        /// <summary>
        /// Get the meta-data for all properties associated with this
        /// component.
        /// </summary>
        /// <returns>
        /// An <see cref="IEnumerable{T}"/> containing meta-data for all
        /// properties associated with this component.
        /// </returns>
        public IEnumerable<IFiftyOneAspectPropertyMetaData> GetProperties()
        {
            return _properties;
        }

        /// <summary>
        /// Get the meta-data for the specified property.
        /// </summary>
        /// <param name="propertyName">
        /// The name of the property to get meta-data for.
        /// </param>
        /// <returns>
        /// A meta-data instance for the requested property or null if
        /// no match was found.
        /// </returns>
        public IFiftyOneAspectPropertyMetaData GetProperty(string propertyName)
        {
            return _properties.SingleOrDefault(p => p.Name == propertyName);
        }

        /// <summary>
        /// Get the hash code for this instance.
        /// </summary>
        /// <returns>
        /// The hash code.
        /// </returns>
        public override int GetHashCode()
        {
            return ComponentId;
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        /// <summary>
        /// Dispose of this instance.
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if(_properties != null)
                    {
                        foreach(var property in _properties)
                        {
                            property.Dispose();
                        }
                    }
                    DefaultProfile?.Dispose();
                }
                disposedValue = true;
            }
        }
        /// <summary>
        /// Dispose of this instance.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
