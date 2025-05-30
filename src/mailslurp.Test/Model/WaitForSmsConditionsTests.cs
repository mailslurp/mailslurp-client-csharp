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
    ///  Class for testing WaitForSmsConditions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class WaitForSmsConditionsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for WaitForSmsConditions
        //private WaitForSmsConditions instance;

        public WaitForSmsConditionsTests()
        {
            // TODO uncomment below to create an instance of WaitForSmsConditions
            //instance = new WaitForSmsConditions();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WaitForSmsConditions
        /// </summary>
        [Fact]
        public void WaitForSmsConditionsInstanceTest()
        {
            // TODO uncomment below to test "IsType" WaitForSmsConditions
            //Assert.IsType<WaitForSmsConditions>(instance);
        }

        /// <summary>
        /// Test the property 'PhoneNumberId'
        /// </summary>
        [Fact]
        public void PhoneNumberIdTest()
        {
            // TODO unit test for the property 'PhoneNumberId'
        }

        /// <summary>
        /// Test the property 'Limit'
        /// </summary>
        [Fact]
        public void LimitTest()
        {
            // TODO unit test for the property 'Limit'
        }

        /// <summary>
        /// Test the property 'Count'
        /// </summary>
        [Fact]
        public void CountTest()
        {
            // TODO unit test for the property 'Count'
        }

        /// <summary>
        /// Test the property 'DelayTimeout'
        /// </summary>
        [Fact]
        public void DelayTimeoutTest()
        {
            // TODO unit test for the property 'DelayTimeout'
        }

        /// <summary>
        /// Test the property 'Timeout'
        /// </summary>
        [Fact]
        public void TimeoutTest()
        {
            // TODO unit test for the property 'Timeout'
        }

        /// <summary>
        /// Test the property 'UnreadOnly'
        /// </summary>
        [Fact]
        public void UnreadOnlyTest()
        {
            // TODO unit test for the property 'UnreadOnly'
        }

        /// <summary>
        /// Test the property 'CountType'
        /// </summary>
        [Fact]
        public void CountTypeTest()
        {
            // TODO unit test for the property 'CountType'
        }

        /// <summary>
        /// Test the property 'Matches'
        /// </summary>
        [Fact]
        public void MatchesTest()
        {
            // TODO unit test for the property 'Matches'
        }

        /// <summary>
        /// Test the property 'SortDirection'
        /// </summary>
        [Fact]
        public void SortDirectionTest()
        {
            // TODO unit test for the property 'SortDirection'
        }

        /// <summary>
        /// Test the property 'Since'
        /// </summary>
        [Fact]
        public void SinceTest()
        {
            // TODO unit test for the property 'Since'
        }

        /// <summary>
        /// Test the property 'Before'
        /// </summary>
        [Fact]
        public void BeforeTest()
        {
            // TODO unit test for the property 'Before'
        }
    }
}
