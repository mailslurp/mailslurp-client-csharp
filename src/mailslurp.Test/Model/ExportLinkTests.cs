/* 
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://www.mailslurp.com/docs/) - [Examples](https://github.com/mailslurp/examples) repository 
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
    ///  Class for testing ExportLink
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ExportLinkTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ExportLink
        //private ExportLink instance;

        public ExportLinkTests()
        {
            // TODO uncomment below to create an instance of ExportLink
            //instance = new ExportLink();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ExportLink
        /// </summary>
        [Fact]
        public void ExportLinkInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ExportLink
            //Assert.IsInstanceOfType<ExportLink> (instance, "variable 'instance' is a ExportLink");
        }


        /// <summary>
        /// Test the property 'DownloadLink'
        /// </summary>
        [Fact]
        public void DownloadLinkTest()
        {
            // TODO unit test for the property 'DownloadLink'
        }

    }

}