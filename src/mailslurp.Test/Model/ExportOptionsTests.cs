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
    ///  Class for testing ExportOptions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ExportOptionsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ExportOptions
        //private ExportOptions instance;

        public ExportOptionsTests()
        {
            // TODO uncomment below to create an instance of ExportOptions
            //instance = new ExportOptions();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ExportOptions
        /// </summary>
        [Fact]
        public void ExportOptionsInstanceTest()
        {
            // TODO uncomment below to test "IsType" ExportOptions
            //Assert.IsType<ExportOptions>(instance);
        }

        /// <summary>
        /// Test the property 'OutputFormat'
        /// </summary>
        [Fact]
        public void OutputFormatTest()
        {
            // TODO unit test for the property 'OutputFormat'
        }

        /// <summary>
        /// Test the property 'ExcludePreviouslyExported'
        /// </summary>
        [Fact]
        public void ExcludePreviouslyExportedTest()
        {
            // TODO unit test for the property 'ExcludePreviouslyExported'
        }

        /// <summary>
        /// Test the property 'CreatedEarliestTime'
        /// </summary>
        [Fact]
        public void CreatedEarliestTimeTest()
        {
            // TODO unit test for the property 'CreatedEarliestTime'
        }

        /// <summary>
        /// Test the property 'CreatedOldestTime'
        /// </summary>
        [Fact]
        public void CreatedOldestTimeTest()
        {
            // TODO unit test for the property 'CreatedOldestTime'
        }

        /// <summary>
        /// Test the property 'Filter'
        /// </summary>
        [Fact]
        public void FilterTest()
        {
            // TODO unit test for the property 'Filter'
        }

        /// <summary>
        /// Test the property 'ListSeparatorToken'
        /// </summary>
        [Fact]
        public void ListSeparatorTokenTest()
        {
            // TODO unit test for the property 'ListSeparatorToken'
        }
    }
}
