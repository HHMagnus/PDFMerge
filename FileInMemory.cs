using System.IO;
public class FileInMemory {
    public MemoryStream Stream {get; set;}

    public long Size {get; set;}

    public string Name {get; set;}

    public FileInMemory(MemoryStream Stream, long Size, string Name)
    {
        this.Stream = Stream;
        this.Size = Size;
        this.Name = Name;
    }
}