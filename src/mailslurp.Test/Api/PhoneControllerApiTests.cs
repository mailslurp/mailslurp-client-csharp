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
    ///  Class for testing PhoneControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PhoneControllerApiTests : IDisposable
    {
        private PhoneControllerApi instance;

        public PhoneControllerApiTests()
        {
            instance = new PhoneControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PhoneControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PhoneControllerApi
            //Assert.IsType<PhoneControllerApi>(instance);
        }

        /// <summary>
        /// Test CreateEmergencyAddress
        /// </summary>
        [Fact]
        public void CreateEmergencyAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateEmergencyAddressOptions createEmergencyAddressOptions = null;
            //var response = instance.CreateEmergencyAddress(createEmergencyAddressOptions);
            //Assert.IsType<EmergencyAddress>(response);
        }

        /// <summary>
        /// Test CreatePhoneNumber
        /// </summary>
        [Fact]
        public void CreatePhoneNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreatePhoneNumberOptions createPhoneNumberOptions = null;
            //var response = instance.CreatePhoneNumber(createPhoneNumberOptions);
            //Assert.IsType<PhoneNumberDto>(response);
        }

        /// <summary>
        /// Test DeleteEmergencyAddress
        /// </summary>
        [Fact]
        public void DeleteEmergencyAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid addressId = null;
            //var response = instance.DeleteEmergencyAddress(addressId);
            //Assert.IsType<EmptyResponseDto>(response);
        }

        /// <summary>
        /// Test DeletePhoneNumber
        /// </summary>
        [Fact]
        public void DeletePhoneNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid phoneNumberId = null;
            //instance.DeletePhoneNumber(phoneNumberId);
        }

        /// <summary>
        /// Test GetAllPhoneMessageThreads
        /// </summary>
        [Fact]
        public void GetAllPhoneMessageThreadsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //var response = instance.GetAllPhoneMessageThreads(page, size);
            //Assert.IsType<PagePhoneMessageThreadProjection>(response);
        }

        /// <summary>
        /// Test GetConsentStatus
        /// </summary>
        [Fact]
        public void GetConsentStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetConsentStatus();
            //Assert.IsType<ConsentStatusDto>(response);
        }

        /// <summary>
        /// Test GetEmergencyAddress
        /// </summary>
        [Fact]
        public void GetEmergencyAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid addressId = null;
            //var response = instance.GetEmergencyAddress(addressId);
            //Assert.IsType<EmergencyAddress>(response);
        }

        /// <summary>
        /// Test GetEmergencyAddresses
        /// </summary>
        [Fact]
        public void GetEmergencyAddressesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetEmergencyAddresses();
            //Assert.IsType<List<EmergencyAddressDto>>(response);
        }

        /// <summary>
        /// Test GetPhoneMessageThreadItems
        /// </summary>
        [Fact]
        public void GetPhoneMessageThreadItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid phoneNumberId = null;
            //string otherNumber = null;
            //int? page = null;
            //int? size = null;
            //var response = instance.GetPhoneMessageThreadItems(phoneNumberId, otherNumber, page, size);
            //Assert.IsType<PagePhoneMessageThreadItemProjection>(response);
        }

        /// <summary>
        /// Test GetPhoneMessageThreads
        /// </summary>
        [Fact]
        public void GetPhoneMessageThreadsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid phoneNumberId = null;
            //int? page = null;
            //int? size = null;
            //var response = instance.GetPhoneMessageThreads(phoneNumberId, page, size);
            //Assert.IsType<PagePhoneMessageThreadProjection>(response);
        }

        /// <summary>
        /// Test GetPhoneNumber
        /// </summary>
        [Fact]
        public void GetPhoneNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid phoneNumberId = null;
            //var response = instance.GetPhoneNumber(phoneNumberId);
            //Assert.IsType<PhoneNumberDto>(response);
        }

        /// <summary>
        /// Test GetPhoneNumberByName
        /// </summary>
        [Fact]
        public void GetPhoneNumberByNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.GetPhoneNumberByName(name);
            //Assert.IsType<PhoneNumberDto>(response);
        }

        /// <summary>
        /// Test GetPhoneNumberByPhoneNumber
        /// </summary>
        [Fact]
        public void GetPhoneNumberByPhoneNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string phoneNumber = null;
            //var response = instance.GetPhoneNumberByPhoneNumber(phoneNumber);
            //Assert.IsType<PhoneNumberDto>(response);
        }

        /// <summary>
        /// Test GetPhoneNumbers
        /// </summary>
        [Fact]
        public void GetPhoneNumbersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string phoneCountry = null;
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //string search = null;
            //List<Guid> include = null;
            //bool? favourite = null;
            //var response = instance.GetPhoneNumbers(phoneCountry, page, size, sort, since, before, search, include, favourite);
            //Assert.IsType<PagePhoneNumberProjection>(response);
        }

        /// <summary>
        /// Test GetPhonePlans
        /// </summary>
        [Fact]
        public void GetPhonePlansTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPhonePlans();
            //Assert.IsType<List<PhonePlanDto>>(response);
        }

        /// <summary>
        /// Test GetPhonePlansAvailability
        /// </summary>
        [Fact]
        public void GetPhonePlansAvailabilityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPhonePlansAvailability();
            //Assert.IsType<PhonePlanAvailability>(response);
        }

        /// <summary>
        /// Test GetSentSmsByPhoneNumber
        /// </summary>
        [Fact]
        public void GetSentSmsByPhoneNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid phoneNumberId = null;
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //string search = null;
            //var response = instance.GetSentSmsByPhoneNumber(phoneNumberId, page, size, sort, since, before, search);
            //Assert.IsType<PageSentSmsProjection>(response);
        }

        /// <summary>
        /// Test GetSmsByPhoneNumber
        /// </summary>
        [Fact]
        public void GetSmsByPhoneNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid phoneNumberId = null;
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //bool? unreadOnly = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //string search = null;
            //bool? favourite = null;
            //var response = instance.GetSmsByPhoneNumber(phoneNumberId, page, size, sort, unreadOnly, since, before, search, favourite);
            //Assert.IsType<PageSmsProjection>(response);
        }

        /// <summary>
        /// Test SendSmsFromPhoneNumber
        /// </summary>
        [Fact]
        public void SendSmsFromPhoneNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid phoneNumberId = null;
            //SmsSendOptions smsSendOptions = null;
            //var response = instance.SendSmsFromPhoneNumber(phoneNumberId, smsSendOptions);
            //Assert.IsType<SentSmsDto>(response);
        }

        /// <summary>
        /// Test SetConsentStatus
        /// </summary>
        [Fact]
        public void SetConsentStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool agree = null;
            //var response = instance.SetConsentStatus(agree);
            //Assert.IsType<ConsentStatusDto>(response);
        }

        /// <summary>
        /// Test SetPhoneFavourited
        /// </summary>
        [Fact]
        public void SetPhoneFavouritedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid phoneNumberId = null;
            //SetPhoneFavouritedOptions setPhoneFavouritedOptions = null;
            //var response = instance.SetPhoneFavourited(phoneNumberId, setPhoneFavouritedOptions);
            //Assert.IsType<PhoneNumberDto>(response);
        }

        /// <summary>
        /// Test TestPhoneNumberSendSms
        /// </summary>
        [Fact]
        public void TestPhoneNumberSendSmsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid phoneNumberId = null;
            //TestPhoneNumberOptions testPhoneNumberOptions = null;
            //string xTestId = null;
            //instance.TestPhoneNumberSendSms(phoneNumberId, testPhoneNumberOptions, xTestId);
        }

        /// <summary>
        /// Test UpdatePhoneNumber
        /// </summary>
        [Fact]
        public void UpdatePhoneNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid phoneNumberId = null;
            //UpdatePhoneNumberOptions updatePhoneNumberOptions = null;
            //var response = instance.UpdatePhoneNumber(phoneNumberId, updatePhoneNumberOptions);
            //Assert.IsType<PhoneNumberDto>(response);
        }

        /// <summary>
        /// Test ValidatePhoneNumber
        /// </summary>
        [Fact]
        public void ValidatePhoneNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ValidatePhoneNumberOptions validatePhoneNumberOptions = null;
            //var response = instance.ValidatePhoneNumber(validatePhoneNumberOptions);
            //Assert.IsType<PhoneNumberValidationDto>(response);
        }
    }
}
