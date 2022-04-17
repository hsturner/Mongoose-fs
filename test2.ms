# mongoose program testing boolean operators (the demorgan laws)
(!(1 || 0) == (!1 && !0)) && (!(1 && 1) == (!0 || !0))
# should eval to 1 (true)
