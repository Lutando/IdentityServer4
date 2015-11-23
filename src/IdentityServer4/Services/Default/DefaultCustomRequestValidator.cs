﻿/*
 * Copyright 2014, 2015 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using IdentityServer4.Core.Validation;
using System.Threading.Tasks;

namespace IdentityServer4.Core.Services.Default
{
    /// <summary>
    /// Default custom request validator
    /// </summary>
    public class DefaultCustomRequestValidator : ICustomRequestValidator
    {
        /// <summary>
        /// Custom validation logic for the authorize request.
        /// </summary>
        /// <param name="request">The validated request.</param>
        /// <returns>
        /// The validation result
        /// </returns>
        // todo
        //public Task<AuthorizeRequestValidationResult> ValidateAuthorizeRequestAsync(ValidatedAuthorizeRequest request)
        //{
        //    return Task.FromResult(new AuthorizeRequestValidationResult
        //    {
        //        IsError = false
        //    });
        //}

        /// <summary>
        /// Custom validation logic for the token request.
        /// </summary>
        /// <param name="request">The validated request.</param>
        /// <returns>
        /// The validation result
        /// </returns>
        public Task<TokenRequestValidationResult> ValidateTokenRequestAsync(ValidatedTokenRequest request)
        {
            return Task.FromResult(new TokenRequestValidationResult
            {
                IsError = false
            });
        }
    }
}