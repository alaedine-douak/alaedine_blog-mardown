namespace Blog.Posts;

internal interface IPostService
{
   Task<List<Post>> GetPostsAsync();
   Task<PostWithContent?> GetPostAsync(string slug); 
}
