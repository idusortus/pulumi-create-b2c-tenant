using Pulumi;
// using Pulumi.AzureNative.AzureActiveDirectory.V20190101Preview;
using AzureNative = Pulumi.AzureNative;

class B2CStack : Stack
{
    public B2CStack()
    {
        var b2cTenant = new AzureNative.AzureActiveDirectory.B2CTenant("b2cTenant", new AzureNative.AzureActiveDirectory.B2CTenantArgs
        {
            Location = "United States",
            Properties = new AzureNative.AzureActiveDirectory.Inputs.CreateTenantRequestBodyPropertiesArgs
            {
                CountryCode = "US",
                DisplayName = "CleverName",
            },
            ResourceGroupName = "name-of-existing-resource-group",
            ResourceName = "CleverName.onmicrosoft.com",
            Sku = new AzureNative.AzureActiveDirectory.Inputs.B2CResourceSKUArgs
            {
                Name = AzureNative.AzureActiveDirectory.B2CResourceSKUName.Standard,
                Tier = AzureNative.AzureActiveDirectory.B2CResourceSKUTier.A0,
            },
        });
    }
}