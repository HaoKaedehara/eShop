namespace eShop.Database.Entities.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public int CreateUserID { get; set; }
        public int UpdateUserID { get; set; }
    }
}
