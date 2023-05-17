/* *********************************************************************
 * This Original Work is copyright of 51 Degrees Mobile Experts Limited.
 * Copyright 2022 51 Degrees Mobile Experts Limited, Davidson House,
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

using FiftyOne.DeviceDetection.Hash.Engine.OnPremise.FlowElements;
using FiftyOne.DeviceDetection.Hash.Engine.OnPremise.Interop;
using FiftyOne.Pipeline.Engines.FiftyOne.Data;
using System;

namespace FiftyOne.DeviceDetection.Hash.Engine.OnPremise.Data
{
    /// <summary>
    /// Data class that contains meta-data relating to a specific 
    /// value. 
    /// See the <see href="https://github.com/51Degrees/specifications/blob/main/data-model-specification/README.md#value">Specification</see>
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Design",
        "CA1036:Override methods on comparable types",
        Justification = "Mathematical operator-style methods are not " +
        "appropriate for this class.")]
    public class ValueMetaData : IValueMetaData, IDisposable
    {
        internal readonly ValueMetaDataSwig _source;
        internal readonly DeviceDetectionHashEngine _engine;

        internal ValueMetaData(DeviceDetectionHashEngine engine, ValueMetaDataSwig source)
        {
            if(source == null) { throw new ArgumentNullException(nameof(source)); }
            _source = source;
            _engine = engine;
        }

        /// <summary>
        /// Get the meta-data for the property associated with this
        /// value instance.
        /// </summary>
        [Obsolete("Use the GetProperty method instead.")]
        public IFiftyOneAspectPropertyMetaData Property => GetProperty();

        /// <summary>
        /// The value
        /// </summary>
        public string Name => _source.getName();

        /// <summary>
        /// A description of this value.
        /// </summary>
        public string Description => _source.getDescription();

        /// <summary>
        /// A URL to get more information on this value.
        /// </summary>
        public string Url => _source.getUrl();

        /// <summary>
        /// Get the property that this value instance is associated with.
        /// </summary>
        /// <returns>
        /// The meta-data for the property this value is associated with.
        /// </returns>
        public IFiftyOneAspectPropertyMetaData GetProperty()
        {
            return new PropertyMetaDataHash(
                _engine,
                _engine.MetaData.getPropertyForValue(_source));
        }

        #region IDisposable Support
        /// <summary>
        /// Dispose
        /// </summary>
        /// <param name="disposing">
        /// False if called from finalizer
        /// </param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _source?.Dispose();
            }
        }

        /// <summary>
        /// Finalizer
        /// </summary>
        ~ValueMetaData()
        {
            Dispose(false);
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Get a hash code for this instance.
        /// The value-space is greater than the key-space so hash 
        /// collisions are possible and may need to be accounted for,
        /// depending on your use-case.
        /// </summary>
        /// <returns>
        /// A hash code.
        /// </returns>
        public override int GetHashCode()
        {
            using (var property = GetProperty()) 
            {
                return property.GetHashCode() ^ Name.GetHashCode();
            }
        }

        /// <summary>
        /// Check if this instance is equal to another object that 
        /// implements <see cref="IValueMetaData"/>.
        /// </summary>
        /// <param name="other">
        /// The <see cref="IValueMetaData"/> to check for 
        /// equality
        /// </param>
        /// <returns>
        /// True if the two instances are equal.
        /// False otherwise
        /// </returns>
        public bool Equals(IValueMetaData other)
        {
            if (other == null) return false;
            using (var property = GetProperty())
            {
                return property.Equals(other.GetProperty());
            }
        }

        /// <summary>
        /// Compare this instance with another object that implements 
        /// <see cref="IValueMetaData"/>
        /// </summary>
        /// <param name="other">
        /// The <see cref="IValueMetaData"/> to compare to
        /// </param>
        /// <returns>
        /// &gt;0 if this instance precedes `other` in the sort order.
        /// 0 if they are equal in the sort order.
        /// &lt;0 if `other` precedes this instance in the sort order.
        /// </returns>
        public int CompareTo(IValueMetaData other)
        {
            if (other == null) return -1;
            using (var property = GetProperty())
            {
                var difference = property.CompareTo(other.GetProperty());

                if (difference == 0)
                {
                    difference = string.Compare(Name, other.Name,
                        StringComparison.OrdinalIgnoreCase);
                }
                return difference;
            }
        }

        /// <summary>
        /// Returns a string representation of this value.
        /// </summary>
        /// <returns>
        /// A string representation of this value.
        /// </returns>
        public override string ToString()
        {
            using (var property = GetProperty())
            {
                return $"{property.Name}=>{Name}";
            }
        }

        #endregion
    }
}
