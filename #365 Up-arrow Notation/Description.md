[2018-07-09] Challenge #365 [Easy] Up-arrow Notation

Description
We were all taught addition, multiplication, and exponentiation in our early years of math.
 You can view addition as repeated succession. Similarly, you can view multiplication as repeated addition. And finally,
you can view exponentiation as repeated multiplication. But why stop there? Knuth's up-arrow notation takes this idea a step further.
The notation is used to represent repeated operations.

In this notation a single ↑ operator corresponds to iterated multiplication. For example:

2 ↑ 4 = ?
= 2 * (2 * (2 * 2))
= 2^4
= 16
While two ↑ operators correspond to iterated exponentiation. For example:

2 ↑↑ 4 = ?
= 2 ↑ (2 ↑ (2 ↑ 2))
= 2^2^2^2
= 65536
Consider how you would evaluate three ↑ operators. For example:

2 ↑↑↑ 3 = ?
= 2 ↑↑ (2 ↑↑ 2)
= 2 ↑↑ (2 ↑ 2)
= 2 ↑↑ (2 ^ 2)
= 2 ↑↑ 4
= 2 ↑ (2 ↑ (2 ↑ 2))
= 2 ^ 2 ^ 2 ^ 2
= 65536
In today's challenge, we are given an expression in Kuth's up-arrow notation to evalute.

5 ↑↑↑↑ 5
7 ↑↑↑↑↑ 3
-1 ↑↑↑ 3
1 ↑ 0
1 ↑↑ 0
12 ↑↑↑↑↑↑↑↑↑↑↑ 25
