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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using mailslurp.Client;
using mailslurp.Model;

namespace mailslurp.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMailServerControllerApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get DNS Mail Server records for a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="describeOptions">describeOptions</param>
        /// <returns>DescribeMailServerDomainResult</returns>
        DescribeMailServerDomainResult DescribeMailServerDomain (DescribeDomainOptions describeOptions);

        /// <summary>
        /// Get DNS Mail Server records for a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="describeOptions">describeOptions</param>
        /// <returns>ApiResponse of DescribeMailServerDomainResult</returns>
        ApiResponse<DescribeMailServerDomainResult> DescribeMailServerDomainWithHttpInfo (DescribeDomainOptions describeOptions);
        /// <summary>
        /// Lookup DNS records for a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsLookupOptions">dnsLookupOptions</param>
        /// <returns>DNSLookupResults</returns>
        DNSLookupResults GetDnsLookup (DNSLookupOptions dnsLookupOptions);

        /// <summary>
        /// Lookup DNS records for a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsLookupOptions">dnsLookupOptions</param>
        /// <returns>ApiResponse of DNSLookupResults</returns>
        ApiResponse<DNSLookupResults> GetDnsLookupWithHttpInfo (DNSLookupOptions dnsLookupOptions);
        /// <summary>
        /// Get IP address for a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">name</param>
        /// <returns>IPAddressResult</returns>
        IPAddressResult GetIpAddress (string name);

        /// <summary>
        /// Get IP address for a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">name</param>
        /// <returns>ApiResponse of IPAddressResult</returns>
        ApiResponse<IPAddressResult> GetIpAddressWithHttpInfo (string name);
        /// <summary>
        /// Verify the existence of an email address at a given mail server.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyOptions">verifyOptions</param>
        /// <returns>EmailVerificationResult</returns>
        EmailVerificationResult VerifyEmailAddress (VerifyEmailAddressOptions verifyOptions);

        /// <summary>
        /// Verify the existence of an email address at a given mail server.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyOptions">verifyOptions</param>
        /// <returns>ApiResponse of EmailVerificationResult</returns>
        ApiResponse<EmailVerificationResult> VerifyEmailAddressWithHttpInfo (VerifyEmailAddressOptions verifyOptions);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMailServerControllerApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get DNS Mail Server records for a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="describeOptions">describeOptions</param>
        /// <returns>Task of DescribeMailServerDomainResult</returns>
        System.Threading.Tasks.Task<DescribeMailServerDomainResult> DescribeMailServerDomainAsync (DescribeDomainOptions describeOptions);

        /// <summary>
        /// Get DNS Mail Server records for a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="describeOptions">describeOptions</param>
        /// <returns>Task of ApiResponse (DescribeMailServerDomainResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<DescribeMailServerDomainResult>> DescribeMailServerDomainAsyncWithHttpInfo (DescribeDomainOptions describeOptions);
        /// <summary>
        /// Lookup DNS records for a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsLookupOptions">dnsLookupOptions</param>
        /// <returns>Task of DNSLookupResults</returns>
        System.Threading.Tasks.Task<DNSLookupResults> GetDnsLookupAsync (DNSLookupOptions dnsLookupOptions);

        /// <summary>
        /// Lookup DNS records for a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsLookupOptions">dnsLookupOptions</param>
        /// <returns>Task of ApiResponse (DNSLookupResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<DNSLookupResults>> GetDnsLookupAsyncWithHttpInfo (DNSLookupOptions dnsLookupOptions);
        /// <summary>
        /// Get IP address for a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">name</param>
        /// <returns>Task of IPAddressResult</returns>
        System.Threading.Tasks.Task<IPAddressResult> GetIpAddressAsync (string name);

        /// <summary>
        /// Get IP address for a domain
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">name</param>
        /// <returns>Task of ApiResponse (IPAddressResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<IPAddressResult>> GetIpAddressAsyncWithHttpInfo (string name);
        /// <summary>
        /// Verify the existence of an email address at a given mail server.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyOptions">verifyOptions</param>
        /// <returns>Task of EmailVerificationResult</returns>
        System.Threading.Tasks.Task<EmailVerificationResult> VerifyEmailAddressAsync (VerifyEmailAddressOptions verifyOptions);

        /// <summary>
        /// Verify the existence of an email address at a given mail server.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyOptions">verifyOptions</param>
        /// <returns>Task of ApiResponse (EmailVerificationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailVerificationResult>> VerifyEmailAddressAsyncWithHttpInfo (VerifyEmailAddressOptions verifyOptions);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMailServerControllerApi : IMailServerControllerApiSync, IMailServerControllerApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MailServerControllerApi : IMailServerControllerApi
    {
        private mailslurp.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MailServerControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MailServerControllerApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MailServerControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MailServerControllerApi(String basePath)
        {
            this.Configuration = mailslurp.Client.Configuration.MergeConfigurations(
                mailslurp.Client.GlobalConfiguration.Instance,
                new mailslurp.Client.Configuration { BasePath = basePath }
            );
            this.Client = new mailslurp.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new mailslurp.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = mailslurp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MailServerControllerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MailServerControllerApi(mailslurp.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = mailslurp.Client.Configuration.MergeConfigurations(
                mailslurp.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new mailslurp.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new mailslurp.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = mailslurp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MailServerControllerApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public MailServerControllerApi(mailslurp.Client.ISynchronousClient client,mailslurp.Client.IAsynchronousClient asyncClient, mailslurp.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = mailslurp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public mailslurp.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public mailslurp.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public mailslurp.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public mailslurp.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get DNS Mail Server records for a domain 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="describeOptions">describeOptions</param>
        /// <returns>DescribeMailServerDomainResult</returns>
        public DescribeMailServerDomainResult DescribeMailServerDomain (DescribeDomainOptions describeOptions)
        {
             mailslurp.Client.ApiResponse<DescribeMailServerDomainResult> localVarResponse = DescribeMailServerDomainWithHttpInfo(describeOptions);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get DNS Mail Server records for a domain 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="describeOptions">describeOptions</param>
        /// <returns>ApiResponse of DescribeMailServerDomainResult</returns>
        public mailslurp.Client.ApiResponse< DescribeMailServerDomainResult > DescribeMailServerDomainWithHttpInfo (DescribeDomainOptions describeOptions)
        {
            // verify the required parameter 'describeOptions' is set
            if (describeOptions == null)
                throw new mailslurp.Client.ApiException(400, "Missing required parameter 'describeOptions' when calling MailServerControllerApi->DescribeMailServerDomain");

            mailslurp.Client.RequestOptions localVarRequestOptions = new mailslurp.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = mailslurp.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = mailslurp.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = describeOptions;

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< DescribeMailServerDomainResult >("/mail-server/describe/domain", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DescribeMailServerDomain", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get DNS Mail Server records for a domain 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="describeOptions">describeOptions</param>
        /// <returns>Task of DescribeMailServerDomainResult</returns>
        public async System.Threading.Tasks.Task<DescribeMailServerDomainResult> DescribeMailServerDomainAsync (DescribeDomainOptions describeOptions)
        {
             mailslurp.Client.ApiResponse<DescribeMailServerDomainResult> localVarResponse = await DescribeMailServerDomainAsyncWithHttpInfo(describeOptions);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get DNS Mail Server records for a domain 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="describeOptions">describeOptions</param>
        /// <returns>Task of ApiResponse (DescribeMailServerDomainResult)</returns>
        public async System.Threading.Tasks.Task<mailslurp.Client.ApiResponse<DescribeMailServerDomainResult>> DescribeMailServerDomainAsyncWithHttpInfo (DescribeDomainOptions describeOptions)
        {
            // verify the required parameter 'describeOptions' is set
            if (describeOptions == null)
                throw new mailslurp.Client.ApiException(400, "Missing required parameter 'describeOptions' when calling MailServerControllerApi->DescribeMailServerDomain");


            mailslurp.Client.RequestOptions localVarRequestOptions = new mailslurp.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = describeOptions;

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<DescribeMailServerDomainResult>("/mail-server/describe/domain", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DescribeMailServerDomain", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Lookup DNS records for a domain 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsLookupOptions">dnsLookupOptions</param>
        /// <returns>DNSLookupResults</returns>
        public DNSLookupResults GetDnsLookup (DNSLookupOptions dnsLookupOptions)
        {
             mailslurp.Client.ApiResponse<DNSLookupResults> localVarResponse = GetDnsLookupWithHttpInfo(dnsLookupOptions);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lookup DNS records for a domain 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsLookupOptions">dnsLookupOptions</param>
        /// <returns>ApiResponse of DNSLookupResults</returns>
        public mailslurp.Client.ApiResponse< DNSLookupResults > GetDnsLookupWithHttpInfo (DNSLookupOptions dnsLookupOptions)
        {
            // verify the required parameter 'dnsLookupOptions' is set
            if (dnsLookupOptions == null)
                throw new mailslurp.Client.ApiException(400, "Missing required parameter 'dnsLookupOptions' when calling MailServerControllerApi->GetDnsLookup");

            mailslurp.Client.RequestOptions localVarRequestOptions = new mailslurp.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = mailslurp.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = mailslurp.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = dnsLookupOptions;

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< DNSLookupResults >("/mail-server/describe/dns-lookup", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDnsLookup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Lookup DNS records for a domain 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsLookupOptions">dnsLookupOptions</param>
        /// <returns>Task of DNSLookupResults</returns>
        public async System.Threading.Tasks.Task<DNSLookupResults> GetDnsLookupAsync (DNSLookupOptions dnsLookupOptions)
        {
             mailslurp.Client.ApiResponse<DNSLookupResults> localVarResponse = await GetDnsLookupAsyncWithHttpInfo(dnsLookupOptions);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lookup DNS records for a domain 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dnsLookupOptions">dnsLookupOptions</param>
        /// <returns>Task of ApiResponse (DNSLookupResults)</returns>
        public async System.Threading.Tasks.Task<mailslurp.Client.ApiResponse<DNSLookupResults>> GetDnsLookupAsyncWithHttpInfo (DNSLookupOptions dnsLookupOptions)
        {
            // verify the required parameter 'dnsLookupOptions' is set
            if (dnsLookupOptions == null)
                throw new mailslurp.Client.ApiException(400, "Missing required parameter 'dnsLookupOptions' when calling MailServerControllerApi->GetDnsLookup");


            mailslurp.Client.RequestOptions localVarRequestOptions = new mailslurp.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = dnsLookupOptions;

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<DNSLookupResults>("/mail-server/describe/dns-lookup", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDnsLookup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get IP address for a domain 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">name</param>
        /// <returns>IPAddressResult</returns>
        public IPAddressResult GetIpAddress (string name)
        {
             mailslurp.Client.ApiResponse<IPAddressResult> localVarResponse = GetIpAddressWithHttpInfo(name);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get IP address for a domain 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">name</param>
        /// <returns>ApiResponse of IPAddressResult</returns>
        public mailslurp.Client.ApiResponse< IPAddressResult > GetIpAddressWithHttpInfo (string name)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new mailslurp.Client.ApiException(400, "Missing required parameter 'name' when calling MailServerControllerApi->GetIpAddress");

            mailslurp.Client.RequestOptions localVarRequestOptions = new mailslurp.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = mailslurp.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = mailslurp.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "name", name));

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< IPAddressResult >("/mail-server/describe/ip-address", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetIpAddress", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get IP address for a domain 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">name</param>
        /// <returns>Task of IPAddressResult</returns>
        public async System.Threading.Tasks.Task<IPAddressResult> GetIpAddressAsync (string name)
        {
             mailslurp.Client.ApiResponse<IPAddressResult> localVarResponse = await GetIpAddressAsyncWithHttpInfo(name);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get IP address for a domain 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">name</param>
        /// <returns>Task of ApiResponse (IPAddressResult)</returns>
        public async System.Threading.Tasks.Task<mailslurp.Client.ApiResponse<IPAddressResult>> GetIpAddressAsyncWithHttpInfo (string name)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new mailslurp.Client.ApiException(400, "Missing required parameter 'name' when calling MailServerControllerApi->GetIpAddress");


            mailslurp.Client.RequestOptions localVarRequestOptions = new mailslurp.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "name", name));

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<IPAddressResult>("/mail-server/describe/ip-address", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetIpAddress", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Verify the existence of an email address at a given mail server. 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyOptions">verifyOptions</param>
        /// <returns>EmailVerificationResult</returns>
        public EmailVerificationResult VerifyEmailAddress (VerifyEmailAddressOptions verifyOptions)
        {
             mailslurp.Client.ApiResponse<EmailVerificationResult> localVarResponse = VerifyEmailAddressWithHttpInfo(verifyOptions);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Verify the existence of an email address at a given mail server. 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyOptions">verifyOptions</param>
        /// <returns>ApiResponse of EmailVerificationResult</returns>
        public mailslurp.Client.ApiResponse< EmailVerificationResult > VerifyEmailAddressWithHttpInfo (VerifyEmailAddressOptions verifyOptions)
        {
            // verify the required parameter 'verifyOptions' is set
            if (verifyOptions == null)
                throw new mailslurp.Client.ApiException(400, "Missing required parameter 'verifyOptions' when calling MailServerControllerApi->VerifyEmailAddress");

            mailslurp.Client.RequestOptions localVarRequestOptions = new mailslurp.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = mailslurp.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = mailslurp.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = verifyOptions;

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< EmailVerificationResult >("/mail-server/verify/email-address", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("VerifyEmailAddress", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Verify the existence of an email address at a given mail server. 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyOptions">verifyOptions</param>
        /// <returns>Task of EmailVerificationResult</returns>
        public async System.Threading.Tasks.Task<EmailVerificationResult> VerifyEmailAddressAsync (VerifyEmailAddressOptions verifyOptions)
        {
             mailslurp.Client.ApiResponse<EmailVerificationResult> localVarResponse = await VerifyEmailAddressAsyncWithHttpInfo(verifyOptions);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Verify the existence of an email address at a given mail server. 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyOptions">verifyOptions</param>
        /// <returns>Task of ApiResponse (EmailVerificationResult)</returns>
        public async System.Threading.Tasks.Task<mailslurp.Client.ApiResponse<EmailVerificationResult>> VerifyEmailAddressAsyncWithHttpInfo (VerifyEmailAddressOptions verifyOptions)
        {
            // verify the required parameter 'verifyOptions' is set
            if (verifyOptions == null)
                throw new mailslurp.Client.ApiException(400, "Missing required parameter 'verifyOptions' when calling MailServerControllerApi->VerifyEmailAddress");


            mailslurp.Client.RequestOptions localVarRequestOptions = new mailslurp.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = verifyOptions;

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<EmailVerificationResult>("/mail-server/verify/email-address", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("VerifyEmailAddress", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
