
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed LayoutMain;

	private global::Gtk.Label LabelMain;

	private global::Gtk.Button AnalyzeButton;

	private global::Gtk.Button LoadButton;

	private global::Gtk.Label LabelScores;

	private global::Gtk.Label LabelPositive;

	private global::Gtk.Entry Positive;

	private global::Gtk.Label LabelNegative;

	private global::Gtk.Entry Negative;

	private global::Gtk.Label LabelNeutral;

	private global::Gtk.Entry Neutral;

	private global::Gtk.Label LabelCompound;

	private global::Gtk.Entry Compound;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView SentimentView;

	private global::Gtk.Image SentimentImageHappy;

	private global::Gtk.Image SentimentImageNeutral;

	private global::Gtk.Image SentimentImageMad;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.WidthRequest = 640;
		this.HeightRequest = 480;
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.Icon = global::Gdk.Pixbuf.LoadFromResource("SentimentAnalyzer.heartbeat.png");
		this.WindowPosition = ((global::Gtk.WindowPosition)(3));
		this.Resizable = false;
		this.AllowGrow = false;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.LayoutMain = new global::Gtk.Fixed();
		this.LayoutMain.Name = "LayoutMain";
		this.LayoutMain.HasWindow = false;
		// Container child LayoutMain.Gtk.Fixed+FixedChild
		this.LabelMain = new global::Gtk.Label();
		this.LabelMain.Name = "LabelMain";
		this.LabelMain.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Sentiment Analyzer</b>");
		this.LabelMain.UseMarkup = true;
		this.LayoutMain.Add(this.LabelMain);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.LayoutMain[this.LabelMain]));
		w1.X = 30;
		w1.Y = 30;
		// Container child LayoutMain.Gtk.Fixed+FixedChild
		this.AnalyzeButton = new global::Gtk.Button();
		this.AnalyzeButton.Name = "AnalyzeButton";
		this.AnalyzeButton.UseUnderline = true;
		this.AnalyzeButton.FocusOnClick = false;
		this.AnalyzeButton.Label = global::Mono.Unix.Catalog.GetString("analyze text");
		this.LayoutMain.Add(this.AnalyzeButton);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.LayoutMain[this.AnalyzeButton]));
		w2.X = 30;
		w2.Y = 420;
		// Container child LayoutMain.Gtk.Fixed+FixedChild
		this.LoadButton = new global::Gtk.Button();
		this.LoadButton.Name = "LoadButton";
		this.LoadButton.UseUnderline = true;
		this.LoadButton.Label = global::Mono.Unix.Catalog.GetString("load text from file");
		this.LayoutMain.Add(this.LoadButton);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.LayoutMain[this.LoadButton]));
		w3.X = 130;
		w3.Y = 420;
		// Container child LayoutMain.Gtk.Fixed+FixedChild
		this.LabelScores = new global::Gtk.Label();
		this.LabelScores.Name = "LabelScores";
		this.LabelScores.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Scores</b>");
		this.LabelScores.UseMarkup = true;
		this.LayoutMain.Add(this.LabelScores);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.LayoutMain[this.LabelScores]));
		w4.X = 450;
		w4.Y = 60;
		// Container child LayoutMain.Gtk.Fixed+FixedChild
		this.LabelPositive = new global::Gtk.Label();
		this.LabelPositive.Name = "LabelPositive";
		this.LabelPositive.LabelProp = global::Mono.Unix.Catalog.GetString("Positive");
		this.LayoutMain.Add(this.LabelPositive);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.LayoutMain[this.LabelPositive]));
		w5.X = 450;
		w5.Y = 90;
		// Container child LayoutMain.Gtk.Fixed+FixedChild
		this.Positive = new global::Gtk.Entry();
		this.Positive.WidthRequest = 130;
		this.Positive.Name = "Positive";
		this.Positive.IsEditable = false;
		this.Positive.InvisibleChar = '•';
		this.LayoutMain.Add(this.Positive);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.LayoutMain[this.Positive]));
		w6.X = 450;
		w6.Y = 110;
		// Container child LayoutMain.Gtk.Fixed+FixedChild
		this.LabelNegative = new global::Gtk.Label();
		this.LabelNegative.Name = "LabelNegative";
		this.LabelNegative.LabelProp = global::Mono.Unix.Catalog.GetString("Negative");
		this.LayoutMain.Add(this.LabelNegative);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.LayoutMain[this.LabelNegative]));
		w7.X = 450;
		w7.Y = 150;
		// Container child LayoutMain.Gtk.Fixed+FixedChild
		this.Negative = new global::Gtk.Entry();
		this.Negative.WidthRequest = 130;
		this.Negative.Name = "Negative";
		this.Negative.IsEditable = false;
		this.Negative.InvisibleChar = '•';
		this.LayoutMain.Add(this.Negative);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.LayoutMain[this.Negative]));
		w8.X = 450;
		w8.Y = 170;
		// Container child LayoutMain.Gtk.Fixed+FixedChild
		this.LabelNeutral = new global::Gtk.Label();
		this.LabelNeutral.Name = "LabelNeutral";
		this.LabelNeutral.LabelProp = global::Mono.Unix.Catalog.GetString("Neutral");
		this.LayoutMain.Add(this.LabelNeutral);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.LayoutMain[this.LabelNeutral]));
		w9.X = 450;
		w9.Y = 210;
		// Container child LayoutMain.Gtk.Fixed+FixedChild
		this.Neutral = new global::Gtk.Entry();
		this.Neutral.WidthRequest = 130;
		this.Neutral.Name = "Neutral";
		this.Neutral.IsEditable = false;
		this.Neutral.InvisibleChar = '•';
		this.LayoutMain.Add(this.Neutral);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.LayoutMain[this.Neutral]));
		w10.X = 450;
		w10.Y = 230;
		// Container child LayoutMain.Gtk.Fixed+FixedChild
		this.LabelCompound = new global::Gtk.Label();
		this.LabelCompound.Name = "LabelCompound";
		this.LabelCompound.LabelProp = global::Mono.Unix.Catalog.GetString("Compound");
		this.LayoutMain.Add(this.LabelCompound);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.LayoutMain[this.LabelCompound]));
		w11.X = 450;
		w11.Y = 270;
		// Container child LayoutMain.Gtk.Fixed+FixedChild
		this.Compound = new global::Gtk.Entry();
		this.Compound.WidthRequest = 130;
		this.Compound.Name = "Compound";
		this.Compound.IsEditable = false;
		this.Compound.InvisibleChar = '•';
		this.LayoutMain.Add(this.Compound);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.LayoutMain[this.Compound]));
		w12.X = 450;
		w12.Y = 290;
		// Container child LayoutMain.Gtk.Fixed+FixedChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.WidthRequest = 400;
		this.GtkScrolledWindow.HeightRequest = 350;
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.SentimentView = new global::Gtk.TextView();
		this.SentimentView.CanFocus = true;
		this.SentimentView.Name = "SentimentView";
		this.SentimentView.WrapMode = ((global::Gtk.WrapMode)(2));
		this.GtkScrolledWindow.Add(this.SentimentView);
		this.LayoutMain.Add(this.GtkScrolledWindow);
		global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.LayoutMain[this.GtkScrolledWindow]));
		w14.X = 30;
		w14.Y = 60;
		// Container child LayoutMain.Gtk.Fixed+FixedChild
		this.SentimentImageHappy = new global::Gtk.Image();
		this.SentimentImageHappy.WidthRequest = 64;
		this.SentimentImageHappy.HeightRequest = 64;
		this.SentimentImageHappy.Name = "SentimentImageHappy";
		this.SentimentImageHappy.Pixbuf = global::Gdk.Pixbuf.LoadFromResource("SentimentAnalyzer.happy.png");
		this.LayoutMain.Add(this.SentimentImageHappy);
		global::Gtk.Fixed.FixedChild w15 = ((global::Gtk.Fixed.FixedChild)(this.LayoutMain[this.SentimentImageHappy]));
		w15.X = 480;
		w15.Y = 340;
		// Container child LayoutMain.Gtk.Fixed+FixedChild
		this.SentimentImageNeutral = new global::Gtk.Image();
		this.SentimentImageNeutral.WidthRequest = 64;
		this.SentimentImageNeutral.HeightRequest = 64;
		this.SentimentImageNeutral.Name = "SentimentImageNeutral";
		this.SentimentImageNeutral.Pixbuf = global::Gdk.Pixbuf.LoadFromResource("SentimentAnalyzer.neutral.png");
		this.LayoutMain.Add(this.SentimentImageNeutral);
		global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.LayoutMain[this.SentimentImageNeutral]));
		w16.X = 480;
		w16.Y = 340;
		// Container child LayoutMain.Gtk.Fixed+FixedChild
		this.SentimentImageMad = new global::Gtk.Image();
		this.SentimentImageMad.WidthRequest = 64;
		this.SentimentImageMad.HeightRequest = 64;
		this.SentimentImageMad.Name = "SentimentImageMad";
		this.SentimentImageMad.Pixbuf = global::Gdk.Pixbuf.LoadFromResource("SentimentAnalyzer.mad.png");
		this.LayoutMain.Add(this.SentimentImageMad);
		global::Gtk.Fixed.FixedChild w17 = ((global::Gtk.Fixed.FixedChild)(this.LayoutMain[this.SentimentImageMad]));
		w17.X = 480;
		w17.Y = 340;
		this.Add(this.LayoutMain);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 640;
		this.DefaultHeight = 480;
		this.SentimentImageHappy.Hide();
		this.SentimentImageNeutral.Hide();
		this.SentimentImageMad.Hide();
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.AnalyzeButton.Clicked += new global::System.EventHandler(this.OnAnalyzeButtonClicked);
		this.LoadButton.Clicked += new global::System.EventHandler(this.OnLoadButtonClicked);
	}
}
