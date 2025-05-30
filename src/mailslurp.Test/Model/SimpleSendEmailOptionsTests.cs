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
    ///  Class for testing SimpleSendEmailOptions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SimpleSendEmailOptionsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SimpleSendEmailOptions
        //private SimpleSendEmailOptions instance;

        public SimpleSendEmailOptionsTests()
        {
            // TODO uncomment below to create an instance of SimpleSendEmailOptions
            //instance = new SimpleSendEmailOptions();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SimpleSendEmailOptions
        /// </summary>
        [Fact]
        public void SimpleSendEmailOptionsInstanceTest()
        {
            // TODO uncomment below to test "IsType" SimpleSendEmailOptions
            //Assert.IsType<SimpleSendEmailOptions>(instance);
        }

        /// <summary>
        /// Test the property 'SenderId'
        /// </summary>
        [Fact]
        public void SenderIdTest()
        {
            // TODO unit test for the property 'SenderId'
        }

        /// <summary>
        /// Test the property 'To'
        /// </summary>
        [Fact]
        public void ToTest()
        {
            // TODO unit test for the property 'To'
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
        /// Test the property 'Subject'
        /// </summary>
        [Fact]
        public void SubjectTest()
        {
            // TODO unit test for the property 'Subject'
        }
    }
}
