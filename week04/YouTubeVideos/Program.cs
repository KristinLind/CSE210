using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)

}
//Create 3-4 videos
List<Video> videos = List<videos>();

Video video1 = new videos("Adventure in Peru", "Beyond Travel", 420);
video1.AddComment(new Comment("Stacy", "This was so beautiful!"))
video1.AddComment(new Comment("Alice", "Machu Picchu was my favorite place."));
video1.AddComment(new Comment("John", "Machu Picchu mountain was a beautiful hike."));
video1.AddComment(new Comment("Charles", "Bucket list was fulfilled today."));
videos.Add(video1)

Video video2 = new videos("Cooking with Fish", "Chef Tiffany" 300);
video2.AddComment(new Comment("Amelia", "This is my new favorite recipe."))
video2.AddComment(new Comment("Derek", "I can't believe how good this tastes."));
video2.AddComment(new Comment("Ella", "This was so yummy!"));
video2.AddComment(new Comment("Kim", "Can you do any mediteranian dishes?"));
videos.Add(video2);

video3 video3 = new videos("Pilates with Crystal", Trainer Crystal" 520);
video3.AddComment(new Comment("Gina", "I am feeling the burn"));
video3.AddComment(new Comment("Jenny", "I love this workout."));
video3.AddComment(new Comment("Diane", "My abs have gotten stronger. Thank you!"));
videos.Add(video3);

// Now Display each video and its comments
foreach (Video video in videos)
{
    Console.WriteLine($"Title: {video.Title}");
    Console.WriteLine($"Author: {video.Author}");
    Console.WriteLine($"Length: {video.Length} seconde");
    Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
    Console.WriteLine("Comments:");
    foreach (Comment comment in video.Comments)
    {
        Console.WriteLine($"- {comment.Name}: {comment.Text}");

    }
    Console.WriteLine(new string('-', 40));
}
}

class Video
{
    public string Title { get; }
    public string Author { get; }
    public int Length { get; }
    public List<Comment> Comments { get; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }
    public int GetCommentCount()
    {
        return Comments.Count;
    }
}
class Comment
{
    public string Name { get; }
    public string Text { get; }

    public Comment(string name string text)
    {
        Name = name;
        Text = text;
    }
}


