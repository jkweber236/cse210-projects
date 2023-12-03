using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video catFails = new Video("Funny Cat Fails", "Olivia Turner", 300);
        Comment catOne = new Comment("WhiskerWonders87", "Funniest video I've ever seen!");
        catFails.AddComment(catOne);
        Comment catTwo = new Comment("MeowsterMind", "Poor cats!");
        catFails.AddComment(catTwo);
        Comment catThree = new Comment("PurrfectLaughs123", "Please make more cat fail videos!");
        catFails.AddComment(catThree);
        videos.Add(catFails);

        Video goats = new Video("Screaming Goats Compilation", "Daniel Parker", 270);
        Comment goatOne = new Comment("NatureLover237", "I never realized how hilarious goats are!!");
        goats.AddComment(goatOne);
        Comment goatTwo = new Comment("GoatFanatic862", "Those goats are so precious!");
        goats.AddComment(goatTwo);
        Comment goatThree = new Comment("GrinningGoatGuy", "I laughed so hard I had tears streaming down my face!");
        goats.AddComment(goatThree);
        Comment goatFour = new Comment("AverageJoe", "Didn't even crack a smile. BORING");
        goats.AddComment(goatFour);
        videos.Add(goats);
        
        Video explosions = new Video("Epic Explosions", "Emily Johnson", 210);
        Comment explosionOne = new Comment("ThrillChaser88", "This is very stress-relieving for some reason.");
        explosions.AddComment(explosionOne);
        Comment explosionTwo = new Comment("KaboomFanatic12", "This is like a scene straight out of an action movie!");
        explosions.AddComment(explosionTwo);
        Comment explosionThree = new Comment("BlastEnthusiast532", "Make sure to turn the volume down before starting the video...");
        explosions.AddComment(explosionThree);
        videos.Add(explosions);

        Video office = new Video("Office Olympics", "Alex Rodriquez", 600);
        Comment officeOne = new Comment("CubicleChampion32", "I want a rematch!");
        office.AddComment(officeOne);
        Comment officeTwo = new Comment("SpreadsheetEnthusiast", "My office needs to step up its game - we've never had competitions like this!");
        office.AddComment(officeTwo);
        Comment officeThree = new Comment("JusttheJanitor907", "Never though I'd be so invested in office sports!");
        office.AddComment(officeThree);
        Comment officeFour = new Comment("BossMan56", "These gusy are taking the phrase 'work hard, play hard' to a whole new level.");
        office.AddComment(officeFour);
        videos.Add(office);

         foreach(Video video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine();
        }
    }
}