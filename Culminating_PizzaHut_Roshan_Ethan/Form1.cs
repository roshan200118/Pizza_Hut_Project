/*Roshan Nanthapalan and Ethan Spall
 * Jan.15.2018
 * Unit X Culminating
 * A pizza maker game. You get an order with certain toppings.
 * You must put all the toppings on the pizza before the pizza reaches the end.
 * You get more points as you complete more orders.
 * The more points you have, the faster the pizza moves and the less time you have.
 * You lose if you get 5 mistakes or don't complete the pizza in time.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Culminating_PizzaHut_Roshan_Ethan
{
    public partial class Form1 : Form
    {
        //Start playing the SriLankanPeaceful2.wav file
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"SriLankanPeaceful2.wav");

        //Declaring a variable for the number of toppings in the pizzaToppings array
        const int ARRAY_SIZE = 6;

        //Creating an array for the pizza toppings 
        string[] pizzaToppings = new string[ARRAY_SIZE];

        //Creating an array for the random pizza toppings 
        string[] randomPizzaToppings = new string[ARRAY_SIZE];

        //Creating a random generator for the number of toppings 
        Random randomNumberOfToppings = new Random();

        //Declaring a variable to store the random number of toppings 
        int numberOfToppings;

        //Create a random generator for to pick the random toppings for the pizzaToppings array
        Random randomToppings = new Random();

        //Declaring a variable for the randomToppingsArray (local array)
        int randomToppingsIndex;

        //Declaring the variable for the pizza's X and Y coordinates 
        int pizzaX;
        int pizzaY;

        //Declaring a variable to make the toppings drop
        bool dropTomatoSauce, dropSriLankanSauce, dropCheese, dropPepperoni, dropChicken, dropOnions;

        //Declaring the variables for the tomato sauce's X and Y coordinates
        int tomatoSauceX, tomatoSauceY;

        //Declaring the variables for the sri-lankan sauce's X and Y coordinates
        int sriLankanSauceX, srilankanSauceY;

        //Declaring the variables for the cheese's X and Y coordinates
        int cheeseX, cheeseY;

        //Declaring the variables for the pepperoni's X and Y coordinates
        int pepperoniX, pepperoniY;

        //Declaring the variables for the chicken's X and Y coordinates
        int chickenX, chickenY;

        //Declaring the variables for the onions's X and Y coordinates
        int onionX, onionY;

        //Declaring the variables for when the toppings are on the pizza
        bool tomatoSauceOnPizza, sriLankanSauceOnPizza, cheeseOnPizza, pepperoniOnPizza, chickenOnPizza, onionsOnPizza;

        //Declaring the variables to keep track of the score
        int score = 0;

        //Declaring a variable for when the pizza moves right or left
        bool pizzaRight, pizzaLeft;

        //Declaring a variable for the number of mistakes
        int mistakes = 0;

        //Declaring a variable for the seconds the user has
        int seconds = 20;

        //Declaring a variable for when home screen's X and Y coordinates
        int homeScreenX = 0;
        int homeScreenY = 0;

        //Declaring a variable for when lose screen's X and Y coordinates
        int loseScreenX = 0;
        int loseScreenY = 0;

        public Form1()
        {
            InitializeComponent();

            //Assigning the pizzaToppings array a value (toppings)
            pizzaToppings[0] = "Tomato Sauce";
            pizzaToppings[1] = "Spicy Sri-Lankan Sauce";
            pizzaToppings[2] = "Cheese";
            pizzaToppings[3] = "Pepperoni";
            pizzaToppings[4] = "Chicken";
            pizzaToppings[5] = "Onion";

            //Starts to play the background music (SriLankanPeaceful2.wav)
            //The background music keeps on looping or replaying
            startSoundPlayer.Play();
            startSoundPlayer.PlayLooping();

            //The pizza starts off at points (1, 426)
            pizzaX = 1;
            pizzaY = 426;

            //Tomato sauce starts off at point (306, 100)
            tomatoSauceX = 306;
            tomatoSauceY = 100;

            //The sri lankan sauce starts off at point (410, 102)
            sriLankanSauceX = 410;
            srilankanSauceY = 102;

            //The cheese starts off at point (540, 87)
            cheeseX = 540;
            cheeseY = 87;

            //The pepperoni starts off at point (638, 79)
            pepperoniX = 638;
            pepperoniY = 79;

            //The chicken starts off at point (756, 86)
            chickenX = 756;
            chickenY = 86;

            //The onion starts off at point (869, 87)
            onionX = 869;
            onionY = 87;

            //Updates the pizza's and the toppings' location
            UpdateLocation();

            //None of the toppings are dropping
            dropTomatoSauce = false;
            dropSriLankanSauce = false;
            dropCheese = false;
            dropPepperoni = false;
            dropChicken = false;
            dropOnions = false;

            //None of the toppings are on the pizza
            tomatoSauceOnPizza = false;
            sriLankanSauceOnPizza = false;
            cheeseOnPizza = false;
            pepperoniOnPizza = false;
            chickenOnPizza = false;
            onionsOnPizza = false;

            //Generates a random order
            RandomOrder();

            //The pizza is not moving left or right 
            pizzaRight = false;
            pizzaLeft = false;

            //The seconds start off at 20
            seconds = 20;

            //The instructions label is invisible 
            lblInstructions.Visible = false;

            //Updates the home screen's location
            pnlHomeScreen.Location = new Point(homeScreenX, homeScreenY);

            //The lose screen is invisible
            pnlLoseScreen.Visible = false;

            //Updates the lose screen's location
            pnlLoseScreen.Location = new Point(loseScreenX, loseScreenY);
        }

        //A timer is used to refresh the code to make the pizza move 
        private void tmrPizzaSpeed_Tick(object sender, EventArgs e)
        {
            //The pizza's X-coordinate increases by 3
            pizzaX += 3;

            //The pizza can't go off the left side of the screen
            if (pizzaX < 0)
            {
                pizzaX = 0;
            }

            //Runs the speed for level 1
            IncreaseSpeedLevel1();

            //Runs the speed for level 2
            IncreaseSpeedLevel2();

            //Runs the speed for level 3
            IncreaseSpeedLevel3();

            //The MovePizza subprogram runs 
            MovePizza();

            //Runs the UpdateLocation subprogram to update the pizza's coordinates 
            UpdateLocation();

            //If the pizza is greater or equal to the form's width
            if (pizzaX >= this.ClientSize.Width)
            {
                //Run the CheckOrderComplete subprogram
                CheckOrderComplete();

                //Run the CheckScore subprogram
                CheckScore();
            }

            //Runs the subprograms for when the toppings are on the pizza
            TomatoSaucePizza();
            SriLankanSaucePizza();
            CheesePizza();
            PepperoniPizza();
            ChickenPizza();
            OnionPizza();


            //If the pizza's X-coordinate is greater than the form's width
            if (pizzaX >= this.ClientSize.Width)
            {
                //Make pizzaX equal 0 (teleports it back to the start)
                pizzaX = 0;

                //Runs the TimeForOrder subprogram
                TimeForOrder();

                //Runs the UpdateLocation subprogram to update the pizza's coordinates 
                UpdateLocation();
            }

            //Runs the subprogram to drop the tomato sauce
            TomatoSauceDrop();

            //Runs the subprogram to drop the sri lankan sauce
            SriLankanSauceDrop();

            //Runs the subprogram to drop the cheese
            CheeseDrop();

            //Runs the subprogram to drop pepperoni
            PepperoniDrop();

            //Runs the subprogram to drop chicken
            ChickenDrop();

            //Runs the subprogram to drop onion
            OnionDrop();

            //If the tomato sauce touches the pizza
            if (picTomatoSauce.Bounds.IntersectsWith(picPizza.Bounds) == true)
            {
                //The tomato sauce is on the pizza
                tomatoSauceOnPizza = true;

                //Stop dropping the tomato sauce
                dropTomatoSauce = false;
            }

            //Run the TomatoSaucePizza subprogram
            TomatoSaucePizza();

            //If the srilankan sauce touches the pizza
            if (picSriLankanSauce.Bounds.IntersectsWith(picPizza.Bounds) == true)
            {
                //The srilankan sauce is on the pizza
                sriLankanSauceOnPizza = true;

                //Stop dropping the srilankan sauce
                dropSriLankanSauce = false;
            }

            //Run the SriLankanSaucePizza subprogram
            SriLankanSaucePizza();


            //If the cheese touches the pizza
            if (picCheese.Bounds.IntersectsWith(picPizza.Bounds) == true)
            {
                //The cheese is on the pizza
                cheeseOnPizza = true;

                //Stop dropping the cheese
                dropCheese = false;
            }

            //Run the CheesePizza subprogram
            CheesePizza();

            //If the pepperoni touches the pizza
            if (picPepperoni.Bounds.IntersectsWith(picPizza.Bounds) == true)
            {
                //The pepperoni is on the pizza
                pepperoniOnPizza = true;

                //Stop dropping the pepperoni
                dropPepperoni = false;
            }

            //Run the PepperoniPizza subprogram
            PepperoniPizza();

            //If the chicken touches the pizza
            if (picChicken.Bounds.IntersectsWith(picPizza.Bounds) == true)
            {
                //The chicken is on the pizza
                chickenOnPizza = true;

                //Stop dropping the chicken
                dropChicken = false;
            }

            //Run the ChickenPizza subprogram
            ChickenPizza();

            //If the onion touches the pizza
            if (picOnion.Bounds.IntersectsWith(picPizza.Bounds) == true)
            {
                //The onion is on the pizza
                onionsOnPizza = true;

                //Stop dropping the onion
                dropOnions = false;
            }

            //Run the OnionPizza subprogram
            OnionPizza();
        }

        void Reset()
        {
            //The pizza starts off at points (1, 426)
            pizzaX = 1;
            pizzaY = 426;

            //Tomato sauce starts off at point (306, 100)
            tomatoSauceX = 306;
            tomatoSauceY = 100;

            //The sri lankan sauce starts off at point (410, 102)
            sriLankanSauceX = 410;
            srilankanSauceY = 102;

            //The cheese starts off at point (540, 87)
            cheeseX = 540;
            cheeseY = 87;

            //The pepperoni starts off at point (638, 79)
            pepperoniX = 638;
            pepperoniY = 79;

            //The chicken starts off at point (756, 86)
            chickenX = 756;
            chickenY = 86;

            //The onion starts off at point (869, 87)
            onionX = 869;
            onionY = 87;

            //Updates the pizza's and the toppings' location
            UpdateLocation();

            //None of the toppings are dropping
            dropTomatoSauce = false;
            dropSriLankanSauce = false;
            dropCheese = false;
            dropPepperoni = false;
            dropChicken = false;
            dropOnions = false;

            //None of the toppings are on the pizza
            tomatoSauceOnPizza = false;
            sriLankanSauceOnPizza = false;
            cheeseOnPizza = false;
            pepperoniOnPizza = false;
            chickenOnPizza = false;
            onionsOnPizza = false;

            //Generates a random order
            RandomOrder();

            //The pizza is not moving left or right 
            pizzaRight = false;
            pizzaLeft = false;

            //The score is reset to 0
            score = 0;

            //The mistakes is reset to 0
            mistakes = 0;

            //The timer is enabled again
            tmrPizzaSpeed.Enabled = true;

            //The seconds timer is enabled again
            tmrSeconds.Enabled = true;

            //Run the subprogram to assign the time
            TimeForOrder();

            //Updates all the labels
            UpdateLabels();

            //The instructions label is invisible 
            lblInstructions.Visible = false;
        }

        //A subprogram to assign the time depending on the score
        void TimeForOrder()
        {
            //If the score is less than or equal to 10
            if (score <= 10)
            {
                //You get 20 seconds
                seconds = 20;
            }

            //If the score is between 10 and 30 seconds
            else if (score > 10 && score <= 30)
            {
                //You get 15 seconds
                seconds = 15;
            }

            //If the score is between 30 and 50 seconds
            else if (score > 30 && score <= 50)
            {
                //You get 10 seconds
                seconds = 10;
            }

            //If the score is more than 50
            else if (score > 50)
            {
                //You get 5 seconds
                seconds = 5;
            }

            //Updates the labels
            UpdateLabels();
        }

        //A subprogram to check the score
        void CheckScore()
        {
            //If the order has been completed
            if (CheckOrderComplete() == true)
            {
                //Increase the score by 10
                score = score + 10;

                //Make another random order
                RandomOrder();
            }

            //If the order is not complete
            else if (CheckOrderComplete() == false)
            {
                //Increases the number of mistakes by 1
                mistakes++;

                //If there is 5 mistakes you lose
                if (mistakes == 5)
                {
                    Lose();
                }
            }

            //Runs the subprogram to update the labels 
            UpdateLabels();
        }

        void Lose()
        {
            //Both the timers are disabled
            tmrPizzaSpeed.Enabled = false;
            tmrSeconds.Enabled = false;

            //The lose screen is visible 
            pnlLoseScreen.Visible = true;
        }

        //A subprogram to check if the order is complete 
        bool CheckOrderComplete()
        {
            //Declaring a variable for the number of toppings complete 
            int toppingsComplete = 0;

            //Declaring a variable for the number of toppings on pizza 
            int toppingsOnPizza = 0;

            //If the tomato sauce is on the pizza, increase the number of topppings on pizza by 1 
            if (tomatoSauceOnPizza == true)
            {
                toppingsOnPizza++;
            }

            //If the srilankan sauce is on the pizza, increase the number of topppings on pizza by 1 
            if (sriLankanSauceOnPizza == true)
            {
                toppingsOnPizza++;
            }

            //If cheese is on the pizza, increase the number of topppings on pizza by 1 
            if (cheeseOnPizza == true)
            {
                toppingsOnPizza++;
            }

            //If pepperoni is on the pizza, increase the number of topppings on pizza by 1 
            if (pepperoniOnPizza == true)
            {
                toppingsOnPizza++;
            }

            //If chicken is on the pizza, increase the number of topppings on pizza by 1 
            if (chickenOnPizza == true)
            {
                toppingsOnPizza++;
            }

            //If onions are on the pizza, increase the number of topppings on pizza by 1 
            if (onionsOnPizza == true)
            {
                toppingsOnPizza++;
            }

            //Run the loop the number of times there are toppings 
            for (int i = 0; i < numberOfToppings; i++)
            {
                //If a topping in the order is tomato sauce and it's on the pizza
                if (randomPizzaToppings[i] == pizzaToppings[0] && tomatoSauceOnPizza == true)
                {
                    //Increase toppingsComplete by 1
                    toppingsComplete++;
                }

                //If a topping in the order is srilankan sauce and it's on the pizza
                else if (randomPizzaToppings[i] == pizzaToppings[1] && sriLankanSauceOnPizza == true)
                {
                    toppingsComplete++;
                }

                //If a topping in the order is cheese and it's on the pizza
                else if (randomPizzaToppings[i] == pizzaToppings[2] && cheeseOnPizza == true)
                {
                    toppingsComplete++;
                }

                //If a topping in the order is pepperoni and it's on the pizza
                else if (randomPizzaToppings[i] == pizzaToppings[3] && pepperoniOnPizza == true)
                {
                    toppingsComplete++;
                }

                //If a topping in the order is chicken and it's on the pizza
                else if (randomPizzaToppings[i] == pizzaToppings[4] && chickenOnPizza == true)
                {
                    toppingsComplete++;
                }

                //If a topping in the order is onions and it's on the pizza
                else if (randomPizzaToppings[i] == pizzaToppings[5] && onionsOnPizza == true)
                {
                    toppingsComplete++;
                }
            }

            //If the number of toppings complete equals the length of the random pizza array and 
            //The number of toppingsComplete equals the number of toppings on the pizza
            if (toppingsComplete == randomPizzaToppings.Length && toppingsComplete == toppingsOnPizza)
            {
                //Return true
                return true;
            }

            //Or else return false
            else
            {
                return false;
            }
        }


        //A subprogram that makes the tomato sauce follow the pizza
        void TomatoSaucePizza()
        {
            //If the tomato sauce is on the pizza
            if (tomatoSauceOnPizza == true)
            {
                //Make the tomato sauce follow its X and Y coordinates
                tomatoSauceX = pizzaX;
                tomatoSauceY = pizzaY;

                //Update the location
                UpdateLocation();
            }

            //If the pizza reaches the end and the tomato sauce is on the pizza
            if (pizzaX >= this.ClientSize.Width && tomatoSauceOnPizza == true)
            {
                //The tomato sauce is not on the pizza
                tomatoSauceOnPizza = false;

                //Tomato sauce goes back to its original position
                tomatoSauceX = 306;
                tomatoSauceY = 100;

                //Updates its location
                UpdateLocation();
            }
        }

        //A subprogram that makes the srilankan sauce follow the pizza
        void SriLankanSaucePizza()
        {
            //If the srilankan sauce is on the pizza
            if (sriLankanSauceOnPizza == true)
            {
                //Make the srilankan sauce follow its X and Y coordinates
                sriLankanSauceX = pizzaX;
                srilankanSauceY = pizzaY;

                //Update the location
                UpdateLocation();
            }

            //If the pizza reaches the end and the sri lankan sauce is on the pizza
            if (pizzaX >= this.ClientSize.Width && sriLankanSauceOnPizza == true)
            {
                //The srilankan sauce is not on the pizza
                sriLankanSauceOnPizza = false;

                //The srilankan sauce goes back to its original position
                sriLankanSauceX = 410;
                srilankanSauceY = 102;

                //Updates its location
                UpdateLocation();
            }
        }

        //A subprogram that makes the cheese follow the pizza
        void CheesePizza()
        {
            //If the cheese is on the pizza
            if (cheeseOnPizza == true)
            {
                //Make the cheese follow its X and Y coordinates
                cheeseX = pizzaX;
                cheeseY = pizzaY;

                //Update the location
                UpdateLocation();
            }

            //If the pizza reaches the end and the cheese is on the pizza
            if (pizzaX >= this.ClientSize.Width && cheeseOnPizza == true)
            {
                //The cheese is not on the pizza
                cheeseOnPizza = false;

                //The cheese goes back to its original position
                cheeseX = 540;
                cheeseY = 87;

                //Updates its location
                UpdateLocation();
            }
        }

        //A subprogram that makes the pepperoni follow the pizza
        void PepperoniPizza()
        {
            //If the pepperoni is on the pizza
            if (pepperoniOnPizza == true)
            {
                //Make the pepperoni follow its X and Y coordinates
                pepperoniX = pizzaX;
                pepperoniY = pizzaY;

                //Update the location
                UpdateLocation();
            }

            //If the pizza reaches the end and the pepperoni is on the pizza
            if (pizzaX >= this.ClientSize.Width && pepperoniOnPizza == true)
            {
                //The pepperoni is not on the pizza
                pepperoniOnPizza = false;

                //The pepperoni goes back to its original position
                pepperoniX = 638;
                pepperoniY = 79;

                //Updates its location
                UpdateLocation();
            }
        }

        //A subprogram that makes the chicken follow the pizza
        void ChickenPizza()
        {
            //If the chicken is on the pizza
            if (chickenOnPizza == true)
            {
                //Make the chicken follow its X and Y coordinates
                chickenX = pizzaX;
                chickenY = pizzaY;

                //Update the location
                UpdateLocation();
            }

            //If the pizza reaches the end and the chicken is on the pizza
            if (pizzaX >= this.ClientSize.Width && chickenOnPizza == true)
            {
                //The chicken is not on the pizza
                chickenOnPizza = false;

                //The chicken goes back to its original position
                chickenX = 756;
                chickenY = 86;

                //Updates its location
                UpdateLocation();
            }
        }

        //A subprogram that makes the onion follow the pizza
        void OnionPizza()
        {
            //If the onion is on the pizza
            if (onionsOnPizza == true)
            {
                //Make the onion follow its X and Y coordinates
                onionX = pizzaX;
                onionY = pizzaY;

                //Update the location
                UpdateLocation();
            }

            //If the pizza reaches the end and the onions is on the pizza
            if (pizzaX >= this.ClientSize.Width && onionsOnPizza == true)
            {
                //The onion is not on the pizza
                onionsOnPizza = false;

                //The onion goes back to its original position
                onionX = 869;
                onionY = 87;

                //Updates its location
                UpdateLocation();
            }
        }

        //A subprorgam to make the random order
        void RandomOrder()
        {
            //The order label is blank
            lblOrder.Text = "";

            //Number of toppings can equal a number between 0 and 6
            numberOfToppings = randomNumberOfToppings.Next(0, 7);

            //Creates a local array the size of the number of toppings 
            string[] randomToppingsArray = new string[numberOfToppings];

            //Runs the loop the number of times there are toppings
            for (int i = 0; i < numberOfToppings; i++)
            {
                //RandomToppingsIndex equals a number between 0 and 6
                randomToppingsIndex = randomToppings.Next(0, 6);

                //Random toppings array element equals the pizza toppings that corresponds with the randomToppingIndex
                randomToppingsArray[i] = pizzaToppings[randomToppingsIndex];

                //If the number of toppings is 1 and the other toppings are the same topping, 
                //Create another random topping
                if (numberOfToppings == 1)
                {
                    while (i == 1 && randomToppingsArray[i] == randomToppingsArray[i - 1])
                    {
                        randomToppingsIndex = randomToppings.Next(0, 6);

                        randomToppingsArray[i] = pizzaToppings[randomToppingsIndex];
                    }
                }

                //If the number of toppings is 2 and the other toppings are the same topping, 
                //Create another random topping
                else if (numberOfToppings == 2)
                {
                    while (i == 1 && randomToppingsArray[i] == randomToppingsArray[i - 1])
                    {
                        randomToppingsIndex = randomToppings.Next(0, 6);

                        randomToppingsArray[i] = pizzaToppings[randomToppingsIndex];
                    }

                    while (i == 2 && randomToppingsArray[i] == randomToppingsArray[i - 1] || i == 2 && randomToppingsArray[i] == randomToppingsArray[i - 2])
                    {
                        randomToppingsIndex = randomToppings.Next(0, 6);

                        randomToppingsArray[i] = pizzaToppings[randomToppingsIndex];
                    }
                }

                //If the number of toppings is 3 and the other toppings are the same topping, 
                //Create another random topping
                else if (numberOfToppings == 3)
                {
                    while (i == 1 && randomToppingsArray[i] == randomToppingsArray[i - 1])
                    {
                        randomToppingsIndex = randomToppings.Next(0, 6);

                        randomToppingsArray[i] = pizzaToppings[randomToppingsIndex];
                    }

                    while (i == 2 && randomToppingsArray[i] == randomToppingsArray[i - 1] || i == 2 && randomToppingsArray[i] == randomToppingsArray[i - 2])
                    {
                        randomToppingsIndex = randomToppings.Next(0, 6);

                        randomToppingsArray[i] = pizzaToppings[randomToppingsIndex];
                    }

                    while (i == 3 && randomToppingsArray[i] == randomToppingsArray[i - 1] || i == 3 && randomToppingsArray[i] == randomToppingsArray[i - 2] || i == 3 && randomToppingsArray[i] == randomToppingsArray[i - 3])
                    {
                        randomToppingsIndex = randomToppings.Next(0, 6);

                        randomToppingsArray[i] = pizzaToppings[randomToppingsIndex];
                    }
                }

                //If the number of toppings is 4 and the other toppings are the same topping, 
                //Create another random topping
                else if (numberOfToppings == 4)
                {
                    while (i == 1 && randomToppingsArray[i] == randomToppingsArray[i - 1])
                    {
                        randomToppingsIndex = randomToppings.Next(0, 6);

                        randomToppingsArray[i] = pizzaToppings[randomToppingsIndex];
                    }

                    while (i == 2 && randomToppingsArray[i] == randomToppingsArray[i - 1] || i == 2 && randomToppingsArray[i] == randomToppingsArray[i - 2])
                    {
                        randomToppingsIndex = randomToppings.Next(0, 6);

                        randomToppingsArray[i] = pizzaToppings[randomToppingsIndex];
                    }

                    while (i == 3 && randomToppingsArray[i] == randomToppingsArray[i - 1] || i == 3 && randomToppingsArray[i] == randomToppingsArray[i - 2] || i == 3 && randomToppingsArray[i] == randomToppingsArray[i - 3])
                    {
                        randomToppingsIndex = randomToppings.Next(0, 6);

                        randomToppingsArray[i] = pizzaToppings[randomToppingsIndex];
                    }

                    while (i == 4 && randomToppingsArray[i] == randomToppingsArray[i - 1] || i == 4 && randomToppingsArray[i] == randomToppingsArray[i - 2] || i == 4 && randomToppingsArray[i] == randomToppingsArray[i - 3] || i == 4 && randomToppingsArray[i] == randomToppingsArray[i - 3])
                    {
                        randomToppingsIndex = randomToppings.Next(0, 6);

                        randomToppingsArray[i] = pizzaToppings[randomToppingsIndex];
                    }
                }

                //If the number of toppings is 5 and the other toppings are the same topping, 
                //Create another random topping
                else if (numberOfToppings == 5)
                {
                    while (i == 1 && randomToppingsArray[i] == randomToppingsArray[i - 1])
                    {
                        randomToppingsIndex = randomToppings.Next(0, 6);

                        randomToppingsArray[i] = pizzaToppings[randomToppingsIndex];
                    }

                    while (i == 2 && randomToppingsArray[i] == randomToppingsArray[i - 1] || i == 2 && randomToppingsArray[i] == randomToppingsArray[i - 2])
                    {
                        randomToppingsIndex = randomToppings.Next(0, 6);

                        randomToppingsArray[i] = pizzaToppings[randomToppingsIndex];
                    }

                    while (i == 3 && randomToppingsArray[i] == randomToppingsArray[i - 1] || i == 3 && randomToppingsArray[i] == randomToppingsArray[i - 2] || i == 3 && randomToppingsArray[i] == randomToppingsArray[i - 3])
                    {
                        randomToppingsIndex = randomToppings.Next(0, 6);

                        randomToppingsArray[i] = pizzaToppings[randomToppingsIndex];
                    }

                    while (i == 4 && randomToppingsArray[i] == randomToppingsArray[i - 1] || i == 4 && randomToppingsArray[i] == randomToppingsArray[i - 2] || i == 4 && randomToppingsArray[i] == randomToppingsArray[i - 3] || i == 4 && randomToppingsArray[i] == randomToppingsArray[i - 4])
                    {
                        randomToppingsIndex = randomToppings.Next(0, 6);

                        randomToppingsArray[i] = pizzaToppings[randomToppingsIndex];
                    }

                    while (i == 5 && randomToppingsArray[i] == randomToppingsArray[i - 1] || i == 5 && randomToppingsArray[i] == randomToppingsArray[i - 2] || i == 5 && randomToppingsArray[i] == randomToppingsArray[i - 3] || i == 5 && randomToppingsArray[i] == randomToppingsArray[i - 4] || i == 5 && randomToppingsArray[i] == randomToppingsArray[i - 5])
                    {
                        randomToppingsIndex = randomToppings.Next(0, 6);

                        randomToppingsArray[i] = pizzaToppings[randomToppingsIndex];
                    }
                }

                //If the number of toppings is 6 and the other toppings are the same topping, 
                //Create another random topping
                else if (numberOfToppings == 6)
                {
                    while (i == 1 && randomToppingsArray[i] == randomToppingsArray[i - 1])
                    {
                        randomToppingsIndex = randomToppings.Next(0, 6);

                        randomToppingsArray[i] = pizzaToppings[randomToppingsIndex];
                    }

                    while (i == 2 && randomToppingsArray[i] == randomToppingsArray[i - 1] || i == 2 && randomToppingsArray[i] == randomToppingsArray[i - 2])
                    {
                        randomToppingsIndex = randomToppings.Next(0, 6);

                        randomToppingsArray[i] = pizzaToppings[randomToppingsIndex];
                    }

                    while (i == 3 && randomToppingsArray[i] == randomToppingsArray[i - 1] || i == 3 && randomToppingsArray[i] == randomToppingsArray[i - 2] || i == 3 && randomToppingsArray[i] == randomToppingsArray[i - 3])
                    {
                        randomToppingsIndex = randomToppings.Next(0, 6);

                        randomToppingsArray[i] = pizzaToppings[randomToppingsIndex];
                    }

                    while (i == 4 && randomToppingsArray[i] == randomToppingsArray[i - 1] || i == 4 && randomToppingsArray[i] == randomToppingsArray[i - 2] || i == 4 && randomToppingsArray[i] == randomToppingsArray[i - 3] || i == 4 && randomToppingsArray[i] == randomToppingsArray[i - 4])
                    {
                        randomToppingsIndex = randomToppings.Next(0, 6);

                        randomToppingsArray[i] = pizzaToppings[randomToppingsIndex];
                    }

                    while (i == 5 && randomToppingsArray[i] == randomToppingsArray[i - 1] || i == 5 && randomToppingsArray[i] == randomToppingsArray[i - 2] || i == 5 && randomToppingsArray[i] == randomToppingsArray[i - 3] || i == 5 && randomToppingsArray[i] == randomToppingsArray[i - 4] || i == 5 && randomToppingsArray[i] == randomToppingsArray[i - 5])
                    {
                        randomToppingsIndex = randomToppings.Next(0, 6);

                        randomToppingsArray[i] = pizzaToppings[randomToppingsIndex];
                    }

                    while (i == 6 && randomToppingsArray[i] == randomToppingsArray[i - 1] || i == 5 && randomToppingsArray[i] == randomToppingsArray[i - 2] || i == 5 && randomToppingsArray[i] == randomToppingsArray[i - 3] || i == 5 && randomToppingsArray[i] == randomToppingsArray[i - 4] || i == 5 && randomToppingsArray[i] == randomToppingsArray[i - 5] || i == 5 && randomToppingsArray[i] == randomToppingsArray[i - 5])
                    {
                        randomToppingsIndex = randomToppings.Next(0, 6);

                        randomToppingsArray[i] = pizzaToppings[randomToppingsIndex];
                    }
                }
            }

            //If the randomPizzaToppings array is smaller than the local random toppings array
            if (randomPizzaToppings.Length < randomToppingsArray.Length)
            {
                //Create a bigger array that is equal to the number of toppings 
                string[] bigger = new string[randomToppingsArray.Length];

                //For the number of times there are elements in the random toppings array, copy the data in the bigger array
                for (int i = 0; i < randomToppingsArray.Length; i++)
                {
                    bigger[i] = randomToppingsArray[i];
                }

                //Make the random pizza toppings array equal the bigger array
                randomPizzaToppings = bigger;

                //Make the random pizza toppings array equal the local random toppings array
                randomPizzaToppings = randomToppingsArray;
            }

            //Else if the random pizza topping array is bigger than the local random toppings array
            else if (randomPizzaToppings.Length > randomToppingsArray.Length)
            {
                //Create a smaller array that is equal to the number of toppings 
                string[] smaller = new string[randomToppingsArray.Length];

                //For the number of times there are elements in the array, copy the data in the smaller array
                for (int i = 0; i < randomToppingsArray.Length; i++)
                {
                    smaller[i] = randomToppingsArray[i];
                }

                //Make the randomPizzaToppings array equal the smaller array
                randomPizzaToppings = smaller;

                //Make the random pizza toppings array equal the local random toppings array
                randomPizzaToppings = randomToppingsArray;
            }

            //Runs the UpdateLabels subprogram
            UpdateLabels();
        }

        //A subprogram to update the pizza's location
        void UpdateLocation()
        {
            //Updates the pizza's new coordinates 
            picPizza.Location = new Point(pizzaX, pizzaY);

            //Updates the tomato sauce's location
            picTomatoSauce.Location = new Point(tomatoSauceX, tomatoSauceY);

            //Updates the srilankan sauce's location
            picSriLankanSauce.Location = new Point(sriLankanSauceX, srilankanSauceY);

            //Updates the cheese's location
            picCheese.Location = new Point(cheeseX, cheeseY);

            //Updates the pepperoni's location
            picPepperoni.Location = new Point(pepperoniX, pepperoniY);

            //Updates the chicken's location
            picChicken.Location = new Point(chickenX, chickenY);

            //Updates the onion's location
            picOnion.Location = new Point(onionX, onionY);
        }

        private void btnTomatoSauce_Click(object sender, EventArgs e)
        {
            //Drop the tomato sauce is true
            dropTomatoSauce = true;
        }

        //A subprogram that makes the tomato sauce drop
        void TomatoSauceDrop()
        {
            //If the player clicked the tomato sauce button
            if (dropTomatoSauce == true)
            {
                //Decrease the tomato sauce's Y coordinate by 15
                tomatoSauceY += 15;

                //Update the location
                UpdateLocation();
            }

            //If the tomato sauce's Y value is equal to or more than 430)
            if (tomatoSauceY >= 430)
            {
                //stop dropping the tomato sauce
                dropTomatoSauce = false;

                //Make tomato sauce start at the top again
                tomatoSauceY = 100;

                //Updates the location
                UpdateLocation();
            }
        }

        //A subprogram that makes the srilankan sauce drop
        void SriLankanSauceDrop()
        {
            //If the player clicked the sri-lankan sauce button
            if (dropSriLankanSauce == true)
            {
                //Decrease the sri-lankan sauce's Y coordinate by 15
                srilankanSauceY += 15;

                //Update the location
                UpdateLocation();
            }

            //If the sri lankan sauce's Y value is equal to or more than 430)
            if (srilankanSauceY >= 430)
            {
                //stop dropping the sri lankan sauce
                dropSriLankanSauce = false;

                //Make sri lankan sauce start at the top again
                srilankanSauceY = 102;

                //Updates the programs location
                UpdateLocation();
            }
        }

        private void btnSriLankanSauce_Click(object sender, EventArgs e)
        {
            //Drop the sri lankan sauce is true
            dropSriLankanSauce = true;
        }

        private void btnCheese_Click(object sender, EventArgs e)
        {
            //Drop the cheese is true 
            dropCheese = true;
        }

        //A subprogram that makes the cheese drop
        void CheeseDrop()
        {
            //If the player clicked the cheese button
            if (dropCheese == true)
            {
                //Decrease the cheese's Y coordinate by 15
                cheeseY += 15;

                //Update the location
                UpdateLocation();
            }

            //If the cheese's Y value is equal to or more than 430)
            if (cheeseY >= 430)
            {
                //Stop dropping the cheese
                dropCheese = false;

                //Make cheese start at the top again
                cheeseY = 87;

                //Updates the programs location
                UpdateLocation();
            }
        }

        private void btnPepperoni_Click(object sender, EventArgs e)
        {
            //Dropping the pepperoni is true
            dropPepperoni = true;
        }

        //A subprogram that makes the pepperoni drop
        void PepperoniDrop()
        {
            //If the player clicked the pepperoni button
            if (dropPepperoni == true)
            {
                //Decrease the pepperoni's Y coordinate by 15
                pepperoniY += 15;

                //Update the location
                UpdateLocation();
            }

            //If the pepperoni's Y value is equal to or more than 430)
            if (pepperoniY >= 430)
            {
                //Stop dropping the pepperoni
                dropPepperoni = false;

                //Make pepperoni start at the top again
                pepperoniY = 79;

                //Updates the programs location
                UpdateLocation();
            }
        }

        private void btnChicken_Click(object sender, EventArgs e)
        {
            //Dropping the chicken is true
            dropChicken = true;
        }

        //A subprogram that makes the chicken drop
        void ChickenDrop()
        {
            //If the player clicked the chicken button
            if (dropChicken == true)
            {
                //Decrease the chicken's Y coordinate by 15
                chickenY += 15;

                //Update the location
                UpdateLocation();
            }

            //If the chicken's Y value is equal to or more than 430)
            if (chickenY >= 430)
            {
                //stop dropping the chicken
                dropChicken = false;

                //Make chicken start at the top again
                chickenY = 86;

                //Updates the programs location
                UpdateLocation();
            }
        }

        private void btnOnion_Click(object sender, EventArgs e)
        {
            //Dropping the onions is true
            dropOnions = true;
        }

        //A subprogram that makes the onion drop
        void OnionDrop()
        {
            //If the player clicked the pepperoni button
            if (dropOnions == true)
            {
                //Decrease the onion's Y coordinate by 15
                onionY += 15;

                //Update the location
                UpdateLocation();
            }

            //If the onion's Y value is equal to or more than 430)
            if (onionY >= 430)
            {
                //stop dropping the onion
                dropOnions = false;

                //Make onion start at the top again
                onionY = 87;

                //Updates the programs location
                UpdateLocation();
            }
        }

        //Ignore code
        /*private void btnOrder_Click(object sender, EventArgs e)
        {
            //Run the RandomOrder subprogram
            RandomOrder();
        }*/

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //If the A key is pressed
            if (e.KeyCode == Keys.A)
            {
                //Make the player move left
                pizzaLeft = true;
            }

            //If the D key is pressed
            else if (e.KeyCode == Keys.D)
            {
                //Make the player move right
                pizzaRight = true;
            }

            //If the 1 key is pressed
            else if (e.KeyCode == Keys.D1)
            {
                //Make the tomato sauce drop
                dropTomatoSauce = true;
            }

            //If the 2 key is pressed
            else if (e.KeyCode == Keys.D2)
            {
                //Make the sri lankan sauce drop
                dropSriLankanSauce = true;
            }

            //If the 3 key is pressed
            else if (e.KeyCode == Keys.D3)
            {
                //Make the cheese drop
                dropCheese = true;
            }

            //If the 4 key is pressed
            else if (e.KeyCode == Keys.D4)
            {
                //Make the pepperoni drop
                dropPepperoni = true;
            }

            //If the 5 key is pressed
            else if (e.KeyCode == Keys.D5)
            {
                //Make the chicken drop
                dropChicken = true;
            }

            //If the 6 key is pressed
            else if (e.KeyCode == Keys.D6)
            {
                //Make the onions drop
                dropOnions = true;
            }
        }

        //A subprogram to make the pizza 
        void MovePizza()
        {
            //If pizzaRight is true
            if (pizzaRight == true)
            {
                //Make the pizzaX value increase by 5
                pizzaX += 5;
                UpdateLocation();
            }

            //If pizzaLeft is true
            if (pizzaLeft == true)
            {
                //Make the pizzaX value decrease by 14
                pizzaX -= 14;
                UpdateLocation();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //If the A key is not pressed
            if (e.KeyCode == Keys.A)
            {
                //Don't move the pizza left
                pizzaLeft = false;
            }

            //If the D key is not pressed 
            else if (e.KeyCode == Keys.D)
            {
                //Don't move the pizza right 
                pizzaRight = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Run the reset subprogram
            Reset();
        }

        private void tmrSeconds_Tick(object sender, EventArgs e)
        {
            //Decrease the number of seconds by 1 
            seconds--;

            //Update the labels
            UpdateLabels();

            //If seconds equals 0
            if (seconds == 0)
            {
                //Run the lose subprogram
                Lose();
            }
        }

        //Increase speed function to increase speed once a certain score is reached
        bool IncreaseSpeedLevel1()
        {
            //If score is between 10 and 29
            if (score >= 10 && score < 30)
            {
                //Increase the speed the pizza moves by 3
                pizzaX += 3;

                return true;
            }
            else
            {
                return false;
            }
        }

        //Increase speed function to increase speed once a certain score is reached
        bool IncreaseSpeedLevel2()
        {
            //if score is between 30 and 49
            if (score >= 30 && score < 50)
            {
                //Increase the speed of the pizza by 6
                pizzaX += 6;

                return true;
            }
            else
            {
                return false;
            }
        }

        //Increase speed function to increase speed once a certain score is reached
        bool IncreaseSpeedLevel3()
        {
            //If score is greater than 50
            if (score >= 50)
            {
                //Increase the speed of the pizza 10
                pizzaX += 10;

                return true;
            }
            else
            {
                return false;
            }
        }


        //Subprogram to update all the labels within the program
        void UpdateLabels()
        {
            //Sets the order label to nothing 
            lblOrder.Text = " ";

            //sets the score label to display the players current score and current number of mistakes
            lblScore.Text = "Score: " + score.ToString() + "    Mistakes: " + mistakes.ToString(); ;

            //Sets the seconds label to display the current time taken to assemble the pizza
            lblSeconds.Text = "Time left: " + seconds.ToString();

            //For the number of times there are toppings
            for (int i = 0; i < numberOfToppings; i++)
            {
                //Make lblOrder display the order
                lblOrder.Text += randomPizzaToppings[i] + "\r\n";
            }
        }

        private void picStartGame_Click(object sender, EventArgs e)
        {
            //Hides the homescreen panel
            pnlHomeScreen.Visible = false;

            //The insturctions label is invisible 
            lblInstructions.Visible = false;

            //Runs the reset subprogram
            Reset();
        }

        private void picTutorial_Click(object sender, EventArgs e)
        {
            //When you click on the instruction picturebox the label is visible, 
            //if you click again it its invisible 
            if (lblInstructions.Visible == true)
            {
                lblInstructions.Visible = false;
            }

            else
            {
                lblInstructions.Visible = true;
            }

            //Tells the user how to play 
            lblInstructions.Text = "This is a pizza making game!\r\nYou start off with 20 seconds to make the requested order.\r\nIf you don't complete the order in time you lose!\r\nIf you make 5 mistakes on the pizza you lose!\r\nUse the buttons on the top to select the toppings and you can also move the pizza \r\nD - move pizza right\r\nA - move pizza left\r\n1 - Tomato Sauce\r\n2 - Spicy Sri-Lankan Sauce\r\n3 - Cheese\r\n4 - Pepperoni\r\n5 - Chicken\r\n6 - Onions\r\nBe careful! The timer gets shorter as you get more points and the pizza moves faster";
        }

        private void picExitGame_Click(object sender, EventArgs e)
        {
            //Exits the application
            Application.Exit();
        }

        private void picPlayAgain_Click(object sender, EventArgs e)
        {
            //The home screen is visible again
            pnlHomeScreen.Visible = true;

            //The instructions label is invisible 
            lblInstructions.Visible = false;

            //The lose screen is invisible 
            pnlLoseScreen.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //The home screen is visible again
            pnlHomeScreen.Visible = true;

            //The instructions label is invisible 
            lblInstructions.Visible = false;

            //The lose screen is invisible 
            pnlLoseScreen.Visible = false;
        }
    }
}
