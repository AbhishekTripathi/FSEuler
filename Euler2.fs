//Each new term in the Fibonacci sequence is generated by adding the previous two terms. 
//By starting with 1 and 2, the first 10 terms will be:
//1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
//By considering the terms in the Fibonacci sequence whose values 
//do not exceed four million, find the sum of the even-valued terms.

let EvenFibSeqUntil limit =
    let before = ref 0
    let next = ref 1
    let temp = ref 0
    //let mutable fib = ref Seq.init
    seq {while !next < limit do
            let _ = temp := !next
            let _ = next := !before + !next
            let _ = before := !temp
            if !next % 2 = 0 then yield !next}

printfn "%d" (Seq.sum (EvenFibSeqUntil 4000000))


//attempt 2 using tail recursion
let EvenFibSeqUntil limit =
    let rec Fib before next =
        seq {
              if next < limit then
                let next' = before + next
                if(next' % 2 = 0) then yield next'
                yield! Fib next next'}
    Fib 0 1
  
printfn "%d" (Seq.sum (EvenFibSeqUntil 4000000))

//interesting found in sequence expression is that if the "if" block is replaced with a "while" block then the 
//code goes in infinite loop and the last value is repeatedly returned. The iteration never breaks. This is something
//not comming in C# because compiler complains of not all code paths returning a value.
