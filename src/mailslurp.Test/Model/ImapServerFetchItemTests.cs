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
    ///  Class for testing ImapServerFetchItem
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ImapServerFetchItemTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ImapServerFetchItem
        //private ImapServerFetchItem instance;

        public ImapServerFetchItemTests()
        {
            // TODO uncomment below to create an instance of ImapServerFetchItem
            //instance = new ImapServerFetchItem();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ImapServerFetchItem
        /// </summary>
        [Fact]
        public void ImapServerFetchItemInstanceTest()
        {
            // TODO uncomment below to test "IsType" ImapServerFetchItem
            //Assert.IsType<ImapServerFetchItem>(instance);
        }

        /// <summary>
        /// Test the property 'Content'
        /// </summary>
        [Fact]
        public void ContentTest()
        {
            // TODO unit test for the property 'Content'
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
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
        /// Test the property 'SeqNum'
        /// </summary>
        [Fact]
        public void SeqNumTest()
        {
            // TODO unit test for the property 'SeqNum'
        }

        /// <summary>
        /// Test the property 'Read'
        /// </summary>
        [Fact]
        public void ReadTest()
        {
            // TODO unit test for the property 'Read'
        }
    }
}
