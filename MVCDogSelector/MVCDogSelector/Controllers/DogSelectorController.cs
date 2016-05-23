using MVCDogSelector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDogSelector.Controllers
{
    public class DogSelectorController : Controller
    {
        const int No_MATCH = 50;

        // GET: DogSelector
        [HttpGet]
        public ActionResult Index()
        {

            return View("SelectDog");
        }

        [HttpPost]
        public ActionResult Index(Dog selectedDog)
        {
            Dog matchchedDog = null;
            List<Dog> dogDataBase = makeDatabase();

            foreach(Dog currentDog in dogDataBase)
            {
                currentDog.MatchScore = computeMatchScore(selectedDog, currentDog);
            }



            IEnumerable<Dog> lowestScoringDog = dogDataBase.Where(d => (d.MatchScore == dogDataBase.Min(cd => cd.MatchScore)));

            matchchedDog = lowestScoringDog.First();

            foreach(Dog d in lowestScoringDog)
            {
                System.Diagnostics.Debug.WriteLine(d.DisplayName + " " + d.MatchScore);
            }

            return View("DisplayDog", lowestScoringDog);
        }

        private int computeMatchScore(Dog UserDog, Dog DatabaseDog)
        {
            int score = 0;

            if((UserDog.GoodWithChildren == true) && (DatabaseDog.GoodWithChildren == false))
            {
                return No_MATCH;
            }

            if((UserDog.Drools == true) && (DatabaseDog.Drools == true))
            {
                return No_MATCH;
            }

            score += Math.Abs((int)UserDog.ActivityLevel - (int)DatabaseDog.ActivityLevel);

            score += Math.Abs((int)UserDog.SheddingLevel - (int)DatabaseDog.SheddingLevel);

            score += Math.Abs((int)UserDog.IntelligenceLevel - (int)DatabaseDog.IntelligenceLevel);

            score += Math.Abs((int)UserDog.Coatlength - (int)DatabaseDog.Coatlength);

            score += Math.Abs((int)UserDog.Size - (int)DatabaseDog.Size);

            return score;
        }



        //=========================================================================
        private List<Dog> makeDatabase()
        {
            List<Dog> newDatabase = new List<Dog>();

            Dog afghanHound = new Dog();
            afghanHound.BreedName = "afghanHound";
            afghanHound.DisplayName = "Afghan Hound";
            afghanHound.ActivityLevel = EScale.High;
            afghanHound.Coatlength = ELength.Long;
            afghanHound.Drools = false;
            afghanHound.GoodWithChildren = false;
            afghanHound.GroomingLevel = EScale.High;
            afghanHound.IntelligenceLevel = EScale.Low;
            afghanHound.SheddingLevel = EScale.High;
            afghanHound.Size = ESize.Large;
            afghanHound.ImageName = "AfghanHound.jpg";
            newDatabase.Add(afghanHound);


            Dog bassetHound = new Dog();
            bassetHound.BreedName = "BassetHound";
            bassetHound.DisplayName = "Basset Hound";
            bassetHound.ActivityLevel = EScale.Medium;
            bassetHound.Coatlength = ELength.Short;
            bassetHound.Drools = true;
            bassetHound.GoodWithChildren = true;
            bassetHound.GroomingLevel = EScale.Low;
            bassetHound.IntelligenceLevel = EScale.Medium;
            bassetHound.SheddingLevel = EScale.Low;
            bassetHound.Size = ESize.Medium;
            bassetHound.ImageName = "BassetHound.jpg";
            newDatabase.Add(bassetHound);

            Dog beagle = new Dog()
            {
                BreedName = "Beagle",
                DisplayName = "Beagle",
                ActivityLevel = EScale.High,
                Coatlength = ELength.Short,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.Medium,
                IntelligenceLevel = EScale.Medium,
                SheddingLevel = EScale.Low,
                Size = ESize.Medium,
                ImageName = "Beagle.jpg"
            };
            newDatabase.Add(beagle);

            Dog bichonFrise = new Dog()
            {
                BreedName = "BichonFrise",
                DisplayName = "Bichon Frise",
                ActivityLevel = EScale.High,
                Coatlength = ELength.Medium,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.Low,
                Size = ESize.Small,
                ImageName = "Bichonfrise.jpg"
            };
            newDatabase.Add(bichonFrise);



            Dog borzoi = new Dog()
            {
                BreedName = "Borzoi",
                DisplayName = "Borzoi",
                ActivityLevel = EScale.High,
                Coatlength = ELength.Long,
                Drools = false,
                GoodWithChildren = false,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.High,
                Size = ESize.Large,
                ImageName = "Borzoi.jpg"
            };
            newDatabase.Add(borzoi);

            Dog bulldog = new Dog()
            {
                BreedName = "Bulldog",
                DisplayName = "Bull Dog",
                ActivityLevel = EScale.Medium,
                Coatlength = ELength.Short,
                Drools = true,
                GoodWithChildren = false,
                GroomingLevel = EScale.Low,
                IntelligenceLevel = EScale.Medium,
                SheddingLevel = EScale.Low,
                Size = ESize.Medium,
                ImageName = "Bulldog.jpg"
            };
            newDatabase.Add(bulldog);


            Dog cav = new Dog()
            {
                BreedName = "CavalierKingCharlesSpaniel",
                DisplayName = "Cavalier King Charles Spaniel",
                ActivityLevel = EScale.Medium,
                Coatlength = ELength.Medium,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.Medium,
                SheddingLevel = EScale.Medium,
                Size = ESize.Small,
                ImageName = "CavalierKingCharlesSpaniel.jpg"
            };
            newDatabase.Add(cav);


            Dog chowchow = new Dog()
            {
                BreedName = "Chowchow",
                DisplayName = "Chow Chow",
                ActivityLevel = EScale.Medium,
                Coatlength = ELength.Long,
                Drools = true,
                GoodWithChildren = false,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.High,
                Size = ESize.Large,
                ImageName = "Chowchow.jpg"
            };
            newDatabase.Add(chowchow);

            Dog dalmation = new Dog()
            {
                BreedName = "Dalmation",
                DisplayName = "Dalmation",
                ActivityLevel = EScale.High,
                Coatlength = ELength.Short,
                Drools = false,
                GoodWithChildren = false,
                GroomingLevel = EScale.Medium,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.Low,
                Size = ESize.Large,
                ImageName = "Dalmation.jpg"
            };
            newDatabase.Add(dalmation);

            Dog goldenRetriever = new Dog()
            {
                BreedName = "GoldenRetriever",
                DisplayName = "Golden Retriever",
                ActivityLevel = EScale.High,
                Coatlength = ELength.Long,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.Medium,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.High,
                Size = ESize.Large,
                ImageName = "GoldenRetriever.jpg"
            };
            newDatabase.Add(goldenRetriever);

            Dog maltese = new Dog()
            {
                BreedName = "Maltese",
                DisplayName = "Maltese",
                ActivityLevel = EScale.High,
                Coatlength = ELength.Long,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.High,
                Size = ESize.Miniature,
                ImageName = "Maltese.jpg"
            };
            newDatabase.Add(maltese);

            Dog newfoundland = new Dog()
            {
                BreedName = "Newfoundland",
                DisplayName = "Newfoundland",
                ActivityLevel = EScale.High,
                Coatlength = ELength.Long,
                Drools = true,
                GoodWithChildren = true,
                GroomingLevel = EScale.Medium,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.High,
                Size = ESize.Giant,
                ImageName = "newfoundland.jpg"
            };
            newDatabase.Add(newfoundland);

            Dog oldEnglishSheepdog = new Dog()
            {
                BreedName = "OldEnglishSheepdog",
                DisplayName = "Old English Sheepdog",
                ActivityLevel = EScale.High,
                Coatlength = ELength.Long,
                Drools = true,
                GoodWithChildren = true,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.Medium,
                SheddingLevel = EScale.High,
                Size = ESize.Giant,
                ImageName = "OldEnglishSheepdog.jpg"
            };
            newDatabase.Add(oldEnglishSheepdog);

            Dog pug = new Dog()
            {
                BreedName = "Pug",
                DisplayName = "Pug",
                ActivityLevel = EScale.High,
                Coatlength = ELength.Short,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.Low,
                IntelligenceLevel = EScale.Low,
                SheddingLevel = EScale.Low,
                Size = ESize.Miniature,
                ImageName = "Pug.jpg"
            };
            newDatabase.Add(pug);


            Dog westHighlandWhiteTerrier = new Dog()
            {
                BreedName = "WestHighlandWhiteTerrier",
                DisplayName = "West Highland White Terrier",
                ActivityLevel = EScale.High,
                Coatlength = ELength.Medium,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.Medium,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.Medium,
                Size = ESize.Small,
                ImageName = "WestHighlandWhiteTerrier.jpg"
            };
            newDatabase.Add(westHighlandWhiteTerrier);

            return newDatabase;
        }
      

    }
}