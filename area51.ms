# Save your planet by implementing the right kind of scoping rule.

let pi = 314159: 
let area = (lambda r.pi*r*r):
let pi = 1:
let composite = (area 51):
let quotient = composite/100000:
let remainder = composite%100000:
(
  cout "\nAccording to your planet's best minds, Area 51 is ";
  cout quotient;
  cout ".";
  cout remainder;
  cout "\n";
  (if (!(quotient==8171)) (cout "Your planet is doomed\n")
  else (cout "Your planet is safe for now\n"));
)
