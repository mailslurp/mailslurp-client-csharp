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
    ///  Class for testing ListUnsubscribeRecipientProjection
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ListUnsubscribeRecipientProjectionTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ListUnsubscribeRecipientProjection
        //private ListUnsubscribeRecipientProjection instance;

        public ListUnsubscribeRecipientProjectionTests()
        {
            // TODO uncomment below to create an instance of ListUnsubscribeRecipientProjection
            //instance = new ListUnsubscribeRecipientProjection();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ListUnsubscribeRecipientProjection
        /// </summary>
        [Fact]
        public void ListUnsubscribeRecipientProjectionInstanceTest()
        {
            // TODO uncomment below to test "IsType" ListUnsubscribeRecipientProjection
            //Assert.IsType<ListUnsubscribeRecipientProjection>(instance);
        }

        /// <summary>
        /// Test the property 'EmailAddress'
        /// </summary>
        [Fact]
        public void EmailAddressTest()
        {
            // TODO unit test for the property 'EmailAddress'
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
        /// Test the property 'DomainId'
        /// </summary>
        [Fact]
        public void DomainIdTest()
        {
            // TODO unit test for the property 'DomainId'
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
    }
}
