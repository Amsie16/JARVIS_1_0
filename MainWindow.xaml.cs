using System.Windows;
using System.Diagnostics;

namespace JARVIS_1_0
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public class ChatMessage
        {
            public string Speaker { get; set; }
            public string Text { get; set; }
            public bool IsUser { get; set; }

            public ChatMessage(string speaker, string text, bool isUser)
            {
                Speaker = speaker;
                Text = text;
                IsUser = isUser;
            }
        }
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string text = InputBox.Text.Trim();

            if (text == "")
            {
                return;
            }

            ChatList.Items.Add(new ChatMessage("DU", text, true));

            string eingabe = text.ToLower();
            string antwort = "";

            if (eingabe.Contains("hallo") || eingabe.Contains("hi") || eingabe.Contains("hey"))
            {
                antwort = "Guten Tag, Sir. Wie kann ich ihnen helfen?";
            }
            else if (eingabe.Contains("öffne") && eingabe.Contains("notepad"))
            { 
                Process.Start(new ProcessStartInfo
                {
                    FileName = "notepad.exe",
                    UseShellExecute = true
                });
                antwort = "Natürlich, Sir. Ich öffne Notepad.";
            }

            else if (eingabe.Contains("öffne") && eingabe.Contains("rechner"))
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "calc.exe",
                        UseShellExecute = true
                    });

                    antwort = "Natürlich, Sir. Ich öffne den Rechner.";
                }

            else if (eingabe.Contains("öffne") && eingabe.Contains("opera"))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "opera.exe",
                    UseShellExecute = true
                });
                antwort = "Natürlich, Sir. Ich öffne Opera.";
            }

            else if (eingabe.Contains("wie geht es dir"))
            {
                antwort = "Alle Systeme laufen einwandfrei, Sir.";
            }
            else if (eingabe.Contains("wie spät ist es") || eingabe.Contains("wie viel uhr ist es"))
            {
                antwort = "Es ist " + DateTime.Now.ToString("HH:mm") + ", Sir.";
            }
            else if (eingabe.Contains("was ist das datum") || eingabe.Contains("welches datum haben wir"))
            {
                antwort = "Heute ist der " + DateTime.Now.ToString("dd.MM.yyyy") + ", Sir.";
            }
            else if (eingabe.Contains("wie heißt du?") || eingabe.Contains("wie ist dein name?"))
            {
                antwort = "Mein Name ist J.A.R.V.I.S., Sir.";
            }
            else if (eingabe.Contains("danke"))
            {
                antwort = "Gern geschehen, Sir.";
            }
            else
            {
                antwort = "Das habe ich leider noch nicht gelernt, Sir.";
            }

            ChatList.Items.Add(new ChatMessage("J.A.R.V.I.S.", antwort, false));
            
            ChatList.ScrollIntoView(
            ChatList.Items[ChatList.Items.Count - 1]);

            InputBox.Clear();

            InputBox.Focus();
        }
        }
}