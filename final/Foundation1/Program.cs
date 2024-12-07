using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Amazing Chocolate Chip Cookie Recipe", "Chef Sarah", 12);

        Comment comment1_1 = new Comment("BakingFan22", "These cookies look absolutely delicious! Can't wait to try this recipe this weekend.", "2 hours ago");
        Comment comment1_2 = new Comment("SweetTooth99", "The technique for mixing the dough looks so professional. Great tutorial!", "4 hours ago");
        Comment comment1_3 = new Comment("HomeCook47", "I've been looking for the perfect chocolate chip cookie recipe. This might be the one!", "1 day ago");
        Comment comment1_4 = new Comment("FoodieLife", "Love how detailed and clear the instructions are. Subscribed to the channel!", "3 days ago");

        video1.AddComment(comment1_1);
        video1.AddComment(comment1_2);
        video1.AddComment(comment1_3);
        video1.AddComment(comment1_4);

        video1.DisplayVideoDetails();
        video1.DisplayVideoComments();
        //
        Video video2 = new Video("Beginner's Guide to Mountain Hiking", "Outdoor Explorer Mark", 15);

        Comment comment2_1 = new Comment("TrailBlazer", "Super helpful tips for someone just starting out with hiking. Thank you!", "1 hours ago");
        Comment comment2_2 = new Comment("NatureLover55", "Great advice on safety and preparation. Really appreciate the detailed guidance.", "3 hours ago");
        Comment comment2_3 = new Comment("AdventureSeeker", "I've been wanting to start hiking but was always too intimidated. This video gave me confidence!", "7 hours ago");
        Comment comment2_4 = new Comment("GearHead23", "Nice breakdown of essential hiking gear for beginners. Very informative", "2 days ago");

        video2.AddComment(comment2_1);
        video2.AddComment(comment2_2);
        video2.AddComment(comment2_3);
        video2.AddComment(comment2_4);

        video2.DisplayVideoDetails();
        video2.DisplayVideoComments();

        Video video3 = new Video("Digital Art Fundamentals in Photoshop", "Emma Rodriguez Design", 20);

        Comment comment3_1 = new Comment("ArtStudent101", "These techniques are going to help me so much in my digital art class!", "1 minute ago");
        Comment comment3_2 = new Comment("CreativeMind", "Emma explains complex concepts so clearly. Love her teaching style.", "7 hours ago");
        Comment comment3_3 = new Comment("DesignPro", "Even as a professional, I picked up some new tricks from this tutorial.", "3 day ago");
        Comment comment3_4 = new Comment("Beginner_Artist", "Finally, a tutorial that doesn't assume I know everything already!", "6 days ago");

        video3.AddComment(comment3_1);
        video3.AddComment(comment3_2);
        video3.AddComment(comment3_3);
        video3.AddComment(comment3_4);

        video3.DisplayVideoDetails();
        video3.DisplayVideoComments();

    }
}