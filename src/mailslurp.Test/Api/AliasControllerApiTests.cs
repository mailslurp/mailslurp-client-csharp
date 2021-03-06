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
    ///  Class for testing AliasControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AliasControllerApiTests : IDisposable
    {
        private AliasControllerApi instance;

        public AliasControllerApiTests()
        {
            instance = new AliasControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AliasControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AliasControllerApi
            //Assert.IsType(typeof(AliasControllerApi), instance, "instance is a AliasControllerApi");
        }

        
        /// <summary>
        /// Test CreateAlias
        /// </summary>
        [Fact]
        public void CreateAliasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateAliasOptions createAliasOptions = null;
            //var response = instance.CreateAlias(createAliasOptions);
            //Assert.IsType<AliasDto> (response, "response is AliasDto");
        }
        
        /// <summary>
        /// Test DeleteAlias
        /// </summary>
        [Fact]
        public void DeleteAliasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid aliasId = null;
            //instance.DeleteAlias(aliasId);
            
        }
        
        /// <summary>
        /// Test GetAlias
        /// </summary>
        [Fact]
        public void GetAliasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid aliasId = null;
            //var response = instance.GetAlias(aliasId);
            //Assert.IsType<AliasDto> (response, "response is AliasDto");
        }
        
        /// <summary>
        /// Test GetAliasEmails
        /// </summary>
        [Fact]
        public void GetAliasEmailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid aliasId = null;
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //var response = instance.GetAliasEmails(aliasId, page, size, sort);
            //Assert.IsType<PageEmailProjection> (response, "response is PageEmailProjection");
        }
        
        /// <summary>
        /// Test GetAliasThreads
        /// </summary>
        [Fact]
        public void GetAliasThreadsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid aliasId = null;
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //var response = instance.GetAliasThreads(aliasId, page, size, sort);
            //Assert.IsType<PageThreadProjection> (response, "response is PageThreadProjection");
        }
        
        /// <summary>
        /// Test GetAliases
        /// </summary>
        [Fact]
        public void GetAliasesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //var response = instance.GetAliases(page, size, sort);
            //Assert.IsType<PageAlias> (response, "response is PageAlias");
        }
        
        /// <summary>
        /// Test ReplyToAliasEmail
        /// </summary>
        [Fact]
        public void ReplyToAliasEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid aliasId = null;
            //Guid emailId = null;
            //ReplyToAliasEmailOptions replyToAliasEmailOptions = null;
            //var response = instance.ReplyToAliasEmail(aliasId, emailId, replyToAliasEmailOptions);
            //Assert.IsType<SentEmailDto> (response, "response is SentEmailDto");
        }
        
        /// <summary>
        /// Test SendAliasEmail
        /// </summary>
        [Fact]
        public void SendAliasEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid aliasId = null;
            //SendEmailOptions sendEmailOptions = null;
            //var response = instance.SendAliasEmail(aliasId, sendEmailOptions);
            //Assert.IsType<SentEmailDto> (response, "response is SentEmailDto");
        }
        
        /// <summary>
        /// Test UpdateAlias
        /// </summary>
        [Fact]
        public void UpdateAliasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid aliasId = null;
            //UpdateAliasOptions updateAliasOptions = null;
            //instance.UpdateAlias(aliasId, updateAliasOptions);
            
        }
        
    }

}
