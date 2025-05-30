/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails and SMS from dynamically allocated email addresses and phone numbers. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://docs.mailslurp.com/) - [Examples](https://github.com/mailslurp/examples) repository
 *
 * The version of the OpenAPI document: 6.5.2
 * Contact: contact@mailslurp.dev
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
// uncomment below to import models
//using mailslurp.Model;

namespace mailslurp.Test.Api
{
    /// <summary>
    ///  Class for testing UserControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserControllerApiTests : IDisposable
    {
        private UserControllerApi instance;

        public UserControllerApiTests()
        {
            instance = new UserControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UserControllerApi
            //Assert.IsType<UserControllerApi>(instance);
        }

        /// <summary>
        /// Test GetEntityAutomations
        /// </summary>
        [Fact]
        public void GetEntityAutomationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //Guid? inboxId = null;
            //Guid? phoneId = null;
            //string filter = null;
            //var response = instance.GetEntityAutomations(page, size, sort, since, before, inboxId, phoneId, filter);
            //Assert.IsType<PageEntityAutomationItems>(response);
        }

        /// <summary>
        /// Test GetEntityEvents
        /// </summary>
        [Fact]
        public void GetEntityEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //Guid? inboxId = null;
            //Guid? emailId = null;
            //Guid? phoneId = null;
            //Guid? smsId = null;
            //Guid? attachmentId = null;
            //string filter = null;
            //var response = instance.GetEntityEvents(page, size, sort, since, before, inboxId, emailId, phoneId, smsId, attachmentId, filter);
            //Assert.IsType<PageEntityEventItems>(response);
        }

        /// <summary>
        /// Test GetEntityFavorites
        /// </summary>
        [Fact]
        public void GetEntityFavoritesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //string filter = null;
            //var response = instance.GetEntityFavorites(page, size, sort, since, before, filter);
            //Assert.IsType<PageEntityFavouriteItems>(response);
        }

        /// <summary>
        /// Test GetJsonPropertyAsString
        /// </summary>
        [Fact]
        public void GetJsonPropertyAsStringTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string property = null;
            //Object body = null;
            //var response = instance.GetJsonPropertyAsString(property, body);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test GetUserInfo
        /// </summary>
        [Fact]
        public void GetUserInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetUserInfo();
            //Assert.IsType<UserInfoDto>(response);
        }
    }
}
