public class Video
{
    public string _title{get; set;}
    public string _author{get; set;}
    public int _lengthInSeconds{get; set;}

    private List<Comment> _comments = new List<Comment>();

    //constructor
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    //method to add a comment
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);

    }

    // method to get the number of comments

    public int GetNumberOfComments()
    {
        return _comments.Count;

    }

    // method to get all comments
    public List<Comment> GetAllComments()
    {
        return _comments;
    }

}