import nltk
from nltk import sent_tokenize
from nltk import word_tokenize
from nltk.stem import PorterStemmer

stemmer = PorterStemmer()
word_list = ['Study','Studying','Studies','Studied']
for w in word_list:
   print(stemmer.stem(w))

text_file = 'C:/Users/Oozwal/Desktop/Natural_Language_Processing_Text.txt'
with open(text_file, 'r') as file:
  content = file.read()
  word_count = len(content)
  print(content)
  print('Word Count: ',word_count)
  print('\n')
  sentences = sent_tokenize(content)
  print(sentences)
#   for sentence in sentences:
#      print(sentence)
  tokens = word_tokenize(content)
  stemmed_tokens = [stemmer.stem(token) for token in tokens]
  
  stemmed_text = ' '.join(stemmed_tokens)
  print(stemmed_text)