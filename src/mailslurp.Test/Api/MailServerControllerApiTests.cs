/* 
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://www.mailslurp.com/docs/) - [Examples](https://github.com/mailslurp/examples) repository 
 *
 * The version of the OpenAPI document: 6.5.2
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using mailslurp.Client;
using mailslurp.Api;
using mailslurp.Model;

namespace mailslurp.Test
{
    /// <summary>
    ///  Class for testing MailServerControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MailServerControllerApiTests : IDisposable
    {
        private MailServerControllerApi instance;

        public MailServerControllerApiTests()
        {
            instance = new MailServerControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MailServerControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MailServerControllerApi
            //Assert.IsType(typeof(MailServerControllerApi), instance, "instance is a MailServerControllerApi");
        }

        
        /// <summary>
        /// Test DescribeMailServerDomain
        /// </summary>
        [Fact]
        public void DescribeMailServerDomainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DescribeDomainOptions describeOptions = null;
            //var response = instance.DescribeMailServerDomain(describeOptions);
            //Assert.IsType<DescribeMailServerDomainResult> (response, "response is DescribeMailServerDomainResult");
        }
        
        /// <summary>
        /// Test GetDnsLookup
        /// </summary>
        [Fact]
        public void GetDnsLookupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DNSLookupOptions dnsLookupOptions = null;
            //var response = instance.GetDnsLookup(dnsLookupOptions);
            //Assert.IsType<DNSLookupResults> (response, "response is DNSLookupResults");
        }
        
        /// <summary>
        /// Test GetIpAddress
        /// </summary>
        [Fact]
        public void GetIpAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.GetIpAddress(name);
            //Assert.IsType<IPAddressResult> (response, "response is IPAddressResult");
        }
        
        /// <summary>
        /// Test VerifyEmailAddress
        /// </summary>
        [Fact]
        public void VerifyEmailAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VerifyEmailAddressOptions verifyOptions = null;
            //var response = instance.VerifyEmailAddress(verifyOptions);
            //Assert.IsType<EmailVerificationResult> (response, "response is EmailVerificationResult");
        }
        
    }

}
