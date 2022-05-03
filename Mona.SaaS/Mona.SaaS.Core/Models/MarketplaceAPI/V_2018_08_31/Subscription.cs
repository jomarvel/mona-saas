﻿// MICROSOFT CONFIDENTIAL INFORMATION
//
// Copyright © Microsoft Corporation
//
// Microsoft Corporation (or based on where you live, one of its affiliates) licenses this preview code for your internal testing purposes only.
//
// Microsoft provides the following preview code AS IS without warranty of any kind. The preview code is not supported under any Microsoft standard support program or services.
//
// Microsoft further disclaims all implied warranties including, without limitation, any implied warranties of merchantability or of fitness for a particular purpose. The entire risk arising out of the use or performance of the preview code remains with you.
//
// In no event shall Microsoft be liable for any damages whatsoever (including, without limitation, damages for loss of business profits, business interruption, loss of business information, or other pecuniary loss) arising out of the use of or inability to use the preview code, even if Microsoft has been advised of the possibility of such damages.

namespace Mona.SaaS.Core.Models.MarketplaceAPI.V_2018_08_31
{
    using Newtonsoft.Json;

    public class Subscription
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publisherId")]
        public string PublisherId { get; set; }

        [JsonProperty("offerId")]
        public string OfferId { get; set; }

        [JsonProperty("planId")]
        public string PlanId { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("beneficiary")]
        public MarketplaceUser Beneficiary { get; set; }

        [JsonProperty("purchaser")]
        public MarketplaceUser Purchaser { get; set; }

        [JsonProperty("isFreeTrial")]
        public bool? IsFreeTrial { get; set; }

        [JsonProperty("isTest")]
        public bool? IsTest { get; set; }

        [JsonProperty("saasSubscriptionStatus")]
        public string Status { get; set; }

        [JsonProperty("term")]
        public MarketplaceTerm Term { get; set; }
    }
}
