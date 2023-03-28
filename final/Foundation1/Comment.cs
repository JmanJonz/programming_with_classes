public class Comment{
    // Functional Methods


    // Member Variables
    private string _commentAuthor;
    private string _comment;

    // Getter and Setter Methods
    public string GetCommentAuthor(){
        return _commentAuthor;
    }
    public string GetComment(){
        return _comment;
    }


    // Constructor Methods
    public Comment(string author, string comment){
        _commentAuthor = author;
        _comment = comment;
    }
}