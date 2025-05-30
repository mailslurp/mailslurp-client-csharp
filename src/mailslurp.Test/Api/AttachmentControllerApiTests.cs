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
    ///  Class for testing AttachmentControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AttachmentControllerApiTests : IDisposable
    {
        private AttachmentControllerApi instance;

        public AttachmentControllerApiTests()
        {
            instance = new AttachmentControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AttachmentControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AttachmentControllerApi
            //Assert.IsType<AttachmentControllerApi>(instance);
        }

        /// <summary>
        /// Test DeleteAllAttachments
        /// </summary>
        [Fact]
        public void DeleteAllAttachmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.DeleteAllAttachments();
        }

        /// <summary>
        /// Test DeleteAttachment
        /// </summary>
        [Fact]
        public void DeleteAttachmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string attachmentId = null;
            //instance.DeleteAttachment(attachmentId);
        }

        /// <summary>
        /// Test DownloadAttachmentAsBase64Encoded
        /// </summary>
        [Fact]
        public void DownloadAttachmentAsBase64EncodedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string attachmentId = null;
            //var response = instance.DownloadAttachmentAsBase64Encoded(attachmentId);
            //Assert.IsType<DownloadAttachmentDto>(response);
        }

        /// <summary>
        /// Test DownloadAttachmentAsBytes
        /// </summary>
        [Fact]
        public void DownloadAttachmentAsBytesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string attachmentId = null;
            //var response = instance.DownloadAttachmentAsBytes(attachmentId);
            //Assert.IsType<byte[]>(response);
        }

        /// <summary>
        /// Test GetAttachment
        /// </summary>
        [Fact]
        public void GetAttachmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string attachmentId = null;
            //var response = instance.GetAttachment(attachmentId);
            //Assert.IsType<AttachmentEntityDto>(response);
        }

        /// <summary>
        /// Test GetAttachmentInfo
        /// </summary>
        [Fact]
        public void GetAttachmentInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string attachmentId = null;
            //var response = instance.GetAttachmentInfo(attachmentId);
            //Assert.IsType<AttachmentMetaData>(response);
        }

        /// <summary>
        /// Test GetAttachments
        /// </summary>
        [Fact]
        public void GetAttachmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //string fileNameFilter = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //Guid? inboxId = null;
            //Guid? emailId = null;
            //Guid? sentEmailId = null;
            //var response = instance.GetAttachments(page, size, sort, fileNameFilter, since, before, inboxId, emailId, sentEmailId);
            //Assert.IsType<PageAttachmentEntity>(response);
        }

        /// <summary>
        /// Test UploadAttachment
        /// </summary>
        [Fact]
        public void UploadAttachmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UploadAttachmentOptions uploadAttachmentOptions = null;
            //var response = instance.UploadAttachment(uploadAttachmentOptions);
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test UploadAttachmentBytes
        /// </summary>
        [Fact]
        public void UploadAttachmentBytesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //string contentType2 = null;
            //string contentId = null;
            //string filename = null;
            //long? fileSize = null;
            //string filename2 = null;
            //var response = instance.UploadAttachmentBytes(contentType, contentType2, contentId, filename, fileSize, filename2);
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test UploadMultipartForm
        /// </summary>
        [Fact]
        public void UploadMultipartFormTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentId = null;
            //string contentType = null;
            //string filename = null;
            //string contentTypeHeader = null;
            //string xFilename = null;
            //string xFilenameRaw = null;
            //long? xFilesize = null;
            //UploadMultipartFormRequest uploadMultipartFormRequest = null;
            //var response = instance.UploadMultipartForm(contentId, contentType, filename, contentTypeHeader, xFilename, xFilenameRaw, xFilesize, uploadMultipartFormRequest);
            //Assert.IsType<List<string>>(response);
        }
    }
}
