/* 
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.   ## Resources - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://www.mailslurp.com/docs/) - [Examples](https://github.com/mailslurp/examples) repository 
 *
 * The version of the OpenAPI document: 6.5.2
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using mailslurp.Api;
using mailslurp.Model;
using mailslurp.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace mailslurp.Test
{
    /// <summary>
    ///  Class for testing DNSLookupResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DNSLookupResultTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DNSLookupResult
        //private DNSLookupResult instance;

        public DNSLookupResultTests()
        {
            // TODO uncomment below to create an instance of DNSLookupResult
            //instance = new DNSLookupResult();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DNSLookupResult
        /// </summary>
        [Fact]
        public void DNSLookupResultInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" DNSLookupResult
            //Assert.IsInstanceOfType<DNSLookupResult> (instance, "variable 'instance' is a DNSLookupResult");
        }


        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            // TODO unit test for the property 'Data'
        }
        /// <summary>
        /// Test the property 'RecordType'
        /// </summary>
        [Fact]
        public void RecordTypeTest()
        {
            // TODO unit test for the property 'RecordType'
        }
        /// <summary>
        /// Test the property 'Ttl'
        /// </summary>
        [Fact]
        public void TtlTest()
        {
            // TODO unit test for the property 'Ttl'
        }
        /// <summary>
        /// Test the property 'Value'
        /// </summary>
        [Fact]
        public void ValueTest()
        {
            // TODO unit test for the property 'Value'
        }

    }

}