using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<Video> videosList = new List<Video>();

        Video video1 = new Video();
        video1._title = "She Will Be Loved ";
        video1._length = "268";
        video1._author = "Maroon 5";
        Comment video1Comment1 = new Comment();
        video1Comment1._name = "Lauren Tracy";
        video1Comment1._commentText = "Best song ever!.";
        Comment video1Comment2 = new Comment();
        video1Comment2._name = "Averie Gumter";
        video1Comment2._commentText = "I love your music! marooneee 4ever!";
        Comment video1Comment3 = new Comment();
        video1Comment3._name = "Karen Smith";
        video1Comment3._commentText = "this is my life soundtrack!";

        Video video2 = new Video();
        video2._title = "Love Me Like You";
        video2._length = "223";
        video2._author = "Little Mix ";
        Comment video2Comment1 = new Comment();
        video2Comment1._name = "Avy Stark";
        video2Comment1._commentText = "I was cooking while lsitening this song!";
        Comment video2Comment2 = new Comment();
        video2Comment2._name = "Bonnie Marshall";
        video2Comment2._commentText = "Amazing video!";
        Comment video2Comment3 = new Comment();
        video2Comment3._name = "Lori Nelson";
        video2Comment3._commentText = "I can never get tired of this song.";

        Video video3 = new Video();
        video3._title = "Shake It Off";
        video3._length = "241";
        video3._author = "Taylor Swift";
        Comment video3Comment1 = new Comment();
        video3Comment1._name = "Lusie lane";
        video3Comment1._commentText = "Thank you so much for this song! sometimes we need to shake it off!";
        Comment video3Comment2 = new Comment();
        video3Comment2._name = "Louis Lane";
        video3Comment2._commentText = "Thank you!, helps me a lot! :D";
        Comment video3Comment3 = new Comment();
        video3Comment3._name = "Daphne Christensen ";
        video3Comment3._commentText = "You are one of my favorite artists! Swiftyyy 4ever!!";
        Comment video3Comment4 = new Comment();
        video3Comment4._name = "Jhonny Chapman";
        video3Comment4._commentText = "Love this song! ";


        video1._commentList.Add(video1Comment1);
        video1._commentList.Add(video1Comment2);
        video1._commentList.Add(video1Comment3);

        video2._commentList.Add(video2Comment1);
        video2._commentList.Add(video2Comment2);
        video2._commentList.Add(video2Comment3);

        video3._commentList.Add(video3Comment1);
        video3._commentList.Add(video3Comment2);
        video3._commentList.Add(video3Comment3);
        video3._commentList.Add(video3Comment4);


        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }

    }
}