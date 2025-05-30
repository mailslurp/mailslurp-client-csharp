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
    ///  Class for testing ImapServerSearchOptions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ImapServerSearchOptionsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ImapServerSearchOptions
        //private ImapServerSearchOptions instance;

        public ImapServerSearchOptionsTests()
        {
            // TODO uncomment below to create an instance of ImapServerSearchOptions
            //instance = new ImapServerSearchOptions();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ImapServerSearchOptions
        /// </summary>
        [Fact]
        public void ImapServerSearchOptionsInstanceTest()
        {
            // TODO uncomment below to test "IsType" ImapServerSearchOptions
            //Assert.IsType<ImapServerSearchOptions>(instance);
        }

        /// <summary>
        /// Test the property 'SeqNum'
        /// </summary>
        [Fact]
        public void SeqNumTest()
        {
            // TODO unit test for the property 'SeqNum'
        }

        /// <summary>
        /// Test the property 'Uid'
        /// </summary>
        [Fact]
        public void UidTest()
        {
            // TODO unit test for the property 'Uid'
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

        /// <summary>
        /// Test the property 'SentSince'
        /// </summary>
        [Fact]
        public void SentSinceTest()
        {
            // TODO unit test for the property 'SentSince'
        }

        /// <summary>
        /// Test the property 'SentBefore'
        /// </summary>
        [Fact]
        public void SentBeforeTest()
        {
            // TODO unit test for the property 'SentBefore'
        }

        /// <summary>
        /// Test the property 'Header'
        /// </summary>
        [Fact]
        public void HeaderTest()
        {
            // TODO unit test for the property 'Header'
        }

        /// <summary>
        /// Test the property 'Body'
        /// </summary>
        [Fact]
        public void BodyTest()
        {
            // TODO unit test for the property 'Body'
        }

        /// <summary>
        /// Test the property 'Text'
        /// </summary>
        [Fact]
        public void TextTest()
        {
            // TODO unit test for the property 'Text'
        }

        /// <summary>
        /// Test the property 'WithFlags'
        /// </summary>
        [Fact]
        public void WithFlagsTest()
        {
            // TODO unit test for the property 'WithFlags'
        }

        /// <summary>
        /// Test the property 'WithoutFlags'
        /// </summary>
        [Fact]
        public void WithoutFlagsTest()
        {
            // TODO unit test for the property 'WithoutFlags'
        }
    }
}
