public class JsonDataTemplate : IDataTemplate
{
    public string JsonFormat { get; set; }

    public IDataTemplate Clone()
    {
        return new JsonDataTemplate { JsonFormat = this.JsonFormat };
    }
}