/*
Problem: Itinerary Conflict Detector

You are given a list of booked events for a single day, specified by a start and end time in 24-hour format. Your task is to determine if there are any overlapping events in the itinerary. An overlap occurs if an event starts before a previous event has ended.

Input Specification:
The first line will be an integer N (1 <= N <= 50), the number of events.
The next N lines will each contain an event's start and end time in the format `HH:MM-HH:MM`.

Output Specification:
Print `Conflict` if there is at least one overlap. Otherwise, print `No Conflict`.

Sample Input:
3
09:00-11:30
14:00-16:00
11:00-13:00

Sample Output:
Conflict
*/

// Your code here
