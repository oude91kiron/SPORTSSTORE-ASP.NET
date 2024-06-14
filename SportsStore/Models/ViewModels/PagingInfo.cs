namespace SportsStore.Models.ViewModels
{
    public class PagingInfo
    {
        /// <summary>
        /// Model Feilds Provide Page info.
        /// </summary>
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages => (int)Math.Ceiling((double)TotalItems / ItemsPerPage);
    }
}
