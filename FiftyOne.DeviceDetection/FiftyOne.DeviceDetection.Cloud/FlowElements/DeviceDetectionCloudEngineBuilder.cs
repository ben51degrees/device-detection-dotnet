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

using FiftyOne.DeviceDetection.Cloud.Data;
using FiftyOne.Pipeline.CloudRequestEngine.FlowElements;
using FiftyOne.Pipeline.Core.Data;
using FiftyOne.Pipeline.Core.FlowElements;
using FiftyOne.Pipeline.Engines.Data;
using FiftyOne.Pipeline.Engines.FlowElements;
using FiftyOne.Pipeline.Engines.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace FiftyOne.DeviceDetection.Cloud.FlowElements
{
    public class DeviceDetectionCloudEngineBuilder: AspectEngineBuilderBase<DeviceDetectionCloudEngineBuilder, DeviceDetectionCloudEngine>
    {
        private ILoggerFactory _loggerFactory;
        private HttpClient _httpClient;
        private CloudRequestEngine _engine;

        public DeviceDetectionCloudEngineBuilder(ILoggerFactory loggerFactory,
            HttpClient httpClient,
            CloudRequestEngine engine)
        {
            _loggerFactory = loggerFactory;
            _httpClient = httpClient;
            _engine = engine;
        }

        public DeviceDetectionCloudEngine Build()
        {
            return BuildEngine();
        }

        protected override DeviceDetectionCloudEngine NewEngine(List<string> properties)
        {
            return new DeviceDetectionCloudEngine(
                _loggerFactory.CreateLogger<DeviceDetectionCloudEngine>(),
                CreateData,
                _httpClient,
                _engine);
        }

        private DeviceDataCloud CreateData(IFlowData flowData, FlowElementBase<DeviceDataCloud, IAspectPropertyMetaData> engine)
        {
            return new DeviceDataCloud(
                _loggerFactory.CreateLogger<DeviceDataCloud>(),
                flowData,
                (IAspectEngine)engine,
                MissingPropertyService.Instance);
        }

    }
}
