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
    ///  Class for testing BulkSendEmailOptions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class BulkSendEmailOptionsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for BulkSendEmailOptions
        //private BulkSendEmailOptions instance;

        public BulkSendEmailOptionsTests()
        {
            // TODO uncomment below to create an instance of BulkSendEmailOptions
            //instance = new BulkSendEmailOptions();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BulkSendEmailOptions
        /// </summary>
        [Fact]
        public void BulkSendEmailOptionsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" BulkSendEmailOptions
            //Assert.IsInstanceOfType<BulkSendEmailOptions> (instance, "variable 'instance' is a BulkSendEmailOptions");
        }


        /// <summary>
        /// Test the property 'InboxIds'
        /// </summary>
        [Fact]
        public void InboxIdsTest()
        {
            // TODO unit test for the property 'InboxIds'
        }
        /// <summary>
        /// Test the property 'SendEmailOptions'
        /// </summary>
        [Fact]
        public void SendEmailOptionsTest()
        {
            // TODO unit test for the property 'SendEmailOptions'
        }

    }

}