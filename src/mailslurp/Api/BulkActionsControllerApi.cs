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
    public interface IBulkActionsControllerApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Bulk create Inboxes (email addresses)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Number of inboxes to be created in bulk</param>
        /// <returns>List&lt;Inbox&gt;</returns>
        List<Inbox> BulkCreateInboxes (int count);

        /// <summary>
        /// Bulk create Inboxes (email addresses)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Number of inboxes to be created in bulk</param>
        /// <returns>ApiResponse of List&lt;Inbox&gt;</returns>
        ApiResponse<List<Inbox>> BulkCreateInboxesWithHttpInfo (int count);
        /// <summary>
        /// Bulk Delete Inboxes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">ids</param>
        /// <returns></returns>
        void BulkDeleteInboxes (List<Guid> ids);

        /// <summary>
        /// Bulk Delete Inboxes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">ids</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> BulkDeleteInboxesWithHttpInfo (List<Guid> ids);
        /// <summary>
        /// Bulk Send Emails
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulkSendEmailOptions">bulkSendEmailOptions</param>
        /// <returns></returns>
        void BulkSendEmails (BulkSendEmailOptions bulkSendEmailOptions);

        /// <summary>
        /// Bulk Send Emails
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulkSendEmailOptions">bulkSendEmailOptions</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> BulkSendEmailsWithHttpInfo (BulkSendEmailOptions bulkSendEmailOptions);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBulkActionsControllerApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Bulk create Inboxes (email addresses)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Number of inboxes to be created in bulk</param>
        /// <returns>Task of List&lt;Inbox&gt;</returns>
        System.Threading.Tasks.Task<List<Inbox>> BulkCreateInboxesAsync (int count);

        /// <summary>
        /// Bulk create Inboxes (email addresses)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Number of inboxes to be created in bulk</param>
        /// <returns>Task of ApiResponse (List&lt;Inbox&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Inbox>>> BulkCreateInboxesAsyncWithHttpInfo (int count);
        /// <summary>
        /// Bulk Delete Inboxes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">ids</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task BulkDeleteInboxesAsync (List<Guid> ids);

        /// <summary>
        /// Bulk Delete Inboxes
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">ids</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> BulkDeleteInboxesAsyncWithHttpInfo (List<Guid> ids);
        /// <summary>
        /// Bulk Send Emails
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulkSendEmailOptions">bulkSendEmailOptions</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task BulkSendEmailsAsync (BulkSendEmailOptions bulkSendEmailOptions);

        /// <summary>
        /// Bulk Send Emails
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulkSendEmailOptions">bulkSendEmailOptions</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> BulkSendEmailsAsyncWithHttpInfo (BulkSendEmailOptions bulkSendEmailOptions);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBulkActionsControllerApi : IBulkActionsControllerApiSync, IBulkActionsControllerApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BulkActionsControllerApi : IBulkActionsControllerApi
    {
        private mailslurp.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkActionsControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BulkActionsControllerApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkActionsControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BulkActionsControllerApi(String basePath)
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
        /// Initializes a new instance of the <see cref="BulkActionsControllerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BulkActionsControllerApi(mailslurp.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="BulkActionsControllerApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public BulkActionsControllerApi(mailslurp.Client.ISynchronousClient client,mailslurp.Client.IAsynchronousClient asyncClient, mailslurp.Client.IReadableConfiguration configuration)
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
        /// Bulk create Inboxes (email addresses) 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Number of inboxes to be created in bulk</param>
        /// <returns>List&lt;Inbox&gt;</returns>
        public List<Inbox> BulkCreateInboxes (int count)
        {
             mailslurp.Client.ApiResponse<List<Inbox>> localVarResponse = BulkCreateInboxesWithHttpInfo(count);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk create Inboxes (email addresses) 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Number of inboxes to be created in bulk</param>
        /// <returns>ApiResponse of List&lt;Inbox&gt;</returns>
        public mailslurp.Client.ApiResponse< List<Inbox> > BulkCreateInboxesWithHttpInfo (int count)
        {
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

            localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "count", count));

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< List<Inbox> >("/bulk/inboxes", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BulkCreateInboxes", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Bulk create Inboxes (email addresses) 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Number of inboxes to be created in bulk</param>
        /// <returns>Task of List&lt;Inbox&gt;</returns>
        public async System.Threading.Tasks.Task<List<Inbox>> BulkCreateInboxesAsync (int count)
        {
             mailslurp.Client.ApiResponse<List<Inbox>> localVarResponse = await BulkCreateInboxesAsyncWithHttpInfo(count);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bulk create Inboxes (email addresses) 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Number of inboxes to be created in bulk</param>
        /// <returns>Task of ApiResponse (List&lt;Inbox&gt;)</returns>
        public async System.Threading.Tasks.Task<mailslurp.Client.ApiResponse<List<Inbox>>> BulkCreateInboxesAsyncWithHttpInfo (int count)
        {

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
            
            localVarRequestOptions.QueryParameters.Add(mailslurp.Client.ClientUtils.ParameterToMultiMap("", "count", count));

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<List<Inbox>>("/bulk/inboxes", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BulkCreateInboxes", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Bulk Delete Inboxes 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">ids</param>
        /// <returns></returns>
        public void BulkDeleteInboxes (List<Guid> ids)
        {
             BulkDeleteInboxesWithHttpInfo(ids);
        }

        /// <summary>
        /// Bulk Delete Inboxes 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">ids</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public mailslurp.Client.ApiResponse<Object> BulkDeleteInboxesWithHttpInfo (List<Guid> ids)
        {
            // verify the required parameter 'ids' is set
            if (ids == null)
                throw new mailslurp.Client.ApiException(400, "Missing required parameter 'ids' when calling BulkActionsControllerApi->BulkDeleteInboxes");

            mailslurp.Client.RequestOptions localVarRequestOptions = new mailslurp.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };

            var localVarContentType = mailslurp.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = mailslurp.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = ids;

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/bulk/inboxes", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BulkDeleteInboxes", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Bulk Delete Inboxes 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">ids</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task BulkDeleteInboxesAsync (List<Guid> ids)
        {
             await BulkDeleteInboxesAsyncWithHttpInfo(ids);

        }

        /// <summary>
        /// Bulk Delete Inboxes 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">ids</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<mailslurp.Client.ApiResponse<Object>> BulkDeleteInboxesAsyncWithHttpInfo (List<Guid> ids)
        {
            // verify the required parameter 'ids' is set
            if (ids == null)
                throw new mailslurp.Client.ApiException(400, "Missing required parameter 'ids' when calling BulkActionsControllerApi->BulkDeleteInboxes");


            mailslurp.Client.RequestOptions localVarRequestOptions = new mailslurp.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = ids;

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/bulk/inboxes", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BulkDeleteInboxes", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Bulk Send Emails 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulkSendEmailOptions">bulkSendEmailOptions</param>
        /// <returns></returns>
        public void BulkSendEmails (BulkSendEmailOptions bulkSendEmailOptions)
        {
             BulkSendEmailsWithHttpInfo(bulkSendEmailOptions);
        }

        /// <summary>
        /// Bulk Send Emails 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulkSendEmailOptions">bulkSendEmailOptions</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public mailslurp.Client.ApiResponse<Object> BulkSendEmailsWithHttpInfo (BulkSendEmailOptions bulkSendEmailOptions)
        {
            // verify the required parameter 'bulkSendEmailOptions' is set
            if (bulkSendEmailOptions == null)
                throw new mailslurp.Client.ApiException(400, "Missing required parameter 'bulkSendEmailOptions' when calling BulkActionsControllerApi->BulkSendEmails");

            mailslurp.Client.RequestOptions localVarRequestOptions = new mailslurp.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };

            var localVarContentType = mailslurp.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = mailslurp.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = bulkSendEmailOptions;

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/bulk/send", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BulkSendEmails", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Bulk Send Emails 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulkSendEmailOptions">bulkSendEmailOptions</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task BulkSendEmailsAsync (BulkSendEmailOptions bulkSendEmailOptions)
        {
             await BulkSendEmailsAsyncWithHttpInfo(bulkSendEmailOptions);

        }

        /// <summary>
        /// Bulk Send Emails 
        /// </summary>
        /// <exception cref="mailslurp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulkSendEmailOptions">bulkSendEmailOptions</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<mailslurp.Client.ApiResponse<Object>> BulkSendEmailsAsyncWithHttpInfo (BulkSendEmailOptions bulkSendEmailOptions)
        {
            // verify the required parameter 'bulkSendEmailOptions' is set
            if (bulkSendEmailOptions == null)
                throw new mailslurp.Client.ApiException(400, "Missing required parameter 'bulkSendEmailOptions' when calling BulkActionsControllerApi->BulkSendEmails");


            mailslurp.Client.RequestOptions localVarRequestOptions = new mailslurp.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = bulkSendEmailOptions;

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/bulk/send", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BulkSendEmails", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
