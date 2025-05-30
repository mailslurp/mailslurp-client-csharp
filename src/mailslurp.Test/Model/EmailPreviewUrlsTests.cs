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
    ///  Class for testing EmailPreviewUrls
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EmailPreviewUrlsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for EmailPreviewUrls
        //private EmailPreviewUrls instance;

        public EmailPreviewUrlsTests()
        {
            // TODO uncomment below to create an instance of EmailPreviewUrls
            //instance = new EmailPreviewUrls();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EmailPreviewUrls
        /// </summary>
        [Fact]
        public void EmailPreviewUrlsInstanceTest()
        {
            // TODO uncomment below to test "IsType" EmailPreviewUrls
            //Assert.IsType<EmailPreviewUrls>(instance);
        }

        /// <summary>
        /// Test the property 'RawSmtpMessageUrl'
        /// </summary>
        [Fact]
        public void RawSmtpMessageUrlTest()
        {
            // TODO unit test for the property 'RawSmtpMessageUrl'
        }

        /// <summary>
        /// Test the property 'PlainHtmlBodyUrl'
        /// </summary>
        [Fact]
        public void PlainHtmlBodyUrlTest()
        {
            // TODO unit test for the property 'PlainHtmlBodyUrl'
        }

        /// <summary>
        /// Test the property 'Origin'
        /// </summary>
        [Fact]
        public void OriginTest()
        {
            // TODO unit test for the property 'Origin'
        }
    }
}
