using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Film1PageScript : MonoBehaviour
{
    public int randomFilm; // number to generate to match with a corresponding film.
    
    public Image filmPicture; // the film's cover image that will be replaced with a sprite for the corresponding film.
    public Image castMember1; // the top cast member that will be replaced with a sprite for the corresponding film.
    public Image castMember2; // the middle cast member that will be replaced with a sprite for the corresponding film.
    public Image castMember3; // the bottom cast member that will be replaced with a sprite for the corresponding film.
    public Image Map; //the map image that will be replaced with a sprite for the corresponding film.
    
    public Image skyLogo; // the sky logo at the top of the page.
    public Image infoImage; // the small circle at the bottom with info.
    public Image trailerImage; // the circle on the left that shows the youtube logo.
    
    //sprites for the (filmPicture) varoiable.
    public Sprite guardianOfTheGalaxyCover; 
    public Sprite shesOutOfMyLeagueCover; 
    public Sprite soloStarWarsCover; 
    public Sprite redSparrowCover; 
    public Sprite theShiningCover; 
    public Sprite despicableMeCover;  
    public Sprite gameNightCover; //        <------- sprites to change the filmPicture image when the film is selected.
    public Sprite stepBrothersCover; 
    public Sprite nannyMcpheeCover; 
    public Sprite blackPantherCover; 
    public Sprite breakingInCover; 
    public Sprite loveSimonCover; 
    public Sprite iceManCover; 
    
    //sprites for the (Map) variable.
    public Sprite guardianOfTheGalaxyMap;
    public Sprite shesOutOfMyLeagueMap;
    public Sprite soloStarWarsMap;
    public Sprite redSparrowMap;
    public Sprite theShiningMap;
    public Sprite despicableMeMap;
    public Sprite gameNightMap; //        <------- sprites to change the Map image when the film is selected.
    public Sprite stepBrothersMap;
    public Sprite nannyMcpheeMap;
    public Sprite blackPantherMap;
    public Sprite breakingInMap;
    public Sprite loveSimonMap;
    public Sprite iceManMap;
    
    //strings for the (URL) variable.
    private string URL; // the URL variable that when (t) is pressed will open.
    
    private string guardianOfTheGalaxyURL = "https://www.youtube.com/watch?v=d96cjJhvlMA";
    private string shesOutOfMyLeagueURL = "https://www.youtube.com/watch?v=9mj4_hUEnpU";
    private string soloStarWarsURL = "https://www.youtube.com/watch?v=jPEYpryMp2s";
    private string redSparrowURL = "https://www.youtube.com/watch?v=PmUL6wMpMWw";
    private string theShiningURL = "https://www.youtube.com/watch?v=5Cb3ik6zP2I";
    private string despicableMeURL = "https://www.youtube.com/watch?v=sUkZFetWYY0";
    private string gameNightURL = "https://www.youtube.com/watch?v=qmxMAdV6s4U"; //  <------- strings to change the URL variable when the film is selected the correct link will be followed.
    private string stepBrothersURL = "https://www.youtube.com/watch?v=CewglxElBK0";
    private string nannyMcpheeURL = "https://www.youtube.com/watch?v=YFcsn70hlHQ";
    private string blackPantherURL = "https://www.youtube.com/watch?v=xjDjIWPwcPU";
    private string breakingInURL = "https://www.youtube.com/watch?v=l2IRWwyOjrU";
    private string loveSimonURL = "https://www.youtube.com/watch?v=E0cbWdlQg_8";
    private string iceManURL = "https://www.youtube.com/watch?v=PkCNs3jIs7U";
    
    private string infoString; // the information string variable that when (space) is pressed to randomise, this string will be passed into the infoText Text variable.
    public GameObject infoObject; // the information object that will be set to active to show the info box.
    public Text infoText; // the text shown in the info text box.
    public Image Character; // the character image that updates to the relevant sprite when randomised.
    
    // the strings to pass into the infoString variable.
    private string guardianOfTheGalaxyInfo = "A group of intergalactic criminals must pull together to stop a fanatical warrior with plans to purge the universe.";
    private string shesOutOfMyLeagueInfo = "An average Joe meets the ideal woman, but his lack of confidence and the influence of his friends and family begin to pick away at the relationship.";
    private string soloStarWarsInfo = "During an adventure into the criminal underworld, Han Solo meets his future co-pilot Chewbacca and encounters Lando Calrissian years before joining the Rebellion.";
    private string redSparrowInfo = "Ballerina Dominika Egorova is recruited to 'Sparrow School,' a Russian intelligence service where she is forced to use her body as a weapon. Her first mission, targeting a C.I.A. agent, threatens to unravel the security of both nations.";
    private string theShiningInfo = "A family heads to an isolated hotel for the winter where an evil spiritual presence influences the father into violence, while his psychic son sees horrific forebodings from both past and future.";
    private string despicableMeInfo = "When a criminal mastermind uses a trio of orphan girls as pawns for a grand scheme, he finds their love is profoundly changing him for the better.";
    private string gameNightInfo = "A group of friends who meet regularly for game nights find themselves entangled in a real-life mystery when the shady brother of one of them is seemingly kidnapped by dangerous gangsters.";
    private string stepBrothersInfo = "Two aimless middle-aged losers still living at home are forced against their will to become roommates when their parents marry.";
    private string nannyMcpheeInfo = "A governess uses magic to rein in the behavior of seven ne'er-do-well children in her charge.";
    private string blackPantherInfo = "T'Challa, heir to the hidden but advanced kingdom of Wakanda, must step forward to lead his people into a new future and must confront a challenger from his country's past.";
    private string breakingInInfo = "A woman fights to protect her family during a home invasion.";
    private string loveSimonInfo = "Simon Spier keeps a huge secret from his family, his friends and all of his classmates: he's gay. When that secret is threatened, Simon must face everyone and come to terms with his identity.";
    private string iceManInfo = "The Ötztal Alps, more than 5300 years ago. A Neolithic clan has settled near a creek. It is their leader Kelab's responsibility to be the keeper of the group's holy shrine Tineka.";
    
    //the sprites to pass into the Character Image variable.
    public Sprite guardianOfTheGalaxyCharacter;
    public Sprite shesOutOfMyLeagueCharacter;
    public Sprite soloStarWarsCharacter;
    public Sprite redSparrowCharacter;
    public Sprite theShiningCharacter;
    public Sprite despicableMeCharacter;
    public Sprite gameNightCharacter;
    public Sprite stepBrothersCharacter;
    public Sprite nannyMcpheeCharacter;
    public Sprite blackPantherCharacter;
    public Sprite breakingInCharacter;
    public Sprite loveSimonCharacter;
    public Sprite iceManCharacter;
    
    /*-------------------------------------------------------------
         Cast Member Sprites and Strings to swap in when randomised 
    -------------------------------------------------------------*/
    //top cast member
    public Sprite guardianOfTheGalaxyCast1;
    private string guardianOfTheGalaxyCast1Description = "Chris Pratt";
    //middle cast member
    public Sprite guardianOfTheGalaxyCast2;
    private string guardianOfTheGalaxyCast2Description = "Zoe Saldana";
    //bottom cast member
    public Sprite guardianOfTheGalaxyCast3;
    private string guardianOfTheGalaxyCast3Description = "Dave Bautista";
    
    //top cast member
    public Sprite shesOutOfMyLeagueCast1;
    private string shesOutOfMyLeagueCast1Description = "Alice Eve";
    //middle cast member
    public Sprite shesOutOfMyLeagueCast2;
    private string shesOutOfMyLeagueCast2Description = "Jay Baruchel";
    //bottom cast member
    public Sprite shesOutOfMyLeagueCast3;
    private string shesOutOfMyLeagueCast3Description = "T.J Miller";
    
    //top cast member
    public Sprite soloStarWarsCast1;
    private string soloStarWarsCast1Description = "Alden Ehrenreich";
    //middle cast member
    public Sprite soloStarWarsCast2;
    private string soloStarWarsCast2Description = "Emilia Clarke";
    //bottom cast member
    public Sprite soloStarWarsCast3;
    private string soloStarWarsCast3Description = "Donald Glover";
    
    //top cast member
    public Sprite redSparrowCast1;
    private string redSparrowCast1Description = "Jennifer Lawrence";
    //middle cast member
    public Sprite redSparrowCast2;
    private string redSparrowCast2Description = "Joel Edgerton";
    //bottom cast member
    public Sprite redSparrowCast3;
    private string redSparrowCast3Description = "Matthias Schoenaerts";

    //top cast member
    public Sprite theShiningCast1;
    private string theShiningCast1Description = "Jack Nicholson";
    //middle cast member
    public Sprite theShiningCast2;
    private string theShiningCast2Description = "Shelley Duvall";
    //bottom cast member
    public Sprite theShiningCast3;
    private string theShiningCast3Description = "Danny Lloyd";
    
    //top cast member
    public Sprite despicableMeCast1;
    private string despicableMeCast1Description = "Steve Carell";
    //middle cast member
    public Sprite despicableMeCast2;
    private string despicableMeCast2Description = "Kristen Wiig";
    //bottom cast member
    public Sprite despicableMeCast3;
    private string despicableMeCast3Description = "Miranda Cosgrove";
    
    //top cast member
    public Sprite gameNightCast1;
    private string gameNightCast1Description = "Jason Bateman";
    //middle cast member
    public Sprite gameNightCast2;
    private string gameNightCast2Description = "Rachel Mcadams";
    //bottom cast member
    public Sprite gameNightCast3;
    private string gameNightCast3Description = "Jesse Plemons";
    
    //top cast member
    public Sprite stepBrothersCast1;
    private string stepBrothersCast1Description = "Will Ferrell";
    //middle cast member
    public Sprite stepBrothersCast2;
    private string stepBrothersCast2Description = "John Reilly";
    //bottom cast member
    public Sprite stepBrothersCast3;
    private string stepBrothersCast3Description = "Mary Steenburgen";
    
    //top cast member
    public Sprite nannyMcpheeCast1;
    private string nannyMcpheeCast1Description = "Emma Thompson";
    //middle cast member
    public Sprite nannyMcpheeCast2;
    private string nannyMcpheeCast2Description = "Thomas Brodie-Sangster";
    //bottom cast member
    public Sprite nannyMcpheeCast3;
    private string nannyMcpheeCast3Description = "Colin Firth";
    
    //top cast member
    public Sprite blackPantherCast1;
    private string blackPantherCast1Description = "Chadwick Boseman";
    //middle cast member
    public Sprite blackPantherCast2;
    private string blackPantherCast2Description = "Michael B Jordan";
    //bottom cast member
    public Sprite blackPantherCast3;
    private string blackPantherCast3Description = "Lupita Nyong";
    
    //top cast member
    public Sprite breakingInCast1;
    private string breakingInCast1Description = "Gabrielle Union";
    //middle cast member
    public Sprite breakingInCast2;
    private string breakingInCast2Description = "Ajiona Alexus";
    //bottom cast member
    public Sprite breakingInCast3;
    private string breakingInCast3Description = "Richard Cabral";
    
    //top cast member
    public Sprite loveSimonCast1;
    private string loveSimonCast1Description = "Nick Robinson";
    //middle cast member
    public Sprite loveSimonCast2;
    private string loveSimonCast2Description = "Keiynan Lonsdale";
    //bottom cast member
    public Sprite loveSimonCast3;
    private string loveSimonCast3Description = "Katherine Langford";
    
    //top cast member
    public Sprite iceManCast1;
    private string iceManCast1Description = "Michael Shannon";
    //middle cast member
    public Sprite iceManCast2;
    private string iceManCast2Description = "Chris Evans";
    //bottom cast member
    public Sprite iceManCast3;
    private string iceManCast3Description = "James Franco";

    
    // the text boxes containing cast member names to be set to active when (1), (2) or (3) is pressed.
    public GameObject castMember1Description;
    public GameObject castMember2Description;
    public GameObject castMember3Description;
    
    // the text containing cast member names to be changed when randomised.
    public Text castMember1DescriptionText;
    public Text castMember2DescriptionText;
    public Text castMember3DescriptionText;
    
    // the name of the film to be changed when randomised.
    public Text randomFilmDescription;
    
    //the stars to be set to active depending on the films rating
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject star4;
    public GameObject star5;
    
    // the IEnumerators to create a flashing animation for the Sky Logo (s), the info circle (i) and the trailer circle (t).
    private IEnumerator skyLogoCoroutine;
    private IEnumerator infoImageCoroutine;
    private IEnumerator trailerImageCoroutine;
    
    
    public Text welcomeText; // the welcome text to get the color component out of.
    public Color welcomeTextColour; // the colour to fade in and out using Color.Lerp.
    
    public Animation randomFilmAnimation; //the growing animation of the ticket when randomised.
    
    void Start() 
    {
        infoObject.SetActive(false); // set to false on start so that it doesn't block the main screen on Start.
        
        randomFilmSelector(); // call the random film function to start with a random film.
        
    }
    
    void Update()
    {    
        welcomeText.GetComponent<Text>().color = welcomeTextColour; // change the welcomeText.Color to the welcomeTextColour variable that changes colour.
        welcomeTextColour = Color.Lerp(Color.white, Color.black, Mathf.PingPong(Time.time, 1)); // changes the colour from white to black in 1 second.
        
        infoText.text = infoString; // placed here so that it updates while in the info screen as well.
        
        /*-------------------------------------------------------------
            Key 'i'
        -------------------------------------------------------------*/
        
        if (Input.GetKeyDown("i") && infoObject.activeInHierarchy == false) // if the infoObject is not showing and (i) is pressed.
        {   
            Invoke("openInfo", 2); //opens info after 2 seconds.
            infoImageCoroutine = infoFlash(); 
            StartCoroutine(infoImageCoroutine); // shows the flashing animation.
        }
        
        /*-------------------------------------------------------------
            Key 'e'
        -------------------------------------------------------------*/
        
        if (Input.GetKeyDown("e") && infoObject.activeInHierarchy == true) { infoObject.SetActive(false); } // exit the info pop up if it is open.
        
        /*-------------------------------------------------------------
            Key 's'
        -------------------------------------------------------------*/
    
        if (Input.GetKeyDown("s")) {
            skyLogoCoroutine = skyLogoFlash();
            StartCoroutine(skyLogoCoroutine); // shows the flashing animation.
        }
        
        /*-------------------------------------------------------------
            Key 'b'
        -------------------------------------------------------------*/
    
        if (Input.GetKeyDown("b")) { SceneManager.LoadScene("mainScene"); } //goes back to previous screen.
    
        /*-------------------------------------------------------------
            Key 't'
        -------------------------------------------------------------*/
    
        if (Input.GetKeyDown("t")) 
        {   
            Invoke("openTrailer", 2); //opens trailer after 2 seconds.
            trailerImageCoroutine = trailerFlash();
            StartCoroutine(trailerImageCoroutine); // shows the flashing animation.
        }
        
        /*-------------------------------------------------------------
            Key 'space'
        -------------------------------------------------------------*/
        
        if (Input.GetKeyDown("space")) { randomFilmSelector(); } //selects random film.
        
        /*-------------------------------------------------------------
            Key 'm'
        -------------------------------------------------------------*/
        
        if (Input.GetKey("m")) {
            Map = Map.GetComponent<Image>();
            Map.color = new Color(1f,1f,1f, 1f); // changes the color to white while m is held down.
        } else { Map.color = new Color(0.2f,0.2f,0.2f, 1f); } // while m is not held down it is grey.
        
        /*-------------------------------------------------------------
            Key '1'
        -------------------------------------------------------------*/
        
        if (Input.GetKey("1")) {
            castMember1Description.SetActive(true); // show the text box.
            castMember1 = castMember1.GetComponent<Image>(); // get the image component.
            castMember1.color = new Color(1f,1f,1f, 1f); // change the image component's properties to white.
        } else { 
            castMember1.color = new Color(0.2f,0.2f,0.2f, 1f); // if 1 is not pressed show it as grey.
            castMember1Description.SetActive(false); // if 1 is not pressed set the text box to inactive.
        }
        
        /*-------------------------------------------------------------
            Key '2'
        -------------------------------------------------------------*/
        
        if (Input.GetKey("2")) {
            castMember2Description.SetActive(true); // show the text box.
            castMember2 = castMember2.GetComponent<Image>(); // get the image component.
            castMember2.color = new Color(1f,1f,1f, 1f); // change the image component's properties to white.
        } else { 
            castMember2.color = new Color(0.2f,0.2f,0.2f, 1f); // if 1 is not pressed show it as grey.
            castMember2Description.SetActive(false); // if 2 is not pressed set the text box to inactive.
        }
        
        /*-------------------------------------------------------------
            Key '3'
        -------------------------------------------------------------*/
        
        if (Input.GetKey("3")) {
            castMember3Description.SetActive(true); // show the text box.
            castMember3 = castMember3.GetComponent<Image>(); // get the image component.
            castMember3.color = new Color(1f,1f,1f, 1f); // change the image component's properties to white.
        } else { 
            castMember3.color = new Color(0.2f,0.2f,0.2f, 1f); // if 1 is not pressed show it as grey.
            castMember3Description.SetActive(false); // if 2 is not pressed set the text box to inactive.
        }
    }
    
    //Sky Logo flashing Animation
    private IEnumerator skyLogoFlash()
    {
        skyLogo.color = new Color(1f,1f,1f, 1f);
        yield return new WaitForSeconds(0.1f);
        skyLogo.color = new Color(0.2f,0.2f,0.2f, 1f);
        yield return new WaitForSeconds(0.1f);
        skyLogo.color = new Color(1f,1f,1f, 1f);
        yield return new WaitForSeconds(0.1f);
        skyLogo.color = new Color(0.2f,0.2f,0.2f, 1f);
        yield return new WaitForSeconds(0.1f);
        skyLogo.color = new Color(1f,1f,1f, 1f); // alternate colours every 0.1 seconds
        yield return new WaitForSeconds(0.1f);
        skyLogo.color = new Color(0.2f,0.2f,0.2f, 1f);
        yield return new WaitForSeconds(0.1f);
        skyLogo.color = new Color(1f,1f,1f, 1f);
        yield return new WaitForSeconds(0.1f);
        skyLogo.color = new Color(0.2f,0.2f,0.2f, 1f);
        yield return new WaitForSeconds(0.1f);
        skyLogo.color = new Color(1f,1f,1f, 1f);
    }
    
    //Info Box flashing Animation
    private IEnumerator infoFlash()
    {
        infoImage.color = new Color(1f,1f,1f, 1f);
        yield return new WaitForSeconds(0.2f);
        infoImage.color = new Color(0.2f,0.2f,0.2f, 1f);
        yield return new WaitForSeconds(0.2f);
        infoImage.color = new Color(1f,1f,1f, 1f);
        yield return new WaitForSeconds(0.2f);
        infoImage.color = new Color(0.2f,0.2f,0.2f, 1f);
        yield return new WaitForSeconds(0.2f);
        infoImage.color = new Color(1f,1f,1f, 1f);
        yield return new WaitForSeconds(0.2f);
        infoImage.color = new Color(0.2f,0.2f,0.2f, 1f); // alternate colours every 0.2 seconds
        yield return new WaitForSeconds(0.2f);
        infoImage.color = new Color(1f,1f,1f, 1f);
        yield return new WaitForSeconds(0.2f);
        infoImage.color = new Color(0.2f,0.2f,0.2f, 1f);
        yield return new WaitForSeconds(0.2f);
        infoImage.color = new Color(1f,1f,1f, 1f);
        yield return new WaitForSeconds(0.2f);
        infoImage.color = new Color(0.2f,0.2f,0.2f, 1f);
        yield return new WaitForSeconds(0.2f);
        infoImage.color = new Color(1f,1f,1f, 1f);
    }
    
    //Trailer Flashing Animation
    private IEnumerator trailerFlash()
    {
        trailerImage.color = new Color(1f,1f,1f, 1f);
        yield return new WaitForSeconds(0.2f);
        trailerImage.color = new Color(0.2f,0.2f,0.2f, 1f);
        yield return new WaitForSeconds(0.2f);
        trailerImage.color = new Color(1f,1f,1f, 1f);
        yield return new WaitForSeconds(0.2f);
        trailerImage.color = new Color(0.2f,0.2f,0.2f, 1f);
        yield return new WaitForSeconds(0.2f);
        trailerImage.color = new Color(1f,1f,1f, 1f);
        yield return new WaitForSeconds(0.2f);
        trailerImage.color = new Color(0.2f,0.2f,0.2f, 1f); // alternate colours every 0.2 seconds
        yield return new WaitForSeconds(0.2f);
        trailerImage.color = new Color(1f,1f,1f, 1f);
        yield return new WaitForSeconds(0.2f);
        trailerImage.color = new Color(0.2f,0.2f,0.2f, 1f);
        yield return new WaitForSeconds(0.2f);
        trailerImage.color = new Color(1f,1f,1f, 1f);
        yield return new WaitForSeconds(0.2f);
        trailerImage.color = new Color(0.2f,0.2f,0.2f, 1f);
        yield return new WaitForSeconds(0.2f);
        trailerImage.color = new Color(1f,1f,1f, 1f);
    }
    
    private void openTrailer() { Application.OpenURL(URL); } // opens the URL string variable that contains the correct url for the film.
    
    private void openInfo() { infoObject.SetActive(true); } // opens the information object.
    
    private void randomFilmSelector() 
    {
        
            randomFilm = Random.Range(1,14); // generates a random number from 1 to 13.
            
            filmPicture = filmPicture.GetComponent<Image>(); // get the image component so that it can be changed.
            castMember1 = castMember1.GetComponent<Image>(); // get the image component so that it can be changed.
            castMember2 = castMember2.GetComponent<Image>(); // get the image component so that it can be changed.
            castMember3 = castMember3.GetComponent<Image>(); // get the image component so that it can be changed.
            Map = Map.GetComponent<Image>(); // get the image component so that it can be changed.
                        
            /*----------------------------------------------------------------------------------------------------
                depending on the random number generated load the corresponding images, text, stars and URL
            ----------------------------------------------------------------------------------------------------*/
                        
            if (randomFilm == 1) { //guardians of the galaxy.
            
                filmPicture.sprite = guardianOfTheGalaxyCover; // change the film picture variable to the guardians of the galaxy cover.
                castMember1DescriptionText.text = guardianOfTheGalaxyCast1Description; // change the cas member name to the correct string.
                castMember1.sprite = guardianOfTheGalaxyCast1; // change the 1st cast member sprite variable to the 1st guardians of the galaxy cast member.
                castMember2DescriptionText.text = guardianOfTheGalaxyCast2Description; // change the cas member name to the correct string.
                castMember2.sprite = guardianOfTheGalaxyCast2; // change the 2nd cast member sprite variable to the 2nd guardians of the galaxy cast member.
                castMember3DescriptionText.text = guardianOfTheGalaxyCast3Description; // change the cas member name to the correct string.
                castMember3.sprite = guardianOfTheGalaxyCast3; // change the 3rd cast member sprite variable to the 3rd guardians of the galaxy cast member.
                Map.sprite = guardianOfTheGalaxyMap;
                
                randomFilmDescription.text = "Guardians of the galaxy"; // change the film name.
                
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true); // - show the correct amount of stars.
                star4.SetActive(true);
                star5.SetActive(true);
                
                URL = guardianOfTheGalaxyURL; // change the URL so that when (t) is pressed it will open the correct video on youtube.
                
                infoString = guardianOfTheGalaxyInfo; // change the info shown by pressing (i).
                
                Character.sprite = guardianOfTheGalaxyCharacter; // change the character shown by pressing (i).
            }
            
            if (randomFilm == 2) { //she's out of my league.
            
                filmPicture.sprite = shesOutOfMyLeagueCover;
                castMember1DescriptionText.text = shesOutOfMyLeagueCast1Description;
                castMember1.sprite = shesOutOfMyLeagueCast1; 
                castMember2DescriptionText.text = shesOutOfMyLeagueCast2Description;
                castMember2.sprite = shesOutOfMyLeagueCast2; 
                castMember3DescriptionText.text = shesOutOfMyLeagueCast3Description;
                castMember3.sprite = shesOutOfMyLeagueCast3; 
                Map.sprite = shesOutOfMyLeagueMap;
                
                randomFilmDescription.text = "She's out of my league";
                
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
                star4.SetActive(true);
                star5.SetActive(true);
                
                URL = shesOutOfMyLeagueURL;
                
                infoString = shesOutOfMyLeagueInfo;
                
                Character.sprite = shesOutOfMyLeagueCharacter;
            }
            
            if (randomFilm == 3) {//Solo Star Wars Story.
                filmPicture.sprite = soloStarWarsCover;
                castMember1DescriptionText.text = soloStarWarsCast1Description;
                castMember1.sprite = soloStarWarsCast1; 
                castMember2DescriptionText.text = soloStarWarsCast2Description;
                castMember2.sprite = soloStarWarsCast2; 
                castMember3DescriptionText.text = soloStarWarsCast3Description;
                castMember3.sprite = soloStarWarsCast3; 
                Map.sprite = soloStarWarsMap;
                
                randomFilmDescription.text = "Solo a Star Wars story";
                
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
                star4.SetActive(true);
                star5.SetActive(false);
                
                URL = soloStarWarsURL;
                
                infoString = soloStarWarsInfo;
                
                Character.sprite = soloStarWarsCharacter;
            }
            
            if (randomFilm == 4) {//Red Sparrow
                filmPicture.sprite = redSparrowCover;
                castMember1DescriptionText.text = redSparrowCast1Description;
                castMember1.sprite = redSparrowCast1; 
                castMember2DescriptionText.text = redSparrowCast2Description;
                castMember2.sprite = redSparrowCast2; 
                castMember3DescriptionText.text = redSparrowCast3Description;
                castMember3.sprite = redSparrowCast3; 
                Map.sprite = redSparrowMap;
                
                randomFilmDescription.text = "Red sparrow";
                
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
                star4.SetActive(true);
                star5.SetActive(false);
                
                URL = redSparrowURL;
                
                infoString = redSparrowInfo;
                
                Character.sprite = redSparrowCharacter;
            }
            
            if (randomFilm == 5) {//the shining
                filmPicture.sprite = theShiningCover;
                castMember1DescriptionText.text = theShiningCast1Description;
                castMember1.sprite = theShiningCast1; 
                castMember2DescriptionText.text = theShiningCast2Description;
                castMember2.sprite = theShiningCast2; 
                castMember3DescriptionText.text = theShiningCast3Description;
                castMember3.sprite = theShiningCast3; 
                Map.sprite = theShiningMap;
                
                randomFilmDescription.text = "the shining";
                
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
                star4.SetActive(true);
                star5.SetActive(true);
                
                URL = theShiningURL;
                
                infoString = theShiningInfo;
                
                Character.sprite = theShiningCharacter;
            }
            
            if (randomFilm == 6) {//despicable me
                filmPicture.sprite = despicableMeCover;
                castMember1DescriptionText.text = despicableMeCast1Description;
                castMember1.sprite = despicableMeCast1; 
                castMember2DescriptionText.text = despicableMeCast2Description;
                castMember2.sprite = despicableMeCast2; 
                castMember3DescriptionText.text = despicableMeCast3Description;
                castMember3.sprite = despicableMeCast3; 
                Map.sprite = despicableMeMap;
                
                randomFilmDescription.text = "despicable me";
                
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
                star4.SetActive(true);
                star5.SetActive(false);
                
                URL = despicableMeURL;
                
                infoString = despicableMeInfo;
                
                Character.sprite = despicableMeCharacter;
            }
            
            if (randomFilm == 7) {//game night
                filmPicture.sprite = gameNightCover;
                castMember1DescriptionText.text = gameNightCast1Description;
                castMember1.sprite = gameNightCast1; 
                castMember2DescriptionText.text = gameNightCast2Description;
                castMember2.sprite = gameNightCast2; 
                castMember3DescriptionText.text = gameNightCast3Description;
                castMember3.sprite = gameNightCast3; 
                Map.sprite = gameNightMap;
                
                randomFilmDescription.text = "game night";
                
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
                star4.SetActive(false);
                star5.SetActive(false);
                
                URL = gameNightURL;
                
                infoString = gameNightInfo;
                
                Character.sprite = gameNightCharacter;
            }
            
            if (randomFilm == 8) {//Step Brothers
                filmPicture.sprite = stepBrothersCover;
                castMember1DescriptionText.text = stepBrothersCast1Description;
                castMember1.sprite = stepBrothersCast1; 
                castMember2DescriptionText.text = stepBrothersCast2Description;
                castMember2.sprite = stepBrothersCast2; 
                castMember3DescriptionText.text = stepBrothersCast3Description;
                castMember3.sprite = stepBrothersCast3; 
                Map.sprite = stepBrothersMap;
                
                randomFilmDescription.text = "step brothers";
                
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
                star4.SetActive(true);
                star5.SetActive(true);
                
                URL = stepBrothersURL;
                
                infoString = stepBrothersInfo;
                
                Character.sprite = stepBrothersCharacter;
            }
            
            if (randomFilm == 9) {//Nanny Mcphee
                filmPicture.sprite = nannyMcpheeCover;
                castMember1DescriptionText.text = nannyMcpheeCast1Description;
                castMember1.sprite = nannyMcpheeCast1; 
                castMember2DescriptionText.text = nannyMcpheeCast2Description;
                castMember2.sprite = nannyMcpheeCast2; 
                castMember3DescriptionText.text = nannyMcpheeCast3Description;
                castMember3.sprite = nannyMcpheeCast3; 
                Map.sprite = nannyMcpheeMap;
                
                randomFilmDescription.text = "nanny mcphee";
                
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
                star4.SetActive(false);
                star5.SetActive(false);
                
                URL = nannyMcpheeURL;
                
                infoString = nannyMcpheeInfo;
                
                Character.sprite = nannyMcpheeCharacter;
            }
            
            if (randomFilm == 10) {//Black Panther
                filmPicture.sprite = blackPantherCover;
                castMember1DescriptionText.text = blackPantherCast1Description;
                castMember1.sprite = blackPantherCast1; 
                castMember2DescriptionText.text = blackPantherCast2Description;
                castMember2.sprite = blackPantherCast2; 
                castMember3DescriptionText.text = blackPantherCast3Description;
                castMember3.sprite = blackPantherCast3; 
                Map.sprite = blackPantherMap;
                
                randomFilmDescription.text = "black panther";
                
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
                star4.SetActive(true);
                star5.SetActive(true);
                
                URL = blackPantherURL;
                
                infoString = blackPantherInfo;
                
                Character.sprite = blackPantherCharacter;
            }
            
            if (randomFilm == 11) {//Breaking In
                filmPicture.sprite = breakingInCover;
                castMember1DescriptionText.text = breakingInCast1Description;
                castMember1.sprite = breakingInCast1; 
                castMember2DescriptionText.text = breakingInCast2Description;
                castMember2.sprite = breakingInCast2; 
                castMember3DescriptionText.text = breakingInCast3Description;
                castMember3.sprite = breakingInCast3; 
                Map.sprite = breakingInMap;
                
                randomFilmDescription.text = "breaking in";
                
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(false);
                star4.SetActive(false);
                star5.SetActive(false);
                
                URL = breakingInURL;
                
                infoString = breakingInInfo;
                
                Character.sprite = breakingInCharacter;
            }
            
            if (randomFilm == 12) {//Love Simon
                filmPicture.sprite = loveSimonCover;
                castMember1DescriptionText.text = loveSimonCast1Description;
                castMember1.sprite = loveSimonCast1; 
                castMember2DescriptionText.text = loveSimonCast2Description;
                castMember2.sprite = loveSimonCast2; 
                castMember3DescriptionText.text = loveSimonCast3Description;
                castMember3.sprite = loveSimonCast3; 
                Map.sprite = loveSimonMap;
                
                randomFilmDescription.text = "love simon";
                
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
                star4.SetActive(true);
                star5.SetActive(false);
                
                URL = loveSimonURL;
                
                infoString = loveSimonInfo;
                
                Character.sprite = loveSimonCharacter;
            }
            
            if (randomFilm == 13) {//Iceman
                filmPicture.sprite = iceManCover;
                castMember1DescriptionText.text = iceManCast1Description;
                castMember1.sprite = iceManCast1; 
                castMember2DescriptionText.text = iceManCast2Description;
                castMember2.sprite = iceManCast2; 
                castMember3DescriptionText.text = iceManCast3Description;
                castMember3.sprite = iceManCast3; 
                Map.sprite = iceManMap;
                
                randomFilmDescription.text = "iceman";
                
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
                star4.SetActive(false);
                star5.SetActive(false);
                
                URL = iceManURL;
                
                infoString = iceManInfo;
                
                Character.sprite = iceManCharacter;
            }
            
            randomFilmAnimation.Play(); // play the animation once the correct picture, description and stars has been set.
    }
}
