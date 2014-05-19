//Largest prime factor
//Problem 3
//The prime factors of 13195 are 5, 7, 13 and 29.
//What is the largest prime factor of the number 600851475143 ?


let FindPrimeFactor (number:float) =
    let factors = [2.0 .. (Math.Ceiling(Math.Sqrt(number)))] |> List.filter(function|x -> number % x = 0.0)
    let nonPrimes = ref [0.0]
    let ShouldAdd (s:float) = !nonPrimes |> (function |h::_ -> h <> s |_ -> false)
    List.iter(fun (s:float)-> 
        List.iter(fun x-> if (s > x && s % x = 0.0 && (ShouldAdd s))
                             then nonPrimes := s :: !nonPrimes) factors) 
                             factors |> ignore
    let primes = System.Linq.Enumerable.Except(factors,!nonPrimes)
    Seq.filter(fun x-> number % x = 0.0) primes |> Seq.max
  
FindPrimeFactor 13195.00
FindPrimeFactor 600851475143.00

// Above solution is probably not the best example of the power of F#. It is more imperative and dirty. I am still 
//not able to think in functional terms yet. Mutable variables should be avoided and replaced with recursive functions.
//Nevertheless, the solution works and for the larger problem the answer is obtained in around 200ms.
