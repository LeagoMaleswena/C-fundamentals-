using System;
using System.Collections.Generic;

namespace rerun_prg161
{
    internal class Program
    {
        //Leago Maleswena 602970, Nhlamulo Ngwana 603014, Tshembo Chabalala 601928
        // Global Declarations
        static string[,] myCust = new string[0, 5];
        static List<string> ProductName = new List<string>();
        static List<double> ProductPrice = new List<double>();

        // enums
        enum MainMenu
        {
            captureCust = 1,
            Movie,
            DVD,
            VHS_Tapes,
            checkOut,
            displayCust,
            exit
        }
        enum Movie
        {
            horror = 1,
            action,
            sci_fi,
            anime,
            exit
        }
        enum Horror
        {
            getOut = 1,
            conjuring,
            quietPlace,
            shining,
            hannahGrace,
            exit
        }
        enum Action
        {
            madMax = 1,
            johnWick,
            gladiator,
            terminator,
            missionImpos,
            exit
        }
        enum sciFi
        {
            interstellar = 1,
            starWars,
            Inception,
            bladeRunner,
            theMatrix,
            exit
        }
        enum anime
        {
            spiritedAway = 1,
            wolfChildren,
            silentVoice,
            howlsMovingCastle,
            myNeighToto,
            exit
        }
        enum cd
        {
            jazz = 1,
            rnb,
            hip_hop,
            classical,
            lofi,
            indie_rock,
            exit
        }
        enum Jazz
        {
            KindOfBlue = 1,
            BlueTrain,
            TimeOut,
            exit
        }
        enum RnB 
        {
            Thriller = 1,
            PurpleRain,
            Confessions,
            exit
        }
        enum HipHop
        {
            Illmatic = 1,
            TheChronic,
            ReadyToDie,
            exit
        }
        enum Classical
        {
            FourSeasons = 1,
            MoonlightSonata,
            SymphonyNine,
            exit
        }
        enum Lofi
        {
            ChillBeats = 1,
            CozyVibes,
            LateNightLoFi,
            exit
        }
        enum IndieRock
        {
            IndieVibes = 1,
            ElectricFeel,
            SummerOf69,
            exit
        }
        enum VHS
        {
            horror = 1,
            action,
            sci_fi,
            anime,
            exit
        }
        //Leago Maleswena 602970, Nhlamulo Ngwana 603014, Tshembo Chabalala 601928
        static void Main(string[] args)
        {
            int option = 0;
            bool exitMain = false;

            do
            {
                option = DisplayMainMenu();
                MainMenu main_menu = (MainMenu)option;

                switch (main_menu)
                {
                    case MainMenu.captureCust:
                        // Adds customers if employee says yes
                        AddCustomers();
                        break;

                    case MainMenu.Movie:
                        Console.Clear();
                        bool exitMovie = false;

                        do
                        {
                            int optionMovie = displayMovieMenu();

                            Movie movieMenu = (Movie)optionMovie;
                            switch (movieMenu)
                            {
                                case Movie.horror:
                                    Console.Clear();
                                    bool exitHorror = false;

                                    do
                                    {
                                        int optionHorror = displayHorror();
                                        Horror menuHorror = (Horror)optionHorror;
                                        switch (menuHorror)
                                        {
                                            case Horror.getOut:
                                                ProductName.Add("Get Out (2017)");
                                                ProductPrice.Add(50);
                                                break;
                                            case Horror.conjuring:
                                                ProductName.Add("The Conjuring (2013)");
                                                ProductPrice.Add(60);
                                                break;
                                            case Horror.quietPlace:
                                                ProductName.Add("A Quiet Place (2018)");
                                                ProductPrice.Add(80);
                                                break;
                                            case Horror.shining:
                                                ProductName.Add("The Shining (1980)");
                                                ProductPrice.Add(40);
                                                break;
                                            case Horror.hannahGrace:
                                                ProductName.Add("The Curse of Hannah Grace (2018)");
                                                ProductPrice.Add(70);
                                                break;
                                            case Horror.exit:
                                                exitHorror = true;
                                                break;
                                        }

                                    } while (!exitHorror);

                                    break;
                                case Movie.action:
                                    Console.Clear();
                                    bool exitAction = false;
                                    do
                                    {
                                        int optionAction = displayAction();
                                        Action menuAction = (Action)optionAction;
                                        switch (menuAction)
                                        {
                                            case Action.madMax:
                                                ProductName.Add("Fast and the furious 7 (2015)");
                                                ProductPrice.Add(85);
                                                break;
                                            case Action.johnWick:
                                                ProductName.Add("21 Bridges (2019)");
                                                ProductPrice.Add(60);
                                                break;
                                            case Action.gladiator:
                                                ProductName.Add("Sonic the Hedgehog (2020)");
                                                ProductPrice.Add(55);
                                                break;
                                            case Action.terminator:
                                                ProductName.Add("Godzilla King of the Monsters(2019)");
                                                ProductPrice.Add(75);
                                                break;
                                            case Action.missionImpos:
                                                ProductName.Add("Mission: Impossible - Fallout (2018)");
                                                ProductPrice.Add(80);
                                                break;
                                            case Action.exit:
                                                exitAction = true;
                                                break;
                                        }
                                    }
                                    while (exitAction == false);

                                    break;
                                case Movie.sci_fi:
                                    Console.Clear();
                                    bool exitSciFi = false;

                                    do
                                    {
                                        int optionSciFi = displaySciFi();
                                        sciFi menuSciFi = (sciFi)optionSciFi;
                                        switch (menuSciFi)
                                        {
                                            case sciFi.interstellar:
                                                ProductName.Add("Interstellar (2014)");
                                                ProductPrice.Add(80);
                                                break;

                                            case sciFi.starWars:
                                                ProductName.Add("Star Wars: Episode IV - A New Hope (1977)");
                                                ProductPrice.Add(55);
                                                break;

                                            case sciFi.Inception:
                                                ProductName.Add("Inception (2010)");
                                                ProductPrice.Add(75);
                                                break;

                                            case sciFi.bladeRunner:
                                                ProductName.Add("Blade Runner (1982)");
                                                ProductPrice.Add(60);
                                                break;

                                            case sciFi.theMatrix:
                                                ProductName.Add("The Matrix (1999)");
                                                ProductPrice.Add(70);
                                                break;

                                            case sciFi.exit:
                                                exitSciFi = true;
                                                break;
                                        }
                                    }

                                    while (exitSciFi == false);
                                    break;
                                case Movie.anime:
                                    Console.Clear();
                                    bool exitAnime = false;

                                    do
                                    {
                                        int optionAnime = displayAnime();
                                        anime menuAnime = (anime)optionAnime;
                                        switch (menuAnime)
                                        {
                                            case anime.spiritedAway:
                                                ProductName.Add("Spirited Away (2001)");
                                                ProductPrice.Add(70);
                                                break;
                                            case anime.wolfChildren:
                                                ProductName.Add("Wolf Children (1995)");
                                                ProductPrice.Add(55);
                                                break;
                                            case anime.silentVoice:
                                                ProductName.Add("Silent Voice (2002)");
                                                ProductPrice.Add(67);
                                                break;
                                            case anime.howlsMovingCastle:
                                                ProductName.Add("Howls Moving Castle (2004)");
                                                ProductPrice.Add(34);
                                                break;
                                            case anime.myNeighToto:
                                                ProductName.Add("My Neighbour Totoro (2010)");
                                                ProductPrice.Add(70);
                                                break;
                                            case anime.exit:
                                                exitAnime = true;
                                                break;
                                        }
                                    } while (exitAnime == false);
                                    break;
                                case Movie.exit:
                                    exitMovie = true;
                                    break;
                            }
                        } while (!exitMovie);
                        break;
                    case MainMenu.DVD:

                        Console.Clear();
                        bool exitCd = false;

                        do
                        {
                            int optionCd = DisplayCdMenu();
                            cd CdMenu = (cd)optionCd;

                            switch (CdMenu)
                            {
                                case cd.jazz:                                
                                    bool exitJazz = false;

                                    do
                                    {
                                        int optionJazz = DisplayJazzMenu();
                                        Jazz jazzMenu = (Jazz)optionJazz;

                                        switch (jazzMenu)
                                        {
                                            case Jazz.KindOfBlue:
                                                ProductName.Add("Kind of Blue (1959)");
                                                ProductPrice.Add(70);
                                                break;
                                            case Jazz.BlueTrain:
                                                ProductName.Add("Blue train (1957)");
                                                ProductPrice.Add(65);
                                                break;
                                            case Jazz.TimeOut:
                                                ProductName.Add("Time Out (1959)");
                                                ProductPrice.Add(60);
                                                break;
                                            case Jazz.exit:
                                                exitJazz = true;
                                                break;
                                        }
                                    } while (exitJazz == false);
                                    break;
                                case cd.rnb:
                                    bool exitRnB = false;
                                    do
                                    {
                                        int optionRnB = displayRnBMenu();
                                        RnB RnBMenu = (RnB)optionRnB;
                                        
                                        switch (RnBMenu)
                                        {
                                            case RnB.Thriller:
                                                ProductName.Add("Thriller (1982)");
                                                ProductPrice.Add(80);
                                                break;
                                            case RnB.PurpleRain:
                                                ProductName.Add("Purple Rain (1984)");
                                                ProductPrice.Add(75);
                                                break;
                                            case RnB.Confessions:
                                                ProductName.Add("Confessions (2004)");
                                                ProductPrice.Add(70);
                                                break;
                                            case RnB.exit:
                                                exitRnB = true;
                                                break;
                                        }
                                    }
                                    while(exitRnB == false);
                                    break;
                                case cd.hip_hop:
                                    bool exitHipHop = false;
                                    do
                                    {
                                        int optionHipHop = displayHipHopMenu();
                                        HipHop HipHopMenu = (HipHop)optionHipHop;

                                        switch (HipHopMenu)
                                        {
                                            case HipHop.Illmatic:
                                                ProductName.Add("All Eyez on Me (1996)");
                                                ProductPrice.Add(90);
                                                break;
                                            case HipHop.TheChronic:
                                                ProductName.Add("Kendric Lamar - Mr.Morale & Big Steppers (2022)");
                                                ProductPrice.Add(85);
                                                break;
                                            case HipHop.ReadyToDie:
                                                ProductName.Add("SWV -Still (2016)");
                                                ProductPrice.Add(80);
                                                break;
                                            case HipHop.exit:
                                                exitRnB = true;
                                                break;
                                        }
                                    }
                                    while (exitHipHop == false);
                                    break;
                                case cd.classical:
                                    bool exitClassical = false;
                                    do
                                    {
                                        int optionClassical = displayClassicalMenu();
                                        Classical ClassicalMenu = (Classical)optionClassical;

                                        switch (ClassicalMenu)
                                        {
                                            case Classical.FourSeasons:
                                                ProductName.Add("The Four Seasons (1725)");
                                                ProductPrice.Add(100);
                                                break;
                                            case Classical.MoonlightSonata:
                                                ProductName.Add("Moonlight Sonata (1801)");
                                                ProductPrice.Add(90);
                                                break;
                                            case Classical.SymphonyNine:
                                                ProductName.Add("Symphony No. 9 (1824)");
                                                ProductPrice.Add(85);
                                                break;
                                            case Classical.exit:
                                                exitClassical = true;
                                                break;
                                        }
                                    }
                                    while (exitClassical == false);
                                    break;
                                case cd.lofi:
                                    bool exitLofi = false;
                                    do
                                    {
                                        int optionLofi = displayLofiMenu();
                                        Lofi LofiMenu = (Lofi)optionLofi;

                                        switch (LofiMenu)
                                        {
                                            case Lofi.ChillBeats:
                                                ProductName.Add("Chill Beats (2019)");
                                                ProductPrice.Add(50);
                                                break;
                                            case Lofi.CozyVibes:
                                                ProductName.Add("Cozy Vibes (2020)");
                                                ProductPrice.Add(45);
                                                break;
                                            case Lofi.LateNightLoFi:
                                                ProductName.Add("Late Night LoFi (2018)");
                                                ProductPrice.Add(55);
                                                break;
                                            case Lofi.exit:
                                                exitLofi = true;
                                                break;
                                        }
                                    }
                                    while (exitLofi == false);
                                    break;
                                case cd.indie_rock:
                                    bool exitIndieRock = false;
                                    do
                                    {
                                        int optionIndieRock = displayIndieRock();
                                        IndieRock IndieRockMenu = (IndieRock)optionIndieRock;

                                        switch (IndieRockMenu)
                                        {
                                            case IndieRock.IndieVibes:
                                                ProductName.Add("Indie Vibes (2018)");
                                                ProductPrice.Add(60);
                                                break;
                                            case IndieRock.ElectricFeel:
                                                ProductName.Add("Electric Feel (2008)");
                                                ProductPrice.Add(65);
                                                break;
                                            case IndieRock.SummerOf69:
                                                ProductName.Add("Summer of '69 (1984)");
                                                ProductPrice.Add(70);
                                                break;
                                            case IndieRock.exit:
                                                exitIndieRock = true;
                                                break;
                                        }
                                    }
                                    while (exitIndieRock == false);
                                    break;
                                case cd.exit:
                                    exitCd = true;
                                    break;
                            }
                        }
                        while (exitCd == false);

                        break;
                    case MainMenu.VHS_Tapes:
                        Console.Clear();
                        bool exitVHS = false;
                        do
                        {
                            int optionVhs = displayVhsMenu();
                            VHS movieVhs = (VHS)optionVhs;

                            switch (movieVhs)
                            {
                                case VHS.horror:
                                    Console.Clear();
                                    bool exitHorror = false;

                                    do
                                    {
                                        int optionHorror = displayHorror();
                                        Horror menuHorror = (Horror)optionHorror;
                                        switch (menuHorror)
                                        {
                                            case Horror.getOut:
                                                ProductName.Add("Get Out (2017)");
                                                ProductPrice.Add(50);
                                                break;
                                            case Horror.conjuring:
                                                ProductName.Add("The Conjuring (2013)");
                                                ProductPrice.Add(60);
                                                break;
                                            case Horror.quietPlace:
                                                ProductName.Add("A Quiet Place (2018)");
                                                ProductPrice.Add(80);
                                                break;
                                            case Horror.shining:
                                                ProductName.Add("The Shining (1980)");
                                                ProductPrice.Add(40);
                                                break;
                                            case Horror.hannahGrace:
                                                ProductName.Add("The Curse of Hannah Grace (2018)");
                                                ProductPrice.Add(70);
                                                break;
                                            case Horror.exit:
                                                exitHorror = true;
                                                break;
                                        }

                                    } while (!exitHorror);

                                    break;
                                case VHS.action:
                                    Console.Clear();
                                    bool exitAction = false;
                                    do
                                    {
                                        int optionAction = displayAction();
                                        Action menuAction = (Action)optionAction;
                                        switch (menuAction)
                                        {
                                            case Action.madMax:
                                                ProductName.Add("Mad Max: Fury Road (2015)");
                                                ProductPrice.Add(50);
                                                break;
                                            case Action.johnWick:
                                                ProductName.Add("John Wick (2014)");
                                                ProductPrice.Add(60);
                                                break;
                                            case Action.gladiator:
                                                ProductName.Add("Gladiator (2000)");
                                                ProductPrice.Add(55);
                                                break;
                                            case Action.terminator:
                                                ProductName.Add("Terminator 2: Judgment Day (1991)");
                                                ProductPrice.Add(65);
                                                break;
                                            case Action.missionImpos:
                                                ProductName.Add("Mission: Impossible - Fallout (2018)");
                                                ProductPrice.Add(80);
                                                break;
                                            case Action.exit:
                                                exitAction = true;
                                                break;
                                        }
                                    }
                                    while (exitAction == false);

                                    break;
                                case VHS.sci_fi:
                                    Console.Clear();
                                    bool exitSciFi = false;

                                    do
                                    {
                                        int optionSciFi = displaySciFi();
                                        sciFi menuSciFi = (sciFi)optionSciFi;
                                        switch (menuSciFi)
                                        {
                                            case sciFi.interstellar:
                                                ProductName.Add("Interstellar (2014)");
                                                ProductPrice.Add(80);
                                                break;

                                            case sciFi.starWars:
                                                ProductName.Add("Star Wars: Episode IV - A New Hope (1977)");
                                                ProductPrice.Add(55);
                                                break;

                                            case sciFi.Inception:
                                                ProductName.Add("Inception (2010)");
                                                ProductPrice.Add(75);
                                                break;

                                            case sciFi.bladeRunner:
                                                ProductName.Add("Blade Runner (1982)");
                                                ProductPrice.Add(60);
                                                break;

                                            case sciFi.theMatrix:
                                                ProductName.Add("The Matrix (1999)");
                                                ProductPrice.Add(70);
                                                break;

                                            case sciFi.exit:
                                                exitSciFi = true;
                                                break;
                                        }
                                    }

                                    while (exitSciFi == false);
                                    break;
                                case VHS.anime:
                                    Console.Clear();
                                    bool exitAnime = false;

                                    do
                                    {
                                        int optionAnime = displayAnime();
                                        anime menuAnime = (anime)optionAnime;
                                        switch (menuAnime)
                                        {
                                            case anime.spiritedAway:
                                                ProductName.Add("Spirited Away (2001)");
                                                ProductPrice.Add(70);
                                                break;
                                            case anime.wolfChildren:
                                                ProductName.Add("Wolf Children (1995)");
                                                ProductPrice.Add(55);
                                                break;
                                            case anime.silentVoice:
                                                ProductName.Add("Silent Voice (2002)");
                                                ProductPrice.Add(67);
                                                break;
                                            case anime.howlsMovingCastle:
                                                ProductName.Add("Howls Moving Castle (2004)");
                                                ProductPrice.Add(34);
                                                break;
                                            case anime.myNeighToto:
                                                ProductName.Add("My Neighbour Totoro (2010)");
                                                ProductPrice.Add(70);
                                                break;
                                            case anime.exit:
                                                exitAnime = true;
                                                break;
                                        }
                                    } while (exitAnime == false);
                                    break;
                                case VHS.exit:
                                    exitVHS = true;
                                    break;
                            }
                        }
                        while (exitVHS == false);
                        break;
                    case MainMenu.checkOut:
                        CheckOut();
                        break;
                    case MainMenu.displayCust:
                        // Display all customers
                        DisplayCustomers();
                        break;
                    case MainMenu.exit:
                        exitMain = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option!...Please Try again.");
                        break;
                }
            } while (!exitMain);
        }

        public static int DisplayJazzMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("1. Kind of blue (1959) -R70");
            Console.WriteLine("2. Blue Train - R65");
            Console.WriteLine("3. Time out (1959) - R60");
            Console.WriteLine("4. Back");
            Console.WriteLine("");

            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static int displayRnBMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("1. Thriller (1982) - R80");
            Console.WriteLine("2. Purple Rain (1984) - R75");
            Console.WriteLine("3. Confessions (2004) - R70");
            Console.WriteLine("4. Back");
            Console.WriteLine("");

            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static int displayHipHopMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("1. Illmatic (1994) - R90");
            Console.WriteLine("2. The Chronic (1992) - R85");
            Console.WriteLine("3. Ready to Die (1994) - R80");
            Console.WriteLine("4. Back");
            Console.WriteLine("");

            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static int displayClassicalMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("1. The Four Seasons (1725) - R100");
            Console.WriteLine("2. Moonlight Sonata (1801) - R90");
            Console.WriteLine("3. Symphony No. 9 (1824) - R85");
            Console.WriteLine("4. Back");
            Console.WriteLine("");

            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static int displayLofiMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("1. Chill Beats (2019) - R50");
            Console.WriteLine("2. Cozy Vibes (2020) - R45");
            Console.WriteLine("3. Late Night LoFi (2018) - R55");
            Console.WriteLine("4. Back");
            Console.WriteLine("");

            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static int displayIndieRock()
        {
            Console.WriteLine("\n");
            Console.WriteLine("1. Indie Vibes (2018) - R60");
            Console.WriteLine("2. Electric Feel (2008) - R65");
            Console.WriteLine("3. Summer of '69 (1984) - R70");
            Console.WriteLine("4. Back");
            Console.WriteLine("");

            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static int DisplayCdMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Jazz");
            Console.WriteLine("2. RnB");
            Console.WriteLine("3. Hip-Hop");
            Console.WriteLine("4. Classical");
            Console.WriteLine("5. Alternative");
            Console.WriteLine("6. blues");
            Console.WriteLine("7. Back");
            Console.WriteLine("");

            int option = int.Parse(Console.ReadLine());
            return option;
        }

        public static int displayVhsMenu()
        {
            Console.Clear();
            Console.WriteLine("Please select a genre");
            Console.WriteLine("\n");
            Console.WriteLine("1. Horror");
            Console.WriteLine("2. Action");
            Console.WriteLine("3. Sci-Fi");
            Console.WriteLine("4. Anime");
            Console.WriteLine("5. Back");
            Console.WriteLine("");

            int option = int.Parse(Console.ReadLine());
            return option;
        }

        public static int displayAnime()
        {
            Console.WriteLine("\n");
            Console.WriteLine("1. Spirited Away (2001) - R70");
            Console.WriteLine("2. Wolf Children (1995) - R55");
            Console.WriteLine("3. Silent Voice (2002) - R67");
            Console.WriteLine("4. Howls Moving Castle (2004)  - R34 ");
            Console.WriteLine("5. My Neighbour Totoro (2010) - R70");
            Console.WriteLine("6. Back");
            Console.WriteLine("");
            Console.WriteLine("Please choose an option");
            Console.WriteLine("");

            int option = int.Parse(Console.ReadLine());
            return option;
        }

        public static int displaySciFi()
        {
            Console.WriteLine("\n");
            Console.WriteLine("1. Interstellar (2014) - R80");
            Console.WriteLine("2. Star Wars: Episode IV - A New Hope (1977) - R55");
            Console.WriteLine("3. Inception (2010) - R75");
            Console.WriteLine("4. Blade Runner (1982) - R60");
            Console.WriteLine("5. The Matrix (1999) - R70");
            Console.WriteLine("6. Back");
            Console.WriteLine("");
            Console.WriteLine("Please choose an option");
            Console.WriteLine("");

            int option = int.Parse(Console.ReadLine());
            return option;
        }
        //Leago Maleswena 602970, Nhlamulo Ngwana 603014, Tshembo Chabalala 601928
        public static int displayAction()
        {
            Console.WriteLine("\n");
            Console.WriteLine("1. Mad Max: Fury Road (2015) - R50");
            Console.WriteLine("2. John Wick (2014) - R60");
            Console.WriteLine("3. Gladiator (2000) - R55");
            Console.WriteLine("4. Terminator 2: Judgment Day (1991) - R65");
            Console.WriteLine("5. Mission: Impossible - Fallout (2018) - R80");
            Console.WriteLine("6. Back");
            Console.WriteLine("");
            Console.WriteLine("Please make your choice");
            Console.WriteLine("");

            int option = int.Parse(Console.ReadLine());
            return option;
        }

        public static void CheckOut()
        {
            double total = 0;
            double discount = 0;
            int itemCount = 0;
            int customerID = 0;
            int totRentals = 0;
            int newTotal = 0;
            double totalSpent = 0;

            // Count items to update user total rentals
            itemCount = ProductPrice.Count;

            // Calculation of total
            for (int x = 0; x < ProductPrice.Count; x++)
            {
                total += ProductPrice[x];
            }
            Console.WriteLine("");
            Console.WriteLine("\nYour order :\n");

            // Details of product name and receipt information
            for (int i = 0; i < ProductName.Count; i++)
            {
                Console.WriteLine("{0}\n@\t{1}", ProductName[i], ProductPrice[i]);
            }

            // Searching Customer to update details after checking out
            Console.WriteLine("Enter the customerID");
            customerID = int.Parse(Console.ReadLine());

            bool customerFound = false; // To track if the customer is found

            for (int r = 0; r < myCust.GetLength(0); r++)
            {
                // Check if the current row's customer ID matches the input customer ID
                if (myCust[r, 0] == customerID.ToString())
                {
                    int yearsRegistered = int.Parse(myCust[r, 2]);
                    totRentals = int.Parse(myCust[r, 3]);
                    newTotal = totRentals + itemCount;

                    // Calculate discount
                    discount = CalculateDiscount(yearsRegistered);
                    double discountedTotal = total - (total * discount);

                    // Update customer data
                    myCust[r, 3] = newTotal.ToString();
                    totalSpent = int.Parse(myCust[r, 4]);
                    myCust[r, 4] = (totalSpent + discountedTotal).ToString();

                    Console.WriteLine("");
                    Console.WriteLine("\nYour order :\n");

                    // Details of product name and receipt information
                    for (int i = 0; i < ProductName.Count; i++)
                    {
                        Console.WriteLine("{0}\n@\t{1}", ProductName[i], ProductPrice[i]);
                    }
                    Console.WriteLine("\nThe total : R{0}", total);
                    Console.WriteLine("\nThe Discount : {0}%", discount * 100);
                    Console.WriteLine("\nDue : R{0}", discountedTotal);
                    Console.WriteLine("");

                    break;
                }
                else if (!customerFound)
                {
                    Console.WriteLine("Customer ID not found.");
                }
                Console.WriteLine("Press\"<\" to process a new order for another customer, or any button to add more to the order :");
                char tempChar = Convert.ToChar(Console.ReadLine());
                if (tempChar.Equals('<'))
                {
                    ProductName.Clear();
                    ProductPrice.Clear();
                    Console.Clear();
                }
            }

        }
        //Leago Maleswena 602970, Nhlamulo Ngwana 603014, Tshembo Chabalala 601928
        public static int displayHorror()
        {
            
            Console.WriteLine("\n");
            Console.WriteLine("1. Get Out (2017) : R50");
            Console.WriteLine("2. The Conjuring (2013) : R60");
            Console.WriteLine("3. A Quiet Place (2018) : R80");
            Console.WriteLine("4. The Shining (1980) : R40");
            Console.WriteLine("5. The Curse of Hannah Grace (2018) : R70");
            Console.WriteLine("6. Back");
            Console.WriteLine("");
            Console.WriteLine("Please choose an option");
            Console.WriteLine("");

            int option = int.Parse(Console.ReadLine());
            return option;

        }

        public static int displayMovieMenu()
        {
            Console.Clear();
            Console.WriteLine("Please choose a genre");
            Console.WriteLine("\n");
            Console.WriteLine("1. Horror");
            Console.WriteLine("2. Action");
            Console.WriteLine("3. Sci-Fi");
            Console.WriteLine("4. Anime");
            Console.WriteLine("5. Back");
            Console.WriteLine("");

            int option = int.Parse(Console.ReadLine());
            return option;
        }

        public static void AddCustomers()
        {
            int CurrentYear = 2024;
            bool addMore = false;
            do
            {
                AddCustomer(CurrentYear);

                Console.WriteLine("Would you like to add another customer? (yes/no)");
                string response = Console.ReadLine().ToLower();
                //addMore = response == "yes"; 
                if (response == "yes")
                {
                    addMore = true;
                }
                else
                {
                    addMore = false;
                }

            } while (addMore);
        }

        public static int DisplayMainMenu()
        {
            Console.WriteLine("Rewinds Media store");
            Console.WriteLine("\n");
            Console.WriteLine(" Main Menu");
            Console.WriteLine("1. Capture Customers");
            Console.WriteLine("2. Movie");
            Console.WriteLine("3. CD");
            Console.WriteLine("4. VHS");
            Console.WriteLine("5. Checkout");
            Console.WriteLine("6. Display Customers");
            Console.WriteLine("7. Exit");
            Console.WriteLine("");

            int option = int.Parse(Console.ReadLine());
            return option;
        }
        //Leago Maleswena 602970, Nhlamulo Ngwana 603014, Tshembo Chabalala 601928
        public static void DisplayCustomers()
        {
            Console.Clear();
            Console.WriteLine(" Customer ID \t Name \t Years Registered \t Total Rentals \t Total Spent \t Lost Media Reward \t\t Coupon Reward");
            Console.WriteLine("");
            for (int row = 0; row < myCust.GetLength(0); row++)
            {
                string reward = CalculateReward(int.Parse(myCust[row, 2]), int.Parse(myCust[row, 3]));
                string couponReward = CouponReward(int.Parse(myCust[row, 3]));
                for (int col = 0; col < myCust.GetLength(1); col++)
                {
                    Console.Write(myCust[row, col] + "\t\t");
                }
                Console.Write(reward + "\t\t" + couponReward + "\t\t\t");
                Console.WriteLine();
                Console.WriteLine();
            }

        }
        public static double CalculateDiscount(int yearsRegistered)
        {
            if (yearsRegistered >= 0 && yearsRegistered <= 4)
            {
                return 0.05; // 5% discount
            }
            else if (yearsRegistered >= 5 && yearsRegistered <= 9)
            {
                return 0.10; // 10% discount
            }
            else if (yearsRegistered >= 10 && yearsRegistered <= 14)
            {
                return 0.20; // 20% discount
            }
            else if (yearsRegistered >= 15)
            {
                return 0.35; // 35% discount
            }
            else
            {
                return 0.0; // No discount
            }
        }
        public static string CouponReward(int totalRentals)
        {
            if(totalRentals >=10 && totalRentals <= 24)
            {
                return "1 Free Rental";
            }
            else if (totalRentals >= 25 && totalRentals <= 49)
            {
                return "2 Free Rental";
            }
            else if (totalRentals >= 50 && totalRentals <= 74)
            {
                return "4 Free Rental";
            }
            else if (totalRentals >= 75)
            {
                return "8 Free Rental";
            }
            else
            {
                return "No Coupon rewarded";
            }
        }
        //Leago Maleswena 602970, Nhlamulo Ngwana 603014, Tshembo Chabalala 601928
        public static string CalculateReward(int yearsRegistered, int totalRentals)
        {
            if (yearsRegistered >= 5 && yearsRegistered <= 9 && totalRentals >= 25)
            {
                return "1 Bronze-tier";
            }
            else if (yearsRegistered >= 10 && yearsRegistered <= 14 && totalRentals >= 50)
            {
                return "3 Bronze-tier + 1 Silver-tier";
            }
            else if (yearsRegistered >= 15 && totalRentals >= 75)
            {
                return "5 Bronze-tier + 2 Silver-tier + 1 Gold-tier";
            }
            else
            {
                return "No Reward";
            }
        }
        //Leago Maleswena 602970, Nhlamulo Ngwana 603014, Tshembo Chabalala 601928
        public static void AddCustomer(int CurrentYear)
        {
            // Create a new array with an additional row
            string[,] newCust = new string[myCust.GetLength(0) + 1, myCust.GetLength(1)];

            // Copy existing data to the new array
            for (int r = 0; r < myCust.GetLength(0); r++)
            {
                for (int c = 0; c < myCust.GetLength(1); c++)
                {
                    newCust[r, c] = myCust[r, c];
                }
            }

            // Add the new customer to the last row
            int newRow = newCust.GetLength(0) - 1;
            Console.WriteLine("Enter Customer ID");
            int custID = int.Parse(Console.ReadLine());
            newCust[newRow, 0] = custID.ToString();

            Console.WriteLine("Enter Customer Name");
            newCust[newRow, 1] = Console.ReadLine();

            Console.WriteLine("Enter Year registered");
            int YearCustReg = int.Parse(Console.ReadLine());
            int yearsReg = CurrentYear - YearCustReg;
            newCust[newRow, 2] = yearsReg.ToString();

            Console.WriteLine("Enter total Rentals");
            int totalRentals = int.Parse(Console.ReadLine());
            newCust[newRow, 3] = totalRentals.ToString();

            Console.WriteLine("Enter total spent");
            int totalSpent = int.Parse(Console.ReadLine());
            newCust[newRow, 4] = totalSpent.ToString();

            // Replace the old array with the new array
            myCust = newCust;
        }
    }
}
