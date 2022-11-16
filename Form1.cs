namespace egg_catcher_game
{
    public partial class gameBoard : Form
    {
        // score
        int score = 0;

        // eggs left
        int eggsLeft = 5;

        // getting random values
        Random rand = new Random();

        // is the egg hit a basket?
        bool isHit = false;

        // directions of three egg baskets
        bool basket1LeftToRight = true;
        bool basket2LeftToRight = true;
        bool basket3LeftToRight = true;

        // random speeds of the egg baskets
        int basket1_speed;
        int basket2_speed;
        int basket3_speed;


        // is the egg in the basket?
        bool eggInBasket1 = false;
        bool eggInBasket2 = false;
        bool eggInBasket3 = false;

        public gameBoard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // randomize the x coordinate of the egg baskets.
            eggBasket1.Location = new Point(rand.Next(0, this.Width), eggBasket1.Location.Y);
            eggBasket2.Location = new Point(rand.Next(0, this.Width), eggBasket2.Location.Y);
            eggBasket3.Location = new Point(rand.Next(0, this.Width), eggBasket3.Location.Y);

            // randomizing the speeds of baskets
            basket1_speed = rand.Next(1, 4);
            basket2_speed = rand.Next(1, 4);
            basket3_speed = rand.Next(1, 4);

            // setting up labels
            lblEggsLeft.Text = eggsLeft.ToString();
            lblScore.Text = score.ToString();
        }

        private void gameBoard_KeyDown(object sender, KeyEventArgs e)
        {
            isHit = false;
            egg.Visible = true;

            eggInBasket1 = false;
            eggInBasket2 = false;
            eggInBasket3 = false;

            eggBasket1.Image = Properties.Resources.egg_basket;
            eggBasket2.Image = Properties.Resources.egg_basket;
            eggBasket3.Image = Properties.Resources.egg_basket;

            // moving the egg
            if (e.KeyCode == Keys.Up)
            {
                egg.Top -= 130;

                // either egg is in a basket,
                if (egg.Bounds.IntersectsWith(eggBasket1.Bounds))
                {
                    eggInBasket1 = true;
                    isHit = true;
                    eggBasket1.Image = Properties.Resources.egg_basket2;
                    egg.Visible = false;

                    // score update
                    score++;
                    lblScore.Text = score.ToString();

                    // other resets
                    eggBasket2.Image = Properties.Resources.egg_basket;
                    eggBasket3.Image = Properties.Resources.egg_basket;
                }
                else if (egg.Bounds.IntersectsWith(eggBasket2.Bounds))
                {
                    eggInBasket2 = true;
                    isHit = true;
                    eggBasket2.Image = Properties.Resources.egg_basket2;
                    egg.Visible = false;

                    // score update
                    score++;
                    lblScore.Text = score.ToString();

                    // other resets
                    eggBasket1.Image = Properties.Resources.egg_basket;
                    eggBasket3.Image = Properties.Resources.egg_basket;

                }
                else if (egg.Bounds.IntersectsWith(eggBasket3.Bounds))
                {
                    eggInBasket3 = true;
                    isHit = true;
                    eggBasket3.Image = Properties.Resources.egg_basket2;
                    egg.Visible = false;

                    // score update
                    score++;
                    lblScore.Text = score.ToString();

                    // other resets
                    eggBasket1.Image = Properties.Resources.egg_basket;
                    eggBasket2.Image = Properties.Resources.egg_basket;
                }

                // or it will be cracked.
                else
                {
                    egg.Image = Properties.Resources.cracked_egg;

                    // egg fall animation start
                    timer_eggFall.Start();

                    // eggs count update
                    eggsLeft--;
                    lblEggsLeft.Text = eggsLeft.ToString();

                    // game reset
                    eggBasket1.Image = Properties.Resources.egg_basket;
                    eggBasket2.Image = Properties.Resources.egg_basket;
                    eggBasket3.Image = Properties.Resources.egg_basket;

                    eggBasket1.Visible = true;
                    eggBasket2.Visible = true;
                    eggBasket3.Visible = true;

                }

                // screen change
                if (egg.Location.Y <= 55 && isHit)
                {
                    // the basket with the egg sould be visble
                    // other baskets should dissappear
                    eggBasket1.Visible = eggInBasket1 ? true : false;
                    eggBasket2.Visible = eggInBasket2 ? true : false;
                    eggBasket3.Visible = eggInBasket3 ? true : false;
                    
                    // location of the visible egg basket should slowly bring down
                    timer_eggBasketMove.Start();


                }

                if(score == 20)
                {
                    // all timers stop
                    timer_basket1.Dispose();
                    timer_basket2.Dispose();
                    timer_basket3.Dispose();

                    // win picturebox visible
                    cover.Image = Properties.Resources.win;
                    cover.Visible = true;
                }

                if(eggsLeft == 0)
                {
                    // all timers stop
                    timer_basket1.Dispose();
                    timer_basket2.Dispose();
                    timer_basket3.Dispose();

                    // lose picturebox visible
                    cover.Visible = true;
                    cover.Image = Properties.Resources.lose;
                }
            }
        }

        private void timer_basket1_Tick(object sender, EventArgs e)
        {
            if (eggBasket1.Location.X >= this.Width - eggBasket1.Width)
            {
                basket1LeftToRight = false;
            }

            if (eggBasket1.Location.X <= 0)
            {
                basket1LeftToRight = true;
            }

            eggBasket1.Left += basket1LeftToRight ? basket1_speed : -basket1_speed;

            // if the egg in the basket, it's location is equal to the basket
            if (eggInBasket1)
            {
                egg.Location = eggBasket1.Location;
            }
        }

        private void timer_basket2_Tick(object sender, EventArgs e)
        {
            if (eggBasket2.Location.X >= this.Width - eggBasket2.Width)
            {
                basket2LeftToRight = false;
            }

            if (eggBasket2.Location.X <= 0)
            {
                basket2LeftToRight = true;
            }

            eggBasket2.Left += basket2LeftToRight ? basket2_speed : -basket2_speed;

            // if the egg in the basket, it's location is equal to the basket
            if (eggInBasket2)
            {
                egg.Location = eggBasket2.Location;
            }
        }

        private void timer_basket3_Tick(object sender, EventArgs e)
        {
            if (eggBasket3.Location.X >= this.Width - eggBasket3.Width)
            {
                basket3LeftToRight = false;
            }

            if (eggBasket3.Location.X <= 0)
            {
                basket3LeftToRight = true;
            }

            eggBasket3.Left += basket3LeftToRight ? basket3_speed : -basket3_speed;

            // if the egg in the basket, it's location is equal to the basket
            if (eggInBasket3)
            {
                egg.Location = eggBasket3.Location;
            }
        }

        private void timer_eggFall_Tick(object sender, EventArgs e)
        {
            egg.Top += 7;

            if(egg.Bounds.Y > this.Height)
            {
                egg.Image = Properties.Resources.egg_cropped;
                egg.Location = new Point(157, 445);

                timer_eggFall.Dispose();
            }
        }

        private void timer_eggBasketMove_Tick(object sender, EventArgs e)
        {
            if (eggInBasket1)
            {
                // each tick should bring down the eggbasket
                eggBasket1.Top += 5;

                if (eggBasket1.Location.Y >= 315)
                {
                    eggBasket2.Location = new Point(rand.Next(0, this.Width), 55);
                    eggBasket3.Location = new Point(rand.Next(0, this.Width), 185);

                    basket2_speed = rand.Next(1, 4);
                    basket3_speed = rand.Next(1, 4);

                    eggBasket2.Visible = true;
                    eggBasket3.Visible = true;

                    timer_eggBasketMove.Dispose();
                }

            }
            else if (eggInBasket2)
            {
                eggBasket2.Top += 5;

                if (eggBasket2.Location.Y >= 315)
                {
                    eggBasket1.Location = new Point(rand.Next(0, this.Width), 185);
                    eggBasket3.Location = new Point(rand.Next(0, this.Width), 55);

                    basket1_speed = rand.Next(1, 4);
                    basket3_speed = rand.Next(1, 4);

                    eggBasket1.Visible = true;
                    eggBasket3.Visible = true;

                    timer_eggBasketMove.Dispose();
                }

            }
            else if (eggInBasket3)
            {
                eggBasket3.Top += 5;

                if (eggBasket3.Location.Y >= 315)
                {
                    eggBasket1.Location = new Point(rand.Next(0, this.Width), 55);
                    eggBasket2.Location = new Point(rand.Next(0, this.Width), 185);

                    basket1_speed = rand.Next(1, 4);
                    basket2_speed = rand.Next(1, 4);

                    eggBasket1.Visible = true;
                    eggBasket2.Visible = true;

                    timer_eggBasketMove.Dispose();
                }
            }

        }
    }
}