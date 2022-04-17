# This program should return the final b calculated inside the while loop
# That is, the value of a sequence (expressions separated by ;) is the value 
# of the last expression in the sequence.  The value of a while loop is the
# value of the last iteration of the loop.

let n = 11:
let a = 0:
let b = 1:
while (0 < n-1)
 (
   b = a+b;
   a = b-a;
   n = n-1;
   b;
 )
# this program calculates the nth Fibonacci number
