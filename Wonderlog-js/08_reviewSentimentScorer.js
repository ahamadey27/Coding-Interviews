/*
Problem: Review Sentiment Scorer

Calculate a sentiment score for each review. The score is calculated as follows: `+1` for each occurrence of the word "great", "amazing", or "love", and `-1` for each occurrence of "bad", "terrible", or "poor". The check is case-insensitive.

Input Specification:
The first line is an integer N (1 <= N <= 10), the number of reviews.
The next N lines each contain a single review as a sentence.

Output Specification:
For each review, print its sentiment score on a new line.

Sample Input:
3
What a great trip, I love Paris!
The hotel was terrible. Very bad service.
The food was good, not amazing but not bad.

Sample Output:
2
-2
-1
*/

// Your code here
