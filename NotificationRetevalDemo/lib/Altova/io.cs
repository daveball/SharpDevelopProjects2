// io.cs
// This file contains generated code and will be overwritten when you rerun code generation.

using System.IO;
using System.Xml;
using System.Text;

namespace Altova.IO
{
    public abstract class Input
    {
        public enum InputType {Reader = 0, Stream = 1, XmlDocument = 2}
        private InputType type;

        public Input(InputType t) { type = t; }
        public InputType Type { get { return type; } }
        public abstract TextReader Reader { get; }
        public abstract Stream Stream { get; }
        public abstract XmlDocument Document { get; }
        public virtual void Close() {}
    };

    public class StreamInput : Input
    {
        private Stream stream;
        public StreamInput(Stream s) : base(InputType.Stream) { stream = s; }

        public override Stream Stream { get { return stream;} }
        public override TextReader Reader { get {throw new System.Exception("This is not a reader"); } }
        public override XmlDocument Document { get {throw new System.Exception("This is not an XML Dom tree"); } }
        public override void Close() {stream.Close();}
    };

    public class FileInput : StreamInput
    {
        private string filename;
        public FileInput(string f) : base(System.IO.File.OpenRead(f)) { filename = f; }

        public string Filename { get { return filename; } }
    };

    public class ReaderInput : Input
    {
        private TextReader reader;
        public ReaderInput(TextReader r) : base(InputType.Reader)
        {
            reader = r;
        }

        public override Stream Stream { get { throw new System.Exception("This is not a stream"); } }
        public override TextReader Reader { get { return reader; } }
        public override XmlDocument Document { get { throw new System.Exception("This is not an XML Dom tree"); } }
        public override void Close() {reader.Close();}
    };

    public class StringInput : ReaderInput
    {
        private string content;
        public StringInput(string c) : base(new System.IO.StringReader(c))
        {
            content = c;
        }

        public string Content { get { return content; } }
    };

    public class DocumentInput : Input
    {
        private XmlDocument document;
        public DocumentInput(XmlDocument d) : base(InputType.XmlDocument) { document = d; }

        public override TextReader Reader { get { throw new System.Exception("This is not a reader"); } }
        public override Stream Stream { get { throw new System.Exception("This is not a stream"); } }
        public override XmlDocument Document { get { return document; } }
    };

    public abstract class Output
    {
        public enum OutputType {Writer = 0, Stream = 1, XmlDocument = 2}
        public OutputType type;

        public Output(OutputType t) { type = t; }
        public OutputType Type { get { return type; } }
        public abstract TextWriter Writer { get; }
        public abstract Stream Stream { get; }
        public abstract XmlDocument Document { get; }
        public virtual void Close() {}
    };

    public class StreamOutput : Output
    {
        private Stream stream;
        public StreamOutput(Stream s) : base(OutputType.Stream) { stream = s; }

        public override Stream Stream { get { return stream; } }
        public override TextWriter Writer { get { throw new System.Exception("This is not a writer"); } }
        public override XmlDocument Document { get { throw new System.Exception("This is not an XML Dom tree"); } }
        public override void Close() {stream.Close();}
    };

    public class FileOutput : StreamOutput
    {
        private string filename;
        public FileOutput(string f) : this(f, System.IO.FileMode.Create) {}
        public FileOutput(string f, System.IO.FileMode fm) : base(new FileStream(f, fm)) { filename = f; }
        public string Fielname { get { return filename; } }
    };

    public class WriterOutput : Output
    {
        private TextWriter writer;
        public WriterOutput(TextWriter w) : base (OutputType.Writer) { writer = w; }

        public override Stream Stream { get { throw new System.Exception("This is not a stream"); } }
        public override TextWriter Writer { get { return writer; } }
        public override XmlDocument Document { get { throw new System.Exception("This is not an XML Dom tree"); } }
        public override void Close() {writer.Close();}
    };

    public class StringOutput : WriterOutput
    {
        private StringBuilder content;
        public StringOutput(StringBuilder s) : base (new System.IO.StringWriter(s)) { content = s; }

        public StringBuilder Content { get { return content; } }
    };

    public class DocumentOutput : Output
    {
        private XmlDocument document;
        public DocumentOutput(XmlDocument d) : base(OutputType.XmlDocument) { document = d; }

        public override Stream Stream { get { throw new System.Exception("This is not a stream"); } }
        public override TextWriter Writer { get { throw new System.Exception("This is not a writer"); } }
        public override XmlDocument Document { get { return document; } }
    };
}
