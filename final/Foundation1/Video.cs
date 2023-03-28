public class Video{
    // Functional Methods
    public int GetNumberOfComments(){
        int numCom = 0;
        foreach (Comment c in _comments){
            numCom += 1;
        }
        return numCom;
    }
    public void DisplayVideoComments(){
        foreach(Comment c in _comments){
            Console.WriteLine(c.GetCommentAuthor());
            Console.WriteLine(c.GetComment());
        }
    }

    // Member Variables
    private string _title;
    private string _author;
    private string _length;
    private List<Comment> _comments = new List<Comment>{};

    // Getter and Setter Methods
    public  string GetTitle(){
        return _title;
    }
    public string GetAuthor(){
        return _author;
    }
    public string GetLength(){
        return _length;
    }
    public List<Comment> GetComments(){
        return _comments;
    }

    // Constructor Methods
    public Video(string title, string author, string length, List<Comment> comments){
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }
}