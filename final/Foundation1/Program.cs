using System;

class Program
{
    static void Main(string[] args)
    {
        List<Comment> comments = new List<Comment>();
        List<Video> videos = new List<Video>();

        int quant2 = 0;
        while(quant2 <= 3){
            quant2 += 1;
            Comment c = new Comment($"Comment Author: Author{quant2}", $"This Authors comment: {quant2}00% I loved this video! Heart Heart Thumbs up!");
            comments.Add(c);
        }

        int quant = 0;
        while(quant <=2){
            quant += 1;
            Video v = new Video($"Video Title: Video{quant}", $"Author Name: Author{quant}", $"Video Length: {quant}000 Seconds", comments);
            videos.Add(v);
        }

        foreach(Video vid in videos){
            Console.WriteLine(vid.GetTitle());
            Console.WriteLine(vid.GetAuthor());
            Console.WriteLine(vid.GetLength());
            Console.WriteLine("---------Comments--------");
            foreach(Comment com in vid.GetComments()){
                Console.WriteLine(com.GetCommentAuthor());
                Console.WriteLine(com.GetComment());
            }
        Console.WriteLine("");
        }
    }
}