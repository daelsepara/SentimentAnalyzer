using Gtk;
using System;
using System.Globalization;
using System.IO;
using VaderSentimentAnalysis;

public partial class MainWindow : Gtk.Window
{
    FileChooserDialog TextLoader;

    Analyzer analyzer;

    public CultureInfo ci = new CultureInfo("en-US");

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        analyzer = new Analyzer("vader_lexicon.txt");

        Title = "Sentiment Analysis using VADER";

        TextLoader = new FileChooserDialog(
            "Load Text File",
            this,
            FileChooserAction.Open,
            "Cancel", ResponseType.Cancel,
            "Load", ResponseType.Accept
        );

        TextLoader.AddFilter(AddFilter("Text files (txt)", "*.txt"));
    }

    protected FileFilter AddFilter(string name, params string[] patterns)
    {
        var filter = new FileFilter { Name = name };

        foreach (var pattern in patterns)
            filter.AddPattern(pattern);

        return filter;
    }

    void HideImages()
    {
        SentimentImageHappy.Hide();
        SentimentImageNeutral.Hide();
        SentimentImageMad.Hide();
    }

    void ShowImage(double compound)
    {
        HideImages();

        if (compound > 0.05)
        {
            SentimentImageHappy.Show();
        }
        else if (compound < -0.05)
        {
            SentimentImageMad.Show();
        }
        else
        {
            SentimentImageNeutral.Show();
        }
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();

        a.RetVal = true;
    }

    protected void OnAnalyzeButtonClicked(object sender, EventArgs e)
    {
        var text = SentimentView.Buffer.Text.Trim();

        if (analyzer != null && !string.IsNullOrEmpty(text))
        {
            var scores = analyzer.GetSentimentScore(text);

            Negative.Text = string.Format("{0:0.000}", Convert.ToString(scores.Item1, ci));
            Neutral.Text = string.Format("{0:0.000}", Convert.ToString(scores.Item2, ci));
            Positive.Text = string.Format("{0:0.000}", Convert.ToString(scores.Item3, ci));
            Compound.Text = string.Format("{0:0.000}", Convert.ToString(scores.Item4, ci));

            ShowImage(scores.Item4);
        }
    }

    protected void OnLoadButtonClicked(object sender, EventArgs e)
    {
        // Add most recent directory
        if (!string.IsNullOrEmpty(TextLoader.Filename))
        {
            var directory = System.IO.Path.GetDirectoryName(TextLoader.Filename);

            if (Directory.Exists(directory))
            {
                TextLoader.SetCurrentFolder(directory);
            }
        }

        if (TextLoader.Run() == (int)ResponseType.Accept)
        {
            if (!string.IsNullOrEmpty(TextLoader.Filename))
            {
                if (File.Exists(TextLoader.Filename))
                {
                    var text = "";

                    using (TextReader reader = File.OpenText(TextLoader.Filename))
                    {
                        var count = 0;

                        string line;

                        while ((line = reader.ReadLine()) != null)
                        {
                            line = line.Trim();

                            text += count > 0 ? "\n" + line : line;

                            count++;
                        }
                    }

                    SentimentView.Buffer.Clear();

                    SentimentView.Buffer.Text = text.Trim();
                }
            }
        }

        TextLoader.Hide();
    }
}
