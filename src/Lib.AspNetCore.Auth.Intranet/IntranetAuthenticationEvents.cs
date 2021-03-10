﻿using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Lib.AspNetCore.Auth.Intranet
{
    public class IntranetAuthenticationEvents
    {
        /// <summary>
        /// Invoked after the security token has passed validation and a ClaimsIdentity has been generated.
        /// </summary>
        public Func<MessageReceivedContext, Task> OnMessageReceived { get; set; } = context => Task.CompletedTask;

        public Func<AddressMatchedContext, Task> OnAddressMatched { get; set; } = context => Task.CompletedTask;

        public Func<AuthenticatedContext, Task> OnAuthenticated { get; set; } = context => Task.CompletedTask;

        public virtual Task MessageReceived(MessageReceivedContext context) => OnMessageReceived(context);
        public virtual Task AddressMatched(AddressMatchedContext context) => OnAddressMatched(context);
        public virtual Task Authenticated(AuthenticatedContext context) => OnAuthenticated(context);
    }
}