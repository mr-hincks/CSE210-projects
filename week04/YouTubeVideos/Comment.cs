public class Comment
{
    //properties
    public string _commenterName{get;set;}
    public string _commentText{get; set; }

    //Constructor
    public Comment(string commenterName,string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

}