namespace ApplicationExtensibility.Plugin.Models
{
    public class MenuInfo : IMenuInfo
    {
        public string ParentMenu { get; set; }
        public string MenuName { get; set; }
        public string Filter { get; set; }
        public bool MultiSelect { get; set; }
        public string ShortcutKeys { get; set; }
        public int? InsertIndex { get; set; }
    }
}