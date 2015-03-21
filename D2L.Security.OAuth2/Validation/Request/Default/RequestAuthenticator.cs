﻿using System.Net.Http;
using System.Web;
using D2L.Security.OAuth2.Validation.Request.Core;

namespace D2L.Security.OAuth2.Validation.Request.Default {
	internal sealed class RequestAuthenticator : IRequestAuthenticator {

		private readonly ICoreAuthenticator m_coreAuthenticator;

		internal RequestAuthenticator( ICoreAuthenticator coreAuthenticator ) {
			m_coreAuthenticator = coreAuthenticator;
		}

		AuthenticationResult IRequestAuthenticator.AuthenticateAndExtract( HttpRequestMessage request, out ID2LPrincipal principal ) {
			string cookie = request.GetCookieValue();
			string bearerToken = request.GetBearerTokenValue();
			string xsrfToken = request.GetXsrfValue();

			return m_coreAuthenticator.Authenticate( cookie, xsrfToken, bearerToken, out principal );
		}

		AuthenticationResult IRequestAuthenticator.AuthenticateAndExtract( HttpRequest request, out ID2LPrincipal principal ) {
			string cookie = request.GetCookieValue();
			string bearerToken = request.GetBearerTokenValue();
			string xsrfToken = request.GetXsrfValue();

			return m_coreAuthenticator.Authenticate( cookie, xsrfToken, bearerToken, out principal );
		}
	}
}