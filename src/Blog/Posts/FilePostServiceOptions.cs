namespace Blog.Posts;

public class FilePostServiceOptions
{
   public string PostsDirectory { get; set; } = string.Empty;
}

public class FilePostServiceOptionsSetup(IConfiguration config) : IConfigureOptions<FilePostServiceOptions>
{
   private const string SectionName = nameof(FilePostServiceOptions);
   private readonly IConfiguration _config = config;
   public void Configure(FilePostServiceOptions options)
   {
      _config.GetSection(SectionName).Bind(options);
   }
}