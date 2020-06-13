namespace ApplicationExtensibility.Plugin.Models
{
    public interface IMenuInfo
    {
        string ParentMenu { get; }
        string MenuName { get; }
        string Filter { get; }
        bool MultiSelect { get; }
        string ShortcutKeys { get; }
        int? InsertIndex { get; }
    }
}