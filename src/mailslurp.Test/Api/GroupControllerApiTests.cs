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
    ///  Class for testing GroupControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GroupControllerApiTests : IDisposable
    {
        private GroupControllerApi instance;

        public GroupControllerApiTests()
        {
            instance = new GroupControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GroupControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' GroupControllerApi
            //Assert.IsType(typeof(GroupControllerApi), instance, "instance is a GroupControllerApi");
        }

        
        /// <summary>
        /// Test AddContactsToGroup
        /// </summary>
        [Fact]
        public void AddContactsToGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid groupId = null;
            //UpdateGroupContacts updateGroupContactsOption = null;
            //var response = instance.AddContactsToGroup(groupId, updateGroupContactsOption);
            //Assert.IsType<GroupContactsDto> (response, "response is GroupContactsDto");
        }
        
        /// <summary>
        /// Test CreateGroup
        /// </summary>
        [Fact]
        public void CreateGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateGroupOptions createGroupOptions = null;
            //var response = instance.CreateGroup(createGroupOptions);
            //Assert.IsType<GroupDto> (response, "response is GroupDto");
        }
        
        /// <summary>
        /// Test DeleteGroup
        /// </summary>
        [Fact]
        public void DeleteGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid groupId = null;
            //instance.DeleteGroup(groupId);
            
        }
        
        /// <summary>
        /// Test GetAllGroups
        /// </summary>
        [Fact]
        public void GetAllGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //var response = instance.GetAllGroups(page, size, sort);
            //Assert.IsType<PageGroupProjection> (response, "response is PageGroupProjection");
        }
        
        /// <summary>
        /// Test GetGroup
        /// </summary>
        [Fact]
        public void GetGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid groupId = null;
            //var response = instance.GetGroup(groupId);
            //Assert.IsType<GroupDto> (response, "response is GroupDto");
        }
        
        /// <summary>
        /// Test GetGroupWithContacts
        /// </summary>
        [Fact]
        public void GetGroupWithContactsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid groupId = null;
            //var response = instance.GetGroupWithContacts(groupId);
            //Assert.IsType<GroupContactsDto> (response, "response is GroupContactsDto");
        }
        
        /// <summary>
        /// Test GetGroupWithContactsPaginated
        /// </summary>
        [Fact]
        public void GetGroupWithContactsPaginatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid groupId = null;
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //var response = instance.GetGroupWithContactsPaginated(groupId, page, size, sort);
            //Assert.IsType<PageContactProjection> (response, "response is PageContactProjection");
        }
        
        /// <summary>
        /// Test GetGroups
        /// </summary>
        [Fact]
        public void GetGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetGroups();
            //Assert.IsType<List<GroupProjection>> (response, "response is List<GroupProjection>");
        }
        
        /// <summary>
        /// Test RemoveContactsFromGroup
        /// </summary>
        [Fact]
        public void RemoveContactsFromGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid groupId = null;
            //UpdateGroupContacts updateGroupContactsOption = null;
            //var response = instance.RemoveContactsFromGroup(groupId, updateGroupContactsOption);
            //Assert.IsType<GroupContactsDto> (response, "response is GroupContactsDto");
        }
        
    }

}
