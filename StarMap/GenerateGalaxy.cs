using System;

public class GenerateGalaxy{

    public static string[] names = new string[]{
        #region names
        "Acamar",
        "Achird",
        "Acrux",
        "Acubens",
        "Adhafera",
        "Adhil",
        "Ain",
        "Athfar",
        "Bali",
        "Dhanab",
        "Gieba",
        "Giedi",
        "Haud",
        "Nair",
        "Niyat",
        "Reschia",
        "Thalimain",
        "Aladfar",
        "Albireo",
        "Alchibah",
        "Alcor",
        "Alcyone",
        "Aldebaran",
        "Alderamin",
        "Alfirk",
        "Algenib",
        "Algol",
        "Algorab",
        "Alioth",
        "Alkaid",
        "Alkalurops",
        "Alkes",
        "Almach",
        "Almeisan",
        "Alnilam",
        "Alnitak",
        "Alphard",
        "Alpheratz",
        "Alsafi",
        "Alshain",
        "Altair",
        "Alterf",
        "Aludra",
        "Alula",
        "Alya",
        "Ancha",
        "Andromeda",
        "Angetenar",
        "Ankaa",
        "Antares",
        "Antlia",
        "Apus",
        "Aquarius",
        "Aquila",
        "Ara",
        "Arcturus",
        "Aries",
        "Arkab",
        "Arneb",
        "Arrakis",
        "Ascella",
        "Asellus",
        "Asmidiske",
        "Asterope",
        "Atik",
        "Atlas",
        "Atria",
        "Auriga",
        "Auva",
        "Avior",
        "Azelfafage",
        "Azha",
        "Baham",
        "BatenKaitos",
        "Beid",
        "Bellatrix",
        "Betelgeuse",
        "Bootes",
        "Botein",
        "Caelum",
        "Camelopardalis",
        "Cancer",
        "CanesVenatici",
        "Canis",
        "Canopus",
        "Capella",
        "Caph",
        "Capricornus",
        "Carina",
        "Cassiopeia",
        "Castor",
        "Celaeno",
        "Centaurus",
        "Cepheus",
        "Cetus",
        "Chamaeleon",
        "Chara",
        "Cheleb",
        "Choo",
        "Circinus",
        "Columba",
        "Coma",
        "Coroli",
        "Corona",
        "Corvus",
        "Coxa",
        "Crater",
        "Crux",
        "Cujam",
        "Cursa",
        "Cygnus",
        "Dabih",
        "Delphinus",
        "Deneb",
        "Deneb",
        "Denebola",
        "Diphda",
        "Dorado",
        "Draco",
        "Dschubba",
        "Dubhe",
        "Dziban",
        "Edasich",
        "Electra",
        "Eltanin",
        "Enif",
        "Equuleus",
        "Erai",
        "Eridanus",
        "Fomalhaut",
        "Fornax",
        "Furud",
        "Gacrux",
        "Gemini",
        "Gemma",
        "Giauzar",
        "Gienah",
        "Gomeisa",
        "Graffias",
        "Grumium",
        "Grus",
        "Hadar",
        "Hamal",
        "Heka",
        "Hercules",
        "Heze",
        "Homam",
        "Horologium",
        "Hydra",
        "Hydrus",
        "Indus",
        "Jabbah",
        "Kaus",
        "Kekuan",
        "Keid",
        "Kerhah",
        "Kital",
        "Kochab",
        "Kornephoros",
        "Kraz",
        "Kuma",
        "Lacerta",
        "Leo",
        "Lepus",
        "Lesath",
        "Libra",
        "Lupus",
        "Lynx",
        "Lyra",
        "Maaz",
        "Maia",
        "Marfik",
        "Markab",
        "Massim",
        "Matar",
        "Mebsuta",
        "Megrez",
        "Mekbuda",
        "Men",
        "Menkalinan",
        "Menkar",
        "Menkent",
        "Menkib",
        "Mensa",
        "Merak",
        "Merope",
        "Mesarthim",
        "Miaplacidus",
        "Microscopium",
        "Mimosa",
        "Minhar",
        "Minkar",
        "Mintaka",
        "Mira",
        "Mirach",
        "Mirak",
        "Mirfak",
        "Mirzam",
        "Mizar",
        "Monoceros",
        "Mothallah",
        "Muhlifain",
        "Muliphein",
        "Mulu-lizi",
        "Muphrid",
        "Musca",
        "Muscida",
        "Nair",
        "Naos",
        "Nashira",
        "Nekkar",
        "Nihal",
        "Nodus",
        "Norma",
        "Nunki",
        "Nusakan",
        "Octans",
        "Ophiuchus",
        "Orion",
        "Pavo",
        "Pegasus",
        "Perseus",
        "Phact",
        "Phad",
        "Pherkab",
        "Phoenix",
        "Pictor",
        "Pisces",
        "Pleadies",
        "Pleione",
        "Polaris",
        "Pollux",
        "Porrima",
        "Praecipula",
        "Prijipati",
        "Primus",
        "Procyon",
        "Propus",
        "Puppis",
        "Pyxis",
        "Rana",
        "Rasalas",
        "Rastaban",
        "Regulus",
        "Reticulum",
        "Rigel",
        "Rotanev",
        "Ruchba",
        "Ruchbah",
        "Rukbat",
        "Sabik",
        "Sadachbia",
        "SadalMelik",
        "SadalSuud",
        "Sadalbari",
        "Sadatoni",
        "Sadr",
        "Sagitta",
        "Sagittarius",
        "Sargas",
        "Sarin",
        "Scheat",
        "Schedar",
        "Schemali",
        "Scorpius",
        "Sculptor",
        "Scutulum",
        "Scutum",
        "Segin",
        "Serpens",
        "Sextans",
        "Shaula",
        "Shelyak",
        "Sheratan",
        "Signus",
        "Sirius",
        "Situla",
        "Skat",
        "Spica",
        "Sualocin",
        "Suhail",
        "Sulafat",
        "Syrma",
        "Talitha",
        "Tania",
        "Tarazed",
        "Tarf",
        "Taurus",
        "Taygeta",
        "Tegmine",
        "Tejat",
        "Telescopium",
        "Thabit",
        "Thuban",
        "Tian",
        "Triangulum",
        "Tsih",
        "Tucana",
        "Tyl",
        "Ukdah",
        "Unuk",
        "Ursa",
        "Vega",
        "Vela",
        "Vindemiatrix",
        "Virgo",
        "Volans",
        "Vulpecula",
        "Wasat",
        "Wezen",
        "Wezn",
        "Yed",
        "Yildun",
        "Zaniah",
        "Zaurak",
        "Zavijava",
        "Zhou",
        "Zi",
        "Zozma",
        "Zuben"};
        #endregion
    public static string[] abc = new string[]{
        #region abc
        "Alpha", 
        "Beta", 
        "Gamma", 
        "Delta", 
        "Epsilon", 
        "Zeta", 
        "Eta", 
        "Theta", 
        "Iota", 
        "Kappa", 
        "Lambda", 
        "Mu", 
        "Nu", 
        "Xi", 
        "Omicron", 
        "Pi", 
        "Rho", 
        "Sigma", 
        "Tau", 
        "Upsilon", 
        "Phi", 
        "Chi", 
        "Psi", 
        "Omega"};
        #endregion

    public static void execute(){

        Console.WriteLine("Please input the number of stars you wish to randomly generate.");
        int numStars = 0;
        while(numStars == 0){
            try{numStars = int.Parse(Console.ReadLine());}
            catch(FormatException e){
                Console.WriteLine(e.Message + " Please try again.");
            }
            if(numStars < 0){
                Console.WriteLine("Invalid input. The number must be a positive number. Please try again."); 
                numStars = 0;
            }
        }

        Console.WriteLine("Please input the maximum distance of the stars from Earth.");
        float maxDist = 0;
        while(maxDist == 0){
            try{maxDist = float.Parse(Console.ReadLine());}
            catch(FormatException e){
                Console.WriteLine(e.Message + " Please try again.");
            }
            if(maxDist < 0){
                Console.WriteLine("Invalid input. The distance must be a positive number. Please try again."); 
                maxDist = 0;
            }
        }

        Console.WriteLine("Generating galaxy...");

        for(int i=0;i<numStars;i++){
            var rand = new Random();

            // generate a random name
            string name = names[rand.Next(names.Length)] + " " + abc[rand.Next(abc.Length)];

            // generate a random coordinate, including negative values
            double x = rand.NextDouble() * maxDist;
            double y = rand.NextDouble() * maxDist;
            double z = rand.NextDouble() * maxDist;
            int randInt = rand.Next(100);
            if(randInt>50){x=x*-1;}
            randInt = rand.Next(100);
            if(randInt>50){y=y*-1;}
            randInt = rand.Next(100);
            if(randInt>50){z=z*-1;}

            // generate a random size
            double size = 0;
            randInt = rand.Next(10);
            if(randInt<2){
                size = rand.NextDouble(); // a few stars will be tiny
            }
            else if(randInt<6){
                size = rand.NextDouble() * 25; // most stars will average to about 12 times the size of the sun
            }
            else if(randInt<8){
                size = rand.NextDouble() * 150; // many stars will be much bigger than the sun
            }
            else{
                size = rand.NextDouble() * 1000; // a few stars will be gigantic
            }

            // pick a random color
            string color = "blue"; 
            randInt = rand.Next(100);
            if(randInt < 4){color = "white";} // about 4% of stars are white
            else if(randInt < 14){color = "blue";} // about 10% of stars are blue
            else if(randInt < 42){color = "yellow";} // about 28% of stars are yellow
            else if(randInt < 53){color = "orange";} // about 11% of stars are orange
            else{color = "red";} // about 47% of stars are red
            if(size<0.5){color = "red";} // very small stars are always red
            InputStar.execute(name, x, y, z, size, color);
        }

        Console.WriteLine("");
        Console.WriteLine("Finished! " + numStars + " randomly generated stars have been added to the database.");
        Console.WriteLine("");
        Console.WriteLine("Please press the Enter key to return to the main menu.");
        Console.ReadLine();
        
    }

}