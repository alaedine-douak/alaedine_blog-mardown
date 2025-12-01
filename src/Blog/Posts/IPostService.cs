namespace Blog.Posts;

public interface IPostService
{
   Task<List<Post>> GetPostsAsync();
   Task<PostWithContent?> GetPostAsync(string slug); 
}
