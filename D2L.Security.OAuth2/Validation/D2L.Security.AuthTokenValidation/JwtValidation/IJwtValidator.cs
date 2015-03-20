﻿namespace D2L.Security.AuthTokenValidation.JwtValidation {
	
	/// <summary>
	/// Entry point into validating a jwt
	/// </summary>
	interface IJwtValidator {
		IValidatedToken Validate( string jwt );
	}
}
