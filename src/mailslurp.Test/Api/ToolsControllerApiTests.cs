/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://docs.mailslurp.com/) - [Examples](https://github.com/mailslurp/examples) repository
 *
 * The version of the OpenAPI document: 6.5.2
 * Contact: contact@mailslurp.dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using mailslurp.Client;
using mailslurp.Api;
// uncomment below to import models
//using mailslurp.Model;

namespace mailslurp.Test.Api
{
    /// <summary>
    ///  Class for testing ToolsControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ToolsControllerApiTests : IDisposable
    {
        private ToolsControllerApi instance;

        public ToolsControllerApiTests()
        {
            instance = new ToolsControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ToolsControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ToolsControllerApi
            //Assert.IsType<ToolsControllerApi>(instance);
        }

        /// <summary>
        /// Test CheckEmailFeaturesClientSupport
        /// </summary>
        [Fact]
        public void CheckEmailFeaturesClientSupportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CheckEmailFeaturesClientSupportOptions checkEmailFeaturesClientSupportOptions = null;
            //var response = instance.CheckEmailFeaturesClientSupport(checkEmailFeaturesClientSupportOptions);
            //Assert.IsType<CheckEmailFeaturesClientSupportResults>(response);
        }

        /// <summary>
        /// Test GenerateBimiRecord
        /// </summary>
        [Fact]
        public void GenerateBimiRecordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GenerateBimiRecordOptions generateBimiRecordOptions = null;
            //var response = instance.GenerateBimiRecord(generateBimiRecordOptions);
            //Assert.IsType<GenerateBimiRecordResults>(response);
        }

        /// <summary>
        /// Test GenerateDmarcRecord
        /// </summary>
        [Fact]
        public void GenerateDmarcRecordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GenerateDmarcRecordOptions generateDmarcRecordOptions = null;
            //var response = instance.GenerateDmarcRecord(generateDmarcRecordOptions);
            //Assert.IsType<GenerateDmarcRecordResults>(response);
        }

        /// <summary>
        /// Test GenerateMtaStsRecord
        /// </summary>
        [Fact]
        public void GenerateMtaStsRecordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GenerateMtaStsRecordOptions generateMtaStsRecordOptions = null;
            //var response = instance.GenerateMtaStsRecord(generateMtaStsRecordOptions);
            //Assert.IsType<GenerateMtaStsRecordResults>(response);
        }

        /// <summary>
        /// Test GenerateTlsReportingRecord
        /// </summary>
        [Fact]
        public void GenerateTlsReportingRecordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GenerateTlsReportingRecordOptions generateTlsReportingRecordOptions = null;
            //var response = instance.GenerateTlsReportingRecord(generateTlsReportingRecordOptions);
            //Assert.IsType<GenerateTlsReportingRecordResults>(response);
        }

        /// <summary>
        /// Test LookupBimiDomain
        /// </summary>
        [Fact]
        public void LookupBimiDomainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LookupBimiDomainOptions lookupBimiDomainOptions = null;
            //var response = instance.LookupBimiDomain(lookupBimiDomainOptions);
            //Assert.IsType<LookupBimiDomainResults>(response);
        }

        /// <summary>
        /// Test LookupDmarcDomain
        /// </summary>
        [Fact]
        public void LookupDmarcDomainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LookupDmarcDomainOptions lookupDmarcDomainOptions = null;
            //var response = instance.LookupDmarcDomain(lookupDmarcDomainOptions);
            //Assert.IsType<LookupDmarcDomainResults>(response);
        }

        /// <summary>
        /// Test LookupMtaStsDomain
        /// </summary>
        [Fact]
        public void LookupMtaStsDomainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LookupMtaStsDomainOptions lookupMtaStsDomainOptions = null;
            //var response = instance.LookupMtaStsDomain(lookupMtaStsDomainOptions);
            //Assert.IsType<LookupMtaStsDomainResults>(response);
        }

        /// <summary>
        /// Test LookupTlsReportingDomain
        /// </summary>
        [Fact]
        public void LookupTlsReportingDomainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LookupTlsReportingDomainOptions lookupTlsReportingDomainOptions = null;
            //var response = instance.LookupTlsReportingDomain(lookupTlsReportingDomainOptions);
            //Assert.IsType<LookupTlsReportingDomainResults>(response);
        }
    }
}