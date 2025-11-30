namespace Blog.Posts;

internal class FilePostServiceOptions
{
   public string PostsDirectory { get; set; } = string.Empty;
}

internal class FilePostServiceOptionsSetup(IConfiguration config) : IConfigureOptions<FilePostServiceOptions>
{
   private const string SectionName = nameof(FilePostServiceOptions);
   private readonly IConfiguration _config = config;
   public void Configure(FilePostServiceOptions options)
   {
      _config.GetSection(SectionName).Bind(options);
   }
}