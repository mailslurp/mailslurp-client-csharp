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
    ///  Class for testing ValidatePhoneNumberOptions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ValidatePhoneNumberOptionsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ValidatePhoneNumberOptions
        //private ValidatePhoneNumberOptions instance;

        public ValidatePhoneNumberOptionsTests()
        {
            // TODO uncomment below to create an instance of ValidatePhoneNumberOptions
            //instance = new ValidatePhoneNumberOptions();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ValidatePhoneNumberOptions
        /// </summary>
        [Fact]
        public void ValidatePhoneNumberOptionsInstanceTest()
        {
            // TODO uncomment below to test "IsType" ValidatePhoneNumberOptions
            //Assert.IsType<ValidatePhoneNumberOptions>(instance);
        }

        /// <summary>
        /// Test the property 'PhoneNumber'
        /// </summary>
        [Fact]
        public void PhoneNumberTest()
        {
            // TODO unit test for the property 'PhoneNumber'
        }
    }
}
