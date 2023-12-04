public class CsvDataTemplate : IDataTemplate
{
    public string CsvFormat { get; set; }

    public IDataTemplate Clone()
    {
        return new CsvDataTemplate { CsvFormat = this.CsvFormat };
    }
}