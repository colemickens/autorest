// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsHttp
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    public static partial class HttpRedirectsExtensions
    {
            /// <summary>
            /// Return 300 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void Head300(this IHttpRedirects operations)
            {
                Task.Factory.StartNew(s => ((IHttpRedirects)s).Head300Async(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return 300 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Head300Async( this IHttpRedirects operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Head300WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Return 300 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<string> Get300(this IHttpRedirects operations)
            {
                return Task.Factory.StartNew(s => ((IHttpRedirects)s).Get300Async(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return 300 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> Get300Async( this IHttpRedirects operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<IList<string>> result = await operations.Get300WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Return 301 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void Head301(this IHttpRedirects operations)
            {
                Task.Factory.StartNew(s => ((IHttpRedirects)s).Head301Async(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return 301 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Head301Async( this IHttpRedirects operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Head301WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Return 301 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void Get301(this IHttpRedirects operations)
            {
                Task.Factory.StartNew(s => ((IHttpRedirects)s).Get301Async(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return 301 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Get301Async( this IHttpRedirects operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Get301WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Put true Boolean value in request returns 301.  This request should not be
            /// automatically redirected, but should return the received 301 to the
            /// caller for evaluation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            public static void Put301(this IHttpRedirects operations, bool? booleanValue = default(bool?))
            {
                Task.Factory.StartNew(s => ((IHttpRedirects)s).Put301Async(booleanValue), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put true Boolean value in request returns 301.  This request should not be
            /// automatically redirected, but should return the received 301 to the
            /// caller for evaluation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Put301Async( this IHttpRedirects operations, bool? booleanValue = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Put301WithHttpMessagesAsync(booleanValue, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Return 302 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void Head302(this IHttpRedirects operations)
            {
                Task.Factory.StartNew(s => ((IHttpRedirects)s).Head302Async(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return 302 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Head302Async( this IHttpRedirects operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Head302WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Return 302 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void Get302(this IHttpRedirects operations)
            {
                Task.Factory.StartNew(s => ((IHttpRedirects)s).Get302Async(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return 302 status code and redirect to /http/success/200
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Get302Async( this IHttpRedirects operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Get302WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Patch true Boolean value in request returns 302.  This request should not
            /// be automatically redirected, but should return the received 302 to the
            /// caller for evaluation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            public static void Patch302(this IHttpRedirects operations, bool? booleanValue = default(bool?))
            {
                Task.Factory.StartNew(s => ((IHttpRedirects)s).Patch302Async(booleanValue), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Patch true Boolean value in request returns 302.  This request should not
            /// be automatically redirected, but should return the received 302 to the
            /// caller for evaluation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Patch302Async( this IHttpRedirects operations, bool? booleanValue = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Patch302WithHttpMessagesAsync(booleanValue, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Post true Boolean value in request returns 303.  This request should be
            /// automatically redirected usign a get, ultimately returning a 200 status
            /// code
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            public static void Post303(this IHttpRedirects operations, bool? booleanValue = default(bool?))
            {
                Task.Factory.StartNew(s => ((IHttpRedirects)s).Post303Async(booleanValue), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Post true Boolean value in request returns 303.  This request should be
            /// automatically redirected usign a get, ultimately returning a 200 status
            /// code
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Post303Async( this IHttpRedirects operations, bool? booleanValue = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Post303WithHttpMessagesAsync(booleanValue, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Redirect with 307, resulting in a 200 success
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void Head307(this IHttpRedirects operations)
            {
                Task.Factory.StartNew(s => ((IHttpRedirects)s).Head307Async(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Redirect with 307, resulting in a 200 success
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Head307Async( this IHttpRedirects operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Head307WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Redirect get with 307, resulting in a 200 success
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void Get307(this IHttpRedirects operations)
            {
                Task.Factory.StartNew(s => ((IHttpRedirects)s).Get307Async(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Redirect get with 307, resulting in a 200 success
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Get307Async( this IHttpRedirects operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Get307WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Put redirected with 307, resulting in a 200 after redirect
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            public static void Put307(this IHttpRedirects operations, bool? booleanValue = default(bool?))
            {
                Task.Factory.StartNew(s => ((IHttpRedirects)s).Put307Async(booleanValue), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put redirected with 307, resulting in a 200 after redirect
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Put307Async( this IHttpRedirects operations, bool? booleanValue = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Put307WithHttpMessagesAsync(booleanValue, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Patch redirected with 307, resulting in a 200 after redirect
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            public static void Patch307(this IHttpRedirects operations, bool? booleanValue = default(bool?))
            {
                Task.Factory.StartNew(s => ((IHttpRedirects)s).Patch307Async(booleanValue), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Patch redirected with 307, resulting in a 200 after redirect
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Patch307Async( this IHttpRedirects operations, bool? booleanValue = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Patch307WithHttpMessagesAsync(booleanValue, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Post redirected with 307, resulting in a 200 after redirect
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            public static void Post307(this IHttpRedirects operations, bool? booleanValue = default(bool?))
            {
                Task.Factory.StartNew(s => ((IHttpRedirects)s).Post307Async(booleanValue), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Post redirected with 307, resulting in a 200 after redirect
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Post307Async( this IHttpRedirects operations, bool? booleanValue = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Post307WithHttpMessagesAsync(booleanValue, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Delete redirected with 307, resulting in a 200 after redirect
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            public static void Delete307(this IHttpRedirects operations, bool? booleanValue = default(bool?))
            {
                Task.Factory.StartNew(s => ((IHttpRedirects)s).Delete307Async(booleanValue), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete redirected with 307, resulting in a 200 after redirect
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Delete307Async( this IHttpRedirects operations, bool? booleanValue = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Delete307WithHttpMessagesAsync(booleanValue, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
