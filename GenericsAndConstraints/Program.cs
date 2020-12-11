using System;
using System.Collections.Generic;

namespace WinProg_Week9_GenericsAndConstraints
{
    public class StaticDemo<T>
    {
        public static int x;
    }
    public interface IDocument
    {
        string Title { get; set; }
        string Content { get; set; }
    }
    public class Document:IDocument
    {
        public Document()
        {

        }
        public Document(string title,string content)
        {
            this.Title = title;
            this.Content = content;
                
        }
        public string Title { get; set; }
        public string Content { get; set; }

    }
    public class DocumentManager<T> where T:IDocument // constraint'i bu sekilde verebiliyoruz.  
    {
        private readonly Queue<T> documentQueue = new Queue<T>();
        public void AddDocument(T doc)
        {
            documentQueue.Enqueue(doc);
        }
        public bool IsDocumentAvailable
        {
            get { return documentQueue.Count > 0; } //eger eleman varsa true döner.
        }
        public T Getdocument()
        {
            T doc = default(T);
            doc = documentQueue.Dequeue();
            return doc;
        }
        public void DisplayAllDocuments()
        {
            foreach(T doc in documentQueue)
            {
                Console.WriteLine(doc.Title+" "+doc.Content);
            }
        }


    }




    class Program
    {

        static void Main(string[] args)
        {
            DocumentManager<Document> dm = new DocumentManager<Document>();
            dm.AddDocument(new Document("Title A", "Sample A"));
            dm.AddDocument(new Document("Title B", "Sample B"));
            dm.DisplayAllDocuments();
            bool x=dm.IsDocumentAvailable;
            Console.WriteLine(x);
        }
    }
}
