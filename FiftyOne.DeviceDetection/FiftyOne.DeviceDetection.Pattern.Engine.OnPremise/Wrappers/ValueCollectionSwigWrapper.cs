/* *********************************************************************
 * This Original Work is copyright of 51 Degrees Mobile Experts Limited.
 * Copyright 2019 51 Degrees Mobile Experts Limited, 5 Charlotte Close,
 * Caversham, Reading, Berkshire, United Kingdom RG4 7BY.
 *
 * This Original Work is licensed under the European Union Public Licence (EUPL) 
 * v.1.2 and is subject to its terms as set out below.
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

using FiftyOne.DeviceDetection.Pattern.Engine.OnPremise.Data;
using FiftyOne.DeviceDetection.Pattern.Engine.OnPremise.FlowElements;
using FiftyOne.DeviceDetection.Pattern.Engine.OnPremise.Interop;
using FiftyOne.Pipeline.Engines.FiftyOne.Data;
using System.Collections;
using System.Collections.Generic;

namespace FiftyOne.DeviceDetection.Pattern.Engine.OnPremise.Wrappers
{
    internal class ValueCollectionSwigWrapper : IValueCollectionSwigWrapper
    {
        private ValueMetaDataCollectionSwig _object;
        private DeviceDetectionPatternEngine _engine;

        public ValueCollectionSwigWrapper(ValueMetaDataCollectionSwig instance,
            DeviceDetectionPatternEngine engine)
        {
            _object = instance;
            _engine = engine;
        }

        public void Dispose()
        {
        }

        public ValueMetaDataSwig getByKey(ValueMetaDataKeySwig key)
        {
            return _object.getByKey(key);
        }

        public IEnumerator<IValueMetaData> GetEnumerator()
        {
            for (uint i = 0; i < _object.getSize(); i++)
            {
                yield return new ValueMetaData(_engine, _object.getByIndex(i));
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
