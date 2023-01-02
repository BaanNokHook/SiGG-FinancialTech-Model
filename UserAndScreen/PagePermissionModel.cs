namespace GM.Model.UserAndScreen
{
    public class PagePermissionModel
    {
        public string UserID { get; set; }
        public int ScreenID { get; set; }
        public string ScreenName { get; set; }
        public string Controller { get; set; }
        public bool CreateFlag { get; set; }
        public bool UpdateFlag { get; set; }
        public bool DeleteFlag { get; set; }
        public bool ViewFlag { get; set; }
    }
}
