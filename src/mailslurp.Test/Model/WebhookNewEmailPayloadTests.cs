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
    ///  Class for testing WebhookNewEmailPayload
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class WebhookNewEmailPayloadTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for WebhookNewEmailPayload
        //private WebhookNewEmailPayload instance;

        public WebhookNewEmailPayloadTests()
        {
            // TODO uncomment below to create an instance of WebhookNewEmailPayload
            //instance = new WebhookNewEmailPayload();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WebhookNewEmailPayload
        /// </summary>
        [Fact]
        public void WebhookNewEmailPayloadInstanceTest()
        {
            // TODO uncomment below to test "IsType" WebhookNewEmailPayload
            //Assert.IsType<WebhookNewEmailPayload>(instance);
        }

        /// <summary>
        /// Test the property 'MessageId'
        /// </summary>
        [Fact]
        public void MessageIdTest()
        {
            // TODO unit test for the property 'MessageId'
        }

        /// <summary>
        /// Test the property 'WebhookId'
        /// </summary>
        [Fact]
        public void WebhookIdTest()
        {
            // TODO unit test for the property 'WebhookId'
        }

        /// <summary>
        /// Test the property 'EventName'
        /// </summary>
        [Fact]
        public void EventNameTest()
        {
            // TODO unit test for the property 'EventName'
        }

        /// <summary>
        /// Test the property 'WebhookName'
        /// </summary>
        [Fact]
        public void WebhookNameTest()
        {
            // TODO unit test for the property 'WebhookName'
        }

        /// <summary>
        /// Test the property 'InboxId'
        /// </summary>
        [Fact]
        public void InboxIdTest()
        {
            // TODO unit test for the property 'InboxId'
        }

        /// <summary>
        /// Test the property 'DomainId'
        /// </summary>
        [Fact]
        public void DomainIdTest()
        {
            // TODO unit test for the property 'DomainId'
        }

        /// <summary>
        /// Test the property 'EmailId'
        /// </summary>
        [Fact]
        public void EmailIdTest()
        {
            // TODO unit test for the property 'EmailId'
        }

        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Fact]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
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
        /// Test the property 'From'
        /// </summary>
        [Fact]
        public void FromTest()
        {
            // TODO unit test for the property 'From'
        }

        /// <summary>
        /// Test the property 'Cc'
        /// </summary>
        [Fact]
        public void CcTest()
        {
            // TODO unit test for the property 'Cc'
        }

        /// <summary>
        /// Test the property 'Bcc'
        /// </summary>
        [Fact]
        public void BccTest()
        {
            // TODO unit test for the property 'Bcc'
        }

        /// <summary>
        /// Test the property 'Subject'
        /// </summary>
        [Fact]
        public void SubjectTest()
        {
            // TODO unit test for the property 'Subject'
        }

        /// <summary>
        /// Test the property 'AttachmentMetaDatas'
        /// </summary>
        [Fact]
        public void AttachmentMetaDatasTest()
        {
            // TODO unit test for the property 'AttachmentMetaDatas'
        }
    }
}
