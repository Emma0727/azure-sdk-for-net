// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class DataLakeStoreAccountOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified firewall rule from the specified Data Lake Store
            /// account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account to delete the firewall rule from
            /// </param>
            /// <param name='firewallRuleName'>
            /// The name of the firewall rule to delete
            /// </param>
            public static void DeleteFirewallRule(this IDataLakeStoreAccountOperations operations, string resourceGroupName, string accountName, string firewallRuleName)
            {
                Task.Factory.StartNew(s => ((IDataLakeStoreAccountOperations)s).DeleteFirewallRuleAsync(resourceGroupName, accountName, firewallRuleName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified firewall rule from the specified Data Lake Store
            /// account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account to delete the firewall rule from
            /// </param>
            /// <param name='firewallRuleName'>
            /// The name of the firewall rule to delete
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteFirewallRuleAsync( this IDataLakeStoreAccountOperations operations, string resourceGroupName, string accountName, string firewallRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteFirewallRuleWithHttpMessagesAsync(resourceGroupName, accountName, firewallRuleName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets the specified Data Lake firewall rules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group the account is in.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account to get the firewall rules from
            /// </param>
            /// <param name='firewallRuleName'>
            /// the name of the firewall rule to retrieve.
            /// </param>
            public static FirewallRule GetFirewallRule(this IDataLakeStoreAccountOperations operations, string resourceGroupName, string accountName, string firewallRuleName)
            {
                return Task.Factory.StartNew(s => ((IDataLakeStoreAccountOperations)s).GetFirewallRuleAsync(resourceGroupName, accountName, firewallRuleName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified Data Lake firewall rules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group the account is in.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account to get the firewall rules from
            /// </param>
            /// <param name='firewallRuleName'>
            /// the name of the firewall rule to retrieve.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FirewallRule> GetFirewallRuleAsync( this IDataLakeStoreAccountOperations operations, string resourceGroupName, string accountName, string firewallRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.GetFirewallRuleWithHttpMessagesAsync(resourceGroupName, accountName, firewallRuleName, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// Lists the Data Lake firewall rules objects within the specified Data Lake
            /// Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account to get the firewall rules from
            /// </param>
            public static IPage<FirewallRule> ListFirewallRules(this IDataLakeStoreAccountOperations operations, string resourceGroupName, string accountName)
            {
                return Task.Factory.StartNew(s => ((IDataLakeStoreAccountOperations)s).ListFirewallRulesAsync(resourceGroupName, accountName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the Data Lake firewall rules objects within the specified Data Lake
            /// Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account to get the firewall rules from
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FirewallRule>> ListFirewallRulesAsync( this IDataLakeStoreAccountOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.ListFirewallRulesWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// Gets the next page of the Data Lake firewall rule objects within the
            /// specified account, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextLink'>
            /// The url to the next firewall rule page.
            /// </param>
            public static IPage<FirewallRule> FirewallRulesListNext(this IDataLakeStoreAccountOperations operations, string nextLink)
            {
                return Task.Factory.StartNew(s => ((IDataLakeStoreAccountOperations)s).FirewallRulesListNextAsync(nextLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the next page of the Data Lake firewall rule objects within the
            /// specified account, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextLink'>
            /// The url to the next firewall rule page.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FirewallRule>> FirewallRulesListNextAsync( this IDataLakeStoreAccountOperations operations, string nextLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.FirewallRulesListNextWithHttpMessagesAsync(nextLink, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// Creates or updates the specified Data Lake Store account with the
            /// specified firewall rules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group the account is in.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account to add the firewall rule to
            /// </param>
            /// <param name='name'>
            /// The new of the firewall rule to create or update.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create firewall rule operation.
            /// </param>
            public static FirewallRule CreateOrUpdateFirewallRule(this IDataLakeStoreAccountOperations operations, string resourceGroupName, string accountName, string name, FirewallRule parameters)
            {
                return Task.Factory.StartNew(s => ((IDataLakeStoreAccountOperations)s).CreateOrUpdateFirewallRuleAsync(resourceGroupName, accountName, name, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the specified Data Lake Store account with the
            /// specified firewall rules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group the account is in.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account to add the firewall rule to
            /// </param>
            /// <param name='name'>
            /// The new of the firewall rule to create or update.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create firewall rule operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FirewallRule> CreateOrUpdateFirewallRuleAsync( this IDataLakeStoreAccountOperations operations, string resourceGroupName, string accountName, string name, FirewallRule parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.CreateOrUpdateFirewallRuleWithHttpMessagesAsync(resourceGroupName, accountName, name, parameters, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// Creates the specified Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group the account will be associated with.
            /// </param>
            /// <param name='name'>
            /// The name of the Data Lake Store account to create.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create Data Lake Store account operation.
            /// </param>
            public static DataLakeStoreAccount Create(this IDataLakeStoreAccountOperations operations, string resourceGroupName, string name, DataLakeStoreAccount parameters)
            {
                return Task.Factory.StartNew(s => ((IDataLakeStoreAccountOperations)s).CreateAsync(resourceGroupName, name, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates the specified Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group the account will be associated with.
            /// </param>
            /// <param name='name'>
            /// The name of the Data Lake Store account to create.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create Data Lake Store account operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataLakeStoreAccount> CreateAsync( this IDataLakeStoreAccountOperations operations, string resourceGroupName, string name, DataLakeStoreAccount parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, name, parameters, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// Creates the specified Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group the account will be associated with.
            /// </param>
            /// <param name='name'>
            /// The name of the Data Lake Store account to create.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create Data Lake Store account operation.
            /// </param>
            public static DataLakeStoreAccount BeginCreate(this IDataLakeStoreAccountOperations operations, string resourceGroupName, string name, DataLakeStoreAccount parameters)
            {
                return Task.Factory.StartNew(s => ((IDataLakeStoreAccountOperations)s).BeginCreateAsync(resourceGroupName, name, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates the specified Data Lake Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group the account will be associated with.
            /// </param>
            /// <param name='name'>
            /// The name of the Data Lake Store account to create.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create Data Lake Store account operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataLakeStoreAccount> BeginCreateAsync( this IDataLakeStoreAccountOperations operations, string resourceGroupName, string name, DataLakeStoreAccount parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, name, parameters, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// Updates the Data Lake Store account object specified by the account name
            /// with the contents of the account object.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the Data Lake Store account to update.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the update Data Lake Store account operation.
            /// </param>
            public static DataLakeStoreAccount Update(this IDataLakeStoreAccountOperations operations, string resourceGroupName, string name, DataLakeStoreAccount parameters)
            {
                return Task.Factory.StartNew(s => ((IDataLakeStoreAccountOperations)s).UpdateAsync(resourceGroupName, name, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the Data Lake Store account object specified by the account name
            /// with the contents of the account object.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the Data Lake Store account to update.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the update Data Lake Store account operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataLakeStoreAccount> UpdateAsync( this IDataLakeStoreAccountOperations operations, string resourceGroupName, string name, DataLakeStoreAccount parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, name, parameters, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// Updates the Data Lake Store account object specified by the account name
            /// with the contents of the account object.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the Data Lake Store account to update.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the update Data Lake Store account operation.
            /// </param>
            public static DataLakeStoreAccount BeginUpdate(this IDataLakeStoreAccountOperations operations, string resourceGroupName, string name, DataLakeStoreAccount parameters)
            {
                return Task.Factory.StartNew(s => ((IDataLakeStoreAccountOperations)s).BeginUpdateAsync(resourceGroupName, name, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the Data Lake Store account object specified by the account name
            /// with the contents of the account object.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the Data Lake Store account to update.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the update Data Lake Store account operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataLakeStoreAccount> BeginUpdateAsync( this IDataLakeStoreAccountOperations operations, string resourceGroupName, string name, DataLakeStoreAccount parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, name, parameters, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// Deletes the Data Lake Store account object specified by the account name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account to delete
            /// </param>
            public static void Delete(this IDataLakeStoreAccountOperations operations, string resourceGroupName, string accountName)
            {
                Task.Factory.StartNew(s => ((IDataLakeStoreAccountOperations)s).DeleteAsync(resourceGroupName, accountName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the Data Lake Store account object specified by the account name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account to delete
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync( this IDataLakeStoreAccountOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Deletes the Data Lake Store account object specified by the account name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account to delete
            /// </param>
            public static void BeginDelete(this IDataLakeStoreAccountOperations operations, string resourceGroupName, string accountName)
            {
                Task.Factory.StartNew(s => ((IDataLakeStoreAccountOperations)s).BeginDeleteAsync(resourceGroupName, accountName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the Data Lake Store account object specified by the account name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account to delete
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync( this IDataLakeStoreAccountOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets the Data Lake Store account object specified by the account name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account to retrieve
            /// </param>
            public static DataLakeStoreAccount Get(this IDataLakeStoreAccountOperations operations, string resourceGroupName, string accountName)
            {
                return Task.Factory.StartNew(s => ((IDataLakeStoreAccountOperations)s).GetAsync(resourceGroupName, accountName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the Data Lake Store account object specified by the account name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the account to retrieve
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataLakeStoreAccount> GetAsync( this IDataLakeStoreAccountOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// Lists the Data Lake Store account objects within the subscription or
            /// within a specific resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// Gets or sets OData Select statement. Limits the properties on each entry
            /// to just those requested, e.g.
            /// Categories?$select=CategoryName,Description. Optional.
            /// </param>
            /// <param name='count'>
            /// Gets or sets a Boolean value of true or false to request a count of the
            /// matching resources included with the resources in the response, e.g.
            /// Categories?$count=true. Optional.
            /// </param>
            /// <param name='search'>
            /// Gets or sets a free form search. A free-text search expression to match
            /// for whether a particular entry should be included in the feed, e.g.
            /// Categories?$search=blue OR green. Optional.
            /// </param>
            /// <param name='format'>
            /// Gets or sets the return format. Return the response in particular
            /// formatxii without access to request headers for standard content-type
            /// negotiation (e.g Orders?$format=json). Optional.
            /// </param>
            public static IPage<DataLakeStoreAccount> List(this IDataLakeStoreAccountOperations operations, string resourceGroupName, ODataQuery<DataLakeStoreAccount> odataQuery = default(ODataQuery<DataLakeStoreAccount>), string select = default(string), bool? count = default(bool?), string search = default(string), string format = default(string))
            {
                return Task.Factory.StartNew(s => ((IDataLakeStoreAccountOperations)s).ListAsync(resourceGroupName, odataQuery, select, count, search, format), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the Data Lake Store account objects within the subscription or
            /// within a specific resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// Gets or sets OData Select statement. Limits the properties on each entry
            /// to just those requested, e.g.
            /// Categories?$select=CategoryName,Description. Optional.
            /// </param>
            /// <param name='count'>
            /// Gets or sets a Boolean value of true or false to request a count of the
            /// matching resources included with the resources in the response, e.g.
            /// Categories?$count=true. Optional.
            /// </param>
            /// <param name='search'>
            /// Gets or sets a free form search. A free-text search expression to match
            /// for whether a particular entry should be included in the feed, e.g.
            /// Categories?$search=blue OR green. Optional.
            /// </param>
            /// <param name='format'>
            /// Gets or sets the return format. Return the response in particular
            /// formatxii without access to request headers for standard content-type
            /// negotiation (e.g Orders?$format=json). Optional.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DataLakeStoreAccount>> ListAsync( this IDataLakeStoreAccountOperations operations, string resourceGroupName, ODataQuery<DataLakeStoreAccount> odataQuery = default(ODataQuery<DataLakeStoreAccount>), string select = default(string), bool? count = default(bool?), string search = default(string), string format = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, odataQuery, select, count, search, format, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// Lists the Data Lake firewall rules objects within the specified Data Lake
            /// Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<FirewallRule> ListFirewallRulesNext(this IDataLakeStoreAccountOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IDataLakeStoreAccountOperations)s).ListFirewallRulesNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the Data Lake firewall rules objects within the specified Data Lake
            /// Store account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FirewallRule>> ListFirewallRulesNextAsync( this IDataLakeStoreAccountOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.ListFirewallRulesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// Gets the next page of the Data Lake firewall rule objects within the
            /// specified account, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<FirewallRule> FirewallRulesListNextNext(this IDataLakeStoreAccountOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IDataLakeStoreAccountOperations)s).FirewallRulesListNextNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the next page of the Data Lake firewall rule objects within the
            /// specified account, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FirewallRule>> FirewallRulesListNextNextAsync( this IDataLakeStoreAccountOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.FirewallRulesListNextNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// Lists the Data Lake Store account objects within the subscription or
            /// within a specific resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DataLakeStoreAccount> ListNext(this IDataLakeStoreAccountOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IDataLakeStoreAccountOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the Data Lake Store account objects within the subscription or
            /// within a specific resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DataLakeStoreAccount>> ListNextAsync( this IDataLakeStoreAccountOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

    }
}
