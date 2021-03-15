using System.IO;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace PaperRockScissors
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        #region ConstansData
        BitmapImage paperIcon = new BitmapImage(new Uri("Images/paper.png", UriKind.RelativeOrAbsolute));
        BitmapImage rockIcon = new BitmapImage(new Uri("Images/rock.png", UriKind.RelativeOrAbsolute));
        BitmapImage scissorsIcon = new BitmapImage(new Uri("Images/scissors.png", UriKind.RelativeOrAbsolute));
        BitmapImage invertPaperIcon = new BitmapImage(new Uri("Images/rpaper.png", UriKind.RelativeOrAbsolute));
        BitmapImage invertRockIcon = new BitmapImage(new Uri("Images/rrock.png", UriKind.RelativeOrAbsolute));
        BitmapImage invertScissorsIcon = new BitmapImage(new Uri("Images/rscissors.png", UriKind.RelativeOrAbsolute));
        const int PAPER_ID = 1;
        const int ROCK_ID = 2;
        const int SCISSORD_ID = 3;
        #endregion

        #region VariableData
        static int playerMove;
        static int enemyMove;
        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }
        private void paperImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            playerMoveImage.Source = paperIcon;
            playerMove = PAPER_ID;
            enemyMove = enemyMovement();
            if(enemyMove==ROCK_ID)
            {
                MessageBox.Show("You won");
            }
            else if(enemyMove==SCISSORD_ID)
            {
                MessageBox.Show("You loose");
            }
            else MessageBox.Show("Tie");
        }
        private void rockImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            playerMoveImage.Source = rockIcon;
            playerMove = ROCK_ID;
            enemyMove = enemyMovement();
            if (enemyMove == SCISSORD_ID)
            {
                MessageBox.Show("You won");
            }
            else if (enemyMove == PAPER_ID)
            {
                MessageBox.Show("You loose");
            }
            else MessageBox.Show("Tie");
        }
        private void scissorsImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            playerMoveImage.Source = scissorsIcon;
            playerMove = SCISSORD_ID;
            enemyMove = enemyMovement();
            if (enemyMove == PAPER_ID)
            {
                MessageBox.Show("You won");
            }
            else if (enemyMove == ROCK_ID)
            {
                MessageBox.Show("You loose");
            }
            else MessageBox.Show("Tie");
        }

        private int enemyMovement()
        {
            Random rand = new Random();
            int move = rand.Next(1, 4);
            if(move==PAPER_ID)
            {
                enemyMoveImage.Source = invertPaperIcon;
                return PAPER_ID;
            }
            else if(move==ROCK_ID)
            {
                enemyMoveImage.Source = invertRockIcon;
                return ROCK_ID;
            }
            else
            {
                enemyMoveImage.Source = invertScissorsIcon;
                return SCISSORD_ID;
            }
        }
    }
}
