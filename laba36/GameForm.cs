using System.Diagnostics.Metrics;
using System.Windows.Forms;

namespace laba36
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            GameCycleTimer.Interval = 10;
        }
        Bitmap _ballskin = new Bitmap(16, 16);
        int _defaultxspeed = 3;
        int _defaultyspeed = -1;
        int _ballspeedx;
        int _ballspeedy;
        int _score = 0;
        int _lives = 3;

        private void GameForm_Load(object sender, EventArgs e)
        {
            InformationToolStripMenuItem.Text = "Очки: " + _score + " Жизни: " + _lives;
            SetSpeed();
            Graphics graphicsball = Graphics.FromImage(_ballskin);
            SolidBrush brush = new SolidBrush(Color.WhiteSmoke);
            Random rand = new Random();
            graphicsball.FillEllipse(brush, 0, 0, 16, 16);
            Size bricksize = new Size(59, 20);
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Brick brick = new Brick();
                    brick.Size = bricksize;
                    brick.Location = new Point(10 + i * (brick.Width + 30), j * (brick.Height + 10));

                    switch (j)
                    {
                        case 1:
                            brick.BackColor = Color.Blue;
                            break;
                        case 2:
                            brick.BackColor = Color.Red;
                            break;
                        case 3:
                            brick.BackColor = Color.HotPink;
                            break;
                        case 4:
                            brick.BackColor = Color.Yellow;
                            break;
                    }
                    GamePanel.Controls.Add(brick);
                }
            }
            playerball.BackgroundImage = _ballskin;
            int randx = rand.Next(200, 600);
            playerball.Location = new Point(randx, playerball.Location.Y);
        }

        private void SetSpeed()
        {
            Random rand = new Random();
            _ballspeedy = _defaultyspeed;
            if (rand.Next(0, 2) == 1)
            {
                _ballspeedx = -_defaultxspeed;
            }
            else
            {
                _ballspeedx = _defaultxspeed;
            }

        }

        private void GameCycleTimer_Tick(object sender, EventArgs e)
        {
            if (_score == 40)
            {
                GameCycleTimer.Stop();
                MessageBox.Show("Вы победили", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (_lives <= 0)
            {
                GameCycleTimer.Stop();
                MessageBox.Show("Вы проиграли", "Поражение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            int racketCenterX = playerracket.Width / 2;
            if (Cursor.Position.X > racketCenterX && Cursor.Position.X < this.ClientSize.Width - racketCenterX)
            {
                playerracket.Location = new Point(Cursor.Position.X - racketCenterX, playerracket.Top);
            }
            Point ballpoint = new Point(playerball.Location.X + _ballspeedx, playerball.Location.Y + _ballspeedy);
            playerball.Location = ballpoint;
            InformationToolStripMenuItem.Text = "Очки: " + _score + " Жизни: " + _lives;
            Rectangle ballRectangle = playerball.Bounds;
            for (int i = this.GamePanel.Controls.Count - 1; i >= 0; i--)
            {
                Control item = this.GamePanel.Controls[i];
                if (item is Brick && item != playerball && item != playerracket)
                {

                    if (ballRectangle.IntersectsWith(item.Bounds))
                    {
                        ballRectangle.Intersect(item.Bounds);
                        if (ballRectangle.Height < ballRectangle.Width)
                        {
                            _ballspeedy = -_ballspeedy;
                        }
                        else
                        {
                            _ballspeedx = -_ballspeedx;
                        }
                        this.GamePanel.Controls.RemoveAt(i);
                        _score++;
                    }
                }
                if (item is Racket)
                {
                    if (ballRectangle.IntersectsWith(item.Bounds))
                    {
                        ballRectangle.Intersect(item.Bounds);
                        if (ballRectangle.Height < ballRectangle.Width)
                        {
                            _ballspeedy = -_ballspeedy;
                        }
                        else
                        {
                            _ballspeedx = -_ballspeedx;
                        }
                    }
                }

            }
            if (playerball.Location.X > GamePanel.Width - 16 || playerball.Location.X < 0)
            {
                _ballspeedx = -_ballspeedx;
            }

            if (playerball.Location.Y > GamePanel.Height)
            {
                _lives--;
                Random rand = new Random();
                int randx = rand.Next(200, 700);
                playerball.Location = new Point(randx, 370);
                SetSpeed();
            }
            if (playerball.Location.Y < 0)
            {
                _ballspeedy = -_ballspeedy;
            }
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (_lives <= 0 || _score == 40)
            {
                return;
            }
            if (e.KeyCode == Keys.Space)
            {
                if (GameCycleTimer.Enabled == true)
                {
                    GameCycleTimer.Stop();
                    StopLabel.Text = "Пауза";
                }
                else
                {
                    GameCycleTimer.Start();
                    StopLabel.Text = "";
                }
            }
        }

        
    }
}
