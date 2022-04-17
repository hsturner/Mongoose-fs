module CSC7B  // at the very top
open CSC7B;

let base_eval = eval
eval <- fun env exp -> 
  match exp with
    | Binop("<",a,b) -> if eval env (Binop("-",b,a)) > 0 then 1 else 0 //I think this is correct
  //  | Binop ("<",a,b) -> if (eval env b) - (eval env b) > 0 then 1 else 0 
    | Binop("==",a,b) -> if eval env (Binop("-",a,b)) = 0 then 1 else 0 //if a-b = 0 true 
    //| Binop("<=",a,b) -> if ((eval env (Binop("<",a,b))) + (eval env (Binop("==",a,b))) >=1 ) then 1 else 0 //at least one has to evaluate to true
    | Binop("<=",a,b) -> (eval env (Binop("||",Binop("<",a,b),Binop("==",a,b)))) //true if less than OR equal 
    | Binop("||",a,b) -> (eval env (Uniop("!",Uniop("!",a)))) + (eval env (Uniop("!",Uniop("!",b))))//will evalaute to zero (false) or >0 (True)
    | Binop("&&",a,b) -> abs(eval env (Binop("*",a,b)))//will be 0 if either expr = 0
    | Uniop("!",a) -> if eval env a  = 0 then 1 else 0  //if true, produces a value >= 1 
    | Ifelse(a,b,c) -> if (eval env a) > 0 then (eval env b) else (eval env c) //if else
    //| Letexp(a,b,c) -> //
    | _ -> base_eval env exp;;





//runit(); // or traceopt(true,false,runit); at the very bottom
traceopt(true,false,runit);;  



(*
    for a let call: 
        check if it exists in the evironemnt
            if yes -> illegal binding
            if no -> create new binding


*)


(*RUNTIME SEQUENCE

traceopt() determines whether parse and eval are traced before and after, can call runit() to execute main command
runit() function Gets command line arguments for trace, error handling, cbn vs cbv
runit() calls interpret function, along with modifications for error handling etc.
interpret function parses 
Dislay result of eval as a string






*)


(*

environ = closure formed by a string composed with a val ref
// use environments of the form [("x",ref Val(0));("y",ref Val(0))] ...


var = variables that are an alphanumeric string
when variables are encountered by the eval function, use the lookup function to match the var with
its val ref within the environ

so to do a lookup

pass the variable in question, pass the environment, and look within environment for the string to 
find the associated val --> deref val and return 

lookup matches a variable with an expression

lookupval() calls lookup() to get an expression and then returns the integer value
    if the expr is of type Val(n)

    ex.

    env = [("abs",ref Val(1))]   --> let x = 1 

    lookup abs env
        searches env for the string "abs" --> FOUND! --> deref Val(1), return expr = Val(1)

    lookupval "abs" env
        v = above function call --> v= Val(1)
        if v = Val(n) -> return n --> SO,,,this will return 1



so eval function evaluates the results of a parse
    when it encounters a Var(s) which is a variable
        performs a lookup to find the expr associated with the variable --> evalauates the resulting expression


so eval always needs the env in order to perform potential lookups 










val = integer values


let expressions, expressions with variables, 'Assign'
expressions (destructive assignment to declared variables), sequence
expression (case Seq in the abstract syntax) and while-loops.





Let symbol, var(x), Sym(=), e1, sym(:), e2

 = letexp(x,e1,e2)



 to evaluate this, i have to add to env variable
    check if value already exists -> if it exists, 



*)


