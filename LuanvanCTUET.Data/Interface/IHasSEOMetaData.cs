namespace LuanvanCTUET.Data.Interface
{
    public interface IHasSEOMetaData
    {
        string SeoPageTitle { get; set; }
        string SeoAlias { get; set; }
        string SeoKeyword { get; set; }
        string SeoPageDescription { get; set; }
    }
}