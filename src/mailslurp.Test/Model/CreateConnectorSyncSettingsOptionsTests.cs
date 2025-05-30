/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails and SMS from dynamically allocated email addresses and phone numbers. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://docs.mailslurp.com/) - [Examples](https://github.com/mailslurp/examples) repository
 *
 * The version of the OpenAPI document: 6.5.2
 * Contact: contact@mailslurp.dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using mailslurp.Model;
using mailslurp.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace mailslurp.Test.Model
{
    /// <summary>
    ///  Class for testing CreateConnectorSyncSettingsOptions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreateConnectorSyncSettingsOptionsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CreateConnectorSyncSettingsOptions
        //private CreateConnectorSyncSettingsOptions instance;

        public CreateConnectorSyncSettingsOptionsTests()
        {
            // TODO uncomment below to create an instance of CreateConnectorSyncSettingsOptions
            //instance = new CreateConnectorSyncSettingsOptions();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateConnectorSyncSettingsOptions
        /// </summary>
        [Fact]
        public void CreateConnectorSyncSettingsOptionsInstanceTest()
        {
            // TODO uncomment below to test "IsType" CreateConnectorSyncSettingsOptions
            //Assert.IsType<CreateConnectorSyncSettingsOptions>(instance);
        }

        /// <summary>
        /// Test the property 'SyncEnabled'
        /// </summary>
        [Fact]
        public void SyncEnabledTest()
        {
            // TODO unit test for the property 'SyncEnabled'
        }

        /// <summary>
        /// Test the property 'SyncScheduleType'
        /// </summary>
        [Fact]
        public void SyncScheduleTypeTest()
        {
            // TODO unit test for the property 'SyncScheduleType'
        }

        /// <summary>
        /// Test the property 'SyncInterval'
        /// </summary>
        [Fact]
        public void SyncIntervalTest()
        {
            // TODO unit test for the property 'SyncInterval'
        }
    }
}
