// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.MixedReality.RemoteRendering
{
    /// <summary> The result of a list sessions request. </summary>
    internal partial class SessionsList
    {
        /// <summary> Initializes a new instance of SessionsList. </summary>
        /// <param name="sessions"> The list of rendering sessions. Does not include sessions in &apos;Stopped&apos; state. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sessions"/> is null. </exception>
        internal SessionsList(IEnumerable<RenderingSession> sessions)
        {
            Argument.AssertNotNull(sessions, nameof(sessions));

            Sessions = sessions.ToList();
        }

        /// <summary> Initializes a new instance of SessionsList. </summary>
        /// <param name="sessions"> The list of rendering sessions. Does not include sessions in &apos;Stopped&apos; state. </param>
        /// <param name="nextLink"> If more rendering sessions are available this field will contain a URL where the next batch of sessions can be requested. This URL will need the same authentication as all calls to the Azure Remote Rendering API. </param>
        internal SessionsList(IReadOnlyList<RenderingSession> sessions, string nextLink)
        {
            Sessions = sessions;
            NextLink = nextLink;
        }

        /// <summary> The list of rendering sessions. Does not include sessions in &apos;Stopped&apos; state. </summary>
        public IReadOnlyList<RenderingSession> Sessions { get; }
        /// <summary> If more rendering sessions are available this field will contain a URL where the next batch of sessions can be requested. This URL will need the same authentication as all calls to the Azure Remote Rendering API. </summary>
        public string NextLink { get; }
    }
}
