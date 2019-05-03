# SentimentAnalyzer

Graphical User Interface (GUI) for Sentiment Analysis using VADER

**About**

This program performs sentiment analysis on a text using VADER (Valence Aware Dictionary and sEntiment Reasoner). It is a lexicon and rule-based approach, tuned specifically for sentiments expressed in social media.

More information on VADER can be found in the following paper:

	**VADER: A Parsimonious Rule-based Model for Sentiment Analysis of Social Media Text
	(by C.J. Hutto and Eric Gilbert)
	Eighth International Conference on Weblogs and Social Media (ICWSM-14). Ann Arbor, MI, June 2014.

Lexical approaches attempt to map words into *sentiments* by building a 'dictionary'.

Sentiments are sometimes grouped into categories like 'positive', 'neutral' accompanied by a numeric score signifying the intensity. Using the lexicon, scores for each word in the text are obtained and adjusted by applying special rules. Some rules adjust the score such as in the case of a *booster* word increasing/decreasing the sentiment score of another word (e.g. *somewhat* bad), or a group of words (e.g. idioms like *kiss of death*). This allows the analyzer to decide the overall sentiment expressed by the text.

One advantage of the lexical approach compared to machine learning is the fact that training a model (on pre-labelled data) is no longer required. Everything needed to assess the text is immediately available. However, the accuracy is limited by the size of the lexicon and the size of the rule set. Prediction using machine learning approaches, on the other hand, generally improve as the volume of data increases. Machine learning approaches also are able to generate more sophisticated mappings of words into sentiments without explicitly implementing the 'rules'.

VADER is open source and is implemented in several languages. For the original Python implementation by one of the authors, please take a look at the project's [GitHub repository](https://github.com/cjhutto/vaderSentiment)

A gentle introduction on VADER sentiment analysis can be found [here](http://datameetsmedia.com/vader-sentiment-analysis-explained/).

**Screenshots**

Shown below are some screenshots on the performance of this program. The graphic emoji is based on the *Compound* score. The threshold used is 0.05, i.e. Positive sentiment for Compound scores > 0.05, and Negative sentiment for Compound scores < -0.05. 

## Positive Sentiment

![Positive Sentiment](/Screenshots/PositiveSentiment.png)

pos: 0.706, neg: 0, neu: 0.294, compound: 0.9469

Punctuation emphasis, booster words, emphasis for ALLCAPS, are handled correctly (sentiment intensity adjusted). VADER appropriately adjusts intensity.

## Negative Sentiment

![Negative Sentiment](/Screenshots/NegativeSentiment.png)

pos: 0.094, neg: 0.327, neu: 0.579, compound: -0.7042

Negative sentence with contraction and qualified positive sentence handled correctly.

## Neutral Sentiments

![Neutral Sentiment](/Screenshots/NeutralSentiment.png)

pos: 0, neg: 0, neu: 1, compound: 0

*Funny*, apparently the exhilirating experience of first time programming is not a positive experience as some of us feel it is ;-)

## Mixed Sentiments

Mixed sentiments have positive and negative sentiment scores.

![Mixed Sentiment 1](/Screenshots/MixedSentiment1.png)

pos: 0.094, neg: 0.327, neu: 0.579, compound: -0.7042

This is the previous example of a negative sentiment. You will notice that there is a non-zero positive (*pos*) sentiment score but the overall sentiment is handle correctly (*compound*: -0.7042).

![Mixed Sentiment 2](/Screenshots/MixedSentiment2.png)

pos: 0.313, neg: 0.165, neu: 0.522, compound: 0.4561

