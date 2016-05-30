using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Dobbelsteen
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Random object instantie.
        /// </summary>
        private Random _random = new Random();

        /// <summary>
        /// Houdt de tijd bij waarop op de knop werpButton is geklikt.
        /// </summary>
        private DateTime _startedAt;

        /// <summary>
        /// Willekeurige tijdsinterval waarop het gooien van de dobbelsteen moet stoppen.
        /// </summary>
        private int _willekeurigeTijd;

        /// <summary>
        /// Dit integer houdt de tijd bij van de 30 seconden countdown
        /// </summary>
        private int timeLeft;


        /// private Dobbellogica = new Dobbellogica();

        /// <summary>
        /// Lijst van dobbelsteen plaatjes (zie in Solution explorer: Dobbelsteen > Properties > Resources.resx.
        /// </summary>
        private Image[] _images = new Image[6]
        {
            Properties.Resources.dice1,
            Properties.Resources.dice2,
            Properties.Resources.dice3,
            Properties.Resources.dice4,
            Properties.Resources.dice5,
            Properties.Resources.dice6
        };

        /// <summary>
        /// Lijst van dobbelsteen geluiden.
        /// </summary>
        private Stream[] _sounds = new Stream[6]
        {
            Properties.Resources.dob1,
            Properties.Resources.dob2,
            Properties.Resources.dob3,
            Properties.Resources.dob4,
            Properties.Resources.dob5,
            Properties.Resources.dob6
        };

        /// <summary>
        /// Lijst van dobbelsteen geluiden.
        /// </summary>
        private Stream[] _soundsSONG = new Stream[6]
        {
            Properties.Resources._1___Arctic_Monkeys___No__1_Party_Anthem__short,
            Properties.Resources._2___Beyoncé__1_1,
            Properties.Resources._3___K3___1_2_3,
            Properties.Resources._4___don_omar_conteo,
            Properties.Resources._5_O_Clock_in_the_morning,
            Properties.Resources._6___Beyoncé___Drunk_in_Love
        };

        /// <summary>
        /// Lijst van opdrachten.
        /// </summary>
        private string[] _tasks = new string[6]
        {
            "Open vraag - zelf beantwoorden",
            "Begrippen - zelf omschrijven",
            "Gesloten vraag voor alle teams",
            "Kies een Begrip, een Open of een Gesloten vraag voor alle teams",
            "Begrippen - team omschrijft",
            "Kies een Begrip, een Open of een Gesloten vraag om zelf te doen"
        };

        /// <summary>
        /// Constructor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            InitializeGameUi();
        }

        /// <summary>
        /// Initialiseert de interface voor de game.
        /// </summary>
        private void InitializeGameUi()
        {
            var panelLocation = new Point(107, 47);
            GamePanel.Visible = false;
            GamePanel.Location = panelLocation;
            MainMenuPanel.Location = panelLocation;
            Size = new Size(716, 565);

            ShowScoreLabels(false);
            getal1PictureBox.Visible = false;
            ResultLabel.MaximumSize = new Size(460, 71);
            ResultLabel.AutoSize = true;
            timeLeft = 30;
            CountDownLabel.Visible = false;
            CountDownbutton.Visible = false;
            StopCountdown.Visible = false;
        }

        /// <summary>
        /// Werp button click event handler. Gaat af als op de button werpButton geklikt wordt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WerpButton_Click(object sender, EventArgs e)
        {
            _willekeurigeTijd = _random.Next(2000, 4000);
            _startedAt = DateTime.Now;

            Start();

            werpButton.Text = "Bezig...";
            werpButton.Enabled = false; // Schakel de button uit zolang de timer loopt

            timer1.Start();
        }

        private void Start()
        {
            IntroPic.Visible = false;
            IntroPic.SizeMode = PictureBoxSizeMode.StretchImage;
            getal1PictureBox.Visible = true;
            CountDownLabel.Visible = false;
            CountDownbutton.Visible = false;

            PlayAudioRollStart(); // Speel geluid beginnende rollende dobbelsteen af
            PlayAudioRolling(); // Speel geluid rollende dobbelsteen af in een loop
        }


        /// <summary>
        /// Speel de opgegeven audioclip af.
        /// </summary>
        /// <param name="audioClip"></param>
        private void PlayAudio(Stream audioClip)
        {
            // Maak een kopie van de audio stream om het meerdere
            // kereren tegelijk af te kunnen spelen
            audioClip.Position = 0;
            var audioClipCopy = new MemoryStream();
            audioClip.CopyTo(audioClipCopy);
            audioClipCopy.Position = 0;

            using (SoundPlayer player = new SoundPlayer(audioClipCopy))
            {
                player.Play();
            }
        }

        private void playaudio() // Speel geluid beginnende rollende dobbelsteen af
        {
            // Het geluid van een rollende dobbelsteen wordt afgespeeld
            SoundPlayer audio3 = new SoundPlayer(Dobbelsteen.Properties.Resources.rolling);
            audio3.Play();
        }

        private void PlayAudioRollStart() // Speel geluid beginnende rollende dobbelsteen af
        {
            // Het geluid van een rollende dobbelsteen wordt afgespeeld
            SoundPlayer audio3 = new SoundPlayer(Dobbelsteen.Properties.Resources.rolling);
            audio3.Play();
        }

        /// <summary>
        /// Speel de audio loop rolling af.
        /// </summary>
        /// <param name="clip"></param>
        private void PlayAudioRolling() // Speel geluid rollende dobbelsteen af in een loop
        {
            using (SoundPlayer player = new SoundPlayer(Properties.Resources.only_roll))
            {
                Properties.Resources.only_roll.Position = 0; // De leeskop voor wav-loop handmatig terugzetten op 0
                player.Stream = null;    // De stream verwijderen uit het geheugen
                player.Stream = Properties.Resources.only_roll;  // De wav verbinden aan audioroll
                player.PlayLooping();          // Speel de clip af (deja vu?)
            }
        }

        private void playaudiorollstop() // Speel geluid volledig rollende dobbelsteen af
        {
            // Het geluid van een rollende dobbelsteen wordt afgespeeld
            SoundPlayer audio2 = new SoundPlayer(Properties.Resources.long_roll);
            audio2.Play();
        }

        /// <summary>
        /// Speel foutmelding geluidje af.
        /// </summary>
        private void PlayAudioError() // Speel geluid Fout (Error) af
        {
            // Het Fout-geluid wordt afgespeeld
            PlayAudio(Properties.Resources.error);
        }

        /// <summary>
        /// Werk de PictureBox van de dobbelsteen met een willekeurig nieuw plaatje.
        /// </summary>
        private void ThrowDice() // Genereert een willekeurig plaatje uit de images array
        {
            getal1PictureBox.Image = _images[_random.Next(0, 6)];

        }

        /// <summary>
        /// Timer tick interval event handler. Gaat af elke keer als de interval van de timer voorbij is. 
        /// Stopt de timer nadat willekeurigeTijd verstreken is.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {

            ThrowDice();

            var delta = DateTime.Now - _startedAt;
            if (delta.TotalMilliseconds >= _willekeurigeTijd)
            {
                RollEnded();
            }
        }

        /// <summary>
        /// Dit werkt de afhandeling af van de worp
        /// </summary>
        private void RollEnded()
        {
            // Stop de timer.
            timer1.Stop();

            // Stop het rollende geluid en laat de dobbelsteen uitrollen.
            playaudiorollstop();

            EvaluateResult();


            // Herstel de button zodat de dobbelsteen opnieuw geworpen kan worden.
            werpButton.Text = "Werp dobbelsteen!";
            werpButton.Enabled = true;
        }

        /// <summary>
        /// Evalueer het resultaat van de worp.
        /// </summary>
        private void EvaluateResult()
        {
            ShowScoreLabels(true);
            var index = Array.IndexOf(_images, getal1PictureBox.Image);
            var score = index + 1;

            if (index == -1)
            {
                PlayAudioError();
                MessageBox.Show("Sorry, er gebeurde iets onverwachts", "Je gooide veels te hard!");
                return;
            }

            PlayAudio(_soundsSONG[index]);
            ScoreLabel.Text = "Jouw worp was " + score;
            ResultLabel.Text = _tasks[index];

            CountDownReady();
        }

        /// <summary>
        /// Toont of verbergt de score labels op basis van de opgeven staat.
        /// </summary>
        /// <param name="state"></param>
        private void ShowScoreLabels(bool state)
        {
            ResultLabel.Visible = state;
            ScoreLabel.Visible = state;
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MainMenuPanel.Visible = true;
            GamePanel.Visible = false;
        }

        private void StartGame()
        {
            MainMenuPanel.Visible = false;
            GamePanel.Visible = true;
        }

        private void EndGame()
        {
            MainMenuPanel.Visible = true;
            GamePanel.Visible = false;
        }

        /// <summary>
        /// Maakt de CountDown-teller + -knop zichtbaar
        /// </summary>
        private void CountDownReady()
        {
            CountDownLabel.Text = "30 ";
            CountDownLabel.Visible = true;
            CountDownbutton.Visible = true;
            CountDownbutton.Text = "Start de Klok!";
        }

        /// <summary>
        /// Na klikken op de Countdownbutton wordt de Werpbutton uitgeschakeld.
        /// De StopCountDownknop wordt zichtbaar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountDownbutton_Click(object sender, EventArgs e)
        {
            CountDownReady();

            werpButton.Enabled = false;
            timeLeft = 29;
            CountDownTimer.Start();

            CountDownbutton.Visible = false;
            StopCountdown.Visible = true;
        }

        /// <summary>
        /// Elke seconde wordt het beeld ververst met de hoeveelheid tijd die er nog over is.
        /// Het geluid van een tikkende klok loopt mee.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountDownTimer_Tick(object sender, EventArgs e)
        {
            PlayAudio(Properties.Resources.clock);
            CountDownLabel.Text = timeLeft + "";
            timeLeft = timeLeft - 1;

            if (timeLeft <10)
            {
                CountDownLabel.ForeColor = System.Drawing.Color.Red;
            }

            if (timeLeft == -1)
            {
                ResetCounter();
                ResultLabel.Text = "De tijd is om!";
                PlayAudio(Properties.Resources.BimBam);
            }
        }

        /// <summary>
        /// Stopt de CountDown. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StopCountdown_Click(object sender, EventArgs e)
        {
            ResetCounter();
        }

        private void ResetCounter()
        {
            CountDownTimer.Stop();
            CountDownbutton.Visible = true;
            CountDownbutton.Text = "Herstarten?";
            StopCountdown.Visible = false;
            werpButton.Enabled = true;
        }


    }
}
