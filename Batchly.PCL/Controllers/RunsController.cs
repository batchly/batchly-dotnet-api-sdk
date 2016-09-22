/*
 * Batchly.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 09/19/2016
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Batchly.PCL;
using Batchly.PCL.Http.Request;
using Batchly.PCL.Http.Response;
using Batchly.PCL.Http.Client;
using Batchly.PCL.Exceptions;
using Batchly.PCL.Models;

namespace Batchly.PCL.Controllers
{
    public partial class RunsController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static RunsController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static RunsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new RunsController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <return>Returns the ApiResponseBoolean response from the API call</return>
        public ApiResponseBoolean DeleteRun(string id)
        {
            Task<ApiResponseBoolean> t = DeleteRunAsync(id);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <return>Returns the ApiResponseBoolean response from the API call</return>
        public async Task<ApiResponseBoolean> DeleteRunAsync(string id)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/Runs/{id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "id", id }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "batchly/1.0.5" },
                { "accept", "application/json" }
            };
             // _headers.Add("Api-Key", Configuration.ApiKey);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Delete(_queryUrl, _headers, null);
            //Custom Authentication to be added for authorization
            AuthUtility.AppendCustomAuthParams(_request);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 404)
                throw new APIException(@"NotFound", _context);
            else if (_response.StatusCode == 401)
                throw new APIException(@"Validate Api keys", _context);

            else if (_response.StatusCode == 403)
                throw new APIException(@"Api key doesn't have required permission to execute operation", _context);

            else if (_response.StatusCode == 400)
                throw new APIException(@"Validation Error", _context);


            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<ApiResponseBoolean>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <return>Returns the ApiResponseBoolean response from the API call</return>
        public ApiResponseBoolean UpdateStopRun(string id)
        {
            Task<ApiResponseBoolean> t = UpdateStopRunAsync(id);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <return>Returns the ApiResponseBoolean response from the API call</return>
        public async Task<ApiResponseBoolean> UpdateStopRunAsync(string id)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/Runs/{id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "id", id }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "batchly/1.0.5" },
                { "accept", "application/json" }
            };
             // _headers.Add("Api-Key", Configuration.ApiKey);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Put(_queryUrl, _headers, null);
            //Custom Authentication to be added for authorization
            AuthUtility.AppendCustomAuthParams(_request);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 404)
                throw new APIException(@"NotFound", _context);
            else if (_response.StatusCode == 401)
                throw new APIException(@"Validate Api keys", _context);

            else if (_response.StatusCode == 403)
                throw new APIException(@"Api key doesn't have required permission to execute operation", _context);

            else if (_response.StatusCode == 400)
                throw new APIException(@"Validation Error", _context);


            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<ApiResponseBoolean>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <return>Returns the ApiResponseRunModel response from the API call</return>
        public ApiResponseRunModel GetDescribeRun(string id)
        {
            Task<ApiResponseRunModel> t = GetDescribeRunAsync(id);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <return>Returns the ApiResponseRunModel response from the API call</return>
        public async Task<ApiResponseRunModel> GetDescribeRunAsync(string id)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/Runs/{id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "id", id }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "batchly/1.0.5" },
                { "accept", "application/json" }
            };
             // _headers.Add("Api-Key", Configuration.ApiKey);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);
            //Custom Authentication to be added for authorization
            AuthUtility.AppendCustomAuthParams(_request);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 404)
                throw new APIException(@"NotFound", _context);
            else if (_response.StatusCode == 401)
                throw new APIException(@"Validate Api keys", _context);

            else if (_response.StatusCode == 403)
                throw new APIException(@"Api key doesn't have required permission to execute operation", _context);

            else if (_response.StatusCode == 400)
                throw new APIException(@"Validation Error", _context);


            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<ApiResponseRunModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="requestContinuationToken">Optional parameter: Example: </param>
        /// <param name="requestFilters">Optional parameter: Example: </param>
        /// <return>Returns the ApiResponseListRunModel response from the API call</return>
        public ApiResponseListRunModel ListRuns(string requestContinuationToken = null, object requestFilters = null)
        {
            Task<ApiResponseListRunModel> t = ListRunsAsync(requestContinuationToken, requestFilters);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="requestContinuationToken">Optional parameter: Example: </param>
        /// <param name="requestFilters">Optional parameter: Example: </param>
        /// <return>Returns the ApiResponseListRunModel response from the API call</return>
        public async Task<ApiResponseListRunModel> ListRunsAsync(string requestContinuationToken = null, object requestFilters = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/Runs");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "request.continuationToken", requestContinuationToken },
                { "request.filters", requestFilters }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "batchly/1.0.5" },
                { "accept", "application/json" }
            };
             // _headers.Add("Api-Key", Configuration.ApiKey);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);
            //Custom Authentication to be added for authorization
            AuthUtility.AppendCustomAuthParams(_request);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //Error handling using HTTP status codes
            if (_response.StatusCode == 401)
                throw new APIException(@"Validate Api keys", _context);

            else if (_response.StatusCode == 403)
                throw new APIException(@"Api key doesn't have required permission to execute operation", _context);

            else if (_response.StatusCode == 400)
                throw new APIException(@"Validation Error", _context);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<ApiResponseListRunModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <return>Returns the ApiResponseRunSummaryViewModel response from the API call</return>
        public ApiResponseRunSummaryViewModel GetRunSummary(string id)
        {
            Task<ApiResponseRunSummaryViewModel> t = GetRunSummaryAsync(id);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <return>Returns the ApiResponseRunSummaryViewModel response from the API call</return>
        public async Task<ApiResponseRunSummaryViewModel> GetRunSummaryAsync(string id)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/Runs/{id}/Summary");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "id", id }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "batchly/1.0.5" },
                { "accept", "application/json" }
            };
             // _headers.Add("Api-Key", Configuration.ApiKey);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);
            //Custom Authentication to be added for authorization
            AuthUtility.AppendCustomAuthParams(_request);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 404)
                throw new APIException(@"NotFound", _context);
            else if (_response.StatusCode == 401)
                throw new APIException(@"Validate Api keys", _context);

            else if (_response.StatusCode == 403)
                throw new APIException(@"Api key doesn't have required permission to execute operation", _context);

            else if (_response.StatusCode == 400)
                throw new APIException(@"Validation Error", _context);


            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<ApiResponseRunSummaryViewModel>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="requestId">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetRunsCheckRun(string requestId)
        {
            Task<dynamic> t = GetRunsCheckRunAsync(requestId);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="requestId">Required parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetRunsCheckRunAsync(string requestId)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/Runs/Check/{requestId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "requestId", requestId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "batchly/1.0.5" },
                { "accept", "application/json" }
            };
             // _headers.Add("Api-Key", Configuration.ApiKey);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);
            //Custom Authentication to be added for authorization
            AuthUtility.AppendCustomAuthParams(_request);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //Error handling using HTTP status codes
            if (_response.StatusCode == 401)
                throw new APIException(@"Validate Api keys", _context);

            else if (_response.StatusCode == 403)
                throw new APIException(@"Api key doesn't have required permission to execute operation", _context);

            else if (_response.StatusCode == 400)
                throw new APIException(@"Validation Error", _context);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 