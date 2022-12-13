namespace FluentAPI;

[Flags]
public enum ApplicableDataEntitlementTypes : long
{
    AssetGroup = 1,
    PhysicalAsset = AssetGroup << 1,
    Product = PhysicalAsset << 1,
    AssetGroupAndPhysicalAsset = AssetGroup | PhysicalAsset,
    AssetGroupAndProduct = AssetGroup | Product,
    PhysicalAssetAndProject = PhysicalAsset | Product,
    All = AssetGroup | PhysicalAsset | Product
}