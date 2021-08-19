namespace API.Entities
{
    public class UserLike
    {
        public AppUser SourceUser { get; set; }

        public int SourceUserId { get; set; }

        public AppUser LikedUser { get; set; }

        public int LikedUserId { get; set; }

        // public int LikedUsersId { get; internal set; }
        
        // public AppUser LikedUsers { get; internal set; }
    }
}
