namespace Models
{
    public static class UrlApiWeb
    {
        public static string BaseUrl = "http://localhost:8181/api/";

        public static string GetBaseUrl(string url)
        {
            return $"{BaseUrl}{url}";
        }
    }
}
