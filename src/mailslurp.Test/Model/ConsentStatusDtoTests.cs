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
    ///  Class for testing ConsentStatusDto
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ConsentStatusDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ConsentStatusDto
        //private ConsentStatusDto instance;

        public ConsentStatusDtoTests()
        {
            // TODO uncomment below to create an instance of ConsentStatusDto
            //instance = new ConsentStatusDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConsentStatusDto
        /// </summary>
        [Fact]
        public void ConsentStatusDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" ConsentStatusDto
            //Assert.IsType<ConsentStatusDto>(instance);
        }

        /// <summary>
        /// Test the property 'Consented'
        /// </summary>
        [Fact]
        public void ConsentedTest()
        {
            // TODO unit test for the property 'Consented'
        }
    }
}
