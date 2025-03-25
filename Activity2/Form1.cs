namespace Activity2
{
    public partial class Form1 : Form
    {
        private int playerScore = 0;
        private int ComScore = 0;
        private string playerChoice;
        private string computerChoice;
    
        public Form1()
        {
            InitializeComponent();
        }
           
        private void bato_Click(object sender, EventArgs e)
        {

        }
    
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void UpdateScore()
        {
            pscore.Text = "Player Score: " + playerScore;
            sscore.Text = "Computer Score: " + ComScore;
        }

        private void batoo_Click(object sender, EventArgs e)
        {
            playerChoice = "rock";
            AnimatePlayers();
        }

        private void papell_Click(object sender, EventArgs e)
        {
            playerChoice = "paper";
            AnimatePlayers();
        }

        private void guntingg_Click(object sender, EventArgs e)
        {
            playerChoice = "scissors";
            AnimatePlayers();
        }
        private void PlayRound()
        {
            Random random = new Random();
            int choice = random.Next(1, 4);

            if (choice == 1)
                computerChoice = "rock";
            else if (choice == 2)
                computerChoice = "paper";
            else
                computerChoice = "scissors";

            if (playerChoice == "rock")
                player.Image = Properties.Resources.rock;
            else if (playerChoice == "paper")
                player.Image = Properties.Resources.paper;
            else
                player.Image = Properties.Resources.gunting;

            if (computerChoice == "rock")
                computer.Image = Properties.Resources.rock;
            else if (computerChoice == "paper")
                computer.Image = Properties.Resources.paper;
            else
                computer.Image = Properties.Resources.gunting;

            if (playerChoice == computerChoice)
                result.Text = "It's a Tie!";
            else if ((playerChoice == "rock" && computerChoice == "scissors") ||
                     (playerChoice == "paper" && computerChoice == "rock") ||
                     (playerChoice == "scissors" && computerChoice == "paper"))
            {
                result.Text = "You Win!";
                playerScore++;
            }
            else
            {
                result.Text = "You Lose!";
                ComScore++;
            }

            UpdateScore();
        }
        private void AnimatePlayers()
        {
            int startY = ClientSize.Height / 3;
            player.Top = computer.Top = startY;

            for (int i = 0; i < 10; i++)
            {
                player.Top -= 5;
                computer.Top -= 5;
                Refresh();
            }
            for (int i = 0; i < 10; i++)
            {
                player.Top += 5;
                computer.Top += 5;
                Refresh();
            }

            PlayRound();
        }
    }
}
