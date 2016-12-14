// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.20.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   Translate API Version v2
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://developers.google.com/translate/v2/using_rest'>Translate API</a>
 *      <tr><th>API Version<td>v2
 *      <tr><th>API Rev<td>20160627 (543)
 *      <tr><th>API Docs
 *          <td><a href='https://developers.google.com/translate/v2/using_rest'>
 *              https://developers.google.com/translate/v2/using_rest</a>
 *      <tr><th>Discovery Name<td>translate
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using Translate API can be found at
 * <a href='https://developers.google.com/translate/v2/using_rest'>https://developers.google.com/translate/v2/using_rest</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.Translate.v2
{
    /// <summary>The Translate Service.</summary>
    public class TranslateService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public TranslateService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public TranslateService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            detections = new DetectionsResource(this);
            languages = new LanguagesResource(this);
            translations = new TranslationsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[] {"dataWrapper"}; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "translate"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
            get { return "https://www.googleapis.com/language/translate/"; }
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return "language/translate/"; }
        }





        private readonly DetectionsResource detections;

        /// <summary>Gets the Detections resource.</summary>
        public virtual DetectionsResource Detections
        {
            get { return detections; }
        }

        private readonly LanguagesResource languages;

        /// <summary>Gets the Languages resource.</summary>
        public virtual LanguagesResource Languages
        {
            get { return languages; }
        }

        private readonly TranslationsResource translations;

        /// <summary>Gets the Translations resource.</summary>
        public virtual TranslationsResource Translations
        {
            get { return translations; }
        }
    }

    ///<summary>A base abstract class for Translate requests.</summary>
    public abstract class TranslateBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new TranslateBaseServiceRequest instance.</summary>
        protected TranslateBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>Data format for the response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
        }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>IP address of the site where the request originates. Use this if you want to enforce per-user
        /// limits.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes Translate parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "userIp", new Google.Apis.Discovery.Parameter
                {
                    Name = "userIp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "detections" collection of methods.</summary>
    public class DetectionsResource
    {
        private const string Resource = "detections";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DetectionsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Detect the language of text.</summary>
        /// <param name="q">The text to detect</param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> q)
        {
            return new ListRequest(service, q);
        }

        /// <summary>Detect the language of text.</summary>
        public class ListRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v2.Data.DetectionsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> q)
                : base(service)
            {
                Q = q;
                InitParameters();
            }


            /// <summary>The text to detect</summary>
            [Google.Apis.Util.RequestParameterAttribute("q", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Q { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "list"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "v2/detect"; }
            }

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "q", new Google.Apis.Discovery.Parameter
                    {
                        Name = "q",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "languages" collection of methods.</summary>
    public class LanguagesResource
    {
        private const string Resource = "languages";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LanguagesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>List the source/target languages supported by the API</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>List the source/target languages supported by the API</summary>
        public class ListRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v2.Data.LanguagesListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service)
                : base(service)
            {
                InitParameters();
            }


            /// <summary>the language and collation in which the localized results should be returned</summary>
            [Google.Apis.Util.RequestParameterAttribute("target", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Target { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "list"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "v2/languages"; }
            }

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "target", new Google.Apis.Discovery.Parameter
                    {
                        Name = "target",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "translations" collection of methods.</summary>
    public class TranslationsResource
    {
        private const string Resource = "translations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TranslationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Returns text translations from one language to another.</summary>
        /// <param name="q">The text to translate</param>
        /// <param name="target">The target language into which the text
        /// should be translated</param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> q, string target)
        {
            return new ListRequest(service, q, target);
        }

        /// <summary>Returns text translations from one language to another.</summary>
        public class ListRequest : TranslateBaseServiceRequest<Google.Apis.Translate.v2.Data.TranslationsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> q, string target)
                : base(service)
            {
                Q = q;
                Target = target;
                InitParameters();
            }


            /// <summary>The text to translate</summary>
            [Google.Apis.Util.RequestParameterAttribute("q", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Q { get; private set; }

            /// <summary>The target language into which the text should be translated</summary>
            [Google.Apis.Util.RequestParameterAttribute("target", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Target { get; private set; }

            /// <summary>The customization id for translate</summary>
            [Google.Apis.Util.RequestParameterAttribute("cid", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Cid { get; set; }

            /// <summary>The format of the text</summary>
            [Google.Apis.Util.RequestParameterAttribute("format", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<FormatEnum> Format { get; set; }

            /// <summary>The format of the text</summary>
            public enum FormatEnum
            {
                /// <summary>Specifies the input is in HTML</summary>
                [Google.Apis.Util.StringValueAttribute("html")]
                Html,
                /// <summary>Specifies the input is in plain textual format</summary>
                [Google.Apis.Util.StringValueAttribute("text")]
                Text,
            }

            /// <summary>The source language of the text</summary>
            [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Source { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "list"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "v2"; }
            }

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "q", new Google.Apis.Discovery.Parameter
                    {
                        Name = "q",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "target", new Google.Apis.Discovery.Parameter
                    {
                        Name = "target",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "cid", new Google.Apis.Discovery.Parameter
                    {
                        Name = "cid",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "format", new Google.Apis.Discovery.Parameter
                    {
                        Name = "format",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "source", new Google.Apis.Discovery.Parameter
                    {
                        Name = "source",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }
}

namespace Google.Apis.Translate.v2.Data
{    

    public class DetectionsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A detections contains detection results of several text</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detections")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IList<DetectionsResourceItems>> Detections { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class DetectionsResourceItems : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The confidence of the detection resul of this language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; } 

        /// <summary>A boolean to indicate is the language detection result reliable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isReliable")]
        public virtual System.Nullable<bool> IsReliable { get; set; } 

        /// <summary>The language we detect</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LanguagesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of source/target languages supported by the translation API. If target parameter is
        /// unspecified, the list is sorted by the ASCII code point order of the language code. If target parameter is
        /// specified, the list is sorted by the collation order of the language name in the target language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languages")]
        public virtual System.Collections.Generic.IList<LanguagesResource> Languages { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LanguagesResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The language code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; } 

        /// <summary>The localized name of the language if target parameter is given.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class TranslationsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Translations contains list of translation results of given text</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("translations")]
        public virtual System.Collections.Generic.IList<TranslationsResource> Translations { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class TranslationsResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detected source language if source parameter is unspecified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedSourceLanguage")]
        public virtual string DetectedSourceLanguage { get; set; } 

        /// <summary>The translation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("translatedText")]
        public virtual string TranslatedText { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
