# Codility-CountTriangles
An array A consisting of N integers is given.</br>
A triplet (P, Q, R) is triangular if it is possible to build a triangle with sides of lengths A[P], A[Q] and A[R].</br>
In other words, triplet (P, Q, R) is triangular if 0 ≤ P < Q < R < N and:</br>
A[P] + A[Q] > A[R],</br>
A[Q] + A[R] > A[P],</br>
A[R] + A[P] > A[Q].

For example, consider array A such that:</br>
A[0] = 10    A[1] = 2    A[2] = 5</br>
A[3] = 1     A[4] = 8    A[5] = 12</br>
There are four triangular triplets that can be constructed from elements of this array,</br> 
namely (0, 2, 4), (0, 2, 5), (0, 4, 5), and (2, 4, 5).

Write a function:</br>
class Solution { public int solution(int[] A); }</br>
that, given an array A consisting of N integers, returns the number of triangular triplets in this array.

For example, given array A such that:</br>
A[0] = 10    A[1] = 2    A[2] = 5</br>
A[3] = 1     A[4] = 8    A[5] = 12</br>
the function should return 4, as explained above.

Write an efficient algorithm for the following assumptions:</br>
N is an integer within the range [0..1,000];</br>
each element of array A is an integer within the range [1..1,000,000,000].
