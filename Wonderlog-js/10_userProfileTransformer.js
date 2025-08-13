/*
Problem: Data Migration: User Profile Transformer

Migrate user data from an old format to a new one.
Old format: `id,email,firstName,lastName`
New format: `LastName, FirstName (email) - ID: id`

Input Specification:
The first line is an integer N (1 <= N <= 50).
The next N lines contain user data in the old format.

Output Specification:
For each user, print their data in the new format, one user per line, sorted by last name alphabetically.

Sample Input:
2
101,pete@wanderlog.com,Peter,Pan
202,harry@wanderlog.com,Harry,Potter

Sample Output:
Pan, Peter (pete@wanderlog.com) - ID: 101
Potter, Harry (harry@wanderlog.com) - ID: 202
*/

// Your code here
