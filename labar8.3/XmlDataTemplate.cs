public class XmlDataTemplate : IDataTemplate
{
    public string XmlFormat { get; set; }

    public IDataTemplate Clone()
    {
        return new XmlDataTemplate { XmlFormat = this.XmlFormat };
    }
}